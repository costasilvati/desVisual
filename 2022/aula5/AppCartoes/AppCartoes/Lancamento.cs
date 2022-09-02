using System;
namespace AppCartoes
{
    public class Lancamento
    {
        Cartao CartaoId { get; set; }
        DateTime DataLancamento { get; set; }
        string Nome { get; set; }


        public Lancamento(Cartao cartaoId)
        {
            this.CartaoId = cartaoId;
        }
    }
}
