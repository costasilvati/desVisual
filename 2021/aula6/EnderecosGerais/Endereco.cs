namespace OrientacaoAObjetos.Enderecos
{
    public class Endereco
    {
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Cep { get; set; }
        public string Bairro { get; set; }
        public Cidade DadosCidade { get; set; }

    }
}
