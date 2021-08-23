using IEnumerableExtensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataLayer {
    public partial class ContaAtivo : Cotacao {
        #region CONTAATIVO

        public override string ToString() => $"Conta: {Conta.Apelido}  Código: {Codigo}";

        public decimal UltimoPreco => Ativo.AtivoUltimoPreco.PrecoUltimo;

        public DateTime UltimoPrecoData => Ativo.AtivoUltimoPreco.Data;

        public int Qtd => Operacoes.Sum(o => o.QtdComSinal);

        public decimal Total => UltimoPreco * Qtd;

        public ObservableListSource<Entrada> EntradasDisponiveis(Saida saida) =>
            Entradas.Where(e => e.Data <= saida.Data && e.Disponivel).ToObservableListSource();

        #endregion CONTAATIVO -----------------------------------

        public bool JaNegociado => Operacoes.Any();

        public bool Corrente => Qtd > 0;

        private IEnumerable<Entrada> Vendaveis => Entradas.Where(o => o.QtdDisponivel > 0 && o.ValorReal < LastClose);

        public int QtdVendavel => Corrente ? Vendaveis.Sum(o => o.QtdDisponivel) : 0;

        public decimal VMVendavel => QtdVendavel == 0 ? 0 : Vendaveis.Sum(o => o.QtdDisponivel * o.ValorReal) / QtdVendavel;

        public decimal? LucroImediato => QtdVendavel * (LastClose - VMVendavel);

        public decimal ValorMedioCompra => JaNegociado ? _valorMedioCompra(false) : 0;

        public decimal ValorMedioCompraReal => JaNegociado ? _valorMedioCompra(true) : 0;

        public decimal? AlertaVenda => LastClose == 0 || ValorMedioCompraReal == 0 ? 10m : LastClose / ValorMedioCompraReal;

        private decimal _valorMedioCompra(bool real) =>
            Operacoes
                .OrderByDescending(o => o.Data)
                .TakeWhile(o => o.QtdAcumulada > 0)
                .Where(o => o.IsEntrada).Reverse()
                .Aggregate(0.0m,
                    (current, operacao) => (current * operacao.QtdAntes +
                                            (real ? operacao.ValorOperacaoComTaxasReal : operacao.ValorOperacaoComTaxas)) / operacao.QtdAcumulada);

        public decimal Patrimonio => LastClose * Qtd;

        public decimal Lucro => (LastClose - ValorMedioCompra) * Qtd;

        public decimal LucroReal => (LastClose - ValorMedioCompraReal) * Qtd;

        public override string CCodigo => Codigo;
    }
}