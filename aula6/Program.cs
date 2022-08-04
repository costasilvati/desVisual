using System;
using OrientacaoAObjetos.Funcionarios;


namespace OrientacaoAObjetos
{
    class MainClass
    {
        public static void Main(string[] args)
        {
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
        }
    }
}
