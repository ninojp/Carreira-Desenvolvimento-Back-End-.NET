# Curso Alura: C# Manipulação de dados com coleções e LINQ

## Aula 1: Introdução às coleções

### Aula 1: Apresentação - Vídeo 1

Transcrição  
Olá! Seja bem-vindo ao curso de manipulação de dados com C# da Alura. Meu nome é Daniel Portugal, sou instrutor e desenvolvedor do Otinete, e estarei acompanhando você ao longo deste conteúdo.

Audiodescrição: Daniel é um homem branco, com cabelos escuros, olhos castanhos e barba por fazer. Ele usa óculos e veste uma camisa laranja. Ao fundo, há um armário com fundo azul.

**Requisitos e objetivos do curso**  
Para aproveitar bem este curso, é necessário ter conhecimentos prévios na linguagem C#, no paradigma de orientação a objetos, na execução de programas do tipo console, leitura e gravação de arquivos, e exceções.

Com esses conhecimentos, vamos evoluir nosso aprendizado no curso, abordando manipulações de coleções e suas principais estruturas de dados no .NET, como List, HashSet, Dictionary, Queue e Stack. Em seguida, exploraremos a biblioteca LINQ (Consulta Integrada à Linguagem), suas principais operações e a razão de utilizá-las como estágios no fluxo de manipulação de dados.

**Explorando tipos de dados e expressões regulares**  
Vamos evoluir para o tipo String (cadeia de caracteres) e conhecer suas características peculiares, como imutabilidade, interning (compartilhamento de instâncias), pool de strings (conjunto de cadeias de caracteres) e também os processos de formatação e parsing (análise), que são bastante importantes no contexto de manipulação de dados.

Depois, vamos capturar e encontrar padrões em textos maiores usando expressões regulares e finalizar o curso persistindo todo esse processamento em arquivos JSON a partir da serialização de dados.

**Realizando projetos práticos e utilizando recursos adicionais**  
Tudo isso será visto através de pequenos projetos práticos, do tipo console, onde exibimos as informações em uma janela do terminal, tudo baseado no contexto de músicas, artistas e playlists. Com uma exceção no primeiro projeto, onde falaremos de coleções e introduziremos esse tema de forma mais genérica.

Não se esqueçam de aproveitar todos os recursos da plataforma. Além dos vídeos gravados, temos também atividades que ajudarão a complementar e aprofundar os tópicos discutidos. Além disso, utilizem o fórum e a comunidade do Discord para conversar e esclarecer dúvidas com outras pessoas que estão discutindo o mesmo assunto.

Convidando para o aprendizado

Vamos nos preparar e mergulhar nesse assunto!

### Aula 1: Representando coleções - Vídeo 2

Transcrição  
Nosso estudo sobre manipulação de dados será dividido em sete partes. Essas partes estão organizadas em sete projetos dentro da solução. Cada projeto é do tipo console, com o qual já estamos acostumados a trabalhar. Vamos desenvolver o assunto e os tópicos em cada projeto.

Estamos com o Visual Studio aberto, com a solução carregada. Vamos disponibilizar o link para download, mas é uma solução bastante simples, que pode ser criada manualmente, se preferirem. No Visual Studio, com o gerenciador de soluções à esquerda da tela, temos uma barra superior onde o primeiro projeto está selecionado. Há uma lista suspensa que permite selecionar o projeto correspondente a cada tópico que abordarmos.

**Preparando o ambiente de desenvolvimento**  
Vamos abrir o arquivo program.cs do primeiro projeto. No gerenciador de soluções, localizamos o arquivo program.cs, clicamos duas vezes nele e o código correspondente aparece no editor. Este é um código padrão que vem ao criar um projeto do tipo console. A primeira ação será selecionar todo o código com ctrl-a e deletá-lo, criando um espaço em branco para começarmos nosso estudo sobre manipulação de dados.

Para manipular dados, frequentemente precisamos trabalhar com coleções de maneira uniforme. Seja para obter uma coleção, realizar operações ou convertê-la para outro passo do programa, coleções são fundamentais na manipulação de dados. No C#, representamos coleções de várias formas. Por exemplo, em um aplicativo de gestão de tarefas, podemos ter os dias da semana organizados. Em um e-commerce, um carrinho de compras é uma lista de produtos que precisa ser totalizada e, possivelmente, ter descontos aplicados. Em um aplicativo de música, uma playlist é uma coleção de músicas.

