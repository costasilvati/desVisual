using System;
namespace poo
{
    public class Funcionario
    {
        public string Nome {get; set;}
        public string Cpf { get; set;}
        public double Salario { get; set; }
        public static int TotalFuncionarios {get; private set;}
        public double PercentBonif { get; set;}

        public Funcionario(string cpf)
        {
            this.Cpf = cpf;
            TotalFuncionarios++;
        }

        public double GetBonificacao()
        {
            return this.Salario * this.PercentBonif;
        }

        public void AumentarSalario()
        {
            //this.Salario = (this.Salario * 0.1) + this.Salario;
            //this.Salario = this.Salario * 1.1;
            this.Salario *= 0.1;
        }

        override
        public string ToString()
        {
            return $"Nome: {this.Nome} \n" +
                $"Cpf: {this.Cpf} \n" +
                $"Total Funcionarios: {TotalFuncionarios}";
        }
    }
}
