using System;
namespace OrientacaoAObjetos.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel
    {

        public Diretor(string cpf): base (5000, cpf)
        {
            Console.WriteLine("Criando DIRETOR");
        }

        public override double GetBonificacao()
        {
            return Salario * 0.5; //+ base.GetBonificacao();
        }

        public override void AumentarSalario()
        { 
            Salario *= 1.15;
        }
        /*
         * public Diretor(string cpf) : base(5000, cpf)
        {
            Console.WriteLine("Criando DIRETOR");
        }
        
        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }

        public override double GetBonificacao()
        {
            return Salario * 0.5;
        }
         */
    }
}