# Curso Alura C#: dominando Orientação a Objetos

## Aula 1 - Organizando o projeto

### Aula 1 - Apresentação  - Vídeo 1

Transcrição  
Daniel: Boas-vindas a mais um curso na Alura sobre orientação a objetos com C#.

Eu sou Daniel Portugal, analista de sistemas e instrutor na Alura.

Daniel Portugal é um homem branco com cabelo e barba curtos e pretos. Tem olhos castanhos, usa óculos quadrados de armação preta e está de casaco preto.

Ao meu lado, o instrutor que vai nos ajudar nesse curso.

Guilherme: Olá, meu nome é Guilherme Lima. Também sou um dos instrutores desse treinamento.

Guilherme é um homem branco, de cabelo curto e barba castanhos, e olhos também castanhos. Usa óculos quadrados de armação preta e está com uma camisa cinza estampada.

**Em que vamos nos aprofundar?**  
Daniel: Aprendemos o básico de orientação a objetos no curso anterior da formação C#.

Agora, vamos preencher as lacunas, falando sobre herança, interface e polimorfismo. Vamos aplicar esses conceitos em um projeto bastante prático.

Guilherme: Além disso, vamos aplicar inteligência artificial em um projeto C#, seguindo boas práticas de programação e deixando nosso código próximo do que acontece nos projetos reais dessa linguagem.

Se você quer aprofundar ainda mais seus conhecimentos em orientação a objetos com C#, esse curso é para você!

### Aula 1 - Preparando o ambiente: projeto do curso

