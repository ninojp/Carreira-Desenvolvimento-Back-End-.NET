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

### Aula 1: Faça como eu fiz: expandindo o sistema

Chegou a hora de incrementar o sistema e criar o escopo de Cinema. A proposta desta atividade é criar as classes de modelo, DTOs, controlador e profile.

Você colocou isso em prática? Vamos colocar a mão na massa e verifique se ficou com alguma dúvida. Se sim, você pode clicar na “Opinião do instrutor” e conferir passo a passo como isso foi feito.

Opinião do instrutor

Para isso, primeiramente crie a classe Cinema dentro da pasta Models:

```csharp
public class Cinema
{
    [Key]
    [Required]
    public int Id { get; set; }
    [Required(ErrorMessage = "O campo de nome é obrigatório.")]
    public string Nome { get; set; }

}
```

Em seguida, precisamos criar na pasta Data/Dtos os DTOs de escrita, leitura e atualização, respectivamente:

```csharp
public class CreateCinemaDto
{
    [Required(ErrorMessage = "O campo de nome é obrigatório.")]
    public string Nome { get; set; }
}
```

```csharp
public class ReadCinemaDto
{
    public int Id { get; set; }
    public string Nome { get; set; }
}
```

```csharp
public class UpdateCinemaDto
    {
        [Required(ErrorMessage = "O campo de nome é obrigatório.")]
        public string Nome { get; set; }
    }
```

Para que possamos lidar com as requisições recebidas, precisamos criar o controlador com o comportamento padrão que vimos no curso anterior. Na pasta Controllers, crie o CinemaController:

```csharp
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
```

Por fim, para que nosso modelo possa ser convertido para um DTO e vice-versa, precisamos de nosso AutoMapper configurado. Dentro da pasta Profiles, crie o CinemaProfile:

```csharp
public class CinemaProfile : Profile
{
    public CinemaProfile()
    {
        CreateMap<CreateCinemaDto, Cinema>();
        CreateMap<Cinema, ReadCinemaDto>();
        CreateMap<UpdateCinemaDto, Cinema>();
    }
}
```

### Aula 1:  Convertendo tipos - Exercício

A fim de crescer nosso projeto, criamos o modelo de Cinema. Para facilitar a conversão entre os diferentes tipos de DTO e nossos modelos, utilizamos a biblioteca AutoMapper. Por meio de uma sintaxe determinada podemos converter um objeto do tipo CreateCinemaDto para Cinema.

Assinale a alternativa que corresponde a essa sintaxe.

Resposta:
_mapper.Map`<Cinema>`(createCinemaDto);

> Através dessa sintaxe faremos a conversão desejada.

### Aula 1: Apresentando o problema - Vídeo 3

Transcrição  
Agora vamos discutir um pouco de teoria para entender qual é o problema a ser resolvido.

Qual situação queremos melhorar?  
Temos, por enquanto, a classe Filme, a classe Cinema com seus respectivos DTOs, controladores e profile. Ainda não temos a classe Endereço, mas em breve vamos criá-la.

![alt text](image.png)

O ponto aqui é o seguinte: nós temos algumas maneiras de representar esses dados. Podemos ter um filme com título "O senhor dos Anéis" e ano de lançamento "2001"; um cinema com nome "Alura Cinema", por enquanto é o único campo que temos; um endereço com dados de logradouro e bairro.

Temos maneiras de representar esses dados e sabemos que jogaremos tudo isso dentro do nosso banco de dados. Mas onde queremos chegar?

No momento em que fazemos alguma operação como, por exemplo, cadastrar um cinema ou pegar uma informação desse cinema, na visão do usuário final podemos pensar na pergunta: eu sei que o cinema existe, mas qual é o endereço desse cinema?

Anteriormente, vimos que a ideia é relacionar, por exemplo, um cinema com um filme, mas temos que pensar também em conceitos mais simples. Por exemplo: cinema e endereço.

Poderíamos criar uma coluna de endereço para cada cinema e colocar essa informação lá.

É uma opção válida, mas vamos pensar que podemos querer usar esse mesmo endereço em outros campos, outras informações que tenham esse mesmo endereço e queremos armazenar endereço para diversos tipos de informações diferentes.

Então, faz sentido ter essa informação em uma tabela.

A partir de agora a ideia é que tenhamos um cinema e tenhamos também uma relação com o endereço, que ainda vamos criar.

Diagrama representando a conexão entre tabela Cinema e tabela Endereço no banco de dados. Cinema, Endereço e Banco de Dados conectados por uma seta em formato triangular.

Então, esse endereço vai ter informações como logradouro e bairro, e o cinema terá esse endereço.

Como isso funcionará dentro da visão de cliente, servidor e banco de dados?

No momento em que fizermos uma operação de recuperar um cinema por ID, GET /cinema/{id}, vamos trazer a informação desse cinema e, junto com essa informação, teremos também qual é o endereço desse cinema.

Então, a partir desse momento conseguimos fazer essa operação. Precisamos ver como fazer esse relacionamento entre a tabela de cinema e a tabela de endereço que estão no nosso banco de dados.

Mas, como vamos trazer essa informação? Como saberemos que o endereço do cinema está correto? Como juntamos essas informações? Responderemos isso em breve.

Mas temos que resolver algumas perguntas antes.

- No momento em que formos criar um cinema, faz sentido um cinema existir sem o endereço?
- E o endereço existir sem um cinema?
- Como o Entity vai relacionar as entidades?

![alt text](image-1.png)

Respondendo à primeira questão, pensando de maneira física: não. Se um cinema está em algum lugar, ele precisa ter um endereço.

E um endereço pode existir sem um cinema? Pode. Note que estamos criando uma relação de dependência.

Então qual é a classe que tem mais importância nesse cenário? Seria o endereço.

Adiante vamos entender como criar todo o conceito de endereço, que será parecido com o que fizemos com cinema. Mas como criaremos e relacionaremos os endereços aos cinemas.

### Aula 1: Pacotes de banco - Exercício

Anteriormente, vimos que teremos a necessidade de relacionar diferentes entidades em nosso sistema, por exemplo, Cinema e Endereço. Com isso, conseguiremos dar mais informação ao usuário a partir de dados mais complexos. Alguns pacotes serão necessários para estabelecer relações entre entidades em um banco de dados.

Marque as opções com estes pacotes.

Respostas:  
Microsoft.EntityFrameworkCore.Tools

> Esse é um dos pacotes necessários.

Microsoft.EntityFrameworkCore

> Esse é um dos pacotes necessários.

### Aula 1: O que aprendemos?

Nessa aula aprendemos:

- Conteúdo de sedimentação de como criar, ler, atualizar e remover recursos no sistema.
- O .NET por si só é capaz de gerenciar múltiplos recursos e endpoints através de uma API.
- O Entity provê a capacidade de relacionar entidades dentro de um banco de dados.
- Através do Entity conseguimos abstrair questões de dependências entre entidades a nível de banco.

