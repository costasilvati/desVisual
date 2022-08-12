using System;
/*
 * Receba um valor e imprima todos valores entre
 *  1 e o valor recebido;
 */
namespace aula2_1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /*
            Console.WriteLine("Imprime " +
                " todos os valores de 1 até o " +
                "valor digitado");
            Console.WriteLine("Digite um valor:");
            
            int valorDigitado = 0;
            string txtDigitado = Console.ReadLine();
            valorDigitado = int.Parse(txtDigitado);
            
            int valorDigitado = int.Parse(Console.ReadLine());

            for(int i = 1; i <= valorDigitado; i++)
            {
                Console.Write(i + " - ");
            }
            */
            string menu = "--- Projeto ----- \n" +
                "1 - Fatorial; \n" +
                "2 - Ver valores de 1 até N \n" +
                "3 - Sair;";
            int option = 3;
            do
            {
                Console.WriteLine(menu);
                option = int.Parse(Console.ReadLine());
            } while (option != 3);

        }
    }
}
