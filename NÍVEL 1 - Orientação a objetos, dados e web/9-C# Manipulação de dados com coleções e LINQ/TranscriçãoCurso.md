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

```csharp
carrinho[0]
```

Iterando sobre coleções com loop for
Se quisermos pegar cada elemento de forma iterativa, por exemplo, para imprimir os produtos no carrinho, precisamos fazer um loop. Utilizaremos um loop for e, nesse loop, incrementaremos o índice passo a passo. Criamos uma variável do tipo inteiro que começa em zero, pois queremos começar a partir do primeiro elemento.

```csharp
for(int i=0;
```

A próxima parte do nosso for é a condição de saída desse loop, que será quando não houver mais elementos. Quando o índice for menor que o total de elementos no carrinho, utilizamos o método Count para indicar o total de elementos.

```csharp
for(int i=0; i < carrinho.Count;
```

A terceira parte é o que faremos com o índice a cada iteração: incrementá-lo de uma unidade.

```csharp
for(int i=0; i < carrinho.Count; i++)
{
}
```

Criamos o for para imprimir cada elemento do carrinho na coleção. Utilizamos o atalho cw "Tab" para escrever Console.WriteLine, algo que faremos muito neste curso. O Visual Studio nos entrega esse código automaticamente. Usamos a interpolação de string para dizer "produto: " e, em seguida, pegamos o elemento da coleção carrinho a partir do índice i e imprimimos o nome dele.

```csharp
for(int i=0; i < carrinho.Count; i++)
{
    Console.WriteLine($"Produto: {carrinho[i].Nome}");
}
```

Com isso, temos um loop que percorre a coleção carrinho índice a índice e imprime o nome do produto no console.

**Executando o programa no Visual Studio**  
Para executar o programa no nosso ambiente local do Visual Studio, vamos até a barra superior, na segunda linha. Vamos dar um zoom nessa barra, onde encontramos o botão de execução, um triângulo verde preenchido. Clicamos nele, e o programa será compilado e executado em uma janela do terminal. Mostraremos que ele percorreu o carrinho e imprimiu no terminal: "produto: leite", "produto: manteiga". Percorremos os elementos de uma coleção usando o loop for, uma operação básica no trabalho com coleções.

Poderíamos também percorrer com o while, mas mostraremos que podemos simplificar ainda mais o nosso trabalho de percorrer uma coleção utilizando outra instrução do C#, que é o foreach.

**Utilizando o loop foreach**  
No trecho de código apresentado, utilizamos o for para acessar elementos de um carrinho de compras. Inicialmente, criamos uma variável chamada produto para representar o elemento atual do carrinho. Essa variável é inicializada com o produto atual, e utilizamos no Console.WriteLine para exibir o produto, demonstrando a construção da instrução for.

```csharp
var produto = carrinho[i];
Console.WriteLine($"Produto: {produto.Nome}");
```

No C#, o foreach é uma instrução mais simplificada, onde definimos qual elemento será extraído da coleção. Utilizamos a palavra reservada in seguida do nome da coleção, neste caso, carrinho. Em seguida, copiamos o Console.WriteLine da linha 18 para imprimir o produto.

```csharp
foreach(var produto in carrinho)
{
    Console.WriteLine($"Produto: {produto.Nome}");
}
```

Comparando com o for tradicional, no qual precisamos definir manualmente o índice, determinar como o loop terminará e incrementar o índice, o foreach automatiza várias dessas etapas. Apenas indicamos o nome da variável que representará o elemento da coleção e a coleção específica, permitindo manipular o dado diretamente dentro das chaves. Isso torna o código mais conciso e legível, pois o processamento do elemento ocorre diretamente entre as chaves.

**Encapsulando loops em métodos**  
Essa é a operação básica para percorrer uma coleção, e utilizaremos bastante o foreach. Para organizar melhor o código e evitar dois loops juntos, criaremos um método chamado PercorrendoComFor. Selecionamos o código da linha 15 a 19, cortamos e colamos dentro desse método na linha 25.

```csharp
void PercorrendoComFor()
{
    for (int i = 0; i < carrinho.Count; i++)
    {
        var produto = carrinho[i];
        Console.WriteLine($"Produto: {produto.Nome}");
    }
}
```

Faremos o mesmo com o método PercorrendoComForEach, selecionando da linha 17 até a linha 20, cortando e colando na linha 32.

```csharp
void PercorrendoComForEach()
{
    foreach (var produto in carrinho)
    {
        Console.WriteLine($"Produto: {produto.Nome}");
    }
}
```

Com esses métodos encapsulados, evitamos atrapalhar a execução do programa. Essa separação didática facilita a apresentação do código. Manteremos a execução apenas do método PercorrendoComForEach, evitando executar os dois loops simultaneamente.

```csharp
PercorrendoComForEach();
```

**Testando a execução do programa**  
Para testar, podemos pressionar a tecla F5, que compila e executa o programa, imprimindo os produtos da coleção no console, assim como era feito com o for tradicional.

Percorrer coleções é uma operação básica em nosso trabalho de manipulação, permitindo processar elementos específicos. No próximo vídeo, exploraremos os bastidores do código foreach e discutiremos o que acontece por trás dele.

### Aula 1: Para saber mais: padrão iterator em C#

O padrão Iterator é um design que tem como objetivo separar a forma como percorremos uma coleção dos detalhes internos de sua implementação. Essa separação permite que a iteração seja realizada de forma genérica e encapsulada, sem que o usuário precise conhecer a estrutura interna dos dados. Em C#, esse conceito se materializa por meio das interfaces IEnumerable e IEnumerator, que garantem que qualquer coleção possa ser percorrida com a mesma sintaxe, como o loop for-each.

**Estrutura e Funcionamento**  
Na prática, a interface IEnumerable define um contrato para que uma coleção possa fornecer um enumerador, ou seja, um objeto que sabe como percorrer os elementos da coleção. Esse enumerador, implementado por meio da interface IEnumerator, é o responsável por manter o estado atual da iteração, oferecendo métodos e propriedades como MoveNext(), Reset() e Current. O método MoveNext(), por exemplo, atualiza internamente um ponteiro para o próximo elemento, enquanto a propriedade Current expõe o elemento atual da coleção.

```csharp
public class MeuEnumerator : IEnumerator<string>
{
    private readonly string[] _itens;
    private int _pos = -1;

    public MeuEnumerator(string[] itens)
    {
        _itens = itens;
    }

    public string Current => _itens[_pos];

    object System.Collections.IEnumerator.Current => Current;

    public bool MoveNext()
    {
        _pos++;
        return _pos < _itens.Length;
    }

    public void Reset()
    {
        _pos = -1;
    }

    public void Dispose() { }
}
```

**Variações e Impactos na Produtividade**  
Embora seja possível implementar as interfaces IEnumerable e IEnumerator manualmente, C# oferece recursos, como o operador yield, que simplifica a criação de iteradores sem a necessidade de gerenciar explicitamente o estado da iteração. Essa abordagem leva a um código mais limpo e legível, reduzindo a probabilidade de erros na manipulação manual da posição do elemento.

Entretanto, a implementação manual do padrão Iterator pode ser útil em cenários onde é necessário um controle mais detalhado sobre a iteração, como quando a lógica de travessia da coleção é complexa ou quando é preciso interagir com recursos externos de forma cuidadosa (por exemplo, liberando recursos após a conclusão da iteração).

Ao separar a lógica de iteração da estrutura de dados, o padrão Iterator promove uma maior flexibilidade e reutilização de código, permitindo que algoritmos de processamento de dados sejam aplicados a diferentes tipos de coleções de forma uniforme.

Esse encapsulamento é especialmente valioso em aplicações que demandam escalabilidade e manutenção de grandes volumes de dados, onde a clareza e a robustez na manipulação de coleções são fundamentais.

### Aula 1: A coleção DiasDaSemana - Vídeo 4

Transcrição  
Vamos começar a criar a classe DiasDaSemana para representar os dias da semana como uma coleção. Inicialmente, vamos declarar a classe sem nenhum conteúdo:

```csharp
class DiasDaSemana
{

}
```

Agora, vamos adicionar um campo do tipo array de strings chamado dias, que será inicializado com os dias da semana:

```csharp
class DiasDaSemana
{
    private string[] dias = { "Domingo", "Segunda", "Terça", "Quarta", "Quinta", "Sexta", "Sábado" };
}
```

**Instanciando e percorrendo a coleção**  
Com a classe DiasDaSemana criada, podemos instanciar um objeto dessa classe:

```csharp
var diasDaSemana = new DiasDaSemana();
```

Para percorrer essa coleção, tentamos usar um foreach, mas encontramos um problema. O compilador reclama que DiasDaSemana não implementa a interface necessária para ser enumerada. Vamos corrigir isso implementando a interface IEnumerable`<string>` na classe DiasDaSemana:

```csharp
class DiasDaSemana : IEnumerable<string>
{
    private string[] dias = { "Domingo", "Segunda", "Terça", "Quarta", "Quinta", "Sexta", "Sábado" };
}
```

**Implementando o método GetEnumerator**  
Agora, precisamos implementar o método GetEnumerator que retorna um objeto que implementa IEnumerator<string>. Inicialmente, lançamos uma exceção para indicar que ainda não implementamos o método:

```csharp
public IEnumerator<string> GetEnumerator()
{
    throw new NotImplementedException();
}

IEnumerator IEnumerable.GetEnumerator()
{
    return GetEnumerator();
}
```

Criando a classe DiasDaSemanaEnumerator
Para implementar o GetEnumerator, vamos criar uma classe chamada DiasDaSemanaEnumerator que implementa IEnumerator`<string>`:

```csharp
class DiasDaSemanaEnumerator : IEnumerator<string>
{

}
```

Na classe DiasDaSemanaEnumerator, precisamos implementar os métodos e propriedades da interface IEnumerator<string>. Vamos começar declarando a propriedade Current e os métodos Dispose, MoveNext, e Reset:

```csharp
public string Current => throw new NotImplementedException();

object IEnumerator.Current => Current;

public void Dispose()
{
    throw new NotImplementedException();
}

public bool MoveNext()
{
    throw new NotImplementedException();
}

public void Reset()
{
    throw new NotImplementedException();
}
```

Implementando a lógica dos métodos do enumerador
Agora, vamos implementar a lógica desses métodos. Primeiro, adicionamos um campo privado posicao para controlar a posição atual na coleção:

```csharp
private int posicao = -1;
```

Implementamos o método MoveNext para avançar para o próximo elemento na coleção:

```csharp
public bool MoveNext()
{
    posicao++;
    return posicao < dias.Length;
}
```

O método Reset redefine a posição para o início da coleção:

```csharp
public void Reset()
{
    posicao = -1;
}
```

A propriedade Current retorna o elemento atual da coleção:

```csharp
public string Current => dias[posicao];
```

Completando a implementação do enumerador
Finalmente, completamos a implementação da classe DiasDaSemanaEnumerator:

```csharp
class DiasDaSemanaEnumerator : IEnumerator<string>
{
    private int posicao = -1;
    private string[] dias = { "Domingo", "Segunda", "Terça", "Quarta", "Quinta", "Sexta", "Sábado" };

    public string Current => dias[posicao];

    object IEnumerator.Current => Current;

    public void Dispose()
    {
    }

    public bool MoveNext()
    {
        posicao++;
        return posicao < dias.Length;
    }

    public void Reset()
    {
        posicao = -1;
    }
}
```

Ajustando a classe DiasDaSemana para usar o enumerador
Agora, ajustamos a classe DiasDaSemana para retornar um DiasDaSemanaEnumerator no método GetEnumerator:

```csharp
class DiasDaSemana : IEnumerable<string>
{
    public IEnumerator<string> GetEnumerator()
    {
        return new DiasDaSemanaEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
```

**Usando foreach para percorrer a coleção**  
Com isso, podemos usar o foreach para percorrer a coleção DiasDaSemana sem erros de compilação:

```csharp
foreach(string dia in diasDaSemana)
{
    Console.WriteLine(dia);
}
```

Ao executar o programa, ele percorrerá a coleção e imprimirá cada dia da semana na ordem definida. Isso demonstra como implementar a interface IEnumerable permite que uma classe personalizada seja percorrida com foreach. No próximo vídeo, exploraremos maneiras de simplificar ainda mais esse processo.

### Aula 1: O operador yield - Vídeo 5

Transcrição  
Agora, nossa classe Dia da Semana implementa a Enumerable. Na prática, o que está acontecendo por trás dos panos é que conseguimos fazer esse for each. Sabemos que esse código é uma facilitação que o C# e a máquina virtual do .NET nos proporcionam. O que acontece por trás dos panos? Ela pega um Enumerator de dias da semana, getEnumerator, e usa esse Enumerator para percorrer nossa coleção, utilizando o método moveNext. Assim, recuperamos o dia através da propriedade current, permitindo a impressão ou processamento daquele elemento da coleção no terminal.

Para ilustrar isso, vamos começar criando um enumerador para nossa coleção de dias da semana:

```csharp
var enumerator = diasDaSemana.GetEnumerator();
```

**Demonstrando o uso do Enumerator manualmente**  
O for each facilita nossa vida, pois não precisamos lidar com todo esse código, como pegar o current, fazer um while ou verificar se podemos mover para o próximo elemento com uma condição booleana. Tudo isso está embutido. No entanto, é importante entender que ele precisa do Enumerator para realizar o loop.

Vamos ver como isso seria feito manualmente com um while:

```csharp
while(enumerator.MoveNext())
{
    var dia = enumerator.Current;
    Console.WriteLine(dia);
}
```

Antes de continuar a explicação, vamos mover tudo isso para "Percorrendo Dias da Semana". Vamos trazer o for each para cá, da linha 12 até a linha 15, e também percorrer com Enumerator. Abrimos chaves e trazemos o código para cá, facilitando nossa vida. Limpei um pouco o programa.

**Criando métodos para percorrer a coleção**  
Agora, vamos ao código que declara os tipos Dia de Semana e Dia de Semana Enumerator. A explicação foi interrompida para que possamos respirar, pois há conceitos mais elaborados que, às vezes, não conseguimos entender de imediato. Mostrei que o Enumerator é usado para fazer o loop, e esse código nos ajuda nesse sentido. Mas imagine uma coleção maior e mais dinâmica. Como gerenciar isso no Enumerator? O código se torna cada vez mais complexo.

Para simplificar, podemos encapsular essa lógica em um método:

```csharp
void PercorrendoDiasDaSemana()
{
    foreach (string dia in diasDaSemana)
    {
        Console.WriteLine(dia);
    }
}
```

E também podemos criar um método para percorrer com o Enumerator:

```csharp
void PercorrendoComEnumerator()
{
    var enumerator = diasDaSemana.GetEnumerator();
    while (enumerator.MoveNext())
    {
        var dia = enumerator.Current;
        Console.WriteLine(dia);
    }
}
```

**Utilizando o recurso yield do C#**  
No final das contas, o que importa para a coleção de Dia da Semana é justamente a coleção. No Visual Studio, selecionei sete elementos que representam os dias da semana. Todo o restante do código é repetido, um código de infraestrutura, que será repetido sempre que quisermos fazer a Enumerable de uma classe customizada. Será que o C# não oferece algum recurso que já nos entregue isso? A resposta é sim.

Qual é esse recurso e como vamos utilizá-lo? Vou copiar esses elementos, os sete da coleção, e voltar para o IEnumerable. No método GetEnumerator, vou usar essas coleções e colar na linha 85. Está ocorrendo um erro de compilação, então faremos alguns ajustes.

Para enumerar uma coleção, no caso, uma coleção com tamanho fixo de dias da semana, entregamos um a um: domingo, segunda, terça, apenas incrementando a posição do array interno e entregando o elemento a cada solicitação de um código consumidor, como o for each mencionado anteriormente. Para representar isso, existe uma instrução no C# chamada yield, que retorna o próximo elemento. Essa instrução é finalizada com ponto e vírgula. Faremos isso para todos os elementos.

```csharp
public IEnumerator<string> GetEnumerator()
{
    yield return "Domingo";
    yield return "Segunda";
    yield return "Terça";
    yield return "Quarta";
    yield return "Quinta";
    yield return "Sexta";
    yield return "Sábado";
}
```

**Explorando recursos de edição no Visual Studio**  
No Visual Studio, há um recurso interessante de edição em múltiplas linhas. Não tem relação com yield ou coleções, mas permite editar várias linhas ao mesmo tempo. Para isso, pressionamos CTRL + ALT e usamos a seta para baixo ou o cursor do teclado para selecionar as linhas desejadas. Com o cursor piscando em todas as linhas, digitamos yield return uma vez, e a instrução é replicada em todas as linhas. Para sair do modo de edição múltipla, pressionamos ESC.

**Concluindo a implementação com yield return**  
Voltando à questão do Enumerator, precisávamos entregar um elemento de cada vez na coleção de dias da semana. Fazíamos isso manualmente com o getEnumerator, controlando a posição e verificando se moveNext estava em uma posição válida. Agora, delegamos esse trabalho à máquina virtual do .NET com yield return. O yield return processa o elemento domingo e, se necessário, avança para a próxima posição. A máquina virtual gerencia a posição, criando uma máquina de estado que guarda a posição da coleção.

Quando o yield return é chamado, incrementa a posição e entrega o elemento atual. Por exemplo, ao chamar yield return pela primeira vez, a posição é zero e o elemento é domingo. Na próxima chamada, a posição é incrementada e o próximo elemento é entregue. Isso é feito automaticamente, sem a necessidade de criar manualmente um Enumerator.

Vamos verificar se a execução funciona percorrendo com o Enumerator. Na linha 15, chamamos o método percorrendo com o Enumerator:

```csharp
PercorrendoComEnumerator();
```

A classe Dia da Semana retorna o método getEnumerator, que não retorna mais o objeto antigo, pois usamos yield return. O método getEnumerator continua existindo e retornando o necessário. Ao pressionar F5, a execução continua a mesma: domingo, segunda, terça, quarta, quinta, agora usando o recurso yield, que abstrai o trabalho de criar um Enumerator para essa coleção.

Com o for each, o mesmo acontece, pois ele usa internamente o getEnumerator para movimentação. Não precisamos criar uma classe Dia da Semana Enumerator, que pode ser deixada como referência. No Visual Studio, o contador de referências da classe é zero, pois não está mais sendo usada. Deixamos como referência para mostrar como é complexo gerenciar uma coleção manualmente. Deixe esse trabalho para a máquina virtual.

O yield return é um recurso que nos auxilia nesse sentido.

### Aula 1: Otimizando a exibição de projetos na CodeConnect - Exercício

A CodeConnect, uma rede social para programadores, que permite curtidas, compartilhamento e comentários em projetos e códigos, está enfrentando um desafio de otimização na exibição de projetos. Atualmente, todos os projetos são carregados de uma vez, consumindo muita memória e tornando a navegação lenta. A equipe de desenvolvimento está considerando implementar uma solução que carregue os projetos sob demanda.

Como o conceito de Yield pode ser aplicado para otimizar essa funcionalidade, garantindo que apenas os projetos visíveis sejam processados e exibidos?

Resposta:  
Implementar um enumerador que utiliza Yield para carregar e processar projetos individualmente à medida que a pessoa usuária rola a página, exibindo apenas os projetos visíveis.

> Correta, pois o uso de Yield permite que os projetos sejam carregados sob demanda, processando e exibindo apenas aqueles que estão prestes a ser visualizados, melhorando a performance e reduzindo o uso de memória.

### Aula 1: Aprofundando o yield - Vídeo 6

Transcrição  
Conhecemos o operador YIELD, que nos ajuda a economizar o código que criamos para implementar enumeradores. Nossa implementação de IEnumerable ficou bem mais concisa e facilitada. Vamos explorar e aprofundar mais sobre o YIELD agora, mas trabalhando com uma coleção que não tem tamanho fixo. Anteriormente, trabalhamos com um dia da semana que tem sete elementos, mas e se quisermos trabalhar com uma coleção cujo tamanho é dinâmico?

No código, vamos apagar a linha 12 para não executar mais o percorrimento do dia da semana com o enumerador. Em seguida, criaremos uma lista de números pares com IEnumerable de números pares. Vamos criar um método IEnumerable<int> chamado NumerosPares. Nesse método, precisamos criar uma lista de inteiros. Já conhecemos o tipo List<int>, então criaremos uma lista vazia para isso e, no final, retornaremos essa lista. Essa é a primeira etapa.

```csharp
IEnumerable<int> NumerosPares()
{
    var Lista = new List<int>();
    return Lista;
}
```

**Gerando números pares**  
Precisamos gerar números pares dentro dessa lista. Para gerar a quantidade desejada de números pares, receberemos como argumento um inteiro que representa o limite: quantos números pares queremos gerar? Faremos um for com i começando de zero até i ser menor que o limite, incrementando i duas vezes. A lista Add será i multiplicado por 2. Vamos testar essa lógica ao imprimir.

```csharp
IEnumerable<int> NumerosPares(int limite)
{
    var Lista = new List<int>();
    for (var i = 0; i < limite; i++)
    {
        Lista.Add(i * 2);
    }
    return Lista;
}
```

Agora, temos os números pares usando a lista, mas ainda não apareceu o YIELD. Vamos fazer um foreach para pegar os 20 primeiros números pares e imprimir cada um deles com Console.WriteLine. Ao executar, esperamos que ele imprima 20 números pares, talvez 18, pois o zero é impresso primeiro. Ajustaremos a lógica do algoritmo conforme necessário.

```csharp
var pares = NumerosPares(20);
foreach(var par in pares) Console.WriteLine(par);
```

**Processando coleções de forma eficiente**  
O importante é entender que obtivemos a coleção e a colocamos em uma variável chamada pares. Somente depois processamos os elementos dessa coleção. O processamento aqui é simples, apenas imprimir no console, mas poderíamos realizar operações mais complexas para cada elemento. Ao obter a coleção, colocamos todos os 20 elementos em memória, pois chamamos o método com 20. No entanto, podemos querer obter números pares com um limite grande e não usar todos.

Na carreira de programação, perceberemos que, às vezes, o código que obtém a coleção está distante, até no tempo, do código que processa essa coleção. Não sabemos exatamente como o código foi obtido ou precisamos de uma coleção maior e processamos apenas uma parte devido a alguma condição. Não é sempre que obtemos x elementos de uma coleção e processamos todos.

Para demonstrar isso, faremos um código diferente. Teremos um contador que começa em 0 e é incrementado dentro do for. Se o contador ultrapassar 5, sairemos do loop, parando de processar a coleção. Isso significa que imprimiremos apenas um subconjunto da coleção, no caso, 6 elementos de uma coleção que tem 20 no total. Isso é útil quando temos um limite alto e queremos trabalhar de forma mais eficiente.

```csharp
var pares = NumerosPares(20);
var contador = 0;
foreach (var par in pares)
{
    contador++;
    Console.WriteLine(par);
    if (contador > 5) break;
}
```

**Introduzindo o YIELD para otimização**  
No entanto, há um problema nesse código. Quando chamamos o método NumerosPares com um limite de 10.000, criamos uma lista com 10.000 elementos, mas usamos apenas uma quantidade muito menor. Se precisarmos de performance e otimização, esse código é ineficiente, pois estamos gerando uma lista grande em memória quando só precisamos de uma parte. É aí que o YIELD nos ajuda.

O YIELD pode ser usado tanto para métodos que retornam um enumerador quanto para métodos que retornam um IEnumerable, como é o caso de NumerosPares. O YIELD nos ajuda na otimização desse processo. Não precisamos mais da lista, então a apagaremos e não a retornaremos. Em vez de lista.Add, usaremos YIELD RETURN. O código ficou mais conciso, mas a vantagem não é apenas a limpeza do código, mas também a otimização.

Vamos renomear o método NumerosPares para NumerosParesSemYield e faremos uma cópia desse método. Estamos explorando o aprendizado, por isso o código está assim. O método NumerosPares será com o YIELD, e aquele código não terá mais a lista.

```csharp
IEnumerable<int> NumerosParesComYield(int limite)
{
    for (var i = 0; i < limite; i++)
    {
        Console.WriteLine($"Processando elemento {i}...");
        yield return i * 2;
    }
}
```

**Comparando métodos com e sem YIELD**  
Aqui será o yield return do número do elemento. Lembremo-nos de que processamos o elemento, multiplicamos por 2, processamos o próximo elemento, e ele gerencia esse enumerador, a posição e tudo mais. Com números pares e yield, colocaremos um Console.WriteLine aqui dentro, processando o elemento. Vamos colocar o i aqui e a mesma coisa com o yield, processando o elemento. Este código é um exemplo de como estamos antecipando tudo a partir do limite: criamos a lista e fazemos tudo.

Ao executar no console, podemos ver a diferença. Ele executa todo o loop até o elemento 9999, coloca tudo na lista e, então, entrega a lista para processarmos e manipulamos esses dados, usando apenas 6 elementos. Este é o método sem yield, que faz isso. Observemos a quantidade de código que é inútil nesse caso. Vamos agora usar o número de pares com yield, executar e perceber que ele só fez o loop para os elementos necessários. Melhor ainda, processa o elemento, retorna o elemento, processa o elemento, retorna o elemento. Observemos a quantidade de código que reduzimos em termos de processamento, execução e memória usando o yield return.

O yield return ajuda na legibilidade e concisão, pois delegamos para a máquina virtual o que ela deve fazer, mas também otimiza bastante o programa. A questão é que o yield só pode ser usado para retornar um IEnumerable ou um IEnumerator. Existem também contraindicações: não devemos usar o yield quando não sabemos de onde vem a coleção. Às vezes, estamos processando uma coleção cuja geração é feita por nós, mas se estivermos pegando essa coleção de um arquivo ou fonte de dados que não controlamos, pode haver problemas. Se o recurso for descartado, como no método Dispose, pode haver problemas. Portanto, devemos ter cuidado ao usar yield com recursos caros que precisam ser liberados frequentemente. Quando temos uma lista em memória que controlamos, o yield é totalmente recomendado e vale a pena usar, pois já vimos a concisão e otimização de performance.

**Explorando o uso avançado do YIELD**  
Há mais coisas interessantes que podemos fazer com o número de pares com yield. Não precisaríamos necessariamente receber um limite. Poderíamos simplesmente ter a variável i começando com 0 e fazer um yield true, uma execução infinita, incrementando o elemento. Será que ficaria infinitamente nesse código? Na verdade, não, porque o yield return nos garante que isso só será processado sob demanda durante a execução. Com yield, não recebemos mais esse argumento como entrada. Ele processará quantas vezes? Essas 5 vezes. Vamos executar novamente a aplicação. Apesar de existir um loop infinito, a execução do código determina onde ele vai parar, que é justamente naquele break. Se precisar de um elemento, ele executa o código, MoveNext e Current. Não precisa mais? Acabou, ele não executará mais.

```csharp
IEnumerable<int> NumerosParesComYield()
{
    var i = 0;
    while(true)
    {
        Console.WriteLine($"Processando elemento {i}...");
        yield return i * 2;
        if (i > 100) yield break;
        i++;
    }
}
```

O yield tem outra construção, que é o yield break. Suponhamos que não queiramos ultrapassar a execução desses números pares além de um limite específico. Podemos fazer uma condição: se i for maior que 100, saímos. É como um circuito de interrupção que não permite execução infinita. O yield tem essas duas construções: o return, que processa o próximo elemento, e o yield break, que encerra a execução do enumerador. Vamos supor que queiramos ir até 200. Vou colocar um código para imprimir "saindo do enumerador". Ele processará os elementos, mas quando for maior que 100, sairá. Não chegará aos 200, pois tivemos esse circuito de interrupção dentro do while true.

O yield é uma maneira importante de percorrer coleções de maneira econômica, processando o próximo elemento sob demanda, e a máquina virtual cuida disso durante a execução do programa.

Terminamos aqui esta primeira parte, onde introduzimos coleções, a operação básica de percorrer uma coleção e discutimos alguns elementos desse processo. Na próxima aula, falaremos mais sobre os tipos de cada coleção.

### Aula 1: Para saber mais: casos de uso do yield

O yield pode parecer um detalhe de sintaxe, mas na prática ele resolve problemas bem comuns: como lidar com coleções grandes, fluxos de dados e processamento sob demanda.

Pense no yield como um podcast de episódios semanais. Você não precisa esperar que toda a temporada seja gravada para começar a ouvir. Os episódios vão sendo liberados um por um, e você consome apenas o que já foi publicado.

- Exemplo 1: Leitura de linhas em um arquivo grande
- Imagine que você precise processar um arquivo de 1 milhão de linhas.
- Se você carregar tudo na memória de uma vez, sua aplicação pode travar. Com yield, você lê uma linha por vez:

```csharp
static IEnumerable<string> LerArquivo(string caminho)
{
    using var reader = new StreamReader(caminho);

    string? linha;
    while ((linha = reader.ReadLine()) != null)
    {
        yield return linha;
    }
}

// Uso:
foreach (var linha in LerArquivo("dados.txt"))
{
    Console.WriteLine(linha);
}
```

➡️ Aqui, você pode começar a processar o arquivo imediatamente, sem esperar que todo ele seja carregado.

**Exemplo 2: Paginação de dados em banco**  
Suponha que você tenha que buscar registros em lotes (páginas) de 1000 em 1000, em vez de tudo de uma vez.

```csharp
static IEnumerable<List<T>> BuscarEmPaginas<T>(Func<int, List<T>> buscarPagina)
{
    int pagina = 0;
    while (true)
    {
        var resultados = buscarPagina(pagina);
        if (resultados.Count == 0)
            yield break; // acabou
        
        yield return resultados;
        pagina++;
    }
}

// Uso (exemplo com usuários fictícios):
foreach (var lote in BuscarEmPaginas(p => BuscarUsuarios(p)))
{
    Console.WriteLine($"Processando {lote.Count} usuários...");
}
```

➡️ Assim você processa página por página, evitando sobrecarregar a aplicação com todos os registros de uma vez.

**Exemplo 3: Geração de relatórios**  
Em vez de gerar todos os dados de um relatório antes de exibir, você pode ir liberando seções conforme são processadas:

```csharp
static IEnumerable<string> GerarRelatorio()
{
    yield return "Início do relatório";
    yield return "Seção 1: Dados gerais";
    yield return "Seção 2: Estatísticas";
    yield return "Seção 3: Conclusões";
    yield return "Fim do relatório";
}

// Uso:
foreach (var parte in GerarRelatorio())
{
    Console.WriteLine(parte);
}
```

➡️ Isso permite exibir resultados progressivamente, em vez de travar a aplicação até que tudo esteja pronto.

**Exemplo 4: Algoritmos complexos**  
No desenvolvimento de jogos ou simulações, o yield pode produzir os próximos passos de forma incremental.

```csharp
static IEnumerable<string> SimularPartida()
{
    yield return "Jogador 1 fez a jogada";
    yield return "Jogador 2 contra-atacou";
    yield return "Jogador 1 venceu a rodada";
}
```

➡️ Cada yield return representa um estado da simulação, que pode ser consumido conforme o motor do jogo precisa.

#### Em resumo

**O yield é ideal quando:**

- os dados são grandes (arquivos, coleções do banco de dados, logs);
- você quer processar sob demanda sem carregar tudo de uma vez;
- deseja produzir fluxos contínuos ou parciais (como logs em tempo real, relatórios incrementais, simulações).

O yield é como uma esteira de produção: você não espera o produto inteiro ser fabricado para começar a usá-lo, ele sai em partes.

### Aula 1: Faça como eu fiz: Coleções e Yield

Nesta aula, exploramos a manipulação de coleções usando C# e como otimizar iterações com o yield return.

Agora é sua vez de praticar os conceitos apresentados. Para isso:

- Abra o Visual Studio com a solução que contém vários projetos do tipo console;
- Selecione o projeto desejado a partir da lista suspensa;
- Abra o arquivo Program.cs e remova o código padrão;
- Crie uma coleção para representar os dias da semana utilizando array ou ArrayList;
- Defina uma classe Produto com propriedades Nome (string) e Preço (double);
- Inicialize uma coleção 'carrinho' com instâncias da classe Produto;
- Implemente um loop for para acessar elementos utilizando índices iniciando em zero;
- Utilize o foreach para iterar de forma mais simples sobre a coleção;
- Organize o código separando a lógica de iteração em métodos distintos;
- Implemente a interface IEnumerable em uma classe personalizada para os dias da semana;
- Desenvolva o método GetEnumerator utilizando yield return para simplificar o enumerator;
- Crie um método que gere números pares e otimize a memória com yield return;
- Teste a execução dos métodos no console e ajuste a lógica conforme necessário.

### Aula 1: O que aprendemos?

Nesta aula, aprendemos:

- A diferença entre Arrays e Listas em C#, incluindo suas capacidades de redimensionamento.
- O uso de Generics para garantir segurança de tipo em coleções no C#.
- A utilização do foreach para simplificar a iteração sobre coleções.
- O uso do yield para criar iteradores de forma concisa e eficiente no C#.
- A implementação de classes iteráveis personalizadas com as interfaces IEnumerable`<T>` e IEnumerator`<T>`.
- A importância de métodos como MoveNext, Reset e Current para gerenciar iterações.
- Como encapsular lógica utilizando métodos para melhorar a organização do código.
- O impacto positivo do yield na performance e otimização de memória ao lidar com coleções grandes.

## Aula 2: Operações com coleções

### Aula 2: Projeto da aula anterior

Na aula anterior, demos os primeiros passos na manipulação de dados e agora avançamos para entender melhor como representar e percorrer coleções em C#. Exploramos arrays, listas, coleções genéricas e vimos como o foreach facilita a leitura dos elementos. Também mergulhamos na implementação de IEnumerable, IEnumerator e no uso do operador yield para simplificar o código. Para acompanhar o projeto desenvolvido até aqui, acesse o [repositório do curso no GitHub](https://github.com/alura-cursos/data-manipulation-with-csharp/tree/main/01-IntroAColecoes).

### Aula 2: Playlist de músicas - Vídeo 1

Transcrição  
Para realizar manipulação de dados, começamos a estudar coleções, pois é algo que faremos com frequência em nossa carreira como pessoas desenvolvedoras. Vamos continuar nosso estudo sobre coleções.

No Visual Studio, vamos fechar o arquivo program.cs do projeto do tópico 1. Fecharemos essa aba e abriremos o program.cs do projeto número 2. No gerenciador de soluções, no projeto número 2, daremos um duplo clique no program.cs. Aparecerá o console com "Hello World", que é típico quando criamos um novo projeto do tipo console.

```csharp
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
```

Para finalizar essa preparação, na barra inicial do Visual Studio, onde temos o menu suspenso que aponta para o projeto número 1, "intro a coleções", vamos selecionar o número 2, "operações em coleções", que é o tópico desta parte do curso.

**Introduzindo o projeto de aplicativo de música**  
Agora, vamos introduzir nossas atividades e o enunciado do que faremos nesta parte do estudo. Selecionaremos as linhas 1 e 2, apagaremos e colaremos os exercícios que vamos realizar. Nesta parte, trabalharemos com um aplicativo de música, no contexto de um aplicativo de gerenciamento de músicas, onde os usuários podem organizar suas faixas favoritas em playlists personalizadas. Para cada playlist, é essencial que o usuário tenha controle total sobre a sequência de reprodução das músicas, permitindo ordená-las livremente a qualquer momento. Além disso, o aplicativo precisa oferecer a funcionalidade de reprodução aleatória.

```csharp
/*
Seja um aplicativo de gerenciamento de músicas onde os usuários podem organizar suas faixas
favoritas em playlists personalizadas. Para cada playlist, é essencial que o usuário tenha
controle total sobre a sequência de reprodução das músicas, permitindo reordená-las
livremente a qualquer momento. Além disso, o aplicativo precisa oferecer a funcionalidade de
reprodução aleatória para uma playlist específica, proporcionando uma experiência de audição
dinâmica e variada, sem, contudo, alterar a ordem original que o usuário definiu. O desafio
é criar uma estrutura robusta que suporte a adição e remoção eficiente de músicas, a
reordenação flexível dentro das playlists e a seleção de faixas tanto em modo sequencial
quanto aleatório.
*/
Funcoes que vamos implementar:
// [ ] Criar as classes para musicas e playlist
// [ ] Listar musicas da playlist
// [ ] Adicionar musica à playlist
// [ ] Obter uma musica especifica da playlist
// [ ] Remover musica da playlist
// [ ] Tocar uma musica aleatoria da playlist
// [ ] Reordenar musicas segundo alguma logica especifica (ex. duracao)
// [ ] Uma playlist nao pode ter musicas repetidas
// [ ] Exibir as 10 musicas mais tocadas em todas as playlists (ranking)
// [ ] Player de musica com:
// [ ] - Fila de reproducao (para musicas avulsas e/ou playlists)
// [ ] - Historico de reproducao
```

