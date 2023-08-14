using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class ContaCorrente
    {
        public string titular;
        public int numero;
        public int agencia;
        public double saldo;
        
        public bool Sacar(double valor)
        {
            if(saldo < valor)
            {
                return false;
            }
            else
            {
                saldo -= valor;
                return true;
            }
        }

        public bool Depositar(double valor)
        {
            if(valor > 0)
            {
                this.saldo += valor;
                return true;
            }
            else
            {
                Console.WriteLine("Depósito deve ser maior que 0.0");
                return false;
            }
        }
    }
}
