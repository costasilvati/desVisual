using System;
using OrientacaoAObjetos.Enderecos;

namespace OrientacaoAObjetos
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime Nascimento { get; set; }
        public Endereco Endereco { get; set; }


    }
}
