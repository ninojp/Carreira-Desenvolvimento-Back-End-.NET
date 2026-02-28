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

### Aula 2 - Visibilidade internal - Vídeo 1

Transcrição  
Daniel: Neste vídeo, trabalharemos com a Orientação a Objetos para encapsular o conceito de nota.

Vamos abrir novamente o arquivo Banda.cs, onde veremos que as notas dadas para a classe Banda são representadas como um inteiro (int). Imagina se adicionarmos um número negativo como -1237.

Guilherme: Ele vai aceitar.

Daniel: A banda será rebaixada.

Vamos tentar representar o conceito de nota por meio de uma classe.

Guilherme: Isso é comum. Geralmente adicionamos os tipos primitivos (int, string, entre outros) no interior de uma classe para podermos manipular melhor essas informações e suas validações. Não queremos que notas negativas sejam aplicadas.

Daniel: Encontraremos muitos tipos na biblioteca .NET que possuem uma série de comportamentos. Com o tipo DateTime, por exemplo, possui comportamentos para representar uma data. Ele permite a soma entre um mês e determinada data para adquirir uma nova data.

Voltando ao código, abriremos o gerenciador de soluções clicando no botão de mesmo nome na lateral direita da IDE. Em seu interior, clicaremos com o botão direito na pasta "Modelos" e selecionaremos "Adicionar > Classe". Com isso, uma janela denominada "Adicionar novo Item" será aberta, onde veremos uma lista de modelos de template.

Até agora utilizamos somente o modelo "Arquivo de Código". Agora, clicaremos no modelo "Classe" e entenderemos o que o Visual Studio nos fornecerá com este template. No campo "Nome", abaixo da lista de modelos, escreveremos "Avaliacao" (sem pontuação) e pressionaremos "Enter".

Com isso, o editor abrirá o arquivo recém-criado Avaliacao.cs, onde teremos a classe Avaliavao com uma estrutura pronta.

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ScreenSound.Modelos
{
    internal class Avaliacao
    {
    }
}
```

Guilherme: É interessante ver que ele aplicou o namespace correto: ScreenSound.Modelos.

Daniel: Exatamente.

Já sabemos o que significam os using no topo do código — ele nos entregou um atalho para diversos namespaces (System, System.Collections.Generic, System.Linq, System.Text e System.Threading.Tasks), entretanto, não vamos utilizar nenhum deles. Por isso, vamos selecionar e apagar essas cinco linhas.

```csharp
namespace ScreenSound.Modelos
{
    internal class Avaliacao
    {
    }
}
```

Dica de boas práticas: Quando mais enxuto o código estiver, melhor.

O namespace está declarado da maneira antiga, utilizando um bloco de chaves. Para alterá-lo, iremos até o fim da linha namespace ScreenSound.Modelos e adicionaremos um ;. Com isso, o editor excluirá o bloco de chaves.

```csharp
namespace ScreenSound.Modelos;

    internal class Avaliacao
    {
    }
```

Guilherme: É como mágica. Eu esperava que você tirasse manualmente as chaves.

Daniel: É.

Voltando à classe Avaliacao, o que ela precisará ter? Um construtor

Entre as chaves de internal class Avaliacao, adicionaremos o construtor escrevendo o atalho ctor e pressionando "Enter". Isso fará com que o editor crie o construtor public Avaliacao() junto a um bloco de chaves.

Entre os parênteses desse construtor, "embrulharemos" o conceito de inteiro adicionando um int nota com "N" minúsculo.

Abaixo das chaves dele, criaremos a propriedade public int Nota { } que terá entre chaves apenas o acesso de leitura (o get).

Acessando o interior das chaves do construtor, guardaremos a nota com "n" minúsculo dentro da propriedade Nota com "N" maiúsculo.

```csharp
namespace ScreenSound.Modelos;

    internal class Avaliacao
        {
            public Avaliacao()
            {
                Nota = nota;
            }
            
            public int Nota { get; }
        }
```

Apesar de não realizarmos ainda nenhuma validação, poderíamos fazê-la para encapsular melhor o conceito de nota.

Guilherme: Vamos deixar esta validação livre para ser criada pelas pessoas estudantes, pois o tipo de valor inserido pode variar, dependendo do aplicativo. Alguns utilizam avaliações que vão de 0 a 10, outros utilizam estrelas que vão de 0 a 5 e outros podem utilizar somente duas opções ("Gostei" e "Não gostei").

Daniel: Vamos falar sobre o termo internal, que não estava presente nas classes anteriores. Ele está relacionado à visibilidade de classes. Vamos entendê-lo por meio da exploração do seu contrário.

Acessando o arquivo Program.cs, veremos a linha abaixo com o tipo Dictionary.

```csharp
Dictionary<string, Banda> bandasRegistradas = new;
```

Nós declaramos esta classe, Gui?

Guilherme: Não.

Daniel: Ela foi criada e entregue pelo próprio .NET, está no namespace System.Collections.Generic e está no interior de outro projeto que não temos acesso neste momento. Para que outros projetos possam enxergá-la, a visibilidade da classe do tipo Dictionary precisa ser pública.

Voltando ao arquivo Avaliacao.cs, quando declaramos uma classe como internal (interna), ela será vista apenas pelo projeto.

Guilherme: Excelente. Acredito que este tipo seja bem-vindo nas outras classes.

Daniel: Exatamente.

Guilherme: Vamos realizar uma refatoração e incluir o internal nelas?

Daniel: Vamos. Acessaremos os arquivos das classes abaixo e adicionaremos o internal à esquerda da palavra reservadas class, salvando o código a cada troca de arquivo. O resultado pode ser visto abaixo.

Arquivo Musica.cs:

```csharp
internal class Musica
```

Arquivo Album.cs:

```csharp
internal class Album
```

Arquivo Banda.cs:

```csharp
internal class Banda
```

Por orientação, manteremos nossas classes com a menor visibilidade possível. Elas devem ser alteradas para public somente nos casos em que queremos que ela seja vista em outros projetos.

Guilherme: Certo. Voltando à aplicação, criamos a classe Avaliacao, mas ainda não a utilizamos. Faremos isso na sequência.

### Aula 2 - Usando o novo tipo - Vídeo 2

Transcrição  
Daniel: Gui, vamos utilizar a classe Avaliacao no projeto.

Guilherme: Vamos lá.

Daniel: Acessaremos o arquivo Banda.cs, onde verificaremos que a representação da nota ainda é feita como uma lista de int. Vamos alterá-la para uma lista de Avaliacao.

Em seguida, alteraremos o método AdicionarNota() para receber um Avaliacao nota no lugar do int nota.

```csharp
internal class Banda
{
// Código omitido
    private List<Avaliacao> notas = new List<Avaliacao>();
    // Código omitido
    public void AdicionarNota(Avaliacao nota)
    {
    // Código omitido
    }
// Código omitido
}
```

Vamos até o método public double Media que calcula a média das notas. Para ele receber um tipo mais complexo (ou seja, uma classe com várias propriedades), precisamos explicitar qual propriedade usar para este cálculo.

Guilherme: Provavelmente é a Avaliacao.nota, certo?

Daniel: Isso. Portanto, na linha public double Media => notas.Average, adicionaremos uma expressão lambda à direita, onde diremos que deve-se usar a propriedade nota para cada avaliação.

Dica: Para entender mais sobre expressões lambda, acesse o página da Microsoft sobre expressões lambda.

```csharp
internal class Banda
{
    // Código omitido
    public double Media => notas. Average (a => a. Nota);
    // Código omitido
}
```

Resolvemos a questão na classe Banda.

Guilherme: Uma dúvida: vamos supor que a nota seja vazia, ou seja, um espaço em branco. Teríamos um erro na média de notas da classe Banda?

Daniel: Você se refere ao caso da lista estar vazia.

Guilherme: Isso.

Daniel: Acho que sim, Gui.

Guilherme: Poderíamos iniciar o construtor dela com a nota 0?

Daniel: Sim, mas a nota seria contabilizada como 0.

Guilherme: Verdade. Então, poderíamos realizar uma verificação para exibir alguma coisa nos casos em que não existir uma nota.

Daniel: Interessante. Com isso, podemos utilizar uma propriedade que não seja somente de leitura no lugar do => notas. Average (a => a. Nota.

Vamos selecionar todo o lambda mencionado acima, recortar esse conteúdo e adicionar um bloco de chaves em seu lugar. Entre essas chaves, abriremos um bloco de chaves get e diremos em seu interior que, para este método de leitura, faremos o seguinte teste:

Se notas.Count for 0 (ou seja, não existe nota), retornaremos a média 0. Senão, retornaremos o cálculo que recortamos anteriormente.
Por fim, substituiremos a primeira seta do código colado por um return.

O resultado do código pode ser visto abaixo.

```csharp
internal class Banda
{
    // Código omitido
    public double Media
    {
        get
        {
            if (notas.Count == 0) return 0;
            else return notas. Average (a => a. Nota);
        }
    }
    // Código omitido
}
```

Boa, Gui.

Guilherme: Excelente. Com isso, garantimos o melhor funcionamento do código.

Daniel: De fato. Eu não havia percebido isso. Por isso é interessante programar junto com outras pessoas.

Com este problema resolvido, vamos acessar o arquivo Program.cs pois lá haverão erros.

No começo do arquivo, temos três linhas que possuem o ira.AdicionarNota().

Guilherme: Ela adicionava a nota diretamente, né. Vamos precisar chamar algo dentro deste método.

Daniel: Exato. Entre os parênteses dos três ira.AdicionarNota() criaremos um objeto new Avaliacao() que envolverá em seus parênteses o número que representa a nota.

```csharp
Banda ira = new Banda("Ira!");
ira. AdicionarNota(new Avaliacao (10));
ira. AdicionarNota(new Avaliacao (8));
ira. AdicionarNota(new Avaliacao (6));
Banda beatles = new("The Beatles");
```

Guilherme: Muito bom. Se observarmos a barra de rolagem na lateral direita, veremos um ponto vermelho.

Daniel: Vamos descer a tela até ele.

Guilherme: É o mesmo problema, né.

Daniel: Sim. Vamos alterar o banda.AdicionarNota(nota) para receber entre parênteses um new Avaliacao() que envolverá a nota.

```csharp
if (bandasRegistradas.ContainsKey(nomeDaBanda))
{
    // Código omitido
    banda.AdicionarNota(new Avaliacao(nota));
    // Código omitido
}
// Código omitido
```

Acredito que resolvemos.

Guilherme: Vamos testar?

Daniel: Vamos. Para isso, pressionaremos "Ctrl+F5".

Na tela da aplicação, vamos avaliar uma banda. Responderemos à primeira pergunta com um 4, a segunda com o nome da banda (Ira!), e por fim, a pergunta sobre a nota que ela merece com o valor da nota. Qual será ela?

Guilherme: Nota 9.

Daniel: Após o "Enter", receberemos a mensagem de que a nota foi registrada com sucesso.

Agora, queremos exibir os detalhes de uma banda que não possui nota, para testar a condicional que criamos. Para isso, responderemos à pergunta "Digite sua opção" com o número 5 e à pergunta "Digite o nome da banda que deseja conhecer melhor" com o nome The Beatles.

Com isso, aparecerá a seguinte mensagem:

A média da banda The Beatles é 0.

Guilherme: Nota 0? Vamos dar uma nota aos Beatles antes de acabar o vídeo?

Daniel: Certo. Vamos responder à pergunta "Digite sua opção" com o número 4 para avaliar a banda, à pergunta "Digite o nome da banda que deseja avaliar" com o nome The Beatles e à pergunta "Qual a nota que a banda The Beatles merece" com o número 10.

Após recebermos a mensagem de que a nota foi registrada com sucesso, exibiremos os detalhes da banda recém-avaliada. Para isso, responderemos à pergunta "Digite sua opção" com o número 5, à pergunta "Digite o nome da banda" com o nome The Beatles e veremos a seguinte mensagem:

A média da banda The Beatles é 10.

Com um "Enter", voltamos ao menu principal. Nele, digitaremos -1 para sair da aplicação. Tudo ok.

### Aula 2 - Melhorando avaliação - Vídeo 3

Transcrição  
Daniel: Gui, já temos bastante coisa. Criamos a classe Avaliacao que encapsula o conceito de nota da avaliação.

Contudo, existe um detalhe que me incomoda e que podemos melhorar, afinal, sempre que desenvolvemos um projeto, buscamos melhorias.

Voltando ao arquivo Program.cs, na linha em que realizamos a última modificação, nós convertemos um valor digitado pela pessoa para inteiro, depois convertemos este valor para um objeto do tipo Avaliacao.

Vamos pular um passo, recolhendo o texto digitado e convertendo-o diretamente para um objeto Avaliacao.

Guilherme: Neste caso, teríamos um parse (conversão) para Avaliacao.

Daniel: Isso. Vamos acessar o arquivo Avaliacao.cs e, abaixo da linha public int Nota { get; }, pularemos uma linha e criaremos um método public Avaliacao Parse() junto a um bloco de chaves. Este método terá o nome Parse e retornará, em vez do Void, um objeto Avaliacao.

Ele também receberá entre parênteses uma string texto.

Voltando ao arquivo Program.cs, copiaremos a linha abaixo, localizada dentro do if.

```csharp
Console.Write("Qual a nota que a banda merece: ");
int nota = int.Parse(Console.ReadLine()!);
```

Em seguida, voltaremos ao Avaliacao.cs e pressionaremos "Ctrl+V" para colar esta linha no interior das chaves de public Avaliacao Parse(). Na linha recém-colada, substituiremos o comando Console.ReadLine()! pelo argumento texto. Por fim, abaixo dela, retornaremos um new Avaliacao(nota).

```csharp
internal class Avaliacao
{
    // Código omitido

    public int Nota { get; }

