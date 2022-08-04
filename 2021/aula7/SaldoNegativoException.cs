using System;
namespace OrientacaoAObjetos
{
    public class SaldoNegativoException : Exception
    {
        public double Saldo { get; }
        public double ValorDesejado { get; }

        public SaldoNegativoException()
        {
        }

        public SaldoNegativoException (double saldo, double valor)
            : this ("Saldo insuficiente. Valor Desejado: " + valor +
                  " a conta possui saldo " + saldo)
        {
            Saldo = saldo;
            ValorDesejado = valor;
        }

        public SaldoNegativoException(string mensagem) : base(mensagem)
        {
        }

    }
}
