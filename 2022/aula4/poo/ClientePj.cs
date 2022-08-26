using System;
namespace poo
{
    public class ClientePj : Cliente
    {
        private string Cnpj { get; set; }

        public ClientePj(string nome, string cnpj) : base(nome)
        {
            this.Cnpj = cnpj;
        }
    }
}
