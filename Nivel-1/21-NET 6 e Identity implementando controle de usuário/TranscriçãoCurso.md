# Curso Alura .NET 6 e Identity: implementando controle de usuário

## Aula 1: Conhecendo o Identity

### Aula 1: Apresentação - Vídeo 1

Transcrição  
Olá! O Daniel Artine vai ser seu instrutor nesse curso da Alura sobre .NET 6 com Identity. Também vamos utilizar conceitos de ASP.NET da parte web.

Daniel Artine é uma pessoa de pele clara, olhos castanhos escuros e cabelos pretos curtos. Usa barba e bigode. Está com camiseta preta, sentado em uma cadeira preta. Ao fundo, há uma parede com iluminação azul.

Objetivo  
Nesse curso, vamos começar um projeto totalmente do zero. A ideia é criar um serviço onde seja possível fazer o cadastro e login da pessoa usuária, bem como permitir ou bloquear acesso baseado em suas características, por exemplo, a idade.

Pré-requisitos  
Contudo, para começar esse curso, é preciso ter concluídos os cursos de pré-requisitos.

Nessa formação de ASP.NET Core, temos o curso de criação de web API com .NET 6 e também o curso de relacionamento de entidade com .NET 6, onde usamos o Entity para fazer esse relacionamento entre diferentes entidades em um sistema.

Ressaltamos que vamos partir de um conhecimento prévio dos cursos anteriores, mas com um novo projeto.

Conteúdo  
Vamos aprender diversas etapas para fazer a criação de um usuário utilizando o Identity. Também vamos entender como abstrair, o que é o Identity e como ele pode nos ajudar.

Além disso, vamos seguir boas práticas para fazer a utilização do UserManager e dos recursos embutidos no Identity.

Também vamos aprender como e para quê criar e trafegar um token que contenha as informações da pessoa usuária, além de como gerenciar o controle de acesso através da interceptação das requisições que a pessoa usuária vai fazer.

Em suma, vamos abordar questões sobre criação e login da pessoa usuária, assim como o conceito de JWT, como trafegar informações através de um token e como validar se realmente podemos acessar determinado recurso.

Caso você já tenha os pré-requisitos necessários para fazer esse curso, te esperamos no próximo vídeo.

### Aula 1: Conhecendo o Identity - Vídeo 2

Transcrição  
Vamos partir para o conteúdo do nosso curso. Como explicado anteriormente, a ideia desse curso é ter uma abordagem mais voltada ao controle e fluxo de pessoa usuária: como cadastro, login e afins. Mas, antes, precisamos saber como isso vai funcionar no escopo atual.

Anteriormente, já fizemos o processo de armazenamento com filmes, cinemas, sessões e endereços. Agora, o objetivo é entrar nesse escopo de pessoa usuária para armazenar essas pessoas no nosso banco de dados. Mas, qual é a diferença?

Queremos cadastrar essa pessoa usuária de alguma maneira. Cada pessoa pode ter informações, como id, username, e-mail e senha. Esses são possíveis campos que essa pessoa poderia ter armazenado na nossa base de dados.

Também podemos querer fazer login. Para isso, precisamos dar uma forma para a pessoa usuária se autenticar nesse sistema e ter alguns conceitos de identidade.

Por exemplo, a pessoa usuária passou username e senha válidos. Como autenticar essa pessoa dentro do sistema? O que significa estar autenticado? Como fazer esse tráfego de dados? A partir do momento que gravamos o dado no banco, precisamos validar se esse dado está correto para fazer a autenticação da pessoa usuária.

Com isso, levantamos algumas perguntas:

Como acessar o banco de maneira prática para cadastrar um usuário?

Já aprendemos que temos o Entity para intermediar essa comunicação entre aplicação e acesso ao banco.

Podemos usar o Entity para criar as tabelas no banco?

Pode, já fizemos isso anteriormente em outro escopo, ou seja, com outros modelos e entidades dentro do nosso sistema.

Mas, ainda existem mais questionamentos.

Como validar pessoa usuária e senha para autenticação?

Suponha que cadastramos uma pessoa usuária, temos uma tabela com seu id, username e senha no banco, onde vamos gravar esses dados.

Mas, será que é seguro armazenar essa senha da pessoa usuária em plain text, ou seja, sem nenhum tipo de criptografia, de modo que qualquer pessoa que acesse o banco consegue visualizar essa senha?

Como fazer essa criptografia e descriptografia nesse processo de autenticação da pessoa usuária? Em outras palavras:

Como armazenar a senha de maneira segura?

Além dessas questões de armazenamento seguro, levantamos ainda outras perguntas:

Como adicionar critérios extras de segurança?

Por exemplo, a partir do momento que fazemos a autenticação da pessoa usuária, por quanto tempo sua sessão vai durar? A sessão vai expirar por tempo ou vai ser manual? Como a pessoa usuária vai informar que está devidamente autenticada?

Ainda existem diversas questões que precisamos responder.

Para isso, vamos utilizar o Identity. De maneira análoga ao Entity que faz essa parte de comunicação com o banco de dados, o Identity é um arsenal que o .NET nos provê para utilizar diversos conceitos de identidade dentro de uma aplicação .NET.

Por exemplo, a partir do momento em que temos clientes fazendo envio para aplicação ao fazer operações de cadastro ou login, o servidor que vai ter a nossa aplicação .NET que utiliza o Identity já vai ter diversos recursos e aplicações já implementadas para conseguir fazer essas operações de maneira mais prática. Com isso, não vamos precisar nos preocupar em implementar uma criptografia ou armazenamento de pessoa usuária do zero.

Ao longo desse curso, vamos aprender como o Identity pode nos ajudar a configurar o banco, cadastrar e logar pessoas usuárias.

Próximos passos  
Nesse vídeo, descobrimos que vamos utilizar o Identity, para que ele serve e por que não deveríamos apenas utilizar somente o Entity nesse caso.

Nos próximos vídeos, vamos aprender o passo a passo de como configurar e definir uma pessoa usuária. Até mais.

### Aula 1: Benefícios do Identity - Exercício

No vídeo, vimos problemas que o Identity nos ajuda a resolver com relação à autenticação e autorização de usuários na nossa aplicação.

Quais os benefícios de utilizar do Identity?

Alternativa correta  
Com o Identity, conseguimos implementar critérios adicionais de segurança para a nossa aplicação.

> Utilizando o Identity, é possível configurar, por exemplo, uma confirmação de e-mail como etapa adicional de segurança.

Alternativa correta  
O Identity provê uma implementação para armazenar senhas/credenciais de maneira segura.

> Utilizando o Identity não é preciso se preocupar com questões de criptografias de dados sensíveis como senhas.

### Aula 1: Recebendo um usuário - Vídeo 3

Transcrição  
Vamos criar um novo projeto com o mesmo processo feito nos cursos anteriores dessa formação. Por isso, os pré-requisitos são tão importantes. Vamos assumir que você já tenha instalado o Visual Studio.

Criando um projeto com Visual Studio  
Com o Visual Studio já aberto, vamos selecionar a última opção do menu "Introdução" para "Criar um projeto".

Se o ambiente de desenvolvimento do Visual Studio já estiver aberto, você também pode pressionar "Ctrl+Shift+N" para criar um novo projeto.

Vamos clicar na barra de pesquisa (ou "Alt + S") para pesquisar modelos e buscar por "api". Vamos utilizar a "API Web do ASP.NET Core". Depois, pressionamos o botão "Próximo" no canto direito inferior (ou "Enter").

Na tela "Configurar seu novo projeto", vamos nomear o projeto e a solução como UsuariosApi. Apertamos no botão de "Próximo" novamente.

Nas "informações adicionais", vamos deixar a estrutura como ".NET 6.0 (Suporte de longo prazo)". Em seguida, clicaremos em "Criar" no canto inferior direito da tela.

Atente-se ao uso do .NET 6. Não utilize .NET 5 ou 7. Com isso, evitamos quaisquer problemas de compatibilidade de alguma biblioteca (lib) defasada ou que ainda esteja em testes no .NET 7.

Criando um novo controlador  
Agora, o Visual Studio vai fazer todo o processo de criação de um projeto e criar uma estrutura base de weather forecast (previsão do tempo). Contudo, não é isso que queremos.

O começo desse projeto é fazer o cadastro de uma pessoa usuária em nosso sistema. Mas, antes de nos preocuparmos em como colocar a pessoa usuária no banco e fazer o controle de requisição, precisamos pensar em como criar, ter e modelar essa pessoa usuária.

Primeiro, vamos apagar permanentemente os arquivos WeatherForecastController.cs e WeatherForecast.cs com a tecla "Delete".

Em seguida, vamos criar um novo controlador. Para isso, vamos clicar com o botão direito do mouse na pasta de "Controllers" e selecionar "Adicionar > Classe" (ou "Shift + Alt + C"). Vamos chamá-la de UsuarioController. Essa será a classe responsável por receber as requisições de criação de uma pessoa usuária.

