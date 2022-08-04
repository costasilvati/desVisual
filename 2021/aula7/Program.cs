using System;
using OrientacaoAObjetos.Funcionarios;
using OrientacaoAObjetos.Sistemas;

namespace OrientacaoAObjetos
{
    class MainClass
    {
        public static void Main(string[] args) 
        {
            //CalcularBonificacao();
            //UsarSistema();
            // Testes();
            try
            {
                Excecoes();
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Argumento com problema " + e.ParamName);
                Console.WriteLine(e.Message);
            }
            catch(SaldoNegativoException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Exceção do tipo SaldoNegativoException");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Sistema executado");
        }

        public static void Testes()
        {
            Dividir(0, 9);
        }

        public static void Dividir(int divisor, int dividendo)
        {
            try
            {
                int resultado = dividendo / divisor;
                Console.WriteLine(resultado);
            }
            catch (DivideByZeroException erro)
            {
                Console.WriteLine(erro.Message);
                Console.WriteLine(erro.StackTrace);
                Console.WriteLine("Não é possível dividir por 0");
            }
        }

        public static void Excecoes()
        {
            Cliente juliana = new Cliente();
            juliana.Nome = "Juliana Costa";
            ContaCorrente contaJu = new ContaCorrente(123, 456);
            contaJu.Titular = juliana;
            contaJu.Saldo = 15989.9;
            contaJu.Sacar(50.0);
            //Console.WriteLine("Saldo Juliana: " + contaJu.Saldo);

            Cliente jose = new Cliente();
            jose.Nome = "Jose da Silva";
            ContaCorrente contaJose = new ContaCorrente(123, 4545454);
            contaJose.Titular = jose;
            //Console.WriteLine("Saldo Jose: " + contaJose.Saldo);

            if(contaJu.Transferir(-150.0, contaJose))
            {
                Console.WriteLine("Transferencia feita com sucesso!");
            }
            else
            {
                Console.WriteLine("Erro na transferencia");
            }
            Console.WriteLine("Novo Saldo Juliana: " + contaJu.Saldo);
            Console.WriteLine("Novo Saldo Jose: " + contaJose.Saldo);

        }

        public static void CalcularBonificacao()
        {
            GerenciadorDeBonficacao gerenciadorBonificacao = new GerenciadorDeBonficacao();

            Designer pedro = new Designer("833.222.048-39");
            pedro.Nome = "Pedro";

            Diretor roberta = new Diretor("159.753.398-04");
            roberta.Nome = "Roberta";

            Auxiliar igor = new Auxiliar("981.198.778-53");
            igor.Nome = "Igor";

            GerenteDeConta camila = new GerenteDeConta("326.985.628-89");
            camila.Nome = "Camila";

            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(igor);
            gerenciadorBonificacao.Registrar(camila);

            Console.WriteLine("Total de bonificações do mês " +
                gerenciadorBonificacao.GetTotalBonificacao());
        }

        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor roberta = new Diretor("159.753.398-04");
            roberta.Nome = "Roberta";
            roberta.Senha = "123";

            GerenteDeConta camila = new GerenteDeConta("326.985.628-89");
            camila.Nome = "Camila";
            camila.Senha = "abc";

            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "123456";

            sistemaInterno.Logar(parceiro, "123456");

            sistemaInterno.Logar(roberta, "123");
            sistemaInterno.Logar(camila, "123");
        }
    }
}