Este curso vai começar com um projeto já existente. Nele temos uma versão modificada da aplicação utilizada no primeiro curso da formação, [C#: criando sua primeira aplicação](https://cursos.alura.com.br/course/csharp-criando-primeira-aplicacao), junto com as classes mencionadas no segundo curso, [C#: aplicando a Orientação a Objetos](https://cursos.alura.com.br/course/csharp-aplicando-orientacao-objetos). Basta [baixar o zip do projeto inicial](https://github.com/alura-cursos/ScreenSound03/archive/refs/heads/projeto-inicial.zip), descompactá-lo em alguma pasta local e abrir a solução no Visual Studio.

Pronto para conhecer o projeto?

### Aula 1 - Abrindo o projeto - Vídeo 2

Transcrição  
Guilherme: Vamos iniciar nossos estudos? Para começar, vamos utilizar como base o projeto Screen Sound do primeiro curso onde criamos nossa primeira aplicação, aplicando conhecimentos do projeto do segundo curso onde aplicamos orientação a objetos.

Porém, teremos desafios, pois tivemos alguns incrementos no projeto.

Uma reflexão é que todo código que você criar na sua carreira como desenvolvedor(a) vai sofrer alteração, edição e manutenção. Alguns códigos criados por outras pessoas vão funcionar, outras vão causar erros. Isso é comum. Vamos perceber isso de forma prática.

Já fizemos download do projeto base que vamos usar durante o curso, disponibilizado na atividade "Preparando o ambiente".

**Mudanças no projeto Screen Sound**  
Daniel: Após baixar e descompactar o arquivo, vamos à pasta raiz e abrimos o arquivo ScreenSound.sln com duplo clique. Com isso, abre-se o Microsoft Visual Studio com o projeto aberto.

Vamos clicar na aba "Gerenciador de soluções" na lateral direita para visualizar os arquivos que compõem o projeto. Basicamente, temos uma mistura do primeiro e segundo curso.

No primeiro curso, temos a aplicação ScreenSound que fazia registro e avaliava bandas. No segundo curso, aplicamos orientação a objetos e temos algumas classes para representar o modelo de sistemas, como:

- Banda.cs
- Album.cs
- Musica.cs

Guilherme: Primeiro, vamos conferir o Program.cs que contém o programa inicial. Visualmente, parece muito com o código anterior. Mas, no método ExibirOpcoesDoMenu(), temos uma opção a mais para exibir detalhes de uma banda.

Program.cs:

```csharp
// código omitido…
void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para registrar o álbum de uma banda");
    Console.WriteLine("Digite 3 para mostrar todas as bandas");
    Console.WriteLine("Digite 4 para avaliar uma banda");
    Console.WriteLine("Digite 5 para exibir os detalhes de uma banda");
    Console.WriteLine("Digite -1 para sair");

// código omitido…

}
```

Depois temos o switch(opcaoEscolhidaNumerica) para cada uma das 5 opções. Em seguida, temos as funções principais de RegistrarBanda() e MostrarBandasRegistradas().

Daniel: Nesse caso, temos duas mudanças no projeto inicial do curso.

Primeiro, ao invés de exibir só a média de uma banda, também exibimos os detalhes da banda. Segundo, também é novo o registro do álbum de uma banda. Assim, podemos registrar a banda e seus álbuns.

Guilherme: Interessante. Na segunda linha do código, estamos usando uma lista de banda registradas. É um dicionário que tem uma chave que é o nome da banda e a lista de inteiros que são as notas que aquela banda recebe.

```csharp
Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Linkin Park", new List<int> { 10, 8, 6 });
bandasRegistradas.Add("The Beatles", new List<int>());
// código omitido…
```

Você mostrou na aba "Gerenciador de Soluções" que existem algumas classes, mas ainda não a estamos usando. Em suma, temos o código principal mais algumas classes para utilizar nesse projeto.

Daniel: Esse é o primeiro desafio: integrar as classes que trouxemos no Program.cs.

**Organização do projeto**  
Guilherme: Nessas classes, temos construtores, propriedades, alguns métodos e conseguimos entender o propósito de cada uma claramente. Afinal, nesse projeto educacional, temos apenas três classes e o programa principal para manipular, editar e atualizar.

Porém, em um projeto real podemos ter centenas de classes. Se o nosso projeto tivesse muitas classes para fazer integração, não conseguiríamos saber nem em qual classe mexer atualmente.

Daniel: Fica difícil de encontrar, principalmente porque estão todas na mesma pasta e no mesmo nível. Precisaríamos usar ferramentas da IDE para encontrar o arquivo.

Podemos facilitar essa busca ao trazer uma melhor organização de classes.

Guilherme: Nesse primeiro momento, não vamos aplicar as classes. Na verdade, vamos entender como organizar os arquivos, pensando em manutenção, suporte e facilidade de acesso.

Daniel: Sim, como fazemos manutenção na classe Banda.cs, se não conseguimos encontrá-la dentre centenas de arquivos? Precisamos começar a separá-las em diretórios.

Para isso, no "Gerenciador de soluções" à direita, vamos clicar com o botão direito do mouse em cima do projeto ScreenSound e escolher a opção "Adicionar > Nova Pasta".

Vamos dar um nome arbitrário comumente utilizado nos projetos no mercado de trabalho para separar classes que representam o modelo de negócio trabalhado. Vamos colocar "Modelos" no plural.

Essa pasta ainda está vazia. Agora, vamos mover os arquivos Album.cs, Banda.cs e Musica.cs para dentro dessa nova pasta. Basta clicar no primeiro, apertar a tecla "Shift" e clicar no último para selecionar todos e arrastá-los para cima da pasta "Modelos".

Aparece um alerta para confirmar se queremos movê-los para um novo local. Vamos apertar "OK".

Em seguida, aparece outro alerta para ajustar namespaces para arquivos movidos. Queremos dar mais atenção a esse alerta e podemos fazê-lo no próximo vídeo.

Guilherme: Segura a ansiedade e não aperte nenhum botão. Vamos fazer essa correção logo após dar ênfase nessa palavra tão importante para o C#.

### Aula 1 - Namespaces - Vídeo 3

Transcrição  
Daniel: Apareceu no Visual Studio um alerta com a seguinte pergunta:

Ajustar namespaces para arquivos movidos?

Esse termo namespaces é algo novo que deveríamos prestar atenção. Quando aparece um termo novo sobre o qual queremos conhecer, geralmente acessamos a documentação da linguagem ou da biblioteca.

Nesse caso, separamos um link da documentação do C# sobre namespaces, um fundamento da linguagem.

Basicamente, a documentação explica que o namespace é usado para organizar os tipos, sejam classes ou outros.

Nós começamos um processo de organização ao levar as classes para uma pasta. O Visual Studio tem uma extensão que vai tentar criar um namespace para refletir aquela pasta criada.

Guilherme: A documentação traz um exemplo interessante com o Console.WriteLine(), que usamos bastante. Nesse caso, system é o namespace e Console é uma classe.

```csharp
System.Console.WriteLine("Hello World!");
```

Podemos usar using e o nome do namespace para não precisar referenciar sempre o caminho exato onde estão aqueles arquivos.

using System;

```csharp
Console.WriteLine("Hello World!");
```

Daniel: É uma maneira de economizar digitação. Vamos aprender isso, na prática. Primeiro, vamos fazer o caminho longo e depois com o using para perceber como fica mais fácil.

Nessa versão específica do Visual Studio que estamos rodando, essa ferramenta de ajustar namespaces não funcionou. Por isso, vamos apertar o "Não" e fazer esse ajuste manualmente para mostrar como deveria ficar no arquivo.

**Ajustar namespaces**  
Primeiro, vamos abrir o arquivo Banda.cs para começar pela hierarquia maior.

O que seria colocar o namespace no seu tipo? Na primeira linha, vamos apertar "Enter" para criar uma linha acima da declaração da classe Banda. Nela, vamos escrever a palavra reserva namespace e o próximo identificador será o nome do namespace.

Existem regras de nomenclaturas para o namespace. É comum colocar nome do projeto/empresa, em seguida o nome do módulo/pasta. A separação desses segmentos é o ponto.

Nesse caso, vamos escrever ScreenSound.Modelos. Ao final, colocamos o ponto e vírgula.

Banda.cs:

```csharp
namespace ScreenSound.Modelos;

class Banda
{
// código omitido…
}
```

Se você pegar um código legado, isto é, que já existe de projetos anteriores, você pode encontrar uma declaração de namespace diferente.

Por exemplo, em vez de ponto e vírgula no final, tem abre e fecha chaves. Entre as chaves, ficaria a classe. Tem o mesmo significado.

Exemplo

```csharp
namespace ScreenSound.Modelos
{
    class Banda
    {

// código omitido…
    }
}
```

A diferença é que, quando usamos ponto e vírgula, temos um código mais elegante e enxuto, economizando indentação. Com isso, tudo que vier embaixo dessa declaração vai fazer parte desse namespace. Por isso, vamos usar essa recomendação do C# 10 a partir daqui.

Guilherme: Esse nome de namespace ScreenSound.Modelos referente ao nome do projeto e da pasta vai ser o mesmo para as outras classes?

Daniel: Sim, basta copiar com "Ctrl + C" e colar com "Ctrl + V" na primeira linha dos arquivos Album.cs e Musica.cs. Salvamos os arquivos.

**Diretiva using**  
Guilherme: Agora que aplicamos os namespaces, o desafio é de fato começar a utilizar essas classes no nosso arquivo principal.

Daniel: Em Program.cs, na três primeiras linhas, criamos um dicionário onde a chave é do tipo string com o nome da banda e o valor é uma lista de inteiros com as respectivas notas. Mas, o que queremos é um dicionário de bandas.

Para começar a entender como funcionaria, vamos criar as bandas Ira! e The Beatles como objetos da classe Banda.

Primeiro, vamos fazer referência ao tipo Banda. Repare que demos "Esc" para não autocompletar, porque queremos mostrar a questão do using.

Em seguida, colocamos ira como variável igual ao objeto new Banda() através do construtor, onde passamos o nome da Banda Ira! entre aspas duplas.

Program.cs:

```csharp
Banda ira = new Banda("Ira!");
```

Repare que o compilador coloca Banda sublinhado de vermelho, indicando que não reconhece essa classe.

Guilherme: O Visual Studio não sabe o que é Banda. Se passamos o mouse por cima do erro, o aviso é que o nome do tipo ou do namespace Banda não pode ser encontrado.

Daniel: Inclusive, dá uma sugestão de usar uma diretiva using ou uma referência de assembly. É isso o que vamos fazer, mas antes vamos mostrar na prática como poderíamos escrever diretamente para fazer o compilador reconhecer essa classe.

Antes de Banda, poderíamos escrever ScreenSound.Modelos.. Assim, ele já consegue reconhecer.

Exemplo

```csharp
ScreenSound.Modelos.Banda ira = new ScreenSound.Modelos.Banda("Ira!");
```

Guilherme: Teria que escrever muito! Fora de cogitação.

Daniel: Sim, imagine ter que fazer o mesmo para a banda do The Beatles e outras bandas. Seria uma quantidade enorme de código repetido só para tentar achar a classe Banda.

Por isso, a diretiva using é tão importante. Se colocamos no topo do documento o using ScreenSound.Modelos, não precisamos mais colocar a referência antes da Banda. Por isso, esse trecho do código fica na cor cinza, pois não é mais necessário.

Inclusive, podemos economizar mais ao não colocar Banda após new. Afinal, já declaramos a variável do tipo Banda, portanto, seu tipo está explícito.

using ScreenSound.Modelos;

```csharp
Banda ira = new Banda("Ira!");
Banda beatles = new("The Beatles");
```

Se a variável é do tipo Banda, então usar o mesmo tipo podemos no construtor.

O próximo passo é colocar os tipos na aplicação Program.cs.

### Aula 1 - OO no Program.cs - Vídeo 4

Transcrição  
Guilherme: Confesso que estou feliz com as bandas que criamos, pois gosto do Ira! e dos Beatles. Só que tem um problema. Apesar de criá-las, ainda não a usamos em nenhum lugar. Por quê?

No dicionário do Program.cs, observe que sua chave é uma string, isto é, um texto qualquer, enquanto a lista de inteiros são as notas. Em suma, nosso dicionário é composto por um tipo Banda e um List de notas inteiras. Isso faz sentido para o nosso projeto?

Daniel: Não, não faz sentido. Vamos manter a chave como string, porque queremos achar no dicionário as bandas com aquele nome.

Porém, o valor vai ser um objeto do tipo Banda. Porque na classe Banda.cs, já temos as notas.

Banda.cs:

```csharp
class Banda
{

    private List<Album> albuns = new List<Album>();
    private List<int> notas = new List<int>();

// código omitido…

}
```

Com isso, trazemos a questão da orientação a objetos, ao encapsular o que a Banda tem.

Integrar classes no Program.cs
Então, vamos colocar no Program.cs. No lugar do List`<int>`, vamos colocar um objeto Banda.

Program.cs:

```csharp
using ScreenSound.Modelos;

Banda ira = new Banda("Ira!");
Banda beatles = new("The Beatles");

Dictionary<string, Banda> bandasRegistradas = new Dictionary<string, List<int>>();

// código omitido…
```

Guilherme: Visualmente, sabemos que algo está errado, porque na barra de rolagem à direita ficam pontos vermelhos sinalizando onde existem erros no código. Vamos arrumar cada um deles.

Daniel: Primeiro, na própria linha de criação do dicionário, vamos apagar Dictionary`<string, List<int>>` e deixar só new() - assim como fizemos na criação da banda The Beatles.

Na próxima linha de bandasRegistradas.Add(), vamos substituir a string Linkin Park que não existe mais. Vamos usar o ira.Nome como chave e passar um objeto ira no lugar das notas.

Vamos colocar as notas após a criação da Banda ira. Em uma nova linha, escrevemos o método ira.AdicionarNota() com as notas 10, 8 e 6.

Agora que adicionamos a banda Ira! no dicionário, vamos adicionar os Beatles. Para isso, em bandasRegistradas.Add(), vamos substituir a string The Beatles por beatles.Nome e o objeto beatles.

using ScreenSound.Modelos;

```csharp
Banda ira = new Banda("Ira!");
ira.AdicionarNota(10);
ira.AdicionarNota(8);
ira.AdicionarNota(6);
Banda beatles = new("The Beatles");

Dictionary<string, Banda> bandasRegistradas = new();
bandasRegistradas.Add(ira.Nome, ira);
bandasRegistradas.Add(beatles.Nome, beatles);
// código omitido…
```

Guilherme: Alguém pode se perguntar porque ainda utilizamos uma string para referenciar a banda. Isso é porque optamos por continuar a usar o dicionário.

Existem outras métodos e técnicas que podíamos utilizar, por exemplo, criar só uma lista de bandas. Contudo, isso traria uma refatoração muito maior. Por isso, deixamos o dicionário com o tipo string com o nome da banda e a notas referenciadas através de propriedades que a banda possui.

Corrigimos a parte inicial, só que ainda temos três erros sinalizados em vermelho na barra de rolagem.

Daniel: Vamos rolar o arquivo até o primeiro ponto no método Registrar Banda(), onde criávamos uma banda. Pois, agora precisamos adicionar o objeto do tipo Banda.

Após Console.ReadLine(), vamos acrescentar uma linha com uma variável Banda banda igual à new Banda(), passando o nomeDaBanda que foi capturada pelo ReadLine() no construtor.

Na próxima linha de bandasRegistradas.Add(), vamos passar o objeto do tipo banda ao invés de new List`<int>`().

```csharp
void RegistrarBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registro das bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    Banda banda = new Banda(nomeDaBanda);
    bandasRegistradas.Add(nomeDaBanda, banda);
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(4000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}
// código omitido…
```

Já resolvemos mais um erro. O próximo erro está no if() do AvaliarUmaBanda(), quando queremos adicionar uma nota com Add(nota).

Precisamos capturar o objeto da banda que está no dicionário. Como fazemos isso?

Na primeira linha do corpo do if, vamos escrever Banda banda igual à bandasRegistradas[nomeDaBanda]. Não colocamos new, porque não queremos criar um novo objeto. Queremos pegar a banda registrada que está no dicionário através da chave nomeDaBanda.

Assim, pegamos o objeto do tipo Banda na variável banda. Com isso, após perguntar qual a nota a banda merece e pegar a nota com o ReadLine(), podemos substituir toda a linha bandasRegistradas[nomeDaBanda].Add(nota).

Em seu lugar, vamos escrever o método banda.AdicionarNota() que já tínhamos, passando nota.

```csharp
void AvaliarUmaBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Avaliar banda");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Banda banda = bandasRegistradas[nomeDaBanda];
        Console.Write($"Qual a nota que a banda {nomeDaBanda} merece: ");
        int nota = int.Parse(Console.ReadLine()!);
        banda.AdicionarNota(nota);
        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
// código omitido…
```

Consertamos mais um erro. O último erro está no if() de ExibirDetalhes(). Nele, precisamos simplesmente pegar a Banda ao invés de pegar a lista de notas.

Por isso, vamos substituir List`<int>` notasDaBanda por uma variável chamada banda que é do tipo Banda.

E, em Console.WriteLine(), vamos substituir a operação notasDaBanda.Average() por banda.Media, pois encapsulamos essa informação na propriedade Media.

```csharp
void ExibirDetalhes()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibir detalhes da banda");
    Console.Write("Digite o nome da banda que deseja conhecer melhor: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Banda banda = bandasRegistradas[nomeDaBanda];
        Console.WriteLine($"\nA média da banda {nomeDaBanda} é {banda.Media}.");
        /**
        * ESPAÇO RESERVADO PARA COMPLETAR A FUNÇÃO
        */
        Console.WriteLine("Digite uma tecla para votar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
// código omitido…
```

Vamos segurar "Ctrl" e dar um clique na propriedade Media para que abra a declaração dessa propriedade Media no Banda.cs. Note que o Average() está na linha 14.

Banda.cs:

```csharp
public double Media => notas.Average();
```

Guilherme: Agora precisamos testar para conferir se o código continua a funcionar.

Daniel: Antes de testar a aplicação, vamos voltar para o Program.cs. Precisamos adicionar algumas funções, tanto no ExibirDetalhes() quanto no RegistrarAlbum().

Em ExibirDetalhes(), gostaríamos de mostrar os álbuns da banda, além de exibir a média. Isso ainda não está aparecendo, mas vamos fazer essa função depois.

Em RegistrarAlbum(), deixamos outro comentário de espaço reservado para completar a função. Porque registramos o álbum no limbo, porque ainda não o adicionamos na banda.

Guilherme: Provavelmente, a banda já tem alguma função que registra o álbum para ela.

Daniel: Exatamente. Após string titulo Album, vamos novamente pegar a banda do dicionário com Banda banda = bandasRegistradas[] a partir do nomeDaBanda.

Antes de Console.Write() onde pedimos para digitar o título do álbum, precisamos fazer um teste com if(). Se bandas.Registramos.ContainsKey(nomeDaBanda), aí, sim, podemos pegar o álbum.

Em seguida, vamos trazer desde Console.Write() até Console.Clear() para dentro do corpo do if.

Agora que já sabemos que existe essa banda digitada no dicionário, podemos simplesmente fazer o método banda.AdicionarAlbum() para criar um new Album() a partir do nome capturado na variável tituloAlbum.

Com isso, registramos esse álbum e, consequentemente, podemos retirar o comentário completar a função.

Program.cs:

```csharp
void RegistrarAlbum()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registro de álbuns");
    Console.Write("Digite a banda cujo álbum deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write("Agora digite o título do álbum: ");
        string tituloAlbum = Console.ReadLine()!;
        Banda banda = bandasRegistradas[nomeDaBanda];
        banda.AdicionarAlbum(new Album(tituloAlbum));
        Console.WriteLine($"O álbum {tituloAlbum} de {nomeDaBanda} foi registrado com sucesso!");
        Thread.Sleep(4000);
        Console.Clear();
    }
    ExibirOpcoesDoMenu();
}
```

Guilherme: Podemos colocar um else, caso não encontramos a banda.

Daniel: Podemos copiar o else do AvaliarUmaBanda(), onde fizemos um else caso a banda não existisse.

Trecho para cópia:

```csharp
    else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
```

Com "Ctrl + C" copiamos esse trecho e o colamos com "Ctrl + V" após o if do RegistrarAlbum(). Mas, podemos retirar ExibirOpcoesDoMenu() de dentro do else, uma vez que já temos esse trecho fora.

```csharp
void RegistrarAlbum()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registro de álbuns");
    Console.Write("Digite a banda cujo álbum deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandas.Registramos.ContainsKey(nomeDaBanda))
    {
        Console.Write("Agora digite o título do álbum: ");
        string tituloAlbum = Console.ReadLine()!;
        Banda banda = bandasRegistradas[nomeDaBanda];
        banda.AdicionarAlbum(new Album(tituloAlbum));
        Console.WriteLine($"O álbum {tituloAlbum} de {nomeDaBanda} foi registrado com sucesso!");
        Thread.Sleep(4000);
        Console.Clear();
    }
    else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
    }
    ExibirOpcoesDoMenu();
}
```

**Testando o ScreenSound**  
Agora podemos testar o código. Apertamos o "Ctrl + F5" para abrir o aplicativo ScreenSound.

Boas vindas ao Screen Sound 2.0!

Guilherme: Vamos testar uma opção por vez. Primeiro, digitamos a opção 1 para registrar a banda Titãs.

A banda Titãs foi registrada com sucesso!

Daniel: Agora, digitamos a opção 2 para registar um álbum de uma banda. Digitamos a banda cujo álbum queremos registrar, o Titãs. Como essa banda foi registrada no dicionário, podemos colocar o título do álbum como Cabeça Dinossauro.

O álbum Cabeça Dinossauro de Titãs foi registrado com sucesso!

Em seguida, apertamos a opção 3 para mostrar todas as bandas registradas na aplicação:

Banda: Ira!  
Banda: The Beatles  
Banda: Titãs  

Já temos as três bandas, apertamos qualquer tecla para voltar ao menu principal. A opção 4 é para avaliar uma banda. Colocamos a nota 10 para o Titãs.

A nota 10 foi registrada com sucesso para a banda Titãs

Por fim, vamos exibir os detalhes de uma banda ao escolher a opção 5. Escolhemos Ira! como a banda que desejamos conhecer melhor.

A média da banda Ira! é 8.

Podemos apertar -1 para sair.

Tchau tchau :)

