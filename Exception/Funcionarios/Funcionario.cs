using System;
namespace OrientacaoAObjetos.Funcionarios
{
    public abstract class Funcionario
    //public class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public double Salario { get; protected set; }
        public static int TotalDeFuncionarios { get; private set; }


        public Funcionario(double salario, string cpf)
        {
            Console.WriteLine("Criando FUNCIONARIO");

            Cpf = cpf;
            Salario = salario;

            TotalDeFuncionarios++;
        }
        /*
        public virtual void AumentarSalario()
        {
            //Salario = Salario + (Salario * 0.1); 
            //Salario = Salario * 1.1; 
            Salario *= 1.1;
        }
        public virtual double GetBonificacao()
        { 
            return Salario * 0.10;
        }
         */

        public abstract void AumentarSalario();

        public abstract double GetBonificacao();

        

    }
}