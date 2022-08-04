using System;

namespace OrientacaoAObjetos.Funcionarios
{
    public class GerenteDeConta : FuncionarioAutenticavel
    {
        public GerenteDeConta(string cpf) : base(cpf, 4000.00)
        {
            Console.WriteLine("Criando GERENTE DE CONTAS");
        }

        public override double GetBonificacao() //Sobrescrita de método da super classe
        {
            return Salario * 0.25;
        }

        public override void AumentarSalario()
        {
            Salario *= 0.05;
        }
    }
}