**Criando classes para músicas e playlists**  
Há uma série de funcionalidades descritas no parágrafo inicial, e temos as funções que gostaríamos de implementar: criar as classes Músicas e Playlists, listar músicas, adicionar, obter uma música por seu título, remover, tocar uma música aleatória da playlist, entre outras. À medida que implementamos essas funções, aprenderemos mais sobre coleções dentro do .NET.

Vamos começar criando essas classes: uma classe para música e uma classe para playlist. Lembrando que, na construção de uma aplicação do tipo console, onde não temos nenhum código escrito no Program.js, a declaração de classes fica no final. Vamos declarar a classe Música, que terá uma propriedade do tipo inteiro para o título, uma propriedade do tipo string para o artista e uma propriedade do tipo inteiro para a duração. A duração será em segundos, então guardaremos um inteiro para isso, sem casas decimais.

```csharp
using System.Collections;

class Musica
{
    public string Titulo { get; set; }
    public string Artista { get; set; }
    public int Duracao { get; set; }
}
```

A próxima classe será para representar playlists. A classe Playlists terá, por enquanto, o nome da playlist. Criamos essas duas classes e, para exemplificar, vamos criar objetos dessas classes. Vamos criar algumas músicas, onde cada música será uma instância da classe Música e terá um título.

```csharp
class Playlist
{
    public string Nome { get; set; }
}
var musica1 = new Musica { Titulo = "Que Pais é Esse?", Artista = "Legião Urbana", Duracao = 350 };
var musica2 = new Musica { Titulo = "Tempo Perdido", Artista = "Legião Urbana", Duracao = 455 };
var musica3 = new Musica { Titulo = "Pro Dia Nascer Feliz", Artista = "Barão Vermelho", Duracao = 345 };
var musica4 = new Musica { Titulo = "Eduardo e Mônica", Artista = "Legião Urbana", Duracao = 530 };
var musica5 = new Musica { Titulo = "Geração Coca-Cola", Artista = "Legião Urbana", Duracao = 350 };
```

**Adicionando músicas à playlist e exibindo no console**  
Agora, vamos criar uma playlist chamada "Rock Nacional". Criamos seis objetos: cinco músicas e uma playlist. O próximo passo é adicionar essas músicas à playlist. Vamos preparar o código que exibirá essa playlist no console. Criamos um método chamado ExibirPlaylist, que recebe a playlist como argumento. Primeiro, vamos pular uma linha e exibir "Tocando as músicas de", seguido do nome da playlist usando interpolação de strings. Em seguida, usamos um for para iterar sobre as músicas na playlist e exibir o título de cada uma.

```csharp
var rockNacional = new Playlist { Nome = "Rock Nacional" };

void ExibirPlaylist(Playlist playlist)
{
    Console.WriteLine($"\n Tocando as musicas de {playlist.Nome}");
    foreach(var musica in playlist)
    {
        Console.WriteLine($"\t - {musica.Titulo}");
    }
}
```

No entanto, o código não está compilando porque a playlist precisa implementar a interface IEnumerable. Isso é necessário para percorrer coleções. Vamos implementar IEnumerable na classe playlist. Para isso, precisamos de um método que retorne um IEnumerator de música. Vamos implementar o método GetEnumerator, que delega para o método que já criamos.

```csharp
class Playlist : IEnumerable<Musica>
{
    private List<Musica> lista = new List<Musica>();

    public IEnumerator<Musica> GetEnumerator()
    {
        return lista.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void AdicionarMusica(Musica musica)
    {
        lista.Add(musica);
    }
}
```

**Implementando ICollection para manipulação avançada**  
A playlist agora implementa IEnumerable de música, e o código para percorrê-la funciona normalmente. No código da classe Prog, já criamos as classes para músicas e playlists e estamos tentando listar as músicas da playlist. Para adicionar músicas à playlist, criamos um método que retorna void e adiciona músicas a uma coleção auxiliar. Inicializamos uma lista de músicas vazia e, no método AdicionarMúsica, adicionamos a música à coleção interna.

```csharp
rockNacional.AdicionarMusica(musica1);
rockNacional.AdicionarMusica(musica2);
rockNacional.AdicionarMusica(musica3);
rockNacional.AdicionarMusica(musica4);
rockNacional.AdicionarMusica(musica5);

ExibirPlaylist(rockNacional);
```

Com isso, conseguimos retornar o Enumerator da lista, e o código compila completamente, permitindo exibir a playlist de músicas. Precisamos agora adicionar todas as músicas criadas à playlist. Copiamos e colamos a linha de código para adicionar cada música.

Recapitulando, criamos uma classe do tipo música e cinco objetos dessa classe. Criamos uma classe do tipo playlist, um objeto dessa classe, e adicionamos as cinco músicas. Para percorrer a playlist, implementamos a interface IEnumerable, que usa uma lista interna. Criamos também um método para adicionar músicas à lista interna.

Executamos o método e verificamos o resultado no terminal. A playlist exibe as músicas de "Rock Nacional", com um "Tab" e um traço, seguidos das cinco músicas adicionadas. A ordem de exibição é a ordem de inclusão, característica do tipo lista.

**Implementando ICollection para manipulação avançada**  
Além disso, podemos precisar adicionar, remover ou totalizar músicas na playlist. Essas funções estão previstas na interface ICollection, que já implementa IEnumerable e fornece métodos comuns. Vamos fazer com que a playlist seja uma coleção de músicas, implementando a interface ICollection.

```csharp
class Playlist : ICollection<Musica>
{
    private List<Musica> lista = new List<Musica>();

    public int Count => lista.Count;
    public bool IsReadOnly => false;

    public void Add(Musica item)
    {
        lista.Add(item);
    }

    public void Clear()
    {
        lista.Clear();
    }

    public bool Contains(Musica item)
    {
        return lista.Contains(item);
    }

    public void CopyTo(Musica[] array, int arrayIndex)
    {
        lista.CopyTo(array, arrayIndex);
    }

    public bool Remove(Musica item)
    {
        return lista.Remove(item);
    }

    public IEnumerator<Musica> GetEnumerator()
    {
        return lista.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
```

Implementamos a interface ICollection, que adicionou vários métodos. Discutimos esses métodos, como a propriedade que entrega o total de músicas na playlist, que implementamos passando o count da lista. A propriedade de somente leitura retorna falso, pois a playlist não é somente leitura.

O método Add foi ajustado para usar o método da ICollection, removendo o método AdicionarMúsica anterior. O método Clear limpa a coleção, e outros métodos delegam para a lista interna. Implementamos todos os métodos e propriedades previstos na interface ICollection, mantendo a coerência com a biblioteca do .NET.

**Ajustando o código para usar ICollection**  
Continuamos a percorrer a playlist de músicas, pois ICollection implementa IEnumerable. Os métodos para adicionar músicas agora se chamam Add. Usamos a função do Visual Studio para editar várias linhas ao mesmo tempo, ajustando o código para usar Add.

```csharp
rockNacional.Add(musica1);
rockNacional.Add(musica2);
rockNacional.Add(musica3);
rockNacional.Add(musica4);
rockNacional.Add(musica5);
```

Executamos novamente o código para garantir que a execução continua a mesma. Agora, para se manter coerente com os tipos disponíveis para coleções, implementamos ICollection em vez de IEnumerable, pois a playlist é uma coleção de músicas. Podemos remover músicas da playlist, verificar se uma música existe e realizar outras operações. Vamos continuar nosso estudo na sequência.

### Aula 2: Músicas aleatórias - Vídeo 2

Transcrição  
Vamos continuar a implementação das funções relacionadas a playlists e músicas. O próximo passo é obter uma música específica de uma playlist através do título e removê-la. Vamos entender como fazer isso no código do programa.

Primeiro, criamos as músicas, a playlist e adicionamos as músicas à playlist. Em seguida, exibimos essa playlist. Agora, vamos pegar uma música específica, por exemplo, dentro da playlist chamada "rock nacional". Vamos criar um método para obter a música pelo título e passaremos o título "Que País É Este". Vamos usar outro nome, como "Eduardo e Mônica". Se a música for encontrada, saberemos disso verificando se a variável é nula ou não. Se encontrada, vamos removê-la e exibir uma mensagem indicando a remoção.

**Declarando variáveis e buscando música**  
Para começar, vamos declarar uma variável para armazenar a música encontrada:

```csharp
var musicaEncontrada;
```

Em seguida, vamos buscar a música pelo título "Eduardo e Mônica":

```csharp
var musicaEncontrada = rockNacional.ObterPeloTitulo("Eduardo e Mônica");
```

Agora, verificamos se a música foi encontrada. Se sim, removemos a música e exibimos uma mensagem:

```csharp
if (musicaEncontrada is not null)
{
    Console.WriteLine("\nRemovendo música...");
    rockNacional.Remove(musicaEncontrada);
}
else
{
    Console.WriteLine("\nMúsica não encontrada!");
}
```

**Criando o método ObterPeloTitulo**  
Já temos um método remove, que faz parte da implementação da iCollection de música, então podemos utilizá-lo. Precisamos implementar o método para obter a música pelo título. Vamos adicionar um else para o caso de a música não ser encontrada, exibindo uma mensagem correspondente.

Vamos criar o método ObterPeloTitulo dentro da playlist. Ele será semelhante ao Contains, mas o argumento de entrada será uma string representando o título. O retorno será uma música ou nulo, representado por ?. Faremos um for para pesquisar cada música na lista. Se música.título for igual ao título, retornaremos a música. Percorreremos a lista sequencialmente, e se encontrarmos a música, retornaremos e sairemos do loop. Caso contrário, retornaremos nulo.

```csharp
public Musica? ObterPeloTitulo(string titulo)
{
    foreach(var musica in Lista)
    {
        if (musica.Titulo == titulo)
        {
            return musica;
        }
    }
    return null;
}
```

**Executando a nova versão do programa**  
Agora, vamos executar essa nova versão do programa. Criamos a playlist, exibimos e removemos a música da playlist. Vamos copiar a linha de exibição da playlist e colá-la no final do programa para mostrar a playlist antes e depois da remoção da música. Ao executar, veremos no console que criamos a playlist, adicionamos as músicas e removemos uma delas. Conseguimos implementar o método ObterPeloTitulo e exibimos novamente a playlist com quatro elementos, sem a música "Eduardo e Mônica".

**Implementando a seleção de música aleatória**  
Já temos as funções para obter uma música específica pelo título e remover uma música da playlist, que já estava disponível através da implementação do iCollection. O próximo passo é tocar uma música aleatória da playlist. Para isso, precisamos pegar uma música de forma aleatória dentro da coleção. Sabemos que a coleção é implementada por um objeto do tipo List, que possui acesso sequencial e indexado.

Para acessar um elemento específico da lista, usamos colchetes. Por exemplo, para pegar o primeiro elemento, usamos o índice zero. Se quisermos outro elemento, usamos um índice diferente, como 3. O problema é que não sabemos o tamanho da lista. Vamos usar essa ideia para obter uma música aleatória. Se temos 10 elementos na lista, procuraremos um número aleatório entre 0 e 9 e pegaremos o elemento correspondente.

**Criando o método ObterAleatoria**  
Vamos criar um método ObterAleatoria ao lado do ObterPeloTitulo. Ele não terá argumentos de entrada e retornará uma música. Para obter um número aleatório no .NET, usamos um objeto do tipo Random. Com o método Next, definimos a faixa de valores desejada, que vai de 0 até lista.count - 1. Assim, obtemos um índice aleatório e retornamos a música correspondente.

```csharp
public Musica? ObterAleatoria()
{
    if (Lista.Count == 0) return null;

    var random = new Random();
    var indiceAleatorio = random.Next(0, Lista.Count - 1);
    return Lista[indiceAleatorio];
}
```

Dessa forma, temos um método que obtém uma música aleatória, garantindo que sempre retornaremos um valor válido.

**Protegendo contra listas vazias**  
Ah, está certo, esquecemos de uma coisa. A lista pode ser nula porque ela pode estar vazia. Então, o que faremos? Se lista.count for 0, ou seja, se a lista estiver vazia, retornaremos um valor nulo. Dessa forma, nos protegemos para não tentar encontrar um elemento em uma lista vazia, evitando erros ao chamar o método ObterAleatoria em uma playlist vazia.

**Executando a seleção de música aleatória**  
Subindo novamente na execução, agora conseguimos obter uma música aleatória. Vamos colocar isso após a exclusão da música. Vamos pegar uma música aleatória através da playlist rock usando ObterAleatoria e exibir. Se musicaAleatoria não for nula, imprimiremos:

```csharp
var musicaAleatoria = rockNacional.ObterAleatoria();
if (musicaAleatoria is not null)
{
    Console.WriteLine($"\nA música aleatória é {musicaAleatoria.Titulo}");
}
else
{
    Console.WriteLine("Playlist vazia!");
}
```

Temos, então, o código que implementa a obtenção de uma música aleatória. Vamos executar e, no console, exibiremos a playlist com as cinco músicas originais. Removemos a música "Eduardo e Mônica" e, novamente, exibimos a playlist sem essa música. Obtivemos uma música aleatória através do código ObterAleatoria, mostrando que o acesso é indexado. Obtemos um índice aleatório e, assim, conseguimos acessar um elemento dessa coleção. No caso, a música aleatória foi "Tempo Perdido".

**Concluindo a implementação**  
Muito bem, nas nossas funções, já conseguimos tocar uma música de forma aleatória. Na sequência, continuaremos implementando essas funções para reordenar uma música segundo uma lógica específica.

### Aula 2: Ordenando playlists - Vídeo 3

Transcrição  
Para ordenar uma música dentro da playlist, segundo uma loja específica, por exemplo, por duração, as músicas menores ficam ordenadas primeiro. Precisamos implementar um método dentro da playlist para realizar essa tarefa. No código, vamos até a classe playlist e navegamos para o final do código, onde está localizada. Próximo aos métodos que criamos, como obter pelo título e obter aleatória, vamos adicionar um novo método. Este método não retornará nada, mas será responsável por ordenar por duração. O nome do método será OrdenarPorDuracao.

Para começar, vamos definir o método OrdenarPorDuracao na nossa classe:

```csharp
public void OrdenarPorDuracao()
{
}
```

Agora que temos o método criado, precisamos implementar a lógica de ordenação. Para ordenar uma lista, utilizamos o método Sort dos objetos do tipo List. A questão que surge é: como informamos qual propriedade queremos ordenar? Vamos abordar isso em breve. Chamamos o método Sort e, no código de execução, vamos invocar esse método.

```csharp
public void OrdenarPorDuracao()
{
    Lista.Sort();
}
```

**Organizando e limpando o código de execução**  
Antes disso, vamos limpar um pouco o código de execução, mantendo apenas a adição das músicas e a exibição da playlist de forma original. Vamos organizar os métodos de obter música pelo título e obter música aleatória.

Criamos o método remover_musica_pelo_titulo, passando a playlist e o título como argumentos de entrada. Transferimos o código das linhas 37 a 47 para dentro desse método. Substituímos "rock nacional" por playlist, que é o argumento de entrada, e verificamos se tudo está correto. O método tenta encontrar a música pelo título; se encontrada, remove-a, caso contrário, informa que não foi encontrada. De qualquer forma, continua exibindo a playlist.

Também criamos um método para exibir música aleatória, transferindo o código das linhas 39 a 46 para dentro desse método. Passamos a playlist como argumento de entrada para permitir uma execução dinâmica. O método seleciona uma música aleatória e exibe as informações.

**Demonstrando a ordenação por duração**  
Queremos ordenar por duração. Criamos o método OrdenarPorDuracao na playlist e, em seguida, exibimos a playlist. A ordenação de uma lista, um objeto do tipo List, é sequencial, seguindo a ordem de inclusão. Para demonstrar isso, trocamos as linhas 29 e 30, adicionando a música "tempo perdido" primeiro. Ao chamar OrdenarPorDuracao, esperamos que a duração das músicas seja exibida em ordem crescente.

Para visualizar isso, além do título, incluímos mais informações, como o artista e a duração em segundos, separadas por um hífen.

```csharp
Console.WriteLine($"\t - {musica.Titulo} ({musica.Artista}) - {musica.Duracao} segundos");
```

Agora, temos todas as informações necessárias para ordenar por outras propriedades, se desejado, no método exibir_playlist.

**Implementando a interface IComparable**  
Ao executar o código, encontramos um problema. A execução foi até o ponto de exibir a playlist com as novas informações, mas a ordenação não ocorreu como esperado. Ao retornar ao Visual Studio, identificamos uma exceção não tratada: System.InviteOperation. A mensagem indica que houve uma falha ao comparar dois elementos na coleção, pois pelo menos um objeto precisa implementar IComparable.

O método Sort requer que um dos elementos implemente IComparable. Todos os elementos da lista são do tipo Musica, então a classe Musica precisa implementar a interface IComparable para que o método Sort funcione. O IComparable requer um método chamado CompareTo, que retorna um inteiro e recebe um objeto como argumento de entrada.

Vamos implementar a interface IComparable na classe Musica:

```csharp
class Musica : IComparable
{
    public int CompareTo(object? obj)
    {
        // iguais: 0; menor: -1; maior: 1
        if (obj is null) return 1;

        Musica outraMusica = obj as Musica;
        return this.Duracao.CompareTo(outraMusica.Duracao);
    }
}
```

**Explicando a lógica de comparação**  
A lógica da comparação é a seguinte: se os objetos forem iguais, retornamos zero. Se o objeto da classe for menor, retornamos -1. Se o objeto passado como argumento for maior, retornamos 1. No final, retornamos zero se for igual, negativo se for menor e positivo se for maior. Vamos implementar essa lógica.

A primeira coisa a considerar é que, se o outro objeto for nulo, retornamos -1, indicando que ele é menor. Precisamos verificar se esse objeto é do tipo música, pois ele não está sendo passado como tal. Se o objeto na variável order for do tipo música, podemos compará-lo. Vamos criar uma variável para representar esse objeto que estamos comparando. Assim, ao mesmo tempo que verificamos o tipo, capturamos o objeto em uma variável. Se a variável order for do tipo música, comparamos este objeto, this, pela sua duração, chamando o método compareTo com o objeto na variável outra música.

A lógica de comparação da duração está aqui. A duração, que é do tipo inteiro, também implementa a interface IComparable. Ao pressionar a tecla Ctrl e clicar em cima de int, podemos ver a definição da classe que representa um inteiro. No .NET, a classe que representa um inteiro é Int32. A palavra reservada int é apenas um apelido para um objeto do tipo Int32, que implementa IComparable, entre outras coisas. Assim, podemos usar o método compareTo no retorno.

Se a variável other não for uma música, mas também não for nula, continuamos retornando -1, indicando que ainda é menor. Essa é a lógica adotada aqui. Se houver algum problema com esse -1, podemos ajustá-lo conforme necessário.

**Testando a ordenação por duração**  
Nosso método Sort na playlist, ao ordenar por duração, não apresentará mais problemas, pois os tipos dos elementos na lista implementam IComparable. O método percorrerá a lista, verificando se a duração de uma música é menor que a de outra, e fará a reordenação com base na lógica implementada no IComparable, no método CompareTo.

Ao executar o programa, não teremos mais erros. A ordenação agora coloca a música mais curta, "Pro Dia Nascer Feliz", em primeiro lugar, seguida por "Que País É Este?", "Geração Coca-Cola", "Tempo Perdido" e, por fim, "Eduardo e Mônica", que é uma música realmente longa, sendo a última da playlist.

**Criando comparadores personalizados**  
Para ordenar uma coleção, usamos o método Sort. Caso queiramos fazer uma comparação por outra lógica, como ordenar por artista, a primeira ideia seria alterar a lógica no método CompareTo. No entanto, se quisermos fazer isso de forma dinâmica, teremos que recompilar o código e entregar uma nova versão. Para resolver isso, podemos criar funções que permitam a ordenação por diferentes critérios, como duração ou artista.

Podemos extrair a lógica de ordenação para uma classe. Vamos criar uma classe chamada PorArtista, que implementará a interface Comparer, responsável pela lógica de comparação. Esta classe terá um método que recebe dois argumentos de entrada, representando as duas pontas da comparação. A lógica será a mesma: se x ou y forem nulos, retornamos 0, indicando que são iguais. Se x for nulo, retornamos 1, indicando que y é maior. Se y for nulo, retornamos -1, indicando que x é maior. Por fim, comparamos x.artista com y.artista.

```csharp
class PorArtista : IComparer<Musica>
{
    public int Compare(Musica? x, Musica? y)
    {
        if (x is null || y is null) return 0;
        if (x is null) return 1;
        if (y is null) return -1;
        return x.Artista.CompareTo(y.Artista);
    }
}
```

**Implementando comparadores por título e artista**  
Da mesma forma, podemos criar uma classe PorTitulo, implementando IComparer de música, com um código semelhante. Basta copiar o método compare do comparador por artista e alterar o nome da propriedade para título.

```csharp
class PorTitulo : IComparer<Musica>
{
    public int Compare(Musica? x, Musica? y)
    {
        if (x is null || y is null) return 0;
        if (x is null) return 1;
        if (y is null) return -1;
        return x.Titulo.CompareTo(y.Titulo);
    }
}
```

Agora, temos dois comparadores adicionais: por artista e por título, além do comparador padrão por duração. Para usar esses comparadores, no método OrdenarPorDuração, utilizamos a ordenação padrão. Podemos criar outro método, OrdenarPorArtista, que chama o método Sort, passando um objeto PorArtista, que é um Comparer de música, com a lógica de ordenação por artista.

```csharp
public void OrdenarPorArtista()
{
    Lista.Sort(new PorArtista());
}
```

**Testando a ordenação por diferentes critérios**  
Vamos testar isso na execução. Exibimos a playlist original, ordenamos por duração e, em seguida, por artista. As músicas da Legião Urbana ficam juntas, conforme esperado. A execução mostra três exibições: a ordem original de inclusão, a ordenação por duração e, finalmente, a ordenação por artista, começando com Barão Vermelho e seguindo com todas as músicas da Legião Urbana.

Implementamos a ordenação de forma flexível, com lógicas de ordenação separadas em classes, que podemos usar conforme necessário. O método Sort está disponível na classe List e em outras classes que representam coleções. Vamos explorar possíveis problemas em vídeos futuros. Até a próxima!

### Aula 2: Otimizando a ordem de entregas na Hermex Log - Execício

A Hermex Log, uma empresa de logística especializada em serviços de entrega, está buscando otimizar a ordem de suas entregas diárias para melhorar a eficiência e reduzir custos. A equipe de desenvolvimento que você faz parte está encarregada de criar um sistema que ordene as entregas com base em diferentes critérios, como distância, tempo estimado de entrega e prioridade do cliente. No entanto, a equipe enfrenta o desafio de implementar um sistema flexível que permita alterar dinamicamente o critério de ordenação sem a necessidade de recompilar o código.

Qual abordagem seria mais adequada para criar um sistema que permita essa flexibilidade na ordenação das entregas?

Resposta correta:  
Implementar diferentes comparadores para cada critério de ordenação desejado, como distância, tempo estimado de entrega e prioridade do cliente, cada um como uma classe separada que implementa uma interface de comparação, permitindo a escolha dinâmica do comparador.

> Correta, pois essa abordagem permite que o sistema escolha dinamicamente qual comparador usar com base nas necessidades do momento, eliminando a necessidade de recompilar o código sempre que o critério de ordenação mudar.

### Aula 2: Evitando músicas repetidas - Vídeo 4

Transcrição  
Vamos continuar avançando na implementação das funções que fomos designados para desenvolver. Já fizemos bastante progresso. O próximo passo é garantir que uma playlist não possa ter músicas repetidas. Será que estamos permitindo músicas repetidas? Vamos verificar.

Vou remover o código que ordena por duração e por artista, deixando a ordem original para demonstrar algo. Vamos tentar adicionar novamente a música "dois". Chamei a função adicionar_musica duas vezes para a música "dois". Vamos ver se ele permite músicas repetidas. De fato, a música "Tempo Perdido" foi incluída no início e depois novamente. Não podemos permitir que músicas repetidas sejam adicionadas à nossa playlist.

**Implementando verificação de músicas repetidas**  
Para verificar se estamos permitindo músicas repetidas, podemos adicionar a música novamente usando o seguinte código:

```csharp
rockNacional.Add(musica2);
```

Como podemos resolver isso? Podemos, por exemplo, verificar se a música já existe no momento em que estamos navegando para o método adicionar_musica. Podemos verificar se a música existe na playlist a partir do título. Se a música não existir, adicionamos; caso contrário, não fazemos nada. Essa é uma maneira de resolver, mas precisamos escrever um pouco de código.

Primeiro, vamos criar uma variável para verificar se a música já existe:

```csharp
var musicaExistente;
```

Em seguida, vamos obter a música pelo título:

```csharp
var musicaExistente = this.ObterPeloTitulo(musica.Titulo);
```

Agora, podemos verificar se a música já existe e, se não existir, adicioná-la à lista:

```csharp
if (musicaExistente is null)
{
    Lista.Add(musica);
}
```

**Utilizando HashSet para evitar duplicatas**  
Além disso, o método de obtenção pelo título faz um acesso a toda a lista. Se tivermos uma playlist com milhares de músicas, como uma playlist compartilhada por várias pessoas, e uma nova música for adicionada, ele percorrerá todos os elementos da playlist para encontrar o título. Isso pode ser um problema de desempenho.

Como podemos resolver isso? Podemos usar outro tipo de coleção, criado para impedir elementos repetidos: o HashSet. Em vez de usar uma lista de músicas, usaremos um HashSet. O HashSet é um conjunto que, por definição, não possui elementos repetidos.

Vamos começar definindo nossa coleção interna como um HashSet:

```csharp
private HashSet<Musica> lista = [];
```

Ao trocar a implementação da nossa coleção interna de playlist de List para HashSet, introduzimos alguns erros no código. Por exemplo, ao obter uma música aleatória, não conseguimos fazer um acesso indexado a um HashSet. Além disso, não conseguimos ordenar um HashSet, pois ele não tem uma ordem sequencial.

**Mantendo funcionalidades com listas e HashSet**  
Como podemos usar as duas funcionalidades? Podemos manter a lista e também um HashSet de músicas. A classe Playlist encapsula todo o comportamento necessário para isso. Podemos manter as duas coleções internamente: uma para garantir que não haja músicas repetidas e a outra para funcionalidades como ordenação e acesso sequencial.

Vamos definir ambas as coleções:

```csharp
private HashSet<Musica> set = [];
private List<Musica> lista = [];
```

Na hora de adicionar uma música, não percorreremos mais a lista para obter o título. Usaremos o método add do HashSet, que internamente verifica se a música já existe. Se a música for igual a algum outro elemento, ele não a adicionará novamente. O método add do HashSet retorna um valor booleano, indicando se a música foi adicionada ou não.

Vamos adicionar a música ao HashSet:

```csharp
set.Add(musica);
```

Se conseguirmos adicionar a música no HashSet, também a adicionamos na lista, garantindo que estamos adicionando de forma única:

```csharp
if (set.Add(musica))
{
    lista.Add(musica);
}
```

**Testando a implementação com HashSet**  
Com isso, conseguimos ter o acesso sequencial e evitar músicas repetidas na playlist.

Acesso indexado continua mantendo a ordenação, tudo isso porque utilizamos a lista para realizar esse trabalho. A funcionalidade de impedir músicas repetidas está sendo obtida através do HashSet. Vamos executar novamente nosso código para verificar se conseguimos implementar isso. Mencionamos que o HashSet impede músicas repetidas, então vamos ver se realmente funciona.

Para testar, podemos tentar adicionar uma nova música:

```csharp
rockNacional.Add(new Musica { Titulo = "Eduardo e Mônica", Artista = "Legião Urbana", Duracao = 530 });
```

Parece que funcionou. Tentamos incluir novamente "Tempo Perdido" e não foi incluído. Vamos realizar mais um teste, mas agora criaremos uma nova música, New Música, com o título "Eduardo e Mônica", artista "Legião", e duração de 530. A música é a mesma: "Eduardo e Mônica" da Legião Urbana, com duração de 530. Vamos executar nosso código para verificar se, desta vez, ele deixou de incluir "Eduardo e Mônica".

**Sobrescrevendo métodos para comparação de objetos**  
Por que isso está acontecendo? O comportamento padrão de um HashSet é verificar se os elementos dessa coleção são iguais através da comparação de objetos. Quando adicionamos uma música novamente na playlist, o mesmo objeto através da variável Música 2, ele entendeu que era um objeto igual e não permitiu a inclusão. Porém, ao criar um novo objeto com new, criamos um novo objeto em uma nova área de memória, e para ele, é um novo objeto, então não impediu a inclusão.

A pergunta que fazemos é: como sobrescrevemos esse comportamento de verificar a igualdade de um determinado tipo, no caso, música? O comportamento padrão para verificar a igualdade de música é através da verificação se os objetos estão ocupando a mesma área de memória no processo. Como sobrescrevemos isso? Precisamos sobrescrever alguns métodos na classe Música, e é o que faremos agora.

Na classe Música, vamos sobrescrever dois métodos para mudar o comportamento padrão de igualdade. O primeiro método a ser sobrescrito é o equals. Estamos sobrescrevendo o método equals, que verifica se um objeto é igual a outro. Se o objeto for nulo, ele não é igual, retornando falso. Se o objeto não for do tipo música, também retorna falso. Caso o objeto seja do tipo música, pegamos esse objeto em uma variável do tipo música e comparamos this.título.equals(outraMúsica.título) e this.artista.equals(outraMúsica.artista). Estamos dizendo que uma música é igual a outra quando o título e o artista forem iguais.

Vamos começar sobrescrevendo o método equals:

```csharp
public override bool Equals(object? obj)
{
    if (obj is null) return false;
    if (obj is Musica outraMusica)
        return this.Titulo.Equals(outraMusica.Titulo) && this.Artista.Equals(outraMusica.Artista);
    return false;
}
```

Falta o último caso, quando o objeto não é do tipo música, e sempre retornamos falso para o restante. Sobrescrevemos o método equals, mas precisamos também sobrescrever o método getHashCode. O que é esse método getHashCode? É uma função que entrega um valor inteiro que indica um identificador único para esse objeto, chamado de HashCode. O HashCode padrão é calculado pela área de memória dos objetos, mas estamos mudando o comportamento padrão de igualdade para título e artista.

Vamos sobrescrever o método getHashCode:

```csharp
public override int GetHashCode()
{
    return this.Titulo.GetHashCode() ^ this.Artista.GetHashCode();
}
```

**Concluindo a implementação de verificação de duplicatas**  
Com esses dois métodos sobrescritos, estamos dizendo que músicas são iguais quando título e artista forem iguais. Vamos executar novamente a aplicação e, desta vez, não teremos mais repetição de músicas na playlist, mesmo que tenhamos objetos diferentes. Como mudamos a comparação para indicar título e artista, não é mais permitido incluir músicas repetidas na playlist. Com isso, implementamos mais uma função do nosso problema inicial, que é não permitir que uma playlist tenha músicas repetidas. Vamos continuar com essas implementações na sequência.

### Aula 2: Evitando transações duplicadas no Bytebank - Exercício

A equipe de desenvolvimento do Bytebank, um banco digital que oferece serviços bancários online, está enfrentando um problema com transações duplicadas. Recentemente, foi identificado que algumas transações estão sendo processadas mais de uma vez, causando confusão e insatisfação entre os clientes. A empresa contratou você para resolver esse problema. Uma das soluções propostas é utilizar uma estrutura de dados que impeça a duplicação de transações.

Considerando que cada transação possui um identificador único, qual seria a melhor abordagem para implementar uma solução eficiente para evitar transações duplicadas no Bytebank?

Resposta correta:

Utilizar um HashSet para armazenar os identificadores únicos das transações, garantindo que cada transação seja processada apenas uma vez.

> Correta, pois o HashSet é uma estrutura de dados que não permite elementos duplicados. Ao armazenar os identificadores únicos das transações, ele impede que transações duplicadas sejam processadas, melhorando a confiabilidade do sistema.

### Aula 2: Top 3 músicas - Vídeo 5

Transcrição  
Continuando a implementação das funções de playlist de músicas, agora queremos criar uma função para exibir as 10 músicas mais tocadas de todas as playlists. Para isso, precisamos criar mais uma playlist para verificar essa funcionalidade. Vamos começar por esse teste, criando o cenário de teste para depois implementar a exibição das 10 músicas mais tocadas.

Já temos uma playlist de músicas nacionais. Agora, vamos criar uma nova playlist chamada "Legião Urbana". O nome será "Mais populares da Legião". Nessa playlist, adicionaremos as músicas da Legião Urbana. As músicas que vamos adicionar são a 1, a 2, a 4 e a 5. Vamos exibir a playlist para verificar se está tudo correto.

Criando e exibindo a playlist "Legião Urbana"  

Primeiro, criamos a playlist:

```csharp
var legiaoUrbana = new Playlist() { Nome = "Mais populares da Legião" };
```

Em seguida, adicionamos as músicas à playlist:

```csharp
legiaoUrbana.Add(musica1);
legiaoUrbana.Add(musica2);
legiaoUrbana.Add(musica4);
legiaoUrbana.Add(musica5);
```

Agora, exibimos a playlist para verificar se as músicas foram adicionadas corretamente:

```csharp
ExibirPlaylist(legiaoUrbana);
```

Temos, então, duas playlists disponíveis: uma com músicas de rock nacional e outra com as músicas mais populares da Legião Urbana. Poderíamos criar outras playlists, mas agora vamos focar em criar um método para exibir as 10 músicas mais tocadas.

**Definindo o método para exibir as músicas mais tocadas**  
Para isso, vamos receber duas playlists como argumento de entrada. Essas duas playlists serão comparadas, e a partir delas, criaremos uma nova coleção que representará as músicas mais tocadas. Precisamos de algo semelhante a uma planilha, com duas colunas: a primeira coluna conterá a música e a segunda coluna, a contagem de vezes que a música aparece em todas as playlists.

Vamos começar definindo o método para exibir as músicas mais tocadas:

```csharp
void ExibirMaisTocadas(Playlist playlist1, Playlist playlist2)
{
    // Inicializamos o dicionário para armazenar a contagem das músicas
    Dictionary<Musica, int> ranking = new Dictionary<Musica, int>();

    // Adicionamos as músicas da primeira playlist ao dicionário
    foreach(var musica in playlist1)
    {
        ranking.Add(musica, 1);
    }

    // Verificamos e atualizamos a contagem das músicas da segunda playlist
    foreach(var musica in playlist2)
    {
        if (ranking.TryGetValue(musica, out int contagem))
        {
            contagem++;
            ranking[musica] = contagem;
        } 
        else
        {
            ranking[musica] = 1;
        }
    }

    // Convertendo o dicionário em uma lista para ordenação
    List<KeyValuePair<Musica, int>> top = new List<KeyValuePair<Musica, int>>(ranking);

    // Ordenamos a lista pela contagem
    top.Sort(new PorContagem());

    // Exibimos as top 3 músicas mais incluídas nas playlists
    Console.WriteLine("\nTop 3 músicas mais incluídas nas playlists:");
    int contador = 1;
    foreach(var par in top)
    {
        Console.WriteLine($"\t - {par.Key.Titulo}");
        contador++;
        if (contador > 3) break;
    }
}
```

**Executando o método e criando a classe de ordenação**  
Por fim, executamos o método passando as playlists "rock nacional" e "legião urbana" para comparar e verificar as top 3:

```csharp
ExibirMaisTocadas(rockNacional, legiaoUrbana);
```

Para a ordenação, criamos uma classe que implementa IComparer para ordenar os pares de chave e valor:

```csharp
class PorContagem : IComparer<KeyValuePair<Musica, int>>
{
    public int Compare(KeyValuePair<Musica, int> x, KeyValuePair<Musica, int> y)
    {
        return y.Value.CompareTo(x.Value);
    }
}
```

