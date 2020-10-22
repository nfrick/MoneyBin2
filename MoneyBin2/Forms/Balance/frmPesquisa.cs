using DataLayer;
using IEnumerableExtensions;
using SqlKata;
using SqlKata.Compilers;
using SqlKata.Execution;
using System;
using System.Configuration;
using System.Data.Entity.Core.EntityClient;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MoneyBin2 {
    public partial class frmPesquisa : MoneyBin2.DataForm {
        //private IEnumerable<int> ColunasVisiveis => dgvPesquisa.Columns.Cast<DataGridViewColumn>()
        //    .Where(c => c.Visible).Select(c => c.Index).ToArray();

        //private ListSortDirection _sort = ListSortDirection.Descending;

        private Query _queryBase;

        private readonly ToolStripButton toolStripButtonProcurar = new ToolStripButton
        {
            BackColor = Color.FromArgb(0, 0, 192),
            DisplayStyle = ToolStripItemDisplayStyle.Text,
            Font = new Font("Webdings", 12F, FontStyle.Bold, GraphicsUnit.Point, 2),
            ForeColor = SystemColors.Control,
            Name = "toolStripButtonProcurar",
            Size = new Size(35, 30),
            Text = "L",
            ToolTipText = "Localizar em qualquer campo",
            Visible = true
        };

        public frmPesquisa() {
            InitializeComponent();

            checkedListBoxContas.Items.AddRange(_ctx.Contas.OrderBy(c => c.Apelido).ToArray());
            checkedListBoxContas.DisplayMember = "Apelido";

            checkedListBoxGrupo.Items.AddRange(_ctx.Balance.Select(b => b.Grupo).Distinct().OrderBy(g => g).ToArray());
            checkedListBoxCategoria.Items.AddRange(_ctx.Balance.Where(b => b.Categoria != null).Select(b => b.Categoria).Distinct().OrderBy(c => c).ToArray());

            _mainBindingSource = bsPesquisa;

            dtpInicio.Value = DateTime.Today.AddMonths(-6);
            toolStripMenu.Items.Add(toolStripButtonProcurar);

            var font = new Font("Segoe UI", 11.0F, FontStyle.Regular, GraphicsUnit.Point, 0);
            foreach (var item in toolStripMenu.Items.Cast<ToolStripItem>()
                .Where(item => item.Font.Name == "Segoe UI")) {
                item.Font = font;
            }

            toolStripButtonSave.Visible = false;
            toolStripButtonRevert.Visible = false;
            toolStripSeparatorSave.Visible = false;
            toolStripSeparatorUndo.Visible = false;
            UpdateStatusBar();

            toolStripButtonProcurar.Click += toolStripButtonProcurar_Click;

            dgvPesquisa.FormatColumn("Conta", null, 80);
            dgvPesquisa.FormatColumn("Data", dgvPesquisa.StyleDateShort, 80);
            dgvPesquisa.FormatColumn("Histórico", null, 300);
            dgvPesquisa.FormatColumn("Documento", null, 120);
            dgvPesquisa.FormatColumn("Valor", dgvPesquisa.StyleCurrency, 100);
            dgvPesquisa.FormatColumn("Afeta Saldo", null, 40);
            dgvPesquisa.FormatColumn("Grupo", null, 120);
            dgvPesquisa.FormatColumn("Categoria", null, 140);
            dgvPesquisa.FormatColumn("SubCategoria", null, 200);
            dgvPesquisa.FormatColumn("Descrição", null, 200);
            dgvPesquisa.Columns[3].Visible = false;

            ResizeForm(dgvPesquisa);

            var str = ConfigurationManager.ConnectionStrings["MoneyBinEntities"].ToString();
            var ec = new EntityConnectionStringBuilder(str);

            var connection = new SqlConnection(ec.ProviderConnectionString);
            var compiler = new SqlServerCompiler();
            var db = new QueryFactory(connection, compiler);

            // You can register the QueryFactory in the IoC container

            _queryBase = db.Query("Extrato.tbBalance")
                .Join("Contas.tbContas", "tbContas.Id", "tbBalance.ContaId");
        }


        private void radioButtonValor_CheckedChanged(object sender, EventArgs e) {
            var radio = (RadioButton)sender;
            if (!radio.Checked) {
                return;
            }

            labelValor_e.Visible = currencyTextBoxValor2.Visible = radioButtonBetween.Checked;
            currencyTextBoxValor1.Visible = !radioButtonAll.Checked;
            if (radioButtonAll.Checked) {
                return;
            }

            currencyTextBoxValor1.Location = radioButtonBetween.Checked ?
                new Point(10, currencyTextBoxValor2.Location.Y) : new Point(radio.Location.X + 53, radio.Location.Y);

        }

        #region TOOLSTRIP ---------------------------
        protected override void toolStripButtonSave_Click(object sender, EventArgs e) {
            dgvPesquisa.EndEdit();
            base.toolStripButtonSave_Click(sender, e);
        }

        protected override void toolStripButtonRevert_Click(object sender, EventArgs e) {
            dgvPesquisa.EndEdit();
            base.toolStripButtonRevert_Click(sender, e);
            dgvPesquisa.Refresh();
        }

        private void toolStripButtonProcurar_Click(object sender, EventArgs e) {

            bsPesquisa.DataSource = null;
            dgvPesquisa.Refresh();

            var query = _queryBase.Clone().WhereBetween("Data", dtpInicio.Value, dtpTermino.Value);

            var contas = checkedListBoxContas.CheckedItems.Cast<Conta>().Select(c => c.ID).ToArray();
            if (contas.Any() && contas.Length != checkedListBoxContas.Items.Count) {
                query = query.WhereIn("ContaID", contas);
            }

            var grupos = checkedListBoxGrupo.CheckedItems.Cast<string>().ToArray();
            if (grupos.Any() && grupos.Length != checkedListBoxGrupo.Items.Count) {
                query = query.WhereIn("Grupo", grupos);
            }

            var categorias = checkedListBoxCategoria.CheckedItems.Cast<string>().ToArray();
            if (categorias.Any() && grupos.Length != checkedListBoxCategoria.Items.Count) {
                query = query.WhereIn("Categoria", categorias);
            }
            
            if (!radioButtonAll.Checked) {
                var valor1 = currencyTextBoxValor1.DecimalValue;

                if (radioButtonEqual.Checked) {
                    query = query.Where("Valor", valor1);
                }
                else if (radioButtonBetween.Checked) {
                    var valor2 = currencyTextBoxValor2.DecimalValue;
                    query = query.WhereBetween("Valor", valor1, valor2);
                }
                else if (radioButtonGreaterThan.Checked) {
                    query = query.Where("Valor", ">=", valor1);
                }
                else if (radioButtonSmallerThan.Checked) {
                    query = query.Where("Valor", "<=", valor1);
                }
            }

            switch (checkBoxAfetaSaldo.CheckState) {
                case CheckState.Checked:
                    query = query.WhereTrue("AfetaSaldo");
                    break;
                case CheckState.Unchecked:
                    query = query.WhereFalse("AfetaSaldo");
                    break;
                default:
                    break;
            }

            var descricao = textBoxDescricao.Text.Trim();
            if (!string.IsNullOrEmpty(descricao)) {
                query = query.WhereContains("Descricao", descricao);
            }

            var historico = textBoxHistorico.Text.Trim();
            if (!string.IsNullOrEmpty(historico)) {
                query = query.WhereContains("Historico", historico);
            }

            bsPesquisa.DataSource = query.Get<Pesquisa>().ToObservableListSource();

            dgvPesquisa.Refresh();
            UpdateStatusBar();

        }

        #endregion TOOLSTRIP ---------------------------

        #region DATAGRIDVIEW ---------------------------
        private void dgvPesquisa_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
            try {
                var item = (Pesquisa)dgvPesquisa.Rows[e.RowIndex].DataBoundItem;
                if (!item.AfetaSaldo) {
                    e.CellStyle.ForeColor = Color.DarkGray;
                    return;
                }

                if (e.ColumnIndex == 4 && (decimal)e.Value < 0) {
                    e.CellStyle.ForeColor = Color.LightCoral;
                }
            }
            catch (Exception exception) {
                Console.WriteLine(exception);
                //throw;
            }
        }

        #endregion DATAGRIDVIEW ------------------------

    }
}
