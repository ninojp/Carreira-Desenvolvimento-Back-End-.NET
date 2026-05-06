using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Models;

public class Cinema
{
    [Key]
    [Required]
    public int Id { get; set; }

    [Required(ErrorMessage = "O campo de nome é obrigatório.")]
    public string Nome { get; set; }

    public int EnderecoId { get; set; }
    //relação de um para um, onde um cinema tem um endereço e um endereço pertence a um cinema
    public virtual Endereco Endereco { get; set; }
}
