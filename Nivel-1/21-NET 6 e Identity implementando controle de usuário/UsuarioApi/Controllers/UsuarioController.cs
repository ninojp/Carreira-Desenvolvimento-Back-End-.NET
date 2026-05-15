using Microsoft.AspNetCore.Mvc;
using UsuarioApi.Data.Dtos;

namespace UsuarioApi.Controllers;

[ApiController]
[Route("[controller]")]
public class UsuarioController : ControllerBase
{
    [HttpPost]
    public IActionResult CadastrarUsuario(CreateUsuarioDto dtoUsuario)
    {
        throw new NotImplementedException();
    }
}
