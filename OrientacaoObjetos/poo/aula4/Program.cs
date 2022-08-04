using System;

namespace poo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Banco - aula 4");

            /*
             * Com base no projeto desenvolvido em aula:
Implemente a classe Cliente;
Cada objeto ContaCorrente deve possuir um Cliente e esse
deve ser instanciado obrigatoriamente antes da criação da ContaCorrente;
Implemente o método PIX em ContaCorrente;
Teste o método */

            Cliente cliente = new Cliente();
            cliente.nome = "Juliana Costa";
            cliente.cpf = "12345678900";
            cliente.email = "juliana.silva@up.edu.br";

            Conta conta = new Conta(cliente);
            conta.titular.email = "novoemail@email.com";
            conta.senha = "123";

            conta.Saldo = 55000;
            Console.WriteLine("Saldo da conta " + conta.Saldo);
        }
    }
}
Footer
