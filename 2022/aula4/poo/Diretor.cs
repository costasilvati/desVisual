using System;
namespace poo
{
    public class Diretor : Funcionario
    {
        public string senha;

        public Diretor(string cpf) : base(cpf)
        {
        }


        public void AumentarSalario()
        {
            this.Salario *= 0.15;
        }

        public double GetBonificacao(double lucro)
        {
            return (this.Salario * this.PercentBonif) + lucro;
        }
    }
}
