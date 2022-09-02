using System;
using System.Collections;

namespace AppCartoes
{
    public class Usuario
    {
        string Nome { get; set; }
        DateTime Nascimento { get; set; }
        string Cpf { get; set; }
        ArrayList Email{get; set;}
        ArrayList Fone { get; set; }
        ArrayList Catoes { get; set; }

        public Usuario(string cpf)
        {
            this.Cpf = cpf;
            this.Catoes = new ArrayList();
            this.Email = new ArrayList();
            this.Fone = new ArrayList();
        }

        public bool cadastraUsuario()
        {
            Console.WriteLine("Email do usuário");
            this.Email.Add(Console.ReadLine());
            return true;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
