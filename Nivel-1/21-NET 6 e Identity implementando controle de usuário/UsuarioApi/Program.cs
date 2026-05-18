using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using UsuarioApi.Data;
using UsuarioApi.Models;
using UsuarioApi.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var conectString = builder.Configuration.GetConnectionString("UsuarioConnection");
builder.Services.AddDbContext<UsuarioDbContext>(opts => {
        opts.UseSqlServer(conectString);
    });

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

builder.Services.AddAutoMapper(config => { config.AddMaps(typeof(Program).Assembly); });

builder.Services.AddScoped<CadastroService>();
//builder.Services.AddTransient<CadastroService>();
//builder.Services.AddSingleton<CadastroService>();

//================================================================================

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
