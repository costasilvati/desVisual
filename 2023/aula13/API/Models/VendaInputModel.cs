namespace APIExemplo.Models
{
    public class VendaInputModel
    {
        public DateTime Data { get; set; }
        public double Total { get; set; }
        public List<int> ProdutosIds { get; set; }
    }

}