```csharp
UsuarioController.cs:

namespace UsuariosApi.Controllers
{
    public class UsuarioController
    {
    }
}
```

Voltamos a frisar que já fizemos todo esse processo anteriormente de criação de controlador, modelo, AutoMapper, DTOs e afins. Estamos recapitulando brevemente para sem nos aprofundar. Caso você tenha dúvidas sobre algum tópico, sugerimos retornar nos cursos anteriores.

Para criar um controlador, precisamos de anotações básicas como ApiController entre colchetes.

No caso, também vamos colocar a API de rota em uma nova linha, ou seja, Route() entre colchetes. Vamos colocar que a nossa rota vai ser para o nome do nosso controlador, digitando Controller entre colchetes e aspas nos parênteses de Route.

Não queremos utilizar esse AspNetCore.Components que aparece automaticamente na primeira linha do código. Podemos apagar essa linha.

Vamos clicar em "Alt + Enter" em cima de ApiController para revelar context actions do ReSharper. Vamos escolher "using Microsoft.AspNetCore.Mvc" para utilizá-lo.

```csharp
using Microsoft.AspNetCore.Mvc;

namespace UsuariosApi.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class UsuarioController
    {
    }
}
```

Em seguida, nosso UsuarioController vai estender de ControllerBase.

Por fim, o nosso controlador vai ter uma anotação de HttpPost entre colchetes dentro da classe. Já que estamos criando um recurso dentro do nosso sistema que vai ser o public IActionResult CadastraUsuario().

Como ainda não vamos nos preocupar com a lógica de cadastramento, vamos escrever um throw new NotImplementedException() no IActionResult.

```csharp
using Microsoft.AspNetCore.Mvc;

namespace UsuariosApi.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class UsuarioController : ControllerBase
    {
        [HttpPost]
        public IActionResult CadastraUsuario()
        {
            throw new NotImplementedException();
        }
    }
}
```

Criando um DTO  
Para poder receber efetivamente o que queremos criar, precisamos criar o nosso DTO.

Dessa forma, clicamos na pasta "UsuariosApi" no projeto raiz com o botão direito do mouse para "Adicionar > Nova Pasta". Vamos criar a pasta "Data" que se refere a toda a parte de dados.

Em seguida, clicamos novamente com o botão direito "Adicionar > Nova Pasta" em "Data" e nomeamos a nova pasta como "Dtos".

Dentro da pasta "Dtos", vamos adicionar uma nova classe chamada CreateUsuarioDto.

```csharp
CreateUsuarioDto.cs:

namespace UsuariosApi.Data.Dtos
{
    public class CreateUsuarioDto
    {
    }
}
```

O que a criação da pessoa usuária vai ter? Como queremos criar uma pessoa usuária?

Vamos ter alguns campos que a pessoa vai precisar passar. O Visual Studio sugere o ID, mas não usaremos esse campo.

Vamos utilizar a annotation de Required do DataAnnotations, pois queremos ter um username obrigatório. Para isso, escrevemos prop e apertamos a tecla "Tab" duas vezes para criar uma propriedade marcada como public. Em seguida, definimos seu tipo como string e nome como Username.

Assim, a pessoa usuária vai ter um username, isto é, um nome de pessoa usuária dentro do nosso sistema.

Outra informação que queremos que seja obrigatória é a data de nascimento. Para isso, criamos outra propriedade pública do tipo DateTime chamada DataNascimento.

```csharp
using System.ComponentModel.DataAnnotations;

namespace UsuariosApi.Data.Dtos
{
    public class CreateUsuarioDto
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public DateTime DataNascimento { get; set; }
    }
}
```

A nossa pessoa usuária também precisa de uma senha. Por isso, criamos mais uma propriedade obrigatória de acesso público do tipo string chamada Password. Você também pode chamar de Senha, como preferir.

Contudo, precisamos explicitar que essa propriedade deve ser tratada como senha. Para isso, depois de required, devemos colocar a anotação DataType() seguido do tipo de data para a senha, DateType.Password.

Geralmente quando criamos uma pessoa usuária, colocamos nome, data de nascimento e senha. Outro detalhe comum no momento do cadastro é um pedido de confirmação da senha. Assim, a pessoa não tem que fazer um processo de redefinição de senha, caso tenha digitado a senha errada.

Mas, essa senha a confirmar não é gravada no banco, pois esse processo é feito só no momento de validação do cadastro da pessoa usuária.

Podemos ter outra propriedade obrigatória que queremos comparar com o campo de Password. Para isso, colocamos a annotation required e, em uma nova linha, a annotation Compare("Password").

Depois, queremos ter um campo de confirmação de senha. Note como o próprio Visual Studio sugere esse campo string chamado PasswordConfirmation. Vamos aceitar a sugestão apertando "Ctrl + .". Porém, vamos colocar um nome mais simples, RePassword.

Com isso, temos um campo obrigatório que vai ser comparado com Password e devem ser iguais para que a validação seja bem feita.

```csharp
    public class CreateUsuarioDto
    {
// código omitido…

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [Compare("Password")]
        public string RePassword { get; set; }
    }
}
```

Vamos voltar ao arquivo UsuarioController.cs. No nosso controlador, queremos receber o CreateUsuarioDto ao cadastrar um usuário. Por isso, em Cadastrausuario(), vamos passar CreateUsuarioDto como dto.

```csharp
UsuarioController.cs:

using Microsoft.AspNetCore.Mvc;
using UsuariosApi.Data.Dtos;

// código omitido…

public class UsuarioController : ControllerBase
{

    [HttpPost]
    public IActionResult CadastraUsuario(CreateUsuarioDto dto)
    {
        throw new NotImplementedException();
    }
}
```

Convertendo DTO para modelo  
Além disso, no momento em que recebemos o DTO e implementamos a lógica de cadastro, vamos efetivamente converter esse DTO para uma pessoa usuária.

Para isso, precisamos criar na nossa raiz "UsuariosApi" uma nova pasta de "Profiles".

Vamos utilizar o AutoMapper para fazer a conversão de um DTO para um modelo. Então, vamos adicionar uma nova classe chamada UsuarioProfile dentro de "Profiles".

```csharp
UsuarioProfile.cs:

namespace UsuariosApi.Profiles
{
    public class UsuarioProfile
    {
    }
}
```

Como vamos utilizar AutoMapper, precisamos fazer a importação do pacote. Para isso, vamos selecionar no menu superior "Ferramentas > Gerenciador de Pacotes do NuGet > Gerenciar Pacotes do NuGet para a Solução".

Em "Procurar" da nova aba, vamos clicar na barra de pesquisa (ou "Ctrl + L") e digitar "automapper". Vamos fazer a instalação da segunda opção "AutoMapper.Extensions.Microsoft.DependencyInjection".

Na coluna do lado direito, vamos marcar o nosso projeto UsuariosApi, utilizar a versão 12.0.0 e clicar no botão "Instalar". Clicamos em "OK" no aviso "Visualizar Alterações".

Vamos selecionar novamente o UsuarioProfile.cs nas abas de arquivos abertos.

O que queremos é estender a classe UsuarioProfile de Profile. No momento em que apertamos "Alt + Enter" em Profile, vamos utilizar o AutoMapper.

Dentro da classe, vamos digitar ctor e clicar na tecla "Tab" duas vezes para criar o construtor UsuarioProfile().

No construtor, vamos ter uma chamada ao CreateMap de um CreateUsuarioDto para um Usuario. As classes de origem e destino devem estar entre os sinais de menor e maior que (<>) e separado por vírgula. Ao final da linha, acrescentamos parênteses vazios.

Repare que usamos CreateUsuarioDto de Data.Dtos, mas onde está o nosso modelo de Usuario?

```csharp
using AutoMapper;
using UsuariosApi.Data.Dtos;

namespace UsuariosApi.Profiles
{
    public class UsuarioProfile : Profile
    {
        public UsuarioProfile()
        {
            CreateMap<CreateUsuarioDto, Usuario>();
        }
    }
}
```

Criando nosso modelo de pessoa usuária  
Vamos criar uma nova pasta chamada "Models" em "UsuariosApi". Dentro da pasta de "Models", vamos adicionar uma nova classe chamada Usuario.

Como já explicamos, o Identity vai ser responsável por fazer todo esse controle de criação, identificação, cadastramento de senha no banco, criptografia, entre outros.

Por isso, por enquanto nosso arquivo Usuario.cs vai estar vazio. Sem acrescentar nenhum campo. A ideia é que o Identity faça isso posteriormente.

```csharp
Usuario.cs:

using Microsoft.AspNetCore.Identity;

namespace UsuariosApi.Models
{
    public class Usuario
    {
    }
}
```

