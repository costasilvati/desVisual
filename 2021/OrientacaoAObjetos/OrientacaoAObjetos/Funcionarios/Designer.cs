using System;
namespace OrientacaoAObjetos.Funcionarios
{
    public class Designer : Funcionario
    {
        public Designer(string cpf) : base(cpf, 3000.00)
        {
            Console.WriteLine("Criando DESIGNER");
        }

        public override double GetBonificacao() //Sobrescrita de método da super classe
        {
            return Salario * 0.17;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.11;
        }
    }
}
