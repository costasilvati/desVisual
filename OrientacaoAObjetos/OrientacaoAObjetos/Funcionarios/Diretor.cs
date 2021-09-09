using System;
namespace OrientacaoAObjetos.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel
    {
        public Diretor(string cpf) : base(cpf, 5000.00)
        {
            Console.WriteLine("Criando DIRETOR");
        }

        public override double GetBonificacao() //Sobrescrita de método da super classe
        {
            return Salario * 0.5;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }
    }
}
