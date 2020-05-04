using DataLayer;
using MoneyBin2.Properties;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.Entity.Core.EntityClient;
using System.Data.OleDb;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace MoneyBin2 {
    public partial class frmConfig : Form {

        private string ConnName => comboBoxStrings.SelectedItem.ToString();
        private bool IsConnEntity => ConnName.EndsWith("Entities");
        private bool IsConnADO => ConnName.EndsWith("ADO");
        private bool IsConnServer => IsConnEntity || IsConnADO;

        public frmConfig() {
            InitializeComponent();
            using (var ctx = new MoneyBinEntities()) {
                comboBoxContaPadrao.DataSource = ctx.Contas.OrderBy(c => c.Apelido).ToList();
                comboBoxContaPadrao.ValueMember = "ID";
                comboBoxContaPadrao.DisplayMember = "Apelido";
            }
            comboBoxContaPadrao.SelectedIndex = Settings.Default.BalanceContaPadrao;
            radioButtonBalanceContaPadrao.Checked = Settings.Default.BalanceUsarContaPadrao;
            labelCalendarioPastaPagamentos.Text = Settings.Default.CalendarioPastaPagamentos;
            checkBoxBackgroundVisivel.Checked = Settings.Default.MainBackgroundVisivel;
            checkBoxBackgroundRodizio.Checked = Settings.Default.MainBackgroundRodizio;
            checkBoxBarraFerramentasVisivel.Checked = Settings.Default.MainBarraFerramentasVisivel;
            checkBoxBarraFerramentasImagemeTexto.Checked = Settings.Default.MainBarraFerramentasImagem;
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e) {
            if (e.TabPageIndex == 0 || listBoxSQLServers.Items.Count > 0) {
                return;
            }
            tabControl1.Visible = false;

            try {
                Thread threadInput = new Thread(EncontrarServidores);
                threadInput.Start();
            }
            catch (Exception ex) {
                MessageBox.Show("The below error occurred while processing the request: \n\r \n\r" + ex.Message);
            }

            tabControl1.Visible = true;

            var connNames = ConfigurationManager.ConnectionStrings
                .Cast<ConnectionStringSettings>()
                .Where(i => i.Name != "LocalSqlServer")
                .Select(i => i.Name)
                .OrderBy(i => i)
                .ToArray();
            comboBoxStrings.Items.AddRange(connNames);
            comboBoxStrings.SelectedIndex = 0;
            buttonSaveDatabase.Enabled = false;
        }

        private void EncontrarServidores() {
            var frm = PleaseWaitDisplay("Procurando servidores SQL. Aguarde...", Resources.FindServer1);

            var servidores = GetSQLInstances();

            this.Invoke((MethodInvoker)delegate {
                listBoxSQLServers.Items.AddRange(servidores);
            });

            PleaseWaitClose(frm);
        }

        private Form PleaseWaitDisplay(string message, Bitmap image = null) {
            var frm = new frmPleaseWait { labelMessage = { Text = message } };
            if(image != null) frm.picture.Image = image;
            this.Invoke((MethodInvoker)delegate {
                this.Cursor = Cursors.WaitCursor;
                frm.Show();
            });
            return frm;
        }

        private void PleaseWaitClose(Form frm) {
            this.Invoke((MethodInvoker)delegate {
                frm.Close();
                this.Cursor = Cursors.Default;
            });
        }

        #region DATABASE ------------------------------------
        private void comboBoxStrings_SelectedIndexChanged(object sender, EventArgs e) {
            AskIfSave();
            var str = ConfigurationManager.ConnectionStrings[ConnName].ToString();
            textBoxString.Text = str;

            if (IsConnEntity) {
                propertyGridConn.SelectedObject = new EntityConnectionStringBuilder(str);
                listBoxSQLServers.SelectedIndex = listBoxSQLServers.Items.IndexOf(EntityDataSource());
            }
            else if (IsConnADO) {
                var csb = new SqlConnectionStringBuilder(str);
                propertyGridConn.SelectedObject = csb;
                var ds = csb.DataSource;
                listBoxSQLServers.SelectedIndex = listBoxSQLServers.Items.IndexOf(ds);
            }
            else {
                propertyGridConn.SelectedObject = new OleDbConnectionStringBuilder(str);
            }
            buttonTestConnection.Enabled = IsConnServer;
            listBoxSQLServers.Enabled = IsConnServer;
        }

        private void propertyGridConn_PropertyValueChanged(object s, PropertyValueChangedEventArgs e) {
            var connectionStringBuilder = (DbConnectionStringBuilder)propertyGridConn.SelectedObject;
            textBoxString.Text = connectionStringBuilder.ConnectionString;
            buttonSaveDatabase.Enabled = true;
        }

        private void buttonSave_Click(object sender, EventArgs e) {
            Save();
        }

        private void Save() {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            if (comboBoxStrings.SelectedItem != null) {
                var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
                connectionStringsSection.ConnectionStrings[ConnName].ConnectionString = textBoxString.Text;
            }
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("connectionStrings");
            ConfigurationManager.RefreshSection("appSettings");
            buttonSaveDatabase.Enabled = false;
        }

        private void frmConfig_FormClosing(object sender, FormClosingEventArgs e) {
            e.Cancel = AskIfSave();
        }

        private bool AskIfSave() {
            if (!buttonSaveDatabase.Enabled) {
                return false;
            }

            var resp = MessageBox.Show($@"Salvar alterações em {ConnName}?", @"Configuração", MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question);
            if (resp == DialogResult.Yes) {
                Save();
            }
            buttonSaveDatabase.Enabled = false;
            return resp == DialogResult.Cancel;
        }

        private void buttonTestConnection_Click(object sender, EventArgs e) {
            string cs;
            if (IsConnEntity) {
                var csb = new SqlConnectionStringBuilder(); ;
                csb.DataSource = EntityDataSource();
                csb.InitialCatalog = EntityDatabase();
                csb.IntegratedSecurity = true;
                cs = csb.ToString();
            }
            else {
                var csb = (DbConnectionStringBuilder)propertyGridConn.SelectedObject;
                cs = csb.ToString();
            }

            try {
                var conn = new SqlConnection(cs);
                conn.Open();
                if (conn.State == ConnectionState.Open) {
                    MessageBox.Show(@"Conexão completada com sucesso!", @"Configuração", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    conn.Close();
                }
                else {
                    MessageBox.Show(@"Conexão não completada. Verifique os parâmetros.", @"Configuração",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex) {
                MessageBox.Show($"Conexão não completada. Verifique os parâmetros.\n\n{cs}\n\n{ex.Message}",
                    @"Configuração",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }

        private void listBoxSQLServers_SelectedIndexChanged(object sender, EventArgs e) {
            if (listBoxSQLServers.SelectedIndex == -1) {
                return;
            }

            var server = listBoxSQLServers.SelectedItem.ToString();
            if (IsConnEntity) {
                if (server == EntityDataSource()) {
                    return;
                }

                var csArray = EntityConnectionStringAsArray();
                for (var i = 0; i < csArray.Count(); i++) {
                    if (!csArray[i].StartsWith("data source")) {
                        continue;
                    }
                    csArray[i] = $"data source={server}";
                    break;
                }

                var conn = (EntityConnectionStringBuilder)propertyGridConn.SelectedObject;
                conn.ProviderConnectionString = string.Join(";", csArray);
                textBoxString.Text = conn.ToString();
            }
            else if (IsConnADO) {
                var conn = (SqlConnectionStringBuilder)propertyGridConn.SelectedObject;
                if (conn.DataSource == server) {
                    return;
                }

                conn.DataSource = server;
                textBoxString.Text = conn.ToString();
            }
            propertyGridConn.Refresh();
            buttonSaveDatabase.Enabled = true;
        }

        private string[] EntityConnectionStringAsArray() {
            var conn = (EntityConnectionStringBuilder)propertyGridConn.SelectedObject;
            var cs = conn.ProviderConnectionString;
            return cs.Split(new char[] { ';' });
        }

        private string EntityDataSource() {
            return EntityConnectionStringInfo("data source");
        }

        private string EntityDatabase() {
            return EntityConnectionStringInfo("initial catalog");
        }

        private string EntityConnectionStringInfo(string info) {
            return EntityConnectionStringAsArray()
                .First(s => s.StartsWith(info)).Substring(info.Length + 1);
        }

        private static string[] GetSQLInstances() {
            //var myServer = Environment.MachineName;
            var servers = SqlDataSourceEnumerator.Instance.GetDataSources();
            var instances = new List<string>();
            for (var i = 0; i < servers.Rows.Count; i++) {
                var server = servers.Rows[i]["ServerName"].ToString();
                //if (myServer != server) {
                //    continue;
                //}
                if ((servers.Rows[i]["InstanceName"] as string) != null) {
                    server += "\\" + servers.Rows[i]["InstanceName"];
                }
                instances.Add(server);
            }
            return instances.ToArray();
        }
        #endregion DATABASE ------------------------------------

        private void buttonSaveSettings_Click(object sender, EventArgs e) {
            Settings.Default.BalanceContaPadrao = comboBoxContaPadrao.SelectedIndex;
            Settings.Default.BalanceUsarContaPadrao = radioButtonBalanceContaPadrao.Checked;
            Settings.Default.CalendarioPastaPagamentos = labelCalendarioPastaPagamentos.Text;
            Settings.Default.MainBackgroundVisivel = checkBoxBackgroundVisivel.Checked;
            Settings.Default.MainBackgroundRodizio = checkBoxBackgroundRodizio.Checked;
            Settings.Default.MainBarraFerramentasVisivel = checkBoxBarraFerramentasVisivel.Checked;
            Settings.Default.MainBarraFerramentasImagem = checkBoxBarraFerramentasImagemeTexto.Checked;
            Settings.Default.Save();
            ((frmMain)this.Parent.Parent).AtualizaConfiguracoes();
        }

        private void labelCalendarioPastaPagamentos_DoubleClick(object sender, EventArgs e) {
            FBD.SelectedPath = labelCalendarioPastaPagamentos.Text;
            if (FBD.ShowDialog() == DialogResult.Cancel) {
                return;
            }

            labelCalendarioPastaPagamentos.Text = FBD.SelectedPath;
        }
    }
}