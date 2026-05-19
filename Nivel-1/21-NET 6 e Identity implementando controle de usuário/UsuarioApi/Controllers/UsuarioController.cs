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
    private UsuarioService _usuarioService;

    public UsuarioController(UsuarioService cadastroService)
    {
        _usuarioService = cadastroService;
    }

    [HttpPost("cadastra")]
    public async Task<IActionResult> CadastraUsuario(CreateUsuarioDto dtoUsuario)
    {
        await _usuarioService.Cadastra(dtoUsuario);
        return Ok("Usuario cadastrado com Sucesso!");
    }

    [HttpPost("login")]
    public async Task<IActionResult> LoginUsuario(LoginUsuarioDto dtoUsuario)
    {
        var token = await _usuarioService.Login(dtoUsuario);
        return Ok(token);
    }
}
