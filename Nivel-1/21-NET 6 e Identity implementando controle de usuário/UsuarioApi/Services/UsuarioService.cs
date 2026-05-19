using AutoMapper;
using Microsoft.AspNetCore.Identity;
using UsuarioApi.Data.Dtos;
using UsuarioApi.Models;

namespace UsuarioApi.Services;

public class UsuarioService
{
    private IMapper _mapper;
    private UserManager<Usuario> _userManager;
    private SignInManager<Usuario> _signInManager;
    private TokenService _tokenService;

    public UsuarioService(IMapper mapper, UserManager<Usuario> userManager, SignInManager<Usuario> signInManager, TokenService tokenService)
    {
        _mapper = mapper;
        _userManager = userManager;
        _signInManager = signInManager;
        _tokenService = tokenService;
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

    public async Task<string> Login(LoginUsuarioDto dtoUsuario)
    {
        var resultado = await _signInManager.PasswordSignInAsync(dtoUsuario.UserName, dtoUsuario.Password, false, false);
        if(!resultado.Succeeded)
        {
            throw new Exception("Falha ao realizar login!");
        }
        //var usuario = await _userManager.FindByNameAsync(dtoUsuario.UserName);
        var usuario = _signInManager.UserManager.Users.FirstOrDefault(
            u => u.NormalizedUserName == dtoUsuario.UserName.ToUpper()
            );
        var token = _tokenService.GenerateToken(usuario);
        return token;
    }

}