**Criando coleções com ArrayList**  
No código C#, vamos criar uma variável chamada diasDaSemana. Esta variável será atribuída a uma coleção de dias da semana. Os elementos serão representados como texto: domingo, segunda, terça, quarta, quinta, sexta e sábado. Precisamos garantir que todos esses elementos estejam representados de maneira coletiva e uniforme. Para isso, usamos chaves para envolver os elementos e especificamos o tipo de coleção. Historicamente, um dos primeiros tipos de coleção no C# foi o ArrayList. Vamos criar um objeto do tipo ArrayList, inicializando-o com os sete elementos dos dias da semana, e concluir a representação com um ponto e vírgula.

Primeiro, vamos declarar a variável diasDaSemana:

```csharp
var diasDaSemana;
```

Agora, vamos inicializar essa variável com os dias da semana:

```csharp
var diasDaSemana = new ArrayList() { "Domingo", "Segunda", "Terça", "Quarta", "Quinta", "Sexta", "Sábado" };
```

**Importando namespaces e criando classes**  
Para usar o ArrayList, precisamos importar o namespace correto:

```csharp
using System.Collections;

var diasDaSemana = new ArrayList() { "Domingo", "Segunda", "Terça", "Quarta", "Quinta", "Sexta", "Sábado" };
```

Na linha 3 do código, temos a inicialização do objeto que representa uma coleção com os sete elementos dos dias da semana. Não é necessário que os elementos sejam de um tipo primitivo, como String. Por exemplo, no caso de um carrinho de compras, podemos criar uma classe Produto para representar os elementos da coleção. Vamos criar uma classe chamada Produto, que terá propriedades como nome (do tipo String) e preço (do tipo Double). Essa classe Produto será o tipo que representará os elementos do conjunto.

Primeiro, criamos a classe Produto:

```csharp
class Produto
{
}
```

Em seguida, adicionamos a propriedade Nome:

```csharp
class Produto
{
    public string Nome { get; set; }
}
```

E finalmente, adicionamos a propriedade Preco:

```csharp
class Produto
{
    public string Nome { get; set; }
    public double Preco { get; set; }
}
```

**Inicializando coleções de produtos**  
Na linha 5, criamos uma variável chamada carrinho do tipo ArrayList. Inicializamos esse objeto e adicionamos alguns produtos. Para criar a variável produto, utilizamos new Produto, cujo nome é "Leite" e o preço é 7,89. Criamos também outro produto chamado "Manteiga", com o preço de 3,45. Assim, criamos uma coleção para representar os produtos de um carrinho, adicionando dois produtos a essa coleção, que é do tipo ArrayList.

Primeiro, inicializamos o carrinho:

```csharp
var carrinho = new ArrayList()
{
};
```

Adicionamos o primeiro produto:

```csharp
var carrinho = new ArrayList()
{
    new Produto() { Nome = "Leite", Preco = 7.89 },
};
```

E então, adicionamos o segundo produto:

```csharp
var carrinho = new ArrayList()
{
    new Produto() { Nome = "Leite", Preco = 7.89 },
    new Produto() { Nome = "Manteiga", Preco = 3.45 }
};
```

**Explorando limitações do ArrayList**  
O problema do ArrayList é que ele não restringe o tipo do elemento. Isso significa que poderíamos criar um carrinho com dois produtos, mas também poderíamos adicionar uma string. Por exemplo, poderíamos colocar o dia da semana junto com os produtos na variável carrinho.

```csharp
var carrinho = new ArrayList()
{
    new Produto() { Nome = "Leite", Preco = 7.89 },
    new Produto() { Nome = "Manteiga", Preco = 3.45 },
    "Domingo"
};
```

A manipulação de dados é facilitada quando restringimos o tipo do elemento de uma coleção, pois sabemos exatamente quais são as propriedades. Se tentarmos acessar o terceiro elemento e totalizar o preço, não conseguiremos, o que pode gerar problemas maiores, exigindo o gerenciamento do tipo do elemento.

**Introduzindo coleções genéricas**  
Existem maneiras mais fáceis de lidar com isso, e o C# oferece o recurso de Generic. Com o Generic, podemos definir o tipo do elemento de uma coleção. Por exemplo, no caso de coleções, podemos definir que o tipo do elemento será string. No C#, podemos fazer isso colocando o tipo do elemento na frente, seguido de colchetes, indicando que é um array do tipo string.

```csharp
var diasDaSemana = new string[] { "Domingo", "Segunda", "Terça", "Quarta", "Quinta", "Sexta", "Sábado" };
```

