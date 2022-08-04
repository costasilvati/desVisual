using System;
namespace OrientacaoAObjetos
{
    public class ContaCorrente
    {
        private Cliente _titular;
        public int agencia;
        public int numero;
        private double _saldo;

        public ContaCorrente(Cliente titular) => this._titular = titular;

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

        public bool Sacar(double valor)
        {
            if (this._saldo < valor)
            {
                return false;
            }

            this._saldo -= valor;
            return true;
        }

        public void Depositar(double valor)
        {
            this._saldo += valor;
        }


        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (this._saldo < valor)
            {
                return false;
            }

            this._saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }
    }
}
