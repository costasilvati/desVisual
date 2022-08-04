using System;
using OrientacaoAObjetos.Funcionarios;

namespace OrientacaoAObjetos.Sistemas
{
    public class SistemaInterno
    {
        public bool Logar(Funcionario funcionario, string senha)
        {
            if(senha == funcionario.Senha)
            {
                Console.WriteLine("Logado com sucesso!");
            }
            else
            {
                Console.WriteLine("Senha incorreta");
            }
        }
    }
}