    public Avaliacao Parse(string texto)
    {
        int nota = int.Parse(texto);
        return new Avaliacao(nota);
    }
}
```

Voltando ao Program.cs, modificaremos a linha que copiamos, de int nota = int.Parse(Console.ReadLine()!) para Avaliacao nota = new Avaliacao().Parse(Console.ReadLine()!).

```csharp
Avaliacao nota = new Avaliacao().Parse(Console.ReadLine()!)
```

Neste momento, o código Avaliacao apontará um erro, sendo sublinhado por uma linha vermelha.

Guilherme: Isso é estranho, pois teoricamente, o Parse pode ser utilizado somente pela chamada, sem precisar instanciá-lo.

Daniel: Existe uma distinção entre métodos de instância (executados com as informações do próprio objeto) e métodos que não são da instância, por exemplo, o int.Parse() utilizado anteriormente.

Guilherme: No primeiro caso, damos new.

Daniel: Isso mesmo.

Se, em vez de int.Parse(), quiséssemos realizar um Avaliacao.Parse(), não seria possível.

Voltando ao arquivo Avaliacao.cs, veremos que as instruções dentro do método Avaliacao Parse() não utilizam nada de fora da instância do objeto, como, por exemplo, nota. Neste tipo de cenário, podemos marcar este método como estático. Dessa forma, ele se tornará apenas uma função com elementos autocontidos.

Faremos isso, adicionando um static à direita da palavra reservada public.

```csharp
internal class Avaliacao
{
// Código omitido
    public static Avaliacao Parse(string texto) 
    {
        int nota int.Parse(texto);
        return new Avaliacao (nota);
    }
}
```

Guilherme: Assim, temos o public static, o tipo Avaliacao que queremos retornar e o Parse que converte um tipo para outro. Ele retornará um new Avaliacao.

Com o static, não precisamos declarar o new e podemos chamar o método diretamente pelo tipo.

Daniel: Isso. O static informa que o conteúdo executado não utiliza nenhuma informação da instância desta classe — no caso, Avaliacao.

Guilherme: Apesar disso, ela modifica alguma coisa que ajudará a classe.

Daniel: Isso mesmo. Através do return que gerará um objeto neste caso.

Salvaremos o código e retornaremos ao arquivo Program.cs, onde temos o compilador funcionando na linha Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!). O que antes era int nota = int.Parse() agora é Avaliacao nota = Avaliacao.Parse().

Na linha de baixo, nós já temos o objeto, então não precisamos mais do comando new Avaliacao. Vamos deletá-lo do interior dos parênteses de banda.AdicionarNota() e fornecer somente o nota que foi criado a partir do Parse().

Guilherme: Porque ele já é do tipo Avaliacao, né. Se ele não conseguir converter, retornará uma mensagem informando que não foi possível realizar o processo.

Daniel: Isso.

```csharp
if (bandasRegistradas.ContainsKey(nomeDaBanda))
{
    // Código omitido
    Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);
    banda. AdicionarNota(nota);
    // Código omitido
}
// Código omitido
```

Guilherme: Vamos testar este código adicionando uma nota?

Daniel: Sim. Pressionaremos "Ctrl+F5" para abrir a aplicação.

Guilherme: Vamos avaliar a banda Ira! com a nota 10. Após responder todas as perguntas, veremos a seguinte mensagem:

A nota ScreenSound.Modelos.Avaliacao foi registrada com sucesso para a banda Ira!

Daniel: Apareceu algo interessante: o nome do tipo da nota (ScreenSound.Modelos.Avaliacao). Isso ocorre porque não estamos mais utilizando um inteiro.

Vamos fechar a aplicação com -1 e observar a linha do Console.WriteLine() abaixo de banda. AdicionarNota(nota). Nela, utilizamos um objeto nota. Para que funcione, precisamos adicionar a ele a propriedade Nota, inserindo antes um ponto.

```csharp
if (bandasRegistradas.ContainsKey(nomeDaBanda))
{
    // Código omitido
    banda. AdicionarNota(nota);
    Console.WriteLine($"\nA nota {nota.Nota} foi registrada com sucesso para a banda {nomeDaBanda}");
    // Código omitido
}
// Código omitido
```

Voltando à aplicação por meio do "Ctrl+F5", vamos conferir se funciona. Vamos avaliar a banda Ira! novamente com a nota 10. Após responder todas as perguntas, veremos a seguinte mensagem:

A nota 9 foi registrada com sucesso para a banda Ira!

Guilherme: Excelente.

Daniel: Vamos fechar a aplicação digitando -1.

Para concluir, os métodos estáticos são muito importantes e serão bastante utilizados em nossas carreiras como pessoas desenvolvedoras. Eles permitem a anexação de funções dentro de um tipo — neste caso, no conceito de Avaliacao.

### Aula 2 - Classe Program - Vídeo 4

Transcrição  
Daniel: Gui, nós incorporamos o conceito de Avaliacao na aplicação e conhecemos os métodos estáticos.

Desde o primeiro curso, revelamos palavras reservadas que foram aparecendo, como internal e namespace. Elas parecem um truque mas, na verdade, o próprio .NET sugere o uso delas como uma maneira de aprendizado.

Guilherme: Sim.

Daniel: O nosso arquivo .cs é, na verdade, uma classe!

Guilherme: Não acredito. Você deve estar brincando! Mostre para nós.

Daniel: Se acessarmos o arquivo Program.cs, veremos que seu texto está organizado em instruções, o que foge do padrão dos outros arquivos do projeto. Isso ocorre porque o Program.cs é o ponto de entrada de uma aplicação .NET.

Para facilitar o aprendizado das pessoas que estão iniciando nessa linguagem, ele escondeu a classe Program. Com o Visual Studio, posicionaremos o cursor na linha vazia, abaixo da linha using ScreenSound.Modelos. Nela, vamos apertar "Ctrl+." acessar a lista suspensa aberta pelo editor e clicar na terceira opção: "Converter para 'Program.Main' o estilo do programa".

Com isso, nosso código exibirá a classe internal class Program envolvendo todo o código do arquivo, e dentro dele, na primeira linha, temos um método chamado Main, o método principal e ponto de entrada da aplicação.

using ScreenSound. Modelos;

```csharp
internal class Program
{
    private static void Main(string[] args)
    {
        Banda ira = new Banda("Ira!");    
    // Código omitido    
    }    
// Código omitido
}
```

Guilherme: Isso é comum? Teremos em toda aplicação?

Daniel: Sim, todas as aplicações .NET possuem estes elementos.

Guilherme: Esta classe diz "o programa começa aqui". A partir dela, toda a mágica acontecerá.

Daniel: Exatamente.

Guilherme: No nosso caso, ela sempre existiu, né… Quando damos play ou rodamos o programa com o Visual Studio Code, por exemplo, sempre fornecemos o nome. Com isso, sem sabermos, estávamos chamando a execução do programa principal, por meio do qual a aplicação se inicia.

Daniel: Exatamente.

Guilherme: E ele possui alguns elementos: o internal para ser visto apenas na própria aplicação e o private static void Main que recebe uma lista de strings com o args.

Daniel: Este último é uma lista ou arranjo de strings que já conhecemos.

Agora que vemos a classe Program e seu método Main, interpretamos melhor o código. Em nossas carreiras, podemos trabalhar com códigos de times que usam o CSharp em uma versão anterior (10 ou menos), onde nos depararemos com estes dois elementos.

Guilherme: É interessante comentar que estes elementos não são exclusivos do CSharp. A maioria das linguagens, principalmente aquelas baseadas em Orientação a Objetos (como Java ou Python), conterão uma classe como essa que armazena outras centenas de classes.

A classe Main é uma forma com a qual a plataforma entende onde será o ponto de partida da aplicação.

Daniel: Contudo, diferentemente de outras linguagens que possuem estes elementos, no CSharp o projeto possui uma marcação para sinalizar qual é a classe de entrada — neste caso, o projeto marcado "ScreenSound" pode ser visto pelo gerenciador de soluções na lateral esquerda da IDE, localizado na raiz dos diretórios).

No Java, por exemplo, podemos marcar qualquer classe como classe de entrada. Para alterá-la, entramos no projeto e alteramos uma opção específica.

Vamos retirar o internal class Program e o private static void Main(string[] args), pois o código estava mais elegante sem eles. Vamos deixar o compilador realizar o trabalho destes elementos.

Para retornar o código para o modo anterior, excluindo a classe Program e o método Main, pressionaremos "Ctrl+Z".

```csharp
using ScreenSound.Modelos;
Banda ira = new Banda("Ira!");
// Código omitido
```

Após esta alteração, podemos continuar nosso aprendizado.

### Aula 2 - Faça como eu fiz: o poder do encapsulamento

Nesta aula introduzimos uma nova classe Avaliacao para que ela pudesse isolar tanto o dado primitivo com o valor da nota (usamos um inteiro para representá-la) quanto possíveis comportamentos do conceito de avaliação em nossa aplicação (por exemplo a capacidade de transformar um texto em um objeto através do método estático Parse(). Um tipo muito comum em projetos C# criado com esta mesma finalidade é o DateTime. Seu objetivo é representar um momento no tempo e fornecer comportamentos para lidar com datas, horas, conversões, dentre outros.

Um comportamento que pode ser inserido nestes tipos é a habilidade de validar valores que estão fora do limite permitido. No caso de uma nota, citei que um valor negativo para uma banda faria com que ela fosse rebaixada no carnaval daquela temporada :-). Notas muito grandes também não fariam sentido e impactariam o cálculo da média, impossibilitando a comparação entre bandas.

Agora é sua vez! Na classe Avaliacao, crie uma regra de negócio para não permitir que notas menores que zero sejam registradas. Além disso, notas maiores que dez também não podem ser registradas.

Considere que valores inteiros fora da faixa recebem os limites inferior e superior. Ou seja:

Notas menores que zero são zero;  
Notas maiores que dez são dez.

Opinião do instrutor

Veja como ficou a classe Avaliacao alterada:

```csharp
internal class Avaliacao
{
    public Avaliacao(int nota)
    {
        if (nota <= 0) nota = 0;
        if (nota >= 10) nota = 10;
        Nota = nota;
    }

    public int Nota { get; }

    public static Avaliacao Parse(string texto)
    {
        int nota = int.Parse(texto);
        return new Avaliacao(nota);
    }
}
```

A regra ficou embutida no construtor da classe. Quando o argumento nota estiver fora da faixa, alteramos seu valor para os valores mínimo ou máximo. E melhor ainda: mesmo que utilize o método estático Parse(), a regra será obedecida. Quem a consome pode passar valores fora da faixa 0-10 e não vai conseguir burlar ou hackear o sistema.

Esse é o poder do encapsulamento: isolamos uma regra de validação pertinente somente a avaliações. Quando houver necessidade de mudar esta regra (seja porque os limites mudaram ou por qualquer outro motivo), a mudança será realizada em um local único. Muito interessante!

### Aula 2 - Exibindo a folha salarial - Exercício

No módulo de folha salarial de uma empresa, existe uma classe que calcula o salário de cada colaborador com base no seu salário bruto, nos descontos aplicados no mês e nos bônus por anos de empresa (anuênio). O código das classes Colaborador e DepartamentoPessoal é exibido abaixo. Nele, o método ExibeFolha() é declarado estaticamente e possui como argumento uma lista de colaboradores.

```csharp
internal class Colaborador
{
    public Colaborador(string nome, double salario, int anosEmpresa, double descontos = 0)
    {
        Nome = nome;
        Salario = salario;
        AnosEmpresa = anosEmpresa;
        Descontos = descontos;
    }

    public string Nome { get; }
    public double Salario { get; }
    public int AnosEmpresa { get; }
    public double Descontos { get; }
    public double Anuenio => 1 + (AnosEmpresa * 0.01);
}

internal class DepartamentoPessoal
{
    public static void ExibeFolha(List<Colaborador> colaboradores)
    {
        foreach (Colaborador c in colaboradores)
        {
            var salarioDoMes = (c.Salario * c.Anuenio) - c.Descontos;
            Console.WriteLine($"- {c.Nome}: R$ {salarioDoMes}");
        }
    }
}
```

Analise as afirmações abaixo e marque as alternativas corretas.

Respostas:  

Para invocar a exibição da folha, basta executar o código abaixo.

> List`<Colaborador>` colaboradores = new();
DepartamentoPessoal.ExibeFolha(colaboradores);

Muito bem! Para exibir a folha salarial da lista de colaboradores não precisamos instanciar objetos DepartamentoPessoal, uma vez que ExibeFolha() é um método estático.

O método de acesso de leitura à propriedade Anuenio não pode ser marcado como estático porque ele acessa o membro de instância Colaborador.AnosEmpresa.

> Isso aí! Apesar da construção usando expressões lambda, ainda estamos escrevendo código para o método get, que implementa o acesso de leitura à propriedade Anuenio. Como esta implementação utiliza a propriedade de instância AnosEmpresa, Anuenio também precisa ser de instância, e portanto não pode ser declarado como static.

### Aula 2 - Desafio: hora da prática

A prática é um elemento essencial ao iniciar os estudos em programação, pois é por meio da aplicação prática dos conceitos teóricos que se solidificam os conhecimentos. Ao escrever código, resolver problemas e construir projetos reais, os iniciantes não apenas internalizam a sintaxe das linguagens de programação, mas também desenvolvem a habilidade de pensar logicamente e abordar desafios de maneira eficiente.

Pensando nisso, criamos uma lista de atividades (não obrigatórias) focada em prática para melhorar ainda mais sua experiência de aprendizagem. Bora praticar, então?

1. Modelar um Pet Shop com classes como Pet, Dono, Consulta e médico.

2. Modelar o funcionamento de uma oficina automobilistica.

3. Criar um programa Program.cs e simular o funcionamento do programa.

4. Escrever um programa que funcione como uma calculadora, que pode realizar as 4 operações básicas, além de calcular raiz quadrada e potências. O usuario deve entrar com dois números e um simbolo que represente a operação a ser feita.

Opinião do instrutor

Para te ajudar a verificar seus códigos, disponibilizamos uma lista com as [possíveis soluções no Github](https://github.com/ArthurOcFernandes/Exerc-cios-C-/tree/curso-3-aula-2).

Boa sorte nos estudos!

### Aula 2 - Faça como eu fiz: contador de objetos

Nesta aula, conhecemos os métodos estáticos, que são blocos de instrução que de alguma maneira estão relacionados ao tipo ao qual aquele método pertence, mas não utilizam nenhum dado ou outro método de objetos do tipo. Além de métodos estáticos, também podemos criar campos estáticos. Neste caso, o valor do campo está associado ao tipo e não ao objeto. Um cenário muito comum é armazenar constantes associadas àquele tipo. Por exemplo, o limite mínimo ou máximo de uma Avaliacao.

Agora é sua vez! Na classe Album utilize um campo estático para incrementar o número de objetos criados no programa. Por exemplo, para o código abaixo, o valor impresso deverá ser 3.

```csharp
internal class Album
{
    // código omitido
}

Album a1 = new Album(“Barões da Pisadinha Ao Vivo”);
Album a2 = new Album(“Barões da Pisadinha feat. Anitta”);
Album a3 = new Album(“Barões da Pisadinha no Free Jazz Festival”);

Console.WriteLine($”Total de objetos criados: {Album.ContadorDeObjetos}”);
```

Opinião do instrutor

Inicialmente, vamos criar um campo estático chamado ContadorDeObjetos na classe Album e inicializá-lo com o valor zero.

```csharp
internal class Album
{
    public static int ContadorDeObjetos = 0;
    // código omitido
}
```

Até mesmo classes podem ser declaradas como estáticas! No caso de classes estáticas, o objetivo é impedir a criação de objetos. Classes estáticas são muito usadas como contêineres de funções estáticas independentes, mas unidas logicamente.

Para concluir o desafio, precisamos incrementar este campo toda vez que um objeto for criado. O momento de fazer isso é no construtor da classe:

```csharp
internal class Album
{
    public static int ContadorDeObjetos = 0;

    public Album()
    {
        ContadorDeObjetos++;
    }
}
```

Pronto! Agora toda vez que um objeto for criado, o campo será incrementado e podemos saber quantos existem através dele.

### Aula 2 - O que aprendemos?

Estes foram os pontos principais abordados nesta aula:

- Conhecemos uma boa prática que é embrulhar tipos primitivos em conceitos maiores, permitindo adicionarmos comportamentos como validação, tradução e quaisquer outras operações;

- Aprendemos que também as classes podem ter sua visibilidade modificada pelas palavras reservadas internal e public. Classes internal só podem ser vistas dentro de um projeto. Já classes public são vistas por qualquer projeto que as referencie.

- Compreendemos que quando um método não acessa informações dos objetos da classe onde está declarado, pode ser indicado como estático. Basta usar a palavra reservada static em sua assinatura. E para ser invocado, usamos o modelo Tipo.MetodoEstatico(). Exemplos de métodos estáticos que já vínhamos usando desde os primeiros cursos: Console.WriteLine(), int.Parse(), Thread.Sleep(), Console.Clear(), dentre outros.

- Revelamos um segredo da Microsoft no arquivo Program.cs. Ele também é uma classe que possui um método estático chamado Main(), indicado para representar o ponto de entrada de qualquer programa .NET. O motivo pelo qual a Microsoft escolheu esconder esta classe foi para reduzir a curva de aprendizado aos iniciantes na linguagem. Legal né?!

Na próxima aula:

Vamos aprender de forma prática como usar uma poderosa tecnologia disponível no C# que oferece recursos avançados para consulta e manipulação de dados!

## Aula 3 - Comportamento comuns aos menus

### Aula 3 - Projeto da aula anterior

Aqui você pode [baixar o zip da Aula 02](https://github.com/alura-cursos/ScreenSound/archive/refs/heads/aula-2.zip) ou acessar os [arquivos no GitHub!](https://github.com/alura-cursos/ScreenSound/tree/aula-2)

### Aula 3 - Isolando cada opção - Vídeo 1

Transcrição  
Guilherme: Algo que me preocupa um pouco na aplicação que estamos desenvolvendo é a quantidade de linhas em alguns arquivos e em outros, não.

Por exemplo: vamos abrir a classe Banda. Observando o arquivo, identificamos 42 linhas de código. Porém, as informações contidas no arquivo Banda.cs fazem com que ele tenha sentido em existir, pois estão isolados os comportamentos e as propriedades.

No arquivo Program.cs, que sabemos ser uma classe, temos 190 linhas de código. Essa não é uma boa prática, não pela quantidade de linhas, mas pelo seguinte problema: temos mais de uma responsabilidade executadas em um único arquivo.

Daniel: De certa forma, a causa é essa. O sintoma é a quantidade de linhas. Se precisamos rolar muito o código, temos o chamado code smell, cheiro de que há algum problema.

Quando temos muitas linhas, provavelmente, há mais de uma responsabilidade na classe.

Guilherme: Pensando nos livros famosos de programação, sabemos que a responsabilidade de uma classe deve ser única, assim como a responsabilidade dos atributos de uma classe, ou de um método, que deve realizar apenas uma função.

Ao observar a classe Program.cs, identificamos diversos nomes: temos o método ExibirDetalhes(), o AvaliarUmaBanda(), o ExibirTituloDaOpcao()… Todos eles contidos em uma mesma classe.

Nesse cenário, o desafio é o seguinte: como manter o comportamento da aplicação, ou seja, como manter o código funcionando, mas de uma maneira que fique mais fácil para dar manutenção?

Daniel: Vamos começar a fazer essa melhoria, Guilherme. Podemos tentar fazer com que cada opção executada seja extraída para uma classe.

Iniciaremos pela exibição dos detalhes, isto é, pelo método ExibirDetalhes(). Acessando o Gerenciador de Soluções na lateral direita da tela, vamos criar uma pasta chamada "Menus" em "ScreenSound", que será responsável pelos menus.

Dentro dessa pasta, criaremos uma classe chamada MenuExibirDetalhes.cs. Teremos a estrutura de classe que já conhecemos, e podemos apagar as linhas de 1 a 6, obtendo o seguinte resultado:

```csharp
namespace ScreenSound.Menus;

internal class MenuExibirDetalhes
{
}
```

Feito isso, vamos retornar ao arquivo Program.cs para entender o que podemos fazer. No momento de exibir os detalhes, a partir da linha 55, precisaríamos criar um objeto MenuExibirDetalhes, e para isso seria necessário adicionar o using no início do arquivo.

```csharp
using ScreenSound.Menus;
```

Após o objeto, declaramos a variável menu e criamos a instância. Na linha abaixo, digitaremos a instância do objeto menu junto ao método Executar(), recebendo como parâmetro bandasRegistradas, pois precisaremos da coleção do dicionário.

Nessa etapa, removemos o método ExibirDetalhes() da linha abaixo.

O método Executar() ainda não existe, então podemos usar o Visual Studio para facilitar nosso processo: com o atalho "Ctrl + .", conseguimos pedir para gerar esse método.

Sugestão do Visual Studio:

```csharp
{
    internal void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        throw new NotImplementedException();
    }
}
```

Na sugestão, note que o dicionário é passado como argumento. Após teclar "Enter" na sugestão, teremos o método declarado.

Resultado do bloco de código:

```csharp
/* Código suprimido */
case 5:
    MenuExibirDetalhes menu = new MenuExibirDetalhes();
    menu.Executar(bandasRegistradas);
    break;

