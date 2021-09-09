using System;
using OrientacaoAObjetos.Funcionarios;

namespace OrientacaoAObjetos

{
    public class SistemaInterno
    {
        public bool Logar(IAutenticavel f, string senha)
        {
            bool userAut = f.Autenticar(senha);
            if (userAut)
            {
                Console.WriteLine("Bem-vindo ao sistema!");
                return true;
            }
            else
            {
                Console.WriteLine("Senha inválida");
                return false;
            }
        }

    }
}