using System;
namespace poo
{
    public class Cliente
    {
        public string nome;
        public string cpf;
        public DateTime nascimento;
        public string email;
        public string fone;

        public Cliente(string cpf, string nome)
        {
            this.cpf = cpf;
            this.nome = nome;
        }

        override
        public string ToString()
        {
            return $"Nome: {this.nome} \n" +
                $"CPF: {this.cpf}\n" +
                $"E-mail: {this.email}";
        }
    }
}
