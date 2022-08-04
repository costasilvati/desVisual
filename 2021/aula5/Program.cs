using System;
using OrientacaoAObjetos.Funcionarios;

namespace OrientacaoAObjetos
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            
            Funcionario carlos = new Funcionario();
            carlos.Cpf = "546.789.000-11";
            carlos.Nome = "Carlos da Silva";
            carlos.Salario = 2500.00;
            GerenciadorDeBonficacao gerenciador = new GerenciadorDeBonficacao();
            gerenciador.Registrar(carlos);

            Console.WriteLine("Nome: " + carlos.Nome + " - Bonificação: " + carlos.GetBonificacao());

            Diretor marcia = new Diretor();
            marcia.Nome = "Marcia Gomes Azevedo";
            marcia.Salario = 5000.00;
            marcia.Cpf = "123.456.789-00";
            //gerenciador.Registrar(marcia);
            Console.WriteLine(marcia.getBonificacao());
            Console.WriteLine("Total de bonificação: " + gerenciador.GetBonificacao());



        }
    }
}
