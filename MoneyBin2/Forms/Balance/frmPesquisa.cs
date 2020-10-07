using DataLayer;
using IEnumerableExtensions;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MoneyBin2 {
    public partial class frmPesquisa : MoneyBin2.DataForm {
        //private IEnumerable<int> ColunasVisiveis => dgvPesquisa.Columns.Cast<DataGridViewColumn>()
        //    .Where(c => c.Visible).Select(c => c.Index).ToArray();

        //private ListSortDirection _sort = ListSortDirection.Descending;

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
        }


        private void radioButtonValor_CheckedChanged(object sender, EventArgs e) {
            labelValor_e.Visible = textBoxValor2.Visible = radioButtonBetween.Checked;
            textBoxValor1.Visible = !radioButtonAll.Checked;
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

            var contasSelecionadas = checkedListBoxContas.CheckedItems.Cast<Conta>().Select(c => $"'{c.ID}'").ToArray();
            var contas = !contasSelecionadas.Any() ||
                         contasSelecionadas.Count() == checkedListBoxContas.Items.Count ?
                null : string.Join(",", contasSelecionadas);

            var grupoSelectSelecionados = checkedListBoxGrupo.CheckedItems.Cast<string>().Select(g => $"'{g}'").ToArray(); ;
            var grupos = !grupoSelectSelecionados.Any() ||
                         grupoSelectSelecionados.Count() == checkedListBoxGrupo.Items.Count ?
                null : string.Join(",", grupoSelectSelecionados);

            var categoriasSelecionadas = checkedListBoxCategoria.CheckedItems.Cast<string>().Select(c => $"'{c}'").ToArray(); ;
            var categorias = !categoriasSelecionadas.Any() ||
                         categoriasSelecionadas.Count() == checkedListBoxGrupo.Items.Count ?
                null : string.Join(",", categoriasSelecionadas);

            string valorOperacao = null;
            var valor1 = textBoxValor1.Text;
            var valor2 = textBoxValor2.Text;

            if (radioButtonBetween.Checked) {
                valorOperacao = "entre";
            }
            else if (radioButtonEqual.Checked) {
                valorOperacao = "=";
            }
            else if (radioButtonGreaterThan.Checked) {
                valorOperacao = ">=";
            }
            else if (radioButtonSmallerThan.Checked) {
                valorOperacao = "<=";
            }

            var afetaSaldo = checkBoxAfetaSaldo.CheckState == CheckState.Unchecked
                ? 0
                : (checkBoxAfetaSaldo.CheckState == CheckState.Checked ? 1 : 2);

            var descricao = string.IsNullOrEmpty(textBoxDescricao.Text) ? null : textBoxDescricao.Text.Trim();

            bsPesquisa.DataSource =
                _ctx.spPesquisa(contas,
                    dtpInicio.Value.ToString("yyyy-MM-dd"),
                    dtpTermino.Value.ToString("yyyy-MM-dd"),
                    valorOperacao, valor1, valor2, afetaSaldo,
                    grupos, categorias, descricao).ToObservableListSource();

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

        private void dgvPesquisa_CellEndEdit(object sender, DataGridViewCellEventArgs e) {
            EnableSaveButtons();
        }

        private void dgvPesquisa_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e) {
            ClassifTools.EditingControlShowing(sender, e);
        }

        private void dgvPesquisa_MouseClick(object sender, MouseEventArgs e) {
            ClassifTools.PopupOptions(sender, e, cmsPopMenu);
        }

        private void cmsPopMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {
            ClassifTools.PopupItemClicked(sender, e, dgvPesquisa);
            EnableSaveButtons();
        }

        private void dgvPesquisa_CellValueChanged(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex == -1 || dgvPesquisa.Columns[e.ColumnIndex].Name !=
                "AfetaSaldo") {
                return;
            }
            dgvPesquisa.Refresh();
        }

        #endregion DATAGRIDVIEW ------------------------

    }
}
