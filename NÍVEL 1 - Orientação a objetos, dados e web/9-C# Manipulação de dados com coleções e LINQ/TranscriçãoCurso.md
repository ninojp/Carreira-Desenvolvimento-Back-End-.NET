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

Preparando o ambiente de desenvolvimento
Precisaremos ler esse arquivo e trazer as músicas como uma coleção. Esse será nosso primeiro trabalho neste estudo. Vamos fechar o arquivo de músicas e abrir a classe Program disponível no projeto 3. Essa é a classe inicial que contém o console "Hello World". Podemos apagar esse conteúdo, selecionando tudo e pressionando "Delete". Em seguida, traremos da área de transferência o enunciado dos exercícios que faremos com o arquivo de músicas, colando-o com "Ctrl+V". Esse é o enunciado com as tarefas para nosso estudo inicial. Realizaremos uma série de atividades baseadas em uma coleção originada de um arquivo.

Vamos salvar o progresso com "Ctrl+S". Para organizar melhor, na barra inicial do Visual Studio, onde há a lista suspensa com os projetos, selecionaremos o projeto número 3. Estamos avançando no estudo. Agora, começaremos a escrever código. O primeiro código será a classe Musica. Vamos criar essa classe diretamente, pois será mais rápido do que copiar e colar de outros lugares.

class Musica
{
}
Copiar código
Criando a classe Musica
Acabamos de iniciar a criação de uma estrutura para manipular dados de músicas. Vamos criar uma propriedade chamada Título, que será do tipo String.

class Musica
{
    public string Titulo { get; set; }
}
Copiar código
Em seguida, adicionamos outra propriedade chamada Artista, também do tipo String.

class Musica
{
    public string Titulo { get; set; }
    public string Artista { get; set; }
}
Copiar código
Por fim, adicionamos uma propriedade do tipo int, que será a Duração.

class Musica
{
    public string Titulo { get; set; }
    public string Artista { get; set; }
    public int Duracao { get; set; }
}
Copiar código
Inicializando o arquivo de músicas
Para inicializar o arquivo, a primeira coisa que precisamos fazer é criar uma variável que representará esse arquivo, do tipo FileStream. No FileStream, devemos passar o nome do arquivo, que será músicas.csv. O modo de abertura será de leitura, utilizando FileAccess para leitura somente. Assim, pegamos esse arquivo.

var arquivo = new FileStream("musicas.csv", FileMode.Open, FileAccess.Read);
Copiar código
Quando trabalhamos com arquivos, é importante gerenciar esse recurso, pois ele representa um ponteiro no sistema operacional. Precisamos liberar esse recurso após o uso, e a palavra reservada using faz isso automaticamente ao término da execução. Portanto, não precisamos nos preocupar em liberar manualmente o recurso. Vamos colocar o using na frente da variável do arquivo.

using var arquivo = new FileStream("musicas.csv", FileMode.Open, FileAccess.Read);
Copiar código
Lendo o arquivo de músicas
Além disso, precisamos ler esse arquivo. Vamos criar um StreamReader a partir do arquivo, também utilizando using, pois precisamos liberar esse recurso que representa um fluxo de bytes lido linha a linha.

using var stream = new StreamReader(arquivo);
Copiar código
Agora, estamos prontos para ler o arquivo e entregar uma coleção de músicas. Vamos criar um método que não será void, mas sim um método que retornará um IEnumerable de músicas. Nomearemos esse método como ObterMusicas a partir de um StreamReader, e o argumento de entrada será chamado de stream.

IEnumerable<Musica> ObterMusicas(StreamReader stream)
{
}
Copiar código
O que esse stream fará? Primeiro, precisamos pegar a linha, pois leremos linha a linha. Enquanto a linha não for null, significa que não terminamos a leitura do arquivo, então permaneceremos nesse loop.

IEnumerable<Musica> ObterMusicas(StreamReader stream)
{
    var linha = stream.ReadLine();
    while(linha is not null)
    {
    }
}
Copiar código
Convertendo linhas em objetos Musica
O próximo passo será converter essa linha em uma música. Vamos criar um objeto do tipo Musica com new Musica. Inicialmente, o Título será uma String vazia, e a Duração será zero.