**Concluindo a função de exibição das músicas mais tocadas**  
Conhecemos mais um tipo que representa coleções no .NET, que é o dicionário. Reforçamos que o tipo da esquerda representa uma chave e utiliza o getHashCode para encontrar o valor necessário. Descobrimos que podemos converter um dicionário em uma lista, considerando como elemento o tipo keyValuePair, passando os dois tipos de chave e valor do dicionário. Fizemos isso para ordenar o dicionário e reforçamos o aprendizado sobre ordenação, criando uma classe que implementa um IComparer.

Concluímos mais uma função do nosso problema, que era exibir as músicas mais tocadas em todas as playlists. Agora, vamos seguir para as funções finais na sequência.

### Aula 2: Fila de reprodução - Vídeo 6

Transcrição  
Nosso próximo desafio é desenvolver um player de música com fila de reprodução e histórico de reprodução. Vamos começar a implementação.

No final do arquivo Program.cs, vamos criar uma nova classe chamada PlayerDeMusica. Esta classe terá uma fila de reprodução, para a qual precisamos incluir músicas. Para isso, criaremos um método public void AdicionarNaFila, que receberá uma música como argumento.

```csharp
class PlayerDeMusica
{
}
```

Para adicionar músicas à fila, precisamos de uma coleção interna dentro do PlayerDeMusica. Vamos criar um campo privado do tipo List, que chamaremos de fila, e inicializá-lo com zero. Já vimos como fazer isso anteriormente.

```csharp
private List<Musica> fila = new List<Musica>();
```

**Adicionando músicas e playlists à fila**  
No método AdicionarNaFila, podemos adicionar músicas repetidas à fila de reprodução. Por exemplo, um DJ pode querer tocar a mesma música várias vezes em uma festa, e isso não é um problema.

```csharp
public void AdicionarNaFIla(Musica musica)
{
    fila.Add(musica);
}
```

Além de adicionar uma música individualmente, também queremos adicionar uma playlist inteira. Para isso, criaremos uma sobrecarga do método AdicionarNaFila, que receberá uma playlist. Precisamos iterar sobre essa playlist, que implementa IEnumerable, e chamar o método AdicionarNaFila para cada música.

```csharp
public void AdicionarNaFIla(Playlist playlist)
{
    foreach (var musica in playlist)
    {
        AdicionarNaFIla(musica);
    }
}
```

Optamos por não adicionar diretamente à fila com Add para reutilizar qualquer código adicional que possa existir no método AdicionarNaFila.

**Criando e exibindo a fila de reprodução**  
Vamos criar um método que retornará a fila, disponibilizando-a para quem precisar. Este método retornará um IEnumerable de músicas e será chamado Fila. Utilizaremos um iterador com yield return para processar cada elemento sob demanda, o que será gerenciado pela máquina de execução do .NET.

```csharp
public IEnumerable<Musica> Fila()
{
    foreach (var musica in fila)
    {
        yield return musica;
    }
}
```

**Testando o Player de Música**  
Agora que criamos o código inicial para o player de música, vamos testar sua execução. No código de teste, criamos uma playlist com algumas músicas e exibimos as mais tocadas. Vamos apagar esse código, pois agora está tudo organizado em métodos para referência.

Criamos um objeto do tipo PlayerDeMusica e adicionamos uma música e uma playlist à fila de reprodução.

```csharp
var player = new PlayerDeMusica();
player.AdicionarNaFIla(musical);
player.AdicionarNaFIla(rockNacional);
```

**Exibindo a fila de reprodução**  
Em seguida, iteramos sobre a fila para imprimir as músicas nela contidas. Utilizamos interpolação de strings para exibir o título de cada música.

```csharp
foreach (var musica in player.Fila())
{
    Console.WriteLine($"{'\t'} - {musica.Titulo}");
}
```

Para manter o padrão, criamos um método separado chamado ExibirFila, que recebe o PlayerDeMusica como argumento. Movemos o código de exibição para este método e utilizamos Console.WriteLine para exibir a fila de reprodução.

```csharp
void ExibirFila(PlayerDeMusica player)
{
    Console.WriteLine($"\nExibindo a fila de reprodução:");
    foreach (var musica in player.Fila())
    {
        Console.WriteLine($"{'\t'} - {musica.Titulo}");
    }
}
```

**Implementando a função de próxima música**  
Por fim, chamamos o método ExibirFila, passando o objeto player como argumento. Executamos o código e analisamos a saída no terminal.

```csharp
ExibirFila(player);
```

Foram exibidas duas playlists: "Rock Nacional" e "Mais Popular da Região". Além disso, adicionamos a música "Que País É Esse" e a playlist "Legião" à fila de reprodução, totalizando seis músicas na fila.

Vamos continuar com o desenvolvimento. Se quisermos pegar a próxima música da fila para tocar, precisamos acessar nosso player e criar um método que retorne a próxima música da fila. Esse método retornará um objeto do tipo música, que também pode ser nulo. Por isso, utilizamos o símbolo de interrogação. O método será chamado de próximaMúsicaDaFila e não terá argumentos de entrada.

```csharp
public Musica? ProximaMusicaDaFila()
{
    if (fila.Count == 0) return null;
    var musica = fila[0];
    fila.Remove(musica);
    return musica;
}
```

**Testando a função de próxima música**  
Vamos testar. No nosso código de teste, onde criamos um player de música, exibiremos a fila e pegaremos a próxima música. Criamos uma variável chamada próxima a partir do player de música, chamando o método próximaMúsicaDaFila. Exibiremos essa música com Console.WriteLine, mostrando "Tocando a música" seguido do título.

```csharp
var proxima = player.ProximaMusicaDaFila();
if (proxima is not null)
{
    Console.WriteLine($"Tocando a musica {proxima.Titulo}...");
}
else
{
    Console.WriteLine("Fila de reprodução vazia!");
}
```

Depois, exibiremos a fila novamente a partir do player de música.

```csharp
ExibirFila(player);
```

**Refatorando para usar a classe Queue**  
Vamos testar com CTRL + F5. Podemos apagar ou comentar a exibição da playlist para não sobrecarregar o terminal. Após executar, na janela do terminal, aumentaremos o zoom. Exibimos a fila de reprodução com seis músicas, pegamos a próxima da fila, "Que País É Esse", e removemos esse elemento da fila. A próxima música agora é "Tempo Perdido".

Agora, vamos entender o comportamento de pegar a próxima música da fila, que consiste em retirar o primeiro elemento. Esse comportamento já está embutido em uma classe do .NET chamada Queue, que representa uma fila. Em uma fila, o primeiro elemento que entrou é o primeiro a sair, e não podemos acessar outros elementos diretamente. Estamos usando uma lista e manipulando manualmente, o que não é uma boa prática de orientação a objetos. A orientação a objetos enfatiza o encapsulamento, mantendo dados e comportamentos encapsulados dentro de uma classe.

Vamos mudar de List para Queue. A fila é inicializada vazia, e o método para adicionar um elemento na fila é Enqueue (enfilar), enquanto o método para remover é Dequeue (desenfilar). Com isso, não precisamos mais verificar o índice zero ou remover manualmente a música. Podemos simplesmente usar Fila.Dequeue, que internamente já remove o elemento. Essa estratégia de acesso, onde o primeiro elemento que entrou é o primeiro a sair, é característica de uma fila, e temos uma classe para isso no .NET.

```csharp
private Queue<Musica> fila = new Queue<Musica>();

public void AdicionarNaFIla(Musica musica)
{
    fila.Enqueue(musica);
}

public Musica? ProximaMusicaDaFila()
{
    if (fila.Count == 0) return null;
    return fila.Dequeue();
}
```

**Finalizando e testando a refatoração**  
Vamos testar o código novamente com F5 e verificar que o comportamento permanece o mesmo, mas agora estamos utilizando um tipo do .NET que possui a semântica de uma fila.

### Aula 2: Histórico de reprodução - Vídeo 7

Transcrição  
Nosso desafio agora é implementar o histórico de reprodução. À medida que tocamos músicas, vamos construindo um histórico. Por exemplo, se tocarmos a música "Que País é Esse", ela será adicionada ao histórico. Caso nenhuma música tenha sido tocada, o histórico estará vazio. Precisamos criar uma nova coleção que representará esse histórico no nosso player de música.

No código, na parte inicial da classe do player de música, adicionaremos um campo para representar esse histórico. Vamos pensar no tipo que utilizaremos para isso. Quando acessamos um elemento do histórico, a música recuperada será a última que entrou, pois o histórico é cronológico. Assim, a última música tocada será a primeira a sair do histórico. Esse comportamento, onde o último a entrar é o primeiro a sair, é característico de uma pilha, ou stack.

**Declarando a pilha de músicas**  
Para começar, vamos declarar a pilha de músicas:

```csharp
private Stack<Musica> pilha = new Stack<Musica>();
```

Portanto, teremos uma pilha de músicas que começa vazia quando o objeto player de música é criado. À medida que tocamos músicas, vamos adicionando-as à pilha. Utilizamos a orientação a objetos e a biblioteca do .NET, que nos fornece uma coleção com características específicas. A pilha segue o conceito de LIFO (Last In, First Out), enquanto uma fila segue o conceito de FIFO (First In, First Out).

Quando tocamos uma música, ela é adicionada ao histórico. Para isso, utilizamos o método PUSH, que adiciona um elemento à coleção do tipo STACK. Vamos ver como isso é feito no código:

```csharp
var musica = fila.Dequeue();
pilha.Push(musica);
```

**Criando o método para visualizar o histórico**  
Além disso, precisamos visualizar esse histórico. Vamos criar um método public IEnumerable de música chamado Historico. Utilizaremos um for-each para iterar sobre a pilha e exibir as músicas.

Primeiro, criamos o método vazio:

```csharp
public IEnumerable<Musica> Historico()
{
}
```

Em seguida, adicionamos a iteração sobre a pilha:

```csharp
public IEnumerable<Musica> Historico()
{
    foreach(var musica in pilha)
    {
        yield return musica;
    }
}
```

**Exibindo a fila de reprodução e o histórico**  
Para testar, vamos exibir a fila de reprodução e o histórico. Criamos um método ExibirHistorico, passando o player de música como argumento. Utilizamos Console.WriteLine para exibir o histórico:

```csharp
void ExibirHistorico(PlayerDeMusica player)
{
    Console.WriteLine($"\nExibindo o histórico:");
    foreach(var musica in player.Historico())
    {
        Console.WriteLine($"\t - {musica.Titulo}");
    }
}
```

Após tocar uma música, exibimos novamente a fila e o histórico:

```csharp
ExibirFila(player);
ExibirHistorico(player);
```

**Implementando a função para tocar a música anterior**  
Se quisermos tocar a música anterior, criamos um método public Musica? MusicaAnterior, que verifica se a pilha está vazia. Se não estiver, utilizamos o método POP para remover e retornar o elemento do topo da pilha. Assim, podemos tocar a música anterior:

```csharp
public Musica? MusicaAnterior()
{
    if (pilha.Count == 0) return null;
    return pilha.Pop();
}
```

**Concluindo o estudo sobre coleções no .NET**  
Ao executar o código, vemos que a fila de reprodução começa com seis músicas e o histórico está vazio. Após tocar "Que País é Esse", a fila diminui e o histórico passa a conter essa música. Se pegarmos a música anterior do histórico e tocarmos novamente, o histórico ficará vazio.

Esse comportamento de coleções no .NET é bastante específico. Em uma fila, o primeiro a entrar é o primeiro a sair, enquanto em uma pilha, o último a entrar é o primeiro a sair. Pilhas são comuns no desenvolvimento de software, como no caso de desfazer comandos com "Ctrl+Z", onde os comandos são armazenados em uma pilha. Outro exemplo é a pilha de chamadas de métodos, onde métodos são empilhados e desempilhados conforme são executados.

Concluímos nosso estudo sobre as principais estruturas de dados de coleções disponíveis no .NET. Embora não tenhamos abordado todas as coleções, exploramos as mais relevantes para o desenvolvimento.

Começamos com a lista, depois passamos para o HashSet e, em seguida, para o dicionário. Após isso, trabalhamos com a Queue (fila) e a Stack (pilha). Essas são cinco coleções que possuem algumas variações e outros tipos de dados, mas compartilham características semelhantes.

A fila é utilizada para acesso sequencial e indexado. O set é usado para evitar elementos repetidos. O HashSet e o dicionário são utilizados quando desejamos ter uma chave customizada para acessar um elemento específico.

Discutimos também sobre uma planilha com duas colunas. A fila possui um comportamento de acesso característico, onde o primeiro elemento a entrar é o primeiro a sair. Já na pilha, o último elemento a entrar é o primeiro a sair.

Nos vemos nos próximos estudos sobre coleções.

### Aula 2: Para saber mais: conversão de dicionários para listas

**Contextualização do Cenário**  
Em muitas situações, precisamos ordenar dados que foram inicialmente armazenados em uma estrutura que não mantém ordem, como o dicionário. No caso apresentado, usamos o dicionário para contar a ocorrência de músicas em playlists, mas para obter um ranking ordenado das músicas mais tocadas, é necessário converter essa coleção em uma lista. Essa abordagem permite aproveitar o método de ordenação da lista, que pode ser customizado de acordo com a lógica desejada.

**Motivação para a Conversão**  
Os dicionários em .NET (Dictionary) utilizam o hash code para indexar os elementos, o que garante acesso rápido, mas não preserva uma ordem definida. Ao converter o dicionário para uma lista de KeyValuePair, podemos aplicar algoritmos de ordenação para estruturar os dados conforme necessário – por exemplo, ordenando pela quantidade de vezes que uma música aparece em playlists. Essa técnica é especialmente útil quando precisamos exibir os dados de maneira organizada, como em um ranking.

**Mecanismo da Conversão e Ordenação**  
A conversão pode ser realizada de forma simples, criando uma nova lista que receba os elementos do dicionário. Uma vez convertida, a lista pode ser ordenada utilizando o método Sort. Como a ordenação padrão não atenderá nossa necessidade específica (ordenar pela contagem e não pela música em si), definimos um comparador customizado implementando a interface IComparer. Esse comparador utiliza a propriedade Value de cada KeyValuePair para realizar a comparação e definir a ordem decrescente, garantindo que os itens com maiores contagens venham primeiro.

Exemplo simplificado do processo:

```csharp
// Conversão do dicionário para lista
List<KeyValuePair<Musica, int>> listaRanking = new List<KeyValuePair<Musica, int>>(ranking);

// Ordenação customizada utilizando um comparador
listaRanking.Sort(new ComparadorPorContagem());
```

No comparador, a lógica inverte a comparação dos valores de forma que o maior número seja considerado "menor" na ordem, invertendo assim a ordenação para decrescente.

**Aspectos de Desempenho e Aplicabilidade**  
Converter um dicionário para uma lista e ordená-la é uma operação que tem complexidade O(n log n), o que é adequado para conjuntos de dados de tamanho pequeno a intermediário. Em cenários com um número muito elevado de elementos, é importante considerar o impacto desse processamento e avaliar se essa abordagem é a mais eficiente ou se estratégias alternativas (como estruturas de dados já ordenadas) poderiam ser utilizadas.

Essa técnica é amplamente utilizada, pois combina a eficiência do acesso rápido do dicionário com a flexibilidade de ordenação da lista, permitindo a construção de rankings e relatórios de maneira clara e de fácil manutenção.

### Aula 2: Faça como eu fiz: gerenciador musical

Nesta aula, exploramos a manipulação de coleções para gerenciar músicas e playlists no .NET, utilizando interfaces, ordenação e estruturas como fila e pilha.

Agora é a sua vez de revisar e colocar em prática o que foi ensinado. Para isso:

- Crie a classe Música com propriedades para título, artista e duração.
- Crie a classe Playlist com a propriedade nome.
- Instancie objetos da classe Música com dados exemplares.
- Instancie um objeto da classe Playlist.
- Adicione as músicas à Playlist usando um método específico.
- Implemente a interface IEnumerable na Playlist para permitir iteração.
- Implemente a interface ICollection delegando para uma lista interna.
- Desenvolva um método para exibir a Playlist no console com interpolação.
- Crie um método para obter uma música pelo título na Playlist.
- Implemente a remoção de uma música utilizando o método Remove.
- Crie um método para tocar uma música aleatória usando a classe Random.
- Verifique se a lista não está vazia antes de selecionar uma música aleatória.
- Ordene as músicas por duração utilizando o método Sort da List.
- Implemente IComparable na classe Música para comparação por duração.
- Crie classes comparadoras (IComparer) para ordenar por artista.
- Crie outra classe comparadora (IComparer) para ordenar por título.
- Implemente métodos na Playlist para ordenar usando os comparadores criados.
- Utilize um HashSet auxiliar para impedir músicas duplicadas na Playlist.
- Sobrescreva os métodos Equals e GetHashCode na classe Música para comparação adequada.
- Crie um dicionário que contabilize quantas vezes cada música aparece nas playlists.
- Construa um Player de Música com fila de reprodução (Queue) e histórico (Stack) para gerenciar as músicas tocadas.

### Aula 2: O que aprendemos?

Nesta aula, aprendemos:

- A criar e gerenciar coleções em C# utilizando ICollection`<T>`, List, HashSet, Queue e Stack.
- A implementar e sobrescrever métodos para manipular listas, incluindo busca, adição e remoção de elementos.
- A utilizar interfaces como IComparable e IComparer`<T>` para definir lógica de ordenação e comparação.
- A adotar estruturas de HashSet para evitar duplicação, implementando Equals e GetHashCode.
- A integrar dicionários para rastrear e contar aparições de itens, permitindo análise quantitativa.
- A implementar uma fila de reprodução utilizando Queue, aplicando conceitos de FIFO.
- A criar históricos de reprodução com Stack, aplicando conceitos de LIFO.
- A utilizar técnicas de interpolação de strings para criação de saídas dinâmicas e formatadas.

## Aula 3: Fluxo de manipulação de coleções

### Aula 3: Projeto da aula anterior

