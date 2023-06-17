using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Data.Dtos;

public class UpdateFilmeDtos
{
    [Required(ErrorMessage = "O campo não pode ser vazio")]
    public string Titulo { get; set; }
    [Required(ErrorMessage = "O campo não pode ser vazio")]
    [StringLength(50, ErrorMessage = "O campo não pode conter mais que 50 caracteres")]
    [MinLength(3, ErrorMessage = "O campo não pode conter menos do 3 caracters")]
    public string Genero { get; set; }
    [Range(70, 500, ErrorMessage = "Duração minima deverá ser 70 e a maxima devera ser 500")]
    public int Duracao { get; set; }
}