/* Código suprimido */
```

Guilherme: A marcação de erro no método Executar() irá sumir e se clicarmos sobre ele com a tecla "Ctrl" pressionada, seremos redirecionados para a declaração no arquivo MenuExibirDetalhes.cs.

namespace ScreenSound.Menus;

```csharp
internal class MenuExibirDetalhes
{
    internal void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        throw new NotImplementedException();
    }
}
```

Daniel: Nesse caso, vamos alterar a visibilidade do método de internal para public, e também vamos remover o bloco throw new NotImplementedException().

namespace ScreenSound.Menus;

```csharp
internal class MenuExibirDetalhes
{
    public void Executar(Dictionary<string, Banda> bandasRegistradas)
    {

    }
}
```

Feito isso, vamos copiar o que está na classe Program.cs e colar no espaço entre chaves. Recortaremos todas as linhas contidas no bloco do método ExibirDetalhes() com o atalho "Ctrl + X", e em seguida teclaremos "Ctrl + V" em MenuExibirDetalhes.cs.

namespace ScreenSound.Menus;

```csharp
internal class MenuExibirDetalhes
{
    public void Executar(Dictionary<string, Banda> bandasRegistradas)
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
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
            ExibirOpcoesDoMenu();
        }
        else
        {
            Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
            ExibirOpcoesDoMenu();
        }
    }
}
```

Precisamos ajustar algumas coisas. Primeiro, o método ExibirTituloDaOpcao() precisa ser visível na classe MenuExibirDetalhes.cs, então vamos criá-lo antes do método Executar().

Guilherme: Para isso, podemos ir até o arquivo Program.cs e copiar da linha de código 126 à 133.

```csharp
void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}
```

Daniel: No caso das instruções ExibirOpcoesDoMenu(), que estão com erro nas linhas de código 32 e 40, vamos apenas removê-las.

namespace ScreenSound.Menus;

```csharp
internal class MenuExibirDetalhes
{
    void ExibirTituloDaOpcao(string titulo)
    {
        int quantidadeDeLetras = titulo.Length;
        string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
        Console.WriteLine(asteriscos);
        Console.WriteLine(titulo);
        Console.WriteLine(asteriscos + "\n");
    }
    public void Executar(Dictionary<string, Banda> bandasRegistradas)
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
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
        else
        {
            Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
```

Dessa forma, nossa classe funciona corretamente!

Guilherme: Agora vamos retornar ao arquivo Program.cs, e na linha de código 59, abaixo do método Executar(), vamos adicionar o método ExibirOpcoesDoMenu().

```csharp
/* Código suprimido */
case 5:
    MenuExibirDetalhes menu = new MenuExibirDetalhes();
    menu.Executar(bandasRegistradas);
    ExibirOpcoesDoMenu();
    break;
/* Código suprimido */
```

Daniel: Além disso, podemos apagar o método ExibirDetalhes(), a partir da linha de código 164, pois ele não está sendo mais usado, conforme indicado pelo sublinhado verde.

Trecho a ser apagado:

```csharp
void ExibirDetalhes()
{

}
```

Guilherme: Exatamente, temos a indicação de que a função declarada nunca é usada.

Daniel: Já conseguimos eliminar algumas linhas do nosso código!

Guilherme: De 190 para 165 já são muitas linhas. Vamos testar para conferir se a função está funcionando corretamente?

Daniel: Com a aplicação aberta, vamos digitar a opção 5 para exibir os detalhes de uma banda:

```csharp
Boas vindas ao Screen Sound 2.0!

Digite 1 para registrar uma banda
Digite 2 para registrar o álbum de uma banda
Digite 3 para mostrar todas as bandas
Digite 4 para avaliar uma banda
Digite 5 para exibir os detalhes de uma banda
Digite -1 para sair

Digite a sua opção: 5
```

Em seguida, precisamos digitar o nome da banda, que será "Ira!":

```csharp
************************
Exibir detalhes da banda
************************

Digite o nome da banda que deseja conhecer melhor: Ira!
```

Por enquanto, será exibida a média da banda, mas depois podemos melhorar os detalhes da resposta.

```csharp
A média da banda Ira! é 8.
Digite uma tecla para voltar ao menu principal
```

Aparentemente, está tudo normal. Pegamos uma instrução que estava em determinado arquivo e levamos para outra classe.

Guilherme: Nós, como pessoas estudantes, podemos fazer isso para as outras classes também? Você recomenda isso nesse momento?

Daniel: Ainda não. Antes, quero trazer mais um recurso que vai nos ajudar a economizar ainda mais em código. Veremos isso no próximo vídeo!

### Aula 3 - Identificando semelhanças - Vídeo 2

Transcrição  
Daniel: Vamos começar a fazer o mesmo processo para outros menus. Começaremos acessando o Gerenciador de Soluções e criando uma nova classe dentro da pasta "Menus".

Chamaremos essa classe de MenuAvaliarBanda.cs e faremos as mesmas alterações, removendo as linhas de 1 a 6 e adicionando ponto e vírgula após o nome do namespace.

```csharp
namespace ScreenSound.Menus;

internal class MenuAvaliarBanda
{
}
```

Entre as chaves da classe MenuAvaliarBanda, teremos um método public void chamado Executar(), e vamos passar para ele a assinatura que está no arquivo MenuExibirDetalhes.cs, na linha de código 16:

```csharp
public void Executar(Dictionary<string, Banda> bandasRegistradas)
```

Copiaremos todo o argumento do método, vamos retornar ao arquivo MenuAvaliarBanda.cs, e colar o trecho entre os parênteses de Executar().

```csharp
namespace ScreenSound.Menus;

internal class MenuAvaliarBanda
{
    public void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
    
    }
}
```

Em seguida, vamos acessar o arquivo Program.cs e recortar com "Ctrl + X" o conteúdo da linha de código 138 à 160, contido no bloco do método AvaliarUmaBanda().

Feito isso, retornaremos ao arquivo MenuAvaliarBanda.cs e usaremos o atalho "Ctrl + V" na linha de código 9.

```csharp
namespace ScreenSound.Menus;

internal class MenuAvaliarBanda
{
    public void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        Console.Clear();
        ExibirTituloDaOpcao("Avaliar banda");
        Console.Write("Digite o nome da banda que deseja avaliar: ");
        string nomeDaBanda = Console.ReadLine()!;
        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            Banda banda = bandasRegistradas[nomeDaBanda];
            Console.Write($"Qual a nota que a banda {nomeDaBanda} merece: ");
            Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);
            banda.AdicionarNota(nota);
            Console.WriteLine($"\nA nota {nota.Nota} foi registrada com sucesso para a banda {nomeDaBanda}");
            Thread.Sleep(2000);
            Console.Clear();
            ExibirOpcoesDoMenu();
        }
        else
        {
            Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
            ExibirOpcoesDoMenu();
        }
    }
}
```

Guilherme: Teremos praticamente os mesmos erros, não é?

Daniel: Sim, os mesmos erros. Vamos fazer os ajustes removendo o ExibirOpcoesDoMenu() das linhas de código 22 e 30. Em seguida, temos a questão do método ExibirTituloDaOpcao(). O que fazer nesse caso?

Guilherme: Agora temos um problema que é um code smell: o método ExibirTituloDaOpcao() será, teoricamente, copiado e colado do arquivo MenuExibirDetalhes.cs para outra classe, sendo a mesma coisa.

Daniel: Teríamos o seguinte resultado:

```csharp
namespace ScreenSound.Menus;

internal class MenuAvaliarBanda
{

    void ExibirTituloDaOpcao(string titulo)
    {
        int quantidadeDeLetras = titulo.Length;
        string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
        Console.WriteLine(asteriscos);
        Console.WriteLine(titulo);
        Console.WriteLine(asteriscos + "\n");
    }

    public void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        Console.Clear();
        ExibirTituloDaOpcao("Avaliar banda");
        Console.Write("Digite o nome da banda que deseja avaliar: ");
        string nomeDaBanda = Console.ReadLine()!;
        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            Banda banda = bandasRegistradas[nomeDaBanda];
            Console.Write($"Qual a nota que a banda {nomeDaBanda} merece: ");
            Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);
            banda.AdicionarNota(nota);
            Console.WriteLine($"\nA nota {nota.Nota} foi registrada com sucesso para a banda {nomeDaBanda}");
            Thread.Sleep(2000);
            Console.Clear();
        }
        else
        {
            Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
```

Guilherme: Isso é um problema. O propósito do método ExibirTituloDaOpcao() é que, ao acessar cada menu, haja um asterisco, o título, e outro asterisco abaixo. Mas e se trocássemos o sinal? E se, no lugar de asterisco, houvesse uma mudança na regra de negócio, a partir da qual foi entendido que o sinal de igual seria melhor?

Nesse caso, teríamos que alterar em todas as classes com o método ExibirTituloDaOpcao() do sinal de asterisco para o sinal de igual.

Daniel: Você falou uma frase que é uma dica para a resolução: todas as classes que tenham o ExibirTituloDaOpcao(), isto é, todas as classes que são menus.

Essa afirmação nos leva a um recurso das linguagens orientadas a objetos: conseguir declarar relações hierárquicas entre classes. Então, podemos dizer que o MenuAvaliarBanda.cs e o MenuExibirDetalhes.cs são menus, conforme o próprio nome diz.

Com isso, podemos criar uma classe chamada Menu.cs e dizer que MenuAvaliarBanda.cs e MenuExibirDetalhes.cs são filhas dessa classe. Esse recurso se chama herança.

Guilherme: Extremamente importante para a orientação a objetos.

Daniel: Sim! Vamos começar a fazer isso no C#, criando uma classe chamada Menu.cs. Como já sabemos, para criar uma classe, acessamos o Gerenciador de Soluções.

Novamente, apagaremos as linhas de 1 a 6 e adicionaremos o ponto e vírgula após o namespace.

```csharp
namespace ScreenSound.Menus;

internal class Menu
{
}
```

Guilherme: Essa classe será a ancestral, correto?

Daniel: Exatamente.

Guilherme: Eu só não entendi ainda como as outras classes vão ser aproveitadas com a herança. Mas veremos isso adiante!

Daniel: Primeiro, vamos recortar com "Ctrl + X" o código de ExibirTituloDaOpcao() do arquivo MenuAvaliarBanda.cs, da linha de código 7 à 14, para a nova classe Menu.cs.

Nesse caso, vamos deixá-lo público, então adicionamos public antes de void.

```csharp
namespace ScreenSound.Menus;

internal class Menu
{
    public void ExibirTituloDaOpcao(string titulo)
    {
        int quantidadeDeLetras = titulo.Length;
        string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
        Console.WriteLine(asteriscos);
        Console.WriteLine(titulo);
        Console.WriteLine(asteriscos + "\n");
    }
}
```

Agora o método ExibirTituloDaOpcao() faz parte da classe Menu.

Retornando ao arquivo MenuAvaliarBanda.cs, teremos um erro no método ExibirTituloDaOpcao().

Guilherme: Porque ele ainda não sabe o que é isso.

Daniel: Sim, para ele, isso ainda não existe. Então, vamos dizer que MenuAvaliarBanda.cs herda as características de Menu.cs. Quando falamos isso, nos referimos a propriedades e métodos, nesse caso, o método ExibirTituloDaOpcao().

Para fazer isso em C#, no final da classe MenuAvaliarBanda, adicionamos dois-pontos (:) seguido de Menu.

Guilherme: Apenas com isso, o arquivo já compreendeu e resolvemos o problema.

Daniel: A leitura feita é de que MenuAvaliarBanda é um Menu.

Guilherme: Vamos retornar ao arquivo Menu.cs para fazer um último teste. Quando falamos em herança e dizemos que uma classe herda de outra, significa que a classe filha terá acesso a todos os métodos, todas as propriedades, e todos os atributos.

Funcionará como uma extensão da classe.

Daniel: Exato. Existe um detalhe: depende da visibilidade que estamos dando na declaração dos ancestrais. Se colocamos, por exemplo, private antes da declaração do método, tornamos ele privado, ou seja, visível apenas entre as chaves das linhas 4 e 13, na declaração da classe Menu.

Dessa forma, retornando ao arquivo MenuAvaliarBanda.cs, ele não conseguirá enxergar e o erro será indicado novamente.

Por isso, mantemos a visibilidade public na classe Menu para garantir acesso geral.

Guilherme: Podemos fazer o mesmo para a classe MenuExibirDetalhes: remover a declaração do método ExibirTituloDaOpcao() e falar que ela herda de Menu.

```csharp
using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuExibirDetalhes : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
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
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
        else
        {
            Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
```

Feito isso, o projeto estará funcionando da mesma forma?

Daniel: No arquivo Program.cs, ainda precisamos apagar o método AvaliarUmaBanda() que deixamos vazio.

Trecho a ser apagado:

```csharp
void AvaliarUmaBanda()
{

}
```

Reduzimos um pouco mais o arquivo Program.cs, agora com 136 linhas.

Além disso, no switch, não temos mais o método AvaliarUmaBanda(). No lugar dele, vamos digitar MenuAvaliarBanda menu4 = new().

Logo abaixo, vamos adicionar o método menu4.Executar(), passando para ele o parâmetro bandasRegistradas. Na linha seguinte, adicionamos o método ExibirOpcoesDoMenu().

```csharp
/* Código suprimido */
case 4:
    MenuAvaliarBanda menu = new()
    menu.Executar(bandasRegistradas);
    ExibirOpcoesDoMenu();
    break;
/* Código suprimido */
```

Vamos aproveitar e alterar a variável menu do bloco de código de case 5 para menu5.

```csharp
/* Código suprimido */

case 5:
    MenuExibirDetalhes menu5 = new()
    menu5.Executar(bandasRegistradas);
    ExibirOpcoesDoMenu();
    break;

/* Código suprimido */
```

Guilherme: Acredito que podemos testar somente uma das opções, como a MenuAvaliarBanda, por exemplo, que ainda não testamos.

Daniel: Certo. Usamos o atalho "Ctrl + F5" para abrir a aplicação. Feito isso, vamos digitar 4 para selecionar a opção de avaliar uma banda:

```csharp
Boas vindas ao Screen Sound 2.0!

Digite 1 para registrar uma banda
Digite 2 para registrar o álbum de uma banda
Digite 3 para mostrar todas as bandas
Digite 4 para avaliar uma banda
Digite 5 para exibir os detalhes de uma banda
Digite -1 para sair

Digite a sua opção: 4
```

Guilherme: Vamos avaliar a banda "Ira!" como nota 10:

```csharp
=============
Avaliar banda
=============

Digite o nome da banda que deseja avaliar: Ira!
Qual a nota que a banda Ira! merece: 10

A nota 10 foi registrada com sucesso para a banda Ira!
```

Daniel: Tudo funcionou corretamente! Agora podemos pedir para você, estudante, criar as opções restantes, usando a ideia de herança. Tudo o que fizemos ao longo desses vídeos, será feito para as outras três opções.

Guilherme: Os cases 3, 2 e 1.

Quando retornarmos, já teremos essas opções feitas!

Daniel: Deixaremos uma atividade com o código resolvido e retornaremos com tudo pronto!

### Aula 3 - Reduzindo mais linhas - Vídeo 3

Transcrição  
Guilherme: Nós criamos uma classe para cada menu restante: MenuRegistrarBanda.cs, MenuRegistrarAlbum.cs, e MenuMostrarBandas.cs.

O código de cada um está disponibilizado na atividade, seguindo os mesmos princípios utilizados anteriormente. Um desses princípios é que toda opção do menu herda de Menu.

Observação: o método ExibirTituloDaOpcao() agora faz parte de Menu.cs, então podemos removê-lo do código de Program.cs.

Trecho a ser removido:

```csharp
void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}
```

Daniel: Apagamos da linha 78 à 88, então reduzimos outras 10 linhas do nosso código.

Guilherme: Fomos de praticamente 200 linhas para 80. É uma grande diferença! Agora os elementos estão isolados. Vamos fazer um teste?

Na classe Menu.cs, perceba que foi usado o sinal de igual (=) na string da linha de código 8. Vamos substituir por qualquer outro sinal, como a cerquilha (#), por exemplo.

```csharp
namespace ScreenSound.Menus;

internal class Menu
{
    public void ExibirTituloDaOpcao(string titulo)
    {
        int quantidadeDeLetras = titulo.Length;
        string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '#');
        Console.WriteLine(asteriscos);
        Console.WriteLine(titulo);
        Console.WriteLine(asteriscos + "\n");
    }
}
```

Daniel: Com "Ctrl + F5", abrimos a aplicação.

Guilherme: Faremos isso apenas para executar e observar que o novo sinal já será aplicado a todas as opções. Vamos testar, por exemplo, a de registrar uma banda:

```csharp
Boas vindas ao Screen Sound 2.0!

Digite 1 para registrar uma banda
Digite 2 para registrar o álbum de uma banda
Digite 3 para mostrar todas as bandas
Digite 4 para avaliar uma banda
Digite 5 para exibir os detalhes de uma banda
Digite -1 para sair

Digite a sua opção: 1
```

Daniel: Já temos as cerquilhas e vamos registrar a banda "Titãs".

```csharp
###################
Registro das bandas
###################

Digite o nome da banda que deseja registrar: Titãs
A banda Titãs foi registrada com sucesso!
```

Guilherme: Agora vamos retornar para o sinal de asterisco (*) e escolher outra opção na aplicação, como a de registrar um álbum, por exemplo.

```csharp
namespace ScreenSound.Menus;

