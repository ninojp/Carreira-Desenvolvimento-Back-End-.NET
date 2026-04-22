using FilmesAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilmesAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class FilmeController : ControllerBase
{
    private static List<Filme> filmes = new();

    private static int id = 0;
    //=================================================================
    [HttpPost]
    public IActionResult AdicionaFilme([FromBody]Filme filme)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        filme.Id = id++;
        filmes.Add(filme);
        Console.WriteLine($"O filme {filme.Id}: {filme.Titulo}, {filme.Duracao} minutos, foi adicionado.");
        return CreatedAtAction(nameof(RecuperaFilmePorId), new { id = filme.Id }, filme);
    }
    //=================================================================
    [HttpGet]
    public IEnumerable<Filme> RecuperaFilmes([FromQuery] int skip = 0, [FromQuery] int take = 10)
    {
        return filmes.Skip(skip).Take(take);
    }
    //=================================================================
    [HttpGet("{id}")]
    public IActionResult RecuperaFilmePorId(int id)
    {
        //if (id < 0 || id >= filmes.Count)
        //{
        //    return NotFound();
        //}
        //return Ok(filmes[id]);
        return filmes.FirstOrDefault(filme => filme.Id == id) is Filme filme ? Ok(filme) : NotFound();
    }
}
