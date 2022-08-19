using System;
namespace poo
{
    public class Cliente
    {
        private string Nome { get; set; }
        private string Email { get; set; }
        private string Fone { get; set; }

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
