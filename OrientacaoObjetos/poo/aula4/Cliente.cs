using System;
namespace poo
{
    public class Cliente
    {
        private string nome;
        private string cpf;
        private DateTime nascimento;
        private string profissao;
        private string empresa;
        private string pai;
        private string mae;
        // Classe endereco implementar e outras necessárias
        public string logradouro;
        public int numero;
        public string bairro;
        public string cidade;
        public string cep;
        public string uf;
        private string email;
        private string fone;


        /*
         * Atalho
         * prop + tab + tab
         * tipo do atributo
         * nome do atributo
         * ENTER
         */
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime Nascimento { get; set; }
        public string Profissao { get; set; }
        public string Empresa { get; set; }
        public string Pai { get; set; }
        public string Mae { get; set; }

    }
}
