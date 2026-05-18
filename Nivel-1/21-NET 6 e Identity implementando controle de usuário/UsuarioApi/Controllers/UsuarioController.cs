using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using UsuarioApi.Data.Dtos;
using UsuarioApi.Models;
using UsuarioApi.Services;

namespace UsuarioApi.Controllers;

[ApiController]
[Route("[controller]")]
public class UsuarioController: ControllerBase
{
    private CadastroService _cadastroService;

    public UsuarioController(CadastroService cadastroService)
    {
        _cadastroService = cadastroService;
    }

    [HttpPost]
    public async Task<IActionResult> CadastraUsuario(CreateUsuarioDto dtoUsuario)
    {
        await _cadastroService.Cadastra(dtoUsuario);
        return Ok("Usuario cadastrado com Sucesso!");
    }
}
