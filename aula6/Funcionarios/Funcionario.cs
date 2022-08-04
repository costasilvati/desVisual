using System;
namespace OrientacaoAObjetos.Funcionarios
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public double Salario { get; protected set; }
        public static int TotalDeFuncionario { get; private set; }


        public Funcionario(string cpf, double salario)
        {
            Cpf = cpf;
            Salario = salario;
            TotalDeFuncionario++;
            
        }

        public abstract void AumentarSalario();
        public abstract double GetBonificacao();
        
    }
}