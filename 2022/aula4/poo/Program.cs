using System;

namespace poo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Funcionario func1 = new Funcionario();
            
            Funcionario func2 = new Funcionario();

            Console.WriteLine("Total de Funcionários " +
                Funcionario.TotalFuncionarios);


        }
    }
}