Na aula anterior, avançamos na realização de operações práticas com listas, playlists e músicas, explorando inclusão, remoção, ordenação, uso de HashSet, Dictionary, além das estruturas de fila (Queue) e pilha (Stack). Esses conceitos tornam as coleções mais flexíveis e aplicáveis a cenários reais. Para conferir a implementação e revisar o código, [acesse o repositório do curso no GitHub](https://github.com/alura-cursos/data-manipulation-with-csharp/tree/main/02-OperacoesEmColecoes).

### Aula 3: Manipulando músicas vindas de um arquivo - Vídeo 1

Transcrição  
Agora que já conhecemos as principais estruturas de dados que representam coleções no .NET, vamos avançar em nosso estudo e pensar na origem dos dados. Queremos manipular coleções e, para isso, precisamos obter esses dados a partir de alguma fonte. Por enquanto, utilizaremos um arquivo para gerar uma coleção relativamente grande, permitindo que trabalhemos operações específicas com os elementos dessa coleção.

No Visual Studio, vamos fechar a classe Program disponível no projeto 2, pois agora passaremos para o projeto 3. Fecharemos essa aba e também o projeto 2 no gerenciador de soluções, abrindo o projeto 3. Neste projeto, temos um arquivo diferente, que contém as músicas com as quais trabalharemos. Vamos abrir esse arquivo, musicas.csv, com um duplo clique. Trata-se de um arquivo de texto onde, em cada linha, há uma série de informações separadas por ponto e vírgula. Essa é uma característica comum de arquivos no formato CSV (Comma Separated Values), que são valores separados por vírgula ou outro separador qualquer. No nosso caso, o separador é ponto e vírgula. Cada linha representa uma música, com título, nome do artista, duração em segundos e o gênero categorizado para aquela música. As músicas são fictícias, mas os artistas são reais.

**Preparando o ambiente de desenvolvimento**  
Precisaremos ler esse arquivo e trazer as músicas como uma coleção. Esse será nosso primeiro trabalho neste estudo. Vamos fechar o arquivo de músicas e abrir a classe Program disponível no projeto 3. Essa é a classe inicial que contém o console "Hello World". Podemos apagar esse conteúdo, selecionando tudo e pressionando "Delete". Em seguida, traremos da área de transferência o enunciado dos exercícios que faremos com o arquivo de músicas, colando-o com "Ctrl+V". Esse é o enunciado com as tarefas para nosso estudo inicial. Realizaremos uma série de atividades baseadas em uma coleção originada de um arquivo.

Vamos salvar o progresso com "Ctrl+S". Para organizar melhor, na barra inicial do Visual Studio, onde há a lista suspensa com os projetos, selecionaremos o projeto número 3. Estamos avançando no estudo. Agora, começaremos a escrever código. O primeiro código será a classe Musica. Vamos criar essa classe diretamente, pois será mais rápido do que copiar e colar de outros lugares.

```csharp
class Musica
{
}
```

**Criando a classe Musica**  
Acabamos de iniciar a criação de uma estrutura para manipular dados de músicas. Vamos criar uma propriedade chamada Título, que será do tipo String.

```csharp
class Musica
{
    public string Titulo { get; set; }
}
```

Em seguida, adicionamos outra propriedade chamada Artista, também do tipo String.

```csharp
class Musica
{
    public string Titulo { get; set; }
    public string Artista { get; set; }
}
```

Por fim, adicionamos uma propriedade do tipo int, que será a Duração.

```csharp
class Musica
{
    public string Titulo { get; set; }
    public string Artista { get; set; }
    public int Duracao { get; set; }
}
```

**Inicializando o arquivo de músicas**  
Para inicializar o arquivo, a primeira coisa que precisamos fazer é criar uma variável que representará esse arquivo, do tipo FileStream. No FileStream, devemos passar o nome do arquivo, que será músicas.csv. O modo de abertura será de leitura, utilizando FileAccess para leitura somente. Assim, pegamos esse arquivo.

```csharp
var arquivo = new FileStream("musicas.csv", FileMode.Open, FileAccess.Read);
```

Quando trabalhamos com arquivos, é importante gerenciar esse recurso, pois ele representa um ponteiro no sistema operacional. Precisamos liberar esse recurso após o uso, e a palavra reservada using faz isso automaticamente ao término da execução. Portanto, não precisamos nos preocupar em liberar manualmente o recurso. Vamos colocar o using na frente da variável do arquivo.

```csharp
using var arquivo = new FileStream("musicas.csv", FileMode.Open, FileAccess.Read);
```

**Lendo o arquivo de músicas**  
Além disso, precisamos ler esse arquivo. Vamos criar um StreamReader a partir do arquivo, também utilizando using, pois precisamos liberar esse recurso que representa um fluxo de bytes lido linha a linha.

```csharp
using var stream = new StreamReader(arquivo);
```

Agora, estamos prontos para ler o arquivo e entregar uma coleção de músicas. Vamos criar um método que não será void, mas sim um método que retornará um IEnumerable de músicas. Nomearemos esse método como ObterMusicas a partir de um StreamReader, e o argumento de entrada será chamado de stream.

```csharp
IEnumerable<Musica> ObterMusicas(StreamReader stream)
{
}
```

O que esse stream fará? Primeiro, precisamos pegar a linha, pois leremos linha a linha. Enquanto a linha não for null, significa que não terminamos a leitura do arquivo, então permaneceremos nesse loop.

```csharp
IEnumerable<Musica> ObterMusicas(StreamReader stream)
{
    var linha = stream.ReadLine();
    while(linha is not null)
    {
    }
}
```

**Convertendo linhas em objetos Musica**  
O próximo passo será converter essa linha em uma música. Vamos criar um objeto do tipo Musica com new Musica. Inicialmente, o Título será uma String vazia, e a Duração será zero.

```csharp
var partes = linha.Split(';');
var musica = new Musica
{
    Titulo = string.Empty,
    Artista = string.Empty,
    Duracao = 0
};
```

Após criar o objeto, precisamos colocá-lo em uma lista ou não. Quando temos métodos que retornam um IEnumerable, podemos entregar diretamente um processamento de elemento sob demanda, usando yield return Musica.

```csharp
yield return musica;
```

Já temos praticamente tudo pronto, mas falta pegar os valores de fato: Título, Artista e Duração de cada linha. Para isso, dividiremos a linha em partes usando o método Split da String, que quebra a linha através do separador ponto e vírgula.

```csharp
var musica = new Musica
{
    Titulo = partes[0],
    Artista = partes[1],
    Duracao = Convert.ToInt32(partes[2])
};
```

**Exibindo as músicas no terminal**  
Com isso, terminamos o código que processa o arquivo de músicas para um enumerado de músicas. Agora, vamos criar um método que lerá e exibirá as músicas no terminal. Esse método receberá um IEnumerable de músicas.

```csharp
void ExibirMusicas(IEnumerable<Musica> musicas)
{
}
```

Vamos percorrer as músicas com foreach (var musica in musicas) e exibir cada música usando interpolação de strings, com um "Tab" e um hífen, seguido do nome da música, musica.Titulo.

```csharp
void ExibirMusicas(IEnumerable<Musica> musicas)
{
    foreach(var musica in musicas)
    {
        Console.WriteLine($"\t - {musica.Titulo}");
    }
}
```

Também adicionaremos um título à exibição, pulando uma linha e escrevendo "Exibindo as músicas:".

```csharp
void ExibirMusicas(IEnumerable<Musica> musicas)
{
    Console.WriteLine($"\nExibindo as músicas:");
    foreach(var musica in musicas)
    {
        Console.WriteLine($"\t - {musica.Titulo}");
    }
}
```

**Limitando a exibição das músicas**  
Para não exibir todas as músicas, já que o arquivo contém mais de mil músicas, faremos uma quebra. Vamos criar um contador e exibir apenas as primeiras 10 músicas. O contador começará em 1, e após exibir cada música, incrementaremos o contador. Se o contador for maior que 10, sairemos do loop e pararemos de exibir músicas.

```csharp
void ExibirMusicas(IEnumerable<Musica> musicas)
{
    var contador = 1;
    Console.WriteLine($"\nExibindo as músicas:");
    foreach(var musica in musicas)
    {
        Console.WriteLine($"\t - {musica.Titulo}");
        contador++;
        if (contador > 10) break;
    }
}
```

**Finalizando a execução do projeto**  
Agora, podemos criar uma variável do tipo Músicas que receberá o método ObterMusicas, retornando um IEnumerable de músicas. Por fim, chamaremos o método ExibirMusicas, passando o IEnumerable criado.

```csharp
var musicas = ObterMusicas(stream);
ExibirMusicas(musicas);
```

Criamos o modelo e a estrutura inicial que usaremos para este estudo de coleções. Vamos executar o projeto atual, que é o projeto número 3, e pressionar F5. Se tudo der certo, ele exibirá as 10 primeiras músicas do arquivo. Caso contrário, verificaremos o motivo. No nosso caso, percebemos que esquecemos de ler a próxima linha dentro do loop.

```csharp
linha = stream.ReadLine();
```

Após corrigir isso, pressionamos F5 novamente, e agora sim, ele exibirá as 10 primeiras músicas do arquivo: "The Broken Road", "Midnight Echo of Shadows", "Lonely Star", entre outras.

Utilizamos a estratégia de processamento sob demanda, deixando para a própria máquina virtual do .NET gerar o enumerador para nós. Assim, não precisamos percorrer todo o arquivo, apenas as 10 primeiras linhas que nos interessavam. Na sequência, continuaremos trabalhando com esses exercícios.

### Aula 3: Gerenciamento de dados de clientes no Serenatto - Exercício

A equipe de TI do Serenatto - Café & Bistrô, que oferece uma variedade de refeições e bebidas, está desenvolvendo um sistema para gerenciar os dados dos clientes que frequentam o bistrô. Esses dados incluem nome, preferências alimentares, histórico de pedidos e feedbacks. A equipe decidiu armazenar essas informações em arquivos CSV para facilitar a manipulação e análise. No entanto, durante a implementação, surgiu a dúvida sobre como garantir que o sistema leia e processe apenas os dados necessários, sem sobrecarregar o sistema com informações desnecessárias.

Como a equipe pode implementar um sistema eficiente que leia e processe apenas os dados necessários dos arquivos CSV, garantindo que o Serenatto - Café & Bistrô possa oferecer um serviço personalizado sem comprometer a eficiência do sistema?

Resposta:  
Implementar um sistema que utilize o conceito de processamento sob demanda, lendo os arquivos CSV linha a linha com um fluxo de dados (StreamReader), dividindo os dados com o método split e processando apenas as informações necessárias, como preferências alimentares e histórico de pedidos.

> Correta, pois essa abordagem permite que o sistema leia e processe apenas os dados necessários sem carregar todo o arquivo na memória, mantendo a eficiência e personalização do serviço.

### Aula 3: Filtrando por artista - Vídeo 2

Transcrição  
Já obtivemos as músicas a partir do arquivo, uma coleção de músicas, e vamos ver qual é o próximo desafio. No nosso Program.cs atual, conseguimos ler uma coleção de músicas usando yield para ter um processamento otimizado. Agora, queremos filtrar a coleção por algum artista, por exemplo, Coldplay. Selecionamos a palavra "Coldplay" e queremos filtrar essa coleção.

A primeira coisa que faríamos seria, ao obter a música, entregar um elemento apenas se a condição for atendida. Se o artista da música for Coldplay, retornamos o elemento, filtrando assim o arquivo pelo artista Coldplay. Vamos começar implementando essa lógica de filtragem:

```csharp
if (musica.Artista == "Coldplay") yield return musica;
```

**Melhorando a exibição das músicas**  
Antes de executar, vamos melhorar a exibição, colocando o nome do artista entre parênteses, pois usaremos isso depois. Vamos incluir também a duração da música, resultando no título da música, artista entre parênteses, um hífen e a duração em segundos. Para isso, ajustamos a exibição da seguinte forma:

```csharp
Console.WriteLine($"{contador++}\t - {musica.Titulo}({musica.Artista}) - {musica.Duracao} seg");
```

Após executar, verificamos se realmente filtramos as músicas do Coldplay, pegando as 10 primeiras músicas. "Dancing Dream" já não é a primeira música, então conseguimos atender a necessidade solicitada. No entanto, precisamos pensar em outros casos, como filtrar por Metallica, por gênero, por duração, ou ordenar a coleção por artista.

**Criando um método de filtragem por artista**  
Quando fazemos a condição diretamente ao obter músicas, restringimos muito a obtenção. O ideal seria realizar esse filtro em um segundo estágio. O primeiro passo é obter os dados, que podem vir de arquivo ou outra fonte. Depois, aplicamos operações para manipular esses dados em etapas subsequentes, conforme necessário.

**Vamos criar um método responsável por filtrar por Coldplay. Esse método retornará um enumerável, chamado**  FiltrarPorColdplay, que receberá um enumerável de músicas como entrada. Vamos iniciar com a definição do método:

```csharp
IEnumerable<Musica> FiltrarPorColdplay(IEnumerable<Musica> musicas)
{
    foreach(var musica in musicas)
    {
        if (musica.Artista == "Coldplay") yield return musica;
    }
}
```

Primeiro, obtemos as músicas e, depois, podemos filtrar as músicas do Coldplay. A variável que usaremos para filtrar será a variável musicas. Se pressionarmos F5, teremos a mesma exibição. No entanto, não temos a mesma exibição porque estamos desatentos. Precisamos exibir as músicas que vierem da variável musicas do Coldplay. Para testar a execução, temos as músicas do Coldplay:

```csharp
var musicasDoColdplay = FiltrarPorColdplay(musicas);
ExibirMusicas(musicasDoColdplay);
```

**Tornando o método de filtragem mais genérico**  
Não precisamos filtrar apenas por Coldplay; podemos filtrar por qualquer artista. Podemos passar uma string com o nome do artista, tornando o método mais genérico. Em vez de um nome fixo como Coldplay, podemos passar o nome do artista como argumento. Assim, o método de filtragem se torna mais flexível:

```csharp
IEnumerable<Musica> FiltrarPor(IEnumerable<Musica> musicas, string artista)
{
    foreach (var musica in musicas)
    {
        if (musica.Artista == artista) yield return musica;
    }
}
```

O que queremos observar é que estamos aplicando estágios para manipular os dados. O primeiro estágio é sempre a obtenção dos dados. Após isso, aplicamos vários passos para manipular a coleção à medida que ela é entregue. O segundo estágio pega o enumerável do primeiro e entrega mais um enumerável, e assim por diante. Criamos uma cadeia de operações que manipulam os dados gradualmente.

**Criando métodos de extensão para filtragem**  
Para isso, podemos usar um recurso no C# chamado método de extensão. Queremos criar um método que estenda um tipo específico, adicionando mais funcionalidade. O tipo que queremos estender é o IEnumerable de música, retornado por obter músicas. Vamos criar a classe de extensão:

```csharp
static class MusicasExtensions
{
    public static IEnumerable<Musica> FiltrarPor(this IEnumerable<Musica> musicas, string artista)
    {
        foreach (var musica in musicas)
        {
            if (musica.Artista == artista) yield return musica;
        }
    }
}
```

Concluímos a criação de um método de extensão para o enumerável de músicas. Agora, temos essa funcionalidade e legibilidade. O primeiro estágio é sempre a obtenção dos dados. A partir do segundo estágio, podemos manipular as coleções como desejarmos, encadeando operações. Aqui, estamos filtrando por artista, e as músicas do Coldplay serão entregues e filtradas a partir do arquivo:

```csharp
var musicasDoColdplay = ObterMusicas(stream).FiltrarPor("Coldplay");
ExibirMusicas(musicasDoColdplay);
```

**Concluindo a implementação e próximos passos**  
A execução está igual, mas o código agora está mais legível, pois organizamos em uma cadeia de manipulação de dados. O primeiro estágio é sempre a obtenção dos dados, e o segundo estágio, neste caso, é a filtragem por artista. Utilizamos métodos de extensão, que seguem o checklist de três itens: classe estática, método público estático e o primeiro argumento de entrada marcado com this.

Na sequência, continuaremos trabalhando com as atividades mencionadas no enunciado.

### Aula 3: Filtrando projetos por linguagem de programação na CodeConnect - Exercício

A CodeConnect, uma rede social para programadores, que permite curtidas, compartilhamento e comentários em projetos e códigos, está desenvolvendo uma nova funcionalidade para permitir que pessoas usuárias filtrem projetos por linguagem de programação. Atualmente, todos os projetos são exibidos em uma lista única, dificultando a busca por projetos específicos.

Como você aplicaria o conceito de encadeamento de operações para implementar essa funcionalidade de forma eficiente e legível?

Resposta:  
Implementar um método de extensão que recebe a lista de projetos e a linguagem desejada como parâmetros, iterando sobre a lista e retornando apenas os projetos que correspondem à linguagem especificada.

> Correta, pois ao criar um método de extensão que encadeia a obtenção da lista de projetos com a filtragem pela linguagem, o código se mantém legível e eficiente, permitindo que a pessoa usuária encontre rapidamente os projetos de seu interesse.

### Aula 3: Condições como argument - Vídeo 3

Transcrição  
Vamos recapitular as atividades que já realizamos em nosso exercício. Lemos uma coleção de músicas, filtramos por artista e, para isso, aprendemos os métodos de extensão. Agora, precisamos trabalhar com outros filtros. Vamos começar com o filtro da coleção por duração.

Para isso, criaremos mais um método de extensão. Vamos copiar e colar a linha onde está o método filtrarPor e chamá-lo de filtrarPorDuracao. Esse método precisa receber a duração que queremos filtrar, sendo maior ou igual à duração especificada. Assim, criamos um método rápido de filtrar por duração, mas não é apenas a duração igual, e sim músicas mais longas que um determinado tempo.

**Definindo o método FiltrarPorDuracao**  
Primeiro, vamos definir o método FiltrarPorDuracao:

```csharp
public static IEnumerable<Musica> FiltrarPorDuracao(this IEnumerable<Musica> musicas, int duracao)
{
    foreach (var musica in musicas)
    {
        if (musica.Duracao >= duracao) yield return musica;
    }
}
```

Estamos filtrando as músicas do Coldplay e adicionaremos mais um estágio na manipulação, filtrando por duração. Vamos executar o código e verificar se há algum erro ou se realmente não existe nenhuma música maior que 500 segundos. A execução mostrou músicas cuja duração é maior que 300 segundos. Vamos ajustar para músicas maiores que 400 segundos. Após salvar e executar novamente, temos um subconjunto de cinco músicas que são maiores que 400 segundos.

```csharp
var musicasDoColdplay =
    ObterMusicas(stream)
        .FiltrarPorArtista("Coldplay") // 2. filtragem por artista
        .FiltrarMaisLongasQue(400); // 3. filtragem por duração
```

**Melhorando a estrutura dos métodos de extensão**
No entanto, há um detalhe que pode ser melhorado. Quando criamos o método de extensão na classe MusicasExtensions, o código é muito parecido. O que muda é a condição. O método retorna uma coleção enumerável de músicas e possui um argumento this para estender esse tipo. A diferença está no segundo argumento: duração em um caso e artista no outro. Podemos melhorar isso.

Vamos criar um método com uma assinatura semelhante, identificando as características comuns. O que muda é a condição. Temos um tipo Musica e o nome da variável é musica. O retorno é booleano, uma condição que avalia para verdadeiro ou falso. No meio do caminho, manipulamos a música e executamos uma expressão avaliada em booleano, chamada de condição.

Podemos criar um método que represente essa condição. O retorno é booleano, e o método recebe como entrada a música. Podemos nomear a variável como quisermos. Por exemplo, no caso de filtrar por artista, a expressão seria musica.artista == "Coldplay". Para filtrar músicas mais longas, teríamos m.duracao >= duracao.

```csharp
bool FiltrarPorArtista(Musica musica) => musica.Artista == "Coldplay";
bool FiltrarMaisLongas(Musica m) => m.Duracao >= 400;
```

**Unificando assinaturas de métodos**  
Precisamos que esses métodos estejam ainda mais parecidos. O nome do método não faz parte da assinatura, mas sim o retorno e os tipos de entrada. Os métodos filtrarPorArtista e filtrarMaisLongas não têm a mesma assinatura porque o segundo argumento é de tipos diferentes: string e int. Podemos tentar unificar as assinaturas, mas isso exigiria passar valores fixos para o nome do artista e a duração. Vamos seguir com essa abordagem e ver como podemos melhorar.

Por que isso é importante? Porque agora temos métodos que possuem a mesma assinatura. O tipo de saída é booleano e o tipo de entrada é único e do tipo música. Para melhorar nossa situação, vamos reduzir mais o código. Quando temos apenas uma instrução dentro do método e é um método que retorna algo, no caso booleano, podemos simplesmente escrever esse método de uma forma mais concisa. Utilizamos uma seta => seguida da instrução que será retornada. Assim, removemos as chaves {} e eliminamos um excesso de código desnecessário, já que temos apenas uma instrução a ser retornada.

**Aplicando a simplificação de métodos**  
Vamos aplicar isso. Pegamos a instrução, transferimos para a nova forma e removemos o código antigo. Com isso, temos uma série de métodos que nos entregam uma condição, como artista == "Metálica". Podemos ter uma série de métodos para filtrar por título que começa com "A". Todos esses métodos possuem a mesma assinatura. Quando isso acontece, temos um recurso do C# que nos permite capturar essa assinatura em uma variável.

Podemos fazer isso sem gerar erros. Vamos criar uma variável chamada condição. Estamos falando de condição aqui. Condição recebe filtrarPorArtista. O interessante é que não vamos executar esse método. A execução ocorre quando chamamos o método, abrimos parênteses e passamos o objeto música que queremos. No caso, não vamos executar; estamos apenas apontando para esse método. Assim, a variável condição está apontando para o método indicado pelo nome filtrarPorArtista.

**Utilizando Delegates para generalizar filtros**  
Qual é o tipo deste método? Qual é o tipo desta variável? Quando passamos o mouse sobre ela, vemos que é um Func de dois tipos genéricos: primeiro, música; segundo, booleano. O Func de música e booleano indica que é uma função que recebe como entrada um objeto do tipo música e retorna um booleano. Essa é a leitura que fazemos desse tipo no C#. Nomes de tipos que representam métodos com a mesma assinatura são chamados de grupo de métodos na documentação do .NET. O nome desse recurso é Delegate. Um Delegate é um tipo que representa métodos que possuem a mesma assinatura.

Agora que sabemos qual é o tipo, podemos declarar essa variável explicitamente. Ela é um Func que recebe uma música como entrada e retorna um booleano. O interessante é que, além de filtrar por artista, podemos também usar filtrarMaisLongas. Todos esses métodos podem ser atribuídos a essa variável porque possuem a mesma assinatura. Isso é um Delegate: tipos que representam métodos com a mesma assinatura.

**Generalizando o método de filtro**  
O que queremos dizer com isso é que, agora, se podemos declarar uma variável de um tipo Delegate, podemos recebê-la como argumento também. Em vez de fazer filtrarMaisLongas passando a duração, vamos receber como argumento de entrada um Delegate que representa essa condição. Generalizamos a duração, removemos da jogada e colocamos o Delegate como argumento de entrada. Como avaliamos essa condição? Agora, sim, executamos a condição passando a música como argumento de entrada. A condição, que é a expressão que vai avaliar o booleano, está sendo recebida como argumento e retornará um booleano.

```csharp
public static IEnumerable<Musica> FiltrarPor(this IEnumerable<Musica> musicas, Func<Musica, bool> condicao)
{
    foreach (var musica in musicas)
    {
        if (condicao(musica)) yield return musica;
    }
}
```

Generalizamos esse filtro. Podemos até mudar o nome, chamando de filtrarPor. A estrutura repetida de código foi eliminada, pois podemos apagar o filtro filtrarPorArtista. FiltrarPorArtista também será filtrarPorDuração, filtrarPorTítuloQueComeçaComUmaLetra, tudo isso será atendido por esse mesmo método.

**Testando a nova implementação**  
Vamos executar para testar se realmente funciona. Não temos mais os métodos filtrarPorArtista e filtrarMaisLongas, mas temos o filtrarPor. O filtrarPor existe, mas está reclamando porque o argumento de entrada agora não é mais uma string, é uma função. Vamos usar filtrarPorMetálica como argumento de entrada e filtrarMaisLongas como argumento de entrada. São funções, são delegates que estão sendo entregues ao mesmo método.

```csharp
var musicasDoColdplay =
    ObterMusicas(stream)
        .FiltrarPor(musica => musica.Artista == "Metallica") // 2. filtragem por artista
        .FiltrarPor(musica => musica.Duracao >= 400); // 3. filtragem por duração
```

Vamos ver se está tudo funcionando. Ao executar, estamos filtrando por "Metálica" e o filtro funcionou. Estamos filtrando músicas do "Metálica" cuja duração é maior que 400 segundos. O filtro continua funcionando corretamente e conseguimos generalizar a operação de filtro. A operação de filtro é um método de extensão único, e passamos como argumento dessa operação de filtro um delegate, que sabemos ser uma função cujo tipo de entrada é música e o retorno é booleano. Passamos agora um delegate como argumento de entrada, e ele avalia a condição dentro desse método de extensão único.

Vamos continuar evoluindo esse estudo na sequência.

### Aula 3: Dinamizando as condições - Vídeo 4

Transcrição  
Criamos um método de extensão genérico para filtrar objetos e elementos de uma coleção. Este método recebe como argumento de entrada um delegate que representa a condição desejada. No entanto, ainda há um detalhe que nos incomoda: precisamos criar um método para representar cada condição específica. Por exemplo, se quisermos filtrar por músicas da banda Coldplay, teríamos que criar um método chamado filtrarPorColdplay, que receberia a música e verificaria se música.artista é igual a Coldplay. Isso exige que escrevamos um método específico para cada condição.

Vamos começar implementando esse método específico para Coldplay:

```csharp
bool FiltrarPorColdplay(Musica musica) => musica.Artista == "Coldplay";
```

**Melhorando a abordagem de filtragem**  
Podemos melhorar essa abordagem. O mais importante nesses métodos, que possuem a mesma assinatura, é a expressão que gera o valor booleano, que vem após a setinha. O nome do método, como filtrarPorArtista, não é necessariamente importante. Precisamos apenas saber como gerar o valor booleano na expressão do delegate. A única coisa que realmente precisa ser declarada é o nome da variável que representa o objeto do tipo música. No nosso caso, estamos usando o nome música, mas poderia ser m ou mus.

Vamos fazer um teste. Vamos copiar a linha onde estamos filtrando músicas que começam com uma letra específica e colá-la como argumento do método filtrarPor. Apagamos o nome do método e colamos a expressão. Isso inicialmente gera um erro de compilação, mas o que importa é a expressão após a setinha. Não precisamos declarar que a expressão retorna um booleano, pois o compilador já sabe que o método filtrarPor espera um delegate que retorne um booleano. Assim, podemos remover o nome do método e, ao fazer isso, o erro de compilação desaparece.

```csharp
.FiltrarPor((musica) => musica.Titulo.StartsWith('C'))
```

**Otimizando a declaração de tipos**  
Com essa abordagem, conseguimos chamar o método filtrarPor de forma concisa, sem a necessidade de declarar métodos específicos para cada condição. Nossa condição se torna bastante dinâmica. Se quisermos agora filtrar músicas que começam com a letra C, basta alterar a expressão, sem a necessidade de criar um novo método.

Um método foi implementado, o que já trouxe melhorias significativas. No entanto, podemos fazer mais uma otimização. Sabemos que o método filtrar-por espera uma função com um tipo de entrada que é música. Portanto, é desnecessário especificar o tipo aqui. Podemos simplesmente remover a declaração do tipo música e os parênteses associados. Assim, o código passa a representar um delegate de forma dinâmica. A variável do tipo música é chamada de música, e a parte seguinte da seta é a expressão que avalia uma condição booleana: música.titulo.startsWith("C"). Com isso, garantimos concisão e economizamos código, eliminando a necessidade de declarações redundantes. Além disso, dinamizamos completamente as condições, permitindo inserir qualquer condição que retorne true.

Por exemplo, ao usar a expressão true, todos os elementos serão incluídos como saída, pois a condição é sempre verdadeira.

```csharp
.FiltrarPor(musica => true)
```

**Construindo filtros dinâmicos**  
Vamos agora tentar construir um filtro sem copiar e colar. Queremos filtrar músicas que começam com "C" e cujo artista seja "Rolling Stones". Não sabemos se há músicas dos Rolling Stones que começam com "C", mas criamos rapidamente um delegate que representa uma função de música que retorna um booleano. A variável é chamada de m, seguindo uma convenção usada por pessoas desenvolvedoras do .NET para expressões delegates concisas. O nome da variável é a letra inicial do tipo, então música é m minúsculo. Se fosse artista, seria a minúsculo. Essa convenção não é obrigatória, mas ajuda na legibilidade quando entendida.

```csharp
.FiltrarPor(m => m.Artista == "Rolling Stones");
```

**Testando e ajustando condições de filtragem**  
Vamos testar o código. Ao executar, verificamos que não há músicas dos Rolling Stones que começam com "C". Vamos então alterar a condição para verificar se a duração da música é menor que 350. Agora, encontramos uma música, "Chasing the River", que atende a essa condição.

```csharp
.FiltrarPor(m => m.Duracao < 350);
```

**Utilizando expressões lambda para filtragem**  
O método filtrar-por é um método de extensão que utiliza um delegate como argumento de entrada. A construção concisa que estamos usando é chamada de expressão lambda. Em vez de escrever um método que é um delegate com a mesma assinatura, colocamos diretamente o necessário para o método existir. A expressão lambda tem uma parte à esquerda da seta, que é o nome da variável, e a parte à direita é a expressão que será executada. No caso de uma função de música que retorna um booleano, é uma expressão booleana, e o objeto de entrada é uma música.

### Aula 3: Para saber mais: delegates e lambdas

Quando trabalhamos com C#, muitas vezes precisamos passar um comportamento como se fosse um dado. Em vez de só enviar números, strings ou objetos, enviamos uma função para que outro método possa executá-la. É aqui que entram os delegates e as expressões lambda.

**O que são delegates?**  
Um delegate é como um controle remoto universal: ele não executa nada por conta própria, mas pode apontar para diferentes aparelhos (métodos) desde que eles sigam o mesmo padrão de funcionamento (a mesma assinatura de parâmetros e retorno).

Exemplo:

```csharp
public delegate int Operacao(int a, int b);

class Program
{
    static int Somar(int x, int y) => x + y;
    static int Subtrair(int x, int y) => x - y;

    static void Main()
    {
        Operacao op = Somar; 
        Console.WriteLine(op(3, 4)); // Saída: 7

        op = Subtrair;
        Console.WriteLine(op(10, 5)); // Saída: 5
    }
}
```

➡️ Aqui, o delegate Operacao é como um controle remoto que ora aponta para a função Somar, ora para a função Subtrair.

**Delegates prontos do .NET: Action, Func e Predicate**  
Na prática, raramente criamos delegates do zero. O .NET já traz modelos prontos, como se fossem formas de bolo reutilizáveis:

- Action → métodos que não retornam nada.
- Func<T, TResult> → métodos que retornam um valor.
- Predicate<T> → métodos que retornam um bool.

```csharp
Func<int, int, int> multiplicar = (a, b) => a * b;
Console.WriteLine(multiplicar(5, 6)); // Saída: 30
```

➡️ Pense no Func como um molde de função: você só preenche com a lógica que deseja.

**O que são expressões lambda?**  
As expressões lambda são como bilhetes de instruções rápidas: em vez de escrever um manual inteiro (um método com nome, retorno, bloco de código), você escreve uma frase curta dizendo exatamente o que deve ser feito.

```csharp
// Forma tradicional
Func<int, int> quadrado = delegate(int x) { return x * x; };

// Com lambda (bilhete rápido)
Func<int, int> quadradoLambda = x => x * x;

Console.WriteLine(quadradoLambda(5)); // Saída: 25
```

➡️ O => pode ser lido como "transforma em". Exemplo: x => x * x é “pegue x e transforme em x * x”.

**Por que usar delegates e lambdas?**  

- Redução de código: menos verbosidade, mais clareza.
- Flexibilidade: passamos funções como parâmetros sem precisar criar métodos auxiliares.

Em resumo:

- Delegate → é o controle remoto que aponta para métodos compatíveis.
- Lambda → é o bilhete rápido que descreve uma função em poucas palavras.
- Uso prático → tornam o código mais expressivo, ajudam em eventos, callbacks, LINQ e programação assíncrona.

### Aula 3: Otimizando a busca de passagens aéreas com milhas - Exercício

A Jornada Milhas, uma plataforma que facilita a compra de passagens aéreas utilizando milhas, está buscando melhorar a experiência de suas pessoas usuárias ao permitir que filtrem passagens de forma mais eficiente. A equipe de desenvolvimento, da qual você faz parte, está implementando um sistema de filtragem que permite às pessoas usuárias buscar passagens com base em critérios como companhia aérea, destino e duração do voo. No entanto, a equipe percebeu que criar métodos específicos para cada critério de filtragem está tornando o código extenso e difícil de manter.

Como você aplicaria o conceito de expressões lambda para tornar o sistema de filtragem mais dinâmico e eficiente, permitindo que as pessoas usuárias combinem diferentes critérios de busca sem a necessidade de criar métodos específicos para cada combinação?

Resposta:  
Utilizar expressões lambda para criar um método de filtragem genérico que aceita um delegate como argumento, permitindo que as pessoas usuárias definam suas próprias condições de filtragem de forma concisa e flexível.

> Correta, pois ao usar expressões lambda, podemos criar um método de filtragem genérico que aceita um delegate, permitindo que as pessoas usuárias combinem critérios de busca de forma dinâmica e eficiente, simplificando o código e melhorando a experiência de uso da plataforma.

### Aula 3: Dos filtros específicos às operações genéricas - Vídeo 5

Transcrição  
Vamos recapitular tudo o que aprendemos até agora. Começamos com um arquivo de músicas, onde cada linha representava uma música, e essa linha estava separada por ponto e vírgula. A partir dessa linha, construímos um objeto do tipo música, e o arquivo representava uma coleção de músicas.

Trabalhamos com a ideia de um fluxo de informações, um fluxo de manipulação de dados. O primeiro estágio é sempre a obtenção do dado. Estamos obtendo esse dado através de um arquivo, mas poderia ser uma base de dados, outro arquivo com outro formato, ou uma API, um serviço web. Esse é o primeiro estágio de obtenção desses dados. Esses dados são obtidos e transformados em uma coleção de um elemento que faça parte do nosso contexto, no nosso caso, música. A partir daí, os próximos estágios de manipulação são usados para aplicar operações que manipulam a coleção passo a passo.

**Explorando métodos de extensão e LINQ**  
Aprendemos que, para ter esse tipo de processamento como fluxo, utilizamos métodos de extensão, a ideia de delegates (delegados) e também expressões lambda. Esses três itens, somados ao fato de termos o YIELD, que é a construção que entrega um enumerável sob demanda, formam quatro blocos fundamentais que nos ajudam a compreender os recursos utilizados em uma biblioteca que faz exatamente isso: entrega uma série de passos, de estágios de operações que podemos usar para manipular coleções.

Essa biblioteca, que já conhecemos e sobre a qual já falamos algumas vezes, é o LINQ (Language Integrated Query). Trata-se de uma linguagem para consulta de forma integrada. Por que integrada? Pode-se dizer uniforme, pois as operações, a partir do segundo passo, são as mesmas para qualquer coleção, não importa se essa coleção veio de um banco de dados, de um arquivo ou de uma API. As operações são realizadas da mesma maneira.

**Utilizando LINQ para filtrar coleções**  
Na prática, como usamos o LINQ aqui? Não há quase nenhuma mudança. A única coisa que permanece fixa é o passo de obtenção dos dados. Isso é um código proprietário nosso.

Vamos discutir como transformar um arquivo CSV recebido em uma coleção de músicas. Esse é um passo inicial, mas a partir daqui, o filtro será feito pelo LINQ. Qual é o método que filtra elementos de uma coleção? O método Where. Note que não fiz mais nenhuma alteração. O método Where recebe como argumento de entrada uma expressão lambda que precisa ser avaliada em uma condição, resultando em um valor booleano.

Para ilustrar isso, vamos ver um exemplo de como podemos usar o LINQ para filtrar músicas de um artista específico e com uma duração menor que 350 segundos:

```csharp
var musicasDoColdplay =
    ObterMusicas(stream)
        .Where(musica => musica.Titulo.StartsWith('C')) // 2. filtragem por artista
        .Where(m => m.Duracao < 350); // 3. filtragem por duracao
```

**Comparando LINQ com o filtro ARPOR**  
O LINQ oferece dezenas de métodos e operações para manipular uma coleção de elementos. Vamos tentar entender isso melhor em breve. A única diferença que o Where tem em relação ao nosso filtro FILTRARPOR é que eles não conhecem um tipo específico de música. A biblioteca LINQ, da Microsoft, precisa ser genérica, feita para qualquer tipo que seja um elemento de uma coleção. No nosso filtro FILTRARPOR, no método de extensão FILTRARPOR, a diferença é que ele pode receber qualquer tipo como argumento de entrada. Para isso, precisamos fazer algumas alterações.

No filtro FILTRARPOR, a função também precisa ser um tipo de entrada. Em toda parte onde há definição de música, colocamos T na frente. A única mudança adicional é que esse é um método genérico, e precisamos definir qual é o tipo. Talvez o nome não devesse ser "músicas"; poderia ser "coleção", e em vez de "música", poderia ser "elemento". Assim, para cada elemento na coleção, se a condição for avaliada como verdadeira, retornamos esse elemento; caso contrário, não.

**Transformando o método FILTRARPOR em genérico**  
Vamos ver como podemos transformar o método FILTRARPOR para que ele seja genérico:

```csharp
public static IEnumerable<T> FiltrarPor<T>(this IEnumerable<T> colecao, Func<T, bool> condicao)
{
    foreach (var elemento in colecao)
    {
        if (condicao(elemento)) yield return elemento;
    }
}
```

Agora, transformamos o método FILTRARPOR, direcionado para elementos de uma coleção de músicas, em uma forma genérica, que é exatamente o que o FILTRARPOR faz. Ele é uma operação que filtra elementos de qualquer tipo de uma coleção de qualquer tipo para enumeráveis.

**Concluindo o uso do LINQ**  
Concluindo nossa ideia, o LINQ é uma biblioteca que oferece uma série de operações para manipular dados a partir de coleções, usando a ideia de um fluxo. Encadeamos operações que queremos utilizar em uma coleção de elementos, obtendo assim os dados necessários. Vamos usar o LINQ para concluir todas essas atividades que estão em sequência.

### Aula 3: Para saber mais: método group conversion em delegates

**O que é Method Group Conversion**  
O método group conversion em delegates é um recurso do C# que permite atribuir um método a uma variável de delegate sem precisar invocar explicitamente o método. Em outras palavras, o compilador interpreta o nome do método como uma referência à função em si, contanto que a assinatura do método corresponda à do delegate. Isso torna o código mais limpo e facilita a manipulação de métodos como objetos.

**Como funciona a conversão**  
Quando atribuímos um método a uma variável do tipo delegate, o compilador realiza uma verificação para confirmar se a assinatura do método (tipos e número dos parâmetros, e o tipo de retorno) combina com a do delegate. Caso haja correspondência, a conversão – conhecida como method group conversion – acontece automaticamente. Dessa forma, em vez de escrever uma expressão lambda que simplesmente encaminha os mesmos parâmetros para o método, podemos referenciar o método diretamente, o que contribui para a clareza e concisão do código.

Exemplo simplificado:

```csharp
// Definindo um método com uma assinatura compatível
bool FiltrarPorArtista(Musica m) => m.Artista == "Metallica";

// Declarando uma variável do tipo Func que recebe uma Musica e retorna um booleano
Func<Musica, bool> condicao = FiltrarPorArtista;
```

Nesse exemplo, não precisamos invocar o método (isto é, não usamos parênteses). O compilador entende que "FiltrarPorArtista" é uma referência ao método e o associa à variável "condicao".

**Por que essa abordagem funciona**  
Esta abordagem é fundamentada na capacidade do C# de tratar métodos como cidadãos de primeira classe, o que significa que métodos podem ser passados como argumentos, armazenados em variáveis ou retornados de outras funções. A existência dos delegates torna a linguagem flexível para implementar padrões de design, como callbacks e eventos, e também promove a reutilização de funções sem amarrá-las a um contexto específico.

A conversão de group method simplifica a sintaxe ao eliminar a necessidade de lambdas quando a intenção é simplesmente encaminhar os parâmetros para um método já existente. Assim, além de deixar o código mais enxuto, também facilita a legibilidade, principalmente em cenários onde múltiplos métodos com assinaturas idênticas podem ser trocados dinamicamente dentro de operações de filtragem ou processamento de dados.

### Aula 3: Faça como eu fiz: manipule CSV com LINQ

Nesta aula, vimos como ler um arquivo CSV e transformar suas linhas em objetos, além de encadear operações usando métodos de extensão, delegates e expressões lambda para filtrar e manipular os dados. Agora é a sua vez de praticar esses conceitos. Para isso:

- Feche a classe do projeto anterior e abra o projeto 3 no Visual Studio.
- Localize e abra o arquivo 'músicas.csv' para entender sua estrutura de dados com ponto e vírgula como separador.
- Crie a classe Música com as propriedades: título, artista e duração (inteiro).
- Implemente a leitura do arquivo CSV usando FileStream e StreamReader dentro de um bloco using.
- Desenvolva um método que leia cada linha do arquivo, divida a string e converta os valores em um objeto Música.
- Utilize yield return para gerar um IEnumerable de músicas de forma sob demanda.
- Implemente a exibição dos dez primeiros registros da coleção de músicas no terminal.
- Crie um método de extensão para filtrar músicas por artista, utilizando um delegate e expressão lambda.
- Generalize o método de filtro para permitir outras condições (por exemplo, filtragem por duração ou título).
- Teste o fluxo de obtenção e manipulação dos dados, verificando os filtros aplicados e o encadeamento de operações.

### Aula 3: O que aprendemos?

Nesta aula, aprendemos:

- Como utilizar FileStream e StreamReader para ler arquivos e utilizar a cláusula using para gerenciar recursos.
- A criar métodos que retornam IEnumerable`<T>` utilizando yield return para processar dados sob demanda.
- A converter tipos em C#, usando Convert.ToInt32.
- A criar métodos de extensão e utilizar delegates em C# para aplicar filtros em coleções de forma modular.
- A usar expressões lambda para simplificar métodos em C#.
- A manipular coleções usando a biblioteca LINQ para realizar operações de filtragem e transformação.
- A encadear operações em coleções usando métodos de extensão para criar pipelines de dados.
- A construir filtros dinâmicos usando expressões lambda sem a necessidade de criar métodos específicos para cada condição.

## Aula 4: Usando o LINQ

### Aula 4: Projeto da aula anterior

Na aula anterior, conectamos ideias de diferentes estruturas de coleção e suas operações a um fluxo real de manipulação de dados, lendo músicas de um arquivo CSV e aplicando filtragens com delegates, lambdas e métodos de extensão. Essa etapa mostra como estruturar a obtenção, filtragem e manipulação em camadas organizadas. Você pode acompanhar o código no [repositório do curso no GitHub.](https://github.com/alura-cursos/data-manipulation-with-csharp/tree/main/03-AbstraindoAFonteDeDados)

### Aula 4: 02 Operações de filtro e ordenação - Vídeo 1

Transcrição  
Conhecemos a Biblioteca Link, que consiste em uma série de operações para manipular coleções. Nós obtemos os dados na primeira parte do fluxo de manipulação de dados e, a partir daí, aplicamos métodos do Link como estágios para manipular essa coleção.

Vamos conhecer essas operações e tentar explorar o máximo possível delas. Para isso, vamos organizar um pouco o ambiente no Visual Studio. A primeira ação é selecionar o projeto correto na lista de projetos. Na barra inicial, onde temos a lista de projetos e a indicação de qual projeto será executado, clicamos na lista suspensa e marcamos o projeto número 4, que é o Link.

**Preparando o código no Visual Studio**  
Agora, vamos começar a escrever código dentro da classe Program.cs do projeto 4. Antes disso, vamos aproveitar o código já desenvolvido, evitando reescrever tudo. Selecionamos todo o conteúdo do Program.cs atual com "CTRL-A", copiamos com "Ctrl+C" e colamos no Program.cs do projeto 4. No gerenciador de soluções, abrimos o projeto 4, clicamos duas vezes no Program.cs, selecionamos tudo, apagamos com "Delete" e colamos o conteúdo copiado com "Ctrl+V". Assim, transferimos tudo para o novo projeto.

Podemos fechar o Program.cs do projeto 3 e fazer algumas alterações no projeto 4. Precisamos da classe Música, então, no final do arquivo, a partir da linha 79, onde temos o método Filtrar-Por, vamos removê-lo, pois faremos tudo através do Link. Também apagamos os métodos que representavam Delegates para condição. Selecionamos e deletamos, e a partir daí já temos tudo o que precisamos.

**Mantendo e ajustando métodos essenciais**  
Mantemos o método Obter Músicas, que é o primeiro estágio do fluxo de manipulação de dados, e o método Exibir Músicas, que exibe as músicas para testar o código. Por fim, temos um cenário de execução onde pegamos músicas que começam com a letra C e têm duração menor que 350, e as exibimos. Vamos ajustar o nome da variável, que não é mais "Músicas do Codeplay".

O Link possui uma série de operações, que são métodos de extensão e, na maioria, recebem expressões lambda como argumento de entrada. Vamos apresentar essas operações de forma abrangente, mas não exaustiva, pois são muitas. Vamos organizá-las como um catálogo, dividido em sessões ou categorias.

**Explorando operações de filtro**
A primeira categoria que conhecemos é a de filtro, onde a entrada é uma coleção de elementos e a saída é uma coleção de elementos com tamanho menor. Esse tamanho é determinado por um argumento de entrada do método. No caso do WHERE, a primeira operação de filtro que conhecemos, aplicamos uma condição: se o elemento atender a condição, ele será incluído na coleção de saída; caso contrário, não será incluído. Operações de filtro têm essa característica: a coleção de entrada pode ser igual ou maior que a coleção de saída.

Vamos aplicar o WHERE para filtrar músicas do Coldplay, onde música.artista é igual a "Coldplay". Temos essa filtragem e uma segunda filtragem por durações menores que 350.

```csharp
var musicasDoColdplay =
    ObterMusicas(stream)         // 1. obtenção dos dados
    .Where(musica => musica.Artista == "Coldplay"); // 2. filtragem por artista
```

**Implementando ordenação com Link**  
Outra categoria que vamos explorar é a de ordenação. Para ordenar uma coleção por uma propriedade específica, anteriormente precisávamos implementar a interface IComparer ou IComparable. O Link simplifica esse processo, oferecendo ordenação de forma simples. Vamos usar o método ORDER BY para ordenar as músicas do Coldplay por título. Este método ordena de forma crescente, do menor para o maior.

```csharp
var musicasDoColdplay =
    ObterMusicas(stream)         // 1. obtenção dos dados
    .Where(musica => musica.Artista == "Coldplay") // 2. filtragem por artista
    .OrderBy(musica => musica.Titulo);
```

**Testando e exibindo resultados**  
Vamos exibir o resultado e testar a organização do Visual Studio que fizemos, executando o código com F5.

Estamos executando o código e vamos mostrar no terminal. Fizemos um ajuste no zoom para melhor visualização. Temos aqui as músicas do Coldplay, as dez primeiras, lembrando que no método Exibir Músicas há um contador que seleciona apenas as dez primeiras. As músicas estão ordenadas por título. Com isso, não precisamos mais realizar o trabalho de implementar ICompatible, pois o link já oferece um método de ordenação, que utiliza uma expressão lambda como argumento de entrada. Existem outros métodos de ordenação, como o OrderByDescending. Este método realiza a ordenação de forma decrescente, organizando os títulos alfabeticamente de trás para frente. Ao executar novamente, com F5, as músicas são exibidas começando pelas que iniciam com T, seguidas por S, e assim por diante. Note que ele está pegando as dez primeiras, e a que começava com B não está sendo exibida.

```csharp
var musicasDoColdplay =
    ObterMusicas(stream)         // 1. obtenção dos dados
    .Where(musica => musica.Artista == "Coldplay") // 2. filtragem por artista
    .OrderByDescending(musica => musica.Titulo);
```

**Explorando ordenação composta**  
Além do OrderBy, temos a possibilidade de realizar uma ordenação composta. Podemos ordenar por título e, em seguida, por duração de forma decrescente. Assim, as músicas são ordenadas alfabeticamente e, depois, as mais longas são priorizadas. Embora não haja um grande efeito aqui, pois dificilmente há músicas do Coldplay com o mesmo título, esse método permite essa funcionalidade. O ThenBy é um estágio que ordena novamente uma coleção já ordenada.

```csharp
var musicasDoColdplay =
    ObterMusicas(stream)         // 1. obtenção dos dados
    .Where(musica => musica.Artista == "Coldplay") // 2. filtragem por artista
    .OrderBy(musica => musica.Titulo)
    .ThenByDescending(m => m.Duracao);
```

**Utilizando métodos de filtro por quantidade**  
Conhecemos agora as categorias de filtro e ordenação. Temos OrderBy, OrderByDescending, ThenBy e ThenByDescending. Essas são as operações de ordenação disponíveis. Em relação às operações de filtro, temos o Where. Outras operações de filtro permitem selecionar elementos da coleção de entrada não por condição, mas por quantidade. No método Exibir Músicas, exibimos as 10 primeiras músicas utilizando um contador. O link também possui um método para isso, chamado Take, que recebe como argumento de entrada uma quantidade. Por exemplo, podemos usar Take para pegar as 5 primeiras músicas ordenadas por título. Assim, ao invés de exibir 10, ele exibirá 5.

```csharp
var musicasDoColdplay =
    ObterMusicas(stream)         // 1. obtenção dos dados
    .Where(musica => musica.Artista == "Coldplay") // 2. filtragem por artista
    .OrderBy(musica => musica.Titulo)
    .Take(5);
```

**Implementando paginação com Skip e Take**  
O Take é uma maneira de filtrar elementos por quantidade. Além do Take, há outra operação que também filtra por quantidade, mas, ao invés de pegar os primeiros elementos, ela descarta os primeiros. Por exemplo, ao usar o argumento 5, ele descarta os primeiros 5 elementos e exibe os 10 seguintes, conforme a restrição no método Exibir Músicas. Ao pressionar F5, a exibição muda, não incluindo a música que começa com B, e mostrando as músicas de G a T.

```csharp
var musicasDoColdplay =
    ObterMusicas(stream)         // 1. obtenção dos dados
    .Where(musica => musica.Artista == "Coldplay") // 2. filtragem por artista
    .OrderBy(musica => musica.Titulo)
    .Skip(5);
```

Os métodos Skip e Take são frequentemente usados em sistemas que exibem listas de elementos de forma paginada. Imagine uma lista de elementos com páginas, exibindo, por exemplo, 10 elementos por página. Podemos navegar para a próxima ou última página através de setas na interface do usuário. Com Skip e Take, conseguimos implementar essa paginação. Por exemplo, se a página de músicas do Coldplay possui 5 elementos, podemos descartar a primeira página e pegar a segunda. Multiplicamos 5 pelo número da página anterior para pegar a terceira página. Ao pressionar F5, pulamos para a terceira página, pegando 5 elementos.

```csharp
var musicasDoColdplay =
    ObterMusicas(stream)         // 1. obtenção dos dados
    .Where(musica => musica.Artista == "Coldplay") // 2. filtragem por artista
    .OrderBy(musica => musica.Titulo)
    .Skip(5 * 2)
    .Take(5);
```

**Conclusão sobre operações de filtragem e ordenação**  
Na carreira de desenvolvimento, ao implementar paginação, manipulamos coleções usando Skip e Take para acessar uma página específica. Nesta primeira parte, conhecemos duas categorias de operações do link: filtragem, que leva a uma coleção de saída menor ou do mesmo tamanho a partir de uma condição ou quantidade, e ordenação, que aplica uma sequência diferente à coleção de entrada. Em seguida, continuaremos nosso estudo das operações do link por categoria.

### Aula 4: Operações de projeção - Vídeo 2

Transcrição  
Estamos conhecendo as operações do LINQ de forma categorizada. Já exploramos a categoria de filtro e a de ordenação. Vamos agora analisar as funções que queremos implementar. Já conseguimos filtrar por duração, mas ainda não conseguimos filtrar por gênero, pois ainda não processamos o gênero no arquivo CSV. Faremos isso em breve. Já conseguimos ordenar por artista e, em seguida, por músicas. Conseguimos realizar o order by, seguido do then by e then by descending.

Vamos agora criar uma coleção de artistas e suas músicas. Vamos começar mostrando os artistas que temos na nossa coleção de entrada, no arquivo. Para isso, vamos levar essa lógica para o método void OperacoesDeFiltroEOrdenacao, recebendo o StreamReader como argumento de entrada.

```csharp
void OperacoesDeFiltroEOrdenacao(StreamReader stream)
```

**Implementando filtro e ordenação**  
Dentro deste método, vamos mover as linhas onde estamos fazendo filtro e ordenação nas músicas, sempre com o compromisso de deixar o código de referência disponível.

```csharp
void OperacoesDeFiltroEOrdenacao(StreamReader stream)
{
    var musicasDoColdplay =
        ObterMusicas(stream)
            .Where(musica => musica.Artista == "Coldplay") // 2. filtragem por artista
            .OrderBy(musica => musica.Titulo)
            .Skip(5 * 2)
            .Take(5);
    ExibirMusicas(musicasDoColdplay);
}
```

Nosso próximo passo é criar uma variável do tipo artistas, que serão obtidos a partir do primeiro estágio, passando o argumento de entrada, o stream. Queremos obter os artistas desse arquivo, então não queremos mais uma coleção de músicas como saída, mas sim uma coleção de artistas. Não vamos criar uma classe para isso; vamos simplesmente exibir o nome do artista, que está representado pela propriedade artistas.

```csharp
var artistas = ObterMusicas(stream)
    .Select(m => m.Artista);
```

**Exibindo artistas únicos**  
Se tentarmos fazer isso diretamente, vamos pegar os primeiros 20 elementos da coleção de músicas completa. Vamos usar um foreach para iterar sobre os artistas e exibir apenas o nome do artista.

```csharp
foreach(var artista in artistas)
{
    Console.WriteLine(artista);
}
```

No entanto, queremos todos os artistas que existam no arquivo de música de forma organizada, sem repetições. Para evitar elementos repetidos, podemos transformar a coleção em um hash set, mas o LINQ também possui um método para isso, chamado distinct.

```csharp
var artistas = ObterMusicas(stream)
    .Select(m => m.Artista)
    .Distinct()
    .OrderBy(a => a);
```

Após aplicar o distinct, vamos ordenar a lista de forma crescente. Depois de projetar os elementos de música em uma string de artistas e pegar apenas os elementos não repetidos, vamos ordená-los com order by. Neste caso, não há uma propriedade para ordenar, pois estamos ordenando pelo próprio elemento, que é uma string. A ordenação será alfabética.

**Explorando projeção e transformação**  
Conhecemos agora mais algumas operações e categorias. O select é uma categoria de projeção ou transformação. Ele aplica uma função de transformação a uma coleção de elementos do tipo T e entrega uma coleção de elementos de um tipo diferente ou até igual. O distinct é um método de filtragem, que elimina elementos repetidos. O order by já conhecíamos.

Além disso, temos outro método importante que precisamos conhecer. É um método que pode confundir um pouco, pois também é de projeção. Para isso, vamos criar um método void chamado OperacoesDeProjecaoDaniel, que recebe um StringReader. Estamos levando esse código de execução para um método.

Agora, queremos obter a coleção não mais de artistas, mas a coleção de gêneros. Sabemos que a quarta parte de cada linha do arquivo CSV contém os gêneros, separados por vírgula. Como vamos transformar isso? Como vamos obter esses gêneros no arquivo de ObterMusicas? Atualmente, ainda não estamos pegando o gênero, então vamos fazer isso agora.

```csharp
public IEnumerable<string> Generos { get; set; }
Generos = partes[3].Split(',').Select(g => g.Trim())
```

**Obtendo e exibindo gêneros**  
Vamos criar uma propriedade que será uma coleção de strings, ou seja, um IEnumerable<string>, e ela se chamará generos. Agora, temos essa propriedade de gêneros que será populada a partir do índice 3. Vamos quebrar essa parte usando a vírgula como separador. Vamos voltar ao arquivo e quebrar em partes, sendo que cada parte está separada por vírgula.

Agora, sabemos o que queremos fazer. Vamos obter os gêneros a partir do stream, selecionar a propriedade generos, e aplicar distinct e orderBy.

```csharp
var generos = ObterMusicas(stream)
    .SelectMany(m => m.Generos)
    .Distinct()
    .OrderBy(g => g);
```

Será que isso vai funcionar? Vamos exibir os gêneros com um foreach, fazendo um Console.WriteLine para cada gênero.

```csharp
foreach(var genero in generos)
{
    Console.WriteLine(genero);
}
```

**Resolvendo problemas de ordenação**  
Ao executar, ocorreu um erro: "failed to compare two elements no array". Esse erro já ocorreu antes quando tentamos ordenar a lista de músicas. Precisamos implementar o IComparable.

No entanto, não teríamos uma string para cada gênero? Vamos verificar o tipo da lista generos. Ao passar o mouse sobre generos, vemos que é um IOrderedEnumerable`<string>`. Faz sentido, mas há um detalhe: generos é um enumerável de strings, como se fosse uma lista de strings. Não é uma string única, mas um enumerável de enumeráveis. Nesse caso, não conseguimos ordenar um enumerável diretamente.

Queremos todos os gêneros, e há um método que nos ajuda a fazer isso, projetando a coleção de saída e achatando os elementos, chamado SelectMany. Quando usamos SelectMany, projetamos muitos elementos e os achatamos na coleção de saída. Isso nos entrega um enumerável de strings, e a variável generos não é mais um IOrderedEnumerable`<IEnumerable>`, mas sim um enumerável ordenado de strings. Assim, conseguimos os gêneros da coleção de músicas sem erros.

**Corrigindo espaços indesejados**  
No entanto, notamos algo estranho. Por exemplo, temos "Blues Rock" com um espaço em branco. Isso ocorre porque, ao fazer o split, separamos por vírgula e o que vem depois pode ter espaços. Para resolver isso, podemos projetar a coleção aplicando uma transformação. Vamos usar o método Trim da classe string, que elimina espaços no início e no fim. Com isso, teremos uma lista de gêneros com nomes corretos, sem espaços indesejados.

Ao aplicar distinct, teremos uma lista mais enxuta e ordenada alfabeticamente. A execução agora não repete gêneros com espaços em branco, pois aplicamos a transformação com Trim e reforçamos a função de projeção do LINQ.

Imprimimos todos os gêneros distintos do arquivo e conhecemos mais um método de projeção. O SelectMany não só projeta e transforma os elementos de entrada para saída, mas também achata os elementos, entregando-os no primeiro nível da coleção de saída.

Vamos continuar nosso estudo agora com outras categorias do LINQ.

### Aula 4: Operações de agregação - Vídeo 3

Transcrição  
Vamos continuar nossos estudos e agora o desafio é informar a duração média das músicas e a duração total das músicas. No final das contas, o que queremos são algumas estatísticas em relação à coleção de entrada. Para organizar, vamos mover o código atual para o método OperacoesDeProjecao2. Vamos pegar da linha 29 até a linha 21 e levá-lo para dentro do método OperacoesDeProjecao2.

Primeiro, vamos definir o método OperacoesDeProjecao2:

```csharp
void OperacoesDeProjecao2(StreamReader stream)
```

Agora, vamos adicionar o código que realiza a projeção dos gêneros musicais:

```csharp
void OperacoesDeProjecao2(StreamReader stream)
{
    var generos = ObterMusicas(stream)
        .SelectMany(m => m.Generos) // projeção
        .Distinct()
        .OrderBy(g => g);

    foreach (var genero in generos)
    {
        Console.WriteLine(genero);
    }
}
```

**Criando o método EstatisticasDeMusicas**  
Vamos criar um método chamado EstatisticasDeMusicas, onde ele recebe um stream reader como entrada. Queremos exibir, além da duração média e duração total, mais algumas estatísticas. Isso será bastante relevante quando quisermos apresentar algum tipo de relatório a partir de uma coleção manipulada.

Primeiro, definimos o método EstatisticasDeMusicas:

```csharp
void EstatisticasDeMusicas(StreamReader stream)
{

}
```

Agora, vamos adicionar as mensagens que queremos exibir:

```csharp
void EstatisticasDeMusicas(StreamReader stream)
{
    Console.WriteLine($"\nExistem X músicas na coleção.");
    Console.WriteLine($"\nExistem X músicas com mais do que 10 minutos na coleção.");
    Console.WriteLine($"\nA música com menor duração da coleção leva N segundos.");
    Console.WriteLine($"\nA música com maior duração da coleção leva Y segundos.");
    Console.WriteLine($"\nA duração média das músicas da coleção é D segundos.");
    Console.WriteLine($"\nVocê vai levar T dias para ouvir toda a coleção!");
}
```

**Utilizando operações de agregação para obter estatísticas**  
Vamos conseguir obter essas estatísticas através do link, utilizando uma categoria de operações chamada agregação. A agregação pega uma coleção de entrada e entrega um valor único a partir de uma operação ou função de cálculo. Vamos começar respondendo quantas músicas existem na coleção. Primeiro, precisamos obter as músicas, então criaremos uma variável musicas a partir do método ObterMusicas, onde passamos o stream como argumento de entrada.

```csharp
var musicas = ObterMusicas(stream);
```

Tudo está pronto para trabalharmos. Vamos substituir o X por uma expressão de interpolação, onde, a partir da coleção de entrada musicas, chamaremos o método do link chamado Count. Esse método nos entrega quantos elementos existem na coleção de entrada.

```csharp
Console.WriteLine($"\nExistem {musicas.Count()} músicas na coleção.");
```

Agora, aplicaremos a expressão de interpolação e também obteremos um Count, mas esse método Count pode receber um argumento de entrada, que é uma condição. Contaremos apenas os elementos que atendem a essa condição, ou seja, as músicas cuja duração é maior ou igual a 600 segundos, 10 minutos.

```csharp
Console.WriteLine($"\nExistem {musicas.Count(m => m.Duracao >= 600)} músicas com mais do que 10 minutos na coleção.");
```

**Executando e verificando resultados**  
Vamos executar para ver o que está acontecendo antes de trabalharmos com todos os outros. Precisamos chamar o método EstatisticasDeMusicas e passar o nosso stream como argumento de entrada.

```csharp
EstatisticasDeMusicas(stream);
```

Ao executar, verificamos que existem 1293 músicas na coleção e zero músicas com mais de 10 minutos na coleção. Isso é estranho, mas está executando. Vamos continuar. A música com menor duração da coleção leva tantos segundos. Vamos substituir o N e usar musicas.Min().

```csharp
Console.WriteLine($"\nA música com menor duração da coleção leva {musicas.Min(m => m.Duracao)} segundos.");
```

Agora, para a música com maior duração, temos também uma função Max, onde pegamos a duração máxima.

```csharp
Console.WriteLine($"\nA música com maior duração da coleção leva {musicas.Max(m => m.Duracao)} segundos.");
```

A duração média das músicas da coleção é obtida através de outra operação de agregação, aplicando o método Average na coleção de entrada.

```csharp
Console.WriteLine($"\nA duração média das músicas da coleção é {musicas.Average(m => m.Duracao)} segundos.");
```

Para saber quantos dias levaríamos para ouvir toda a coleção, usaremos como operação de agregação o método Sum, somando todas as durações da coleção de entrada. Inicialmente, temos a duração em segundos, e queremos transformar em dias.

```csharp
Console.WriteLine($"\nVocê vai levar {musicas.Sum(m => m.Duracao)/(3600*24)} dias para ouvir toda a coleção!");
```

**Corrigindo erros e materializando a coleção**  
Acho que fizemos tudo. Apresentamos as operações de agregação para exibir estatísticas de músicas, como se fosse um relatório. Vamos executar para verificar, mas encontramos um erro. Recebemos uma exceção chamada "sequência não contém elementos", o que é estranho, pois temos elementos na coleção.

O método que estamos utilizando está lançando uma exceção quando não deveria. Vamos interromper a execução da aplicação para analisar o que está acontecendo. As operações de agregação possuem uma característica importante: para realizar, por exemplo, uma totalização em uma coleção, é necessário percorrer todos os elementos.

Vamos voltar ao código onde obtemos as músicas. No caso do yield return musica, ele está sendo processado para todos os elementos, executando o código até o fim. Se inserirmos um Console.WriteLine indicando que chegou ao fim do processamento do arquivo, veremos que, para executar a operação de agregação, é preciso percorrer todos os elementos da coleção.

```csharp
Console.WriteLine("Chegou ao fim do processamento");
```

Ao executar, ele continuará apresentando um erro, mas queremos mostrar a execução. No primeiro Count, para realizar essa primeira parte, foi necessário chegar ao fim do processamento. Ao exibir as músicas com mais de dez minutos, não havia mais o que processar, pois já tinha chegado ao fim. Tentou-se novamente, e no caso do método Min, ele apresenta um erro quando não há elementos na coleção, diferente do Count, que retorna zero.

**Materializando a coleção em memória**  
Precisamos de uma mudança no código. Em vez de obter as músicas e simplesmente contar com o processamento sob demanda, vamos solicitar ao .NET, ao Runtime, que processe todos os elementos e os coloque em uma lista. Assim, não precisamos mais contar com o yield return. Para isso, no final do método onde obtemos as músicas, chamaremos o método ToList.

```csharp
var musicas = ObterMusicas(stream).ToList();
```

Com isso, percorreremos todos os elementos, chegaremos ao fim do processamento e guardaremos em uma variável musicas. Agora, a variável musicas não é mais um IEnumerable, mas uma lista.

Estamos materializando essa coleção em memória. Quando fizermos o Count, teremos essa lista totalmente na memória, permitindo realizar o Count sem precisar do yield return. Abdicamos do uso do yield return para esse tipo de processamento. Em geral, ao realizar agregações em coleções, especialmente várias em sequência, é importante materializar a coleção.

Vamos executar novamente para ver o resultado. Agora, temos os valores sem problemas ou erros. Existem 1.293 músicas na coleção. Da lista materializada, há duas músicas com mais de 10 minutos (600 segundos). A música com menor duração leva 200 segundos, e a com maior duração leva 952 segundos. A duração média das músicas é 328, com várias casas decimais. Levaríamos 4 dias para ouvir toda a coleção.

Conhecemos agora uma nova categoria de operações do link, chamada agregação, onde, a partir de uma coleção de entrada, obtemos um valor único na saída. Esse valor único depende da operação e de um argumento de entrada. Para isso, é necessário materializar a coleção, pois essa categoria de operações do link avalia todos os elementos imediatamente, percorrendo toda a coleção.

Vamos continuar esse estudo na sequência.

### Aula 4: Otimizando a gestão de tarefas em equipe - Exercício

A Checklist é uma plataforma de gestão de tarefas e checklists para equipes. A equipe de desenvolvimento que você faz parte está trabalhando em um novo recurso que permitirá às pessoas usuárias visualizar estatísticas sobre suas listas de tarefas. Eles querem saber quantas tarefas estão em cada lista, qual é a tarefa mais longa e a mais curta em termos de tempo estimado de conclusão, a duração média das tarefas, e quantos dias, em média, uma equipe leva para concluir todas as tarefas de uma lista.

Como você aplicaria os conceitos de agregação para implementar esse recurso na plataforma Checklist?

Resposta:  
Para implementar o recurso de estatísticas na plataforma Checklist, você pode usar operações de agregação. Para contar quantas tarefas estão em cada lista, utilize a função count para cada lista de tarefas. Para identificar a tarefa mais longa e a mais curta, aplique as funções max e min sobre o tempo estimado de conclusão das tarefas. A duração média das tarefas pode ser calculada usando a função average sobre o tempo estimado. Para calcular quantos dias, em média, uma equipe leva para concluir todas as tarefas de uma lista, some o tempo estimado de todas as tarefas usando sum e divida pelo número de horas em um dia, considerando a jornada de trabalho da equipe.

> Correta, pois esta abordagem utiliza adequadamente as funções de agregação para fornecer as estatísticas desejadas, aplicando count, max, min, average e sum de maneira apropriada para cada tipo de dado necessário.

### Aula 4: Operações de agrupamento - Vídeo 4

Transcrição  
Vamos seguir com nossos desafios relacionados à coleção de músicas. Já conseguimos informar a duração média e a duração total das músicas. Poderíamos também filtrar por gênero, mas ainda não implementamos essa funcionalidade. O próximo passo seria criar uma coleção de artistas e suas músicas. Como podemos obter isso? Através de uma projeção, pois transformaremos uma coleção de músicas em uma coleção de artistas. Além do artista, precisamos incluir as músicas desses artistas, o que se enquadra em outra categoria de operações do link, chamada agrupamento.

Para começar, vamos criar uma variável artistas que irá armazenar essa coleção. Inicialmente, vamos obter as músicas a partir do stream do arquivo:

```csharp
var artistas = ObterMusicas(stream);
```

**Agrupando músicas por artista**  
Agora, precisamos agrupar essas músicas por artista. Para isso, utilizaremos o método GroupBy, que é usado para agrupar a coleção de entrada através de alguma chave. Vamos indicar qual propriedade da coleção de entrada será usada para o agrupamento, utilizando uma expressão lambda para agrupar por artista:

```csharp
var artistas = ObterMusicas(stream)
    .GroupBy(m => m.Artista);
```

Vamos exibir essa coleção de artistas para podermos trabalhar um pouco. O resultado do nosso GroupBy é um enumerável. Estamos conseguindo colocá-lo no foreach, mas vamos verificar o tipo dele: é um enumerável do elemento IGrouping<String, Music>. Vamos ver o que conseguimos fazer aqui. Primeiro, vamos adicionar um Console.WriteLine para pular uma linha e exibir as músicas de cada artista. Vamos pegar apenas os cinco primeiros artistas.

```csharp
Console.WriteLine($"\nExibindo as músicas de cada artista:");
foreach(var artista in artistas.Take(5))
{
    Console.WriteLine($"Artista: {artista.Key}");
    foreach(var musica in artista)
    {
        Console.WriteLine($"\t - {musica.Titulo}");
    }
}
```

**Explorando o uso do IGrouping**  
No foreach, após o in na coleção de artistas, pegamos os primeiros cinco grupos de artistas. Poderíamos ordenar, mas vamos pegar o que vem primeiro na nossa coleção. A primeira coisa é exibir o artista, então utilizamos Console.WriteLine com a expressão de interpolação. O artista é do tipo string. Agora, como exibimos as músicas desse artista? Precisamos fazer um foreach para cada música. Note que o artista não é apenas o nome; ele é um objeto que implementa IGrouping e possui uma propriedade chamada Key, que é a chave usada para o agrupamento. No caso, Key é o nome do artista, já que o agrupamento foi feito por artista. Assim, estamos exibindo o nome do artista.

O IGrouping é enumerável, o que significa que o elemento música pode ser enumerado. Por isso, estamos utilizando var musica in artista para exibir cada música. Vamos fazer um "Tab", um hífen e, em seguida, o nome da música. Note que a variável musica possui título, duração e o próprio artista. Essa variável musica, que está no foreach, é um objeto do tipo música. Quando chamamos GroupBy, geramos uma coleção de saída que é um enumerável de IGrouping, onde esse IGrouping possui dois elementos: o tipo usado como chave, que é uma string (já que artista é do tipo string), e o segundo tipo é o tipo do elemento da lista que está agrupada, no caso, música. Por isso, conseguimos fazer um foreach diretamente em artista, pois IGrouping também implementa enumerável.

**Executando e analisando resultados**  
Vamos executar isso, lembrando que estamos pegando os cinco primeiros artistas para não exibir todas as músicas. Ao pressionar F5, veremos o primeiro artista do arquivo. É interessante notar que o GroupBy também precisa fazer uma avaliação imediata, pois ele precisa processar tudo para agrupar. Imagine que a última linha do arquivo é do artista Rolling Stones, que é o primeiro a aparecer. Ele precisa avaliar toda a coleção para poder fazer o agrupamento. Por isso, operações de agrupamento são avaliadas imediatamente.

O artista Rolling Stones é exibido com suas músicas, seguido por Coldplay, Adele, The Weeknd e Metallica. Isso ocorre porque fizemos um take de cinco. Percebemos que começamos a ter funções bastante complexas. Podemos aplicar funções de agregação nos agrupamentos de artista, como calcular o total de músicas em cada agrupamento. Por exemplo, podemos usar artista.Count com músicas, que já é avaliado imediatamente. Assim, conseguimos realizar todo o trabalho sem precisar materializar uma lista.

Na dúvida, devemos executar e fazer testes. Observamos que Rolling Stones possui nove músicas, Coldplay dezenove, Adele vinte e nove, e Metallica vinte. Começamos a ter um relatório complexo, onde podemos fazer agrupamento, filtro, ordenação e agregação usando todas essas categorias de operações para obter o que precisamos. Conseguimos criar uma coleção de artistas com suas músicas e até entregamos uma totalização de músicas que existem em cada artista. Operações de agrupamento são realizadas dessa maneira.

### Aula 4: Obtenção de elementos específicos - Vídeo 5

Transcrição  
Nosso próximo desafio é informar qual artista possui mais músicas na coleção. Antes disso, vamos separar o código das operações de agrupamento em um método chamado OperacoesDeAgrupamento, onde receberemos um StreamReader como argumento de entrada. Vamos começar definindo o método vazio:

```csharp
void OperacoesDeAgrupamento(StreamReader stream)
{

}
```

Agora, vamos copiar da linha 32 até a linha 21, utilizando "Ctrl+X", e levar para dentro do método OperacoesDeAgrupamento, para que esse código esteja disponível como referência. Vamos adicionar o código de agrupamento dentro do método:

```csharp
void OperacoesDeAgrupamento(StreamReader stream)
{
    var artistas = ObterMusicas(stream)
        .GroupBy(m => m.Artista);
    
    Console.WriteLine($"\nExibindo as músicas de cada artista:");
    foreach (var artista in artistas.Take(5))
    {
        Console.WriteLine($"Artista: {artista.Key} com {artista.Count()} músicas");
        foreach (var musica in artista)
        {
            Console.WriteLine($"\t - {musica.Titulo}");
        }
    }
}
```

**Criando o método de obtenção de elementos**  
Qual artista tem mais durações na coleção? Vamos trabalhar com uma categoria de operações do link, onde, a partir de uma coleção de elementos de entrada, obtemos um elemento na saída, do mesmo tipo. Isso difere das operações de agregação, nas quais temos um valor único, que pode ser numérico ou de outro tipo. Não se trata de uma operação de agregação, mas sim de uma operação da categoria de obtenção de elementos. De uma coleção de entrada, pegamos um desses elementos e o retornamos na saída. Como pegamos esses elementos? A partir de condições. Qual é o elemento que atende a essa condição? Podemos pegar a partir de ordem, primeiro elemento, último elemento. Esse é o tipo de operação que temos na categoria de obtenção de elementos.

Vamos criar um método chamado OperacoesDeObtencaoDeElementos, passando novamente o StreamReader como argumento de entrada. Faremos isso: musicas recebe ObterMusicas a partir do Stream. Vamos começar com o método vazio:

```csharp
void OperacoesDeObtencaoDeElementos(StreamReader stream)
{

}
```

Agora, vamos materializar essa informação em uma lista, uma estrutura de dados em memória, pois, para pegar um elemento específico a partir de uma condição, precisamos percorrer toda a coleção. Algumas operações não precisariam, mas vamos materializar tudo diretamente em uma lista, chamando o método toList, para trabalhar com vários elementos:

```csharp
var musicas = ObterMusicas(stream).ToList();
```

**Utilizando métodos de obtenção de elementos**  
Por exemplo, para a primeira música, utilizaremos o método first. O método first possui uma variação chamada firstOrDefault, que, se a coleção estiver vazia, não lançará uma exceção, mas retornará um valor nulo. Precisamos tratar esse valor nulo ao continuar. Usamos first quando sabemos que há elementos na coleção, e firstOrDefault quando não temos certeza, verificando se está nulo ou não. Vamos deixar o first normal aqui, pois sabemos que existem músicas na coleção, e podemos exibir a primeira música:

```csharp
var primeiraMusica = musicas.First();
Console.WriteLine($"A primeira música é {primeiraMusica.Titulo}");
```

Da mesma maneira, podemos fazer com outros elementos para obtenção, como last ou lastOrDefault. Temos todas essas opções. Para a música de maior duração, lembramos que discutimos quantas músicas existem com maior duração. Fizemos uma estatística assim: qual é a música que tem maior duração? Vamos criar uma variável maiorDuracao, onde musicas utiliza um método chamado MaxBy. O MaxBy é uma agregação, retornando um valor único, que é um valor inteiro. Existe um método chamado MaxBy, que pega o elemento com maior informação, e precisamos passar o argumento, a expressão lambda do argumento de entrada. Vamos pegar a música com maior duração, o elemento música com maior duração:

```csharp
var maiorDuracao = musicas.MaxBy(m => m.Duracao);
if (maiorDuracao is not null)
{
    Console.WriteLine($"A música com maior duração é {maiorDuracao.Titulo} com {maiorDuracao.Duracao} segundos.");
}
```

**Identificando o artista com mais músicas**  
Essa categoria do link é a categoria de operações de obtenção de elementos a partir de uma coleção de elementos do tipo T. Aplicamos uma operação com argumentos de entrada e obtemos um elemento do tipo T, sempre do mesmo tipo. Para resolver e informar qual artista tem mais músicas na coleção, vamos encadear uma série de operações de categorias diferentes para responder a essa pergunta.

Vamos apagar a chamada do método de operações de elementos e obter novamente os artistas a partir do stream de músicas. Vamos agrupar essas músicas por artista e fazer uma projeção. Vamos gerar um objeto de tipo anônimo. Já discutimos sobre tipos anônimos, que são quando não temos o nome da classe e geramos diretamente um objeto a partir dessa construção. Fazemos um nil e abrimos e fechamos a chave, colocando dentro as propriedades desse objeto.

Vamos gerar um tipo anônimo, que é bastante utilizado quando precisamos usar o link para projetar uma informação e utilizá-la logo depois. Vamos criar um objeto cujo nome do artista é o próprio G.Key. As músicas desse artista estão dentro do G. Lembramos que G é o iGrouping de Key e Música, sendo que a segunda parte é o enumerável. Estamos levando as músicas para cá e o total de músicas é uma agregação. Pegamos o G, a quantidade de músicas, e aplicamos uma função de agregação que conta essas músicas:

```csharp
var artistaComMaiorQtdeMusicas = ObterMusicas(stream)
    .GroupBy(m => m.Artista)
    .Select(g => new { Artista = g.Key, Musicas = g, Total = g.Count() })
    .MaxBy(a => a.Total);
```

Criamos a variável que representa esse nome e vamos imprimir com Console.WriteLine. Usamos o símbolo que representa a interpolação. O artista com maior quantidade de músicas é exibido:

```csharp
if (artistaComMaiorQtdeMusicas is not null)
{
    Console.WriteLine($"O artista com maior qtde de músicas é {artistaComMaiorQtdeMusicas.Artista} com {artistaComMaiorQtdeMusicas.Total} músicas!");
}
```

Temos a resposta: o artista com maior quantidade de músicas é o Maroon 5, com 40 músicas. Naquela hora, quando vimos a operação de agrupamento, o group by, tínhamos um com 29, outro com 20, e não tínhamos chegado ao Maroon 5 porque fizemos um take dos 5 primeiros. Então, Maroon 5, com 40 músicas, é o artista que tem a maior quantidade de músicas. Para isso, usamos mais uma categoria de operações do link, que é a categoria de obtenção de elementos, onde, a partir de uma coleção de entrada de um elemento do tipo T, aplicamos alguma operação ou condição que nos entrega um elemento do tipo T na saída.

### Aula 4: Para saber mais: métodos do LINQ

O LINQ (Language Integrated Query) é uma das ferramentas mais poderosas do C#. Ele permite consultar, transformar e manipular coleções de dados de forma declarativa e concisa, como se estivéssemos escrevendo consultas em uma linguagem própria dentro do C#.

Com o LINQ, não precisamos mais escrever laços for e estruturas complexas para filtrar, ordenar, agrupar ou combinar dados. Em vez disso, utilizamos métodos de extensão padronizados, aplicados a coleções que implementam IEnumerable<T> ou IQueryable<T>.

Esses métodos podem ser agrupados em categorias de operação, como filtragem, projeção, ordenação, agregação, junções e agrupamentos. Cada categoria resolve um tipo de problema comum na manipulação de dados.

A tabela a seguir resume os métodos mais importantes do LINQ, separados por categoria, com uma breve explicação e exemplos práticos para você ter como referência rápida no dia a dia.

Show! Seguindo o formato “Para saber mais”, aqui vai um PSM de LINQ com os métodos mais usados, organizados por categoria. Incluí a função e um exemplo curtinho (C#) para cada um.

Projeção

| Método | Função | Exemplo |
| --- | --- | --- |
| Select | Projeta cada item em uma nova forma. | nums.Select(n => n * 2) |
| SelectMany | “Achata” sequências aninhadas. | pedidos.SelectMany(p => p.Itens) |

## Filtragem

| Método | Função | Exemplo |
| --- | --- | --- |
| Where | Filtra por predicado. | `nums.Where(n => n % 2 == 0)` |
| OfType&lt;T&gt; | Filtra por tipo. | `objs.OfType<string>()` |

## Ordenação

| Método | Função | Exemplo |
| --- | --- | --- |
| OrderBy / OrderByDescending | Ordena crescente/decrescente por chave. | `pessoas.OrderBy(p => p.Nome)` |
| ThenBy / ThenByDescending | Ordenação secundária. | `pessoas.OrderBy(p=>p.Cidade).ThenBy(p=>p.Nome)` |
| Reverse | Inverte a ordem atual. | `nums.Reverse()` |

## Agrupamento

| Método | Função | Exemplo |
| --- | --- | --- |
| GroupBy | Agrupa por chave (retorna grupos). | `alunos.GroupBy(a => a.Turma)` |
| ToLookup | Índice imutável chave→itens (eager). | `alunos.ToLookup(a => a.Turma)` |

## Junções

| Método | Função | Exemplo |
| --- | --- | --- |
| Join | Inner join entre sequências. | `clientes.Join(pedidos, c=>c.Id, p=>p.ClienteId, (c,p)=>new{c,p})` |
| GroupJoin | Left join (agrupa relacionados). | `clientes.GroupJoin(pedidos, c=>c.Id, p=>p.ClienteId, (c,ps)=>new{c,ps})` |
| (Padrões) | Left/Right/Full via combinações | `Left: from c in clientes join p in pedidos on c.Id equals p.ClienteId into grp from p in grp.DefaultIfEmpty() select new{c,p}` |

## Agregação

| Método | Função | Exemplo |
| --- | --- | --- |
| Count / LongCount | Conta elementos (condição opcional). | `nums.Count(n=>n>0)` |
| Sum / Min / Max / Average | Agregações numéricas. | `nums.Average()` |
| Aggregate | Redução personalizada (fold). | `palavras.Aggregate((a,b)=> a + "," + b)` |

## Elemento (busca pontual)

| Método | Função | Exemplo |
| --- | --- | --- |
| First / FirstOrDefault | Primeiro item (ou default). | `nums.FirstOrDefault(n=>n>10)` |
| Single / SingleOrDefault | Exige exatamente 1 item (ou default). | `emails.Single(e=>e.Principal)` |
| Last / LastOrDefault | Último item (ou default). | `logs.LastOrDefault()` |
| ElementAt / ElementAtOrDefault | Acessa pelo índice. | `nums.ElementAtOrDefault(3)` |
| DefaultIfEmpty | Fornece default se vazio. | `seq.DefaultIfEmpty(0)` |

## Quantificadores

| Método | Função | Exemplo |
| --- | --- | --- |
| Any | Existe algum que atenda? | `nums.Any(n=>n<0)` |
| All | Todos atendem? | `nums.All(n=>n>=0)` |
| Contains | Contém o valor? | `nums.Contains(42)` |
| SequenceEqual | Mesma sequência/ordem? | `a.SequenceEqual(b)` |

## Conjuntos (teoria de conjuntos)

| Método | Função | Exemplo |
| --- | --- | --- |
| Distinct | Remove duplicatas. | `nums.Distinct()` |
| Union | União (distintos). | `a.Union(b)` |
| Intersect | Interseção. | `a.Intersect(b)` |
| Except | Diferença (A–B). | `a.Except(b)` |

## Particionamento

| Método | Função | Exemplo |
| --- | --- | --- |
| Take / Skip | Pega/pula N itens. | `produtos.Skip(20).Take(10)` |
| TakeWhile / SkipWhile | Enquanto predicado verdadeiro. | `nums.TakeWhile(n=>n<100)` |
| Chunk (.NET 6+) | Divide em blocos do mesmo tamanho. | `nums.Chunk(100)` |

## Geração

| Método | Função | Exemplo |
| --- | --- | --- |
| Range | Gera intervalo de ints. | `Enumerable.Range(1, 10)` |
| Repeat | Repete valor N vezes. | `Enumerable.Repeat("a", 3)` |
| Empty&lt;T&gt; | Sequência vazia tipada. | `Enumerable.Empty<string>()` |

## Conversão & Materialização

| Método | Função | Exemplo |
| --- | --- | --- |
| ToList / ToArray | Materializa coleção. | `query.ToList()` |
| ToDictionary | Dicionário por chave (e valor opcional). | `pessoas.ToDictionary(p=>p.Id)` |
| AsEnumerable | Força resolução como LINQ a objetos. | `query.AsEnumerable()` |
| Cast&lt;T&gt; | Converte elementos (lança se falhar). | `objs.Cast<string>()` |

## Combinação & utilidades

| Método | Função | Exemplo |
| --- | --- | --- |
| Zip | Combina pares por posição. | `a.Zip(b, (x,y)=>x+y)` |
| Append / Prepend | Adiciona item ao fim/começo. | `nums.Append(99)` |
| Concat | Concatena sequências. | `a.Concat(b)` |
| Select com índice | Projeção com índice. | `itens.Select((x,i)=> new { i, x })` |

Algumas dicas

- Select vs SelectMany: se o seletor retorna coleção, use SelectMany para “achatar” (ex.: Pedidos → Itens).
- First vs Single: First aceita 1+ itens; Single exige exatamente 1 (útil para chaves únicas).
- Ordenação estável: OrderBy é estável; use ThenBy para chaves secundárias.
- Eager vs Deferred: ToList/ToArray/ToDictionary executam agora; sem materializar, a query roda ao iterar.
- Performance: filtre/seleciona antes de materializar; evite múltiplas enumerações não necessárias.

### Aula 4: Sincronizando contatos profissionais por setor - Exercício

A Indexa, uma plataforma que organiza e gerencia contatos pessoais e profissionais de forma inteligente, utilizando recursos de busca avançada e sincronização automática, está desenvolvendo uma nova funcionalidade para ajudar as pessoas usuárias a sincronizar seus contatos profissionais por setor de atuação. A ideia é que as pessoas usuárias possam visualizar e acessar rapidamente todos os contatos dentro de um determinado setor, como tecnologia, saúde ou finanças.

Qual abordagem seria mais eficaz para garantir que os contatos sejam agrupados e sincronizados corretamente por setor?

Resposta:  
Utilizar um método de agrupamento que organize os contatos profissionais por setor de atuação, aplicando uma chave de agrupamento, como o setor de atuação de cada contato, e implementar sincronização automática para atualizações em tempo real.

> Correta, pois ao utilizar um método de agrupamento, como o GroupBy, a plataforma pode criar coleções de contatos agrupados por setor, permitindo que as pessoas usuárias visualizem e acessem rapidamente todos os contatos dentro de um setor específico. A sincronização automática garante que qualquer atualização nos contatos seja refletida em tempo real, mantendo as informações sempre atualizadas e organizadas.

### Aula 4: Operações para verificação de existência - Vídeo 6

Transcrição  
Concluímos nossos desafios de manipulação de dados e obtenção de informações a partir de uma coleção de músicas. Manipulamos os dados utilizando as operações do LINQ. Finalizamos mais uma função para implementar, mas decidimos apresentar mais uma categoria de operações do LINQ.

Vamos verificar artistas que tenham pelo menos uma música com duração superior a 8 minutos e artistas com pelo menos uma música de rock. Já sabemos que temos músicas de rock na coleção.

**Explorando a existência de gêneros musicais**  
Será que há músicas de reggae na coleção? E outra pergunta, existem músicas de jazz na coleção? Vamos tentar ver operações do LINQ para poder fazer isso. A primeira coisa de sempre é dar uma limpada na execução. Vamos criar um método para trazer esse código.

Vamos começar com o artista com maior quantidade, recebendo no StreamReader. Tudo de sempre: abre e fecha chaves. Vamos mover a linha 24 para a linha 30, para dentro desse método.

**Criando o método de verificação de existência**  
Muito bem. Então, aqui vamos fazer void OperacoesDeVerificacaoDeExistencia e o nome dessa categoria, onde vamos verificar uma determinada condição. Essa condição vai retornar um booleano. Essa operação, desculpe, vai retornar um booleano. É chamada de Operações de Verificação de Existência a partir de um StreamReader.

```csharp
void OperacoesDeVerificacaoDeExistencia(StreamReader stream)
{
}
```

Muito bem. Então, abrimos e fechamos chaves aqui. Vamos reforçar o que foi dito: é uma categoria de operações do LINQ, onde a partir de uma coleção de elementos de entrada, entregamos um booleano. Existe alguma informação nessa coleção? Ou tem pelo menos um elemento? Todos esses elementos têm essa mesma condição. Sempre vai retornar um booleano. É esse tipo de categoria que vamos ver agora.

**Identificando artistas com músicas longas**  
Vamos lá. Artistas com pelo menos uma música acima de 8 minutos. Precisamos obter os artistas. Primeiro, vamos pegar as músicas:

```csharp
var musicas = ObterMusicas(stream).ToList();
```

Vamos materializar também, porque nesse caso será necessário para fazer agrupamento e tudo mais. Então, das músicas, vamos agrupá-las por artista. Vamos usar um filtro aqui. Desse agrupamento, vamos pegar os artistas, os grupos que contêm pelo menos uma música acima de 8 minutos.

```csharp
var artistas = musicas
    .GroupBy(m => m.Artista)
    .Where(g => g.Any(m => m.Duracao >= 480));
```

**Imprimindo artistas com músicas longas**  
Sabemos que o grupo é um enumerable com as músicas. Lembre-se disso. O grupo, esse G que estamos chamando, pode ser chamado de artista, mas é melhor chamar de grupo, porque ele é um IGrouping de String e Música. Ele tem uma propriedade chamada chave. Lembre-se, essa chave é o nome do artista. A segunda parte é o próprio G, que é um enumerable de músicas. Aqui, vamos aplicar uma função que vai retornar um booleano. Então, pelo menos uma música acima de 8 minutos. Vamos dizer assim: existe qualquer um desse grupo cuja música, cuja duração, seja maior ou igual a 480 segundos.

Tranquilo? Então, pegamos aqui artistas, agrupamos por artistas que têm pelo menos um elemento cuja duração é maior do que 480 segundos, ou seja, 8 minutos. Vamos fazer um foreach para imprimir esses artistas.

```csharp
foreach(var artista in artistas)
{
    Console.WriteLine($"\t- {artista.Key}");
}
```

**Ajustando critérios de duração**  
Vamos executar esse código para ver artistas que possuem pelo menos uma música com duração de 480 segundos, ou seja, 8 minutos.

Quando executamos isso, temos muitos artistas, e não estão ordenados porque não ordenamos. Vamos aumentar um pouco. Vamos dizer que queremos que seja, sei lá, 9 minutos, ou seja, 540 segundos.

```csharp
var artistas = musicas
    .GroupBy(m => m.Artista)
    .Where(g => g.Any(m => m.Duracao >= 540));
```

Agora a coisa ficou mais séria. Temos Roberto Carlos e Calvin Harris. São apenas os dois artistas que possuem músicas com mais de 9 minutos. Certo? Beleza, Calvin Harris, inclusive, é o artista que tem aquela música maior.

**Verificando a existência de músicas de reggae**  
Beleza, então, artista com pelo menos uma música acima de 9 minutos, ou 540 segundos. Artista com pelo menos uma música de reggae, será que existe? Vamos criar aqui Reggae e vamos lá nas músicas. Vamos fazer uma mudança. Pode ser o mesmo código, mas agora vai mudar um pouco.

```csharp
var reggae = musicas
    .GroupBy(m => m.Artista)
    .Where(g => g.Any(m => m.Generos.Contains("Reggae")));
```

E aí, os gêneros também são um enumerable. Vamos usar mais uma função aqui que nos permite verificar se existe um elemento desse enumerable. No caso, enumerable de gêneros é string, e queremos verificar qual elemento é reggae. Então, artistas que possuem essa característica, terem músicas de reggae, vamos exibir aqui.

```csharp
foreach(var artista in reggae)
{
    Console.WriteLine($"\t- {artista.Key}");
}
```

**Separando e exibindo resultados**  
Precisamos fazer uma separação aqui rapidamente. Executamos, mas não mostramos para vocês, pois ficamos com vergonha da exibição. Artistas com músicas, vamos pular uma linha aqui, \n, artistas com músicas acima de 9 minutos. Beleza. E agora vamos colocar aqui artistas com músicas de reggae.

```csharp
Console.WriteLine("\nArtistas com músicas acima de 9 minutos:");
Console.WriteLine("\nArtistas com músicas de Reggae:");
```

Aí conseguimos separar bem. Muito bom. F5 para executar. Agora sim, artistas com músicas acima de 9 minutos: Roberto Carlos e Calvin Harris. Artistas com músicas de reggae: Skank e, claro, Bob Marley.

**Resumindo categorias de operações do LINQ**  
Muito bom. Então, vimos aqui que também existe um grupo de operações do LINQ, onde a partir de uma coleção de elementos de entrada, retornamos um booleano, que é justamente para verificar alguma condição de existência desses elementos de entrada. O método Any é um método que nos ajuda nisso. Além disso, temos o método Contains, também temos o método Exists e temos o método All. Também são operações que se enquadram na categoria de Operações de Verificação de Existência.

Poderíamos continuar falando de mais algumas operações do LINQ, mas já demos a ideia de que as operações do LINQ se enquadram em categorias. Falamos um pouco sobre essas categorias e agora vamos fazer um resumo rápido de cada uma dessas categorias. Vamos copiar aqui um resumo que colocamos em forma de comentário. Vamos pular uma linha aqui antes de começar a execução de fato do código. Vamos colocar esse comentário aqui para entender um pouco as categorias de operações do LINQ.

```csharp
/*
Fluxo Padrão: Estágio 1 (Origem Dados) > Estágio 2 > ... > Estágio N

LINQ - Categorias de operações para manipulação de coleções
============================================================

Filtro (+)      | coleção c/ tam menor/igual atendendo condição | Where, Distinct
Projeção (+)    | coleção transformada, do mesmo tipo ou não     | Select, SelectMany
Ordenação (+)   | coleção ordenada pela expressão lambda        | OrderBy, ThenBy
Agregação (*)   | valor único a partir de operação de acúmulo   | Sum, Min, Max
Agrupamento (+) | coleção de grupos onde a chave é o argumento  | GroupBy
Elementos (*)   | elemento único T a partir do argumento        | First, Last, MinBy
Existência (*)  | booleano a partir da operação e argumento     | All, Any, Contains
Conversão (*)   | coleção em outra estrutura                    | ToList, ToArray

+ operações avalidas sob demanda (yield)
* operações avalidas imediatamente
*/
```

**Recapitulando operações do LINQ**  
Então, começando a lembrar, começando a recapitular, trabalhamos com manipulação de coleções através de um fluxo. O fluxo padrão é o primeiro estágio, onde obtemos os dados, e a partir do segundo estágio, aplicamos operações do LINQ para manipular esses dados de acordo com a necessidade. Podemos ter operações que se enquadram nessas categorias que estamos colocando aqui: filtro, projeção, ordenação, agregação, agrupamento, obtenção de elementos, verificação de existência e até conversão.

Falamos de to-list, que converte uma coleção de elementos de um tipo em outra estrutura de coleção também. No caso, to-list, to-array, to-hash-set, to-dictionary. Temos uma série de métodos que fazem conversão e assim usamos algumas delas. Operação de filtro: a coleção de saída tem um tamanho menor ou igual a partir de uma condição. Falamos do where, falamos do distinct.

**Detalhando categorias de operações**  
Projeção: transforma a coleção de entrada em uma coleção de saída, sendo do mesmo tipo ou não. Falamos do select, falamos do selectMany, que é usado para quando a propriedade que estamos selecionando é um array, é um enumerable, uma coleção. Aí achatamos todos esses elementos no nível acima.

Ordenação: entrega uma coleção ordenada através de uma expressão lambda. Falamos do order by, falamos do then by, falamos do order descending.

Operações de agregação: obtém um valor único a partir da coleção de entrada. Vamos usar a operação que vai acumular esse valor: sum, min, max, count. Tudo isso são operações de agregação.

Categoria agrupamento: pega a coleção de entrada e agrupa por alguma chave. Obtivemos artistas, por exemplo, a partir das músicas, e aí obtivemos informações bastante interessantes: artistas que são de reggae, artistas que têm pelo menos uma música com 400 minutos, o artista que tem o maior total de músicas, que era o Maroon 5. Então, fomos obtendo informações bastante relevantes para trabalhar justamente com o agrupamento. O método é o group by.

**Explorando obtenção de elementos e existência**  
Obtenção de elementos: a partir de uma coleção de entrada de um elemento T, obtém um elemento T. Vamos usar a função, o método que queremos: quero pegar o primeiro, quero pegar o último, quero pegar o elemento que se adequa a uma expressão de mínimo ou máximo, min by, max by. Falamos do first or default, last or default. Temos esse tipo de operação.

Categoria de existência: foi essa última que falamos. A partir de uma coleção de entrada, temos uma verificação a partir de uma condição, onde vamos retornar um booleano. Falamos do all, falamos do any, falamos do contains.

**Considerações sobre conversão e otimização**  
E também operações de conversão, onde materializamos aquela coleção enumerable em uma estrutura de dados em memória. Fazemos toda a avaliação para poder converter isso em memória. Usamos muito o to-list para isso. Marcamos aqui também as categorias com mais e asterisco para indicar as categorias que são avaliadas sob demanda, ou seja, que usam yield return. Só vai entregar quando aquele yield return for processado. Então, filtro pode fazer isso, projeção pode fazer isso, agrupamento, algumas partes, mas a maioria das categorias precisa avaliar as operações antes de começar a trabalhar.

Isso é importante quando começamos a trabalhar com a origem do dado. Se a origem do dado tiver um recurso importante que precisa ser manipulado, em geral, é interessante que já materializemos essa informação usando o to-list, usando o to-array, usando algum outro tipo de método de conversão, para que não precisemos nos preocupar com aqueles erros que tomamos, que estávamos esperando, erros e comportamentos indesejados. Por exemplo, estávamos tentando ver o total de músicas sob alguma determinada condição e veio zero. Isso porque já tinha chegado ao final da enumeração e não tinha mais nada para processar. Então, às vezes, é bom já fazer essa conversão com uma lista, mas precisamos tomar cuidado. Se essa lista for muito grande, vamos colocar a lista toda em memória. Então, precisamos pensar em qual estratégia vamos usar, considerando também essa parte de otimização.

**Concluindo a exploração das operações do LINQ**  
Vimos então as operações do LINQ que são usadas. Mostramos esse catálogo por categoria. O próximo passo na manipulação de dados virá em seguida.

### Aula 4: Para saber mais: ordenando coleções com LINQ

**Ordenação em múltiplos níveis**
Ao trabalharmos com ordenação em coleções, muitas vezes é necessário aplicar critérios hierárquicos de ordenação. O método OrderBy é utilizado para definir o primeiro critério e, em seguida, o ThenBy ou ThenByDescending são empregados para refinar essa ordenação quando os elementos possuem chaves iguais no primeiro nível. Essa abordagem permite estruturar os dados de forma que, por exemplo, se os valores principais forem iguais, os itens serão ordenados por uma segunda propriedade.

Como funciona o encadeamento de ordenação
Inicialmente, o OrderBy organiza a coleção com base em uma função de seleção fornecida, criando uma primeira camada de ordenação. Caso dois ou mais elementos tenham o mesmo valor para essa chave, o ThenBy entra em ação para desempatar, utilizando uma nova função de seleção. Quando a necessidade exige uma ordenação decrescente em um nível posterior, o uso de ThenByDescending se torna a alternativa adequada.

Exemplo prático:

```csharp
var playlistOrdenada = musicas
    .OrderBy(m => m.Artista)        // Ordena pelo nome do artista
    .ThenBy(m => m.Nome)             // Se os artistas forem iguais, ordena pelo nome da música
    .ThenByDescending(m => m.Duracao); // Para músicas do mesmo artista e nome iguais, ordena pela duração de forma decrescente
```

Nesse exemplo, a coleção é ordenada primeiramente pelo artista, depois pelo nome da música e, por fim, pela duração em ordem decrescente. Dessa forma, se houver muitas músicas do mesmo artista, o critério adicional assegura que a ordem seja consistente e significativa.

**Vantagens e cuidados**  
Entre as vantagens dessa abordagem estão a clareza e a simplicidade do pipeline de ordenação, permitindo ao desenvolvedor definir de forma elegante múltiplos critérios sem a necessidade de escrever comparadores complexos. Contudo, é importante lembrar que cada critério adicional gera uma nova camada de avaliação, o que, em coleções extremamente grandes, pode impactar a performance. Por isso, escolha os níveis de ordenação com base na necessidade real e no contexto da aplicação.

Essa técnica de ordenação múltipla é um exemplo poderoso de como o LINQ promove uma sintaxe declarativa e intuitiva para tratar coleções, facilitando a manutenção e a legibilidade do código.

### Aula 4: O que aprendemos?

Nesta aula, aprendemos:

- A utilizar o método Select para projetar elementos em novas formas.
- A remover duplicatas em coleções usando o método Distinct.
- A ordenar coleções com o método OrderBy.
- A projetar e achatar coleções aninhadas com SelectMany.
- Sobre o uso de GroupBy para agrupar coleções por chave.
- A aplicar operações de agregação como Count, Sum, Min, Max, e Average.
- As operações de verificação de existência com Any e Contains.
- Como utilizar métodos como First, FirstOrDefault, e MaxBy para obtenção de elementos.

## Aula 5: String

### Aula 5: Projeto da aula anterior

Na aula anterior conhecemos o LINQ, uma poderosa biblioteca que unifica operações de consulta e transformação em coleções. Aplicamos filtros, projeções, agregações, agrupamentos e verificações de existência de forma concisa e legível. Para revisar e testar os exemplos no projeto, acesse o [repositório do curso no GitHub.](https://github.com/alura-cursos/data-manipulation-with-csharp/tree/main/04-LINQ)

### Aula 5: Manipulando textos - Vídeo 1

Transcrição  
Muito bem, encerramos nosso estudo sobre LINQ, no qual mostramos as operações que ele disponibiliza. Apresentamos as operações de forma abrangente, embora não completa, e as categorizamos. No final desse estudo, mostramos uma tabela comentada e deixamos disponível para que possam explorar novas operações ainda não apresentadas, inserindo-as nessas categorias para estudo próprio.

Agora, vamos avançar em nosso processo de aprendizado sobre manipulação de dados, mudando o foco de coleções para um tipo de dado fundamental e onipresente nas aplicações de software: o tipo texto, conhecido como string no .NET e em outras linguagens.

**Organizando o ambiente no Visual Studio**  
Antes disso, vamos organizar nosso ambiente no Visual Studio. Primeiro, fecharemos a aba que contém o arquivo program.cs do projeto 4, relacionado ao LINQ. Em seguida, na barra inicial do Visual Studio, selecionaremos o próximo projeto, número 5, chamado "string", que será nosso objeto de estudo. Fecharemos o projeto 4 e abriremos o projeto 5, além da classe program.cs, que contém o arquivo inicial de um projeto do tipo terminal. Notem que esse projeto inicial já contém o texto "Hello World", demonstrando a onipresença dos textos e a necessidade de manipulá-los em nossos programas.

```csharp
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
```

Vamos selecionar todo o conteúdo desse arquivo e apagá-lo, substituindo-o por um código pronto que vem do nosso estudo de coleções. Esse código, do projeto 5, é uma estrutura mais elaborada do trabalho com coleções que fizemos até aqui. Para recapitular, estamos obtendo uma coleção de músicas a partir de um arquivo CSV, usando uma operação de filtro para pegar as cinco primeiras músicas e exibi-las. A diferença neste código é que o arquivo CSV contém uma coluna adicional com a data de lançamento da música. Na linha 43, temos uma nova propriedade na classe Música, que é o lançamento da música, do tipo DateTime. Por fim, exibimos essa data de lançamento entre colchetes.

Implementando a leitura de músicas de um arquivo CSV

```csharp
using var arquivo = new FileStream("musicas.csv", FileMode.Open, FileAccess.Read);
using var stream = new StreamReader(arquivo);

var musicas = ObterMusicas(stream)
    .Take(50);

ExibirMusicas(musicas);

void ExibirMusicas(IEnumerable<Musica> musicas)
{
    Console.WriteLine("\nMúsicas do arquivo:");
    foreach (var musica in musicas)
    {
        var linha = $"\t- {musica.Titulo} ({musica.Artista}) - {musica.Duracao}s [{musica.Lancamento}]";
        Console.WriteLine(linha);
    }
}

IEnumerable<Musica> ObterMusicas(StreamReader stream)
{
    var linha = stream.ReadLine();
    while (linha is not null)
    {
        var partes = linha.Split(';');
        var musica = new Musica
        {
            Titulo = partes[0],
            Artista = partes[1],
            Duracao = Convert.ToInt32(partes[2]),
            Generos = partes[3].Split(',').Select(g => g.Trim()),
            Lancamento = Convert.ToDateTime(partes[4])
        };
        yield return musica;
        linha = stream.ReadLine();
    }
}

class Musica
{
    public string Titulo { get; set; }
    public string Artista { get; set; }
    public int Duracao { get; set; }
    public IEnumerable<string> Generos { get; set; }
    public DateTime Lancamento { get; set; }
}
```

Vamos salvar e executar o arquivo com F5. No terminal, as cinco primeiras músicas são exibidas segundo o padrão criado: título, artista entre parênteses, um hífen com a duração em segundos e, por fim, a data de lançamento entre colchetes.

**Introduzindo o conceito de strings**  
Vamos começar nosso estudo de strings pelo mais simples. Uma string é um objeto em memória, uma classe no .NET. Quando precisamos de uma string, alocamos um objeto em memória, mas, diferentemente do padrão normal de criação de objetos, não usamos new. Criamos usando o string literal, que é escrever um texto entre aspas duplas. No método de exibição de músicas, o título é uma string e está sendo alocado como um objeto. Vamos mover esse título para uma variável para demonstrar essa alocação.

```csharp
var titulo = "\nMúsicas do arquivo:";
Console.WriteLine(titulo);
```

Ao passar o mouse sobre a variável título, vemos que é uma string ou nula, mas não será nula, pois estamos alocando diretamente. Essa alocação de um objeto do tipo string é chamada de string literal.

**Explorando métodos de manipulação de strings**  
Podemos criar um objeto de string de outra maneira, embora não seja comum nem recomendado. Poderíamos usar new String e passar o texto, mas isso não é o padrão. O string literal é a maneira natural de alocar memória para objetos do tipo string.

Nos códigos anteriores, já manipulamos strings usando alguns métodos. Destacamos o método split, da classe string, que recebe como argumento o separador e divide uma linha em várias partes, criando um array de strings. Outro método é o trim, que remove espaços em branco do início e do fim da string. Existem variações como trimStart e trimEnd, que removem espaços apenas do início ou do fim, respectivamente.

```csharp
g.TrimStart();
g.TrimEnd();
```

Outro método que já utilizamos é o startsWith, aplicado em uma operação de filtro na coleção de entrada. Ele verifica se o título da música começa com um determinado caractere. Usamos aspas simples para denotar um caractere único, enquanto aspas duplas são usadas para textos completos. O startsWith retorna um valor booleano, verificando se a string começa com o caractere especificado.

```csharp
var musicas = ObterMusicas(stream)
    .Where(m => m.Titulo.StartsWith('T'))
    .Take(50);
```

**Demonstrando a string como um array de caracteres**  
Uma string é, na verdade, um array de caracteres. Sendo uma coleção, pode ser usada com métodos do LINQ. Podemos enumerar uma string. Por exemplo, ao criar uma string chamada título, podemos manipulá-la como uma coleção de caracteres.

```csharp
var titulo = "Músicas do arquivo";
foreach(var letra in titulo) Console.WriteLine(letra);
```

Criei uma string utilizando string literal. Vamos comentar o char de letras, que foi apenas para demonstrar que a string é uma rede de caracteres. A variável se chama string e é do tipo string. Podemos fazer um for em cada var letra no título e imprimir cada letra. Vamos comentar que exibimos músicas para apresentar diretamente a letra. Repare que título é um enumerado de char, e a variável letra é do tipo char. Ela é um enumerado que implementa a interface enumerada para elementos do tipo char. Se executarmos este método, teremos a exibição de cada letra que está na string título. Utilizamos o Console.WriteLine, por isso foi apresentado linha a linha. Repare que o espaço também faz parte da string e está sendo exibido.

**Validando a força de uma senha usando LINQ**
Temos um enumerado, então podemos fazer operações de LINQ a partir de uma string. Vamos fazer um exercício sobre como usar o LINQ em uma string. Imagine que estamos trabalhando com um aplicativo de músicas, onde há um módulo específico para registro de usuários. A pessoa precisará inserir seus dados, como nome, e-mail, nome de usuário e uma senha. Essa senha, em algum momento, será transportada no nosso software. Se for um software web, ela sairá do navegador de um formulário, e isso chegará ao código em C#. Teremos uma string representando essa senha.

Queremos validar se a senha é forte. Temos algumas regras para uma senha forte, que são cinco características. Vamos fazer uma operação de agregação para cada regra, utilizando LINQ. A primeira regra é verificar o total de caracteres, que pode ser feito a partir da propriedade Length da própria string. Poderíamos usar também o Count, que é um método de agregação do LINQ. Guardamos isso no totalDeCaracteres.

```csharp
var senha = "123";
var totalCaracteres = senha.Length;
```

Agora, vamos obter o total de letras maiúsculas. Precisaremos de mais conhecimento aqui. Vamos usar uma operação de agregação, não o Count, mas uma expressão lambda dentro do Count para nos dar uma condição. Para cada char, vamos verificar se é maiúsculo. Para isso, usaremos o método estático Char.IsUpper. Ele nos diz se o caractere está em caixa alta. Vamos fazer uma contagem de todos os caracteres que estão em caixa alta.

```csharp
var totalLetrasMaiusculas = senha.Count(c => char.IsUpper(c));
```

Vamos copiar e colar essa linha e mudar o nome da variável para totalDeLetrasMinusculas. Da mesma forma, existe um IsLower. Já fizemos três regras, mas ainda não verificamos. Vamos escrever as três regras e verificar se existe um número. Vamos adicionar mais uma linha para totalDeNumeros. Mudamos o nome da variável para totalDeNumeros e vamos totalizar. O tipo char também tem um IsDigit, que verifica isso.

```csharp
var totalLetrasMinusculas = senha.Count(c => char.IsLower(c));
var totalNumeros = senha.Count(c => char.IsDigit(c));
```

Por fim, verificamos se possui algum símbolo. Para totalDeSimbolos, consideraremos que não é uma letra nem um dígito. Vamos fazer uma negação usando a exclamação !Char.IsLetterOrDigit. Se não for letra e não for dígito, então é um símbolo, e será totalizado na variável totalDeSimbolos.

```csharp
var totalSimbolos = senha.Count(c => !char.IsLetterOrDigit(c));
```

**Determinando a força da senha**  
Agora, precisamos apresentar uma mensagem para dizer se a senha é forte ou não. Vamos fazer um if que dirá "A senha digitada é forte". Teremos um else que dirá "A senha digitada é fraca". O if conterá todos esses contadores. Se totalDeCaracteres for menor que 8, totalDeLetrasMaiusculas for zero, totalDeLetrasMinusculas for zero, totalDeNumeros for zero ou totalDeSimbolos for zero, qualquer uma dessas condições fará com que o if imprima que a senha é fraca.

```csharp
if (totalCaracteres < 8 ||
    totalLetrasMaiusculas == 0 ||
    totalLetrasMinusculas == 0 ||
    totalNumeros == 0 ||
    totalSimbolos == 0 )
{
    Console.WriteLine("A senha digitada é fraca!");
}
else
{
    Console.WriteLine("A senha digitada é forte!");
}
```

Vamos executar e, de fato, a senha digitada é fraca. Vamos fazer uma mudança na senha. Vamos colocar uma senha forte, como uma letra maiúscula, nosso nome, 123. Quase todas as condições estão sendo atendidas, exceto o símbolo. Temos nove caracteres, então estamos quase lá. Vamos executar novamente e a senha continua sendo fraca. Vamos adicionar um símbolo, como um percentual, e executar novamente. Agora, a senha passou a ser forte, atendendo a todas as regras.

```csharp
var senha = "Daniel123%";
```

**Concluindo o estudo inicial sobre strings**  
Usamos o recurso do LINQ e conhecemos alguns métodos do tipo char que ajudam a validar isso. Fechamos este primeiro estudo sobre strings, apresentando como a alocação é feita através do string literal. Não é recomendado usar new string. Além disso, relembramos alguns métodos que já utilizamos em nosso estudo sobre coleções, como StartsWith, Split, Trim, TrimEnd e TrimStart. Mostramos também que a string é um enumerável de caracteres e usamos LINQ para validar a senha. Nos vemos no próximo estudo sobre strings.

### Aula 5:  Alterando o título de uma música - Vídeo 2

Transcrição  
Vamos avançar no estudo sobre strings. Primeiramente, vamos organizar o código. Vamos criar um método para guardar o código de alteração de senha. Selecionamos o trecho de código da linha 40 até a linha 10, onde está toda a parte do estudo de strings, e movemos para a validação de senha. Não precisamos passar nenhum argumento como entrada. Assim, o código fica disponível para nós. Também deixamos dois códigos que mostram a questão das strings sendo um enumerável de caracteres.

Para começar, vamos definir o método ValidandoSenha que será responsável por essa validação:

```csharp
void ValidandoSenha()
{
}
```

**Implementando a lógica de validação de senha**  
Agora, vamos adicionar a lógica de validação de senha dentro desse método. A senha será considerada forte se atender a certos critérios, como ter pelo menos 8 caracteres, conter letras maiúsculas e minúsculas, números e símbolos.

```csharp
void ValidandoSenha()
{
    var senha = "Daniel123%";
    /*
     Senha será forte se:
     0. possui pelo menos 8 caracteres
     1. possui alguma letra maiúscula
     2. possui alguma letra minúscula
     3. possui algum número
     4. possui algum símbolo
    */
    var totalCaracteres = senha.Length;
    var totalLetrasMaiusculas = senha.Count(c => char.IsUpper(c));
    var totalLetrasMinusculas = senha.Count(c => char.IsLower(c));
    var totalNumeros = senha.Count(c => char.IsDigit(c));
    var totalSimbilos = senha.Count(c => !char.IsLetterOrDigit(c));

    if (totalCaracteres < 8 ||
        totalLetrasMaiusculas == 0 ||
        totalLetrasMinusculas == 0 ||
        totalNumeros == 0 ||
        totalSimbilos == 0)
    {
        Console.WriteLine("A senha digitada é fraca!");
    }
    else
    {
        Console.WriteLine("A senha digitada é forte!");
    }
}
```

**Formatando código no Visual Studio**  
Percebemos que o código para exibir músicas saiu um pouco da formatação. Uma dica rápida: quando queremos formatar rapidamente o arquivo que estamos editando no Visual Studio, podemos pressionar as teclas Ctrl+K+D. Isso formata tudo automaticamente, sem precisar fazer manualmente.

Agora, queremos pegar uma música e alterar o título dela. Nunca fizemos isso antes. Vamos mudar o título de uma música. Para isso, pegamos uma música nesse enumerável, utilizando FirstOrDefault. Não precisamos mais do argumento 50. Vamos chamar essa música de musica.

```csharp
var musica = ObterMusicas(stream)
    .Where(m => m.Titulo.StartsWith('T'))
    .FirstOrDefault();
```

**Usando interpolação de strings**  
Primeiro, exibimos o título da música. Estamos usando interpolação, que é uma característica das strings. Podemos usar o símbolo de cifrão ($) e, a partir disso, o texto da string fica disponível para expressões de interpolação entre chaves.

```csharp
if (musica is not null)
{
    Console.WriteLine($"Título da música: {musica.Titulo}"); // interpolação
}
```

Poderíamos também usar a concatenação tradicional. Por exemplo, poderíamos escrever "Título da música: " e somar com o título da música. A interpolação é uma forma mais moderna de concatenação, lançada nas versões mais atuais do C#. Não lembramos qual versão introduziu a interpolação, mas podemos pesquisar para saber.

**Alterando o título da música e entendendo a imutabilidade**  
Voltando ao nosso problema original, queremos mudar o título de uma música. Para evitar a mensagem do Visual Studio indicando que a variável pode ser nula, fazemos uma validação. Se a variável não for nula, colocamos o código dentro de chaves. Isso impede que o Visual Studio reclame, pois já fizemos a validação.

```csharp
if (musica is not null)
{
    musica.Titulo = musica.Titulo.Replace("The ", ""); // imutabilidade
    Console.WriteLine($"Título da música: {musica.Titulo}"); // interpolação
}
```

Ao executar, percebemos que o título da música continua igual, inalterado. Isso ocorre porque a classe string é imutável. Os métodos que manipulam strings sempre retornam uma nova instância. O método Replace retorna uma nova string, não altera a original. Para mudar o título, precisamos fazer com que musica.Titulo receba o novo objeto criado pelo método Replace. Assim, substituímos o objeto anterior por um novo, resultado da substituição.

**Explorando métodos de strings e imutabilidade**  
Agora, ao executar a aplicação, temos o efeito esperado: o título da música realmente muda de "The Broken Road" para "Broken Road". É importante entender que as strings são imutáveis. Quando alocadas, não mudam mais. O método Replace retorna uma nova string, assim como outros métodos da classe string que retornam strings. Por exemplo, para colocar a música em letras maiúsculas, usamos o método ToUpper. Ele também retorna uma nova string, então precisamos apontar musica.Titulo para esse novo objeto.

```csharp
musica.Titulo = musica.Titulo.ToUpper();
```

Os métodos da classe string que retornam strings sempre entregam um novo objeto, pois são imutáveis.

**Melhorando o método obterMúsicas**  
No nosso código, vamos comentar o método toUpper para que possamos ter uma referência. Já estamos utilizando um método no obterMúsicas, que transforma o CSV em um objeto do tipo música. Podemos melhorar esse método, especialmente agora que entendemos a questão da imutabilidade, o que faz ainda mais sentido.

No método obterMúsicas, na linha 83, temos um código que lida com gêneros. Ele converte um segmento da nossa string de gêneros, que estão separados por vírgulas. Utilizamos o split e, em seguida, fazemos uma projeção usando o método select. Para evitar que os gêneros tenham espaço na frente, usamos o trim. O trim retorna uma string, e sabemos que strings são imutáveis. Portanto, ele cria um novo objeto, descartando o objeto original que começou no select e utilizando um novo objeto. Se tivermos 20 gêneros, teremos 40, pois estamos usando um segundo método que gera uma nova string. Neste caso, isso não afeta nossa performance, mas agora temos consciência do design da classe string e podemos pensar em melhorias.

**Otimizando o uso de strings com StringSplitOptions**  
Podemos melhorar o código utilizando uma sobrecarga do método split, onde passamos um segundo argumento, StringSplitOptions. Com isso, aplicamos o trim diretamente nas entradas do split, eliminando a necessidade de usar o select e o método trim separadamente. Isso torna nosso código mais performático.

```csharp
Generos = partes[3].Split(',', StringSplitOptions.TrimEntries);
```

**Concluindo o estudo sobre imutabilidade de strings**  
Para concluir, entendemos que strings são imutáveis. Um objeto imutável, uma vez alocado, não muda mais até o fim de sua vida útil. No caso das strings, o conteúdo permanece igual. Para garantir essa imutabilidade e ainda assim modificar valores, atribuímos um novo objeto à propriedade desejada, como título ou artista. Os métodos que retornam strings entregam novos objetos.

A Microsoft tornou as strings imutáveis porque são muito frequentes no código e usadas em diversos contextos, como em processamento paralelo. Se as strings fossem mutáveis, não teríamos garantia de que processamentos paralelos não alterariam seu valor. A imutabilidade nos dá segurança e garantia. Além disso, em coleções cuja chave é do tipo string, a imutabilidade garante que o valor da chave não seja alterado por outro código, preservando o elemento da coleção.

A imutabilidade é fundamental para garantir segurança, especialmente em processamento paralelo e na manutenção de chaves de hashing. Vamos continuar nosso estudo na sequência.

### Aula 5: Duração e lançamento formatados - Vídeo 3

Transcrição  
Avançando em nosso estudo, vamos organizar o ambiente primeiro, realizando o trabalho habitual. No topo, temos um código que utilizamos para alterar o título de uma música, o que serviu como base para discutirmos a imutabilidade de strings.

Vamos selecionar todo esse código, da linha 6 até a linha 20, que realiza a alteração do título. Primeiro, ele seleciona uma música e, em seguida, altera o título. Vamos recortar esse trecho e criar um método chamado alterarTitulo. Abriremos e fecharemos as chaves e copiaremos o código para dentro delas. Receberemos como argumento de entrada o StringReader. Pronto, o método está disponível para referência futura.

**Definindo o método AlterandoOTitulo**  
Para começar, vamos definir o método AlterandoOTitulo que irá encapsular a lógica de alteração do título da música:

```csharp
void AlterandoOTitulo()
{
    var musica = ObterMusicas(stream)
    .Where(m => m.Titulo.StartsWith('T'))
    .FirstOrDefault();

    if (musica is not null)
    {
        Console.WriteLine("Título da música: " + musica.Titulo); // concatenação tradicional
        Console.WriteLine($"Título da música: {musica.Titulo}"); // interpolação
        musica.Titulo = musica.Titulo.Replace("The ", ""); // imutabilidade
        musica.Titulo = musica.Titulo.ToUpper();
        Console.WriteLine($"Título da música: {musica.Titulo}"); // interpolação
    }
}
```

**Exibindo músicas e criando o método exibirMusicasEmTabela**  
Outro processo importante na manipulação de texto é a exibição em algum local. Por exemplo, estamos executando o código e exibindo as informações no terminal. Podemos exibir isso em uma página web, em uma aplicação desktop ou em uma aplicação móvel. Esse processo de exibição das informações também requer manipulação de texto.

Vamos criar novamente uma variável musicas, obtendo-a a partir do nosso stream. Selecionaremos 20 músicas e chamaremos a função para exibir essas músicas. Para exemplificar a exibição, ao pressionar F5, as músicas serão exibidas no terminal. A exibição está mostrando as informações, mas poderíamos organizá-las de maneira mais estruturada.

Primeiro, vamos obter as músicas do stream e selecionar apenas 20 delas:

```csharp
var musicas = ObterMusicas(stream)
    .Take(20);
```

Em seguida, chamamos a função para exibir essas músicas:

```csharp
ExibirMusicas(musicas);
```

Recebemos a demanda de exibir as músicas em formato de tabela, com colunas para título, artista, duração e lançamento. Podemos fazer isso utilizando métodos da String. Vamos descer para o método exibirMusicas. Manteremos o método original, mas selecionaremos todo o método novamente, da linha 68 a 79. Vamos copiá-lo e colá-lo logo abaixo.

Está ocorrendo um erro de compilação porque não podemos ter dois métodos com a mesma assinatura. Vamos renomear o método para exibirMusicasEmTabela. Alteraremos o nome no topo para exibirMusicasEmTabela, para não esquecermos depois. Retornando ao método exibirMusicasEmTabela, precisamos primeiro mostrar um cabeçalho com as seguintes colunas: título, artista, duração e lançamento.

**Formatação de Strings e Exibição de Dados**  
Definimos as colunas artista, duração e lançamento para nossa tabela. O console será exibido com o título no topo. Queremos que a exibição em tabela tenha colunas com largura fixa. Para isso, utilizamos o método padLeft, que alinha a string à direita a partir de um tamanho especificado. Se não passarmos outro argumento além do tamanho, ele alinha com espaços. No entanto, queremos usar o padRight com um tamanho de 40 caracteres para a coluna título, 30 para artista, 10 para duração e 15 para lançamento. Caso haja algum erro, faremos a modificação posteriormente.

Vamos definir as colunas com o tamanho apropriado:

```csharp
var colunaTitulo = "Titulo".PadRight(40);
var colunaArtista = "Artista".PadRight(30);
var colunaDuracao = "Duração".PadRight(10);
var colunaLancamento = "Lançada Em".PadRight(15);
```

Podemos imprimir essas colunas diretamente, utilizando interpolação de strings para passar as variáveis. Além disso, imprimiremos uma linha para separar o cabeçalho das linhas das músicas. Essa linha terá um tamanho total de 100 caracteres, composta por sinais de igual repetidos. Utilizaremos console.writeLine para exibir essa linha, que chamaremos de borda, para evitar conflitos com outras variáveis.

```csharp
Console.WriteLine($"{colunaTitulo}{colunaArtista}{colunaDuracao}{colunaLancamento}");
var borda = "".PadRight(100, '=');
Console.WriteLine(borda);
```

Após recebermos as 50 músicas, verificamos que o título, artista, duração e lançamento estão corretos. No entanto, a linha não fez o pad corretamente. Precisamos pegar uma string vazia e fazer um padRight com o caractere igual para o preenchimento. Assim, a linha será impressa corretamente.

O próximo passo é ajustar cada informação da música para que se encaixe nas larguras fixas. A interpolação de strings nos permite definir quantos caracteres cada expressão terá, utilizando um sinal de alinhamento. Por exemplo, para alinhar à direita, usamos um número negativo, como -40 para a coluna título. Testar o software é essencial para garantir que tudo esteja correto.

```csharp
var linha = $"{musica.Titulo,-40}{musica.Artista,-30}{musica.Duracao/60.0,-10:F3}{musica.Lancamento,-15:dd/MM/yyyy}";
```

Além do alinhamento, podemos formatar os valores. A duração, por exemplo, será exibida em minutos ao dividir os segundos por 60. Para exibir valores decimais, representamos 60 como 60.0. Utilizamos a expressão de interpolação com dois pontos para formatar o valor em ponto flutuante com duas casas decimais.

Para formatar a data, não exibiremos as horas, apenas o dia, mês e ano. Usamos m maiúsculo para o mês e y para o ano. A tabela agora exibe as músicas com a formatação desejada, alinhadas à esquerda e com valores formatados.

Para saber quais formatações estão disponíveis, consultamos a documentação da Microsoft. Caso a interpolação não esteja disponível, podemos usar o método estático string.format, passando a chave do índice do argumento e a formatação desejada. Ajustamos o alinhamento e a divisão por 60 para exibir a duração corretamente.

A maioria dos tipos em .NET possui uma formatação básica através do método toString. Podemos sobrescrever esse método para formatar objetos personalizados, como músicas. Assim, formatamos valores e objetos de maneira customizada, utilizando diferentes métodos e técnicas de formatação.

### Aula 5: Comparando strings - Vídeo 4

Transcrição  
Agora estamos exibindo as músicas em formato de tabela, com largura adequada, formatação de números, duração em minutos e data de lançamento. Vamos continuar nosso estudo com strings, abordando um processo bastante comum. Vamos pegar as primeiras 20 músicas de um artista específico. Utilizamos a variável música e música.artista igual a "Coldplay", nosso sempre querido Coldplay. Exibimos as músicas do Coldplay, e o resultado está em tabela.

Para isso, começamos com o seguinte código:

```csharp
var musicas = ObterMusicas(stream)
    .Where(musica => musica.Artista == "Coldplay")
    .Take(20);
```

**Comparando objetos do tipo string**  
O que estamos fazendo aqui é uma comparação entre dois objetos do tipo string: o objeto que está em artista e o objeto gerado. Lembre-se de que uma string literal aloca um novo objeto, portanto, são dois objetos diferentes. Nesse caso, é importante lembrar que já fizemos isso anteriormente quando precisávamos criar um hash set de músicas. Precisamos criar uma condição de igualdade para identificar o que é uma música igual, considerando título e artista como iguais. Para isso, sobrescrevemos os métodos equals e getHashCode. A classe string faz a mesma coisa, permitindo que essa comparação funcione. Ela sobrescreve o método equals e getHashCode para comparar o conteúdo. Mesmo que sejam dois objetos diferentes, música.artista e a string literal "Coldplay" retornarão true devido à sobrescrita do método equals.

Se colocarmos o nome do artista em maiúsculas, será que funcionará? Vamos testar. Ao executar o código, obtemos uma tabela vazia, pois o conteúdo é diferente. "Coldplay" com caracteres diferentes do artista "Coldplay" apenas com "C" maiúsculo.

```csharp
var musicas = ObterMusicas(stream)
    .Where(musica => musica.Artista == "COLDPLAY")
    .Take(20);
```

**Resolvendo diferenças de maiúsculas e minúsculas**  
Já vimos, inclusive, quando validamos uma senha forte, que existe diferença entre caracteres maiúsculos e minúsculos.

Como resolver isso? Queremos que, mesmo escrevendo "Coldplay" com maiúsculas ou minúsculas, todas as músicas do Coldplay sejam exibidas, independentemente de como está escrito na fonte de dados. Para isso, precisamos sair da comparação com == e usar o método equals. Vamos pegar a string literal e colocá-la como argumento.

```csharp
.Where(musica => musica.Artista.Equals("COLDPLAY"))
```

Precisamos adicionar um segundo argumento ao equals para comparar independentemente de a letra ser maiúscula ou minúscula.

```csharp
.Where(musica => musica.Artista.Equals("COLDPLAY", StringComparison.OrdinalIgnoreCase))
```

**Utilizando string comparison**  
O conceito de string comparison (comparação de strings) é importante, especialmente quando utilizamos o ordinal ignore case. O essencial aqui é o ignore case, que permite a comparação de strings sem considerar diferenças entre maiúsculas e minúsculas. Ao executar o código, mesmo que as músicas do Coldplay estejam escritas de forma diferente, elas serão reconhecidas corretamente.

A comparação entre strings é frequente, e muitas vezes não sabemos se uma string está em maiúsculas ou minúsculas. Por isso, utilizamos bastante o string comparison. Já escrevemos muito código onde, por exemplo, usamos musica com M para ser mais rápido, e artista.toUpper() igual a "Coldplay".

```csharp
.Where(m => m.Artista.ToUpper() == "COLDPLAY")
```

**Considerando a imutabilidade das strings**  
Isso funciona, mas é importante lembrar da imutabilidade das strings. Todos os métodos que retornam uma string criam um novo objeto. Já fizemos uma mudança no trim e no split para evitar a projeção do link usando o trim, pois um novo objeto estava sendo criado. Portanto, esse código é menos performático, pois aloca mais objetos em memória. Na maioria das vezes, isso não faz diferença em coleções pequenas, mas é importante estar ciente e usar as melhores práticas.

Vamos comentar e trocar o código para mostrar que a comparação pode ser feita de forma mais elegante, garantindo que a string será comparada sem considerar maiúsculas e minúsculas. O tipo string comparison não é usado apenas no equals, mas em vários outros métodos.

```csharp
// métodos que utilizam StringComparison
"Coldplay".Equals("coldplay", StringComparison.OrdinalIgnoreCase);
"Coldplay".StartsWith("cold", StringComparison.OrdinalIgnoreCase);
"Coldplay".EndsWith("coldplay", StringComparison.OrdinalIgnoreCase);
"Coldplay".IndexOf("coldplay", StringComparison.OrdinalIgnoreCase);
"Coldplay".Contains("OLD", StringComparison.OrdinalIgnoreCase);
"Coldplay".Replace("cold", "warm", StringComparison.OrdinalIgnoreCase);
```

**Recomendando o uso de string comparison**  
Recomendamos o uso do string comparison para facilitar o desenvolvimento e evitar erros inesperados. A classe string sobrescreve o equals e o getHashCode para comparação de conteúdo, e a comparação sem considerar maiúsculas e minúsculas é feita com string comparison e o valor ordinal ignore case. Vamos continuar nosso estudo sobre strings em seguida.

### Aula 5: Comparação de títulos de vídeos na plataforma Screen Match - Exercício

A Screen Match, uma plataforma de streaming de vídeos similar ao YouTube, está enfrentando um desafio com a busca de vídeos. A equipe de desenvolvimento que você faz parte está trabalhando em um sistema de busca que precisa ser capaz de encontrar vídeos independentemente de como as pessoas usuárias digitam os títulos. Por exemplo, se uma pessoa usuária procurar por "Aventuras no Espaço" ou "aventuras no espaço", o sistema deve retornar o mesmo conjunto de vídeos.

Considerando a importância de uma busca eficiente e precisa, qual abordagem você implementaria para permitir a comparação de títulos de vídeos sem considerar diferenças entre letras maiúsculas e minúsculas?

Resposta:  
Implementar a comparação de strings utilizando o método equals com o argumento StringComparison.OrdinalIgnoreCase.

> Correta, pois essa abordagem permite que o sistema de busca compare os títulos dos vídeos sem considerar diferenças entre letras maiúsculas e minúsculas, garantindo que "Aventuras no Espaço" e "aventuras no espaço" sejam tratados como equivalentes, melhorando a experiência da pessoa usuária.

### Aula 5: Como o .NET trata strings - Vídeo 5

Transcrição  
Para continuarmos nosso estudo sobre dados textuais e manipulação de dados textuais com a classe String, vamos organizar o código. A parte de comparação será separada em um método para que possamos ter como referência. Vamos criar esse método chamado ComparandoStrings, passando o StreamReader como argumento.

Primeiro, definimos o método vazio:

```csharp
void ComparandoStrings(StreamReader stream)
{

}
```

Agora, vamos transferir o código da linha 7 até a linha 20, que é onde realizamos a comparação entre strings, para dentro do método ComparandoStrings.

```csharp
void ComparandoStrings(StreamReader stream)
{
    var musicas = ObterMusicas(stream)
        .Where(musica => musica.Artista.Equals("COLDPLAY", StringComparison.OrdinalIgnoreCase))
        //.Where(m => m.Artista.ToUpper() == "COLDPLAY")
        .Take(20);

    // métodos que utilizam StringComparison
    "Coldplay".Equals("coldplay", StringComparison.OrdinalIgnoreCase);
    "Coldplay".StartsWith("cold", StringComparison.OrdinalIgnoreCase);
    "Coldplay".EndsWith("coldplay", StringComparison.OrdinalIgnoreCase);
    "Coldplay".IndexOf("coldplay", StringComparison.OrdinalIgnoreCase);
    "Coldplay".Contains("OLD", StringComparison.OrdinalIgnoreCase);
    "Coldplay".Replace("cold", "warm", StringComparison.OrdinalIgnoreCase);

    ExibirMusicasEmTabela(musicas);
}
```

**Explorando o comportamento de strings no .NET**  
Agora, precisamos fazer uma pequena alteração. Vamos apagar a linha 1, que está completamente inútil. Provavelmente, foi um erro cometido durante os testes, resultando naquele using desnecessário.

Precisamos nos desviar um pouco da discussão sobre músicas e playlists para abordar um assunto sobre strings: entender um pouco os bastidores de como o .NET trabalha com strings. Considerando que strings são dados muito frequentes e um recurso amplamente utilizado em programas e aplicações, o .NET tem um tratamento especial na alocação de objetos do tipo string.

Para iniciar nosso estudo, vamos criar duas variáveis do tipo string: var artista1, que chamaremos de "Coldplay". Imagino que já estejamos cansados de ouvir Coldplay.

```csharp
var artista1 = "Coldplay";
```

Vamos criar uma segunda variável com o conteúdo codeplay. Vamos imprimir no console o resultado da igualdade entre essas duas variáveis. Perguntamos: o que será exibido? True ou False?

```csharp
var artista2 = "Coldplay";
Console.WriteLine(artista1 == artista2);
```

Também vamos exibir um método que verifica se essas duas referências são iguais, ou seja, se as duas variáveis estão apontando para a mesma área de memória. Existe um método chamado ReferenceEquals, no qual passamos como argumentos as duas variáveis artista1 e artista2. Perguntamos novamente: o que aparecerá aqui?

```csharp
Console.WriteLine(ReferenceEquals(artista1, artista2));
```

**Compreendendo o string pool e o interning**  
Já discutimos a comparação de strings, que sobrescreve os métodos equals e getHashCode. Portanto, ele comparará o conteúdo. Como o conteúdo dessas duas variáveis é igual, imaginamos que o resultado será true. Agora, temos duas variáveis, artista1 e artista2, nas quais estamos alocando objetos do tipo string. Como são objetos diferentes, esperamos que as referências também sejam diferentes, resultando em false para a comparação de referências.

Ao executar a aplicação, observamos que a comparação por conteúdo retornou true, como esperado. No entanto, a comparação por referências, que esperávamos ser false, retornou true. Isso ocorre devido a um comportamento específico do runtime do .NET para tratar strings. Como strings são muito frequentes, o .NET reserva uma área de memória específica para gerenciá-las, chamada de string pool.

O string pool otimiza o uso de memória verificando se o conteúdo já existe. Se o conteúdo for o mesmo, ele reutiliza a referência existente no pool de strings. No caso do artista2, como o conteúdo é o mesmo, ele utiliza a referência do pool de strings, economizando memória. Se tivéssemos várias strings literais, o .NET usaria o mesmo objeto para todas, pois o conteúdo é o mesmo.

**Explorando o uso do método String.Intern**  
É importante destacar que o string pool economiza áreas de memória. O processo de colocar uma string no pool é chamado de interning. Quando criamos uma string literal, como artista1, ela é internada no pool. Ao criar uma segunda variável com o mesmo conteúdo, o .NET verifica se já está no pool e reutiliza a referência, sem fazer interning novamente.

Se criarmos uma nova string usando new String("Coldplay"), mesmo com o mesmo conteúdo, não será utilizada a mesma referência, pois o interning só ocorre com strings literais. Por isso, não é recomendado usar new String, pois impede o .NET de otimizar o uso do pool de strings.

```csharp
var artista3 = new string("Coldplay");
Console.WriteLine(ReferenceEquals(artista1, artista3));
```

Se removermos o new String, o .NET usará a mesma referência. O interning só é feito com strings literais. Nenhum outro método fará interning. Por exemplo, se criarmos uma variável artista4 com codeplay, ela fará string interning, mas será uma referência diferente de artista1.

```csharp
var artista4 = "COLDPLAY";
```

Se tentarmos usar ReferenceEquals entre artista1 e artista4, o resultado será false, pois são referências diferentes. Se criarmos uma variável artista5 a partir de artista1 com ToUpper, não haverá interning, pois o interning só é utilizado com strings literais. Nesse caso, um novo objeto será gerado e armazenado na área de memória comum de objetos, chamada de heap.

```csharp
var artista5 = artista1.ToUpper();
Console.WriteLine(ReferenceEquals(artista1, artista4));
```

Se quisermos usar o processo de interning, podemos utilizar o método estático String.Intern. Quando usamos String.Intern, ele verifica o string pool e, se o conteúdo já existir, retorna a referência existente. Assim, String.Intern retorna uma string a partir do pool.

```csharp
var artista5 = string.Intern(artista1.ToUpper());
Console.WriteLine(ReferenceEquals(artista4, artista5));
```

**Concluindo o estudo sobre strings no .NET**  
Ao executar novamente, a comparação entre artista5 e artista4 retorna true, pois estão usando a mesma referência, graças ao método Intern da classe string. É importante entender que string é uma classe especial no .NET, desenvolvida de forma especial devido à sua frequência de uso. Por isso, estamos dedicando tempo para estudar a manipulação de dados com strings.

Essas duas características são fundamentais ao escrever código: a imutabilidade de uma string e o processo de interning em uma área de memória reservada chamada string pool. Vamos continuar nossa sequência de estudos sobre strings em seguida.

### Aula 5: Otimizando o uso de strings no Bytebank

A equipe de desenvolvimento do Bytebank, um banco digital que oferece serviços bancários online, está trabalhando em uma nova funcionalidade para o aplicativo que envolve a manipulação intensiva de strings, como nomes de clientes e descrições de transações. Durante uma revisão de código, foi observado que várias strings literais idênticas estão sendo criadas em diferentes partes do sistema. A equipe está preocupada com o impacto disso na performance e no uso de memória do aplicativo.

Qual das alternativas abaixo melhor explica a importância do string pool do .NET nesse contexto e quais práticas são recomendadas para otimizar o uso de strings no Bytebank?

Resposta:  
O string pool do .NET armazena strings literais de forma eficiente, reutilizando referências existentes para economizar memória. Recomenda-se usar strings literais e métodos como String.Intern para evitar a criação desnecessária de novas instâncias.

> Correta, pois o string pool do .NET ajuda a otimizar o uso de memória ao reutilizar strings literais já existentes, e o uso de String.Intern garante que strings repetidas sejam armazenadas eficientemente.

### Aula 5:  Validando a obtenção do CSV - Vídeo 6

Transcrição  
Agradecemos pela licença poética concedida para abordar um assunto fora do contexto musical. Acabamos utilizando exemplos de músicas e artistas, mas nos afastamos um pouco do tema de playlists, músicas e enumeráveis. Após essa licença poética, vamos continuar nosso estudo e agora falaremos sobre validação, especificamente a validação de strings. Antes disso, precisamos organizar nosso ambiente, criando um método para separar o código. Vamos abrir e fechar chaves, copiar o código da linha 15 para a linha 4, onde estamos estudando interning. Feito isso, podemos prosseguir.

Para começar, vamos criar o método Interning que será utilizado para demonstrar o conceito de interning de strings:

```csharp
void Interning()
{
}
```

**Demonstrando o conceito de interning de strings**  
Agora, vamos adicionar alguns exemplos de interning de strings. Isso nos ajudará a entender como o .NET gerencia strings de forma eficiente:

```csharp
void Interning()
{
    var artista1 = "Coldplay"; // interning - string literal
    var artista2 = "Coldplay";
    var artista3 = new string("Coldplay"); // não faz interning
    var artista4 = "COLDPLAY";
    var artista5 = string.Intern(artista1.ToUpper()); // HEAP x

    Console.WriteLine(artista1 == artista2); // True
    Console.WriteLine(ReferenceEquals(artista1, artista3)); //True - pool de strings
    Console.WriteLine(ReferenceEquals(artista1, artista4));
    Console.WriteLine(ReferenceEquals(artista4, artista5));
}
```

**Introduzindo a necessidade de validação de strings**  
Como vamos validar? Mencionamos anteriormente que, no futuro, validaríamos os dados ao criar uma música. Atualmente, estamos obtendo o arquivo CSV e transferindo para uma coleção de músicas, mas essa obtenção está sendo feita de forma frágil e vulnerável. Se houver algum problema nas linhas do CSV, podemos enfrentar erros, pois não realizamos nenhum tipo de validação. É isso que queremos abordar agora.

Antes disso, vamos inserir um código para realizar testes. Criaremos uma variável chamada músicas, obteremos as músicas a partir do nosso stream, selecionaremos as primeiras 20 e as exibiremos em formato de tabela:

```csharp
var musicas = ObterMusicas(stream)
    .Take(20);

ExibirMusicasEmTabela(musicas);
```

Após pressionar F5, verificamos se tudo está funcionando corretamente. Sim, está tudo em ordem, estamos imprimindo as 50 primeiras músicas em formato de tabela.

**Navegando no código e analisando a leitura de dados**  
A validação de uma string, no caso do objeto música, precisa ocorrer no método obter músicas. Às vezes, fazemos as coisas tão rapidamente que esquecemos de mencionar detalhes importantes, então vamos voltar ao início. No Visual Studio, há uma maneira de navegar rapidamente pelo código, independentemente de estarmos em vários arquivos. No nosso caso, estamos no mesmo arquivo, mas podemos ter vários abertos. Para navegar até a implementação ou declaração de um método ou classe, seguramos a tecla CTRL no teclado (no Windows; no Mac, não sabemos qual tecla usar), passamos o mouse sobre o local desejado, e ele se transforma em um link, como em um navegador. A mãozinha aparece, e ao clicar, navegamos diretamente para a declaração do método. Essa dica já foi utilizada algumas vezes, mas ainda não havia sido mencionada.

Vamos começar analisando o código. Primeiramente, estamos utilizando o StreamReader para ler uma linha. Se a linha não for nula, transformamos essa linha em um array de strings e armazenamos na variável parts. Em seguida, atribuímos a primeira parte ao título, a segunda ao artista, e convertendo a terceira parte em uma duração. Caso haja algum erro, abrimos um arquivo de músicas e inserimos a primeira linha com duração 399, podendo ser qualquer valor, até mesmo vazio. Se tentarmos executar esse código agora, ocorrerá um erro, pois estamos tentando exibir a primeira linha com um erro já presente. O erro ocorre porque a string de entrada "B" não está no formato correto ao tentarmos convertê-la para inteiro.

**Implementando a conversão segura de strings para inteiros**  
Para evitar esse problema, precisamos converter uma string em um inteiro de forma segura. Vamos criar uma variável chamada duração. O tipo de destino, no caso int, possui um método chamado parse. Os métodos parse de todos os tipos disponíveis no .NET realizam a conversão de uma string para o tipo de destino. Por exemplo, int.parse converte uma string em um inteiro. O argumento de entrada do método parse é a string que desejamos converter. Esse processo de parseamento é o oposto da formatação, onde partimos de um dado de origem, como um inteiro ou dateTime, e o convertemos em uma string. No parse, começamos com uma string como origem e a entregamos em um tipo de destino, como int ou dateTime.

No entanto, o método parse também pode gerar erros. Para contornar isso, utilizamos o método tryParse, que retorna um valor booleano indicando se a conversão foi bem-sucedida. Se a conversão for bem-sucedida, ele retorna true; caso contrário, retorna false. Além disso, se a conversão for bem-sucedida, ele também retorna o objeto convertido. Para isso, utilizamos a sintaxe out, criando uma variável do tipo inteiro chamada duração. Podemos inicializar essa variável com 0 e, em vez de especificar o tipo inteiro, utilizamos out para indicar a saída. Dessa forma, podemos usar o valor na variável duração que foi declarada:

```csharp
int duracao = 0;
bool sucesso = int.TryParse(partes[2], out duracao);
```

Essas duas construções são úteis, e utilizaremos bastante o método tryParse ao validar valores textuais para conversão em um tipo de destino. Se a conversão falhar, a duração será 0, mas podemos definir uma duração padrão, como 350. Assim, a variável duração começará com 350, e se a conversão for bem-sucedida, o valor convertido será atribuído a ela. Dessa forma, conseguimos executar o programa sem erros. No entanto, a duração está sendo definida como 0, pois a variável foi inicializada com esse valor. Não utilizaremos essa construção, pois resulta em um código extenso.

**Utilizando expressões condicionais para conversão**  
Vamos fazer uma segunda alteração. Tentaremos converter diretamente no código, utilizando uma expressão condicional com um operador ternário. Se a expressão booleana for avaliada como true, o segmento correspondente será executado. Se o tryParse for bem-sucedido, utilizamos a variável duração; caso contrário, utilizamos o valor padrão 350:

```csharp
Duracao = int.TryParse(partes[2], out int duracao) ? duracao : 350,
```

Se houver um erro, removemos a declaração anterior da variável. Essa construção é semelhante a um if. Se int.tryParse for true, o código correspondente será executado; caso contrário, o outro segmento será executado. Dessa forma, ao executar o código, esperamos que ele utilize o valor 350.

**Validando e parseando DateTime**  
Realizamos a primeira validação e compreendemos o processo de parse. Agora, queremos fazer o parse do dateTime. Se o dateTime tiver uma formatação inadequada, podemos aplicar o mesmo procedimento. Utilizamos dateTime.tryParse na parte número 4, que é o quinto segmento, e armazenamos o resultado em uma variável data. Podemos usar var nesse caso. Se a conversão for bem-sucedida, utilizamos a data; caso contrário, criamos um dateTime com um valor qualquer, como a data atual (dateTime.now ou dateTime.today):

```csharp
Lancamento = DateTime.TryParse(partes[4], out var data) ? data : DateTime.Today
```

Executamos e validamos o dateTime. Não havia erros para dateTime, mas podemos introduzir um erro para verificar se ele utilizará a data atual.

**Verificando o tamanho do array e validando strings**  
Outra verificação que podemos fazer é se temos cinco segmentos no array obtido pelo método split. Utilizamos um if para verificar se parts.length é igual a 5. Se for, realizamos a conversão e retornamos a música. Caso contrário, pulamos para a próxima linha e continuamos a conversão do CSV:

```csharp
if (partes.Length == 5)
{
    var musica = new Musica
    {
        Titulo = partes[0],
        Artista = partes[1],
        Duracao = int.TryParse(partes[2], out int duracao) ? duracao : 350,
        Generos = partes[3].Split(',', StringSplitOptions.TrimEntries),
        Lancamento = DateTime.TryParse(partes[4], out var data) ? data : DateTime.Today
    };
    yield return musica;
}
```

**Utilizando isNullOrWhitespace para validação de strings**  
Para finalizar, introduzimos mais um método da classe String. Suponha que o título ou o artista estejam vazios. Podemos tratar isso utilizando o método estático isNullOrWhitespace. Esse método verifica três condições: se a string está nula, vazia ou composta apenas por espaços em branco. Se qualquer uma dessas condições for verdadeira, ele retorna true. O método isNullOrEmpty verifica apenas se a string está vazia ou nula, não considerando espaços em branco. Portanto, utilizamos isNullOrWhitespace, que é mais completo:

```csharp
Titulo = string.IsNullOrWhiteSpace(partes[0]) ? "Título não encontrado" : partes[0],
Artista = string.IsNullOrWhiteSpace(partes[1]) ? "Artista não encontrado" : partes[1],
```

Se a parte zero atender a essas condições, utilizamos um valor padrão, como "Título não encontrado". Caso contrário, utilizamos o elemento zero do array. O mesmo se aplica ao artista. Se string.isNullOrWhitespace retornar true, utilizamos "Artista não encontrado". Caso contrário, utilizamos a parte um do array. Ao executar o código, percebemos que, quando o artista estava nulo, ele foi substituído por "Artista não encontrado", e quando o título estava cheio de espaços, foi substituído por "Título não encontrado". Poderíamos adicionar marcadores para tornar a visualização mais clara.

Embora isNullOrWhitespace não faça parte do processo de parsing, ele é relevante para garantir que uma string não esteja completamente vazia. O processo de parsing é compreendido ao pegarmos uma string maior, uma linha, e a convertermos em um tipo específico, como música. Utilizamos todo esse código para fazer o parsing de uma string em música, a partir de uma estratégia de CSV. Os métodos tryParse e parse são usados para o padrão de parsing, onde uma string de entrada é convertida em um tipo de destino. Além disso, validamos todo o CSV, verificando o tamanho do array e utilizando o método estático isNullOrWhitespace para garantir que uma string não esteja vazia.

### Aula 5: Para saber mais: string como coleção de caracteres

**A Natureza Enumerável das Strings**  
No .NET, uma string é mais do que apenas uma sequência de caracteres. Ela é uma instância de uma classe imutável que, internamente, armazena cada caractere em uma coleção. Essa característica permite que possamos iterar sobre seus elementos individualmente, exatamente como faríamos com qualquer outro tipo que implemente a interface IEnumerable. Essa propriedade abre caminho para a aplicação de métodos do LINQ diretamente na string, facilitando transformações e filtragens de forma concisa.

**Iterando e Manipulando com LINQ**  
Uma das vantagens de considerar a string como uma coleção de caracteres é a possibilidade de utilizar o poder do LINQ para processar os dados textuais. Por exemplo, imagine que precisamos contar quantas letras maiúsculas uma string possui. Podemos aplicar o método Count com uma expressão lambda para verificar cada caractere:

```csharp
string texto = "Hello World";
int totalMaiusculas = texto.Count(c => char.IsUpper(c));
Console.WriteLine($"Total de letras maiúsculas: {totalMaiusculas}");
```

Esse exemplo ilustra como a string, por ser enumerável, pode ser tratada como qualquer outra coleção. Além disso, iterar diretamente sobre a string utilizando um loop foreach torna o acesso a cada caractere intuitivo e eficiente:

```csharp
foreach (char letra in texto) {
    Console.WriteLine(letra);
}
```

**Considerações sobre Benefícios e Cuidados**  
A abordagem de tratar a string como uma coleção de caracteres oferece flexibilidade, permitindo aplicar diversos métodos de consulta e transformação providos pelo LINQ. Essa característica é útil, por exemplo, na validação de padrões, contagem de tipos de caracteres e até na construção de novas strings com base em condições específicas.

No entanto, é importante lembrar que, por ser uma estrutura imutável, qualquer modificação que pareça alterar uma string na verdade gera uma nova instância. Assim, operações pesadas de concatenação repetida podem impactar a performance. Nessas situações, alternativas como o StringBuilder podem ser mais adequadas para a manipulação eficiente de grandes volumes de dados textuais.

A compreensão de que uma string se comporta como uma coleção de caracteres é crucial para explorar todo o potencial das operações com LINQ e, consequentemente, para escrever códigos mais limpos e expressivos em C#.

### Aula 5: Faça como eu fiz: manipulação de strings

Nesta aula, exploramos a manipulação e formatação de dados textuais com o .NET, utilizando operações com strings e validações no processamento de arquivos CSV.

Agora é a sua vez de aplicar os conceitos estudados. Para isso:

- Organize o ambiente fechando o projeto anterior e abrindo o projeto de strings no Visual Studio.
- Abra e limpe o arquivo program.cs do novo projeto de strings.
- Cole o código de manipulação de músicas extraído do CSV, incluindo data de lançamento.
- Execute o programa para verificar a exibição correta das músicas.
- Utilize string literal para alocar objetos do tipo string, evitando o uso de new string.
- Empregue métodos como Split e Trim para separar e limpar dados do CSV.
- Aplique operações de agregação (Count) para contar caracteres em strings.
- Implemente validação de senha forte usando métodos como isUpper, isLower e isDigit.
- Teste a validação alterando a senha para verificar regras de formatação e símbolos.
- Extraia o código de alteração de título de música para um método dedicado.
- Refaça a exibição das músicas em formato de tabela utilizando PadLeft e PadRight.
- Use interpolação de strings para alinhar colunas e organizar dados na tabela.
- Formate valores numéricos e datas (ex.: duração em minutos e data no formato dd/MM/yyyy).
- Crie cabeçalho e linha separadora para a tabela de exibição das músicas.
- Compare strings utilizando Equals com StringComparison para ignorar diferenças de case.
- Separe o código de comparação de strings em um método específico.
- Demonstre o conceito de imutabilidade e o funcionamento do string pool (interning).
- Valide dados do CSV com TryParse para conversão segura de inteiros e DateTime.
- Utilize isNullOrWhitespace para substituir valores vazios por conteúdos padrão.

### Aula 5: O que aprendemos?

Nesta aula, aprendemos:

- Que strings são imutáveis em C# e modificações geram novas instâncias.
- A utilizar métodos como Replace, ToUpper, StartsWith e EndsWith para manipulação eficiente de strings.
- A importância do string pool e interning para reutilização de referências de strings literais.
- Como a imutabilidade de strings impacta a performance e garante segurança no processamento paralelo.
- A formatar strings e valores usando interpolação, PadLeft, PadRight e string.Format.
- A validar e converter strings com int.TryParse e string.IsNullOrWhiteSpace.
- A comparar strings considerando maiúsculas e minúsculas com StringComparison.OrdinalIgnoreCase.
- A encapsular funcionalidades em métodos dedicados para organização e clareza do código.

## Aula 6: Expressões Regulares

### Aula 6: Projeto da aula anterior

Na aula anterior, voltamos o foco para dados textuais: exploramos as características das strings, sua imutabilidade, boas práticas de uso e recursos como Replace, Split, interpolação, StringBuilder e TryParse. Também entendemos como o .NET otimiza o uso de strings na memória. Para conferir o projeto e os exemplos implementados, acesse o [repositório do curso no GitHub.](https://github.com/alura-cursos/data-manipulation-with-csharp/tree/main/05-Strings)

### Aula 6: Duração com novo formato - Vídeo 1

Transcrição  
Vamos avançar para outro tópico no estudo de manipulação de dados. Para isso, realizaremos a tarefa rotineira de organizar o ambiente no Visual Studio. Como estamos mudando de tópico, também alteraremos o projeto. Vamos agora para o projeto número 6. Fecharemos a aba do Program.cs e, na lista suspensa de projetos que serão executados, escolheremos o número 6. Estamos quase finalizando.

No gerenciador de soluções, abriremos o Program.cs relativo a este projeto. Já existe um código pronto, que inclui uma parte que já escrevemos desde a aula sobre string. Temos aqui a exibição das músicas em tabela. Vamos executar o código pressionando F5, e a execução aparecerá no terminal. Pegamos as 20 primeiras músicas em tabela. Algo que chama a atenção é que a duração está sempre igual, refletindo a duração padrão que definimos na validação, onde capturamos a duração.

**Analisando o problema de parsing de duração**  
Para começar, vamos abrir o arquivo de músicas do projeto 6. O formato da duração agora é minutos:segundos. A maneira que utilizávamos para capturar e fazer o parsing da duração não está mais funcionando. Se formos em obter músicas, usando o ctrl-clique, veremos que a duração está tentando fazer o parsing desse valor. O terceiro elemento do array, gerado a partir do método split, está retornando falso, então sempre pega 350, que é o valor padrão que consideramos para a duração de uma música. Precisamos fazer uma mudança.

Para isso, vamos começar carregando o arquivo de músicas e exibindo as músicas em tabela:

```csharp
using var arquivo = new FileStream("musicas.csv", FileMode.Open, FileAccess.Read);
using var stream = new StreamReader(arquivo);

var musicas = ObterMusicas(stream)
    .Take(20);

ExibirMusicasEmTabela(musicas);
```

Se temos o formato 0:00, poderíamos fazer um split com dois pontos como separador, pegando a primeira parte como minutos e a segunda como segundos. No entanto, queremos mostrar outro recurso para esse tipo de cenário, onde encontramos um padrão em um texto. Embora possamos resolver via split, existem cenários mais complexos que exigiriam vários ifs e validações, tornando o código menos legível. Talvez não conseguíssemos uma solução usando split ou outro método da classe string.

**Introduzindo expressões regulares**  
O recurso que utilizaremos para encontrar padrões em um texto são as expressões regulares. A ideia é identificar expressões específicas que ocorrem regularmente em um texto. No arquivo musicas.cs, temos um padrão claro: número, dois pontos, outro número. Vamos tentar encontrar esse padrão, não no texto como um todo, mas em cada linha especificamente.

Para não nos comprometermos ainda com a solução, copiaremos a primeira linha e a levaremos para o início da execução para realizar alguns testes. Após explicar tudo e entender o processo, aplicaremos a solução que realmente captura a duração das músicas. Criaremos uma variável chamada linha no início da execução do programa, com um string literal contendo a linha completa:

```csharp
var linha = "The Broken Road;Rolling Stones;6:39;Rock, Blues Rock;13/09/1974";
```

Comentaremos a parte que captura e exibe as músicas para realizar os testes:

```csharp
//var musicas = ObterMusicas(stream)
//    .Take(20);

//ExibirMusicasEmTabela(musicas);
```

**Utilizando a classe Regex para capturar padrões**  
Para capturar um padrão específico em uma string, utilizaremos a classe Regex de expressões regulares. Esta classe possui um método que nos entrega um objeto para identificar se houve um match, ou seja, se o padrão foi encontrado no texto de entrada. O método Match retorna um objeto do tipo match, e o argumento de entrada é o texto que queremos analisar.

Primeiro, precisamos importar o namespace necessário para trabalhar com expressões regulares:

```csharp
using System.Text.RegularExpressions;
```

Para iniciar, precisamos definir o texto que desejamos procurar, que neste caso está armazenado na variável linha. Em seguida, determinamos o padrão que queremos encontrar dentro desse texto. O padrão utiliza a sintaxe de expressões regulares, que é específica para representar essas expressões. Vamos criar a expressão regular para encontrar o padrão de duração:

```csharp
var match = Regex.Match(linha, @"\d:\d\d");
```

Temos aqui o primeiro padrão que escrevemos em expressões regulares. Vamos capturar o objeto gerado pelo método Match e realizar algumas verificações. O objeto na variável match possui uma propriedade chamada Success, que indica se o padrão foi encontrado. Se encontrado, indicaremos "Duração Encontrada" e, melhor ainda, já exibiremos o valor, pois o objeto match possui uma propriedade chamada Value. Caso contrário, escreveremos "Duração Não Encontrada":

```csharp
if (match.Success)
{
    Console.WriteLine($"Duração encontrada! {match.Value}");
}
else
{
    Console.WriteLine("Duração não encontrada!");
}
```

**Testando e validando o uso de expressões regulares**  
Vamos executar esse código, que serve para testar e aprender sobre expressões regulares. Ao pressionar F5 ou clicar no triângulo verde, veremos que ele encontrou o padrão no texto, na linha especificada. Se houver um dígito seguido por dois pontos e depois dois dígitos, ele captura esse padrão, como ocorreu.

Expressões regulares nos conferem a capacidade de encontrar padrões específicos dentro de strings, que podem ser bastante complexos. Não conseguimos escrever código usando apenas if e outros métodos padrão de strings para isso. Este é um padrão relativamente simples, mas utilizaremos expressões regulares para encontrar padrões nos textos. A classe Regex é a classe de entrada para trabalhar com expressões regulares. O método Match é utilizado para buscar um padrão, que segue uma sintaxe específica. Neste caso, a sintaxe é para encontrar um dígito seguido por dois pontos e depois dois dígitos. Além disso, o método Match retorna um objeto com duas propriedades que estamos utilizando: um booleano indicando se o padrão foi encontrado e uma propriedade Value, que entrega uma string com o valor encontrado.

Em seguida, continuaremos nosso estudo sobre expressões regulares.

### Aula 6: Sincronização de contatos com padrões de data - Exercício

Na Indexa, uma plataforma que organiza e gerencia contatos pessoais e profissionais de forma inteligente, a equipe de desenvolvimento está enfrentando um problema com a sincronização automática de contatos. Os dados de aniversário dos contatos foram alterados para um novo formato "ano/mês/dia". A empresa contratou você para garantir que o sistema de busca avançada consiga identificar e processar corretamente essas novas entradas de data.

Qual abordagem utilizando expressões regulares você adotaria para resolver esse problema?

Resposta:  
Criar uma expressão regular @"\d{4}/\d{2}/\d{2}" para capturar o padrão "ano/mês/dia", utilizando a classe RegEx e o método match para verificar a presença do padrão nos dados de entrada. A propriedade success do objeto match indicará se a data foi identificada corretamente.

> Correta, pois essa expressão regular é projetada especificamente para capturar o formato "ano/mês/dia", garantindo que o sistema de busca avançada possa identificar e processar as novas entradas de data de forma eficaz.

### Aula 6: Capturando partes do valor encontrado - Vídeo 2

Transcrição  
Já adquirimos mais conhecimento sobre expressões regulares para encontrar padrões em nosso texto. No entanto, ainda não estamos utilizando esses valores. Precisamos capturar a parte que está antes dos pontos e a parte que está depois dos pontos. O objeto match possui uma propriedade chamada groups, que é uma coleção de grupos. Como é uma coleção, ela é enumerável, e podemos iterar sobre ela sem erros.

Para começar, vamos iterar sobre os grupos encontrados na expressão regular. Podemos fazer isso com o seguinte código:

```csharp
foreach(var group in match.Groups)
{
    Console.WriteLine($"Grupo: {group}");
}
```

**Enumerando e capturando grupos**  
Ao enumerar esses grupos, podemos mostrar o que há dentro dessa propriedade. Se encontrarmos o padrão, ele irá primeiro enumerar o que está dentro de groups. Ao executar o código, percebemos que havia apenas um grupo, um elemento desse array, que era justamente o valor impresso em seguida.

Para gerar mais grupos, podemos agrupar subpartes da expressão regular utilizando parênteses. No primeiro elemento que queremos capturar, colocamos parênteses, e no segundo elemento também. Vamos definir a expressão regular para capturar os minutos e segundos:

```csharp
var match = Regex.Match(linha, @"(\d):(\d\d)");
```

Após salvar e executar o código, notamos que agora temos mais dois elementos na coleção de grupos: o primeiro elemento representa os minutos e o segundo, os segundos.

**Convertendo e calculando a duração**
Com isso, conseguimos capturar os minutos e segundos a partir das propriedades dos elementos da coleção de grupos. Como sabemos que o padrão foi encontrado e que os grupos foram definidos na sintaxe, podemos converter diretamente para inteiro, utilizando int.Parse. Vamos capturar os minutos e segundos como inteiros:

```csharp
var minutos = int.Parse(match.Groups[1].Value);
var segundos = int.Parse(match.Groups[2].Value);
```

Para representar a duração encontrada, multiplicamos os minutos por 60 e somamos com os segundos. Essa é a duração que queremos guardar no objeto músicas. Vamos imprimir a duração encontrada:

```csharp
Console.WriteLine($"Duração encontrada: {(minutos * 60) + segundos}");
```

Ao executar, verificamos que a duração encontrada era 399, que corresponde à duração da primeira música.

**Ajustando a expressão regular para diferentes durações**  
Aprendemos sobre grupos, uma maneira de agrupar partes do padrão, utilizando a coleção de grupos no objeto match. A partir daí, conseguimos capturar essas partes específicas. Vamos aplicar esse código à duração, mas há um detalhe a mais: se tivermos uma música muito longa, como 12 minutos, teremos dois dígitos. Para capturar corretamente, ajustamos a expressão regular:

```csharp
var match = Regex.Match(linha, @"(\d?\d):(\d\d)");
```

Podemos colocar os dois dígitos, mas, ao executar a duração, obteremos o valor correto. No entanto, se tivermos uma duração com apenas um dígito, a execução não funcionará, pois agora ele espera um padrão com dois dígitos. Se tivermos uma música com apenas um dígito, precisamos indicar que o primeiro dígito, antes dos dois pontos, é opcional. Para indicar essa ocorrência opcional, usamos a sintaxe da interrogação.

**Implementando a lógica de captura de duração**  
Anteriormente, nossa execução caía no else, indicando "duração não encontrada". Agora, ele encontrará a duração, como no caso de 2 minutos e 39 segundos, mas também encontrará durações com mais de um dígito, como 759. Assim, temos a possibilidade de ter dois dígitos ou apenas um na parte dos minutos. Na parte dos segundos, queremos que haja dois dígitos, pois, se houver apenas um, não saberemos se é 30 segundos ou 3 segundos. Portanto, validaremos que a parte dos segundos deve ter dois dígitos.

Vamos levar esse código para a obtenção de música, no método que usamos para isso. Vamos recortar o código e levá-lo para a parte onde obtemos a música. A música já está aqui, com a indicação do padrão. Vamos manter o objeto match sendo criado, mas agora sabemos o que fazer com a duração. Vamos criar um objeto chamado duração, um inteiro de 350, onde a duração será minutos multiplicados por 60, somados com os segundos. Não haverá else, pois já começamos com 350, e usaremos essa duração diretamente ao criar a propriedade duração da classe música.

```csharp
int duracao = 350;
var match = Regex.Match(linha, @"(\d?\d):(\d\d)");
if (match.Success)
{
    var minutos = int.Parse(match.Groups[1].Value);
    var segundos = int.Parse(match.Groups[2].Value);
    duracao = (minutos * 60) + segundos;
}
```

**Testando e validando a implementação**  
Agora, podemos testar a tabela novamente. A linha 7 não está mais sendo utilizada, então vamos apagá-la e descomentar o código que obtém as músicas, já com a duração corrigida. Ao executar, a tabela mostrará a duração corrigida, como 6 minutos, 650, 3 segundos, e assim por diante. Todos esses valores estão sendo capturados conforme esperado, já no novo formato de duração.

Conhecemos os grupos como uma maneira de agrupar padrões em subpartes, usando parênteses para isso, e utilizamos a coleção de grupos. Além disso, falamos sobre a ocorrência de algum elemento dentro desse padrão de expressões regulares, como a ocorrência opcional indicada pela interrogação. Existem também ocorrências para ter zero ou mais, ou pelo menos uma, e falaremos mais sobre essas ocorrências em seguida.

### Aula 6: Analisando padrões de duração de voos - Exercício

A plataforma Jornada Viagens, especializada na comparação e reserva de pacotes de viagens, hotéis e passagens aéreas, está desenvolvendo um novo recurso para calcular a duração total dos voos com base em dados de horários de partida e chegada. A equipe de desenvolvimento está utilizando expressões regulares para extrair e calcular a duração dos voos a partir de strings de texto que contêm informações de horários. No entanto, eles enfrentam um desafio ao lidar com voos que têm durações expressas em diferentes formatos, como "2h 30m" ou "1h 5m".

Qual abordagem a equipe pode adotar para utilizar expressões regulares e capturar corretamente as horas e minutos, garantindo que o cálculo da duração seja preciso, independentemente do formato?

Resposta:  
A equipe pode definir grupos na expressão regular para capturar as horas e minutos separadamente, utilizando uma expressão como (\d+)h\s*(\d+)?m?, onde (\d+) captura um ou mais dígitos para as horas, e (\d+)? captura opcionalmente os minutos. A interrogação após o grupo de minutos indica que ele é opcional, permitindo que a expressão funcione tanto para "2h 30m" quanto para "1h". A equipe pode então converter os valores capturados em inteiros e calcular a duração total em minutos, multiplicando as horas por 60 e somando os minutos.

> Correta, pois essa abordagem permite capturar de forma flexível as horas e minutos, independentemente do formato, garantindo que a duração total seja calculada com precisão.

### Aula 6: Superpoderes nas operações de filtro - Vídeo 3

Transcrição  
Agora que já conhecemos expressões regulares e aplicamos esse conhecimento para fazer o parsing da duração, considerando que o dado de entrada, aquele arquivo, mudou o formato da duração, podemos utilizar expressões regulares em outros contextos. Um contexto interessante é capturar e manipular coleções através do método WHERE. Esse método nos permite filtrar coleções usando link, e sabemos que ele precisa de um argumento que retorna um valor booleano. Se a condição for atendida, o elemento será incluído na saída; caso contrário, não será incluído.

Podemos combinar o WHERE com regex para usar padrões ainda mais complexos na captura de informações em nossa coleção de músicas. Vamos explorar isso. Trouxemos alguns exercícios para praticar, que serão copiados como comentários, seguindo o que fizemos anteriormente. Os exercícios incluem encontrar artistas com caracteres especiais, títulos de músicas com duas palavras, músicas que começam e terminam com a mesma palavra, músicas com letras repetidas e músicas com números romanos. Esses são alguns padrões que podemos tentar identificar nas músicas usando regex.

```csharp
/*
    - encontrando artistas com caracteres especiais
    - encontrando títulos com duas palavras
    - encontrando títulos que começam e terminam com a mesma palavra
    - encontrando títulos com letras repetidas
    - encontrando títulos com números romanos
*/
```

**Iniciando a filtragem de artistas com caracteres especiais**  
Para começar, vamos comentar o trecho relacionado às músicas, pois vamos trabalhar com artistas neste momento. Vamos criar uma variável chamada artistas, que será obtida a partir do arquivo de músicas. Em seguida, utilizaremos o WHERE, onde começaremos a nossa tarefa. Vamos montar o modelo com m = true, projetar a música para pegar somente a propriedade artista, eliminar elementos repetidos e, por fim, ordená-los de forma alfabética.

```csharp
var artistas = ObterMusicas(stream)
    .Where(m => true)
    .Select(m => m.Artista)
    .Distinct()
    .OrderBy(a => a);
```

Aqui temos todos os artistas ordenados de forma alfabética, sem repetir nenhum deles. Agora, precisamos trabalhar em uma condição que será obtida através de expressões regulares. A classe regex possui um método chamado isMatch, que verifica um padrão e retorna um valor booleano, exatamente o que precisamos na cláusula where.

**Definindo padrões de caracteres especiais**  
A string de entrada é a propriedade artista da classe música. Estamos verificando se esse artista possui caracteres especiais. O entendimento necessário aqui é sobre o padrão que precisamos conhecer para aplicar como uma expressão regular. Isso se aplica a todos os casos semelhantes. Cabe ressaltar que não conhecemos todos os padrões, pois seria humanamente impossível. Conhecemos um pouco de sintaxe, mas hoje em dia, com inteligência artificial e documentação, existem ferramentas online para testar padrões de expressões regulares, o que nos ajuda a criá-los.

O mais importante é saber que podemos usar expressões regulares e como aplicá-las. Utilizamos para fazer o parsing de duração e agora estamos usando para manipular coleções de músicas. Vou explicar o padrão específico que utilizaremos para encontrar caracteres especiais. Um caractere especial é tudo aquilo que não é um caractere normal, como letras minúsculas, maiúsculas, dígitos e espaços. O que não estiver nesse conjunto é considerado um caractere especial para este código.

Para definir um conjunto de opções em uma expressão regular, usamos colchetes. Tudo dentro dos colchetes é uma opção que pode ou não ocorrer em uma posição específica. Representamos um intervalo de valores com hífen, como A-Z para letras minúsculas, A-Z para maiúsculas, 0-9 para dígitos e espaço para o caractere de espaço em branco. Também podemos usar \s para representar espaço em branco. Esse padrão encontrará caracteres na propriedade artística, mas queremos aqueles que não são desse tipo. Para negar algo em uma expressão regular, usamos o acento circunflexo (^). Assim, buscamos na propriedade artística tudo que não seja letras de A a Z, números de 0 a 9 ou espaços em branco. Esses são os caracteres especiais.

```csharp
.Where(m => Regex.IsMatch(m.Artista, "[^a-zA-Z0-9 ]"))
```

**Imprimindo artistas com caracteres especiais**  
Após criar isso, faremos um for each para cada artista em artistas, imprimindo a variável artista. Ao executar, o resultado mostrará artistas com caracteres especiais, como ACDC com barra invertida, B1C com acento no E, Guns N' Roses com apóstrofo, K-Pop com hífen, Legião Urbana com til, Racionais com apóstrofo, Rosalia com acento e Tiesto com acento no E. Esses são os artistas com caracteres especiais na coleção de músicas.

```csharp
foreach(var artista in artistas) Console.WriteLine(artista);
```

**Otimizando o uso de expressões regulares**  
Com apenas uma linha, conseguimos realizar um trabalho complexo para encontrar esse padrão. Precisamos discutir mais um ponto: ao usar YIELD e WHERE, executamos essa condição para cada elemento da coleção, gerando um novo objeto regex a cada iteração. Em coleções grandes, como 1200 músicas, isso não é ideal. O recomendado é criar um objeto do tipo regex com NEW REGEX e definir o padrão nele. Assim, reutilizamos o mesmo objeto em cada iteração, evitando recriações desnecessárias.

```csharp
var regex = new Regex(@"[^a-zA-Z0-9 ]");
var artistas = ObterMusicas(stream)
    .Where(m => regex.IsMatch(m.Artista))
    .Select(m => m.Artista)
    .Distinct()
    .OrderBy(a => a);
foreach (var artista in artistas) Console.WriteLine(artista);
```

**Encapsulando a lógica em um método**  
Agora, vamos pegar esse código e levá-lo para um método, segundo nosso modelo. Selecionamos todo o código que filtra artistas com caracteres especiais e colocamos no método artistasComCaracteresEspeciais. O próximo passo será usar esse mesmo padrão WHERE com MATCH e expressão regular para outros exercícios.

```csharp
void ArtistasComCaracteresEspeciais()
{
    var regex = new Regex(@"[^a-zA-Z0-9 ]");
    var artistas = ObterMusicas(stream)
        .Where(m => regex.IsMatch(m.Artista))
        .Select(m => m.Artista)
        .Distinct()
        .OrderBy(a => a);
    foreach (var artista in artistas) Console.WriteLine(artista);
}
```

Com isso, encapsulamos a lógica de encontrar artistas com caracteres especiais em um método, facilitando a reutilização e manutenção do código.

### Aula 6: Resolvendo os outros exercícios - Vídeo 4

Transcrição  
Vamos continuar com nosso desafio de resolver os exercícios propostos. Já resolvemos o primeiro, que consiste em encontrar artistas com caracteres especiais. Vamos marcar essa atividade como concluída e deixar um espaço para as próximas.

O próximo exercício é encontrar títulos com duas palavras. Vamos montar nosso template para trabalhar com isso. Primeiramente, criamos um objeto do tipo regex (expressão regular).

```csharp
var regex = 
```

Agora, vamos inicializar esse objeto com a classe Regex.

```csharp
var regex = new Regex();
```

**Definindo padrões de expressões regulares**  
Precisamos definir a condição para que o título da música corresponda ao regex.

```csharp
var regex = new Regex(@"");
```

Em seguida, vamos exibir os 20 primeiros resultados em uma tabela.

```csharp
var musicas = ObterMusicas(stream)
    .Where()
    .Take(20);
```

A questão é: qual padrão devemos usar para encontrar títulos com duas palavras? Este é um estudo que nos permitirá aplicar o conhecimento posteriormente ou utilizar ferramentas que forneçam esses padrões. A inteligência artificial também pode nos ajudar bastante nesse processo.

O objetivo é encontrar um título com exatamente duas palavras, sem mais ou menos. Precisamos avaliar a string original do início ao fim, garantindo que o padrão se aplique à string inteira. Para isso, utilizamos dois símbolos: o símbolo do chapéu (^) para indicar o início da string e o cifrão ($) para indicar o fim. Entre esses dois símbolos, colocamos o padrão desejado.

**Criando expressões regulares para títulos de músicas**  
Para encontrar uma palavra em uma string, usamos caracteres que a representem. Na expressão regular, o \w indica um caractere que pode aparecer em uma palavra, como letras minúsculas, maiúsculas, dígitos, entre outros. Queremos pelo menos um caractere, então usamos o símbolo de mais (+) para indicar essa ocorrência. O espaço separa duas palavras, então incluímos um espaço seguido do mesmo padrão \w+. Isso indica que a string começa e termina com uma palavra, totalizando duas palavras.

```csharp
var regex = new Regex(@"^\w+ \w+$");
```

Vamos testar nossa coleção de músicas com duas palavras. Agora, exibimos as vinte primeiras músicas que contêm exatamente duas palavras.

```csharp
var musicas = ObterMusicas(stream)
    .Where(m => regex.IsMatch(m.Titulo))
    .Take(20);
```

**Criando métodos para manipulação de músicas**  
Prosseguindo, marcamos mais um exercício como concluído. O próximo passo é levar o código que resolve esse exercício para um método chamado "Músicas com duas palavras".

```csharp
void MusicasComDuasPalavras()
{
    var regex = new Regex(@"^\w+ \w+$");
    var musicas = ObterMusicas(stream)
        .Where(m => regex.IsMatch(m.Titulo))
        .Take(20);

    ExibirMusicasEmTabela(musicas);
}
```

**Encontrando padrões complexos em títulos de músicas**  
O próximo desafio é encontrar músicas que começam e terminam com a mesma palavra. Este é um pouco mais complexo. Vamos usar o padrão anterior, mas o regex será diferente. Precisamos garantir que o padrão ocorra do início ao fim da string original. A primeira palavra deve ser repetida no final. Para isso, capturamos a palavra em uma subparte da expressão regular.

```csharp
var regex = new Regex(@"^(\w+).*\1$");
```

Após capturar a primeira palavra, qualquer coisa pode aparecer em seguida. Usamos o ponto (.) para indicar qualquer caractere e o asterisco (*) para indicar que pode ocorrer zero ou mais vezes. Finalmente, a mesma palavra deve aparecer no final da expressão. Para referenciar o primeiro grupo capturado, usamos \1. O Visual Studio fornece indicações úteis para facilitar esse processo.

**Implementando métodos para padrões repetidos**  
Assim, capturamos a primeira palavra no início e garantimos que ela se repita no final da string.

```csharp
void MusicasQueComecamETerminamComAMesmaPalavra()
{
    var regex = new Regex(@"^(\w+).*\1$");
    var musicas = ObterMusicas(stream)
        .Where(m => regex.IsMatch(m.Titulo))
        .Take(20);

    ExibirMusicasEmTabela(musicas);
}
```

Depois, aceitamos qualquer coisa que venha. Pode ser 30 palavras, pode ser 2 palavras. No final, deve ser o mesmo valor que foi capturado naquele primeiro grupo. Este é o nosso padrão para encontrar músicas que começam e terminam com a mesma palavra. Será que existe isso na coleção de músicas? Vamos apertar F5 e verificar. Apareceu uma música: "Yeah, yeah, yeah". A primeira palavra é "yeah" e a última palavra também é "yeah". O que vinha aparecendo no meio não era relevante. Utilizamos o ponto com asterisco, mas ele encontrou o padrão. Assim, começamos a usar expressões regulares bastante complexas, mantendo sempre o mesmo padrão. Encontramos músicas que começam e terminam com a mesma palavra.

**Explorando padrões de letras repetidas**  
Vamos seguir para mais um exemplo: músicas com letras repetidas. Seguindo o mesmo padrão, vamos copiar e colar aqui. Agora, precisamos entender qual é o padrão. Este padrão é bastante complexo, mas vamos tentar explicar. Primeiro, ele pode encontrar um padrão em qualquer local da string original, pois não há início e fim de string definidos. Esse padrão pode ocorrer em partes do título da música. O importante é que ele aceita qualquer palavra com qualquer ocorrência. Ele precisa encontrar um padrão específico: capturar uma letra específica dentro dos caracteres que representam a palavra. Depois, queremos que essa mesma letra capturada apareça novamente. Temos o \1 aqui, e ela pode aparecer mais duas vezes, ou seja, duas ou mais vezes. Assim, letras repetidas são capturadas, e depois pode aparecer qualquer coisa.

```csharp
var regex = new Regex(@"(\w)\1{2,}");
```

Vamos executar este exemplo de músicas com letras repetidas. Até estamos incrédulos se isso vai funcionar. F5. Surpreendentemente, encontramos uma música com três letras repetidas e uma música do Linkin Park com essas três letras. Dentro das 1.200 músicas, encontramos essas duas com letras repetidas. Se não me engano, isso poderia ocorrer pelo menos uma vez. Ele encontrou duas letras repetidas: "Sweet Sound, Sweet, Sweet, Sweet, Sweet". Quando há o 2, ele busca ainda mais repetições, a partir de três repetições. Quando colocamos o 1, não precisamos especificar, podemos usar o mais para indicar pelo menos uma vez. Para especificar uma ocorrência diferente, usamos chaves para indicar o número de ocorrências. No caso, é de 2 até infinito. Se quiséssemos de 2 até 4, colocaríamos o limite final. Para apenas duas vezes, como nas duas músicas que encontramos, sempre três vezes, podemos especificar assim também. É uma maneira de representar a ocorrência em uma expressão regular.

```csharp
void MusicasComLetrasRepetidas()
{
    var regex = new Regex(@"(\w)\1{2,}");
    var musicas = ObterMusicas(stream)
        .Where(m => regex.IsMatch(m.Titulo))
        .Take(20);

    ExibirMusicasEmTabela(musicas);
}
```

**Identificando títulos com números romanos**  
Para encontrar números romanos, é mais simples. Vamos criar títulos com números romanos. Em geral, músicas com números romanos são óperas ou músicas clássicas, como "Adagio, Número X" ou "Sonata, Número Y". Vamos copiar nosso modelo e substituir o padrão regex. Precisamos de um conjunto que represente números romanos.

```csharp
var regex = new Regex(@"\b[IVXLCDM]+\b");
```

Este é um conjunto, então qualquer ocorrência desses caracteres entra no padrão, pelo menos uma vez. A outra indicação é o \b, que indica o fim ou limite da palavra. O número romano não aparece em outra palavra, como o Y, que deve ser separado por espaço, fim ou início de padrão.

Vamos executar o método para títulos com números romanos. Apertar F5. Encontramos um erro: falta um ponto e vírgula. Após corrigir, F5 novamente. Encontramos músicas clássicas, como "Sinfonia número 4" e "Adagio 3". Apesar de ser um dado fictício, é uma coleção de músicas fictícias.

```csharp
void TitulosComNumerosRomanos()
{
    var regex = new Regex(@"\b[IVXLCDM]+\b");
    var musicas = ObterMusicas(stream)
        .Where(m => regex.IsMatch(m.Titulo))
        .Take(20);

    ExibirMusicasEmTabela(musicas);
}
```

**Concluindo o estudo de expressões regulares**  
Para concluir este estudo, com expressões regulares, ganhamos superpoderes na manipulação de dados, tanto de texto quanto de coleções. Primeiro, usamos expressões regulares para fazer o parsing de uma duração e, depois, para encontrar padrões complexos em coleções, encadeando com a operação de filtro do link, que é o WHERE. Colocamos a expressão regular para se tornar a condição de match, incluindo ou não o elemento na saída. Em seguida, continuaremos nosso estudo sobre manipulação de dados.

### Aula 6: Para saber mais: Regex com back-references

**Compreendendo o conceito**  
As back-references em expressões regulares permitem reutilizar uma parte do padrão capturado anteriormente, garantindo que a mesma sequência de caracteres ocorra novamente em outro ponto da string. Esse recurso é extremamente útil quando se deseja validar padrões onde um elemento deve ser repetido, como o caso de músicas que começam e terminam com a mesma palavra.

Quando se define um grupo entre parênteses, o conteúdo capturado fica disponível para referência posterior. Por exemplo, em um padrão como ^(\w+).*(\1)$, o primeiro grupo \w+ captura uma sequência de caracteres que compõem uma palavra. O \1 é a back-reference a esse grupo, obrigando todo o restante da string a terminar exatamente com o mesmo conteúdo capturado.

**Funcionamento e vantagens**  
O principal motivo pelo qual as back-references funcionam é que elas operam em um nível de verificação de igualdade entre strings. Diferente de outras técnicas de validação, que criam condições independentes, as back-references garantem que a mesma cadeia de caracteres ocorra em duas (ou mais) posições distintas. Essa abordagem é poderosa para identificar simetrias, repetições ou padrões que se repetem de forma idêntica.

Entre as vantagens, destacam-se:

Consistência nos padrões: Ao capturar um grupo e referenciá-lo, a expressão regular assegura a consistência dos dados, por exemplo, em padrões que exigem que o início e o fim sejam iguais.
Simplicidade na criação do padrão: Em vez de tentar definir manualmente quais variações poderiam aparecer, a back-reference lida automaticamente com a repetição exata do grupo.
Flexibilidade: Pode ser aplicada em diversos cenários, desde validação de formatos simples até extração de dados complexos.

**Exemplos práticos**  
Imagine um cenário onde se deseja identificar títulos que começam e terminam com a mesma palavra. Um exemplo de expressão poderia ser:

```csharp
string pattern = @"^(\w+)\s.*\s(\1)$";
```

Neste padrão:

- ^(\w+) captura a primeira palavra do título.
- \s.*\s aceita qualquer conteúdo intermediário, contanto que seja delimitado por espaços.
- (\1)$ garante que a última palavra seja igual à primeira.

Assim, a expressão assegura que, se um título iniciar com uma determinada palavra, ele terminará com a mesma sequência de letras.

**Considerações e cuidados**  
Embora as back-references sejam ferramentas poderosas, é importante ter atenção aos seguintes pontos:

- Performance: Em algumas circunstâncias, o uso excessivo de back-references pode impactar a performance da aplicação, especialmente em textos muito grandes ou padrões muito complexos.
- Legibilidade e manutenção: Expressões regulares com várias back-references podem se tornar difíceis de ler e manter.  Nesse caso, uma documentação interna do padrão pode ajudar outros desenvolvedores a compreender a lógica aplicada.
- Limitações: Nem todas as implementações de regex possuem suporte completo a back-references. Verifique a compatibilidade da ferramenta ou linguagem utilizada.

Compreender profundamente o funcionamento das back-references permite criar padrões robustos e eficientes, aprimorando a validação e extração de dados em aplicações que manipulam coleções e textos de forma intensiva.

### Aula 6: Faça como eu fiz: Regex em ação

Nesta aula, aplicamos expressões regulares para adaptar o código diante das mudanças no formato de dados e para filtrar padrões específicos em coleções.

Agora é a sua vez de praticar os conceitos abordados. Para isso:

- Organize o Visual Studio, fechando e abrindo a abinha do program.cs conforme a troca para o projeto 6.
- Abra o arquivo program.cs do projeto 6 e confira o código pré-existente.
- Execute o código (F5) e observe a exibição das músicas em tabela, verificando o problema na duração.
- Analise o novo formato da duração e identifique a necessidade de atualização no parsing.
- Implemente o uso de expressões regulares para localizar o padrão de 'minutos:segundos' na duração.
- Agrupe as partes (minuto e segundo) utilizando parênteses na expressão regular.
- Converta os valores capturados de string para inteiro e calcule a duração total em segundos.
- Substitua a lógica antiga de parsing pelo novo método baseado em Regex.
- Utilize o método Where com Regex para filtrar artistas com caracteres especiais e outros exercícios propostos.
- Modularize o código criando métodos separados para cada tipo de filtro (títulos com duas palavras, músicas que iniciam e terminam com a mesma palavra, etc.).

### Aula 6: O que aprendemos?

Nesta aula, aprendemos:

- A utilizar a propriedade Groups do objeto Match para capturar subpartes de uma expressão regular.
- A definir grupos em expressões regulares utilizando parênteses para capturar diferentes partes de um padrão.
- A converter diretamente grupos capturados para tipos numéricos usando int.Parse.
- A usar a interrogação em expressões regulares para indicar que um elemento é opcional.
- A identificar padrões específicos em strings utilizando a classe RegEx do C#.
- A criar e utilizar expressões regulares para lidar com diferentes formatos de entrada.
- A aplicar expressões regulares em filtros LINQ para manipular coleções com condições complexas.
- A encapsular operações de filtragem em métodos distintos para organização e reutilização do código.

## Aula 7: Serialização

### Aula 7: Projeto da aula anterior

Na aula anterior, ampliamos o conhecimento sobre manipulação de strings com expressões regulares, aprendendo a reconhecer padrões, capturar grupos, aplicar filtros complexos e entender implicações de desempenho. Essa técnica é essencial para validar e transformar informações textuais em cenários reais. Você pode conferir o código completo da aula no [repositório do curso no GitHub.](https://github.com/alura-cursos/data-manipulation-with-csharp/tree/main/06-ExpressoesRegulares)

### Aula 7: Gerando um arquivo a partir da coleção - Vídeo 1

Transcrição
Estamos chegando ao final do nosso estudo sobre manipulação de dados e agora temos um desafio final. Vamos organizar o ambiente e, em seguida, realizar o exercício proposto.

Primeiramente, vamos fechar o Program.cs do projeto 6 e selecionar o projeto 7 na lista suspensa da barra inicial do Visual Studio. No projeto 7, vamos abrir o Program.cs, que já está preenchido com o código para leitura e exibição de arquivos de músicas.

Descrevendo o exercício proposto
O exercício consiste em criar uma coleção de artistas com as músicas ordenadas por data de lançamento. Além disso, devemos incluir o total de músicas em uma propriedade separada. Após montar essa coleção, que envolve processar a coleção de músicas, vamos gerar um arquivo no formato JSON com essa coleção.

Esse estágio é geralmente o último na manipulação de dados. O primeiro estágio é obter os dados da origem, seja arquivo, banco de dados, API web ou outro sistema. Em seguida, manipulamos esses dados, que geralmente vêm como coleção, utilizando link, expressões regulares, entre outros. Depois de gerar a coleção final, persistimos esses dados, tornando-os permanentes. No nosso exemplo, vamos torná-los permanentes em um arquivo, mas também é possível armazená-los em um banco de dados ou enviá-los para outro sistema web ou de software. No nosso caso, criaremos um arquivo JSON para isso.

Criando a coleção de artistas
Vamos ao desafio. A primeira etapa é criar a coleção de artistas. Vamos criar uma variável chamada artistas, que será derivada da coleção de músicas a partir do arquivo de entrada.

var artistas = 
Copiar código
Em seguida, utilizaremos o método ObterMusicas para obter a coleção de músicas a partir do stream.

var artistas = ObterMusicas(stream)
Copiar código
Agora, utilizaremos o método groupby do link para agrupar as músicas pelo artista, que será a chave de agrupamento dessa coleção.

var artistas = ObterMusicas(stream)
    .GroupBy(m => m.Artista)
Copiar código
Selecionando e ordenando músicas
Após isso, faremos um select para cada grupo, criando um objeto anônimo onde o nome será o artista. Teremos uma propriedade chamada artista, que será o resultado da chave, e uma propriedade chamada músicas, que será o próprio agrupamento ordenado de forma crescente pela propriedade data de lançamento da música. Além disso, teremos uma propriedade chamada total, que é a agregação do total de músicas no agrupamento.

var artistas = ObterMusicas(stream)
    .GroupBy(m => m.Artista)
    .Select(g => new { Artista = g.Key, Musicas = g.OrderBy(m => m.Lancamento), Total = g.Count() })
Copiar código
Vamos transformar isso em uma lista para materializar a coleção.

var artistas = ObterMusicas(stream)
    .GroupBy(m => m.Artista)
    .Select(g => new { Artista = g.Key, Musicas = g.OrderBy(m => m.Lancamento), Total = g.Count() })
    .ToList();
Copiar código
Preparando para a serialização em JSON
Agora, para serializar essa coleção em um formato JSON, precisamos entender que o JSON é um formato padrão amplamente utilizado no mercado para arquivos de texto estruturados. Essa estrutura é bastante enxuta e baseada na linguagem JavaScript, por isso é chamada de JavaScript Object Notation. Quando temos objetos em JavaScript e queremos representá-los, utilizamos essa notação.

Para gerar o arquivo JSON, primeiro precisamos criá-lo. O nome do arquivo será uma combinação de caminhos, utilizando uma classe estática chamada Environment, que contém informações sobre o ambiente de execução. Vamos pegar o caminho de uma pasta especial, que é o Desktop, utilizando SpecialFolder.Desktop.

var nomeArquivo = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), 
    "artistas.json");
Copiar código
Dessa forma, não precisamos escrever manualmente o caminho, como "C:", por exemplo, pois o Environment nos fornece essa informação de forma automática.

Criando e escrevendo no arquivo JSON
Vamos combinar a pasta com o nome artistas.json. O nome do arquivo é esse. Assim como anteriormente criamos um arquivo para leitura, que estava na própria pasta de execução, agora vamos criar um arquivo para saída. Podemos até copiar o código anterior, pois é muito parecido, mas o nome do arquivo será diferente. Será um FileStream, e o nome do arquivo é o que criamos, nome_arquivo. O modo de abertura será para criação e o acesso será de escrita.

using var arquivoJson = new FileStream(nomeArquivo, FileMode.Create, FileAccess.Write);
Copiar código
Para escrever a coleção de artistas nesse arquivo.json, utilizaremos uma classe do Namespace chamada System.Text.Json.

using System.Text.Json;
Copiar código
Serializando a coleção de artistas
Essa classe é o JsonSerializer. O processo que estamos realizando, de manipular dados, pegar uma coleção em memória e transferir para um arquivo texto ou formato textual, é chamado de serialização. Não precisa ser apenas com coleções, pode ser com objetos também. Pegamos um objeto em memória, que pode ser uma coleção ou qualquer outra coisa, e o levamos para uma representação textual. Isso é diferente do formato, que é usado para visualização. Nesse caso, o formato é usado para transportar a informação, seja via arquivo, sistema de software ou web. Esse processo é chamado de serialização e, em geral, é o último estágio do nosso fluxo de manipulação de dados.

A classe JsonSerializer será responsável por serializar a coleção de artistas. No método serialize, passamos o arquivo para onde queremos serializar e o objeto, que é a coleção de artistas.

JsonSerializer.Serialize(arquivoJson, artistas);
Copiar código
Podemos até incluir um Console.WriteLine com a mensagem "Serialização Concluída".

Console.WriteLine("Serialização concluída!");
Copiar código
Executando e verificando o arquivo gerado
Vamos executar o código com F5 e, se tudo der certo, veremos a mensagem "Serialização concluída" no terminal, indicando que o arquivo foi gerado no desktop. Vamos fechar a execução e tentar abrir o arquivo. Clicamos em "Open" no Visual Studio, procuramos na área de trabalho e ele abre. O arquivo existe e contém o conteúdo, mas não conseguimos entender muito bem. É importante lembrar que esse entendimento é para humanos. Para máquinas e outros sistemas de software, essa estrutura é perfeita e permite dar continuidade ao processo necessário.

Melhorando a legibilidade do arquivo JSON
Agora, vamos adicionar uma opção para que pessoas consigam visualizar o conteúdo de forma mais clara. Vamos gerar novamente o arquivo, mas com outra opção. Para isso, precisamos criar um objeto do tipo JsonSerializerOptions.

var options = new JsonSerializerOptions
{
    WriteIndented = true
};
Copiar código
Nesse objeto, passaremos uma flag como true para escrever de forma indentada. Isso proporcionará uma visualização mais clara. Passaremos esse objeto como terceiro argumento no método JsonSerializer.Serialize.

JsonSerializer.Serialize(arquivoJson, artistas, options);
Copiar código
Vamos executar novamente. Ele sobrescreverá o arquivo anterior e, ao abrir novamente o arquivo artistas.json no desktop, veremos que ficou muito mais fácil de ler. Podemos conferir cada estrutura: artistas como Rolling Stones, com um total de 9 músicas, Coldplay com 19 músicas, e assim por diante, incluindo Adele, The Weekend, Metallica, todas ordenadas por artistas.

Concluindo o estudo de manipulação de dados
Com isso, concluímos essa parte de manipulação de dados. Este estudo foi bastante aprofundado, começando desde a obtenção de dados através de um arquivo, passando por coleções, textos, expressões regulares e, por fim, serializando a manipulação que fizemos em um arquivo JSON.

### Aula 7:  - Vídeo 2
### Aula 7:  - Vídeo 3
### Aula 7:  - Vídeo 4
### Aula 7:  - Vídeo 5
### Aula 7:  - Vídeo 6
### Aula 7:  - Vídeo 7
### Aula 7:  - Vídeo 8
### Aula 7:  - Vídeo 9
