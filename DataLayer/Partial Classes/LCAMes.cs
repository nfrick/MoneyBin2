namespace DataLayer {
    public partial class LCAMes {
        public decimal RendimentoMes => (SaldoAtual - RendimentoBruto) == 0 ?
            0 : RendimentoBruto / (SaldoAtual - RendimentoBruto);

        private decimal Saldo => SaldoAtual == 0 ? Resgates : SaldoAtual;
    }
}
