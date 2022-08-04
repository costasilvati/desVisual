using System;

namespace CaracteresETextos
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 3 TEXTOS");
            //character
            char letra = ' ';
            Console.WriteLine(letra);
            letra = (char)61; // ASCII
            Console.WriteLine(letra);
            letra = (char)(letra + 1);
            Console.WriteLine(letra);

            // string
            string palavra = "ADS Positivo";
            Console.WriteLine(palavra);
            string frase =
@"Aluno1
Aluno2
Aluno3";
            Console.WriteLine(frase);

        }
    }
}
