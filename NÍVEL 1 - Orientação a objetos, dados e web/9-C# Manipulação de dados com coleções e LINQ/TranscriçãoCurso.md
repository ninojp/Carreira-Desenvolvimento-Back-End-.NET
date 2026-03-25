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

## Aula 2: 

### Aula 2:  - Vídeo 1
### Aula 2:  - Vídeo 1
### Aula 2:  - Vídeo 2
### Aula 2:  - Vídeo 3
### Aula 2:  - Vídeo 4
### Aula 2:  - Vídeo 5
### Aula 2:  - Vídeo 6