internal class Menu
{
    public void ExibirTituloDaOpcao(string titulo)
    {
        int quantidadeDeLetras = titulo.Length;
        string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
        Console.WriteLine(asteriscos);
        Console.WriteLine(titulo);
        Console.WriteLine(asteriscos + "\n");
    }
}

Boas vindas ao Screen Sound 2.0!

Digite 1 para registrar uma banda
Digite 2 para registrar o álbum de uma banda
Digite 3 para mostrar todas as bandas
Digite 4 para avaliar uma banda
Digite 5 para exibir os detalhes de uma banda
Digite -1 para sair

Digite a sua opção: 2
```

Daniel: Agora teremos os asteriscos em vez das cerquilhas, e vamos registrar um álbum da banda "The Beatles", chamado "White Album".

```csharp
******************
Registro de álbuns
******************

Digite a banda cujo álbum deseja registrar: The Beatles
Agora digite o título do álbum: White Album
O álbum White Album de The Beatles foi registrado com sucesso!
```

Guilherme: Qual é o nosso próximo desafio, Daniel?

Daniel: Acho que podemos diminuir ainda mais a quantidade de linhas do arquivo Program.cs. Repare como os blocos do switch estão parecidos: primeiro é criado o menu, depois é chamado o método Executar(), e por fim temos o método ExibirOpcoesDoMenu().

Além de os descendentes herdarem as características dos ancestrais, existe outra vantagem. Conseguimos criar uma variável do tipo Menu chamada menu, e atribuir qualquer objeto descendente a ela, como o MenuAvaliarBanda(), por exemplo.

```csharp
Menu menu = new MenuAvaliarBanda();
```

Isso é possível pois o MenuAvaliarBanda() faz parte da hierarquia de menu.

Com essa informação em mente, podemos criar um dicionário de menus. A partir disso, tentaremos remover o switch do código de Program.cs.

Vamos manter a variável do tipo Menu antes do bloco switch, pois vamos utilizá-la posteriormente. Depois faremos as melhorias necessárias.

Agora vamos criar um novo dicionário na linha de código 15, abaixo do primeiro Dictionary<>. O tipo da chave desse dicionário será inteiro (int) e o valor será um objeto do tipo Menu. Em seguida, vamos definir o nome como opcoes. Criaremos o dicionário vazio, então digitamos new() após opcoes.

```csharp
Dictionary<int, Menu> opcoes = new();
```

O próximo passo é popular o dicionário. Faremos isso da mesma forma que fizemos com bandasRegistradas: usaremos o método Add() junto a opcoes.

```csharp
Para a opção 1, teremos new MenuRegistrarBanda();
Para a opção 2, new MenuRegistrarAlbum();
Para a opção 3, new MenuMostrarBandas();
Para a opção 4, new MenuAvaliarBanda();
Para a opção 5, new MenuExibirDetalhes();
Para a opção -1, new MenuSair();
Dictionary<int, Menu> opcoes = new();
opcoes.Add(1, new MenuRegistrarBanda());
opcoes.Add(2, new MenuRegistrarAlbum());
opcoes.Add(3, new MenuMostrarBandas());
opcoes.Add(4, new MenuAvaliarBanda());
opcoes.Add(5, new MenuExibirDetalhes());
opcoes.Add(-1, new MenuSair());
```

Agora temos um dicionário de menus!

Feito isso, vamos retornar ao Console.Write() na linha de código 47, acima da variável menu. Suponha que a pessoa escolheu a opção e temos agora a opcaoEscolhidaNumerica. O menu pode ser encontrado através do dicionário opcoes seguido de uma abertura de colchetes contendo a chave opcaoEscolhidaNumerica.

```csharp
/* Código suprimido */
Console.Write("\nDigite a sua opção: ");
string opcaoEscolhida = Console.ReadLine()!;
int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

Menu menu = opcoes[opcaoEscolhidaNumerica];
/* Código suprimido */
```

Guilherme: Vamos entender por partes: nós pegamos a opção que a pessoa digitou, que é um inteiro (int), pegamos o dicionário de menus (opcoes), e falamos para opcoes usar um menu específico, que pode ser o 1, o 2, o 3, e assim por diante. Em seguida, atribuímos toda essa informação a uma variável chamada menu.

Daniel: Exato, estou capturando o objeto que está no dicionário e adicionando à variável.

Guilherme: Essa variável poderia ter outro nome? Por exemplo, menuASerExibido?

Daniel: Sim, vamos alterar.

```csharp
Menu menuASerExibido = opcoes[opcaoEscolhidaNumerica];
```

Precisamos nos lembrar de fazer o seguinte teste: se houver a chave opcaoEscolhidaNumerica dentro do dicionário, conseguiremos capturar o menu na variável menuASerExibido. Para isso, digitamos o bloco if contendo entre parênteses a estrutura opcoes.ContainsKey() que recebe a chave opcaoEscolhidaNumerica.

Se não houver essa chave, ou seja, else, será exibida a mensagem da linha 92 do switch.

```csharp
if (opcoes.ContainsKey(opcaoEscolhidaNumerica))
{
    Menu menuASerExibido = opcoes[opcaoEscolhidaNumerica];
}
else
{
    Console.WriteLine("Opção inválida");
}
```

Agora resta exibir o menu.

Guilherme: Precisamos executá-lo de alguma forma.

Daniel: Para isso, abaixo da declaração da variável menuASerExibido, vamos digitar menuASerExibido chamando o método Executar().

```csharp
if (opcoes.ContainsKey(opcaoEscolhidaNumerica))
{
    Menu menuASerExibido = opcoes[opcaoEscolhidaNumerica];
    menuASerExibido.Executar();
}
else
{
    Console.WriteLine("Opção inválida");
}
```

Porém, o método Executar() não existe no menuASerExibido. O primeiro motivo é que o tipo da variável que capturamos é Menu, e em Menu.cs não existe um método com esse nome.

Guilherme: Nesse caso, temos um problema, porque o Executar() de cada menu é diferente.

Daniel: As instruções que estão dentro do método Executar() são diferentes, mas podemos reparar que a assinatura do método é igual.

Com assinatura, nos referimos ao que aparece para quem estiver consumindo.

Tentaremos usar essa informação para resolver a questão de remover o switch.

### Aula 3 - Removendo o switch - Vídeo 4

Transcrição  
Daniel: Precisamos resolver a questão do arquivo Program.cs, para que uma variável do tipo Menu consiga ser executada.

Vimos que todos os menus têm a mesma declaração do método Executar().

```csharp
public void Executar(Dictionary<string, Banda> bandasRegistradas)
```

A partir disso, vamos copiar essa declaração e colar no ancestral Menu, logo abaixo do método ExibirTituloDaOpcao().

```csharp
using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class Menu
{
    public void ExibirTituloDaOpcao(string titulo)
    {
        int quantidadeDeLetras = titulo.Length;
        string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
        Console.WriteLine(asteriscos);
        Console.WriteLine(titulo);
        Console.WriteLine(asteriscos + "\n");
    }

    public virtual void Executar(Dictionary<string, Banda> bandasRegistradas)
    {

    }
}
```

Com isso, temos um novo erro no arquivo Program.cs: o método Executar() só é reconhecido com argumentos, então vamos passar bandasRegistradas.

```csharp
if (opcoes.ContainsKey(opcaoEscolhidaNumerica))
{
    Menu menuASerExibido = opcoes[opcaoEscolhidaNumerica];
    menuASerExibido.Executar(bandasRegistradas);
}
else
{
    Console.WriteLine("Opção inválida");
}
```

Agora a variável pode ser executada normalmente.

Porém, ainda precisamos fazer algumas alterações. A questão é a seguinte: o arquivo Menu.cs está com o método Executar(); da mesma forma, o arquivo descendente MenuAvaliarBanda.cs, por exemplo, possui esse método, mas com um sublinhado verde indicando erro.

Essa indicação significa que temos o método Executar() no ancestral e esse método com a mesma assinatura no descendente, mas no descendente, é como se estivéssemos criando um novo método e abandonando tudo o que estiver escrito no arquivo ancestral.

Na verdade, queremos aproveitar isso, afinal, estamos falando sobre herdar características. Seria interessante que, ao executar o método Executar(), fosse aproveitado o que já está no ancestral.

Guilherme: O que for comum a todos os métodos Executar() das outras classes, correto?

Daniel: Exatamente!

Guilherme: A ideia é a seguinte: colocaremos algumas coisas no método Executar() da classe ancestral, isto é, do Menu.cs, e todos os outros Executar() que vão herdar esse comportamento, terão partes do Executar() do Menu e partes do Executar() de cada um deles.

Daniel: Isso mesmo! Vamos acessar, por exemplo, a classe MenuAvaliarBanda.cs. O método Executar() dessa classe tem o método Console.Clear(). Da mesma forma, temos esse método em MenuExibirDetalhes.cs.

Guilherme: Vamos começar movendo o Console.Clear() para o arquivo Menu.cs.

Daniel: Para isso, selecionamos o trecho, teclamos "Ctrl + X" para recortar" , e colamos no método Executar().

```csharp
using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class Menu
{
    public void ExibirTituloDaOpcao(string titulo)
    {
        int quantidadeDeLetras = titulo.Length;
        string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
        Console.WriteLine(asteriscos);
        Console.WriteLine(titulo);
        Console.WriteLine(asteriscos + "\n");
    }

    public virtual void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        Console.Clear()
    }
}
```

Dessa forma, todos os menus que chamarem o método Executar() devem limpar o console.

No arquivo MenuExibirDetalhes.cs, precisamos informar que queremos continuar utilizando o que está escrito também no Menu. Então, precisamos dizer que queremos sobrescrever, mas, eventualmente, utilizar o que está no arquivo.

Existe uma palavra reservada que podemos usar para indicar que queremos sobrescrever o método Executar(), chamada override. Vamos adicioná-la após a palavra public da declaração.

```csharp
using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuExibirDetalhes : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {

/* Código suprimido */
```

Feito isso, será indicado um novo erro no método Executar(), porque precisamos indicar no ancestral que ele pode ser sobrescrito. Para isso, temos a palavra reservada virtual. Vamos adicioná-la após o public do método Executar() no arquivo Menu.cs.

```csharp
/* Código suprimido */

    public virtual void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        Console.Clear()
    }
}
```

Assim, dizemos que o método Executar() pode ser sobrescrito pelos seus ancestrais e o código funcionará corretamente.

Há outra coisa que precisamos fazer: para puxar o que está sendo executado na classe Menu.cs, isto é, o método Console.Clear(), precisamos dizer no MenuExibirDetalhes.cs que queremos executar o que está nas bases, nos ancestrais.

Para isso, existe a palavra reservada base que vamos usar para chamar o método Executar(), recebendo como argumento bandasRegistradas.

```csharp
using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuExibirDetalhes : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
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
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
        else
        {
            Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
```

Guilherme: Isso significa que será executado o que está no método do arquivo Menu.cs e também o que está no método que sobrescrevemos.

Daniel: Exato, inclusive na posição indicada no código. Primeiro, conforme indicado na linha 9, é executado o que está na classe Menu.cs, e depois, correspondente à linha 10, é dada continuidade à execução do próprio método Executar() e do ExibirTituloDaOpcao().

Guilherme: Vamos fazer isso em todas as nossas classes. Em todas elas, teremos a palavra reservada override, e no lugar de Console.Clear(), teremos base.Executar(bandasregistradas).

```csharp
MenuAvaliarBanda.cs

using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuAvaliarBanda : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTituloDaOpcao("Avaliar banda");
        Console.Write("Digite o nome da banda que deseja avaliar: ");
        string nomeDaBanda = Console.ReadLine()!;
        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            Banda banda = bandasRegistradas[nomeDaBanda];
            Console.Write($"Qual a nota que a banda {nomeDaBanda} merece: ");
            Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);
            banda.AdicionarNota(nota);
            Console.WriteLine($"\nA nota {nota.Nota} foi registrada com sucesso para a banda {nomeDaBanda}");
            Thread.Sleep(2000);
            Console.Clear();
        }
        else
        {
            Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
```

MenuMostrarBandas.cs

```csharp
using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuMostrarBandas : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTituloDaOpcao("Exibindo todas as bandas registradas na nossa aplicação");

        foreach (string banda in bandasRegistradas.Keys)
        {
            Console.WriteLine($"Banda: {banda}");
        }

        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
    }
}
```

MenuRegistrarAlbum.cs

```csharp
using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuRegistrarAlbum : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
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
        else
        {
            Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
```

MenuRegistrarBanda.cs

```csharp
using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuRegistrarBanda : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTituloDaOpcao("Registro das bandas");
        Console.Write("Digite o nome da banda que deseja registrar: ");
        string nomeDaBanda = Console.ReadLine()!;
        Banda banda = new Banda(nomeDaBanda);
        bandasRegistradas.Add(nomeDaBanda, banda);
        Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
        Thread.Sleep(4000);
        Console.Clear();
    }
}
```

Daniel: No caso do arquivo MenuSair.cs, não queremos que seja feito o Console.Clear() na mensagem "Tchau tchau :)", então não vamos chamar o base.Executar(bandasRegistradas).

MenuSair.cs

```csharp
using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuSair : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        Console.WriteLine("Tchau tchau :)");
    }
}
```

Guilherme: De fato, no console a informação não era limpada. Era apenas retornada a mensagem de "tchau" e depois saíamos da aplicação.

Para conseguirmos testar, faltam apenas alguns detalhes no arquivo Program.cs, além das configurações que já fizemos.

Daniel: Precisamos remover o switch.

Guilherme: Provavelmente, se rodássemos o código como está agora, escolheríamos uma opção e depois iríamos novamente para o switch, pois ele tem o número da opção.

Daniel: Iria executar a opção duas vezes. Então, vamos apagar da linha de código 61 à 95.

Trecho a ser apagado:

```csharp
switch (opcaoEscolhidaNumerica)
{
    case 1:
        MenuRegistrarBanda menu1 = new();
        menu1.Executar(bandasRegistradas);
        ExibirOpcoesDoMenu();
        break;
    case 2:
        MenuRegistrarAlbum menu2 = new();
        menu2.Executar(bandasRegistradas);
        ExibirOpcoesDoMenu();
        break;
    case 3:
        MenuMostrarBandas menu3 = new();
        menu3.Executar(bandasRegistradas);
        ExibirOpcoesDoMenu();
        break;
    case 4:
        MenuAvaliarBanda menu4 = new();
        menu4.Executar(bandasRegistradas);
        ExibirOpcoesDoMenu();
        break;
    case 5:
        MenuExibirDetalhes menu5 = new();
        menu5.Executar(bandasRegistradas);
        ExibirOpcoesDoMenu();
        break;
    case -1:
        MenuSair menu6 = new();
        menu6.Executar(bandasRegistradas);
        break;
    default:
        Console.WriteLine("Opção inválida");
        break;
}
```

Guilherme: Chegamos a um código com 62 linhas no arquivo Program.cs.

Daniel: Agora que reduzimos as linhas de código, precisamos fazer uma última alteração. Após executar o menu (menuASerExibido.Executar()), precisam ser exibidas novamente as opções do menu (ExibirOpcoesDoMenu()).

Porém, isso só será feito se (if) a opção numérica (opcaoEscolhidaNumerica) não for a correspondente ao sair, ou seja, se for maior que zero.

Ao final do bloco if, adicionamos o método ExibirOpcoesDoMenu().

```csharp
/* Código suprimido */
    if (opcoes.ContainsKey(opcaoEscolhidaNumerica))
    {
        Menu menuASerExibido = opcoes[opcaoEscolhidaNumerica];
        menuASerExibido.Executar(bandasRegistradas);
        if (opcaoEscolhidaNumerica > 0) ExibirOpcoesDoMenu();
    } 
    else
    {
        Console.WriteLine("Opção inválida");
    }
}
ExibirOpcoesDoMenu();
```

Agora conseguimos testar. Vamos compilar com o atalho "Ctrl + F5":

```csharp
Boas vindas ao Screen Sound 2.0!

Digite 1 para registrar uma banda
Digite 2 para registrar o álbum de uma banda
Digite 3 para mostrar todas as bandas
Digite 4 para avaliar uma banda
Digite 5 para exibir os detalhes de uma banda
Digite -1 para sair

Digite a sua opção: 
```

Guilherme: Criaremos a banda "U2", então selecionamos a opção 1 para registro de banda:

```csharp
*******************
Registro das bandas
*******************

Digite o nome da banda que deseja registrar: U2
A banda U2 foi registrada com sucesso!
```

Daniel: Após 4 segundos, retornamos para a tela de boas-vindas. Agora vamos registrar um álbum da banda U2 (opção 2), chamado "Joshua Tree".

```csharp
******************
Registro de álbuns
******************

Digite a banda cujo álbum deseja registrar: U2
Agora digite o título do álbum: Joshua Tree
O álbum Joshua Tree de U2 foi registrado com sucesso!
```

Em seguida, vamos selecionar a opção 3 para exibir todas as bandas registradas:

```csharp
*******************************************************
Exibindo todas as bandas registradas na nossa aplicação
*******************************************************

Banda: Ira!
Banda: The Beatles
Banda: U2

Digite uma tecla para voltar ao menu principal
```

Com a opção 4, conseguimos avaliar uma banda. Vamos avaliar o U2 com a nota 10.

```csharp
*************
Avaliar banda
*************

Digite o nome da banda que deseja avaliar: U2
Qual a nota que a banda U2 merece: 10

