using System;
namespace poo
{
    public class Cliente
    {
        private string Nome { get; set; }
        public string Email { get; set; }
        public string Fone { get; set; }

        public Cliente(string nome)
        {
            this.Nome = nome;
        }

        override
        public string ToString()
        {
            return $"Nome: {this.Nome} \n" +
                $"E-mail: {this.Email} \n" +
                $"Fone: {this.Fone}";
        }
    }
}
