# Curso Alura .NET 6: relacionando entidades

## Aula 1: Crescendo o projeto

### Aula 1: Apresentação - Vídeo 1

Transcrição  
Olá! Sou o Daniel e serei seu instrutor nesse curso de relacionamento com entidades .NET e Entity.

Daniel Artine é uma pessoa de pele clara, olhos castanhos escuros e cabelos pretos curtos. Usa barba e bigode. Está com camiseta preta, sentado em uma cadeira preta. Ao fundo, há uma parede com iluminação azul.

Neste curso, começaremos exatamente de onde paramos no curso anterior, vamos crescer o nosso projeto. Além de fazer a inserção de filmes, vamos também inserir cinemas, endereços e sessões.

Nosso sistema ficará mais complexo e completo.

Agora precisaremos relacionar os conceitos. Como um filme vai se relacionar com o cinema dentro do nosso sistema? Ou como o endereço do cinema pode ser recuperado através de uma consulta?

Faremos criações e mudanças através de migrations. Já vimos esse conceito no curso anterior e veremos mais nesse curso, pois vamos gerar novas migrations para alterar nosso banco de dados.

E faremos a construção dos modelos:

- Cinema.cs
- Endereco.cs
- Filme.cs
- Sessão.cs

Faremos também os devidos mapeamentos com o AutoMapper, usando as mesmas ferramentas do curso anterior.

Pré-requisitos  
Antes de começarmos, é muito importante que você tenha feito os cursos de pré-requisito:

HTTP: Entendendo a web por baixo dos panos

.NET 6: criando uma web API

O nosso ponto de partida será o projeto final do curso anterior. Caso você tenha feito esse projeto e queira seguir com ele, certifique-se de que ele está bem alinhado com a forma como terminamos o curso anterior para evitar incompatibilidades.

Espero que você aproveite esse curso e saia com novos conhecimentos. No próximo vídeo começaremos com nosso conteúdo. Até lá!

### Aula 1: Projeto inicial do curso

