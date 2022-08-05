using System;

namespace DesSoftVisual
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /*
            Console.WriteLine("Olá projeto Des. Software Visual!!");
            double nota = 6.5;
            Console.WriteLine(nota);
            string nome = "Juliana";
            Console.WriteLine(nome + " - " + nota);
            double soma = nota + 1;
            Console.WriteLine(soma);
            */

            /*
            
            1 - Receba 3 valores e imprima o maior valor;
            2 - Receba 3 valores e imprima o menor valor;
            3 - Receba 3 valores e exiba esses valores em
                ordem descrescente;
            */
            int ordem1, ordem2, ordem3;

            Console.WriteLine("Digite o valor 1");
            int valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor 2");
            int valor2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor 3");
            int valor3 = int.Parse(Console.ReadLine());

            // 1 - Receba 3 valores e imprima o maior valor;
            Console.WriteLine("Valores: "+ valor1 + " - "+ valor2 + " - " + valor3 );
            int maior = 0;
            if (valor1 > valor2 && valor1 > valor3)
            {
                maior = valor1;
            }else if (valor2 > valor1 && valor2 > valor3)
            {
                maior = valor2;
            }else if (valor3 > valor1 && valor3 > valor2)
            {
                maior = valor3;
            }
            else
            {
                Console.WriteLine("Os valores são iguais");
            }
            
            Console.WriteLine(maior + " é o maior valor");


            // Menor valor
            int menor = 0;
            if (valor1 < valor2 && valor1 < valor3)
            {
                menor = valor1;
            }
            else if (valor2 < valor1 && valor2 < valor3)
            {
                menor = valor2;
            }
            else if (valor3 < valor1 && valor3 < valor2)
            {
                menor = valor3;
            }
            else
            {
                Console.WriteLine("Os valores são iguais");
            }

            Console.WriteLine(menor + " é o menor valor");

            // 3 - Receba 3 valores e exiba esses valores em ordem descrescente;
            int item2 = 0;
            /*
                123
                132
                213
                231
                312
                321
            */

            if((maior == valor1 && menor == valor2) || (maior == valor2 && menor == valor1))
            {
                item2 = valor3;
            }
            else if ((maior == valor1 && menor == valor3)|| (maior == valor3 && menor == valor1))
            {
                item2 = valor2;
            }
            else if ((maior == valor2 && menor == valor3) || (maior == valor3 && menor == valor2))
            {
                item2 = valor1;
            }

            Console.WriteLine("Ordem descrescente " + maior + " - "+ item2 + " - " + menor);

        }
    }
}
