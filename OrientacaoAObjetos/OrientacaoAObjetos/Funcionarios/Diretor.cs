using System;
namespace OrientacaoAObjetos.Funcionarios
{
    public class Diretor : Funcionario //herança
    {
        public override double GetBonificacao() //Sobrescrita de método da super classe
        {
            return Salario;
        }
    }
}
