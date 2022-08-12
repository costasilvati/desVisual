using System;
namespace poo
{
    public class ContaCorrente // Declaração 
    {
        // Atributos
        public string nomeTitular;
        public string numeroConta;
        public string numeroAgencia;
        public double saldo;
        public double limite;

        // Construtor
        public ContaCorrente()
        {
        }

        public ContaCorrente(string nomeTitular)
        {
            this.nomeTitular = nomeTitular;
        }

        public string ToString()
        {
            return $"Nome titular: {this.nomeTitular} \n" +
                $"Numero Conta {this.numeroConta} \n" +
                $"Numero agencia {this.numeroAgencia}";
        }

    }
}
