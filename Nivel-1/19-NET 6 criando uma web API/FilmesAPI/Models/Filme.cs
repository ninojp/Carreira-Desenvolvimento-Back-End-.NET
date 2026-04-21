using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Models;

public class Filme
{
    [Required(ErrorMessage = "O título é obrigatório.")]
    public string Titulo { get; set; }

    [Required(ErrorMessage = "O gênero é obrigatório.")]
    [StringLength(50, ErrorMessage = "O gênero deve ter no máximo 50 caracteres.")]
    public string Genero { get; set; }

    [Required(ErrorMessage = "A duração é obrigatória.")]
    [Range(70, 600, ErrorMessage = "A duração deve estar entre 70 e 600 minutos.")]
    public int Duracao { get; set; }
}
