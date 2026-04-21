using FilmesAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilmesAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class FilmeController : ControllerBase
{
    private static List<Filme> filmes = new();

    [HttpPost]
    public IActionResult AdicionaFilme([FromBody]Filme filme)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        filmes.Add(filme);
        Console.WriteLine($"Filme, {filme.Titulo} adicionado.");
        Console.WriteLine($"Duração do filme: {filme.Duracao} minutos");
        return CreatedAtAction(nameof(AdicionaFilme), new { titulo = filme.Titulo }, filme);
    }
}
