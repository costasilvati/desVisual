using System;

namespace poo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Orientação a objetos");
            // Instanciação de objeto
            ContaCorrente conta = new ContaCorrente();
            //ContaCorrente conta = new();
            conta.nomeTitular = "Maria Gomes";
            conta.saldo = 1500.9;
            Console.WriteLine(conta.ToString());
            

        }
    }
}
