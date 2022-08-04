using System;
namespace OrientacaoAObjetos
{
    public class ContaCorrente
    {
        private Cliente _titular;
        private int Agencia { get; }
        private int Numero { get; }
        private double _saldo;

        public ContaCorrente(int agencia, int numero)
        {
            if(numero <= 0)
            {
                throw new ArgumentException(
                    "O argumento numero deve ser maior que 0", nameof(numero));
            }
            Agencia = agencia;
            Numero = numero;
        }

        //public Cliente Titular { get; set; }

        public Cliente Titular
        {
            get;
            set;
        }

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }

                _saldo = value;
            }
        }

        public void Sacar(double valor)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor inválido para saque.", nameof(valor));
            }

            if (Saldo < valor)
            {
                throw new SaldoNegativoException(Saldo, valor);
            }

            Saldo -= valor;
        }

        public void Depositar(double valor)
        {
            this._saldo += valor;
        }


        public void Transferir(double valor, ContaCorrente contaDestino)
        {

            if (valor < 0)
            {
                throw new ArgumentException("Valor inválido para tranferância.", nameof(valor));
            }
            Sacar(valor);
            contaDestino.Depositar(valor);
        }
    }
}