Existem outros tipos que representam coleções, e vamos estudá-los com mais profundidade. Um tipo que já vimos em outros cursos é o tipo List. Inicializamos e atribuímos variáveis com esse tipo, indicando que o tipo do elemento fica entre os sinais de maior ou menor, que são os parâmetros do tipo genérico. Quando criamos um carrinho como uma lista de produtos, automaticamente ganhamos a vantagem de que elementos de tipos diferentes, como "domingo", que é do tipo string, não podem ser compilados, pois não são do tipo Produto.

**Trabalhando com listas genéricas**  
Primeiro, declaramos o carrinho como uma lista de Produto:

```csharp
var carrinho = new List<Produto>();
```

E então, inicializamos com produtos:

```csharp
var carrinho = new List<Produto>()
{
    new Produto() { Nome = "Leite", Preco = 7.89 },
    new Produto() { Nome = "Manteiga", Preco = 3.45 },
};
```

Os generics nas coleções nos oferecem essa vantagem, permitindo manipular os dados da coleção carrinhos para totalizar os preços sem problemas, pois todos os elementos são do tipo Produto. Fizemos uma rápida introdução às coleções no C#, mostrando como inicializar usando chaves. Mostramos o ArrayList, um tipo antigo do C# 1.0 de 2001, que representava coleções, mas tinha o problema de permitir elementos de qualquer tipo, exigindo verificação do tipo para manipulação.

**Concluindo com vantagens dos generics**  
Com os generics a partir da versão 2.0, novos tipos foram disponibilizados, restringindo o tipo do elemento da coleção, o que é amplamente utilizado atualmente. Uma discussão importante é que usaremos muito essas coleções representadas por tipos, como List, com mais frequência do que coleções do tipo Array. A diferença é que o Array é uma coleção com tamanho fixo, como dias da semana, que sempre serão sete elementos. Podemos usar o Array sem problemas, pois não precisamos redimensioná-lo manualmente.

Quando a coleção precisa ser redimensionada dinamicamente, como em um carrinho de compras que muda de tamanho, é melhor usar tipos mais modernos, como List, que já oferecem redimensionamento automático. Assim, nas coleções, o redimensionamento é automático quando usamos List. No próximo vídeo, falaremos sobre uma operação comum no trabalho com coleções.

### Aula 1: Organização de inventário em uma loja de livros - Exercício

Na loja Meu Pequeno Grimorio, especializada em livros de literatura fantástica e esotérica, a equipe de TI está desenvolvendo um sistema para gerenciar o inventário de livros. Cada livro possui informações como título, autor, preço e quantidade em estoque. A equipe precisa garantir que o sistema possa facilmente adicionar novos livros, atualizar informações existentes e remover livros que não estão mais disponíveis.

Qual tipo de coleção seria mais apropriado para implementar o inventário de livros?

Resposta:  
List

> Correta, pois o List permite o armazenamento de objetos complexos, como instâncias de uma classe Livro que contém todas as informações necessárias (título, autor, preço, quantidade). A capacidade de redimensionamento dinâmico do List facilita a adição e remoção de livros do inventário. Além disso, o uso de genéricos garante que todos os elementos da coleção sejam do tipo Livro, permitindo manipulações seguras e eficientes dos dados.

### Aula 1: Percorrendo coleções - Vídeo 3

Transcrição
Falamos que, para manipular dados, precisamos trabalhar com coleções de maneira uniforme. Apresentamos arrays, lists, discutimos tipos genéricos e a importância de restringir o tipo do elemento no carrinho.

Para acessar um elemento de uma coleção, como uma lista, utilizamos um acesso indexado. Se quisermos pegar o primeiro elemento, colocamos um colchete e usamos um índice. No caso do primeiro elemento, usamos o índice zero. As coleções no C# são indexadas a partir do índice zero, assim como os arrays. Por exemplo, o primeiro elemento do dia da semana também seria o índice zero. Dessa forma, acessamos elementos individualmente em uma coleção através de um acesso indexado com colchetes e índice.

carrinho[0]
Copiar código
Iterando sobre coleções com loop for
Se quisermos pegar cada elemento de forma iterativa, por exemplo, para imprimir os produtos no carrinho, precisamos fazer um loop. Utilizaremos um loop for e, nesse loop, incrementaremos o índice passo a passo. Criamos uma variável do tipo inteiro que começa em zero, pois queremos começar a partir do primeiro elemento.