## Aula 2: Relacionamento 1:1

### Aula 2: Adicionando o Endereço - Vídeo 1

Transcrição  
Agora vamos criar todo escopo de um endereço dentro do nosso sistema. Como faremos isso? Repetiremos o passo a passo que fizemos para o nosso cinema.

O primeiro passo é criarmos o modelo, para isso, do lado direito em "Gerenciador de soluções" com o cursor em "Models" clicamos com o botão direito do mouse. Será exibido um menu e nele clicamos em "Adicionar > Classe".

No pop-up seguinte, na parte inferior esquerda, temos o campo "Nome" e nele digitaremos "Endereco". Em seguida, à direita, selecionamos o botão "Adicionar". Seremos redirecionados para o arquivo "Endereco", localizado em "FilmesApi > Models".

Endereco

```csharp
namespace FilmesApi.Models
{
    public class Endereco
    {
    }
}
```

Vamos adicionar o endereço com seus respectivos campos. Como vimos anteriormente, precisamos definir as propriedades que desejamos mapear para o banco de dados. Colocaremos dentro da classe entre colchetes a nossa key e o required, logo após teclamos "Alt + Enter" para importarmos a anotação.

Endereco

```csharp
using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Models
{
    public class Endereco
    {
        [Key]
        [Required]
    }
}
```

Na linha seguinte, incluímos a propriedade de id, depois o logradouro e o número do endereço.

Endereco

```csharp
using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Models
{
    public class Endereco
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string Logradouro { get; set; }
                public int Numero { get; set; }
    }
}
```

Podemos pensar em inserir um required para logradouro e para o número, fique à vontade para aplicar as restrições conforme achar melhor. Porém, neste caso não estamos nos preocupando tanto com isso, por isso deixaremos sem o required, seguiremos em um fluxo mais rápido. Assim, criamos o nosso endereço.

Agora vamos criar os nossos DTOs. Para tal, com o cursor sobre "Dtos" do lado direito, selecionamos as opções "Adicionar > Classe". Nomearemos o arquivo de "CreateEnderecoDto" e logo após clicamos no botão "Adicionar", seremos redirecionados para o arquivo "CreateEnderecoDto", localizado em "Data > Dtos".

CreateEnderecoDto

```csharp
namespace FilmesApi.Data.Dtos
{
    public class CreateEnderecoDto
    {
    }
}
```

Para criar um endereço de fato, precisamos passar o nosso logradouro e o número - lembrando que não estamos nos preocupando com a obrigatoriedade, mas vamos inserir esses parâmetros para podermos criar.

CreateEnderecoDto

```csharp
namespace FilmesApi.Data.Dtos
{
    public class CreateEnderecoDto
    {
        public string Logradouro { get; set; }
        public int Numero { get; set; }
    }
}
```

Pronto! Agora, vamos criar o nosso Dto de leitura do endereço. Novamente, com o cursor sobre "Dtos" clicamos nas opções "Adicionar > Classe", nomearemos o arquivo de "ReadEnderecoDto" e depois selecionamos o botão "Adicionar". Seremos redirecionados para o arquivo:

ReadEnderecoDto

```csharp
namespace FilmesApi.Data.Dtos
{

    public class ReadEnderecoDto
    {
    }
}
```

No arquivo "Endereco" copiaremos as três linhas referentes aos três campos: id, logradouro e número. Em seguida, colamos dentro da classe ReadEnderecoDto no arquivo "ReadEnderecoDto"

ReadEnderecoDto

```csharp
namespace FilmesApi.Data.Dtos
{
    public class ReadEnderecoDto
    {
        public int Id { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
    }
}
```

Por fim, vamos criar o "UpdateEnderecoDto" seguindo o mesmo passo a passo mencionado anteriormente para a criação de arquivos Dtos.

UpdateEnderecoDto

```csharp
namespace FilmesApi.Data.Dtos
{

    public class UpdateEnderecoDto
    {
    }
}
```

Para podermos atualizar o endereço, passaremos as mesmas informações do arquivo "CreateEnderecoDto", sem o id.

UpdateEnderecoDto

```csharp
namespace FilmesApi.Data.Dtos
{
    public class UpdateEnderecoDto
    {
        public string Logradouro { get; set; }
        public int Numero { get; set; }
    }
}
```

Com isso, criamos os Dtos. Agora, vamos criar os nossos controladores. Com o mouse sobre a pasta "Controllers" do lado direito, em "Gerenciador de soluções", clicamos com o botão direito e escolhemos as opções "Adicionar > Classe". No campo "Nome" do pop-up seguinte, digitamos "EnderecoController" e depois clicamos no botão "Adicionar".

EnderecoController

```csharp
namespace FilmesApi.Controllers
{
         public class EnderecoController
         {
         }
}
```

Como já vimos anteriormente, colaremos o seguinte script dentro da classe "EnderecoController", para não perdermos tempo com conceitos que já aprendemos.

