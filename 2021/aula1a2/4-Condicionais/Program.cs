using System;

namespace Condicionais
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 4 - CONDICIONAIS");
            int idade = 16;
            //int numPessoas = 1;
            bool acompanhado = false;
            string mensagem;
            // mensagem discute o escopo da variável
            if (idade >= 18 || acompanhado == true) // && operador lógico E
            {
                mensagem = "Entrada liberada";
            }
            else
            {
                mensagem = "Entrada proibida. Menor de 18 anos sem acompanhante";
            }
            Console.WriteLine(mensagem);

            // Forma 2
            //if (idade >= 18)
            //{
            //    Console.WriteLine("Entrada liberada");
            //}
            //else
            //{
            //    if (numPessoas >= 2)
            //    {
            //        Console.WriteLine("Entrada liberada. Número de pessoas: " + numPessoas);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Entrada proibida. Menor de 18 anos!");
            //    }
            //}



        }
    }
}
