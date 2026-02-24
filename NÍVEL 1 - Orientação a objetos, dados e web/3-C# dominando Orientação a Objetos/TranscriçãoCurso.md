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

## Aula 3 - 

### Aula 3 -  - Vídeo 1