EnderecoController

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
    public class EnderecoController : ControllerBase
    {
        private FilmeContext _context;
        private IMapper _mapper;

        public EnderecoController(FilmeContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult AdicionaEndereco([FromBody] CreateEnderecoDto enderecoDto)
        {
            Endereco endereco = _mapper.Map<Endereco>(enderecoDto);
            _context.Enderecos.Add(endereco);
            _context.SaveChanges();
            return CreatedAtAction(nameof(RecuperaEnderecosPorId), new { Id = endereco.Id }, endereco);
        }

        [HttpGet]
        public IEnumerable<ReadEnderecoDto> RecuperaEnderecos()
        {
            return _mapper.Map<List<ReadEnderecoDto>>(_context.Enderecos);
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaEnderecosPorId(int id)
        {
            Endereco endereco = _context.Enderecos.FirstOrDefault(endereco => endereco.Id == id);
            if (endereco != null)
            {
                ReadEnderecoDto enderecoDto = _mapper.Map<ReadEnderecoDto>(endereco);

                return Ok(enderecoDto);
            }
            return NotFound();
        }

        [HttpPut("{id}")]
        public IActionResult AtualizaEndereco(int id, [FromBody] UpdateEnderecoDto enderecoDto)
        {
            Endereco endereco = _context.Enderecos.FirstOrDefault(endereco => endereco.Id == id);
            if (endereco == null)
            {
                return NotFound();
            }
            _mapper.Map(enderecoDto, endereco);
            _context.SaveChanges();
            return NoContent();
        }


        [HttpDelete("{id}")]
        public IActionResult DeletaEndereco(int id)
        {
            Endereco endereco = _context.Enderecos.FirstOrDefault(endereco => endereco.Id == id);
            if (endereco == null)
            {
                return NotFound();
            }
            _context.Remove(endereco);
            _context.SaveChanges();
            return NoContent();
        }

    }
}
```

Geramos de forma análoga aos nossos controladores anteriores, com as anotações "ApiController" e "Route["controller"]", com o construtor com as injeções de dependências necessárias para este caso:

Construtor e dependências do arquivo "EnderecoController"

```csharp
//código omitido
{
        private FilmeContext _context;
        private IMapper _mapper;

        public EnderecoController(FilmeContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
//código omitido
```

Temos os métodos de adicionar, recuperar, atualizar e remover o endereço. Observe que no método DeletaEndereco a palavra "Enderecos" está com um sublinhado na cor vermelha. Isso significa que precisamos criar em "FilmeContext" o nosso Dbset de endereço, localizado em "Data".

FilmeContext

```csharp
//código omitido

public DbSet<Endereco> Enderecos { get; set; }

//código omitido
```

Até o momento temos quase toda a parte de endereço criada, precisamos finalizar com o nosso profile. Com o mouse sobre a pasta "Profiles", clicamos com o botão direito e escolhemos as opções "Adicionar > Classe", nomearemos o arquivo de "EnderecoProfile". Logo após, selecionamos o botão "Adicionar".

EnderecoProfile

```csharp
namespace FilmesApi.Profiles
{
    public class EnderecoProfile 
    {
    }
}
```

Esse arquivo vai estender da nossa classe de profile (do automapper), por isso, incluiremos dois pontos profile (": Profile"), após o nome da classe.

EnderecoProfile

```csharp
namespace FilmesApi.Profiles
{
    public class EnderecoProfile : Profile
    {
    }
}
```

A classe "profile" está sublinhada na cor vermelha, teclamos "Alt + Enter" para importar e escolhemos a opção "using AutoMapper;".

EnderecoProfile

```csharp
using AutoMapper;

namespace FilmesApi.Profiles
{
    public class EnderecoProfile : Profile
    {
    }
}
```

Logo após, dentro da classe, digitamos "ctor" e clicamos na tecla "tab" duas vezes. Será gerado de forma automática o public EnderecoProfile(){}.

EnderecoProfile

```csharp
using AutoMapper;

namespace FilmesApi.Profiles
{
    public class EnderecoProfile : Profile
    {

        public EnderecoProfile()
        {
        }
    }
}
```

Estamos fazendo mais rápido, pois já aprendemos isso de forma mais detalhada em vídeos passados. Dentro de "EnderecoProfile" faremos o create map de "CreateEnderecoDto" para "Endereco". Logo após, de "Endereco" para "ReadEnderecoDto" e de "UpdateEnderecoDto" para "Endereco".

EnderecoProfile

```csharp
using AutoMapper;
using FilmesApi.Data.Dtos;
using FilmesApi.Models;

namespace FilmesApi.Profiles
{
    public class EnderecoProfile : Profile
    {
        public EnderecoProfile()
        {
            CreateMap<CreateEnderecoDto, Endereco>();
            CreateMap<Endereco, ReadEnderecoDto>();
            CreateMap<UpdateEnderecoDto, Endereco>();
        }
    }
}
```

Ou seja, quando estamos criando mapeamos do Dto para o endereço, quando buscamos passamos do endereço para o read, e para atualizar é a mesma lógica do create.

Desse modo, criamos toda a nossa parte de endereço. O que temos dentro do nosso sistema após isso? Filmes, endereço e cinemas. Conseguimos cadastrar esses três recursos com as operações básicas de criar, ler, atualizar e remover.

Na sequência, vamos fazer a primeira interação entre um Cinema e um Endereço. Te espero na próxima aula!

### Aula 2: Projeto da aula anterior

Caso queira, você pode [baixar o projeto do curso](https://github.com/alura-cursos/dotnet-api-2/tree/Aula-1) no ponto em que paramos na aula anterior.

### Aula 2:  Relacionando Endereço e Cinema - Vídeo 2

Transcrição  
Na aula anterior nos fizemos algumas perguntas:

![alt text](image-2.png)

Perguntas

- Um Cinema pode existir sem um endereço? E um endereço, pode existir sem um Cinema?
Como o Entity irá relacionar as entidades?
- Precisamos responder essas perguntas! No momento em que cadastrarmos o Cinema desejamos lidar com esses diferentes cenários. Mas vamos entender por partes o que desejamos alcançar.

Diagrama representando a conexão entre tabela Cinema e tabela Endereço no banco de dados. Cinema, Endereço e Banco de Dados conectados por uma seta em formato triangular.

A princípio temos uma tabela Cinema e outra tabela Endereço. O que estamos representando? Estamos informando que um Cinema e um Endereço se relacionam. Como? No nosso sistema, um cinema possui somente um endereço. Logo, um cinema físico não pode estar em vários endereços simultaneamente, com isso, o endereço conterá apenas um cinema.

No exemplo mencionado anteriormente, que o endereço pode conter um estoque ou loja, conseguimos aplicar essa regra da mesma forma, isso porque o endereço estaria se relacionando com outras entidades. Logo, com o Cinema é uma relação um para um, mas podemos incluir outras relações com outras entidades.

Desse modo, o tipo de relacionamento entre Cinema e Endereço é de um para um, representado pela nomenclatura 1:1. Um cinema possuirá somente um endereço, e um endereço será relacionado apenas a um cinema. Como isso vai funcionar?

Se tivermos os cinemas "A", "B" e "C" com os endereços "A", "B" e "C" também, caso o Cinema A tenha alguma relação com o Endereço A, possuirá apenas este endereço. Se cadastrarmos o Cinema A com o Endereço B, seria uma relação somente com esse endereço e assim por diante.

Temos esses diferentes cenários, em que estamos relacionando um cinema com um endereço. Mas ainda fica uma pergunta: como o Cinema A sabe com qual endereço está se relacionando? Qual campo de endereço que podemos usar para identificarmos o endereço que estamos nos referindo? A resposta é o nosso ID.

Com isso, dentro do nosso Cinema A precisamos incluir de alguma forma a informação que faz menção ao endereço desejado. E dentro do Cinema A teremos uma coluna que vai conter o endereço que esse cinema possui. Aplicaremos isso agora.

Para isso, precisamos informar ao entity que a partir desse momento vamos criar para o nosso cinema uma nova propriedade que vai possuir o id do endereço.

Do lado direito do projeto, clicamos no arquivo "Cinema.cs", localizado em "Models". Nele, incluiremos "EnderecoId" após o campo "Nome".

Cinema.cs

```csharp
//código omitido
public int EnderecoId { get; set; }
```

Na linha seguinte, informamos ao entity que o Cinema e o Endereço possuem uma relação de 1:1. Para o entity entender isso, precisamos explicitar dentro de "Cinema" que ele terá uma propriedade virtual que será do tipo endereço nomeado "Endereco".

Cinema.cs

```csharp
//código omitido
public int EnderecoId { get; set; }
public virtual Endereco Endereco { get; set; }
```

Desse modo, o arquivo completo fica:

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
        public int EnderecoId { get; set; }
        public virtual Endereco Endereco { get; set; }

    }
}
```

Com isso, estamos comunicando ao entity que essa entidade "Cinema" possui uma relação de somente um endereço, e estamos explicitando isso na última linha do arquivo que acabamos de incluir. Precisamos aplicar a mesma lógica em "Endereco.cs".

No arquivo "Endereco.cs" digitamos public virtual Cinema Cinema com get e set na última linha, após o campo de número.

Endereco.cs

```csharp
using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Models
{
    public class Endereco
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public virtual Cinema Cinema { get; set; }
    }
}
```

Não usamos o Id do cinema dentro de endereço porque estamos imaginando da seguinte forma: qual a relação de dependência entre essas duas entidades? Vamos entender associando com situações fora do escopo de cinema e filmes.

Uma instituição ou empresa pode existir (fisicamente) sem possui um endereço? A princípio, não. Para uma empresa existir fisicamente ela precisa ter um endereço, mas caso não tenha nada no lugar indicado o endereço continua existindo.

Por exemplo, caso o cinema não exista no endereço indicado, o logradouro e o número continuam existindo. Portanto, temos uma relação de dependência: para que o cinema exista, é necessário ter um endereço prévio, isto é, no momento de cadastrarmos um cinema já precisamos ter o endereço.

E é justamente isso que estamos explicitando no arquivo "Cinema.cs" a partir da linha 12.

Parte selecionada pelo instrutor do arquivo "Cinema.cs"

```csharp
//código omitido

        public int EnderecoId { get; set; }
```

Isto é, para que um cinema seja criado no banco de dados ele deve receber o Id do endereço desse cinema. Agora, no momento de criarmos esse cinema dentro do banco de dados, precisamos receber como parâmetro através do Dto o Id do endereço no controlador. Passaremos isso via parâmetro.

Para isso, vamos ao arquivo "CreateCinemaDto" em "Dtos", e na última linha incluímos public int EnderecoId { get; set; }.

CreateCinemaDto

```csharp
using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Data.Dtos
{
    public class CreateCinemaDto
    {
        [Required(ErrorMessage = "O campo de nome é obrigatório.")]
        public string Nome { get; set; }
        public int EnderecoId { get; set; }
    }
}
```

Por fim, precisamos que no momento de retornarmos a informação de ReadCinemaDto possamos colocar a propriedade que será "ReadEnderecoDto" que chamaremos pelo mesmo nome, sendo "ReadEnderecoDto".

ReadCinemaDto

```csharp
namespace FilmesApi.Data.Dtos
{
    public class ReadCinemaDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public ReadEnderecoDto ReadEnderecoDto { get; set; }
    }
}
```

Com isso, no momento de fazermos o parse para o nosso "ReadCinemaDto" teremos a informação de "ReadEnderecoDto".

Para gerarmos essa mudança, clicamos no menu superior em "Ferramentas" e depois nas opções "Gerenciador de Pacotes do NuGet > Console do Gerenciador de Pacotes". Na parte inferior será exibido o console, nele rodaremos o comando Add-Migration "Cinema e Endereco".

```csharp
Add-Migration "Cinema e Endereco"
```

Após apertarmos a tecla "Enter", o build vai começar e a migration será gerada. Como retorno, obtemos:

Build started…

Build succeeded.

Microsoft.EntityFrameworkCore.Infraestructure[10403]

Entity Framework Core 6.0.10 initialized 'FilmeContext' using provider 'Pomelo.EntityFrameworkCore.MySql:6.0.2' with options: ServerVersion 5.6.26-mysql

To undo this action, use Remove-Migration

Vamos analisar o arquivo gerado chamado "20221218222033_Cinema e Endereco.cs", em "Migrations".

20221218222033_Cinema e Endereco.cs

Nesse arquivo, é gerada a tabela de endereços com as colunas "Id", "Logradouro" e "Numero" sendo o que definimos para o endereço. Logo após, criamos o Id como chave primária.

Parte do código selecionada pelo instrutor no arquivo "20221218222033_Cinema e Endereco.cs".

```csharp
// código omitido
namespace FilmesApi.Migrations
{
    public partial class CinemaeEndereco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Enderecos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Logradouro = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Numero = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enderecos", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

// código omitido
```

Na tabela "Cinemas", temos os campos "Id", "Nome" e "EnderecoId". A nossa chave primária é o Id do cinema e temos uma chave estrangeira ("Foreign Key"). Isso significa que essa chave faz menção a outra tabela, ele informa que o "EnderecoId" referência a tabela de endereços através da coluna "Id".

20221218222033_Cinema e Endereco.cs

```csharp
// código omitido
  migrationBuilder.CreateTable(
                name: "Cinemas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EnderecoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cinemas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cinemas_Enderecos_EnderecoId",
                        column: x => x.EnderecoId,
                        principalTable: "Enderecos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

// código omitido
```

Mas como o entity conseguiu deduzir isso? Usando o nome. No arquivo "Endereco.cs" definimos a propriedade "Id" e no arquivo "Cinema.cs" passamos public int EnderecoId, sendo "Endereco" o nome da nossa tabela com o sufixo Id. Com isso, o entity fez essa inferência.

Voltando ao arquivo gerado na pasta "Migrations", ele cria o campo endereço id com a chave estrangeira do nosso cinema em relação ao endereço. Descendo um pouco mais o código, temos o seguinte trecho:

20221218222033_Cinema e Endereco.cs

```csharp
// código omitido
migrationBuilder.CreateIndex(
    name: "IX_Cinemas_EnderecoId",
    table: "Cinemas",
    column: "EnderecoId",
    unique: true);
// código omitido
```

Nesse trecho é indicado a unidade que definimos, no campo "unique". Agora, no console, executaremos o comando update-Database para criarmos o banco de dados.

```csharp
update-Database
```

No caso do instrutor, ele não estava com o banco de dados criado. E no momento de executar o comando (já tínhamos removido anteriormente com o comando drop database filme;), no console do MySQL rodaremos o comando use filme;.

```csharp
use filme;
```

Usamos "filme" porque definimos no campo "FilmeConnection" do arquivo "appsettings.json".

appsettings.json

```Json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "FilmeConnection": "server=localhost;database=filme;user=root;password=root"
  }
}
```

Aprendemos em cursos anteriores como efetuar essa conexão com o banco de dados.

Após rodarmos o comando use filme;, executamos show tables; para visualizarmos as tabelas.

```csharp
show tables;
```

Como retorno, obtemos:

- Tables_in_filme
- efmigrationshi…
- cinemas
- enderecos
- filmes

Temos as tabelas "cinemas", "enderecos" e "filmes". Se rodarmos describe cinemas; é exibida a tabela com as suas respectivas colunas, tipo, se é nulo, o tipo de chave (primária, única ou estrangeira), uma coluna "Default" e uma "Extra".

```csharp
describe cinemas;
```

Como retorno, teremos:

|Field|Type|Null|Key|Default|Extra|
|---|---|---|---|---|---|
|Id|int(11)|NO|PRI||auto_increment|
|Nome|longtext|NO||||
|EnderecoId|int(11)|NO|UNI|||

Agora, se rodarmos describe enderecos; também temos as informações de Id, logradouro e número.

```csharp
describe enderecos;
```

Como retorno, temos:

|Field|Type|Null|Key|Default|Extra|
|---|---|---|---|---|---|
|Id|int(11)|NO|PRI||auto_increment|
|Nome|longtext|NO||||
|EnderecoId|int(11)|NO|UNI|||

Desse modo, estamos criando o vínculo de 1:1 entre a entidade Cinema e um Endereço.

Na sequência, vamos testar o nosso sistema e veremos algumas curiosidades acerca da propriedade virtual que criamos para cada modelo.

Te espero na próxima aula!

### Aula 2: Faça como eu fiz: modificando os modelos

Chegou a hora de estabelecer o relacionamento 1:1 entre um Cinema e um Endereco. Nossa intenção com essa prática é modificar os modelos atuais a fim de informar o relacionamento ao Entity.

Você colocou isso em prática? Vamos colocar a mão na massa e verifique se ficou com alguma dúvida. Se sim, você pode clicar na “Opinião do instrutor” e conferir passo a passo como isso foi feito.

Opinião do instrutor

Para isso, primeiramente altere a classe Cinema para:

```csharp
public class Cinema
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo de nome é obrigatório.")]
        public string Nome { get; set; }
        public int EnderecoId { get; set; }
        public virtual Endereco Endereco { get; set; }
    }
```

Em seguida, será necessário fazer o processo de maneira parecida na classe Endereco:

```csharp
public class Endereco
{
    [Key]
    [Required]
    public int Id { get; set; }
    public string Logradouro { get; set; }
    public int Numero { get; set; }
    public virtual Cinema Cinema { get; set; }
}
```

Para criarmos um Cinema agora será necessário informar um EnderecoId no momento de criação. Para isso, altere a classe CreateCinemaDto:

```csharp
public class CreateCinemaDto
    {
        [Required(ErrorMessage = "O campo de nome é obrigatório.")]
        public string Nome { get; set; }
        public int EnderecoId { get; set; }
    }
```

Para leitura, também modificaremos nosso ReadCinemaDto:

```csharp
public class ReadCinemaDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public ReadEnderecoDto Endereco { get; set; }
    }
```

Por fim, não esqueça de gerar e aplicar as migrations com os comandos Add-Migrations e Update-Database.

### Aula 2: Cadastrando recursos - Vídeo 3

Transcrição  
Rodaremos a nossa aplicação, para isso clicamos no botão com o ícone de play "▶" no menu superior referente ao "Iniciar Sem Depurar" ou podemos usar o atalho "Ctrl + F5". Observe que ele está escutando na porta 7106.

Agora, usaremos o Postman para enviarmos uma requisição post para cinema. Na aba com o método post, temos o seguinte caminho:

```csharp
https://localhost:7106/cinema
```

Copiamos esse caminho e abriremos mais uma aba no Postman com o método post, só que ao invés de "cinema" após a barra, colocaremos "endereco".

```csharp
https://localhost:7106/endereco
```

Vimos que para criarmos um cinema precisamos previamente já ter cadastrado um endereço. Por isso, na aba de cinema, clicamos em "Body" no menu após o caminho, depois marcamos a opção "raw" e depois selecionamos "Text". Neste, escolhemos o formato "JSON". Faremos a mesma coisa para a aba de endereço.

O que precisamos para criar um endereço? Logradouro e número. Por isso, digitaremos as seguintes informações em "Body":

Body da aba de endereço

```csharp
{
"Logradouro" : "Rua das Couves",
"Numero" : 300
}
```

Logo após, clicamos no botão "Send". Observe que gerou o status 201 Created com a seguinte estrutura no body do retorno:

```csharp
{
“id”: 1,
“logradouro”: “Rua das Couves”,
“numero”: 300,
“cinema”: null
}
```

O campo "cinema" está como nulo, isso significa que criamos essa informação que não contém nenhum cinema dentro do sistema. Agora, vamos tentar criar o cinema, para isso voltamos para a aba de cinema no Postman e em "Body", digitamos:

```csharp
{
"Nome" : "Alura Cinemas",
"EnderecoId" : 1
}
```

No campo "EnderecoId" colocamos o número de Id que acabou de ser gerado, no caso o Id de número 1. Em seguida, podemos clicar no botão azul "Send". Observe que foi devolvido o status 201 created.

Agora tentaremos realizar uma leitura. Para isso, abrimos mais uma aba no Postman usando o método get com o endereço `https://localhost:7106/cinema`. Ou seja, estamos buscando todos os cinemas cadastrados no banco de dados.

Após clicarmos no botão "Send", obtemos:

```csharp
{
“id”: 1,
“nome”: “Alura Cinemas”,
“readEnderecoDto”: null
}
```

Vamos entender mais adiante o motivo do campo "readEnderecoDto" estar nulo. Antes, desejamos testar outra coisa.

Na aba de criação do cinema (método post), vamos alterar o campo "Nome" adicionando a palavra "Outro" no final e manteremos o endereço Id.

```csharp
{
"Nome" : "Alura Cinemas Outro",
"EnderecoId" : 1
}
```

Em seguida, clicamos no botão "Send". Observe que retornou o status 500 Internal Server Error, e no "Body" no retorno, temos:

Microsoft.EntityFrameworkCore.DbUpdateException: An error occurred while saving the entity changes. See the inner exception for details.

Isso significa que ocorreu um erro quando ele foi realizar a inserção do endereço. Logo após, em "Duplicate entry '1' for key 'IXCinemasEnderecoId'", ele informa que a entrada está duplicada para o cinema e endereço especificado.

Isto é, ele não permitiu inserirmos outro cinema com o mesmo endereço de um cinema já cadastrado no banco de dados. Desse modo, garantimos a unicidade.

Se formos na aba de endereço e tentarmos criar "Rua das Couves Outros" no número 600, será gerado um novo endereço.

Body da aba de endereço

```csharp
{
"Logradouro" : "Rua das Couves Outro",
"Numero" : 600
}
```

Podemos clicar no botão "Send". Logo após, na aba de cinema colocaremos o cinema "Alura Cinemas Outros" no endereço Id número 2 (nosso novo endereço).

Body da aba cinema

```csharp
{
"Nome" : "Alura Cinemas Outro",
"EnderecoId" : 2
}
```

Após clicamos no botão para enviarmos a requisição, note que funcionou conforme o esperado, com status 201 Created.

Body do retorno da aba cinema

```csharp
{
"nome" : "Alura Cinemas Outro",
"enderecoId" : 2
}
```

Com isso, validamos o nosso sistema. Ainda precisamos entender melhor o motivo do campo "readEnderecoDto" estar como nulo e como a propriedade virtual funciona e como podemos usá-la ao nosso favor.

Vamos aprender isso no próximo vídeo. Te espero lá!

### Aula 2: Características do relacionamento - Exercício

Através do código escrito anteriormente, foi possível estabelecer um relacionamento 1:1 entre um Cinema e um Endereço em nosso sistema. Por qual motivo esse relacionamento recebe o nome de “um para um”?

Marque a alternativa correta.

Alternativa correta  
Pois em nosso sistema um Cinema se relaciona com um e apenas um Endereço e vice-versa.

> Esse é o motivo que dá nome ao tipo de relacionamento.

### Aula 2: Lazy Properties - Vídeo 5

Transcrição  
Agora vamos entender um detalhe importante: atualmente estamos retornando nulo no campo "readEnderecoDto". Como podemos resolver isso?

Arquivo Cinema.cs

O primeiro passo é analisarmos a classe Cinema. Observe que temos o nosso "EnderecoId" e na linha seguinte temos um "Endereco", sendo uma propriedade virtual.

A propriedade virtual serve para algo além de indicar a unicidade ou não em uma relação, ou de cardinalidade entre as diversas entidades. Ou seja, não usamos somente para indicar se é 1:1, essa propriedade possui uma função importante.

No momento que estamos carregando um cinema em memória no sistema, por exemplo, ao recuperarmos um cinema no arquivo "CinemaController", conseguimos que para cada cinema (usando a propriedade virtual) seja recuperado uma instância do seu respectivo endereço.

Com isso, conseguimos ter, além do acesso ao "EnderecoId", o acesso ao nome e ao logradouro (isso devido à instância que será gerada). Na linha sobre a propriedade virtual, será gerado um objeto para essa entidade que se relaciona com o cinema (que no caso é o endereço).

Linha selecionada pelo instrutor no arquivo "Cinema"

```csharp
//código omitido

public int EnderecoId { get; set; }
public virtual Endereco Endereco { get; set; }

//código omitido
```

Contudo, precisamos configurar o nosso código para executarmos isso e para resolvermos o problema do Dto. Iniciaremos abrindo o console, para isso, clicamos em "Ferramentas" no menu superior e depois nas opções "Gerenciador de Pacotes do NuGet > Gerenciar Pacotes do NuGet para a Solução…".

Na canto superior esquerdo da página seguinte temos um campo de pesquisa (cujo atalho é "Ctrl + L"), nele digitaremos "proxies" para buscarmos pelo pacote proxies. Na primeira opção exibida, temos a "Microsoft.EntityFrameworkCore.Proxies", podemos selecioná-la.

À direita, será mostrada uma caixa com as versões. Nela, selecionamos a checkbox referente ao nosso projeto "FilmesApi" e depois escolhemos a versão desejada no campo "Versão" abaixo da caixa de checkbox. No caso, usaremos a versão 6.0.10 e, em seguida, clicamos no botão "Instalar".

Caso esteja usando uma versão diferente de 6.0.10 no "EntityFrameworkCore", é necessário alterar agora para o proxies.

Será exibida duas janelas posteriormente, em que clicamos no botão "Ok" e depois no "I Accept". Por fim, precisamos configurar que desejamos efetuar o carregamento dessas informações na nossa classe "Program.cs". Ou seja, no momento de instanciamos um cinema desejamos instanciar junto uma propriedade endereço.

Precisamos informar ao .NET que ele carregará isso de forma lazy ("lenta"). Logo, no momento em que o arquivo "Cinema.cs" for instanciado, o endereço será instanciado.

Para configurarmos isso, vamos ao arquivo "Program.cs". Nele, aproximadamente na linha 11, entre o opts e o useMysql digitamos o método "UseLazyLoadingProxies()".

Program

```csharp
//código omitido

builder.Services.AddDbContext<FilmeContext>(opts =>
    opts.UseLazyLoadingProxies().UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

//código omitido
```

Logo após, rodamos a aplicação clicando no botão "▶" na parte superior. Depois vamos ao Postman e clicamos no botão "Send" da aba cinema com o método get, para executarmos. Observe que no retorno continua devolvendo nulo no campo "readEnderecoDto".

Vamos entender o motivo disso continuar acontecendo e como resolvemos esse problema usando as Lazy Loading Proxies. Para compreendermos bem o que estamos fazendo, isolaremos cada chamada que estamos efetuando no método "RecuperaCinemas()" no arquivo "CinemaController.cs".

Parte do arquivo "CinemaController" usada pelo instrutor

```csharp
//código omitido

[HttpGet]
public IEnumerable<ReadCinemaDto> RecuperaCinemas()
        {
    return _mapper.Map<List<ReadCinemaDto>>(_context.Cinemas.ToList());
        }

//código omitido
```

Acima do retorno, criamos uma variável chamada "listaDeCinemas" que será igual ao nosso mapper (copiamos tudo após o retorno e colamos após o sinal de igual da variável) e depois retornamos essa lista.

CinemaController

```csharp
//código omitido

[HttpGet]
public IEnumerable<ReadCinemaDto> RecuperaCinemas()
{
    var listaDeCinemas = _mapper.Map<List<ReadCinemaDto>>(_context.Cinemas.ToList());
    return listaDeCinemas;
}

//código omitido
```

Vamos parar a aplicação e rodá-la novamente, mas desta vez em modo de depuração (para compreendermos melhor o que vai acontecer). Para colocarmos um breakpoint ("ponto de interrupção") selecionamos, do lado esquerdo, a parte em cinza mais escuro - aproximadamente na linha 35.

Em seguida, apertamos diretamente no nome do projeto "FilmesApi" na parte superior. Assim, a aplicação rodará em modo de depuração para visualizarmos passo a passo do que está acontecendo por trás.

Depois voltamos ao Postman e selecionamos o botão "Send" da aba cinema. Voltando ao código, observe que ele trava para nós: a linha da variável que criamos está grifada em amarelo e há um ícone de lâmpada à esquerda da linha.

Na parte superior, temos uma seta referente ao "Pular método (F10)", clicaremos nela para executarmos a linha grifada. Note que ele travou na linha do retorno agora. O que é essa lista de cinemas?

Com o cursor sobre "return listaDeCinemas;" note ser exibidos os dois cinemas previamente cadastrados ("Alura Cinemas" e "Alura Cinemas Outro"). Cada um possui suas respectivas colunas, e realmente o campo "readEnderecoDto" está nulo.

Com a depuração, conseguimos verificar que a nossa lista de cinemas está com um problema de mapeamento entre um endereço (que carregamos em memória) e o nosso listaDeCinemas, o Dto.

Para provarmos efetivamente que isso está acontecendo, criaremos mais uma variável (para visualizarmos) que será igual ao context.Cinemas.ToList() (sendo efetivamente os nossos cinemas do banco de dados).

CinemaController

```csharp
//código omitido

[HttpGet]
public IEnumerable<ReadCinemaDto> RecuperaCinemas()
{
    var listaDeCinemasBanco = _context.Cinemas.ToList();
    var listaDeCinemas = _mapper.Map<List<ReadCinemaDto>>(_context.Cinemas.ToList());
    return listaDeCinemas;
}
//código omitido
```

Novamente paramos a aplicação e clicamos em "FilmesApi" na parte superior, para rodarmos com depuração. Após subir a aplicação, vamos ao Postman e selecionamos o botão "Send" na aba de cinema com o método get.

No console do projeto, se analisarmos o valor de "listaDeCinemasBanco" ele mostra uma tabela que clicando que cada linha podemos expandir. Por exemplo, ao clicarmos em "listaDeCinemasBanco" conseguimos abrir mais informações, e clicando em "[0]" temos mais detalhes.

Ao selecionarmos "Endereco", temos as informações de id, logradouro e número. Podemos parar a aplicação. Logo, as informações estão aqui e, com isso, podemos deduzir que o problema está no momento de mapear a nossa lista de cinemas que vem do banco de dados (listaDeCinemasBanco) para a nossa lista de ReadCinemaDto.

Podemos remover as alterações que fizemos no código, voltando ao trecho que estava antes:

CinemaController

```csharp
//código omitido

[HttpGet]
public IEnumerable<ReadCinemaDto> RecuperaCinemas()
        {
      return _mapper.Map<List<ReadCinemaDto>>(_context.Cinemas.ToList());
        }

//código omitido
```

Como o nosso problema está no mapeamento vamos ao arquivo "CinemaProfile".

CinemaProfile

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

No momento que estamos mapeando um "Cinema" para "ReadCinemaDto", o que precisamos passar? Informamos ao AutoMapper que para determinado membro ("ForMember") ele deve fazer um mapeamento específico.

CinemaProfile

```csharp
//código omitido

CreateMap<Cinema, ReadCinemaDto>()
                .ForMember();

//código omitido
```

Estamos passando de "cinemaDto" para o membro "ReadEnderecoDto" do nosso "cinemaDto". O que desejamos fazer? Desejamos definir uma opção de mapeamento ("opt"), e queremos que para essa opção seja mapeado de algum lugar ("MapFrom"), no caso do "cinema" (já que neste momento pegamos o "cinema.Endereco" e fazer o mapeamento).

CinemaProfile

```csharp
//código omitido

            CreateMap<Cinema, ReadCinemaDto>()
                .ForMember(cinemaDto => cinemaDto.ReadEnderecoDto, 
                    opt => opt.MapFrom(cinema => cinema.Endereco));

//código omitido
```

Neste trecho, estamos criando um mapeamento entre Cinema e ReadCinemaDto, ou seja, estamos ensinando a nossa aplicação a converter de Cinema para ReadCinemaDto. O campo de endereço do arquivo "Cinema.cs" será mapeado para o campo de ReadEnderecoDto (o Automapper sabe fazer isso porque no arquivo "EnderecoProfile" ensinamos a conversão de Endereco para ReadEnderecoDto).

Agora, vamos rodar a nossa aplicação sem depurar. Após a aplicação subir, vamos ao Postman clicar no botão "Send" na aba de cinema. Observe que no corpo do retorno ele devolve a estrutura esperada:

Body do retorno no Postman

```csharp
{
"nome" : "Alura Cinemas",
"readEnderecoDto" : {
        "id": 1,
        "logradouro": "Rua das Couves",
        "numero": 300
    }
},

// retorno omitido
```

Para finalizar, por questões estéticas, no arquivo "ReadCinemaDto" alteraremos de "ReadEnderecoDto" para "Endereco" na linha 7.

ReadEnderecoDto

```csharp
// código omitido

public ReadEnderecoDto Endereco { get; set; }

// código omitido
```

Estamos padronizando e alterando para "Endereco" dado que já sabemos o tipo dele. Agora, no arquivo "CinemaProfile" vamos alterar o nome "ReadEnderecoDto" para somente "Endereco" também. Isso porque alteramos o nome da propriedade.

CinemaProfile

```csharp
CreateMap<Cinema, ReadCinemaDto>()
         .ForMember(cinemaDto => cinemaDto.Endereco, 
            opt => opt.MapFrom(cinema => cinema.Endereco));
```

Podemos rodar novamente a aplicação e voltar no Postman para selecionar o botão "Send". Observe que o nome do campo foi alterado.

Retorno no Postman

```csharp
[
    {
        "id" :1,
        "nome" : "Alura Cinemas",
        "endereco" : {
                "id": 1,
                "logradouro": "Rua das Couves",
                "numero": 300
    }
},

// retorno omitido
```

Neste vídeo, mapeamos diferentes campos passando para o Automapper como aplicar isso. Aprendemos, também, como fazer o carregamento em memória de informações entre entidades relacionadas. Esses conceitos nos ajudam a obter um retorno mais robusto para o usuário final.

Espero que tenha gostado. Até a próxima aula!

### Aula 2: Carregando em tempo de execução - Exercício

No vídeo anterior aprendemos a utilizar o conceito de “laziness” para carregar propriedades diretamente de nossas entidades.

Selecione as alternativas com as etapas que devemos seguir para que isso seja possível.

Resposta correta  
Devemos utilizar a palavra reservada virtual em nossas propriedades e definir em nosso startup que usaremos o carregamento através do método UseLazyLoadingProxies().

> Com isso, será possível carregarmos as propriedades em tempo de execução.

### Aula 2: O que aprendemos?

Nessa aula aprendemos:

- Que um relacionamento 1:1 cria um vínculo entre uma e somente uma entidade dos dois lados.
- Podemos definir a cardinalidade do relacionamento através das propriedades do modelo.
- Como definir relações de dependência através das propriedades.
- Como habilitar e utilizar Lazy Properties com o método UseLazyLoadingProxies().
- Propriedades lazy podem ser acessadas diretamente em tempo de execução.
- Como fazer mapeamentos mais complexos com os métodos ForMember() e MapFrom().

## Aula 2: Relacionamento 1:n

### Aula 3: Projeto da aula anterior

Caso queira, você pode [baixar o projeto do curso](https://github.com/alura-cursos/dotnet-api-2/tree/Aula-2) no ponto em que paramos na aula anterior.

### Aula 3: Criando a Sessão - Vídeo 1

Transcrição  
Nós criamos cinemas, filmes, endereços e já temos algumas entidades. A seguir, vamos crescer ainda mais o nosso sistema, usando o conceito de sessão.

Quando decidimos ir ao cinema, nós compramos um ingresso para assistir a uma sessão, que ocorrerá em um cinema e exibirá um filme para nós. Portanto, vamos criar o conceito de sessão no nosso sistema.

Classe  
No Visual Studio, vamos clicar com o botão direito sobre a pasta "Models", selecionar "Adicionar > Classe..." e criar uma classe chamada Sessao.cs. O resultado será o seguinte arquivo:

```csharp
namespace FilmesApi.Models
{
    public class Sessao
    {
    }
}
```

Apesar de já termos realizado esse processo na criação das classes Cinema e Endereco, vamos reparar em breve que a sessão tem algumas peculiaridades.

A princípio, a sessão terá a propriedade ID com os atributos [Key] e [Required]. Logo, também será preciso importar o namespace dos Data Annotations:

```csharp
using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Models
{
    public class Sessao
    {
        [Key]
        [Required]
        public int Id { get; set; }
    }
}
```

A sessão pode ter uma série de campos, como capacidade máxima de pessoas ou preço. Nosso objetivo atual é que o sistema seja funcional e enxuto, então vamos prosseguir apenas com a propriedade ID, por enquanto.

DTO  
A seguir, vamos criar nossos DTOs. Vamos clicar com o botão direito sobre a pasta "Data > Dtos", selecionar "Adicionar > Classe..." e nomeá-la ReadSessaoDto.cs. Nesse arquivo de leitura, retornaremos o ID:

```csharp
namespace FilmesApi.Data.Dtos
{
    public class ReadSessaoDto
    {
            public int Id { get; set; }
    }
}
```

Em seguida, vamos clicar novamente sobre a pasta "Data > Dtos", selecionar "Adicionar > Classe..." e nomeá-la CreateSessaoDto.cs. O resultado será o seguinte arquivo:

```csharp
using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Data.Dtos
{
    public class CreateSessaoDto
    {
    }
}
```

Por que criamos um DTO responsável pela criação, se a única propriedade que temos atualmente é o ID e, no momento da criação, não passamos esse valor? Mais adiante, vamos entender o motivo!

Profile  
Assim, temos o modelo Sessao.cs, o DTO de leitura ReadSessaoDto.cs e o DTO de criação CreateSessaoDto.cs. A seguir, criaremos o profile.

Vamos clicar sobre a pasta "Profiles", selecionar "Adicionar > Classe..." e nomeá-la SessaoProfile.cs. Essa classe estenderá o Profile do AutoMapper:

```csharp
using AutoMapper;

namespace FilmesApi.Profiles
{
    public class SessaoProfile : Profile
    {
    }
}
```

Nessa classe, criaremos um construtor que terá um CreateMap<> de CreateSessaoDto para uma Sessao. Para fazer as importações correspondentes, podemos posicionar o cursor sobre Sessao e pressionar "Ctrl + Enter":

```csharp
using AutoMapper;
using FilmesApi.Data.Dtos;
using FilmesApi.Models;

namespace FilmesApi.Profiles
{
    public class SessaoProfile : Profile
    {
        public SessaoProfile()
        {
            CreateMap<CreateSessaoDto, Sessao>();
        }
    }
}
```

Além disso, teremos um CreateMap<> para uma Sessao até um ReadSessaoDto:

```csharp
using AutoMapper;
using FilmesApi.Data.Dtos;
using FilmesApi.Models;

namespace FilmesApi.Profiles
{
    public class SessaoProfile : Profile
    {
        public SessaoProfile()
        {
            CreateMap<CreateSessaoDto, Sessao>();
            CreateMap<Sessao, ReadSessaoDto>();
        }
    }
}
```

Não vamos nos preocupar muito com questões de atualização e remoção, pois já estudamos esses recursos no curso anterior. Para evitar essa repetição, deixaremos essa parte mais enxuta.

Controlador  
Vamos clicar com o botão direito sobre a pasta "Controllers", selecionar "Adicionar > Classe..." e nomeá-la SessaoController.cs. Nesse arquivo, colocaremos o seguinte código:

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
    public class SessaoController : ControllerBase
    {
        private FilmeContext _context;
        private IMapper _mapper;

        public SessaoController(FilmeContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult AdicionaSessao(CreateSessaoDto dto)
        {
            Sessao sessao = _mapper.Map<Sessao>(dto);
            _context.Sessoes.Add(sessao);
            _context.SaveChanges();
            return CreatedAtAction(nameof(RecuperaSessoesPorId), new { Id = sessao.Id }, sessao);
        }

        [HttpGet]
        public IEnumerable<ReadSessaoDto> RecuperaSessoes()
        {
            return _mapper.Map<List<ReadSessaoDto>>(_context.Sessoes.ToList());
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaSessoesPorId(int id)
        {
            Sessao sessao = _context.Sessoes.FirstOrDefault(sessao => sessao.Id == id);
            if (sessao != null)
            {
                ReadSessaoDto sessaoDto = _mapper.Map<ReadSessaoDto>(sessao);

                return Ok(sessaoDto);
            }
            return NotFound();
        }
    }
}
```

O controlador SessaoController estende de ControllerBase, assim como os demais controladores que desenvolvemos anteriormente.

Nele, também temos o FilmeContext e precisamos criar nosso DbSet<> de Sessoes. Para acessar o arquivo FilmeContext.cs, podemos fazer um "Ctrl + Clique" sobre FilmeContext, na linha 13.

Em FilmeContext.cs, criaremos o DbSet`<Sessoes>` chamado Sessoes:

```csharp
using FilmesApi.Models;
using Microsoft.EntityFrameworkCore;

namespace FilmesApi.Data;

public class FilmeContext : DbContext
{
    public FilmeContext(DbContextOptions<FilmeContext> opts)
        : base(opts)
    {

    }

    public DbSet<Filme> Filmes { get; set; }
    public DbSet<Cinema> Cinemas { get; set; }
    public DbSet<Endereco> Enderecos { get; set; }
    public DbSet<Sessao> Sessoes { get; set; }
}
```

Voltando ao controlador, ele estará funcionando sem problemas.

Como criamos esse projeto apenas com operações de escrita e leitura, não temos o verbo de atualização (PUT ou PATCH) nem o de remoção (DELETE).

O método AdicionaSessao() será responsável por adicionar uma sessão ao sistema, mas o que acontecerá exatamente? Nesse método, recebemos um CreateSessaoDto (que até então está vazio), realizamos o mapeamento para uma sessão, geramos um ID, adicionamos a sessão e salvamos essas mudanças. Seguindo o padrão arquitetural REST, o retorno é a localização para acessarmos o recurso recém-criado.

Por que criamos uma sessão se ela só tem um ID e um DTO vazio? Agora que geramos a sessão no sistema, começaremos a relacioná-la com um filme e um cinema, dado que esses elementos estão ligados à sessão. Assim, a disposição e o tráfego de informações ficarão melhor estruturados no nosso sistema, pois adicionaremos uma camada de complexidade (no bom sentido).

Na sequência, vamos relacionar a sessão com a entidade do filme.

### Aula 3:  - Vídeo 2
### Aula 3:  - Vídeo 3
### Aula 3:  - Vídeo 4
### Aula 3:  - Vídeo 5
### Aula 3:  - Vídeo 6
### Aula 3:  - Vídeo 7
### Aula 3:  - Vídeo 7

