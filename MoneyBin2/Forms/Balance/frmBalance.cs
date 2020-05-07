using DataLayer;
using MoneyBin2.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MoneyBin2 {
    public partial class frmBalance : MoneyBin2.DataForm {
        private Conta ContaAtual => (Conta)toolStripComboBoxConta.SelectedItem;
        private IEnumerable<int> ColunasVisiveis => dgvBalance.Columns.Cast<DataGridViewColumn>()
            .Where(c => c.Visible).Select(c => c.Index).ToArray();

        private ListSortDirection _sort = ListSortDirection.Descending;

        private readonly ToolStripComboBox toolStripComboBoxConta = new ToolStripComboBox {
            Name = "toolStripComboBoxConta",
            Size = new Size(100, 33),
        };

        private readonly ToolStripButton toolStripButtonProcurar = new ToolStripButton {
            BackColor = Color.FromArgb(0, 0, 192),
            DisplayStyle = ToolStripItemDisplayStyle.Text,
            Font = new Font("Webdings", 12F, FontStyle.Bold, GraphicsUnit.Point, 2),
            ForeColor = SystemColors.Control,
            Name = "toolStripButtonProcurar",
            Size = new Size(35, 30),
            Text = "L",
            ToolTipText = "Localizar em qualquer campo",
            Visible = false
        };

        private readonly ToolStripSeparator toolStripSeparator1 = new ToolStripSeparator {
            Name = "toolStripSeparator1",
            Size = new Size(6, 33)
        };

        private readonly ToolStripComboBox toolStripComboBoxGrupo = new ToolStripComboBox {
            Name = "toolStripComboBoxGrupo",
            Size = new Size(121, 33)
        };

        private readonly ToolStripButton toolStripButtonSelecionar = new ToolStripButton {
            BackColor = Color.FromArgb(192, 0, 0),
            DisplayStyle = ToolStripItemDisplayStyle.Text,
            Font = new Font("Wingdings", 12F, FontStyle.Regular, GraphicsUnit.Point, 2),
            ForeColor = SystemColors.Control,
            Name = "toolStripButtonSelecionar",
            Size = new Size(35, 30),
            Text = "è",
            ToolTipText = "Selecionar itens",
            Visible = false
        };

        private readonly ToolStripTextBox toolStripTextBoxProcurar = new ToolStripTextBox {
            Name = "toolStripTextBoxProcurar",
            Size = new Size(150, 33)
        };

        private readonly ToolStripDateTimePicker _dtpInicio = new ToolStripDateTimePicker("dtpInicio", DateTime.Today.AddDays(-60), DateTimePickerFormat.Short) { Width = 100 };

        private readonly ToolStripDateTimePicker _dtpTermino = new ToolStripDateTimePicker("dtpTermino", DateTime.Today, DateTimePickerFormat.Short) { Width = 100 };

        private readonly ToolStripCheckbox _chkboxAutoMode = new ToolStripCheckbox("chkboxAutoMode", "Auto", true) {
            ForeColor = SystemColors.ControlText,
            BackColor = SystemColors.Control,
            ToolTipText = "Atualiza Balance automaticamente quando parãmetros são alterados (pode ser lento)"
        };

        private readonly ToolStripCheckbox _chkboxRegex = new ToolStripCheckbox("chkboxRegex", "Regex", false) {
            ForeColor = SystemColors.ControlText,
            BackColor = SystemColors.Control,
            ToolTipText = "Usar Regular Expressions nas pesquisas"
        };

        private readonly ToolStripCheckbox _chkboxDocumento = new ToolStripCheckbox("chkboxDocumento", "Coluna 'Documento'", false) {
            ForeColor = SystemColors.ControlText,
            BackColor = SystemColors.Control,
            ToolTipText = "Exibe coluna 'Documento'"
        };

        public frmBalance() {
            InitializeComponent();

            _mainBindingSource = bsBalance;

            var lblInicio = new ToolStripLabel("Início:") { DoubleClickEnabled = true };
            lblInicio.DoubleClick += (sender, args) => {
                _dtpInicio.Value = ContaAtual.DataMin;
                if (_dtpInicio.Value > _dtpTermino.Value) {
                    _dtpTermino.Value = _dtpInicio.Value.AddMonths(3);
                }
            };

            var lblTermino = new ToolStripLabel("Término:") { DoubleClickEnabled = true };
            lblTermino.DoubleClick += (sender, args) => {
                _dtpTermino.Value = ContaAtual.DataMax;
                if (_dtpInicio.Value > _dtpTermino.Value) {
                    _dtpInicio.Value = _dtpTermino.Value.AddMonths(-3);
                }
            };

            toolStripMenu.Items.Add(new ToolStripLabel("Conta:"));
            toolStripMenu.Items.Add(toolStripComboBoxConta);
            toolStripMenu.Items.Add(lblInicio);
            toolStripMenu.Items.Add(_dtpInicio);
            toolStripMenu.Items.Add(lblTermino);
            toolStripMenu.Items.Add(_dtpTermino);
            toolStripMenu.Items.Add(toolStripButtonProcurar);
            toolStripMenu.Items.Add(new ToolStripLabel("Grupo:"));
            toolStripMenu.Items.Add(toolStripComboBoxGrupo);
            toolStripMenu.Items.Add(toolStripButtonSelecionar);
            toolStripMenu.Items.Add(toolStripSeparator1);
            toolStripMenu.Items.Add(_chkboxAutoMode);
            toolStripMenu.Items.Add(new ToolStripSeparator());
            toolStripMenu.Items.Add(new ToolStripLabel("Procurar:"));
            toolStripMenu.Items.Add(toolStripTextBoxProcurar);
            toolStripMenu.Items.Add(toolStripButtonProcurar);
            toolStripMenu.Items.Add(new ToolStripSeparator());
            toolStripMenu.Items.Add(_chkboxRegex);
            toolStripMenu.Items.Add(new ToolStripSeparator());
            toolStripMenu.Items.Add(_chkboxDocumento);

            var font = new Font("Segoe UI", 11.0F, FontStyle.Regular, GraphicsUnit.Point, 0);
            foreach (var item in toolStripMenu.Items.Cast<ToolStripItem>()
                .Where(item => item.Font.Name == "Segoe UI")) {
                item.Font = font;
            }

            toolStripTextBoxProcurar.KeyDown += toolStripTextBoxProcurar_KeyDown;
            toolStripTextBoxProcurar.Validated += toolStripTextBoxProcurar_Validated;
            toolStripTextBoxProcurar.TextChanged += toolStripTextBoxProcurar_TextChanged;
            toolStripButtonProcurar.Click += toolStripButtonProcurar_Click;
            _chkboxAutoMode.CheckedChanged += ToggleAutoMode;
            _chkboxDocumento.CheckedChanged += ShowDocumento;
            toolStripComboBoxConta.SelectedIndexChanged += FilterItemChanged;
            toolStripButtonSelecionar.Click += FilterItemChanged;
            _dtpInicio.ValueChanged += FilterItemChanged;
            _dtpTermino.ValueChanged += FilterItemChanged;

            toolStripComboBoxConta.ComboBox.Items.AddRange(_ctx.Contas.OrderBy(c => c.Apelido).ToArray());
            toolStripComboBoxConta.ComboBox.DisplayMember = "Apelido";

            toolStripComboBoxConta.ComboBox.SelectedItem =
                Settings.Default.BalanceUsarContaPadrao
                    ? _ctx.Contas.Find(Settings.Default.BalanceContaPadrao)
                    : _ctx.Contas.Find(Settings.Default.BalanceUltimaConta);

            dgvBalance.FormatColumn("Data", dgvBalance.StyleDateShort, 80);
            dgvBalance.FormatColumn("Histórico", null, 300);
            dgvBalance.FormatColumn("Documento", null, 120);
            dgvBalance.FormatColumn("Valor", dgvBalance.StyleCurrency, 100);
            dgvBalance.FormatColumn("Afeta Saldo", null, 40);
            dgvBalance.FormatColumn("Saldo", dgvBalance.StyleCurrency, 100);
            dgvBalance.FormatColumn("Grupo", null, 120);
            dgvBalance.FormatColumn("Categoria", null, 140);
            dgvBalance.FormatColumn("SubCategoria", null, 200);
            dgvBalance.FormatColumn("Descrição", null, 200);
            dgvBalance.Columns[2].Visible = false;

            ResizeForm(dgvBalance);

            QueryDatabase();

            toolStripComboBoxGrupo.SelectedIndexChanged += FilterItemChanged;
        }

        protected override void DataForm_FormClosing(object sender, FormClosingEventArgs e) {
            Settings.Default.BalanceUltimaConta = ((Conta)toolStripComboBoxConta.ComboBox.SelectedItem).ID;
            Settings.Default.Save();
            base.DataForm_FormClosing(sender, e);
        }

        #region TOOLSTRIP ---------------------------
        private void FilterItemChanged(object sender, EventArgs e) {
            if (((ToolStripItem)sender).Name == "toolStripComboBoxConta") {
                toolStripComboBoxGrupo.ComboBox.Items.Clear();
                toolStripComboBoxGrupo.ComboBox.Items.Add("Todos");
                toolStripComboBoxGrupo.ComboBox.Items.AddRange(ContaAtual.Grupos.ToArray());
                toolStripComboBoxGrupo.ComboBox.SelectedIndex = 0;
            }
            if (((ToolStripItem)sender).Name == "toolStripButtonSelecionar" ||
                _chkboxAutoMode.Checked) {
                QueryDatabase();
            }

            var grupo = toolStripComboBoxGrupo.SelectedIndex == 0
                ? ""
                : $"Grupo = '{toolStripComboBoxGrupo.SelectedItem}' e ";
            toolStripButtonSelecionar.ToolTipText =
                $"Selecionar itens com {grupo}data entre {_dtpInicio.Value:d} e {_dtpTermino.Value:d}";
        }

        private void QueryDatabase() {
            var balance = new ObservableListSource<BalanceItem>(
                ContaAtual.BalanceFiltrado(
                _dtpInicio.Value, _dtpTermino.Value,
                (string)toolStripComboBoxGrupo.SelectedItem,
                true, _sort));

            bsBalance.DataSource = balance.Any() ? balance.ToBindingList() : null;
            EnableSaveButtons();
        }

        private void ToggleAutoMode(object sender, EventArgs e) {
            toolStripButtonSelecionar.Visible = !_chkboxAutoMode.Checked;
        }

        private void ShowDocumento(object sender, EventArgs e) {
            dgvBalance.Columns["Documento"].Visible = _chkboxDocumento.Checked;
            ResizeForm(dgvBalance);
        }

        protected override void toolStripButtonSave_Click(object sender, EventArgs e) {
            dgvBalance.EndEdit();
            base.toolStripButtonSave_Click(sender, e);
        }

        protected override void toolStripButtonRevert_Click(object sender, EventArgs e) {
            dgvBalance.EndEdit();
            base.toolStripButtonRevert_Click(sender, e);
            dgvBalance.Refresh();
        }

        #region PROCURAR ----------------
        private void toolStripTextBoxProcurar_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode != Keys.Enter || string.IsNullOrEmpty(toolStripTextBoxProcurar.Text)) {
                return;
            }
            SelectFirstRow();
            Procurar();
        }

        private void toolStripTextBoxProcurar_Validated(object sender, EventArgs e) {
            SelectFirstRow();
        }

        private void toolStripTextBoxProcurar_TextChanged(object sender, EventArgs e) {
            toolStripButtonProcurar.Visible = !string.IsNullOrEmpty(toolStripTextBoxProcurar.Text);
        }

        private void SelectFirstRow() {
            dgvBalance.ClearSelection();
            dgvBalance.CurrentCell = dgvBalance.Rows[0].Cells[0];
            dgvBalance.Rows[0].Selected = true;
        }

        private void toolStripButtonProcurar_Click(object sender, EventArgs e) {
            Procurar();
        }

        private void Procurar() {
            var targetRegex = new Regex(toolStripTextBoxProcurar.Text);
            var target = toolStripTextBoxProcurar.Text.ToLower();
            var row = dgvBalance.CurrentRow.Index;
            var startCol = dgvBalance.CurrentCell.ColumnIndex;

            while (row < dgvBalance.RowCount) {
                var Row = dgvBalance.Rows[row];
                foreach (var col in ColunasVisiveis.Where(c => c > startCol)) {
                    var found = _chkboxRegex.Checked ? targetRegex.IsMatch(Row.Cells[col].FormattedValue.ToString()) : Row.Cells[col].FormattedValue.ToString().ToLower().Contains(target);
                    if (!found) {
                        continue;
                    }

                    dgvBalance.CurrentCell = Row.Cells[col];
                    return;
                }
                ++row;
                startCol = -1;
            }
            MessageBox.Show($"'{targetRegex}' não encontrado", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion PROCURAR ----------------

        #endregion TOOLSTRIP ---------------------------

        #region DATAGRIDVIEW ---------------------------
        private void dgvBalance_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
            var x = dgvBalance.Rows[e.RowIndex].DataBoundItem;
            try {
                var item = (BalanceItem)dgvBalance.Rows[e.RowIndex].DataBoundItem;
                if (!item.AfetaSaldo) {
                    e.CellStyle.ForeColor = Color.DarkGray;
                }

                if ((e.ColumnIndex == 3 || e.ColumnIndex == 5) && (decimal)e.Value < 0) {
                    e.CellStyle.ForeColor = Color.LightCoral;
                }
            }
            catch (Exception exception) {
                Console.WriteLine(exception);
                //throw;
            }
        }

        private void dgvBalance_CellEndEdit(object sender, DataGridViewCellEventArgs e) {
            EnableSaveButtons();
        }

        private void dgvBalance_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e) {
            ClassifTools.EditingControlShowing(sender, e);
        }

        private void dgvBalance_MouseClick(object sender, MouseEventArgs e) {
            ClassifTools.PopupOptions(sender, e, cmsPopMenu);
        }

        private void cmsPopMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {
            ClassifTools.PopupItemClicked(sender, e, dgvBalance);
            EnableSaveButtons();
        }

        private void dgvBalance_CellValueChanged(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex == -1 || dgvBalance.Columns[e.ColumnIndex].Name !=
                "AfetaSaldo") {
                return;
            }
            ContaAtual.CalculaBalance();
            dgvBalance.Refresh();
        }

        #endregion DATAGRIDVIEW ------------------------
    }
}
