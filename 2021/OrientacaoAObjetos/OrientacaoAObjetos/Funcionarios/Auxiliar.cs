using System;
namespace OrientacaoAObjetos.Funcionarios
{
    public class Auxiliar : Funcionario
    {
        public Auxiliar(string cpf) : base(cpf, 2000.00)
        {
            Console.WriteLine("Criando AUXILIAR");
        }

        public override double GetBonificacao() //Sobrescrita de método da super classe
        {
            return Salario * 0.20;
        }

        public override void AumentarSalario()
        {
            Salario *= 0.1;
        }
    }
}
