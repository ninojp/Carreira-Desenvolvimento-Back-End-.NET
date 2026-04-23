using AutoMapper;
using FilmesAPI.Data;
using FilmesAPI.Data.Dtos;
using FilmesAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilmesAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class FilmeController : ControllerBase
{
    //private static List<Filme> filmes = new();
    //private static int id = 0;

    private FilmeContext _context;
    private IMapper _mapper;

    public FilmeController(FilmeContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    //=================================================================
    [HttpPost]
    public IActionResult AdicionaFilme([FromBody] CreateFilmeDTO filmeDto)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        //filme.Id = id++;
        Filme filme = _mapper.Map<Filme>(filmeDto);
        _context.Filmes.Add(filme);
        _context.SaveChanges();
        Console.WriteLine($"O filme {filme.Id}: {filme.Titulo}, {filme.Duracao} minutos, foi adicionado.");
        return CreatedAtAction(nameof(RecuperaFilmePorId), new { id = filme.Id }, filme);
    }
    //=================================================================
    [HttpGet]
    public IEnumerable<Filme> RecuperaFilmes([FromQuery] int skip = 0, [FromQuery] int take = 10)
    {
        return _context.Filmes.Skip(skip).Take(take);
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
        return _context.Filmes.FirstOrDefault(filme => filme.Id == id) is Filme filme ? Ok(filme) : NotFound();
    }
}
