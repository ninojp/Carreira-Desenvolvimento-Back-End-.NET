using AutoMapper;
using Microsoft.AspNetCore.Identity;
using UsuarioApi.Data.Dtos;
using UsuarioApi.Models;

namespace UsuarioApi.Services;

public class CadastroService
{
    private IMapper _mapper;
    private UserManager<Usuario> _userManager;

    public CadastroService(IMapper mapper, UserManager<Usuario> userManager)
    {
        _mapper = mapper;
        _userManager = userManager;
    }

    public async Task Cadastra(CreateUsuarioDto dtoUsuario)
    {
        Usuario usuario = _mapper.Map<Usuario>(dtoUsuario);
        IdentityResult resultado = await _userManager.CreateAsync(usuario, dtoUsuario.Password);
        if(!resultado.Succeeded)
        {
            throw new Exception("Houve uma falha ao cadastrar o usuário!");
        }
    }
}
