using System;

namespace LacosDeRepeticao
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 5 - LAÇOS DE REPETIÇÃO");

            int contador = 1;
            int total = 0;

            while(contador <= 10)
            {
                total += contador;
                Console.WriteLine("Contador: " + contador + " Total: " + total);
                contador++;
            }

            // FOR

            for(int i=0; i < 10; i++)
            {
                Console.WriteLine("i: " + i);
            }
        }
    }
}