Agora, vamos voltar no arquivo UsuarioProfile.cs. Vamos apertar "Alt + Enter" na classe de destino Usuario do CreateMap para fazer a importação no namespace.

```csharp
UsuarioProfile.cs:

using AutoMapper;
using UsuariosApi.Data.Dtos;
using UsuariosApi.Models;

// código omitido…
```

Nesse momento, temos o nosso código compilável: o controlador que chama o nosso método, o DTO, o modelo e o profile.

A ideia é utilizar o Identity para dar um formato mais amigável para a nossa estrutura, entendendo melhor o que precisamos fazer. Mas, já temos a estrutura base para receber uma pessoa usuária através de uma requisição. A partir daí, vamos aprender como cadastrar essa pessoa usuária no nosso sistema.

### Aula 1: Faça como eu fiz: revisando controladores

Nesta atividade, abordaremos um pouco do conteúdo dos cursos anteriores a fim de construir uma estrutura base para a futura criação de um usuário: criação de controladores, profiles, modelos e DTOs.

Opinião do instrutor

Inicialmente, crie um projeto web api .NET 6 com o Visual Studio. Ao criar, apague as classes e controladores que já vêm por padrão, exceto a classe Program e os arquivos de configuração.

Em seguida, na pasta Controllers, crie o UsuarioController:

```csharp
[ApiController]
    [Route("[Controller]")]
    public class UsuarioController : ControllerBase
    {

        [HttpPost]
        public IActionResult CadastraUsuario(CreateUsuarioDto dto)
        {
            throw new NotImplementedException();
        }
    }
```

Na raiz do projeto, crie a pasta Data e, dentro dela, crie outra pasta chamada Dtos. Nessa pasta faremos o nosso CreateUsuarioDto:

```csharp
public class CreateUsuarioDto
{
    [Required]
    public string Username { get; set; }
    [Required]
    public DateTime DataNascimento { get; set; }
    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; }
    [Required]
    [Compare("Password")]
    public string RePassword { get; set; }
}
```

Com o auxílio do nuget, instale a biblioteca AutoMapper.Extensions.Microsoft.DependencyInjection na versão 12.0.0. Depois, crie a pasta Profiles com a classe UsuarioProfile:

```csharp
public class UsuarioProfile : Profile
{
    public UsuarioProfile()
    {
        CreateMap<CreateUsuarioDto, Usuario>();
    }
}
```

Para finalizar, crie na raiz do projeto a pasta Models com a classe Usuario, inicialmente vazia:

```csharp
public class Usuario
{
}
```

### Aula 1: Comparando parâmetros - Exercício

Anteriormente, criamos as classes necessárias para receber as requisições do cadastro de um Usuario em nosso sistema. A fim de garantir que o campo Password seja igual ao campo de RePassword, podemos utilizar uma anotação nativa do .NET.

Qual é a anotação que podemos utilizar nesse caso?

Alternativa correta  
[Compare]

> Essa anotação compara e avalia se dois campos são iguais.

### Aula 1: O que aprendemos?

Nessa aula, aprendemos:

- O Identity é um sistema para criar, ler, atualizar e remover contas de usuários;
- Podemos integrar o Identity com o Entity para armazenar os dados dos usuários;
- O Identity é configurável para se adequar às necessidades da pessoa que está desenvolvendo;
- Como comparar diferentes campos com a anotação [Compare].

## Aula 2: Configurando o Identity

### Aula 2: Projeto da aula anterior

