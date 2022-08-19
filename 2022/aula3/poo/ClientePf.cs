using System;
namespace poo
{
    public class ClientePf : Cliente
    {
        private string Cpf { get; set; }
        private DateTime Nascimento { get; set; }

        public ClientePf(string nome, string cpf) : base(nome)
        {
            this.Cpf = cpf;
        }

        
    }
}
