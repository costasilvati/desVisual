using System;
using OrientacaoAObjetos.Sistemas;

namespace OrientacaoAObjetos
{
    public class ParceiroComercial : IAutenticavel
    {
        public string Senha { get; set; }

        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }
    }
}