A nota 10 foi registrada com sucesso para a banda U2
```

Por fim, vamos digitar a opção 5 para exibir detalhes da banda U2:

```csharp
************************
Exibir detalhes da banda
************************

Digite o nome da banda que deseja conhecer melhor: U2

A média da banda U2 é 10.
Digite uma tecla para voltar ao menu principal
```

A opção -1 nos permite sair da aplicação e é retornada a mensagem "Tchau tchau :)".

Guilherme: Com isso, concluímos a última questão de reduzir as linhas de código do arquivo Program.cs, deixando-o mais legível, usando herança para representar os menus da nossa aplicação.

### Aula 3 - Modelando o planeta Pandora - Exercício

No universo dos filmes "Avatar", existem diferentes espécies de seres que habitam o planeta Pandora. Cada espécie possui características únicas e habilidades especiais. A classe SerPandora está escrita no código abaixo:

```csharp
internal class SerPandora
{
    public void Apresentar()
    {
        Console.Write($"\nBoas-vindas ao mundo de Pandora!");
    }
}
```

Representamos duas espécies de Pandora, Banshee e Thanator, com suas respectivas apresentações, conforme ilustrado no código abaixo:

```csharp
internal class Banshee : SerPandora
{
    public void Apresentar()
    {
        Console.WriteLine($"\nFaço parte da espécie Banshee!");
    }
}

internal class Thanator : SerPandora
{
    public void Apresentar()
    {
        Console.WriteLine($"\nEu sou #TeamThanator 0-< ");
    }
}
```

O código a seguir cria dois seres de Pandora, cada um com sua espécie, e os apresenta:

```csharp
SerPandora ser1 = new Banshee();
SerPandora ser2 = new Thanator();

ser1.Apresentar();
ser2.Apresentar();
```

Agora, marque todas as alternativas que modificam as classes para que a execução imprima a seguinte mensagem no console:

```csharp
Boas-vindas ao mundo de Pandora!
Faço parte da espécie Banshee!

Boas-vindas ao mundo de Pandora!
Eu sou #TeamThanator 0-<
```

Selecione 3 alternativas

Resposta, 1:

```csharp
internal class Banshee : SerPandora
{
    public override void Apresentar()
    {
        base.Apresentar();
        Console.WriteLine($"\nFaço parte da espécie Banshee!");
    }
}
```

> Boa! Na classe descendente Banshee sobrescrevemos o método Apresentar() usando a palavra reservada override. E, além disso, chamamos o código do mesmo método em seu ancestral para imprimir as boas-vindas (através do base.Apresentar()).

Resposta, 2:

```csharp
internal class Thanator : SerPandora
{
    public override void Apresentar()
    {
        base.Apresentar();
        Console.WriteLine($"\nEu sou #TeamThanator 0-< ");
    }
}
```

> Muito bem! Na classe descendente Thanator, sobrescrevemos o método Apresentar() usando a palavra reservada override. E, além disso, chamamos o código do mesmo método em seu ancestral para imprimir as boas-vindas (através do base.Apresentar()).

Respostas, 3:

```csharp
internal class SerPandora
{
    public virtual void Apresentar()
    {
        Console.Write($"\nBoas-vindas ao mundo de Pandora!");
    }
}
```

Esse é um passo importante para a resolução do problema. É preciso marcar o método Apresentar() como virtual para que ele possa ser sobrescrito nos descendentes.

### Aula 3 - Desafio: hora da prática

A prática é um elemento essencial ao iniciar os estudos em programação, pois é por meio da aplicação prática dos conceitos teóricos que se solidificam os conhecimentos. Ao escrever código, resolver problemas e construir projetos reais, os iniciantes não apenas internalizam a sintaxe das linguagens de programação, mas também desenvolvem a habilidade de pensar logicamente e abordar desafios de maneira eficiente.

Pensando nisso, criamos uma lista de atividades (não obrigatórias) focada em prática para melhorar ainda mais sua experiência de aprendizagem. Bora praticar, então?

1. Criar uma hierarquia de classes representando formas geométricas, como Quadrado, Círculo e Triângulo. Utilize herança para criar uma classe base chamada FormaGeometrica, que contenha métodos para calcular a área e o perímetro de uma forma.

2. Crie uma hierarquia de classes representando funcionários de uma empresa. Utilize herança para criar classes como Gerente, Programador e Analista. Cada classe deve ter propriedades específicas, além das propriedades comuns a todos os funcionários, como Nome e Salário.

3. Criar uma hierarquia de classes representando contas bancárias, como ContaCorrente e ContaPoupanca. Utilize herança e o conceito de métodos virtuais para implementar um método CalcularSaldo que retorne o saldo atual da conta.

4. Criar uma hierarquia de classes representando animais, como Mamifero, Ave e Peixe. Utilize herança e o conceito de métodos virtuais para implementar um método EmitirSom que represente o som característico de cada tipo de animal.

5. Criar uma hierarquia de classes representando produtos eletrônicos, como Smartphone, Tablet e Laptop. Utilize herança e o conceito de métodos virtuais para implementar um método ExibirInformacoes que retorne informações específicas de cada produto.

Opinião do instrutor

Para te ajudar a verificar seus códigos, disponibilizamos uma lista com as [possíveis soluções no Github](https://github.com/ArthurOcFernandes/Exerc-cios-C-/tree/curso-3-aula-3).

Boa sorte nos estudos!

### Aula 3 - Faça como eu fiz: crie as opções restantes

Atualmente, nossa aplicação possui 2 menus: MenuAvaliarBanda e MenuExibirDetalhes. Esses menus foram criados para encapsular a execução específica de cada menu. Para aproveitar as características comuns a cada menu, utilizamos o recurso de herança criando a classe ancestral Menu e relacionamos as opções concretas com Menu a partir do modelo ClasseDescendente : ClasseAncestral.

Agora é sua vez! Crie classes para as opções restantes:

- Para registrar bandas, implemente a classe MenuRegistrarBanda;
- Para registrar álbuns, construa a classe MenuRegistrarAlbum;
- Para mostrar todas as bandas registradas, crie a classe MenuMostrarBandas;
- Para sair da ScreenSound, crie a classe MenuSair.

Não se esqueça de aplicar herança nas classes acima, dizendo que são filhas de Menu.

Por fim, substitua o código na classe Program.cs para utilizar as opções recém criadas. Ah, e não se esqueça de apagar o código desnecessário. É bastante coisa, mas tenho certeza que você vai mandar bem! Pode ir com calma que eu e Gui te esperamos para os próximos ensinamentos!

Opinião do instrutor

Abaixo, compartilhamos o código das quatro classes que representam as novas opções de menu.

Para a classe MenuRegistrarBanda:

```csharp
using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuRegistrarBanda : Menu
{
    public void Executar(Dictionary<string, Banda> bandasRegistradas)
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
    }
}
```

Para a classe MenuRegistrarAlbum:

```csharp
using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuRegistrarAlbum : Menu
{
    public void Executar(Dictionary<string, Banda> bandasRegistradas)
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
        else
        {
            Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
```

Para a classe MenuMostrarBandas:

```csharp
using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuMostrarBandas : Menu
{
    public void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        Console.Clear();
        ExibirTituloDaOpcao("Exibindo todas as bandas registradas na nossa aplicação");

        foreach (string banda in bandasRegistradas.Keys)
        {
            Console.WriteLine($"Banda: {banda}");
        }

        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
    }
}
```

Para a classe MenuSair:

```csharp
using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuSair : Menu
{
    public void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        Console.WriteLine("Tchau tchau :)");
    }
}
```

Por fim veja como ficou o código do switch no arquivo Program.cs:

```csharp
    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            MenuRegistrarBanda menu1 = new();
            menu1.Executar(bandasRegistradas);
            ExibirOpcoesDoMenu();
            break;
        case 2:
            MenuRegistrarAlbum menu2 = new();
            menu2.Executar(bandasRegistradas);
            ExibirOpcoesDoMenu();
            break;
        case 3:
            MenuMostrarBandas menu3 = new();
            menu3.Executar(bandasRegistradas);
            ExibirOpcoesDoMenu();
            break;
        case 4:
            MenuAvaliarBanda menu4 = new();
            menu4.Executar(bandasRegistradas);
            ExibirOpcoesDoMenu();
            break;
        case 5:
            MenuExibirDetalhes menu5 = new MenuExibirDetalhes();
            menu5.Executar(bandasRegistradas);
            ExibirOpcoesDoMenu();
            break;
        case -1:
            MenuSair menuSair = new();
            menuSair.Executar(bandasRegistradas);
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
```

Pronto! Observe que o arquivo Program.cs teve uma redução de mais de cem linhas de código!

### Aula 3 - O que aprendemos?

Estes foram os pontos principais abordados nesta aula:

- Classes e métodos com muitas linhas são sintomas de códigos que possuem muitas responsabilidades. Isso é ruim porque dificulta a manutenção e legibilidade do seu projeto;

- Aprendemos o conceito de herança, um recurso para compartilhar comportamentos comuns entre classes de mesma hierarquia;

- Na herança, classes ancestrais podem ter comportamentos substituídos ou sobrescritos por seus descendentes. Para indicar essa possibilidade, declaramos o membro no ancestral como virtual, e no descendente que for sobrescrevê-lo, marcamos o membro da classe com override. Se ainda assim quisermos executar a parte de código que estiver no ancestral, usamos a palavra reservada base.

## Aula 4 - Alternativa para anexar semelhanças

### Aula 4 - Projeto da aula anterior

Aqui você pode [baixar o zip da Aula 03](https://github.com/alura-cursos/ScreenSound03/archive/refs/heads/aula-3.zip) ou acessar os [arquivos no Github!](https://github.com/alura-cursos/ScreenSound03)

### Aula 4 - Álbuns e músicas avaliáveis - Vídeo 1

Transcrição  
Daniel: Agora temos os menus e nosso código está mais sucinto. Seria interessante evoluir um pouco mais a aplicação.

Você deve gostar de diferentes bandas, e provavelmente gosta de alguns álbuns delas menos do que gosta de outros. Sendo assim, você poderia querer avaliar álbuns de uma mesma banda de maneira diferente. No nosso sistema, só temos a opção de avaliar bandas, e não álbuns específicos.

Seria legal ter a possibilidade de, por exemplo, dar nota 10 para um determinado álbum do U2 e nota 8 para outro álbum dessa banda. O mesmo vale para músicas específicas, ou seja, poderíamos atribuir notas diferentes para músicas de um mesmo álbum.

Para isso, vamos verificar como a avaliação de uma banda se dá dentro da classe Banda, no arquivo Banda.cs.

Guilherme: Temos uma lista com as notas na linha 6: private List`<Avaliacao>` notas = new List`<Avaliacao>`(). Em seguida, temos a propriedade Media na linha 14, calculada a partir dessa lista. Também temos um método chamado AdicionarNota() que, justamente, adiciona notas a essa lista.

Daniel: São essas as partes do código que fazem parte do cenário de avaliação de bandas. O mesmo valeria para álbuns e músicas específicas. Ou seja, esse seria um comportamento comum que gostaríamos de incluir nas classes Album e Musica.

Conhecemos um recurso que pode nos ajudar nisso: a herança. Vale a pena aplicar esse recurso nesse caso?

Guilherme: No caso dos menus, o próprio nome da classe levava o nome da classe ancestral — como Menu e MenuExibirDetalhes, MenuAvaliarBanda e assim por diante.

No caso atual, queremos que Musica e Album tenham uma classe ancestral, teoricamente, para aproveitar esses comportamentos. Talvez seja difícil pensar em um nome específico para eles.

Daniel: Essa é uma situação muito comum. Nós "forçamos" uma herança apenas para aproveitar um comportamento comum; nesse caso, a possibilidade de avaliação dessas classes.

Mas não temos apenas esse recurso para anexar um comportamento a uma classe. Na orientação a objetos, não apenas no C#, há outro recurso para isso. Vamos entender como ele funciona.

Por exemplo, queremos que álbuns sejam avaliados; então, basta que Album garanta que entregará o método AdicionarNota(), que é público, e a Media, que também é pública.

A lista de notas não é pública, então não é obrigatório solucionar dessa forma.

É como se informássemos a necessidade de garantir que seja entregue a média e o método AdicionarNota(). Funciona como um contrato, e na orientação a objetos, chamamos isso de interface.

Guilherme: Vamos partir para o código, onde criaremos uma interface com esse comportamento. No Gerenciador de Soluções, vamos clicar com o botão direito sobre a pasta "Modelos" e ir até "Adicionar > Classe…".

Agora, em vez de usar a opção "Classe", vamos selecionar o modelo "Interface". Quanto ao nome, por convenção, a Microsoft pede que todas as interfaces sejam iniciadas com a letra "I" maiúscula. Nesse caso, chamaremos de IAvaliavel.cs.

Quando você encontrar um tipo que comece com "I", provavelmente se trata de uma interface.

Daniel: Será criado um arquivo com a seguinte estrutura:

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Modelos;
{
    internal interface IAvaliavel
    {
    }
}
```

Conforme feito anteriormente, vamos apagar as linhas de 1 a 6 e adicionar um ponto e vírgula após o namespace que é ScreenSound.Modelos.

```csharp
namespace ScreenSound.Modelos;

internal interface IAvaliavel
{
}
```

A diferença desse código para os outros está na palavra reservada interface. Essa palavra reservada indica que, dentro da chave, o que teremos não será um código executável, apenas uma assinatura.

Guilherme: Nós não usamos new em interface, correto?

Daniel: Exato, o compilador não permite.

Entre as chaves da interface, temos um método chamado AdicionarNota() que recebe como argumento uma Avaliacao e o parâmetro nota. Dessa vez, finalizamos a linha com ponto e vírgula, e não com abertura de chaves.

```csharp
namespace ScreenSound.Modelos;

internal interface IAvaliavel
{
    void AdicionarNota(Avaliacao nota);
}
```

Guilherme: Mais uma diferença no código.

Daniel: Sim. Existe essa diferença por não ter execução de código dentro da interface. O que fazemos é como se fosse a cláusula de um contrato: para assinar o contrato IAvaliavel.cs, você precisa necessariamente ter um método chamado AdicionarNota() que não retorna nada e que recebe como argumento um objeto do tipo Avaliacao.

Guilherme: Agora falta a Media, certo?

Daniel: Exatamente. A propriedade Media retorna um double e contém get entre chaves. Vamos adicionar isso antes do método AdicionarNota()

```csharp
namespace ScreenSound.Modelos;

internal interface IAvaliavel
{
    double Media { get; }
    void AdicionarNota(Avaliacao nota);
}
```

Essa assinatura de propriedade apenas indica que teremos um método de leitura que irá entregar um double no nome Media.

Guilherme: E como usamos uma interface?

Daniel: Primeiro, vamos dizer que Banda já assina o contrato IAvaliavel.cs, ou seja, que o arquivo Banda.cs implementa a interface IAvaliavel.

Com Banda.cs aberto, na declaração da classe Banda, vamos adicionar dois-pontos (:) e dizer que ela implementa a interface IAvaliavel.

```csharp
namespace ScreenSound.Modelos; 

internal class Banda : IAvaliavel
{

/* Código suprimido */
```

Guilherme: Teoricamente, após fazer isso, nada acontece. O código continuou da mesma forma, justamente porque já implementamos o que é pedido.

Mas e se, por exemplo, removêssemos a Media, da linha 14 à linha 21?

Trecho a ser comentado para teste:

```csharp
public double Media
{
    get
    {
        if (notas.Count == 0) return 0;
        else return notas.Average(a => a.Nota);
    }
}
```

Daniel: Para comentar, selecionamos o trecho e usamos o atalho "Ctrl + K + C".

Guilherme: Com essa alteração, será indicado um erro na interface IAvaliavel.

Daniel: Posicionando o cursor sobre a interface, teremos a indicação de que Banda não implementa o membro de interface IAvaliavel.Media.

Guilherme: Interessante, então a partir do momento em que criamos uma classe e dizemos que ela implementa determinada interface, cada classe pode ter meios diferentes de exibir a média, no nosso caso.

Daniel: Podemos remover o comentário do trecho selecionado, usando o atalho "Ctrl + K + U". Assim, garantimos que a aplicação irá funcionar da mesma forma, sendo possível visualizar a média de uma banda.

Guilherme: Vamos executar apenas para conferir se a média é calculada corretamente.

Daniel: Com "Ctrl + F5", executamos a aplicação.

```csharp
Boas vindas ao Screen Sound 2.0!

Digite 1 para registrar uma banda
Digite 2 para registrar o álbum de uma banda
Digite 3 para mostrar todas as bandas
Digite 4 para avaliar uma banda
Digite 5 para exibir os detalhes de uma banda
Digite -1 para sair

Digite a sua opção: 
```

Guilherme: Podemos selecionar a opção 5 para exibir os detalhes da banda Ira!.

```csharp
************************
Exibir detalhes da banda
************************

Digite o nome da banda que deseja conhecer melhor: Ira!

A média da banda Ira! é 8.
Digite uma tecla para voltar ao menu principal
```

Daniel: A média é exibida normalmente!

Guilherme: Bacana. O próximo desafio é implementar a interface na classe Album, do arquivo Album.cs. Faremos isso no vídeo a seguir!

### Aula 4 - IAvaliavel em álbum e música - Vídeo 2

Transcrição  
Daniel: O desafio agora é implementar a interface IAvaliavel em Album. Ou seja, queremos que álbuns sejam avaliáveis.

