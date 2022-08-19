using System;

namespace poo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Orientação a objetos");
            // Instanciação de objeto
            Cliente cliente =
                new Cliente("12345678900", "Maria do Carmo");
            cliente.email = "mariac@gmail.com";
            cliente.fone = "2333333";
            cliente.nascimento = new DateTime();

            ContaCorrente conta = new ContaCorrente(cliente);
            conta.saldo = 1500.9;
            Console.WriteLine("antes da transf. "+ conta.ToString());

            // Instanciação de objeto
            Cliente cliente2 =
                new Cliente("12345678911", "Juliana Costa");
            cliente2.email = "juliana@gmail.com";
            cliente2.fone = "8989898";
            cliente2.nascimento = new DateTime(1988, 3, 1, 7, 0, 0); ;

            ContaCorrente conta2 = new ContaCorrente(cliente2);
            conta2.saldo = 0.0;
            Console.WriteLine("antes da transf 2. " + conta2.ToString());

            if (conta.Transferencia(conta2, 200.0))
            {
                Console.WriteLine("Transferido com sucesso!");
                Console.WriteLine("pós transf. " + conta.ToString());
                Console.WriteLine("pós transf 2. " + conta2.ToString());
            }
            else
            {
                Console.WriteLine("ERRO na transferência...");
            }

        }
    }
}