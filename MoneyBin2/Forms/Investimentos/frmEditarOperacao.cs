using DataLayer;
using System;
using System.Linq;
using System.Windows.Forms;

namespace MoneyBin2 {
    public partial class frmEditarOperacao : Form {
        public Operacao Operacao { private get; set; }
        public ObservableListSource<Acao> Acoes { private get; set; }
        public MoneyBinEntities Ctx { private get; set; }

        public frmEditarOperacao() {
            InitializeComponent();
        }

        private void EditarOperacao_Load(object sender, EventArgs e) {

            comboBoxAtivo.DataSource = Ctx.Ativos.OrderBy(a => a.Nome).ToArray();
            comboBoxAtivo.DisplayMember = "Codigo";
            comboBoxAtivo.ValueMember = "Codigo";

            comboBoxOperacao.DataSource = Ctx.OperacoesTipos.OrderBy(t => t.Tipo).ToArray();
            comboBoxOperacao.DisplayMember = "Tipo";
            comboBoxOperacao.ValueMember = "TipoId";

            if (Operacao.OperacaoId == 0) {
                comboBoxOperacao.SelectedIndex = -1;
                buttonOK.Enabled = false;
                dateTimePickerData.Value = DateTime.Now;
                nudQtd.Value = 1000;
                Text = @"Nova Operação";
            }
            else {
                comboBoxAtivo.Enabled = false;
                comboBoxOperacao.SelectedValue = Operacao.TipoId;
                dateTimePickerData.Value = Operacao.Data;
                nudQtd.Value = Operacao.Qtd;
                nudValorNominal.Value = Operacao.Valor;
                nudValorReal.Value = Operacao.ValorReal;
                nudCustoOperacao.Value = Operacao.CustoOperacao;
                Text = @"Editar Operação";
            }
            comboBoxAtivo.SelectedValue = Operacao.Codigo;
            ExibirTotais();
            buttonOK.Enabled = Operacao.OperacaoId != 0;
        }

        private void buttonOK_Click(object sender, EventArgs e) {

        }

        private void combos_ValueChanged(object sender, EventArgs e) {
            buttonOK.Enabled = (comboBoxAtivo.SelectedValue != null &&
                comboBoxOperacao.SelectedValue != null);
        }

        private void numericUpDown_Enter(object sender, EventArgs e) {
            var nup = (NumericUpDown)sender;
            nup.Select(0, nup.Text.Length);
        }

        private void nudValor_Validated(object sender, EventArgs e) {
            var nud = (NumericUpDown)sender;
            if (nud.Value == 0 || nud.Text == string.Empty) {
                nud.Value = nudValorNominal.Value;
            }
            ExibirTotais();
        }

        private void ExibirTotais() {
            labelTotalNominal.Text = $@"{nudQtd.Value * nudValorNominal.Value:N2}";
            labelTotalReal.Text = $@"{nudQtd.Value * nudValorReal.Value:N2}";
        }

        private void frmEditarOperacao_FormClosing(object sender, FormClosingEventArgs e) {
            if (this.DialogResult == DialogResult.Cancel) {
                return;
            }
            var operacaoTipo = (OperacaoTipo) comboBoxOperacao.SelectedItem;
            if (operacaoTipo.SinalPositivo) {
                Salvaralteracoes();
                return;
            }

            var codigo = (string) comboBoxAtivo.SelectedValue;
            var acaoAtual = Acoes.FirstOrDefault(a => a.Codigo == codigo);
            var QtdDisponivel = acaoAtual == null ? 0 :
                    Operacao.OperacaoId == 0 ? acaoAtual.Qtd : Operacao.QtdAntes;
            var qtd = (int) nudQtd.Value;
            if (qtd <= QtdDisponivel) {
                Salvaralteracoes();
                return;
            }

            MessageBox.Show($"{codigo} - Qtd anterior: {Operacao.QtdAntes}\n\nNão há 'saldo' para a {operacaoTipo.Tipo} de {qtd:N0} ações.",
                Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            nudQtd.Focus();
            e.Cancel = true;
        }

        private void Salvaralteracoes() {
            Operacao.Codigo = (string)comboBoxAtivo.SelectedValue;
            Operacao.OperacaoTipo = (OperacaoTipo)comboBoxOperacao.SelectedItem;
            Operacao.TipoId = (int)comboBoxOperacao.SelectedValue;
            Operacao.Data = dateTimePickerData.Value;
            Operacao.Qtd = (int)nudQtd.Value;
            Operacao.Valor = nudValorNominal.Value;
            Operacao.ValorReal = nudValorReal.Value;
            //Operacao.CustoOperacao = nudCustoOperacao.Value;
        }
    }
}