var partes = linha.Split(';');
var musica = new Musica
{
    Titulo = string.Empty,
    Artista = string.Empty,
    Duracao = 0
};
Copiar código
Após criar o objeto, precisamos colocá-lo em uma lista ou não. Quando temos métodos que retornam um IEnumerable, podemos entregar diretamente um processamento de elemento sob demanda, usando yield return Musica.

yield return musica;
Copiar código
Já temos praticamente tudo pronto, mas falta pegar os valores de fato: Título, Artista e Duração de cada linha. Para isso, dividiremos a linha em partes usando o método Split da String, que quebra a linha através do separador ponto e vírgula.

var musica = new Musica
{
    Titulo = partes[0],
    Artista = partes[1],
    Duracao = Convert.ToInt32(partes[2])
};
Copiar código
Exibindo as músicas no terminal
Com isso, terminamos o código que processa o arquivo de músicas para um enumerado de músicas. Agora, vamos criar um método que lerá e exibirá as músicas no terminal. Esse método receberá um IEnumerable de músicas.

void ExibirMusicas(IEnumerable<Musica> musicas)
{
}
Copiar código
Vamos percorrer as músicas com foreach (var musica in musicas) e exibir cada música usando interpolação de strings, com um "Tab" e um hífen, seguido do nome da música, musica.Titulo.

void ExibirMusicas(IEnumerable<Musica> musicas)
{
    foreach(var musica in musicas)
    {
        Console.WriteLine($"\t - {musica.Titulo}");
    }
}
Copiar código
Também adicionaremos um título à exibição, pulando uma linha e escrevendo "Exibindo as músicas:".

void ExibirMusicas(IEnumerable<Musica> musicas)
{
    Console.WriteLine($"\nExibindo as músicas:");
    foreach(var musica in musicas)
    {
        Console.WriteLine($"\t - {musica.Titulo}");
    }
}
Copiar código
Limitando a exibição das músicas
Para não exibir todas as músicas, já que o arquivo contém mais de mil músicas, faremos uma quebra. Vamos criar um contador e exibir apenas as primeiras 10 músicas. O contador começará em 1, e após exibir cada música, incrementaremos o contador. Se o contador for maior que 10, sairemos do loop e pararemos de exibir músicas.

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
Copiar código
Finalizando a execução do projeto
Agora, podemos criar uma variável do tipo Músicas que receberá o método ObterMusicas, retornando um IEnumerable de músicas. Por fim, chamaremos o método ExibirMusicas, passando o IEnumerable criado.

var musicas = ObterMusicas(stream);
ExibirMusicas(musicas);
Copiar código
Criamos o modelo e a estrutura inicial que usaremos para este estudo de coleções. Vamos executar o projeto atual, que é o projeto número 3, e pressionar F5. Se tudo der certo, ele exibirá as 10 primeiras músicas do arquivo. Caso contrário, verificaremos o motivo. No nosso caso, percebemos que esquecemos de ler a próxima linha dentro do loop.

linha = stream.ReadLine();
Copiar código
Após corrigir isso, pressionamos F5 novamente, e agora sim, ele exibirá as 10 primeiras músicas do arquivo: "The Broken Road", "Midnight Echo of Shadows", "Lonely Star", entre outras.

Utilizamos a estratégia de processamento sob demanda, deixando para a própria máquina virtual do .NET gerar o enumerador para nós. Assim, não precisamos percorrer todo o arquivo, apenas as 10 primeiras linhas que nos interessavam. Na sequência, continuaremos trabalhando com esses exercícios.

### Aula 3:  - Vídeo 2
### Aula 3:  - Vídeo 3
### Aula 3:  - Vídeo 4
### Aula 3:  - Vídeo 5
### Aula 3:  - Vídeo 6
### Aula 3:  - Vídeo 7
### Aula 3:  - Vídeo 8

