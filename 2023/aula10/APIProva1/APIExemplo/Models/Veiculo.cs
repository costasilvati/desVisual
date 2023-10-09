using System.ComponentModel.DataAnnotations;

namespace APIExemplo.Models;

public class Veiculo
{
    [Key]
    public int IdVeiculo { get; set; }
    public string Descricao { get; set; }
    public int Ano { get; set; }
    public string Modelo { get; set; }
    public string Placa { get; set; }
    public string Marca { get; set; }
    public string Cor { get; set; }

}
