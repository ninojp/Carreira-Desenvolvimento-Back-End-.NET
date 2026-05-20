using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using UsuarioApi.Authorization;
using UsuarioApi.Data;
using UsuarioApi.Models;
using UsuarioApi.Services;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
//AddScoped: Uma nova instância é criada para cada solicitação HTTP, e a mesma instância é compartilhada dentro dessa solicitação. Isso é útil para serviços que precisam manter estado durante a solicitação, mas não devem ser compartilhados entre solicitações.
//AddTransient: Uma nova instância é criada cada vez que o serviço é solicitado. Isso é útil para serviços leves e sem estado, onde a criação de uma nova instância não tem um impacto significativo no desempenho.
//AddSingleton: Uma única instância é criada e compartilhada por toda a aplicação. Isso é útil para serviços que mantêm estado global ou são caros de criar, mas deve ser usado com cuidado para evitar problemas de concorrência.
//--------------------------------------------------------------------------------
//var conectString = builder.Configuration.GetConnectionString("UsuarioConnection");
var conectString = builder.Configuration["ConnectionStrings:UsuarioConnection"];

builder.Services.AddDbContext<UsuarioDbContext>(opts => {
        opts.UseSqlServer(conectString);
    });
//-------------------------------------------------------------
builder.Services.AddIdentity<Usuario, IdentityRole>(options =>
{
    // Configurações de senha mais permissivas para desenvolvimento
    options.Password.RequireDigit = false;
    options.Password.RequireLowercase = false;
    options.Password.RequireUppercase = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequiredLength = 4;
    // Configurações de usuário
    options.User.RequireUniqueEmail = false;
})
    .AddEntityFrameworkStores<UsuarioDbContext>()
    .AddDefaultTokenProviders();
//--------------------------------------------------

builder.Services.AddAutoMapper(config => { config.AddMaps(typeof(Program).Assembly); });
//---------------------------------------------------------------------------------------

builder.Services.AddSingleton<IAuthorizationHandler, IdadeAuthorization>();
//-----------------------------------------------------------------------------------------

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["SymmetricSecurityKey"])),
        ValidateIssuer = false,
        ValidateAudience = false,
        ClockSkew = TimeSpan.Zero
    };
});
//-----------------------------------------------------------------------------------------

builder.Services.AddAuthorization(options => { options.AddPolicy("IdadeMinima", policy => 
    policy.AddRequirements(new IdadeMinima(18)));
});
//-----------------------------------------------

builder.Services.AddScoped<UsuarioService>();
builder.Services.AddScoped<TokenService>();
//----------------------------------------------------------------------

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
//================================================================================

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}
//------------------------

app.UseHttpsRedirection();
//------------------------

app.UseAuthentication();

app.UseAuthorization();
//---------------------

app.MapControllers();
//-------------------

app.Run();
