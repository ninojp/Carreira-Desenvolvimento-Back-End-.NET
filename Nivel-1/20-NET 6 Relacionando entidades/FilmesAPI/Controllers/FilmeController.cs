using AutoMapper;
using FilmesAPI.Data;
using FilmesAPI.Data.Dtos;
using FilmesAPI.Models;
using Microsoft.AspNetCore.JsonPatch;
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
    /// <summary>
    /// Adiciona um novo filme ao banco de dados com base nos dados fornecidos.
    /// </summary>
    /// <remarks>O filme criado será persistido no banco de dados e o local do novo recurso será informado no
    /// cabeçalho Location da resposta. O método espera um corpo JSON compatível com o modelo CreateFilmeDTO.</remarks>
    /// <param name="filmeDto">O objeto que contém as informações do filme a ser criado. Deve incluir todos os campos obrigatórios definidos em
    /// CreateFilmeDTO. Não pode ser nulo.</param>
    /// <returns>Um resultado que indica o status da operação. Retorna 201 Created com os dados do filme criado se bem-sucedido;
    /// retorna 400 Bad Request se os dados fornecidos são inválidos.</returns>
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
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
    public IEnumerable<ReadFilmeDTO> RecuperaFilmes([FromQuery] int skip = 0, [FromQuery] int take = 10)
    {
        return _mapper.Map<List<ReadFilmeDTO>>(_context.Filmes.Skip(skip).Take(take));
    }
    //=================================================================
    [HttpGet("{id}")]
    public IActionResult RecuperaFilmePorId(int id)
    {
        var filme = _context.Filmes.FirstOrDefault(filme => filme.Id == id);
        if (filme == null) return NotFound();
        var filmeDto = _mapper.Map<ReadFilmeDTO>(filme);
        return Ok(filmeDto);
    }
    //=========================================================================================================
    [HttpPut("{id}")]
    public IActionResult AtualizaFilme(int id, [FromBody] UpdateFilmeDTO filmeDto)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);
        var filme = _context.Filmes.FirstOrDefault(filme => filme.Id == id);
        if (filme == null) return NotFound();
        _mapper.Map(filmeDto, filme);
        _context.SaveChanges();
        Console.WriteLine($"O filme {filme.Id}: {filme.Titulo}, {filme.Duracao} minutos, foi atualizado.");
        return NoContent();
    }
    //========================================================================================================
    [HttpPatch("{id}")]
    public IActionResult AtualizaFilmeParcial(int id, JsonPatchDocument<UpdateFilmeDTO> patch)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);
        var filme = _context.Filmes.FirstOrDefault(filme => filme.Id == id);
        if (filme == null) return NotFound();

        var filmeParaAtualizar = _mapper.Map<UpdateFilmeDTO>(filme);
        patch.ApplyTo(filmeParaAtualizar, ModelState);
        if (!TryValidateModel(filmeParaAtualizar)) return ValidationProblem(ModelState);

        _mapper.Map(filmeParaAtualizar, filme);
        _context.SaveChanges();
        Console.WriteLine($"O filme {filme.Id}: {filme.Titulo}, {filme.Duracao} minutos, foi atualizado.");
        return NoContent();
    }
    //========================================================================================================
    [HttpDelete("{id}")]
    public IActionResult DeletaFilme(int id)
    {
        var filme = _context.Filmes.FirstOrDefault(filme => filme.Id == id);
        if (filme == null) return NotFound();
        _context.Filmes.Remove(filme);
        _context.SaveChanges();
        Console.WriteLine($"O filme {filme.Id}: {filme.Titulo}, {filme.Duracao} minutos, foi deletado.");
        return NoContent();
    }
}
