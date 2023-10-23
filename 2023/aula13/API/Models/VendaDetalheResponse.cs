namespace APIExemplo.Models
{
    public class VendaDetalhadaResponse
    {
        public int VendaId { get; set; }
        public DateTime DataVenda { get; set; }
        public double Total { get; set; }
        public List<Produto> Produtos { get; set; }
    }

}
