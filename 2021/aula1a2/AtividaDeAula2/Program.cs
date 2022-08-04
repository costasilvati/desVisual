using System;
//Desenvolva um projeto C# que imprima
// to dos os múltiplos de 3 entre 1 e 100; 


namespace AtividaDeAula2
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Iniciando o cálculo");
            for(int i = 1; i <= 100; i++)
            {
                if(i%3 == 0)
                {
                    Console.WriteLine(i + " é divisível por 3!");
                }
            }
            Console.WriteLine("Executado divisíveis por 3 com sucesso!");

            Console.WriteLine("------------------FATORIAL---------------------");
            int fatorial = 1;
            for(int numAtual = 1; numAtual <= 10; numAtual++)
            {
                fatorial = fatorial * numAtual;
            }
            Console.WriteLine("Fatorial: " + fatorial);
        }
    }
}
