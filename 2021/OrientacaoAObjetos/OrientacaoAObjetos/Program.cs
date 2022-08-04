using System;
using OrientacaoAObjetos.Funcionarios;

<<<<<<< HEAD
=======

>>>>>>> aula6
namespace OrientacaoAObjetos
{
    class MainClass
    {
        public static void Main(string[] args)
        {
<<<<<<< HEAD
            
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



=======
            //ContagemDeFuncionario();
            CalcularBonificacoes();

        }

        public static void CalcularBonificacoes()
        {
            GerenciadorDeBonficacao gerenciador = new GerenciadorDeBonficacao();

            Diretor marcia = new Diretor("123.456.789-00");
            marcia.Nome = "Marcia Gomes Azevedo";
            marcia.Senha = "123";
            
            Designer luana = new Designer("12345678");
            luana.Nome = "Luana Albertoni";

            Auxiliar jose = new Auxiliar("2323232323");
            jose.Nome = "José Oliveira";

            GerenteDeConta camila = new GerenteDeConta("90909090909");
            camila.Nome = "Camila Soares";

            gerenciador.Registrar(marcia);
            gerenciador.Registrar(luana);
            gerenciador.Registrar(jose);
            gerenciador.Registrar(camila);

            //Console.WriteLine("Total de bonificações: " + gerenciador.GetBonificacao());

            SistemaInterno sis = new SistemaInterno();

            sis.Logar(camila, "123");
        }

        public static void ContagemDeFuncionario()
        {   
            Diretor marcia = new Diretor("123.456.789-00");
            marcia.Nome = "Marcia Gomes Azevedo";
>>>>>>> aula6
        }
    }
}
