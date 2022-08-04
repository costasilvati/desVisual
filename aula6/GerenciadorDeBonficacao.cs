using System;
using OrientacaoAObjetos.Funcionarios;
namespace OrientacaoAObjetos
{
    public class GerenciadorDeBonficacao
    {
        private double _totalBonificacao;

        public void Registrar(Funcionario funcionario)
        {
            _totalBonificacao += funcionario.GetBonificacao();
        }
        //Sobrecarga do método registrar
        // Para cada tipo de funcionário teremos que escrever um novo método
        /*
        public void Registrar(Diretor funcionario)
        {
            _totalBonificacao += funcionario.GetBonificacao();
        }
        */
        public double GetBonificacao()
        {
            return _totalBonificacao;
        }
    }
}
