# Curso Alura: ASP.NET autenticação e autorização em APIs e aplicações web

## Aula 1: Autentificação e autorização na API

### Aula 1: Apresentação - Vídeo 1

Transcrição  
Olá, pessoa desenvolvedora apaixonada pelo .NET! Eu sou o Daniel Portugal, programador e instrutor de .NET na Alura, e irei te acompanhar nessa jornada!

Audiodescrição: Daniel se descreve como um homem branco, de cabelo preto liso e curto, olhos castanhos, e barba por fazer. Ele usa óculos de armação retangular preta e veste uma camisa preta com guitarras estampadas. Ele está sentado em frente a um notebook e um microfone sobre uma mesa preta, e ao fundo, há uma estante preta com enfeites em uma parede clara iluminada em gradiente azul e roxo.

O que vamos aprender?  
Vamos mostrar rapidamente para você um problema na nossa aplicação e discutir sobre a questão que queremos abordar. Imagine que estamos no projeto ScreenSound, com artistas cadastrados, e em nenhum momento nos identificamos, como você já deve ter percebido.

Podemos selecionar um artista fictício clicando no botão "DETALHES" e excluí-lo. Ou seja, conseguimos excluir um item da nossa base de dados de forma anônima.

Isso é um problema que precisamos resolver tanto na nossa API, que já temos, quanto na nossa aplicação web. Portanto, o tema deste curso é autorização e autenticação usando o ASP.NET em APIs REST e aplicações web.

Para quem é este curso?  
Este curso é voltado para quem conhece C# e orientação a objetos, consegue persistir informações usando bancos de dados relacionais com o Entity Framework, consegue expor essas informações usando minimal APIs, e por fim, consegue mostrar essas informações no navegador usando uma aplicação web.

Qualquer dúvida que você tiver, qualquer esclarecimento que precisar, entre em contato conosco no Discord. Nós temos um servidor da Alura, e teremos muito prazer em dialogar com você e responder as suas dúvidas e questões.

Vamos para o primeiro vídeo deste curso?

### Aula 1: Projeto inicial

