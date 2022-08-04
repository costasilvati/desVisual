using System;
using OrientacaoAObjetos.Funcionarios;

namespace OrientacaoAObjetos
{
    public class GerenciadorDeBonficacao
    {
        private static double _totalBonificacao { get; set; }

        public void Registrar(Funcionario funcionario)
        {
            _totalBonificacao += funcionario.GetBonificacao();
        }

        public double GetTotalBonificacao()
        {
            return _totalBonificacao;
        }

    }
}
