using System;
namespace poo
{
    public class Conta
    {
        private int numero;
        public Cliente titular; // Implemente a classe Cliente
        private float _saldo;
        public string senha;
        public string tipo;

        //Construtor da classe
        public Conta(Cliente cliente) => titular = cliente;
        // Segundo construtor
        public Conta(int numero) => this.numero = numero;

        public int Numero
        {
            get;
            set;
        }

        public bool Saque(float valor)
        {
            if(_saldo < valor)
            {
                return false;
            }
            this._saldo -= valor;
            //this.saldo = (saldo - valor);
            return true;
        }

        public bool Deposito(float valor)
        {
            if(valor > 0)
            {
                this._saldo += valor;
                return true;
            }
            return false;
        }

        public bool Pix(float valor, Conta contaDestino)
        {
            if(valor > 0 && this._saldo >= valor)
            {
                this._saldo -= valor;
                contaDestino.Deposito(valor);
                return true;
            }

            return false;
        }

        public float Saldo
        {
            get
            {
                return this._saldo;
            }
            set
            {
                if (!(value < 0))
                {
                    this._saldo = value;
                }
                else
                {
                    Console.WriteLine("Erro ao editar saldo!");
                }
            }
        }
    }
}