Para acompanhar este curso, antes de iniciá-lo é importante você [baixar o projeto inicial](https://github.com/alura-cursos/dotnet-api-2/tree/Aula-Ini) neste link.

### Aula 1: Adicionando o Cinema - Vídeo 2

Transcrição  
Neste curso queremos tornar nosso projeto ainda maior, no conceito de termos diferentes entidades que vão se relacionar.

Para isso, o primeiro passo será criar uma dessas novas entidades. Começaremos nosso projeto exatamente de onde paramos no curso anterior, então já temos a entidade de filmes. Recomendo que você faça a partir desse projeto que está mais alinhado com o fluxo que usaremos aqui.

O primeiro passo será criar a classe Cinema e os nossos conceitos de cinema que, futuramente, vão se relacionar com a entidade de filmes.

Esse vídeo será uma espécie de revisão sobre criação de:

- Modelo
- DTOs
- Controlador
- Profile do AutoMapper

A princípio, vamos criar o modelo de Cinema. No painel do gerenciador de soluções clicaremos com o botão direto sobre a pasta "Models" e selecionaremos "Adicionar > Classe...". Criaremos uma nova classe chamada Cinema.cs.

Neste momento, o que precisamos no código de Cinema.cs é um identificador, dentro do escopo de public class Cinema vamos inserir [Key]. Com o Key selecionado usaremos o atalho "Alt + Enter" para importar o namespace necessário, que é o de DataAnnotations.

Teremos também a chave Required e criaremos um public int Id, que é o identificador dessa entidade dentro do banco de dados.

```csharp
using System.ComponentModel.DataAnnotations;
namespace FilmesApi.Models
{
    public class Cinema
    {
        [Key]
        [Required]
        public int Id { get; set; }
    }
}
```

Por enquanto, nosso atributo terá mais um item como Required, o nome, ou seja, qual o nome do cinema que será criado?

```csharp
using System.ComponentModel.DataAnnotations;
namespace FilmesApi.Models
{
    public class Cinema
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
    }
}
```

Para tornar o nosso modelo um pouco mais robusto vamos complementar o Required do campo de nome definindo uma mensagem de erro, informaremos que o nome é obrigatório:

```csharp
[Required(ErrorMessage = "O campo de nome é obrigatório.")]
```

Cinema.cs

```csharp
using System.ComponentModel.DataAnnotations;
namespace FilmesApi.Models
{
    public class Cinema
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo de nome é obrigatório.")]
        public string Nome { get; set; }
    }
}
```

DTOs  
Já criamos o modelo de Cinema, agora criaremos os DTOs.

No painel do gerenciador de soluções, clicaremos com o botão direto sobre a pasta "Dtos" e selecionaremos a opção "Adicionar > Classe...". Criaremos uma nova classe chamada CreateCinemaDto.cs.

Para criar um cinema qual é o campo que precisamos passar? Nosso usuário precisará se preocupar em passar ID porque ainda estamos criando esse recurso, então só precisamos nos preocupar com a criação de um nome. Vamos inserir as linhas que dizem respeito ao nome do cinema para o código do arquivo CreateCinemaDto, as linhas de [Required] e a de public string Nome.

```csharp
using System.ComponentModel.DataAnnotations;
namespace FilmesApi.Data.Dtos
{
    public class CreateCinemaDto
    {
        [Required(ErrorMessage = "O campo de nome é obrigatório.")]
        public string Nome { get; set; }
    }
}
```

Em seguida, criaremos também o DTO de leitura.

No painel do gerenciador de soluções, clicaremos com o botão direto sobre a pasta "Dtos" e selecionaremos a opção "Adicionar > Classe...". Criaremos uma nova classe chamada ReadCinemaDto. E dentro desse arquivo teremos esses dois parâmetros, duas propriedades que queremos retornar: ID e nome.

```csharp
namespace FilmesApi.Data.Dtos
{
    public class ReadCinemaDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
    }
}
```

Agora, podemos adicionar outra nova classe dentro da pasta "Dtos". Nomearemos essa classe de UpdateCinemaDto. O arquivo UpdateCinemaDto.cs terá o parâmetro de Nome. Vamos receber o ID através da URL e definiremos qual será o nome do cinema.

```csharp
using System.ComponentModel.DataAnnotations;
namespace FilmesApi.Data.Dtos
{
    public class UpdateCinemaDto
    {
        [Required(ErrorMessage = "O campo de nome é obrigatório.")]
        public string Nome { get; set; }
    }
}
```

Controller  
Já criamos o nosso modelo e os DTOs. Agora criaremos o controlador.

No painel do gerenciador de soluções, clicaremos com o botão direto sobre a pasta "Controllers" e selecionaremos a opção "Adicionar > Classe...". Nomearemos essa classe de CinemaController.

Lembrando que já estudamos esses procedimentos com mais profundidade no curso anterior. Caso você não esteja entendendo, é sinal de que você deve fazer o curso anterior que é pré-requisito para este curso.

Então, como o controlador é uma classe que terá um bloco de código um pouco maior, vou colar um código pronto que eu tenho aqui para seguirmos mais rapidamente. De qualquer forma, passaremos por ele para dar uma revisada.

CinemaController.cs

```csharp
using AutoMapper;
using FilmesApi.Data.Dtos;
using FilmesApi.Data;
using FilmesApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilmesApi.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class CinemaController : ControllerBase
    {
        private FilmeContext _context;
        private IMapper _mapper;

        public CinemaController(FilmeContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult AdicionaCinema([FromBody] CreateCinemaDto cinemaDto)
        {
            Cinema cinema = _mapper.Map<Cinema>(cinemaDto);
            _context.Cinemas.Add(cinema);
            _context.SaveChanges();
            return CreatedAtAction(nameof(RecuperaCinemasPorId), new { Id = cinema.Id }, cinemaDto);
        }

        [HttpGet]
        public IEnumerable<ReadCinemaDto> RecuperaCinemas()
        {
            return _mapper.Map<List<ReadCinemaDto>>(_context.Cinemas.ToList());
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaCinemasPorId(int id)
        {
            Cinema cinema = _context.Cinemas.FirstOrDefault(cinema => cinema.Id == id);
            if (cinema != null)
            {
                ReadCinemaDto cinemaDto = _mapper.Map<ReadCinemaDto>(cinema);
                return Ok(cinemaDto);
            }
            return NotFound();
        }

        [HttpPut("{id}")]
        public IActionResult AtualizaCinema(int id, [FromBody] UpdateCinemaDto cinemaDto)
        {
            Cinema cinema = _context.Cinemas.FirstOrDefault(cinema => cinema.Id == id);
            if (cinema == null)
            {
                return NotFound();
            }
            _mapper.Map(cinemaDto, cinema);
            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletaCinema(int id)
        {
            Cinema cinema = _context.Cinemas.FirstOrDefault(cinema => cinema.Id == id);
            if (cinema == null)
            {
                return NotFound();
            }
            _context.Remove(cinema);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
```

Neste código que colamos em CinemaController.cs, estamos definindo as anotações de controlador com [ApiController] e nossa rota para /cinema que é o nome do nosso controlador, [Route("[controller]")].

Em seguida, estendemos o ControllerBase, fizemos a injeção das dependências, que no caso serão FilmeContext e IMapper.

Depois, temos as operações básicas. O bloco do [HttpPost] para adicionar um cinema. Neste bloco de código nós recebemos o CreateCinemaDto, mapeamos ele para um Cinema, adicionamos ele no nosso context– Então, precisamos ainda criar o DbSet, que é nosso próximo passo – Salvamos as alterações com SaveChanges() e retornamos à rota em que ele foi criado.

Em seguida, no bloco de código de [HttpGet] usamos o RecuperaCinemas(), retornamos todos os cinemas que temos cadastrados.

E temos também o GET por ID, [HttpGet("{id}")]. Em que recebemos um ID e retornamos o cinema correspondente.

Para atualização inserimos o PUT por ID, [HttpPut("{id}")].

E, por fim, temos o bloco do DELETE por ID, [HttpDelete("{id}")].

Agora precisamos criar o DbSet. Para criá-lo vamos para o início do código de CinemaController e, segurando o "Ctrl", clicaremos em "FilmeContext" para acessar o arquivo FilmeContext.cs.

No FilmeContext.cs criaremos o DbSet de Cinema, DbSet`<Cinema>` Cinemas { get; set; }:

```csharp
public class FilmeContext : DbContext
{
    public FilmeContext(DbContextOptions<FilmeContext> opts)
        : base(opts)
    {

    }

    public DbSet<Filme> Filmes { get; set; }
    public DbSet<Cinema> Cinemas { get; set; }
}
```

Agora, um último detalhe. Tem um erro silencioso que aconteceria caso executássemos o nosso sistema. Porque ainda não ensinamos o AutoMapper a fazer esse mapeamento Cinema cinema = _mapper.Map<Cinema>(cinemaDto).

Para fazer isso, criaremos um profile. Na pasta "Profiles", vamos criar uma nova classe chamada CinemaProfile.

Profile  
Para ser efetivamente um profile precisamos estender da classe Profile e para criar o construtor usaremos o atalho de escrever "ctor" e pressionar "Tab" duas vezes. Usaremos o método CreateMap para criar o Map de CreateCinemaDto para Cinema e faremos a mesma coisa para os outros DTOs, na segunda linha, faremos de um Cinema para um ReadCinemaDto e, na terceira linha, de um UpdateCinemaDto para um Cinema.

```csharp
using AutoMapper;
using FilmesApi.Data.Dtos;
using FilmesApi.Models;

namespace FilmesApi.Profiles
{
    public class CinemaProfile : Profile
    {
        public CinemaProfile()
        {
            CreateMap<CreateCinemaDto, Cinema>();
            CreateMap<Cinema, ReadCinemaDto>();
            CreateMap<UpdateCinemaDto, Cinema>();
        }
    }
}
```

Agora, ao analisar o CinemaControllerestamos, a princípio, sem nenhum problema.

Então, neste vídeo o que fizemos foi uma breve revisão desses conceitos mais importantes que vimos anteriormente. Seguiremos aplicando-os em alguns cenários.

Agora temos um conceito de cinema. Conseguimos cadastrar cinemas e fazer operações com cinemas dentro do nosso sistema.

Agora precisamos pensar: como o Cinema vai se relacionar com outras classes dentro do nosso banco?

Te espero no próximo vídeo!

### Aula 1:  - Vídeo 3
### Aula 1:  - Vídeo 4
### Aula 1:  - Vídeo 5
### Aula 1:  - Vídeo 6
### Aula 1:  - Vídeo 7
### Aula 1:  - Vídeo 8
### Aula 1:  - Vídeo 9
### Aula 1:  - Vídeo 10
