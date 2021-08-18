using System;

namespace poo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Banco");

            // Instanciando Objeto Conta
            Conta conta1 = new Conta();
            conta1.numero = 123456;
            conta1.cliente = "Juliana Costa";
            conta1.saldo = 10000;
            conta1.tipo = "Corrente";
            conta1.senha = "123456";
            Console.WriteLine("Conta: " + conta1.cliente);

            Conta conta2 = new Conta();
            conta2 = conta1;
            Console.WriteLine("Igualdade de tipos de referência " + (conta1 == conta2));

            // Métodos
            bool saque = conta1.Saque(15000);
            if (saque)
            {
                Console.WriteLine("Saque efetuado. Novo saldo: R$" + conta1.saldo);
            }
            else
            {
                Console.WriteLine("Saldo induficiente!");
            }

            if (conta1.Deposito(300000))
            {
                Console.WriteLine("Depósito Efetuado! Novo saldo: R$" + conta1.saldo);
            }
            else
            {
                Console.WriteLine("Valor de depósito deve ser maior que 0");
            }

            //Implemente o método Pix na classe Conta
            // e teste o método AQUI
        }
    }
}
