using System.ComponentModel.DataAnnotations;

namespace APIExemplo.Models
{
    public class Medicamento
    {
        [Key]
        public int IdMedicamento { get; set; }
        public string Descricao { get; set; }
        public string Lote { get; set; }
        public int MesVencimento { get; set; }
        public int AnoVencimento { get; set; }
        public string Marca { get; set; }
        public string Fabricante { get; set; }

    }
}