Caso queira, você pode [baixar o projeto do curso](https://github.com/alura-cursos/alura-identity/tree/Aula-1) no ponto em que paramos na aula anterior.

### Aula 2: Configurando o banco - Vídeo 1

Transcrição  
Para dar o próximo passo com o Identity, precisamos criar toda a utilização do DbContext para fazer a comunicação com o banco. Além disso, vamos configurar como o Identity se comunicará com o banco, ou seja, como especificamente queremos configurar o nosso usuário.

Para ganhar tempo, vamos apenas conhecer as versões de algumas bibliotecas que precisamos instalar (as acessamos em "Ferramentas > Gerenciador de Pacotes do NuGet > Gerenciar Pacotes do NuGet para a Solução"):

- Microsoft.AspNetCore.Identity.EntityFrameworkCore (versão 6.0.14)
- Microsoft.EntityFrameworkCore.Tools (versão 6.0.14)
- Microsoft.Extensions.Identity.Stores (versão 6.0.14)

Observação: se você procurar por "Identity.Stores", vai surgir uma biblioteca com esse exato nome. No entanto, queremos a indicada acima.

- Pomelo.EntityFrameworkCore.MySql (versão 6.0.2)
- AutoMapper.Extensions.Microsoft.DependencyInject (versão 12.0.0, que já havíamos instalado)

Contexto para comunicação com banco de dados
A primeira etapa é a seguinte: no nosso Program.cs, precisamos indicar que a aplicação utilize determinado contexto para se comunicar com o banco de dados.

Já fizemos isso anteriormente nos cursos prévios, então passaremos por isso sem explicações aprofundadas, apenas quando houver novidade.

Se queremos fazer uma comunicação e utilizar um DbContext, precisamos escrever builder.Services.AddDbContext(). Ele terá uma especificidade: esse DbContext que queremos adicionar será um UsuarioDbContext, respectivo para o nosso usuário. Então:

Program.cs

```csharp
builder.Services.AddDbContext<UsuarioDbContext>()
```

Nesse momento, como estamos fazendo essa referência a um usuário DbContext que ainda não existe, precisamos criá-lo.

Criando o UsuarioDbContext  
Para isso, clicamos na pasta "Data" com o botão direito e, depois, em "Adicionar > Classe". Vamos nomear essa classe como UsuarioDbContext.

Aprendemos que, no fluxo tradicional da criação de um DbContext, até então, indicávamos que a classe seria um DbContext, criando o DbContext em si.

A diferença agora é que não será um DbContext, mas um IdentityDbContext que faz referência, especificamente, a um Usuario. Afinal, é o modelo que estamos utilizando para mapear um usuário para o banco, em Usuario.cs. Então:

UsuarioDbContext.cs

```csharp
public class UsuarioDbContext : 
    IdentityDbContext<Usuario>
```

Agora, com o cursor posicionado ao final de Usuário, vamos pressionar "Alt + Enter" para usar o modelo.

Ainda precisamos fazer a utilização do nosso construtor. Então digitamos ctor e pressionamos "Enter". Com isso, surge a linha public UsuarioDbContext(), que receberá DbContextOptions. O DbContextOptions, por sua vez, será do nosso UsuarioDbContext, que chamaremos de opts. Teremos a linha: public UsuarioDbContext(DbContextOptions`<UsuarioDbContext>` opts).

Por fim, esse construtor vai chamar o construtor da nossa superclasse, com base(opts). Então:

UsuarioDbContext.cs

```csharp
public class UsuarioDbContext : 
    IdentityDbContext<Usuario>
{
    public UsuarioDbContext
        (DbContextOptions<UsuarioDbContext> opts) : base(opts) { }
}
```

Extensão de IdentityUser
Você pode reparar que o UsuarioDbContext continua reclamando. Isso porque temos a nossa classe Usuario e, para indicarmos que esse modelo da nossa aplicação é um usuário tratável e que possui informações a armazenar no banco pelo Identity, precisamos estender dela o IdentityUser:

Usuario.cs

```csharp
public class Usuario : IdentityUser
{
}
```

Se pressionarmos "Ctrl" e clicarmos com o botão esquerdo em IdentityUser, conseguimos verificar como essa classe foi feita, o que há dentro dela. Descendo a tela, observamos diversas propriedades:

ID

```csharp
[PersonalData]
public virtual TKey Id { get; set; }
```

Username

```csharp
[ProtectedPersonalData]
public virtual string UserName { get; set; }
```

Username normalizado, devidamente tratado

```csharp
public virtual string NormalizedUserName { get; set; }
```

E-mail

```csharp
[ProtectedPersonalData]
public virtual string Email { get; set; }
```

E-mail normalizado

```csharp
public virtual string NormalizedEmail { get; set; }
```

E-mail confirmado

```csharp
[PersonalData]
public virtual bool EmailConfirmed { get; set; }
```

Hash da senha

```csharp
public virtual string PasswordHash { get; set; }
```

TimeStamp de segurança:

```csharp
public virtual string SecurityStamp { get; set; }
```

Número de telefone

```csharp
[ProtectedPersonalData]
public virtual string PhoneNumber { get; set; }
```

Todas essas propriedades estão disponíveis para utilizarmos. Então, talvez você possa se perguntar: "Por que eu preciso do meu Usuario? Não bastaria indicar, no UsuarioDbContext.cs, que utilizaremos diretamente um IdentityUser?".

Poderíamos! Conseguiríamos inserir IdentityUser em IdentityDbContext<> sem nenhum problema. Inclusive, ele para de reclamar.

Mas, criando um modelo próprio e customizado, conseguimos criar propriedades que não são cobertas pelo IdentityUser já feito pelo Identity. Por exemplo, a data de nascimento.

Atualizando o modelo Usuario  
Então, no modelo Usuario.cs, poderíamos indicar que nosso usuário terá uma propriedade escrevendo prop e apertando "Enter", resultando em public int MyProperty { get; set }. Essa propriedade será um DateTime (substituímos int), que terá a DataNascimento (substituímos MyProperty):

Usuario.cs

```csharp
public class Usuario : IdentityUser
{
         public DateTime DataNascimento { get, set } 
}
```

Agora precisamos indicar que, quando um usuário for instanciado, faremos a chamada do construtor da superclasse desse usuário - no caso, o IdentityUser. Então escrevemos ctor logo abaixo da última linha e pressionamos "Enter", resultando em public Usuario() {}.

Apagamos as chaves para continuar escrevendo na mesma linha e, após os parenteses, inserimos dois pontos (:) e chamamos o construtor, com base() { }:

Usuario.cs

```csharp
public class Usuario : IdentityUser
{
         public DateTime DataNascimento { get, set } 
         public Usuario() : base() { } 
}
```

Com isso, definimos que nosso Usuario, além de ter todas as propriedades e possíveis métodos do IdentityUser, também possui a propriedade DataNascimento, um campo personalizado nosso.

É isso que ganhamos ao criar um Usuario estendendo o IdentityUser!

Especificação do DbContext  
Se voltarmos para o Program.cs, conseguimos dar um "Alt + Enter" no nosso UsuariosApi.Data para utilizar o UsuarioDbContext. Agora ele não está mais reclamando!

Lembrete: faremos essa parte mais rapidamente e sem muitas explicações porque aprendemos tudo isso nos cursos prévios.

Na linha seguinte, teremos nossas opções (opts => {}). Colocaremos as opções que desejamos para esse DbContext dentro das chaves. Diremos, então, que queremos utilizar o "mySql" (opts.UseMySql()).

A primeira configuração que precisamos passar nesses parênteses é a connection string. Então: builder.Configuration.getConnectionString(), cujo nome será "UsuarioConnection". O segundo parâmetro será a versão: ServerVersion.AutoDetect(), em que passaremos novamente a connection string.

Para limpar o código, podemos criar a variável para a connection string, connString e trocar suas ocorrências pela leitura da variável. Então:

Program.cs

```csharp
var connString = builder.Configuration.GetConnectionString("UsuarioConnection");

builder.Services.AddDbContext<UsuarioDbContext>
    (opts =>
    {
        opts.UseMySql(connString, ServerVersion.AutoDetect(connString));
    });
```

Bacana! Fizemos a especificação do nosso DbContext.

Configurações de Identity  
Agora, precisamos fazer algumas configurações a nível de Identity. Abaixo da nossa definição de banco, indicaremos que queremos adicionar o Identity através do builder.Services, então: builder.Services.AddIdentity().

Nesse momento, o AddIdentity será reclamado porque precisamos passar alguns parâmetros para ele. O Identity que estamos usando será de um Usuario (pressionamos "Alt + Enter" nele para utilizá-lo). Esse nosso modelo de usuário terá também uma IdentityRole:

Program.cs

```csharp
builder.Services
    .AddIdentity<Usuario, IdentityRole>()
```

O que estamos dizendo aqui é o seguinte: "Identity, eu quero adicionar o conceito de identidade para esse usuário, e o papel desse usuário (IdentityRole) dentro do nosso sistema também será gerenciado por você". Isso ficará nebuloso por enquanto, mas entenderemos o que isso quer dizer mais adiante.

Precisamos de mais alguns detalhes. Para isso, encadearemos mais instruções dentro do builder.Services. Por exemplo: .AddEntityFrameworkStores`<UsuarioDbContext>`() para dizer que estamos utilizando esse DbContext para fazer a comunicação com o nosso banco de dados. Ou seja, quem armazenará as configurações desse usuário em si será o UsuarioDbContext.

Por fim, adicionamos o .AddDefaultTokenProviders`<UsuarioDbContext>`(), que utilizaremos posteriormente para a questão de autenticação. Temos, então:

Program.cs

```csharp
builder.Services
    .AddIdentity<Usuario, IdentityRole>()
    .AddEntityFrameworkStores<UsuarioDbContext>()
    .AddDefaultTokenProviders();
```

Certo. Nesse momento, conseguimos abrir o nosso AppSettings e definir que nossa "ConnectionStrings" terá um "UsuarioConnection".

Usaremos uma connection string padrão para manter o fluxo: servidor localhost, em que podemos utilizar a porta desejada, como 5008. O banco de dados será o usuariodb, o usuário e a senha serão root. Já fizemos toda a instalação e configuração de um MySql nos cursos anteriores a esse.

Vamos tirar a porta para usar uma porta padrão do MySql, sem customizar nada. Teremos, então:

appsettings.json

```csharp
  "ConnectionStrings": {
    "UsuarioConnection": "server=localhost;database=usuariodb;user=root;password=root"
  }
```

No vídeo seguinte, vamos gerar essa migração. Até lá!

### Aula 2: Faça como eu fiz: configurando o Identity

Chegou a hora configurar o Identity para que possamos ter acesso ao banco de dados com os benefícios que o Identity pode nos oferecer, como: criação das tabelas para usuário, criptografia de senha, login, etc.

Então, agora é sua vez! Coloque a mão na massa e verifique se ficou com alguma dúvida. Se sim, você pode clicar em “Opinião do instrutor” e conferir o passo a passo de como isso foi feito.

Opinião do instrutor

Inicialmente, instale as bibliotecas conforme o .csproj abaixo:

```csharp
    <PackageReference Include="Microsoft.AspNetCore.Identity.EntityFrameworkCore" Version="6.0.14" />
    <PackageReference Include="Microsoft.EntityFrameworkCore.Tools" Version="6.0.14">
      <PrivateAssets>all</PrivateAssets>
      <IncludeAssets>runtime; build; native; contentfiles; analyzers; buildtransitive</IncludeAssets>
    </PackageReference>
    <PackageReference Include="Microsoft.Extensions.Identity.Stores" Version="6.0.14" />
    <PackageReference Include="Pomelo.EntityFrameworkCore.MySql" Version="6.0.2" />
```

Em seguida, na classe Program, adicione os serviços de DbContext e Identity:

```csharp
var connString = builder.Configuration.GetConnectionString("UsuarioConnection");

builder.Services.AddDbContext<UsuarioDbContext>
    (opts =>
    {
        opts.UseMySql(connString, ServerVersion.AutoDetect(connString));
    });

builder.Services
    .AddIdentity<Usuario, IdentityRole>()
    .AddEntityFrameworkStores<UsuarioDbContext>()
    .AddDefaultTokenProviders();
```

Precisamos também criar a nossa classe UsuarioDbContext na pasta Data, fazendo as devidas extensões e parametrizações:

```csharp
public class UsuarioDbContext : IdentityDbContext<Usuario>
    {
        public UsuarioDbContext(DbContextOptions<UsuarioDbContext> opts) : base(opts) { }
    }
```

O nosso Usuario deve ser um IdentityUser e possuir o campo de DataNascimento. Para isso, emitiremos nossa classe Usuario:

```csharp
public class Usuario : IdentityUser
    {
        public DateTime DataNascimento { get; set; }
        public Usuario(): base() { }
    }
```

Por fim, não esqueça de configurar sua ConnectionString em seu appsettings.json, conforme o seu banco. Por exemplo:

```csharp
"ConnectionStrings": {
    "UsuarioConnection": "server=localhost;database=usuariodb;user=root;password=root"
  }
```

### Aula 2: Configuração do banco - Exercício

Para integrarmos o Identity com o Entity, devemos utilizar novamente um Context para acessar o banco. Diferente da abordagem tradicional, onde estendemos da classe DbContext, precisamos estender de outra classe para o funcionamento do Identity.

Escolha a alternativa abaixo que indica qual é essa classe:

Resposta correta  
IdentityDbContext

> Essa classe é responsável por criar um DbContext específico para o Identity.

### Aula 2: Cadastrando um usuário - Vídeo 2

Transcrição  
Agora vamos criar a nossa migration, atualizar o nosso banco e cadastrar o usuário no sistema. Vamos por partes!

Migration  
A nossa primeira pendência é a geração da migration. Com o nosso código devidamente compilado e "buildável", vamos executar no console o comando:

```cmd
Add-Migration "Criando Usuario"
```

Uma possibilidade é você receber o seguinte erro:

Specified key was too long: max key length is 767 bytes

Isso significa que você está utilizando uma versão antiga do MySQL. Nesse curso, estamos usando o MySQL versão 8. Caso você esteja com a versão 5.6, por exemplo, é provável que você caia nesse problema.

Isso não acontecerá no momento de gerar a migração, mas no momento de executar o comando de update, com a migração já devidamente gerada:

```cmd
Update-Database
```

Correu tudo bem, já que estamos usando a versão mais recente.

Vamos observar a nossa migration "Criando Usuário", criada em "UsuariosApi > Migrations", arquivo 20230222004652_Criando Usuario.cs. Conseguimos verificar o campo de ID, de Name, todos os outros campos criados por padrão, e o de Data de Nascimento. Toda essa migration complexa foi criada por meio do "combo" Identity.Entity. Muito legal!

Lógica de cadastro de usuário  
Agora, através do nosso controlador (em UsuarioController.cs), em que já temos o nosso CreateUusarioDto em CadastraUsuario, precisamos implementar a lógica de cadastro de usuário.

No lugar de throw new NotImplementedException(), teremos um Usuario que será obtido através do nosso mapeamento para um usuário a partir do nosso dto: Usuario usuario = mapper.Map`<Usuario>` (dto). Damos um "Alt + Enter" em Usuario e no Automapper.

Vamos gerar o campo do _mapper, que será um IMapper: private IMapper_mapper. Damos "Alt + Enter" no nome do _mapper. Com isso, é gerado o nosso construtor: public UsuarioController(IMapper mapper). Teremos o seguinte:

UsuarioController.cs

```csharp
public class UsuarioController : ControllerBase
{
        private IMapper _mapper;

        public UsuarioController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult CadastraUsuario
            (CreateUsuarioDto dto)
        {
            Usuario usuario = _mapper.Map<Usuario>
                (dto);
        }
}
```

Agora, a partir desse Usuario, precisamos cadastrá-lo no banco. O Identity provê um método de cadastro de usuários no banco, o CreateAsync. Para chamá-lo, precisamos ter outro campo além do Automapper, que será o _userManager.

Então o adicionamos abaixo de Usuario, chamando o método .CreateAsync(). Passaremos por ele o nosso usuario e a sua senha.

No entanto, não temos essa informação dentro do Usuario.cs, apenas a data de nascimento, e nem no IdentityUser. O que temos em IdentityUser é o PasswordHash. Então, no nosso controlador, passaremos o dto.Password na senha:

UsuarioController.cs

```csharp
// código omitido
            _userManager.CreateAsync(usuario, dto.Password);
        }
}
```

Damos "Alt + Enter" em userManager e geramos o campo. Ele não será um object, mas um UserManager de um Usuario. Esse é o usuário que criamos, que estende de IdentityUser.

O resultado do nosso controlador será:

UsuarioController.cs

```csharp
public class UsuarioController : ControllerBase
{
    private IMapper _mapper;
    private UserManager<Usuario> _ userManager

    public UsuarioController(IMapper mapper)
    {
        _mapper = mapper;
    }

    [HttpPost]
    public IActionResult CadastraUsuario
        (CreateUsuarioDto dto)
    {
        Usuario usuario = _mapper.Map<Usuario>
            (dto);

        _userManager.CreateAsync(usuario, 
            dto.Password);
    }
}
```

Agora, com "Alt + Enter" no _userManager do campo, nós adicionamos o parâmetro ao construtor selecionando a opção "Adicionar parâmetros ao 'UsuarioController(IMapper)'". Estamos criando o usuário agora!

Mas, tem um detalhe: precisamos saber se o resultado dessa operação foi bem-sucedido para informar a pessoa usuária se seu usuário foi cadastrado com sucesso ou não.

Mensagem de sucesso  
Para pegar o resultado dessa operação, adicionamos um var resultado = antes do _userManager.CreateAsync para dizer que queremos salvar esse resultado:

UsuarioController.cs

```csharp
// código omitido
            var resultado = _userManager.CreateAsync(usuario, 
                dto.Password);
        }
}
```

Isso é possível porque o _userManagerCreateAsync retorna uma task de IdentityResult (você pode verificar isso passando o cursor por cima do CreateAsync). Isso significa que, se dermos um "Alt + Enter" no var e selecionarmos "Usar o tipo explícito", teremos o seguinte:

UsuarioController.cs

```csharp
// código omitido
            Task<IdentityResult> resultado 
                = _userManager.CreateAsync(usuario, 
                dto.Password);
        }
}
```

Essa Task representa uma operação assíncrona que pode retornar um valor. Então, nesse contexto, a maneira mais interessante de lidar com as operações assíncronas é indicar que queremos esperar a operação ser executada para saber se ela foi bem-sucedida ou não.

Para isso, inserimos um await antes de _userManager.CreateAsync. A partir desse momento, já não teremos mais uma Task de IdentityResult, e sim um IdentityResult em si, então apagamos Task<>.

Afinal, se estamos esperando essa execução ser finalizada graças ao await, não temos mais o retorno de uma operação assíncrona, mas o seu resultado:

UsuarioController.cs

```csharp
// código omitido
            IdentityResult resultado = await
                _userManager.CreateAsync(usuario, 
                dto.Password);
        }
}
```

Podemos observar que há muitas reclamações. Por isso, precisamos tornar o método CadastraUsuario assíncrono também. Então, inserimos um async antes de IActionResult CadastraUsuario. Além disso, queremos retornar uma Task de IActionResult:

UsuarioController.cs

```csharp
[HttpPost]
public async Task<IActionResult> 
    CadastraUsuario
        (CreateUsuarioDto dto)
    {
        Usuario usuario = _mapper.Map<Usuario>
            (dto);

        IdentityResult resultado = await
            _userManager.CreateAsync(usuario, 
            dto.Password);
    }
```

Como esse contexto agora é assíncrono, estamos voltando ao contexto de representar uma operação que pode ou não retornar um valor. Então, as reclamações param na operação de criação de usuário.

Agora, queremos a mensagem de sucesso da operação de criação desse usuário. Se resultado.Succeeded (foi bem sucedido), retornaremos um Ok de "Usuário cadastrado!". Caso contrário, colocamos um throw new ApplicationException dizendo: "Falha ao cadastrar usuário!":

UsuarioController.cs

```csharp
IdentityResult resultado = await
    _userManager.CreateAsync(usuario, 
    dto.Password);

if (resultado.Succeeded) return Ok("Usuário cadastrado!);

throw new ApplicationException("Falha ao cadastrar usuário!");
```

Nossa lógica está pronta!

Repare que, se tirarmos a Task de IActionResult, ele passa a reclamar CadastarUsuario, porque:

"O tipo de retorno de um método assíncrono precisa ser nulo, Task, ou um tipo semelhante à tarefa."

Ou seja, não podemos simplesmente retornar um IActionResult mais. Inclusive, se dermos um "Alt + Enter" em CadastarUsuario, é pedido para alterarmos a assinatura do método. Por isso, precisamos dizer que é uma Task de IActionResult.

A ideia desse curso não é falar muito sobre assincronismo no .NET, mas estamos falando sobre isso porque precisamos passar por esses cenários.

Resumindo a lógica:

Temos um método que retorna uma operação assíncrona (Task`<IActionResult>` CadastraUsuario);
Essa operação assíncrona é devida à utilização do await, que espera a execução de um método assíncrono - no caso o CreateAsync, um método "aguardável".

Executando a aplicação  
Agora, faremos um último detalhe no Program.cs: após adicionar os nossos Services e utilizar o Identity, vamos adicionar o AutoMapper pois ainda não fizemos sua devida utilização. Então: builder.Services.AddAutoMapper(). Por ele, precisamos passar o AppDomain.CurrentDomain.GetAssemblies:

Program.cs

```csharp
builder.Services.AddAutoMapper
    (AppDomain.CurrentDomain.GetAssemblies());
```

Lembrete: já fizemos isso nos cursos anteriores, estamos apenas utilizando o que já aprendemos nesse momento.

Agora vamos executar a aplicação sem depurar, clicando em "Depurar > Iniciar Sem Deupurar" no menu superior. Veremos o início da execução no console.

Enquanto isso, vamos verificar nosso banco de dados no MySQL. Executando o comando show databases;, receberemos o retorno em que consta o "usuariodb":

show databases;

- Database
- filme
- information_sche...
- mysql
- performance_sche...
- sys
- usuariodb

Agora, vamos rodar o comando use usuariodb;, depois show tables;. Receberemos várias tabelas, como no exemplo:

```sql
use usuariodb;
show tables;
Tables_in_usuariodb
aspnetroles
aspnetuserclaims
aspnetuserlogins
aspnetuserroles
aspnetusers
aspnetusertokens
```

A que queremos é a "aspnetusers". Se rodarmos o comando select * from aspnetusers;, veremos a tabela dos nossos usuários (resumida a seguir):

select * from aspnetusers;

> Id - DataNascimento - UserName - NormalizedUserName - Email - NormalizedEmail - EmailConfirmed - PasswordHash

Ou seja, uma tabela contendo todas as informações de cada um do nosso usuário.

Cadastrando um usuário  
Voltando ao VS, veremos que a aplicação está sendo executada na porta 5212. Com o Postman aberto, vamos abrir uma nova aba e fazer um POST para `"http://localhost:5212/usuario"`, passando a porta e o controlador.

O que precisamos passar no CreateUsuarioDto é um UserName, uma DataNascimento, a senha Password e a confirmação da senha RePassword.

Então, no Postman, clicamos em "Body" no menu central, passando um "raw" do tipo "JSON". No campo de código, passaremos o seguinte como exemplo:

Postman

```json
{
        "Username": "daniel",
        "DataNascimento": "1900-01-01",
        "Password": "Senha123!",
        "RePassword": "Senha123!",
}
```

Em seguida, clicamos em "Send" à direita da barra superior da página. Então, receberemos como retorno:

200 OK Usuário cadastrado!

Vamos conferir no nosso banco de dados no MySQL, rodando o seguinte comando novamente. Receberemos a tabela de usuários novamente, resumida a seguir:

select * from aspnetusers;

Id DataNascimento UserName NormalizedUserName Email NormalizedEmail EmailConfirmed PasswordHash SecurityStamp
959c987d-de0b-47aa-ac63-2a7642c1b969 1900-01-01 daniel DANIEL ... ... ... AQAAAAEAACcQ... X27U...

Repare que não armazenamos senhas puras no banco de dados, isso é uma falha grave de segurança. Então, armazenamos o hash da senha (e não uma criptografia).

Curiosidade: na criptografia, conseguimos "ir e voltar". No hash, temos apenas o "caminho de ida".

Conseguimos cadastrar um usuário!

Podemos tentar cadastrar outra pessoa, mas, com a RePassword errada. Por exemplo:

Postman

```json
{
        "Username": "nico",
        "DataNascimento": "1900-01-01",
        "Password": "Senha123!",
        "RePassword": "Senha1234!",
}
```

Ao clicar em "Send", recebemos como retorno o erro:

400 Bad Request - "'Repassword' and 'Password' do not match."

Há uma peculiaridade do próprio Identity: se definirmos a nossa senha como "senha", tomamos um erro 500:

500 (Internet Server Error) - Falha ao cadastrar usuário!

Esse erro não é explicado de maneira muito visual, mas a questão é a seguinte: o Identity em si tem fatores de segurança que exigem um critério mínimo para aceitação da senha cadastrada.

Se colocarmos "Senha123", continuamos recebendo o erro 500. Mas, se inserimos um caractere especial, como "Senha123@", ele passa a aceitar o cadastro. Caso você esteja recebendo esse erro, significa que sua senha não está segura o suficiente. É claro que conseguimos configurar diversos desses fatores, e deixaremos um conteúdo extra sobre isso nessa aula.

Fizemos o cadastro de um usuário e verificamos que ele está no banco. Adiante, veremos como deixar nosso projeto ainda mais robusto. Nos encontramos no próximo vídeo!

### Aula 2: Para saber mais: configurações padronizadas de segurança

Como dito anteriormente, o Identity provê algumas configurações padronizadas para segurança de senha. Diversas dessas configurações podem ser customizadas conforme a necessidade da aplicação.

Mais informações podem ser obtidas por meio da [documentação oficial](https://learn.microsoft.com/pt-br/aspnet/core/security/authentication/identity-configuration?view=aspnetcore-7.0#password).

### Aula 2: Gerenciando usuários - Exercício

Após instalar e configurar o Identity, é possível cadastrar usuários de maneira prática e rápida utilizando as classes provenientes dos pacotes do Identity.

Marque a alternativa abaixo que contém a classe responsável por possuir o método CreateAsync():

Resposta correta  
UserManager

> A classe UserManager provê diversos métodos voltados para a parte de gerenciamento de usuário, inclusive cadastro.

### Aula 2: Movendo para um serviço - Vídeo 3

Transcrição  
O que vamos fazer agora é melhorar o nosso código. Vamos analisar para entender o porquê.

O controlador presente no arquivo UsuarioController.cs deve ser responsável por receber as requisições das pessoas usuárias. Mas, atualmente recebemos a requisição da pessoa usuária e fazemos toda a nossa lógica de cadastro diretamente no controlador.

Por consequência, a lógica está em um arquivo que não deveria, porque o papel do controlador é lidar com as requisições e não com a execução de lógica da aplicação em si. Além disso, acabamos por criar uma dependência direta do controlador com o IMapper e UserManager.

Com isso, tornamos o código do nosso controlador mais complexo do que deveria e o deixando exposto, porque deveria estar encapsulado em outro local.

Por exemplo, suponha que queremos fazer o cadastro da pessoa usuária com alguma outra alteração ou a partir de outro endpoint com um parâmetro diferente. Não conseguiríamos reutilizar essa lógica, já que ela está diretamente no controlador.

O que podemos fazer nesse caso? Podemos fazer o isolamento dessa lógica em um serviço responsável pelo cadastro de pessoas usuárias.

Em UsuarioController.cs, vamos recortar todo o trecho de código que está dentro de CadastraUsuario:

```csharp
Usuario usuario = _mapper.Map<Usuario>(dto);

IdentityResult resultado = await _userManager.CreateAsync(usuario, dto.Password);

if (!resultado.Succeeded)
{
    throw new ApplicationException("Falha ao cadastrar usuário!")
}
return Ok("Usuário cadastrado!");
```

A ideia que todo o trecho que recortamos seja movido para um _cadastroService.

Por isso, vamos digitar _cadastroService.Cadastra() dentro de CadastraUsuario. Também deveríamos colocar a pessoa usuária que queremos cadastrar, mas vamos deixar pendente por enquanto. Vamos apenas passar dto como parâmetro de Cadastra.

Vamos seguir o fluxo de adiantamento do Visual Studio, apertando "Alt + Enter" em _cadastroService para gerar campo.

No campo gerado na linha 16, vamos substituir object por CadastroService.

UsuarioController.cs:

```csharp
// código omitido…
private IMapper _mapper;
private UserManager<Usario> _userManager;
private CadastroService _cadastroService;
// código omitido…

[HttpPost]
public async Task<IActionResult> CadastraUsuario
    (CreateUsuarioDto dto)
{
    _cadastroService.Cadastra(dto);
}
```

Criando a classe de cadastro  
Agora, vamos criar essa classe de cadastro. No gerenciador de soluções, vamos clicar na pasta "UsuariosApi" para adicionar uma pasta chamada "Services". Dentro dessa pasta, vamos adicionar uma classe chamada CadastroService.

Com isso, podemos importar no controlador UsarioController.cs, o CadastroService da linha 16. E na linha 29, podemos dar "Alt + Enter" no Cadastra para gerar o método.

Ao entrar no arquivo de serviço CadastroService.cs, já foi gerado o método Cadastra dentro da classe CadastroService.

CadastroService.cs:

```csharp
namespace UsuariosApi.Services
{
    public class CadastroService
    {
        internal void Cadastra(CreateUsuarioDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
```

Mas, queremos que o método Cadastra seja public void. Por isso, substituímos internal por public.

Além disso, vamos colocar a lógica de cadastro que tínhamos recortado anteriormente no lugar da exceção que está dentro do método.

```csharp
namespace UsuariosApi.Services
{
    public class CadastroService
    {
        public void Cadastra(CreateUsuarioDto dto)
        {
            Usuario usuario = _mapper.Map<Usuario>(dto);

            IdentityResult resultado = await _userManager.CreateAsync(usuario, dto.Password);

            if (!resultado.Succeeded)
            {
                throw new ApplicationException("Falha ao cadastrar usuário!")
            }
            return Ok("Usuário cadastrado!");
        }
    }
}
```

Agora, precisamos do AutoMapper. Por isso, vamos apertar "Alt + Enter" para gerar campo do _mapper. No campo gerado na linha 9, vamos substituir object por IMapper.

Também vamos usar "Alt + Enter" para gerar a variável _userManager, substituindo object por UserMagener de `<Usuario>`.

Vamos dar um "Alt + Enter" novamente em _userManager. Dessa vez para gerar o construtor CadastroService(UserManager`<Usuario>`). Em seguida, vamos adicionar o IMapper como parâmetro do CadastroService(UserManager`<Usuario>`) ao dar "Alt + Enter" em _mapper.

A princípio nosso código está quase funcional. Basta dar um "Alt + Enter" em await na linha 23 para tornar o método Cadastra assíncrono - assim como fizemos anteriormente com o controlador.

Agora, o método na linha 19 é um public async Task chamado CadastraAsync. Mas, vamos substituir o nome de CadastraAsync para Cadastra para manter o nome que colocamos em outros arquivos.

O último detalhe é que não podemos retornar um Ok("Usuário cadastrado!") dentro do nosso serviço, porque esse Ok está restrito ao escopo de requisição e retorno de resposta a pessoa usuária. Vamos recortá-lo.

```csharp
namespace UsuariosApi.Services
{
    public class CadastroService
    {
        private IMapper _mapper;
        private UserManager<Usuario> _userManager;

        public CadastroService(UserManager<Usuario> userManager, IMapper mapper)
        {
            _userManager = userManager;
            _mapper = mapper;
        }

        public async Task Cadastra(CreateUsuarioDto dto)
        {
            Usuario usuario = _mapper.Map<Usuario>(dto);

            IdentityResult resultado = await _userManager.CreateAsync(usuario, dto.Password);

            if (!resultado.Succeeded)
            {
                throw new ApplicationException("Falha ao cadastrar usuário!")
            }
        }
    }
}
```

Vamos mover a linha de retorno Ok("Usuário cadastrado!") para o controlador, UsuarioController.cs.

Também podemos conferir se o método Cadastra continua com o nome correto e dar um "Alt + Enter" em _cadastroService para adicionar um await. Afinal, o Cadastra é assíncrona e queremos que essa operação seja aguardada até sua conclusão.

UsuarioController.cs:

```csharp
// código omitido…

[HttpPost]
public async Task<IActionResult> CadastraUsuario
    (CreateUsuarioDto dto)
{
    await _cadastroService.Cadastra(dto);
    return Ok("Usuário cadastrado!");
}
```

Com isso, uma vez executado a requisição no UsuarioController.cs, vai ser cadastrado no CadastroService.cs. Se não foi bem-sucedido, vai ser lançada uma exceção e nem vamos chegar ao return de pessoa usuária cadastrada. O retorno só acontece quando toda a lógica for bem executada e não lançar a exceção.

Limpando o controlador  
Agora falta limpar o arquivo do controlador, retirando as linhas do IMapper e UserManager. Também vamos apagar o controlador UsuarioController que tinha como parâmetro IMapper e UserManager.

Vamos deixar somente o CadastroService, além de gerar um novo construtor UsuarioController(CadastroService) ao apertar "Alt + Enter" em _cadastroService.

Verifique como ficou o arquivo completo do controlador:

UsuarioController.cs:

```csharp
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UsuariosApi.Data.Dtos;
using UsuariosApi.Services;

namespace UsuariosApi.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class UsuarioController : ControllerBase
    {
        private CadastroService _cadastroService;

        public UsuarioController(CadastroService cadastroService)
        {
            _cadastroService = cadastroService;
        }
        [HttpPost]
        public async Task<IActionResult> CadastraUsuario
            (CreateUsuarioDto dto)
        {
            await _cadastroService.Cadastra(dto);
            return Ok("Usuário cadastrado!");
        }
    }
}
```

Injeção de CadastroService  
Como estamos fazendo essa injeção de uma classe que nós criamos, precisamos explicitar ao .NET que queremos que a classe efetiva CadastroService seja utilizada ao fazer a injeção de dependência de _cadastroService.

Mas, porque não precisamos fazer isso com o IMapper e UserManager? Porque isso já é resolvido automaticamente na implementação interna.

Para fazer isso com o CadastroService precisamos fazer essa injeção no arquivo Program.cs.

Após o builder de AddAutoMapper, vamos adicionar um builder.Services. Em seguida, precisamos definir como o serviço vai ser injetado.

Existem três maneiras de resolver dependências:

- AddScoped;
- AddTransient;
- AddSingleton.

Nesse momento, vamos usar o AddScoped assim o CadastroService sempre vai ser instanciado quando houver uma requisição nova que demande uma instância de CadastroService. Com isso, se fazemos uma requisição nova e chamamos o CadastroService, vamos instanciar um novo.

Se utilizássemos o AddSingleton seria um único CadastroService para todas as requisições que chegassem, ou seja, seria a mesma instância.

Já o AddTransient vai fazer sempre uma instância nova, mesmo que seja na mesma requisição. Assim, se chega uma requisição e precisamos de uma instância de CadastroService, vamos instanciar uma nova. Mas, se chega uma requisição e precisamos do CadastroService, também vai instanciar uma nova.

Vamos usar o AddScoped já que não precisamos nos preocupar com essa questão de instanciar um novo ou manter um antigo, ou seja, o estado.

Program.cs:

```csharp
using UsuariosApi.Services;
// código omitido…
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddScoped<CadastroService>();
// código omitido…
```

Ao executar a nossa aplicação, clicando no botão de "Iniciar Sem Depurar" na barra de ferramentas (ou "Ctrl + F5").

Vamos abrir o Postman para fazer o cadastro de uma pessoa usuária com o método POST.

> POST `http://localhost:5212/Usuario`

Na aba "Body", vamos cadastrar outra pessoa usuária qualquer. Escrevemos "Fulano" como username, mantendo a mesma data de nascimento e senha que já estavam inseridas.

```csharp
{
    "Username": "Fulano",
    "DataNascimento": "2018-01-01",
    "Password": "Senha123@",
    "RePassoword": "Senha123@"
}
```

Ao enviar a requisição, temos o status "200 OK" e sabemos que a pessoa foi devidamente cadastrada.

Usuário cadastrado!

Próximos passos  
Conseguimos limpar o nosso projeto e o deixamos mais enxuto. Com isso, também seguimos melhor a boa prática de não deixar a nossa lógica de negócio no nosso controlador, mas, sim, em um serviço designado para tal.

Adiante, vamos aprender como autenticar a pessoa usuária.

### Aula 2: Controladores lotados - Exercício

Anteriormente vimos os problemas que podemos enfrentar caso toda a nossa lógica esteja inserida diretamente em nosso controlador.

Selecione a alternativa que apresenta um desses problemas:

Resposta correta  
Quando o código da nossa lógica atual aumentar, ela acabará sendo misturada com uma nova lógica de finalidade diferente.

> Quando aumentarmos o código, as responsabilidades vão se misturar. Uma alternativa para contornar tal problema é criar classes contendo cada lógica específica.

### Aula 2: O que aprendemos?

Nessa aula, aprendemos:

- A integrar o Identity com o Entity por meio das classes e métodos oferecidos pela biblioteca;
- Como utilizar a classe UserManager e o método CreateAsync() para cadastrarmos usuários no sistema;
- Que o controlador deve ter o mínimo de responsabilidade possível no âmbito de implementação de lógica;
- É uma boa prática não expor o modelo de nossas entidades diretamente no controlador;
- Criar services é uma boa alternativa a fim de isolar a lógica que implementamos.

## Aula 3: Logando um usuário

Caso queira, você pode [baixar o projeto do curso](https://github.com/alura-cursos/alura-identity/tree/Aula-2) no ponto em que paramos na aula anterior.

### Aula 3: Efetuando o login - Vídeo 1

Transcrição
Anteriormente, fizemos o cadastro da pessoa usuária dentro do nosso sistema e agora vamos fazer o login. Já temos no banco de dados um usuário (username e um hash para a senha). Mas como vamos fazer a autenticação dessa pessoa na nossa aplicação?

Arquivo UsuarioController.cs

O primeiro passo é criarmos um novo meio para fazermos isso, já temos o nosso UsuarioController e podemos levantar algumas possibilidades.

UsuarioController

// código omitido

   public class UsuarioController : ControllerBase
    {
        private CadastroService _cadastroService;

        public UsuarioController(CadastroService cadastroService)
        {
            _cadastroService = cadastroService;
        }

        [HttpPost]
        public async Task<IActionResult> CadastraUsuario
            (CreateUsuarioDto dto)
        {
            await _cadastroService.CadastraUsuario(dto);
            return Ok("Usuário cadastrado!");
        }

// código omitidoCopiar código
Dentro do nosso UsuarioController temos o CadastraUsuario e podemos adicionar um relacionado ao login ou podemos criar um controlador do zero. No nosso caso, vamos aproveitar a rota dentro desse controlador existente para incluirmos a nossa rota de login.

No final do arquivo, adicionamos uma nova rota. Para isso escrevemos [Http] sem colocar o tipo ainda e na linha seguinte colocamos public IActionResult que será o nosso Login(){}. Nas chaves, fazemos o nosso comando efetivamente, vamos chamar os serviços para realizar o login: _loginService.Login().

UsuarioController

// código omitido

                [Http]
                public IActionResult Login() 
                {
                        _loginService.Login();
                }

// código omitidoCopiar código
Vamos analisar quais as outras possibilidades que podemos ter nesse cenário. No cadastroService podemos, por exemplo, alterar esse serviço para ele englobar esses tipos de operações que estamos realizando.

Pode ser que o nosso CadastroService faça mais sentido ser renomeado para UsuarioService. Para tal, clicamos com o botão direito em CadastroService e escolhemos a opção "Rename"; e depois em _cadastroService trocamos para _usuarioService. Esse serviço vai fazer toda a parte de autenticação de cadastro dos nossos usuários.

Isso para mantermos a coerência, dado que agora dentro desse serviço, além de cadastro também vamos ter o login.

UsuarioController

// código omitido

    public class UsuarioController : ControllerBase
    {
        private UsuarioService _usuarioService;

        public UsuarioController(UsuarioService cadastroService)
        {
            _usuarioService = cadastroService;
        }

// código omitidoCopiar código
Voltando ao login, ao invés de _loginService colocamos _usuarioService e dentro dele criamos o método. Em Login() recebemos LoginUsuarioDto dto.

UsuarioController

// código omitido

                [Http]
                public IActionResult Login(LoginUsuarioDto dto) 
                {
                        _usuarioService.Login();
                }

// código omitidoCopiar código
Agora precisamos criar esse dto. Para isso, vamos criar uma classe chamada de LoginUsuarioDto.cs dentro pasta de Dtos. Assim, somos redirecionados para o arquivo que acabamos de criar:

LoginUsuarioDto.cs

namespace UsuariosApi.Data.Dtos
{
    public class LoginUsuarioDto
    {

    }
}Copiar código
Para fazermos a autenticação no nosso sistema, vamos precisar obrigatoriamente de um username e a senha (em inglês, password). Teclamos "Alt + Enter" logo acima de Required para importarmos.

LoginUsuarioDto.cs

using System.ComponentModel.DataAnnotations;

namespace UsuariosApi.Data.Dtos
{
    public class LoginUsuarioDto
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}Copiar código
Voltando ao arquivo UsuarioController, estamos recebendo um dto e o passamos dentro dos parênteses do nosso serviço no método Login().

UsuarioController

// código omitido

                [Http]
                public IActionResult Login(LoginUsuarioDto dto) 
                {
                        _usuarioService.Login(dto);
                }

// código omitidoCopiar código
Logo após, teclamos "Alt + Enter" em Login() e escolhemos a opção "Gerar método de 'Login'". Assim, será criado um método. Para ajustarmos podemos clicar em cima de Login() que vamos ser redirecionados para o arquivo com o método. Ao invés de interno (internal), desejamos que seja público (public).

UsuarioService.cs

// código omitido

        public void Login(LoginUsuarioDto dto)
        {

                        throw new NotImplementedException();

                }Copiar código
Agora, precisamos implementar. Como vai funcionar o login? Assim como temos o nosso _userManager, temos outro chamado de SignInManager. Podemos remover o conteúdo de dentro das chaves do trecho de código exibido anteriormente, e escrevemos _signInManager para fazer o login.

Teclando "Alt + Enter" com o cursor sobre o _signInManager, vamos escolher a opção "Gerar campo 'signInManager'". Isso para que possamos criar esses campos de forma mais rápida.

Subindo o arquivo, dentro de UsuarioService ao invés de object ele será do tipo SignInManager<Usuario>, esse <Usuario> serve para representar que é respectivo a um usuário. Logo após, teclamos "Alt + Enter" em _signInManager e escolhemos a opção "Adicionar parâmetros ao 'UsuarioService(IMapper, UserManager<Usuario>)'". Isso para adicionarmos o parâmetro ao construtor.

UsuarioService.cs

// código omitido

    public class UsuarioService
    {
        private IMapper _mapper;
        private UserManager<Usuario> _userManager;
        private SignInManager<Usuario> _signInManager;

// código omitidoCopiar código
Agora vamos usar o SignInManager no método de Login(). Há um método específico que vamos usar, o PasswordSignInAsync(), que a partir do usuário e senha ele tenta realizar a autenticação.

O primeiro parâmetro que passamos é o dto.username e o segundo parâmetro vai ser o dto.Password. Há um terceiro e quarto parâmetro que são do tipo boolean, sendo o terceiro um verdadeiro ou falso para isPersistente e o quarto para lockoutOnFailure.

Isso significa que se teclarmos "Ctrl + clique" em PasswordSignInAsync conseguimos visualizar uma descrição mais detalhada desse método. Informa que o isPersistente é uma flag que indica se desejamos persistir esse cookie de autenticação de login após o fechamento do navegador.

E o lockoutOnFailure indica se a conta deve ser bloqueada se o sign in falhar. Não estamos nos preocupando com nada disso, por enquanto. Portanto, colocamos como terceiro e quarto parâmetro false.

UsuarioService.cs

// código omitido

        public void Login(LoginUsuarioDto dto)
        {

                        _signInManager.PasswordSignInAsync(dto.Username, dto.Password, false, false);

                }Copiar código
Entrando novamente no PasswordSignInAsync, ele nos retorna uma Task<SignInResult>. Se é uma task e desejamos pegar o resultado sabemos que devemos esperar (await) por esse resultado, por isso, colocamos await e depois tornamos o método login assíncrono (async).

Para tal, teclamos "Ctrl + clique" e escolhemos a opção "Tornar método assíncrono". Logo após, antes do await colocamos var resultado =.

UsuarioService.cs

// código omitido

        public async Task LoginAsync(LoginUsuarioDto dto)
        {

                        var resultado = await _signInManager.PasswordSignInAsync(dto.Username, dto.Password, false, false);

                }Copiar código
Agora, desejamos validar se a nossa operação foi executada com sucesso (fizemos isso anteriormente). Caso o resultado não seja bem sucedido, desejamos lançar uma new ApplicationException() com a mensagem "Usuário não autenticado!".

UsuarioService.cs

// código omitido

        public async Task LoginAsync(LoginUsuarioDto dto)
        {
            var resultado = await _signInManager.PasswordSignInAsync(dto.Username, dto.Password, false, false);

            if (!resultado.Succeeded)
            {
                throw new ApplicationException("Usuário não autenticado!");
            }

                }Copiar código
Então recebemos o nosso dto e o transmitimos para o nosso serviço de login. E fazemos essa operação a partir do signInManager que vem do próprio Identity e, por fim, validamos se a operação foi feita com sucesso. Podemos salvar.

No arquivo UsuarioController, podemos remover o Async de LoginAsync (que o VS Code colocou de forma automática) para mantermos o padrão. Depois podemos remover o Async do LoginAsync() do método de serviço no arquivo UsuarioService.

Vamos informar que é um método assíncrono usando async e pelo fato de ser assíncrono, usamos o await e retornamos um Ok() passando a mensagem "Usuário autenticado". O verbo que vamos usar por ser um login, será o post. Portanto, colocamos HttpPost.

Usamos o post por fazer mais sentido passarmos os parâmetros de autenticação através do corpo da requisição e não do URL (caso usássemos o get). Isso não significa que está mais seguro ou criptografado.

UsuarioController

// código omitido

                [HttpPost]
                public async Task<IActionResult> LoginAsync(LoginUsuarioDto dto) 
                {
                        await _usuarioService.Login(dto);
                        return Ok("Usuário autenticado!");
                }

// código omitidoCopiar código
Observe que temos dois HttpPost dentro do arquivo UsuarioController. Podemos diferenciá-los especificando para onde estão indo, por exemplo: [HttpPost("cadastro")]. E aplicamos a mesma lógica para o de login: [HttpPost("login")]. Logo após, salvamos a aplicação e no menu superior, clicamos em "Depurar" e depois em "Iniciar Sem Depurar".

No Postman, estamos com o verbo post e o endereço http://localhost:5212/usuario, onde vamos acrescentar /cadastro no final: http://localhost:5212/usuario/cadastro. Como desejamos cadastro um usuário, no body preenchemos:

{
        "Username": "romulo",
        "DataNascimento": "1900-01-01",
        "Password": "Senha123@",
        "RePassword": "Senha123@"
}Copiar código
Em seguida clicamos no botão "Send".

Observe que retornou o Status 200 OK, e a mensagem "Usuário cadastrado!".

Para testar o login, vamos abrir mais uma aba no Postman com o verbo post e o endereço http://localhost:5212/usuario/login. No body passamos um raw e em text selecionamos JSON e preenchemos:

{
        "Username": "david",
        "Password": "Senha123@",
}Copiar código
Em seguida clicamos no botão "Send". Retornou o Status 200 OK, e à mensagem "Usuário autenticado!". Se colocarmos uma senha inválida, como:

{
        "Username": "david",
        "Password": "Senha123123",
}Copiar código
E selecionamos "Send", temos a mensagem informando que o usuário não foi autenticado, com o Status 500 Internal Server Error. Com o login funcionando, como fazemos algo a partir dele? O que prova que o usuário foi autenticado no nosso sistema? Como realizamos operações a partir disso?

Vamos entender melhor como fazer tudo isso nos próximos vídeos. Até mais!

### Aula 3:  - Vídeo 1
### Aula 3:  - Vídeo 2
### Aula 3:  - Vídeo 3
### Aula 3:  - Vídeo 4
### Aula 3:  - Vídeo 5
### Aula 3:  - Vídeo 6
### Aula 3:  - Vídeo 7
### Aula 3:  - Vídeo 8
