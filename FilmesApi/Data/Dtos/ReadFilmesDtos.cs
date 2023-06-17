using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Data.Dtos;

public class ReadFilmesDtos
{
    public string Titulo { get; set; }
    public string Genero { get; set; }
    public int Duracao { get; set; }
    public DateTime DataConsulta { get; set; } = DateTime.Now;
}
