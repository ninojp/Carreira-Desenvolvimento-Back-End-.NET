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

### Aula 1:  - Vídeo 8
