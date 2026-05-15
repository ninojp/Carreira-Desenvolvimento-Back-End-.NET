using System.ComponentModel.DataAnnotations;

namespace UsuarioApi.Data.Dtos;

public class CreateUsuarioDto
{
    [Required]
    public string UserName { get; set; }

    [Required]
    public DateTime DataNascimento { get; set; }

    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; }

    [Required]
    [Compare("Password", ErrorMessage = "As senhas não coincidem.")]
    public string RePassword { get; set; }

}
