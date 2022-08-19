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

        override
        public string ToString()
        {
            return $"Cliente: {this.cliente.ToString()} \n" +
                $"Numero Conta {this.numeroConta} \n" +
                $"Numero agencia {this.numeroAgencia}";
        }

    }
}