Para isso, vamos acessar o arquivo Album.cs e dizer que a classe Album implementa IAvaliavel.

```csharp
namespace ScreenSound.Modelos;

internal class Album : IAvaliavel
{

/* Código suprimido */
```

Guilherme: Feito isso, alguns erros são esperados. Quando posicionamos o cursor sobre IAvaliavel, temos a indicação de que Album não implementa os membros de interface IAvaliavel.AdicionarNota(Avaliacao) e IAvaliavel.Media.

Daniel: Vamos usar o Visual Studio para nos ajudar a resolver esses problemas. Com o erro selecionado, podemos teclar "Ctrl + ." e escolher a primeira opção "Implementar a interface".

Porém, ao fazer isso, será exibido o seguinte trecho na linha de código 17, acima do método AdicionarMusica():

```csharp
public double Media => throw new NotImplementedException();
```

Resolveremos isso mais adiante.

Antes de preencher esse bloco, vamos criar a lista de notas na linha 6, abaixo da lista de musicas. Para isso, digitamos a palavra private seguida do componente List<> do tipo Avaliacao cujo nome é notas. Vamos criá-la vazia, então, new().

```csharp
namespace ScreenSound.Modelos;

internal class Album : IAvaliavel
{
    private List<Musica> musicas = new List<Musica>();
    private List<Avaliacao> notas = new();
```

Guilherme: Agora podemos fazer o mesmo na Media e no método AdicionarNota().

Na Media, em vez de usar o lambda completo, vamos abrir e fechar chaves, e dizer que o método get tem uma construção condicional. Se não houver nenhuma nota cadastrada, ou seja, if (notas.Count ==0), será retornado 0, então return 0.

Caso contrário (else), será retornada a média da propriedade Nota que está no objeto a (return notas.Average(a => a.Nota)).

```csharp
public double Media
{
    get
    {
        if (notas.Count == 0) return 0;
        else return notas.Average(nota => nota.Nota);
    }
}
```

Daniel: Agora que retornamos a média, vamos preencher na linha 33 o código para o método AdicionarNota(). No lugar de throw new NotImplementedException(), vamos usar o método notas.Add() para adicionar um objeto nota na lista.

```csharp
public void AdicionarNota(Avaliacao nota)
{
    notas.Add(nota);
}
```

Guilherme: Assinamos o contrato?

Daniel: Contrato assinado! Porém, não conseguimos testar.

Guilherme: Sim, porque não temos um menu para avaliar de fato um álbum. Nesse caso, avaliamos apenas a banda, correto?

Daniel: Sim, por enquanto, é válido somente a banda no menu. Agora precisamos criar um menu para avaliar álbum. No Gerenciador de Soluções, vamos clicar com o botão direito sobre a pasta "Menus" e ir até "Adicionar > Classe…". Criaremos um menu chamado MenuAvaliarAlbum.cs. Como padrão, vamos remover as linhas de 1 a 6 e adicionar ponto e vírgula ao final do namespace.

A primeira coisa que faremos é informar que a classe MenuAvaliarAlbum herda de Menu.

```csharp
namespace ScreenSound.Menus;

internal class MenuAvaliarAlbum : Menu
{
}
```

Guilherme: O próximo passo é adicionar o método Executar().

Daniel: Sim. É interessante que o Visual Studio nos permite dizer se queremos sobrescrever o método Executar(). Para isso, temos a palavra reservada override. Ao digitá-la, serão sugeridas todas as opções que podemos sobrescrever. São quatro métodos:

Equals();  
Executar();  
GetHashCode();  
ToString();

Explicaremos três deles com mais calma, mas o que buscamos no momento é o Executar(). Quando selecionamos essa opção e teclamos "Enter", automaticamente, é montado o modelo.

```csharp
using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuAvaliarAlbum : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
    }
}
```

Agora resta escrever o código relacionado a avaliar um álbum.

Guilherme: O código é muito semelhante ao de avaliar uma banda. Nesse caso, podemos talvez copiar e colar alguns trechos. Então, vamos acessar o arquivo MenuAvaliarBanda.cs.

Copiaremos da linha 12 à linha 31 e, em seguida, vamos colar abaixo do método Executar(), na linha de código 11.

Trecho a ser copiado:

```csharp
ExibirTituloDaOpcao("Avaliar banda");
Console.Write("Digite o nome da banda que deseja avaliar: ");
string nomeDaBanda = Console.ReadLine()!;
if (bandasRegistradas.ContainsKey(nomeDaBanda))
{
    Banda banda = bandasRegistradas[nomeDaBanda];
    Console.Write($"Qual a nota que a banda {nomeDaBanda} merece: ");
    Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);
    banda.AdicionarNota(nota);
    Console.WriteLine($"\nA nota {nota.Nota} foi registrada com sucesso para a banda {nomeDaBanda}");
    Thread.Sleep(2000);
    Console.Clear();
}
else
{
    Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
    Console.WriteLine("Digite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
}
```

Começaremos alterando de "Avaliar banda" para "Avaliar álbum" na linha 11.

Daniel: Na sequência, precisamos procurar a banda, para depois ser possível encontrar o álbum. Então, vamos manter o Console.Write() do texto "Digite o nome da banda que deseja avaliar". Uma vez encontrada a banda, precisamos encontrar o álbum.

Vamos aproveitar o código de outro menu, o MenuRegistrarAlbum.cs. Há um Console.Write() perguntando o título do álbum, nas linhas 15 e 16.

Trecho a ser copiado:

```csharp
Console.Write("Agora digite o título do álbum: ");
string tituloAlbum = Console.ReadLine()!;
```

Podemos copiar esse trecho e colar após a variável banda na linha 16.

Guilherme: Em seguida, precisamos adicionar o bloco correspondente a se o álbum existir.

Daniel: Exatamente, então if (banda.Albuns.Count > 0).

```csharp
Console.Write("Agora digite o título do álbum: ");
string tituloAlbum = Console.ReadLine()!;
if (banda.Albuns.Count > 0)
{

}
```

Vamos supor que essa condição ainda não está sendo resolvida. Nesse momento, vamos dar continuidade ao código e deixar as etapas mais difíceis para depois.

Em seguida, vamos copiar todo o Console.Write() após a condição if, da linha 24 à 29, e mover para dentro das chaves da condição.

Trecho a ser movido:

```csharp
Console.Write($"Qual a nota que a banda {nomeDaBanda} merece: ");
Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);
banda.AdicionarNota(nota);
Console.WriteLine($"\nA nota {nota.Nota} foi registrada com sucesso para a banda {nomeDaBanda}");
Thread.Sleep(2000);
Console.Clear();
```

Faremos as substituições de "banda" para "álbum" e de nomeDaBanda para tituloAlbum na linha 21. Em seguida, pegaremos a nota a partir do Console.ReadLine(), mas após isso, já precisamos ter o objeto Album que será buscado de algum lugar.

Na linha de código 24, vamos substituir banda por album no método AdicionarNota(), para adicionar a nota ao álbum.

Diremos que a nota foi registrada com sucesso, conforme indicado no código, mas dessa vez para o álbum. Então, substituímos "banda" por "álbum" e nomeDaBanda por tituloAlbum.

No momento, temos o seguinte código:

MenuAvaliarAlbum.cs

```csharp
using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuAvaliarAlbum : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);

        ExibirTituloDaOpcao("Avaliar álbum");
        Console.Write("Digite o nome da banda que deseja avaliar: ");
        string nomeDaBanda = Console.ReadLine()!;
        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            Banda banda = bandasRegistradas[nomeDaBanda];
            Console.Write("Agora digite o título do álbum: ");
            string tituloAlbum = Console.ReadLine()!;
            if (banda.Albuns.Count > 0)
            {
                Console.Write($"Qual a nota que o álbum {tituloAlbum} merece: ");
                Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);
                Album album = ???
                album.AdicionarNota(nota);
                Console.WriteLine($"\nA nota {nota.Nota} foi registrada com sucesso para o álbum {tituloAlbum}");
                Thread.Sleep(2000);
                Console.Clear();
            } 
        }
        else
        {
            Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
```

Temos duas coisas importantes no código acima: primeiro precisamos saber se o álbum existe na lista de bandas, o que ainda não sabemos fazer; e depois precisamos colocar o album em uma variável do tipo Album.

Faremos isso no próximo vídeo!

### Aula 4 - Menu para avaliar álbum - Vídeo 3

Transcrição  
Daniel: Temos dois desafios nesse momento: primeiro, precisamos encontrar o álbum na lista de álbuns da banda, ou seja, verificar se o tituloAlbum da linha 18 existe nessa lista; segundo, precisamos pegar esse objeto.

Para isso, existem várias alternativas, mas vamos usar a seguinte: primeiramente, removemos a condição Count > 0, pois não queremos entrar na condição if se existir algo, e sim se o tituloAlbum existir na lista de álbuns da banda.

