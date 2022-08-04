using System;
namespace poo
{
    public class Conta
    {
        public int numero;
        public string cliente; // Implemente a classe Cliente
        public float saldo;
        public string senha;
        public string tipo;

        public bool Saque(float valor)
        {
            if(saldo < valor)
            {
                return false;
            }
            this.saldo -= valor;
            //this.saldo = (saldo - valor);
            return true;
        }

        public bool Deposito(float valor)
        {
            if(valor > 0)
            {
                this.saldo += valor;
                return true;
            }
            return false;
        }

        //public bool Pix(float valor, Conta contaDestino)
        //{
            
        //}
    }
}