Este curso vai começar com um projeto já existente. Nele temos uma versão modificada da aplicação utilizada no curso anterior desta formação. [Baixe o zip do projeto](https://github.com/alura-cursos/ScreenSound-Curso4) que usaremos no curso, descompacte-o em alguma pasta local e abra a solução no Visual Studio.

Modificações no projeto  
Atenção! Este projeto é diferente do projeto que foi concluído no curso anterior desta formação. No entanto, você pode continuar usando a versão prévia do projeto, desde que realize as mudanças que descreveremos a seguir.

Definições de CORS na API  
No arquivo Program.cs do projeto com a API, aumentamos a restrição de acesso entre a aplicação Web e a API através da configuração CORS, nomeada abaixo como wasm. O projeto anterior permitia qualquer acesso, enquanto o código abaixo somente permite origens apontadas pelas URLs dos dois projetos.

```csharp
builder.Services.AddCors(
    options => options.AddPolicy(
        "wasm",
        policy => policy.WithOrigins([builder.Configuration["BackendUrl"] ?? "https://localhost:7089",
            builder.Configuration["FrontendUrl"] ?? "https://localhost:7015"])
            .AllowAnyMethod()
            .SetIsOriginAllowed(pol => true)
            .AllowAnyHeader()
            .AllowCredentials()));

var app = builder.Build();

app.UseCors("wasm");
```

Injeção dos serviços na app Web  
No arquivo Program.cs do projeto com a aplicação Web, alteramos o tipo de injeção de transient para scoped. O motivo é conseguir reaproveitar os objetos do mesmo tipo em diferentes páginas e componentes, dentro da mesma requisição. Esse tipo de ciclo de vida dos objetos injetados (a saber, scoped) será fundamental quando começarmos a lidar com estados de autenticação na Aula 3.

Classe de contexto ScreenSoundContext  
No método OnModelCreating(), localizado na classe ´ScreenSoundContextdo projetoScreenSound.Shared.Dados, incluímos a linha de código base.OnModelCreating(modelBuilder);`. O objetivo é permitir que códigos escritos em classes ancestrais continuem sendo executados. Como veremos em breve, essa mudança será importante para usarmos uma biblioteca da Microsoft.

### Aula 1: ASP.NET Core Identity - Vídeo 2

Transcrição  
Para dar início aos nossos estudos, vamos executar a API. Você já deve ter seu projeto na máquina; disponibilizamos uma atividade para você baixar o projeto inicial deste curso. Há algumas modificações, as quais estão explicadas na atividade. Agora, vamos executar a API do ScreenSound.

ASP.NET Core Identity  
Na barra de ferramentas superior do Visual Studio, vamos clicar no ícone de triângulo vazado para executar a API. Será exibida uma página com a documentação da API e seus endpoints.

Se testarmos o "GET /Artistas", clicando no botão "Try it out" e depois em "Execute", ele vai ao banco e traz os artistas cadastrados na nossa base local. Na sua, deve ser diferente, mas deve exibir os artistas e uma resposta 200. Vamos copiar um dos IDs.

Feito isso, vamos fechar esse endpoint clicando novamente na aba "GET /Artistas". Em seguida, vamos acessar outro endpoint chamado "DELETE /Artistas/{id}". Queremos excluir um artista, por exemplo, Foo Fighters. Clicaremos em "Try it out" novamente e colocaremos o ID 9 de Foo Fighters.

Após executar, temos a resposta 204 (No Content), status code para nenhum conteúdo encontrado, o que significa que a exclusão foi feita corretamente.

Se voltarmos ao endpoint "GET /Artistas" e executarmos novamente, notaremos que o artista Foo Fighters foi excluído da nossa base. Percebe o problema?

Acreditamos que você deve ter percebido isso há muito tempo. Em nenhum momento dissemos quem somos, fizemos algum tipo de login, nos conectamos com alguma conta, então de forma anônima, excluímos um registro do banco de dados. Uma informação do banco de dados foi excluída sem ninguém se identificar. Isso é um problema e vamos começar a trabalhar na proteção dos endpoints a partir de agora.

Para conseguirmos nos conectar e colocar nossas informações de identidade, precisamos gerenciar tudo isso. Precisamos saber quem é a pessoa, qual é o e-mail dela, se vai ter senha, ou seja, há uma série de funcionalidades que estão associadas a essa gestão de identidade.

Trata-se de um problema comum a qualquer aplicação. Você já usou suas aplicações de e-mail, de streaming, de música e precisou colocar sua conta. A depender do tipo de conta criada, você tem acesso a algumas coisas e a outras, não.

Como é um problema comum, existem soluções comuns também. Iremos usar uma solução bastante comum da Microsoft, uma biblioteca chamada ASP.NET Core Identity.

Vamos começar instalando essa biblioteca.

Instalando a biblioteca  
De volta ao Visual Studio, temos os cinco projetos da nossa aplicação, os quais evoluímos ao longo do tempo. No projeto ScreenSound.Shared.Dados, vamos instalar a biblioteca ASP.NET Core Identity e explicar por que colocamos nesse projeto específico.

Clicando com o botão direito do mouse sobre o projeto, selecionaremos a opção "Editar Arquivo do Projeto". Será aberto o arquivo com a extensão .csproj, que contém uma série de informações relacionadas ao projeto. Uma das informações são os pacotes instalados nesse projeto especificamente.

A biblioteca ASP.NET Core Identity faz a gestão de identidades, tem todas as funcionalidades, mas essa gestão de identidades precisa também persistir as informações. Nesse caso, vamos usar como persistência algo que já conhecemos: o Entity Framework Core. Sendo assim, vamos usar uma biblioteca que já faz a gestão de identidade e persiste usando o Entity.

Para visualizarmos um pouco melhor, vamos fechar o gerenciador de soluções à esquerda, e na linha 15 do arquivo ScreenSound.Shared.Dados.csproj, vamos colar o código do pacote que queremos instalar.

ScreenSound.Shared.Dados.csproj:

```csharp
<PackageReference Include="Microsoft.AspnetCore.Identity.EntityFrameworkCore" Version="7.0.13" />
```

Usaremos a biblioteca Microsoft.AspnetCore.Identity conforme já falamos, porém, a persistência dessa gestão de identidade será feita usando o EntityFrameworkCore.

Essa é uma maneira de instalar pacote, mas também já conhecemos outras usando a visão do Visual Studio. Entretanto, essa é uma forma mais rápida de fazer isso, apenas colamos a informação e vamos salvar o projeto com "Ctrl + S". Automaticamente, será restaurado e instalado o pacote para nós.

Implementando o ASP.NET Core Identity  
Vamos fechar o arquivo de projeto para continuarmos a implementação do Identity. Como falamos anteriormente, precisamos persistir as informações de identidade usando o Entity Framework.

Para fazer acesso via Entity Framework, há uma classe que herda de DbContext, na classe ScreenSoundContext. O que precisamos agora é dizer o seguinte: temos artistas como modelo, músicas, gênero, então todas as entidades que são persistidas precisam estar no nosso contexto.

Também teremos novas entidades relacionadas a esse módulo, principalmente pessoa que terá acesso e perfil dessa pessoa que terá acesso. Vamos modelar essas duas entidades para podermos verificar que existem novas entidades que agora serão gerenciadas por essa biblioteca.

Criando as classes PessoaComAcesso e PerfilDeAcesso  
Vamos voltar ao gerenciador de soluções e criar uma pasta chamada "Modelos" no projeto ScreenSound.Shared.Dados. Dentro dessa nova pasta, vamos criar duas classes: a primeira será a classe PessoaComAcesso; e a segunda será a PerfilDeAcesso. Essas duas classes representam novas entidades no nosso sistema que agora serão persistidas.

Vamos fazer algumas mudanças em ambas as classes, porque a biblioteca Identity tem informações que vão nos ajudar. Pense conosco: o que uma pessoa que tem acesso precisa para fazer uma conexão e se logar no sistema? Ela precisa colocar um nome de usuário, uma senha, pode precisar desbloquear essa pessoa.

Há uma série de propriedades dessa classe que precisaríamos modelar. Porém, não vamos fazer isso; usaremos justamente a biblioteca para facilitar nosso processo.

Vamos acessar a classe PessoaComAcesso e torná-la pública (public), para aumentar sua visibilidade para outros projetos. Feito isso, vamos dizer que ela herda de uma classe chamada IdentityUser, a qual está definida na biblioteca que instalamos.

Em seguida, vamos dizer que essa classe IdentityUser é de um tipo inteiro (int). Esse tipo int representa o tipo da chave primária. Artista, Musica e Genero já têm o tipo inteiro como chave primária, e nós vamos manter esse padrão.

PessoaComAcesso.cs

```csharp
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Shared.Dados.Modelos;
public class PessoaComAcesso : IdentityUser<int>
{
}
```

Faremos apenas isso, porque a classe IdentityUser já tem usuário, já tem e-mail, já tem senha e uma série de outras funções. Após as alterações, vamos salvar essa classe.

Agora vamos acessar a classe PerfilDeAcesso e fazer a mesma coisa: vamos aumentar a visibilidade substituindo o internal por public. Nesse caso, vamos fazer com que a classe herde de IdentityRole, e novamente vamos dizer que o tipo da chave primária é um inteiro (int).

PerfilDeAcesso.cs:

```csharp
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Shared.Dados.Modelos;
public class PerfilDeAcesso : IdentityRole<int>
{
}
```

Agora vamos voltar para o arquivo ScreenSoundContext.cs, onde temos a classe ScreenSoundContext, e vamos dizer que ela não herda mais de DbContext, mas sim de IdentityDbContext, que também é uma classe definida no ASP.NET Core Identity.

Em seguida, passaremos para IdentityDbContext<> as classes que modelam pessoas e perfis, isto é, a classe PessoaComAcesso e a PerfilDeAcesso. A chave primária é modelada com o tipo int.

ScreenSoundContext.cs:

```csharp
public class ScreenSoundContext: IdentityDbContext<PessoaComAcesso, PerfilDeAcesso, int>
```

Atualizando o banco de dados  
Esse foi o segundo passo que realizamos: após instalar o pacote, modelamos as pessoas e os perfis que têm acesso. Agora falta atualizar o banco de dados. No momento, nosso banco de dados só tem tabela para artistas, gêneros e músicas. Ainda precisamos de tabelas para gerenciar pessoas, perfis de acesso e outras coisas mais que você descobrirá se tiver curiosidade.

O que precisamos fazer para atualizar o banco de dados? Migrations, então no menu "Ferramentas", vamos até "Gerenciador de Pacotes do NuGet > Console do Gerenciador de Pacotes".

Será aberto um console na parte inferior, onde vamos digitar um comando para adicionar uma nova versão que vai atualizar o banco de dados. O comando utilizado será o seguinte:

```csharp
Add-Migration IdentityTabelas
```

Antes de executar o comando, precisamos fazer algumas mudanças. Na barra de ferramentas superior do Visual Studio, precisamos informar qual é o projeto de inicialização, que será o ScreenSound.API.

Em seguida, na barra de ferramentas superior do console, há uma seção "Projeto padrão", onde precisamos colocar o projeto onde a migração será armazenada, ou seja, ScreenSound.Shared.Dados.

Feito isso, podemos apertar "Enter" para compilar o projeto. Se tudo der certo, ele vai adicionar uma migração chamada IdentityTabelas.

Conforme esperado, foi adicionada uma migração IdentityTabelas, com um método chamado Up() que faz o update do nosso banco de dados, e cria algumas tabelas com CreateTable(). Temos tabela para perfil (AspNetRoles), tabela para pessoa usuária (AspNetUsers), entre outras.

> 20231212130845_IdentityTabelas.cs

Isso faz parte do módulo de gestão de identidade entregue pelo Identity.

Criando as tabelas no banco de dados  
Último passo: vamos voltar para o console do gerenciador de pacotes e executar o comando Update-Database, para criar as tabelas no banco de dados que antes tinha apenas artista, gênero e música. Agora ele terá todas as tabelas que estão na migração IdentityTabelas.

```csharp
Update-Database
```

Conclusão  
Vamos disponibilizar para você a documentação sobre tópicos de segurança relacionados ao ASP.NET Core, relacionados ao framework web da Microsoft. Um dos tópicos presentes na documentação é esse que abordamos no curso, Authentication vs. Authorization (autenticação e autorização).

Você pode escolher a solução desejada. Nesse subconjunto, usamos a solução Identity. Dentro de "Authentication", uma das soluções é usar essa biblioteca, e foi justamente isso que começamos a fazer.

Na sequência, vamos realmente proteger a API do ScreenSound!

### Aula 1:  - Vídeo 3
### Aula 1:  - Vídeo 4
### Aula 1:  - Vídeo 5
### Aula 1:  - Vídeo 6
### Aula 1:  - Vídeo 7
### Aula 1:  - Vídeo 8