Nesse caso, usamos a operação Any(a => a.Nome.Equals(tituloAlbum) para indicar que entraremos no bloco if se existir algum álbum (Any(a => a)) cujo nome seja igual (Nome.Equals()) ao título digitado (tituloAlbum).

```csharp
if (banda.Albuns.Any(a => a.Nome.Equals(tituloAlbum)))
```

Agora podemos pegar esse objeto que já sabemos existir na lista de álbuns. Vamos copiar a linha de código 23, recortá-la e movê-la para a primeira posição no bloco if, na linha 21.

Feito isso, após o sinal de igual, vamos adicionar banda.Albuns.First() para pegar o primeiro álbum da lista que atenda à condição digitada no if, que passaremos também para o First().

```csharp
if (banda.Albuns.Any(a => a.Nome.Equals(tituloAlbum)))
{
    Album album = banda.Albuns.First(a => a.Nome.Equals(tituloAlbum));
    Console.Write($"Qual a nota que o álbum {tituloAlbum} merece: ");
    Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);
    album.AdicionarNota(nota);
    Console.WriteLine($"\nA nota {nota.Nota} foi registrada com sucesso para o álbum {tituloAlbum}");
    Thread.Sleep(2000);
    Console.Clear();
} 
```

Com isso, pegamos o objeto que representa o título e aplicamos à variável album.

Guilherme: Você trouxe o álbum de fato que queremos avaliar, correto?

Daniel: Sim. Após pegar o álbum, temos a pergunta sobre a nota que ele merece, obtemos a nota digitada, e adicionamos usando o método AdicionarNota(), construído de modo que o Album implementasse a partir da interface IAvaliavel.

Na sequência, é exibido que o registro foi feito com sucesso para o álbum, após dois segundos, a tela da aplicação é limpa.

Agora resta adicionar um bloco else, para indicar o cenário em que o álbum não existe na lista. Nesse caso, podemos copiar as linhas 37 a 40 e fazer o ajuste necessário: "O álbum {tituloAlbum} não foi encontrado!".

Trecho a ser copiado:

```csharp
Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
Console.WriteLine("Digite uma tecla para voltar ao menu principal");
Console.ReadKey();
Console.Clear();
```

Abaixo, o resultado do código de MenuAvaliarAlbum.cs:

```csharp
using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuAvaliarAlbum : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);

        ExibirTituloDaOpcao("Avaliar álbum");
        Console.Write("Digite o nome da banda que deseja avaliar: ");
        string nomeDaBanda = Console.ReadLine()!;
        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            Banda banda = bandasRegistradas[nomeDaBanda];

            Console.Write("Agora digite o título do álbum: ");
            string tituloAlbum = Console.ReadLine()!;

            if (banda.Albuns.Any(a => a.Nome.Equals(tituloAlbum)))
            {
                Album album = banda.Albuns.First(a => a.Nome.Equals(tituloAlbum));
                Console.Write($"Qual a nota que o álbum {tituloAlbum} merece: ");
                Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);
                album.AdicionarNota(nota);
                Console.WriteLine($"\nA nota {nota.Nota} foi registrada com sucesso para o álbum {tituloAlbum}");
                Thread.Sleep(2000);
                Console.Clear();
            } 
            else
            {
                Console.WriteLine($"\nO álbum {tituloAlbum} não foi encontrado!");
                Console.WriteLine("Digite uma tecla para voltar ao menu principal");
                Console.ReadKey();
                Console.Clear();
            }
        }
        else
        {
            Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }

    }
}
```

Dessa forma, conseguimos avaliar álbuns além das bandas. O que falta agora?

Guilherme: Provavelmente, falta ajustar as opções disponíveis no menu inicial, pois teremos uma a mais, a de avaliar álbum.

Daniel: Exato, nós apenas criamos a classe. Agora precisamos ir ao arquivo Program.cs e usar o método opcoes.Add() para adicionar a opção 6. Vamos usar o new para dizer que agora existe a opção MenuAvaliarAlbum().

Guilherme: Com base na ordem das opções do menu, faria sentido que a opção MenuAvaliarAlbum() viesse na posição 5, após a opção MenuAvaliarBanda(). Fazendo essa alteração, chegamos ao seguinte resultado:

```csharp
Dictionary<int, Menu> opcoes = new();
opcoes.Add(1, new MenuRegistrarBanda());
opcoes.Add(2, new MenuRegistrarAlbum());
opcoes.Add(3, new MenuMostrarBandas());
opcoes.Add(4, new MenuAvaliarBanda());
opcoes.Add(5, new MenuAvaliarAlbum());
opcoes.Add(6, new MenuExibirDetalhes());
opcoes.Add(-1, new MenuSair());
```

Em seguida, vamos até a parte do código de Program.cs onde é exibida a lista do menu, no método ExibirOpcoesDoMenu() da linha 38. Precisamos adicionar o Console.WriteLine() da nova opção de avaliar álbum.

Daniel: Podemos copiar a linha de cima e fazer os ajustes necessários. O texto será "Digite 5 para avaliar um álbum", e precisamos também alterar o Console.WriteLine() de exibir os detalhes de uma banda para corresponder à opção 6.

```csharp
void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para registrar o álbum de uma banda");
    Console.WriteLine("Digite 3 para mostrar todas as bandas");
    Console.WriteLine("Digite 4 para avaliar uma banda");
    Console.WriteLine("Digite 5 para avaliar um álbum");
    Console.WriteLine("Digite 6 para exibir os detalhes de uma banda");
    Console.WriteLine("Digite -1 para sair");
```

É interessante que, após adicionar ao dicionário, não precisamos mais nos preocupar com o que é feito na condição if da linha 53.

Guilherme: Exato, não precisamos criar um if/else para essa condição específica.

Daniel: Agora vamos testar. Com "Ctrl + F5", iniciamos a aplicação.

```csharp
Boas vindas ao Screen Sound 2.0!

Digite 1 para registrar uma banda
Digite 2 para registrar o álbum de uma banda
Digite 3 para mostrar todas as bandas
Digite 4 para avaliar uma banda
Digite 5 para exibir os detalhes de uma banda
Digite -1 para sair

Digite a sua opção: 
```

Guilherme: No momento, ainda não temos álbuns registrados, então vamos usar a opção 2 para registrar um álbum da banda Ira!, como "ABC", por exemplo.

```csharp
******************
Registro de álbuns
******************

Digite a banda cujo álbum deseja registrar: Ira!
Agora digite o título do álbum: ABC
O álbum ABC de Ira! foi registrado com sucesso!
```

Daniel: Após registrar o álbum, vamos avaliá-lo (opção 5).

```csharp
*************
Avaliar álbum
*************

Digite o nome da banda que deseja avaliar: Ira!
Agora digite o título do álbum: ABC
Qual a nota que o álbum ABC merece: 10

A nota 10 foi registrada com sucesso para o álbum banda ABC
```

Ao exibir os detalhes de uma banda, não temos as informações referentes ao álbum. Nesse caso, não seria possível mostrar a média do álbum, pois não trabalhamos nesse código até o momento.

Guilherme: Faremos isso na sequência!

### Aula 4 - Completando o novo menu - Vídeo 4

Transcrição  
Guilherme: Resta concluir a opção de exibir detalhes da banda, pois em nenhum momento mostramos a média dos álbuns registrados.

Daniel: Vamos analisar o estado atual da classe MenuExibirDetalhes.

```csharp
using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuExibirDetalhes : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
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
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
        else
        {
            Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
```

Guilherme: Note que temos um espaço reservado para completar a função na linha 17.

Daniel: Nesse momento, exibimos somente a média da banda.

Guilherme: A ideia é exibir a média de cada álbum registrado para determinada banda. Por exemplo: se a banda Ira! tem três álbuns registrados, exibiremos a média de cada um.

Daniel: Exato. Para isso, nós podemos usar a instrução foreach() para cada álbum (Album album) que estiver nos álbuns da banda (in banda.Albuns).

Entre as chaves, vamos adicionar o método Console.WriteLine(), que será usado para exibir o nome do álbum (album.Nome) e a média do álbum (album.Media)

```csharp
foreach(Album album in banda.Albuns)
{
    Console.WriteLine($"{album.Nome} -> {album.Media}");
}
```

Vamos aproveitar para adicionar um espaço (\n) antes do texto "Digite uma tecla para voltar ao menu principal", na linha de código 21. Além disso, antes de exibir os álbuns, podemos adicionar um Console.WriteLine() para escrever "Discografia:".

Abaixo, o resultado do código de MenuExibirDetalhes.cs:

```csharp
using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuExibirDetalhes : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTituloDaOpcao("Exibir detalhes da banda");
        Console.Write("Digite o nome da banda que deseja conhecer melhor: ");
        string nomeDaBanda = Console.ReadLine()!;
        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            Banda banda = bandasRegistradas[nomeDaBanda];
            Console.WriteLine($"\nA média da banda {nomeDaBanda} é {banda.Media}.");
            Console.WriteLine("\nDiscografia:");
            foreach(Album album in banda.Albuns)
            {
                Console.WriteLine($"{album.Nome} -> {album.Media}");
            }
            Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
        else
        {
            Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
```

Guilherme: Podemos começar o teste registrando três álbuns da banda Ira!.

Daniel: Sim, mas antes de iniciar, é importante destacar que, para fazer a alteração no menu MenuExibirDetalhes, só fizemos ajustes no código do método Executar().

Nessa etapa, não precisamos mexer no arquivo Program.cs. Essa é uma das grandes vantagens de separar cada elemento do projeto em suas próprias classes e arquivos.

Vamos partir para os testes?

Guilherme: Vamos lá! Usamos o atalho "Ctrl + F5" para abrir a aplicação:

```csharp
Boas vindas ao Screen Sound 2.0!

Digite 1 para registrar uma banda
Digite 2 para registrar o álbum de uma banda
Digite 3 para mostrar todas as bandas
Digite 4 para avaliar uma banda
Digite 5 para exibir os detalhes de uma banda
Digite -1 para sair

Digite a sua opção: 
```

Daniel: Para registrar álbuns, usamos a opção 2. Faremos o registro de um álbum da banda Ira!, o "Isso é amor".

```csharp
******************
Registro de álbuns
******************

Digite a banda cujo álbum deseja registrar: Ira!
Agora digite o título do álbum: Isso é amor
O álbum Isso é amor de Ira! foi registrado com sucesso!
```

Guilherme: O próximo álbum também pode ser do Ira!, chamado "Clandestino". Por último, vamos registrar o álbum "Invisível DJ", também da banda Ira!.

Uma dúvida: se pedirmos para exibir os detalhes da banda Ira! nesse momento, como ainda não há nenhuma nota registrada para os álbuns, a média de cada um seria 0.

Vamos observar isso na prática?

Daniel: Selecionamos a opção 6 para exibir detalhes da banda:

```csharp
************************
Exibir detalhes da banda
************************

Digite o nome da banda que deseja conhecer melhor: Ira!

A média da banda Ira! é 8.

Discografia:

Isso é amor -> 0
Clandestino -> 0
Invisível DJ -> 0

Digite uma tecla para voltar ao menu principal
```

Guilherme: Funcionou corretamente a questão de quando não há nenhuma nota registrada. Agora vamos atribuir duas notas diferentes ao álbum "Clandestino", 10 e 8, por exemplo.

Conforme definido, escolhemos a opção 5 para avaliar um álbum.

Daniel: Feito isso, vamos pedir para exibir os detalhes da banda Ira! novamente.

```csharp
************************
Exibir detalhes da banda
************************

Digite o nome da banda que deseja conhecer melhor: Ira!

A média da banda Ira! é 8.

Discografia:

Isso é amor -> 0
Clandestino -> 9
Invisível DJ -> 0

Digite uma tecla para voltar ao menu principal
```

Guilherme: Funcionou corretamente e agora temos a média do álbum. Provavelmente, funcionará da mesma forma para os outros álbuns.

Daniel: Muito bem, Gui. Fizemos com que os álbuns também pudessem ser avaliados, ou seja, implementamos a interface IAvaliavel, e também colocamos isso na nossa aplicação. Agora conseguimos registrar um álbum, avaliá-lo, e visualizar os detalhes com a média do álbum.

Caso queira, você pode fazer o mesmo para cada uma das músicas do álbum. O processo é muito semelhante, precisamos apenas implementar a interface IAvaliavel e criar os respectivos menus.

Conhecemos mais um recurso para anexar comportamentos às classes!

continuar lendo

### Aula 4 - Para saber mais: ancestral-raiz

Em um dos vídeos, sobrescrevemos o método Executar(), declarado em Menu, usando um atalho do Visual Studio em que digitamos a palavra override, seguida de um espaço. Isso resulta na apresentação de todos os métodos que podem ser sobrescritos. Neste momento, apareceram dois métodos que não havíamos utilizado e outro já conhecido: ToString(), GetHashCode() e Equals(). Afinal, de onde vêm esses métodos, uma vez que não estão declarados no seu único ancestral, Menu?

Na verdade, todas as classes herdam de um “ancestral-raiz”: a classe Object. Podemos dizer que objetos criados a partir de qualquer classe são Object. E é nessa classe que estão declarados esses três métodos.

Para que serve cada um desses métodos?

- O método ToString() pode ser utilizado para gerar uma representação textual do tipo cujo objeto pertence. A implementação padrão existente em Object somente imprime o nome do tipo. Lembra daquela vez que corrigimos a nota para exibir o valor porque estava exibindo um texto “estranho”, ScreenSound.Modelos.Avaliacao? Pois é, tal texto estranho é a implementação padrão de ToString(), o nome do tipo do objeto. Podemos sobrescrever esse método para retornar um texto mais significativo.

- O método Equals() retorna um valor booleano para indicar se o objeto é equivalente a outro passado como argumento do método. Podemos sobrescrever esse método para representar uma nova lógica de equivalência.

- O método GetHashCode() é usado em conjunto com a sobrescrita de Equals(). Em algumas coleções, usamos um código hash para identificar o objeto no conjunto. Se a condição de igualdade for alterada, é preciso também alterar o código identificador para o objeto.

> No repositório do Github, [deixei uma versão da classe de avaliações](https://github.com/alura-cursos/ScreenSound03/blob/aula-4/ScreenSound/Modelos/AvaliacaoComSobrescrita.cs), chamada AvaliacaoComSobrescrita, com os três métodos de Object como referência para você.

### Aula 4 - Modelando o acesso a um prédio - Exercício

Em um sistema de registro de acesso a um prédio comercial existem três formas de entrada:

Como um representante de uma empresa que entrega encomendas, alimentos, dentre outros itens;

Como uma pessoa colaboradora que trabalha no prédio; neste caso, essa pessoa já possui um identificador de acesso; ou

Como uma pessoa visitante; aqui registra-se nome, documento e sala onde a visita será feita.

Marcelo vem estudando C# até aqui e criou o código abaixo com classes que representam esses tipos de acesso:

```csharp
namespace RegistroDeAcesso.Modelos;

internal class Colaborador
{
    public Colaborador(int idAcesso)
    {
        IdAcesso = idAcesso;
    }

    public int IdAcesso { get; }
}

internal class Entrega
{
    public Entrega(string representante)
    {
        Representante = representante;
    }

    public string Representante { get; }
}

internal class Visitante
{
    public Visitante(string nome, string documento, string sala)
    {
        Nome = nome;
        Documento = documento;
        Sala = sala;
    }

    public string Nome { get; }
    public string Documento { get; }
    public string Sala { get; }
}
```

Além disso, Marcelo criou um módulo que imprime o registro e impressão de entradas no mês. Ele criou a classe que simboliza o registro:

```csharp
namespace RegistroDeAcesso.Relatorios;

internal class AcessoAoPredio
{
    public AcessoAoPredio(DateTime entrada, string resumo)
    {
        Entrada = entrada;
        Resumo = resumo;
    }

    public DateTime Entrada { get; }
    public string Resumo { get; }
}
```

Contudo, ficou na dúvida sobre como implementar a classe com o relatório mensal. Ele chegou até este ponto:

```csharp
namespace RegistroDeAcesso.Relatorios;

internal class RelatorioDeAcesso
{
    private List<AcessoAoPredio> acessos = new();

    public void RegistrarEntrada(??? entrada)
    {
        acessos.Add(new AcessoAoPredio(DateTime.Now, ???));
    }

    public void ExibirRegistroDoMes()
    {
        Console.WriteLine("Acessos registrados no mês:");
        foreach (var acesso in acessos)
        {
            Console.WriteLine($"- {acesso.Resumo} em {acesso.Entrada}");
        }
    }
}
```

Observe que a classe RelatorioDeAcesso está incompleta no método RegistrarEntrada(). Marcelo precisa garantir que todos os tipos de acesso sejam aceitos como argumentos deste método para que o código de exemplo listado abaixo funcione:

```csharp
using RegistroDeAcesso.Modelos;
using RegistroDeAcesso.Relatorios;

Entrega entregaDePizza = new Entrega(representante: "Marcela");
Colaborador joseDaAlura = new Colaborador(idAcesso: 25);
Colaborador mariaDaAcme = new Colaborador(idAcesso: 14);
Visitante filhoDeMaria = new Visitante(nome: "Pedro", documento: "12938732", sala: "1002");

RelatorioDeAcesso acessoMensal = new RelatorioDeAcesso();
acessoMensal.RegistrarEntrada(entregaDePizza);
acessoMensal.RegistrarEntrada(joseDaAlura);
acessoMensal.RegistrarEntrada(mariaDaAcme);
acessoMensal.RegistrarEntrada(filhoDeMaria);

// ao final do mês...
acessoMensal.ExibirRegistroDoMes();
```

Sabendo disso, analise as alternativas abaixo e marque somente aquela que irá completar o código do sistema e fazer com que o código de exemplo compile.

Selecione uma alternativa

Resposta:  
Criar uma interface que representa a informação de acesso.

```csharp
internal interface IResumoAcesso
{
string Resumo { get; }
}
```

Fazer com que os tipos de acesso a implementem. Por fim, usar o tipo IResumoAcesso como argumento do método RegistrarEntrada().

> Com uma interface criamos uma extensão que exige que todas implementações obrigatoriamente forneçam um texto com o resumo do acesso. O mais legal desta solução é que novos tipos de acesso podem ser acrescentados sem impacto no módulo de relatórios. Deixei o código com a resolução deste exercício neste repositório.

### Aula 4 - Desafio: hora da prática

A prática é um elemento essencial ao iniciar os estudos em programação, pois é por meio da aplicação prática dos conceitos teóricos que se solidificam os conhecimentos. Ao escrever código, resolver problemas e construir projetos reais, os iniciantes não apenas internalizam a sintaxe das linguagens de programação, mas também desenvolvem a habilidade de pensar logicamente e abordar desafios de maneira eficiente.

Pensando nisso, criamos uma lista de atividades (não obrigatórias) focada em prática para melhorar ainda mais sua experiência de aprendizagem. Bora praticar, então?

1. Criar uma interface chamada IForma que declare métodos para calcular a área e o perímetro de uma forma geométrica. Implemente esta interface em duas classes: Circulo e Retangulo.

2. Criar duas interfaces adicionais, IPilotavel e IVoavel. Implemente essas interfaces na classe Veiculo.

3. Criar uma interface chamada IPagavel com um método CalcularPagamento. Implemente essa interface em duas classes, Produto e Servico. O método CalcularPagamento deve retornar o valor total a ser pago, levando em consideração a quantidade para produtos e a taxa horária para serviços.

4. Criar uma interface chamada INotificavel com um método EnviarNotificacao. Implemente essa interface em duas classes, Email e SMS. O método EnviarNotificacao deve exibir mensagens diferentes para cada tipo de notificação.

5. Criar uma interface chamada IArmazenavel com métodos Salvar e Recuperar. Implemente essa interface em duas classes, Arquivo e BancoDeDados. Os métodos Salvar e Recuperar devem exibir mensagens simulando a ação de salvar e recuperar dados.

Opinião do instrutor

Para te ajudar a verificar seus códigos, disponibilizamos uma lista com as [possíveis soluções no Github](https://github.com/ArthurOcFernandes/Exerc-cios-C-/tree/curso-3-aula-4).

Boa sorte nos estudos!

### Aula 4 - Faça como eu fiz: protegendo nossa lógica

Abra a classe Banda e observe o tipo da propriedade Albuns. Está declarada como List<Album>. Ela de fato representa uma lista de álbuns, mas existe um problema nesta declaração: o método AdicionarAlbum() é usado para adicionar álbuns à banda, porém na documentação da classe List vemos que ela também possui um método Add(). E isso faz com que os consumidores de Banda consigam fazer isso:

```csharp
Banda beatles = new Banda(“The Beatles”);
beatles.Albuns.Add(new Album(“White Album”)); // não era para usar AdicionarAlbum?
```

Se você tivesse investido algumas horas codando uma regra de negócio que impedisse que qualquer álbum fosse incluído numa banda, infelizmente preciso comunicar que você perdeu tempo. E a causa desta brecha é a declaração da propriedade como List`<Album>`. Toda List tem o método Add(), não tem jeito!

E nada é ruim que não possa piorar! Veja o absurdo que o hacker fez:

```csharp
Banda beatles = new Banda(“The Beatles”);
beatles.AdicionarAlbum(new Album(“White Album”));
beatles.AdicionarAlbum(new Album(“Revolver”));
beatles.AdicionarAlbum(new Album(“Abbey Road”));

beatles.Albuns.Clear(); // nãaaaao!
```

Ele simplesmente apagou da história álbuns clássicos e revolucionários dos Beatles. Tudo porque List possui o método Clear(), que limpa todos os elementos de uma lista.

Muito bem, Daniel, me convenceu. Mas qual a solução? Usar outro tipo para representar esta propriedade. E é aqui que as interfaces brilham. Quando declaramos um tipo como uma interface escondemos o como ela está sendo implementada. Para este cenário, a recomendação é declarar a propriedade Album como IEnumerable`<Album>`, e deixar o campo interno como uma List, porque List implementa tal interface. Quando fizermos isso, o código do hacker não vai mais compilar. Rá, te peguei!

Agora é sua vez! Troque todas as propriedades públicas que retornam List por IEnumerable.

Opinião do instrutor

Veja como seria a implementação da classe Banda:

```csharp
internal class Banda
{
    private List<Avaliacao> notas = new List<Avaliacao>();

// código omitido

public IEnumerable<Album> Albuns => albuns;
}
```

Sugerimos também a consulta à [documentação sobre List](https://learn.microsoft.com/pt-br/dotnet/api/system.collections.generic.list-1) e à [documentação sobre IEnumerable](https://learn.microsoft.com/pt-br/dotnet/api/system.collections.generic.ienumerable-1).

### Aula 4 - O que aprendemos?

Estes foram os pontos principais abordados nesta aula:

Herança não é a única maneira de incluir comportamentos e características comuns a um tipo.

> Interfaces são tipos mais leves e mais abstratos que podem ser usados para garantir que tipos de hierarquias diferentes implementem os mesmos métodos e propriedades;

Interfaces não possuem código concreto e não podem ser instanciadas através de new.

## Aula 5 - Desafio: implementar API do ChatGPT

### Aula 5 - Projeto da aula anterior

Aqui você pode [baixar o zip da Aula 04](https://github.com/alura-cursos/ScreenSound03/archive/refs/heads/aula-4.zip) ou acessar os [arquivos no Github!](https://github.com/alura-cursos/ScreenSound03/tree/aula-4/ScreenSound)

### Aula 4 - Precificação da OpenAI

🚨 Aviso importante sobre mudanças na precificação da OpenAI
Nos próximos vídeos, utilizaremos a API da OpenAI para geração de textos. A OpenAI, responsável pelo ChatGPT, é uma das maiores referências em inteligência artificial no mundo. No mercado de trabalho, o uso de IA está se tornando cada vez mais requisitado, seja para automação de processos ou até mesmo apoio em tarefas rotineiras.

Mas é importante dizer que adicionar a API da OpenAI ao projeto do curso é uma etapa opcional que claro, deixa seu projeto mais completo. No entanto, caso não queira investir nisso, tudo bem. Pular essa etapa não afetará seu progresso no curso. Mas, caso queira deixar seu projeto com maiores funcionalidades como buscar automaticamente uma descrição para banda, leia as orientações abaixo.

**Mudança na política de preços da OpenAI**  
Quando este curso foi desenvolvido, a OpenAI oferecia um free tier, ou seja, um nível gratuito que permitia um número limitado de requisições sem custo. No entanto, a OpenAI alterou seus termos e desativou esse modelo gratuito.

Agora, é necessário um pagamento mínimo de US$ 5 para ativar o uso da API, mesmo no nível mais básico.

**Como isso impacta você?**  

- O pagamento é feito via cartão de crédito, que deve ser [cadastrado na OpenAI](https://platform.openai.com/settings/organization/billing/overview).
- O valor mínimo de US$ 5 em créditos será suficiente para acompanhar o curso.
- A OpenAI cobra por tokens utilizados, não por requisições. Tokens representam fragmentos de texto processado.

Após o esgotamento dos créditos, você pode decidir se deseja adicionar mais saldo ou interromper o uso.

**Controle de custos**  

- Você pode definir um orçamento mensal nas [configurações de cobrança](https://platform.openai.com/settings/organization/limits).
- Para evitar cobranças inesperadas, desative a recarga automática (auto recharge). Ou seja, quando seu saldo de créditos atingir $0, suas solicitações de API deixarão de funcionar.
- Consulte os [limites de uso](https://platform.openai.com/organization/usage) e os [preços atualizados](https://openai.com/api/pricing/).

> ⚠️ Reforçamos que essa cobrança é uma política exclusiva da OpenAI, não tem relação com a Alura. Defina seus limites para evitar gastos inesperados.

### Aula 4 - Desafio - Vídeo 1

Transcrição  
Guilherme: Nesse curso, estamos trazendo cenários e situações que acontecem no cotidiano da pessoa profissional em desenvolvimento de software e programação.

Algo comum é quando um projeto, desenvolvido pela equipe interna, é integrado a uma solução de outro time, que às vezes nem utiliza a mesma linguagem.

Simularemos uma situação semelhante. Utilizaremos a Inteligência Artificial no nosso projeto para criar uma descrição quando a banda for criada.

Daniel: Vamos descobrir como podemos fazer isso usando o ChatGPT. Para isso, abrimos o navegador e acessamos o Chat OpenAI. Feito isso, escrevemos o seguinte prompt:

Resuma a banda Ira! em um parágrafo. Adote um estilo informal.

Temos o seguinte retorno:

Ah, Ira!, mano, que banda massa! Formada lá nos anos 80, esses caras são pura energia e atitude. Com um som que mistura rock, pop e punk, eles arrebentam nos palcos e nas letras. Edgard Scandurra, o guitarrista, manda muito bem nos riffs, enquanto Nasi, o vocalista, tem uma voz poderosa que te arrepia. Os caras falam de amor, de protesto e das coisas da vida de um jeito único, fazendo a galera se identificar e cantar junto, Ira! é daquelas bandas que deixam saudade, sabe? Não tem como resistir ao som desses ícones do rock nacional.

Guilherme: Gostei muito do retorno!

Daniel: É exatamente isso que queremos, utilizar esse resumo quando formos exibir uma banda.

Guilherme: Antes de mostrarmos onde colocaremos as informações, precisamos nos conectar com o ChatGPT, certo?

Daniel: Sim! Além disso, é importante lembrar que essa aplicação não é valida apenas para o ChatGPT e sim para qualquer tipo de biblioteca que quisermos integrar na aplicação.

Para utilizar o ChatGPT, precisamos criar uma conta gratuita na plataforma utilizando e-mail, celular e senha. Feito isso, a ferramenta fica disponível para uso durante três meses. Caso você tenha criado uma conta anteriormente, fique atento a data.

O segundo passo é criar a API Key, ou seja, uma chave para podermos utilizar na integração. Para isso, logado na OpenAI, no lado superior direito, clicamos no botão "Personal" e depois em "View API keys".

Somos encaminhados para uma nova página na qual descobrimos como gerenciar as chaves que permitirão o acesso a API.

Para criar uma nova chave, clicamos no botão "Create new secret key", definimos o nome "ScreenSound" e clicamos em "Create secret key".

A ferramenta só disponibiliza a chave quando é criada, portanto, precisamos copiá-la assim que é gerada, caso não, não a encontraremos em outro local. Feito isso, clicamos no botão "Done".

O próximo passo é abrir o projeto #C para criarmos a integração usando a chave e uma biblioteca específica que fará a integração.

Guilherme: Faremos isso no vídeo seguinte. Até lá!

### Aula 4 - Preparando o ambiente: instalando pelo Visual Studio Code

Na próxima atividade, vamos instalar uma biblioteca pelo Visual Studio. Porém, se você está fazendo o curso através do Visual Studio Code, é possível adicionar a biblioteca através do terminal com a instrução abaixo (garanta que está no diretório do projeto, ok?):

> dotnet add package OpenAI

### Aula 4 - Instalando a biblioteca - Vídeo 2

Transcrição  
Daniel: Acessamos nosso projeto no VS Code. Agora, precisamos adicionar uma biblioteca que nos auxiliará na construção do código.

Para integrar bibliotecas nos projetos .NET, no menu lateral direito, clicamos no botão "Gerenciador de soluções". No projeto, encontramos um item chamado "Dependências". Clicamos nele com o botão direito e depois em "Gerenciar Pacotes do NuGet".

Abre uma nova tela na lateral esquerda, na qual podemos procurar e instalar a biblioteca desejada. Na lateral superior esquerda, encontramos as abas "Procurar", "Instalado" e "Atualizações".

Clicamos na primeira opção. Depois, no campo de busca, escrevemos "OpenAI" e apertamos "Enter". Feito isso, temos uma lista de resultados. Clicamos no primeiro e depois no botão "Install".

Lembrando que geralmente para executar essa ação é preciso estar conectado a internet.

Aparece uma aba de permissão de instalação e licenças, clicamos em "Ok" e depois em "Aceitar".

Guilherme: Feito isso a biblioteca já está no projeto? Já podemos utilizá-la?

Daniel: Isso mesmo, Gui. Podemos fechar as abas e voltar para o código.

Começaremos realizando um teste. O que precisamos fazer é criar um objeto, guardá-lo em uma variável e usar seus métodos.

Então, na quarta linha, escrevemos using OpenAI_API.

Caso apareça um sublinhado em vermelho é porque houve algum erro na instalação, portanto, será necessário verificar isso antes de prosseguir.

Agora, utilizando o var criaremos uma variável chamada client com o tipo new OpenAIAPI(). Nas chaves e dentro de aspas duplas, passaremos a chave, portanto, apertamos "Ctrl + V".

```csharp
using ScreenSound;
using ScreenSound. Menus;
using ScreenSound. Modelos;
using OpenAI_API;
```

```csharp
var client = new OpenAIAPI("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");
```

Guilherme: Lembrando que a chave que estamos utilizando já não está mais ativa, portanto, não tentem utilizá-la, crie uma especificamente para seu projeto.

Daniel: Feito isso, criamos um objeto cliente que fará pedidos para a API OpenAI.

Na linha abaixo, escrevemos var chat = client.Chat.CreateConversation() para começar uma nova conversa, semelhante como ocorre no navegador.

Em seguida, escrevemos chat.AppendSystemMessage() para escrever uma mensagem. Nos parênteses, dentro de aspas duplas, inserimos o prompt que usamos no ChatGPT.

Feito isso, precisamos capturar a resposta em uma string, então escrevemos string resposta. Essa string está na variável chat.GetResponseFromChatbotAsync().

```csharp
//trecho omitido

var chat = client.Chat.CreateConversation();

chat.AppendSystemMessage("Resuma a banda Ira! em 1 parágrafo. Adote um estilo informal.");

string resposta = chat.GetResponseFromChatbotAsync();
```

Como não conheciamos todos os métodos dessa API acessamos a documentação para estudá-la.

Nesse caso, o método GetResponse() é executado de forma assíncrona. Isso significa que a execução não parará no fim desse trecho de código que criamos, ela continuará executando o restante.

Precisamos informar para o #C que queremos esperar o término da execução dessa requisição. Para isso, antes de GetResponse() escrevemos await.

Assim temos a resposta em uma string. Para imprimir no console escrevemos Console.WriteLine(resposta).

```csharp
using ScreenSound;
using ScreenSound. Menus;
using ScreenSound. Modelos;
using OpenAI_API;

var client = new OpenAIAPI("sk-GisUk7sScSE7KUd7XBYOTзBlbkFJjPYOTnGrMzxjzxWBCB5R");

var chat = client.Chat.CreateConversation();

chat.AppendSystemMessage("Resuma a banda Ira! em 1 parágrafo. Adote um estilo informal.");

string resposta = await chat.GetResponseFromChatbotAsync();

Console.WriteLine(resposta);
```

Guilherme: Para imprimirmos apenas essa resposta, no fim desse código, podemos comentar o ExibirOpcoesdoMenu() adicionando duas barras.

Daniel: Ótimo, Gui. Feito isso, apertamos "Ctrl + F5" para executar o código. Temos como retorno a resposta do ChatGPT. Deu certo!

Guilherme: Agora, o desafio é que esse texto seja gerado quando registrarmos uma nova banda. Faremos isso na aula seguinte!

### Aula 4 - Obtendo o resumo - Vídeo 3

Transcrição  
Daniel: Agora, integraremos tudo o que aprendemos no sistema. Colocaremos nosso código no registro de banda, assim, quando for registrada solicitaremos que o ChatGPT gere o resumo.

Banda.cs

Precisamos guardar esse resumo, mas ainda não temos um local para isso. Então, no menu lateral direito, clicamos em "Gerenciador de Soluções" e abrimos o arquivo Banda.cs.

Na linha 22, criamos uma propriedade string que aceitará valores nulos, então escrevemos public string? Resumo { get; set; }

//trecho omitido  
public string? Resumo { get; set; }

MenuRegistrarBanda.cs

Em seguida, acessamos novamente o "Gerenciador de Soluções", clicamos na pasta "Menu" e abrimos o arquivo MenuRegistrarBanda.cs, no qual criaremos o acesso ao ChatGPT.

Program.cs

Para isso, abrimos o arquivo Program.cs. Selecionamos o trecho de código da linha 6 até a 13 e apertamos "Ctrl + X".

Aproveitamos para apagar o using OpenAI_API, já que não precisaremos mais dele nesse arquivo.

MenuRegistrarBanda.cs

Voltamos para o arquivo de registro de banda. Após a linha bandasRegistradas, damos espaço e apertamos "Ctrl + V" para colar o código.

Agora, faremos as alterações necessárias. Em AppendSystemMessage(), fazemos uma interpolação de string, adicionando $ antes do texto. Depois, apagamos o nome da banda Ira! e definimos a variável nomeDaBanda.

Repare que, o trecho de código abaixo está sublinhado em vermelho. Isso acontece, pois a palavra reservada await precisa estar em conjunto com a palavra async.

De forma geral, os métodos assíncronos retornam uma tarefa, porém, nesse caso, utilizaremos outra estrutura. Então, na linha 23, apagamos o await.

Feito isso, se passarmos o mouse no método de GetResponseFromChatbotAsync(), percebemos que essa é uma tarefa que retorna uma string.

Então, na mesma linha, escrevemos .GetAwaiter(), para haver a espera e depois .GetResult() para termos o resultado.

Recomendamos essa opção somente se não for possível utilizar o awaite o async.

Feito isso, apagamos a linha Console.WriteLine(resposta) e escrevemos banda.Resumo que receberá a resposta.

Por fim, comentamos a linha Thread.Sleep(4000) adicionando duas barras.

```csharp
//trecho omitido

bandasRegistradas.Add(nomeDaBanda, banda);

var client = new OpenAIAPI("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");

var chat = client.Chat.CreateConversation();

chat.AppendSystemMessage($"Resuma a banda {nomeDaBanda} em 1 parágrafo. Adote um est: informal.");

string resposta = chat.GetResponseFromChatbotAsync().GetAwaiter().GetResult();
banda. Resumo = resposta;

Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!"); 
//Thread.Sleep(4000);
Console.Clear();
```

MenuExibirDetalhes.cs

Daniel: Agora, precisamos acessar o arquivo MenuExibirDetalhes.cs para exibir o resumo.

Então, em if(), abaixo de Banda banda, escrevemos Console.WriteLine(banda.Resumo).

```csharp
//trecho omitido
 if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            Banda banda = bandasRegistradas[nomeDaBanda];
            Console.WriteLine(banda.Resumo);
            Console.WriteLine($"\nA média da banda {nomeDaBanda} é {banda.Media}.");
            Console.WriteLine("\nDiscografia:");
            foreach(Album album in banda.Albuns)

//trecho omitido
```

Guilherme: Daniel, o que você acha de copiar o trecho de código das linhas 23 a 25 e colar em MenuRegistrarBanda.cs? Isso porque, mesmo que a requisição demore um pouco, passará direto.

Daniel: Acho ótimo, Gui. Ao fazer isso o código está pronto.

```csharp
using ScreenSound.Modelos;
using OpenAI_API;

namespace ScreenSound.Menus;

internal class MenuRegistrarBanda : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTituloDaOpcao("Registro das bandas");
        Console.Write("Digite o nome da banda que deseja registrar: ");
        string nomeDaBanda = Console.ReadLine()!;
        Banda banda = new Banda(nomeDaBanda);
        bandasRegistradas.Add(nomeDaBanda, banda);

        var client = new OpenAIAPI("<SUA API KEY AQUI>");
        var chat = client.Chat.CreateConversation();
        chat.AppendSystemMessage($"Resuma a banda {nomeDaBanda} em 1 parágrafo. Adote um estilo informal");
        var resposta = chat.GetResponseFromChatbotAsync().GetAwaiter().GetResult();
        banda.Resumo = resposta;

        Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
    }
}
```

Daniel: Para testar, apertamos "Ctrl + F5". Repare que houve um erro.

Guilherme: Sei o motivo. No código principal comentamos o método ExibirOpcoesDoMenu(), precisamos apagar o comentário.

Daniel: Para corrigir basta acessar o arquivo Program.cse apagar as duas barras. Feito isso, executamos o código novamente. Agora deu certo.

Feito isso o Screen Sound 2.0 abre. Digitamos "1" e apertamos "Enter" para registrar uma banda.

Guilherme: Vamos registrar a banda Kid Abelha. Então, escrevemos e apertamos "Enter". Assim, temos o retorno abaixo:

A banda Kid Abelha foi registrada com sucesso! Digite uma tecla para voltar ao menu principal

Daniel: Para exibir os detalhes da banda digitamos "6" e apertamos "Enter". Temos o retorno abaixo:

Mano, Kid Abelha era uma banda de rock/pop nacional que fazia um sucesso danado nos anos 80 e 90. A liderança era da diva Paula Toller, que arrasava nos vocais e na beleza, e o repertório era cheio de músicas que grudavam na cabeça, tipo "Como eu quero", "Grand Hotel", "Lágrimas e chuva" e mais uma porrada de sucessos. Além disso, a banda sempre teve um estilo maneiro, com umas roupinhas bem típicas da época, sabe? Enfim, Kid Abelha é até hoje um clássico daquela época.

A média da banda Kid Abelha é 0.

Discografia:

Digite uma tecla para voltar ao menu principal

Guilherme: Voltamos para o menu principal e digitamos "4" para avaliar a banda.

Em seguida, digitamos o nome da banda e atribuímos o valor "10". Assim, temos o seguinte retorno:

A nota 10 foi registrada com sucesso para a banda Kid Abelha

Daniel: Agora, se voltarmos para o menu principal e acessarmos os detalhes da banda, digitando "6" temos a descrição e a nota média. Tudo certo!

### Aula 4 - Projeto final

Chegamos ao final deste curso! Se você quiser conferir e fazer o download do projeto completo que desenvolvemos juntos durantes as aulas, você pode [baixar o zip da Aula 05](https://github.com/alura-cursos/ScreenSound03/archive/refs/heads/aula-5.zip) ou acessar os [arquivos no Github!](https://github.com/alura-cursos/ScreenSound03/tree/aula-5)

### Aula 4 - Parabéns!

Chegou o momento de celebrar sua grande conquista!

Neste curso, você aprofundou os conhecimentos de Orientação a Objetos, aprendendo sobre métodos estáticos, herança e interface. Além disso, refletiu sobre boas práticas, organizando seu código através de namespaces e pastas de projeto. Por fim, também descobriu como integrar o seu projeto a uma biblioteca de terceiros.

Durante o curso, você teve a oportunidade de aplicar esses conceitos em um ambiente prático, utilizando o Visual Studio, como já está acostumado aqui na Alura. Incorporou as classes Banda e Album no arquivo Program.cs, criou uma classe Avaliacao para representar avaliações, reorganizou os menus em uma hierarquia de classes e conseguiu aplicar notas a bandas, álbuns e músicas através da interface IAvaliavel. Para fechar com chave de ouro, utilizou Inteligência Artificial instalando uma biblioteca de terceiros para ajudar a obter mais informações sobre bandas, exibindo-as no ScreenSound!

Nossa… quanta coisa legal!

"Não tenha medo de falhar. Cada fracasso é um degrau para o sucesso." (Allyson Michelle Felix, corredora olímpica)

Agora, dê uma nota para o curso, faça download do seu certificado e comemore bastante essa conquista.

Guilherme Lima

Daniel Portugal

### Aula 4 - Referências

1. [Estrutura geral de um programa em C#](https://learn.microsoft.com/pt-br/dotnet/csharp/fundamentals/program-structure/) (gratuito, português, documentação)

Documentação oficial da Microsoft que apresenta conceitos sobre a estrutura de projetos em C# e exemplos de implementação.

2. [Convenções comuns de código C#](https://learn.microsoft.com/pt-br/dotnet/csharp/fundamentals/coding-style/coding-conventions) (gratuito, português, documentação)

Documentação oficial da Microsoft que apresenta conceitos sobre convenções comuns e boas práticas de escrita de código em C#, além de exemplos de utilização.

3. [Modificadores de acesso](https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/access-modifiers) (gratuito, português, documentação)

Documentação oficial da Microsoft que apresenta conceitos sobre modificadores de acesso, diferentes visibilidades em C# e exemplos de implementação.

4. [Interfaces](https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/interface) (gratuito, português, documentação)

Documentação oficial da Microsoft que apresenta conceitos sobre interfaces em C# e exemplos de implementação.

### Aula 4 - Conclusão - Vídeo

Transcrição  
Guilherme: Parabéns por concluir mais um curso da Alura!

Antes de encerrar, vamos relembrar tudo o que aprendemos e descobrir quais são suas novas capacitações.

Daniel: Com o conteúdo aprendido, você pode poderá fazer a leitura e organização do código, além de entender e evoluir um projeto real com a Orientação a Objetos, como herança e interface.

Guilherme: Nessa jornada de aprendizado, estudamos a arquitetura das pastas, como devemos organizar a aplicação em códigos e classes diferentes usando namespaces e como tornar o código mais legível.

É muito importante que você entenda que o código que criamos sempre passará por mudanças e evoluções.

Daniel: Exatamente, Gui. Por fim, integramos um projeto a uma biblioteca externa com inteligência artificial para buscarmos novas informações sobre bandas de música.

Guilherme: Isso foi realmente muito interessante! Parecia que seria algo muito complexo, mas conseguimos aplicar de forma simples.

Esperamos que você também tenha gostado do curso. Não se esqueça de deixar sua avaliação e nos contar o que mais gostou.

Até a próxima!

continuar lendo
