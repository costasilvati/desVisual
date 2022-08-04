using System;
namespace OrientacaoAObjetos.Funcionarios
{
<<<<<<< HEAD
    public class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public double Salario { get; set; }
        private int _tipo;

        public Funcionario (int tipo)
        {
            this._tipo = tipo;
        }

        public Funcionario() { }

        public virtual double GetBonificacao() // é possível que outra classe mude seu comortamento
        {
            // 0 - funcionario
            // 1 - diretor
            // 2 - designer
            if(this._tipo == 1)
            {
                return Salario;
            }
            return Salario * 0.10;
        }

=======
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
        
>>>>>>> aula6
    }
}