Conseguimos integrar as classes que estávamos usando no Program.cs.

### Aula 1 - Construindo um Pet - Exercício

Numa aplicação console de adoção de animais, Mônica precisa criar um objeto da classe Pet no arquivo Program.cs. A classe Pet está declarada no namespace Adopet.Modelos, conforme o código abaixo:

namespace Adopet.Modelos;

```csharp
class Pet
{
    // código omitido da classe Pet
}
```

O conteúdo do arquivo Program.cs está incompleto e é mostrado a seguir:

```csharp
Pet alvo = // como criar um objeto do tipo Pet?
```

Analise os códigos abaixo e selecione todas alternativas corretas para criar um objeto Pet em C#, modificando o arquivoProgram.cs.

Alternativas corretas:

```csharp
using Adopet.Modelos;
Pet alvo = new Pet();
```

> Este código é o que você mais vai usar e encontrar em projetos da vida real. A palavra reservada using abrevia o nome completo do tipo Pet e permite que o C# encontre a referência para o tipo correto e conclua o processo de compilação do programa.

```csharp
Adopet.Modelos.Pet alvo = new(); 
```

> Muito bem! Quando declaramos explicitamente o tipo de uma variável podemos abreviar a construção do objeto usando apenas o new(). Mas, lembre-se: somente quando o tipo está declarado explicitamente. Em declarações implícitas de variáveis, o uso do new() não é permitido, simplesmente porque o compilador não consegue inferir qual tipo irá associar à variável declarada.Por exemplo o var idade = new(); não é uma instrução válida no C#.

