using System;
using System.Collections;

namespace AppCartoes
{
    public class Cartao
    {
        Usuario Titular { get; set; }
        string Numero { get; set; }
        int Vencimento { get; set; }
        string codigoSeguranca { get; set; }
        double Limite { get; set; }
        double LimiteUtilizado { get; set; }
        ArrayList Lancamentos { get; set; }

        public Cartao(Usuario titular)
        {
            this.Titular = titular;
            this.Lancamentos = new ArrayList();
        }

    }
}
