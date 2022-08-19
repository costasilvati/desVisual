using System;
namespace poo
{
    public class ContaCorrente // Declaração 
    {
        // Atributos
        public Cliente cliente;
        public string numeroConta;
        public string numeroAgencia;
        public double saldo;
        public double limite;

        // Construtor
        public ContaCorrente(Cliente cliente)
        {
            this.cliente = cliente;
            
        }


        // Transferencia
        public bool Transferencia(ContaCorrente contaDestino,
            double valor)
        {
            if (this.saldo < valor)
            {
                return false;
            }
            else
            {
                this.saldo -= valor;
                contaDestino.saldo += valor;
                return true;
            }
        }

        override
        public string ToString()
        {
            return $"Cliente: {this.cliente.ToString()} \n" +
                $"Numero Conta {this.numeroConta} \n" +
                $"Numero agencia {this.numeroAgencia}\n" +
                $"Saldo: {this.saldo} \n" +
                $"Limite: {this.limite}";
        }

    }
}