### Aula 1 - Para saber mais: namespaces e guia de nomenclatura

No vídeo em que abordamos os Namespaces, sugerimos a [leitura da documentação oficial](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/types/namespaces) sobre namespaces em C#.

Vale lembrar também que, como qualquer nome dado a identificadores em nosso projeto, um namespace segue algumas orientações de nomenclatura:

Cada “segmento” do namespace utiliza PascalCase;

Os segmentos são conectados pelo caractere . (ponto);

Uma regra geral para a nomeação de namespaces com diferentes segmentos é começar com o nome da empresa, em seguida o produto ou tecnologia, depois o módulo ou função e eventualmente um quarto segmento para o submódulo. Exemplo: Microsoft.AspnetCore.Mvc.

Indicamos também a leitura do [guia de nomenclatura de namespaces](https://learn.microsoft.com/en-us/dotnet/standard/design-guidelines/names-of-namespaces) para consulta.

### Aula 1 -  Desafio: hora da prática

A prática é um elemento essencial ao iniciar os estudos em programação, pois é por meio da aplicação prática dos conceitos teóricos que se solidificam os conhecimentos. Ao escrever código, resolver problemas e construir projetos reais, os iniciantes não apenas internalizam a sintaxe das linguagens de programação, mas também desenvolvem a habilidade de pensar logicamente e abordar desafios de maneira eficiente.

Pensando nisso, criamos uma lista de atividades (não obrigatórias) focada em prática para melhorar ainda mais sua experiência de aprendizagem. Bora praticar, então?

Criar uma classe que representa um filme, com dados como seu titulo, duração e elenco. Após isso, colocá-la no namespace Alura.Filmes.

Criar um programa Program.cs, instanciar seus 5 filmes favoritos, guardá-los em uma lista e mostrar as suas informações no console.

Criar uma classe Artista, que representa uma pessoa que atua em filmes, no namespace Alura.Filmes. A classe deve conter atributos como o nome, idade e uma lista de filmes onde o artista atuou.

Modificar as classes Artista e Filme do namespace Alura.Filmes para que elas sejam consistentes uma com a outra, ou seja, sempre que for adicionado um artista a um filme, terá de ser adicionado também o filme à lista de filmes do artista.

Opinião do instrutor

Para te ajudar a verificar seus códigos, disponibilizamos uma [lista com as possíveis soluções](https://github.com/ArthurOcFernandes/Exerc-cios-C-/tree/curso-3-aula-1) no Github.

Boa sorte nos estudos!

### Aula 1 - Faça como eu fiz: organização de código como boa prática

Afirmamos que em nossa carreira de pessoas desenvolvedoras vamos trabalhar em projetos com dezenas e até centenas de classes. Imagina se todas as classes ficassem no mesmo nível de pasta e a cada necessidade de encontrar uma classe você precisasse usar a barra de rolagem? Ou mesmo digitar o nome dela em uma janela de pesquisa em sua IDE favorita? Produtividade é um objetivo essencial no trabalho e uma das maneiras de atingi-la é organizar os arquivos e classes em pastas diferentes.

Junto com a separação em pastas, utilizamos outro recurso que nos permite organizar classes: são os namespaces. Além da organização, um benefício adicional é conseguir manter dentro do projeto tipos com o mesmo nome. A distinção é feita através da referência ao “nome completo da classe”, ou Fully Qualified Name (FQN), que é obtido com a concatenação do namespace com a classe. Por exemplo, o FQN da classe Musica no namespace ScreenSound.Modelos é ScreenSound.Modelos.Musica.

Agora é a sua vez de testar pastas e namespaces em um projeto!

Sua missão agora é criar um projeto do tipo console com duas pastas: PlataformaA e PlataformaB. Nelas você vai declarar classes de mesmo nome: Video. A ideia é representar vídeos com conceitos diferentes, dependendo da plataforma de streaming. Para o objetivo desta atividade, não precisaremos criar propriedades nelas. Declare seus namespaces como a seguir:

Classe Video na pasta PlataformaA: namespace VideoFlix.PlataformaA;

Classe Video na pasta PlataformaB: namespace VideoFlix.PlataformaB.

Por fim, declare duas variáveis no arquivo Program.cs cujos tipos são Video da plataforma A e Video da plataforma B. Como resolver o conflito de nomes?

### Aula 1 - O que aprendemos?

**Desafio proposto pela Luri, a IA da Alura.**

Explique com suas próprias palavras os principais conceitos que você aprendeu nesta aula.

Resposta:  
Nesta aula os professores frizaram a importância de se organizar os arquivos dentro de um projeto, com suas devidas classes separadas em si e agrupadas em um 'conjunto' dentro de uma pasta, criando um espaço, namespace.

Parabéns pela dedicação aos estudos!

Você abordou um ponto muito importante sobre a organização dos arquivos dentro de um projeto, destacando a criação de pastas e namespaces para agrupar as classes. Além disso, também vimos que essa prática não só melhora a legibilidade do código, mas também facilita a manutenção e a colaboração em equipe, uma vez que todos os desenvolvedores podem entender rapidamente a estrutura do projeto.

Outro aspecto que foi discutido na aula é a aplicação das classes Banda e Album no arquivo Program.cs, o que ajuda a tornar a aplicação mais orientada a objetos. O encapsulamento das notas como parte de uma banda é um exemplo de como podemos manter o código limpo e organizado, permitindo que futuras alterações sejam feitas de maneira mais eficiente.

Continue estudando e praticando!

## Aula 2 - Nova classe Avaliacao

### Aula 2 -  - Vídeo 1
### Aula 2 -  - Vídeo 2 
### Aula 2 -  - Vídeo 3
### Aula 2 -  - Vídeo 4
### Aula 2 -  - Vídeo 5
### Aula 2 -  - Vídeo 6
### Aula 2 -  - Vídeo 7
### Aula 2 -  - Vídeo 8