for(int i=0;
Copiar código
A próxima parte do nosso for é a condição de saída desse loop, que será quando não houver mais elementos. Quando o índice for menor que o total de elementos no carrinho, utilizamos o método Count para indicar o total de elementos.

for(int i=0; i < carrinho.Count;
Copiar código
A terceira parte é o que faremos com o índice a cada iteração: incrementá-lo de uma unidade.

for(int i=0; i < carrinho.Count; i++)
{
}
Copiar código
Criamos o for para imprimir cada elemento do carrinho na coleção. Utilizamos o atalho cw "Tab" para escrever Console.WriteLine, algo que faremos muito neste curso. O Visual Studio nos entrega esse código automaticamente. Usamos a interpolação de string para dizer "produto: " e, em seguida, pegamos o elemento da coleção carrinho a partir do índice i e imprimimos o nome dele.

for(int i=0; i < carrinho.Count; i++)
{
    Console.WriteLine($"Produto: {carrinho[i].Nome}");
}
Copiar código
Com isso, temos um loop que percorre a coleção carrinho índice a índice e imprime o nome do produto no console.

Executando o programa no Visual Studio
Para executar o programa no nosso ambiente local do Visual Studio, vamos até a barra superior, na segunda linha. Vamos dar um zoom nessa barra, onde encontramos o botão de execução, um triângulo verde preenchido. Clicamos nele, e o programa será compilado e executado em uma janela do terminal. Mostraremos que ele percorreu o carrinho e imprimiu no terminal: "produto: leite", "produto: manteiga". Percorremos os elementos de uma coleção usando o loop for, uma operação básica no trabalho com coleções.

Poderíamos também percorrer com o while, mas mostraremos que podemos simplificar ainda mais o nosso trabalho de percorrer uma coleção utilizando outra instrução do C#, que é o foreach.

Utilizando o loop foreach
No trecho de código apresentado, utilizamos o for para acessar elementos de um carrinho de compras. Inicialmente, criamos uma variável chamada produto para representar o elemento atual do carrinho. Essa variável é inicializada com o produto atual, e utilizamos no Console.WriteLine para exibir o produto, demonstrando a construção da instrução for.

var produto = carrinho[i];
Console.WriteLine($"Produto: {produto.Nome}");
Copiar código
No C#, o foreach é uma instrução mais simplificada, onde definimos qual elemento será extraído da coleção. Utilizamos a palavra reservada in seguida do nome da coleção, neste caso, carrinho. Em seguida, copiamos o Console.WriteLine da linha 18 para imprimir o produto.

foreach(var produto in carrinho)
{
    Console.WriteLine($"Produto: {produto.Nome}");
}
Copiar código
Comparando com o for tradicional, no qual precisamos definir manualmente o índice, determinar como o loop terminará e incrementar o índice, o foreach automatiza várias dessas etapas. Apenas indicamos o nome da variável que representará o elemento da coleção e a coleção específica, permitindo manipular o dado diretamente dentro das chaves. Isso torna o código mais conciso e legível, pois o processamento do elemento ocorre diretamente entre as chaves.

Encapsulando loops em métodos
Essa é a operação básica para percorrer uma coleção, e utilizaremos bastante o foreach. Para organizar melhor o código e evitar dois loops juntos, criaremos um método chamado PercorrendoComFor. Selecionamos o código da linha 15 a 19, cortamos e colamos dentro desse método na linha 25.

void PercorrendoComFor()
{
    for (int i = 0; i < carrinho.Count; i++)
    {
        var produto = carrinho[i];
        Console.WriteLine($"Produto: {produto.Nome}");
    }
}
Copiar código
Faremos o mesmo com o método PercorrendoComForEach, selecionando da linha 17 até a linha 20, cortando e colando na linha 32.

void PercorrendoComForEach()
{
    foreach (var produto in carrinho)
    {
        Console.WriteLine($"Produto: {produto.Nome}");
    }
}
Copiar código
Com esses métodos encapsulados, evitamos atrapalhar a execução do programa. Essa separação didática facilita a apresentação do código. Manteremos a execução apenas do método PercorrendoComForEach, evitando executar os dois loops simultaneamente.

PercorrendoComForEach();
Copiar código
Testando a execução do programa
Para testar, podemos pressionar a tecla F5, que compila e executa o programa, imprimindo os produtos da coleção no console, assim como era feito com o for tradicional.

Percorrer coleções é uma operação básica em nosso trabalho de manipulação, permitindo processar elementos específicos. No próximo vídeo, exploraremos os bastidores do código foreach e discutiremos o que acontece por trás dele.

### Aula 1:  - Vídeo 4
### Aula 1:  - Vídeo 5
### Aula 1:  - Vídeo 6
### Aula 1:  - Vídeo 7
### Aula 1:  - Vídeo 8

