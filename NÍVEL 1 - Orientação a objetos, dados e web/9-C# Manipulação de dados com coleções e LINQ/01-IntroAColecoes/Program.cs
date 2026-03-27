using System.Collections;
using System.Runtime.Intrinsics.X86;

var produto1 = new Produto { Id = "1", Nome = "Camiseta", Preco = 29.90m };
var produto2 = new Produto { Id = "2", Nome = "Calça Jeans", Preco = 89.90m };

var musica1 = new Musica { Titulo = "Bohemian Rhapsody", Artista = "Queen" };
var musica2 = new Musica { Titulo = "Imagine", Artista = "John Lennon" };
// existem outras maneiras de inicializar listas
var playlist2 = new List<Musica>
{
    new Musica { Titulo = "Hotel California", Artista = "Eagles" },
    new Musica { Titulo = "Stairway to Heaven", Artista = "Led Zeppelin" }
};

// Antigamente usavamos o ArrayList, que permite armazenar qualquer tipo de objeto, e tem seu tamanho previamente definido. 
ArrayList arrayList1 = ["Segunda-feira", produto1, musica1, 20];

//string[], temos o array de "tipoDefinido", que é um tipo específico de array, e tem seu tamanho previamente definido. 
string[] arrayDiasDaSemana = ["Domingo", "Segunda-feira", "Terça-feira", "Quarta-feira", "Quinta-feira", "Sexta-feira", "Sábado"];

//Atualmente usamos o List<T>, que é dinâmico, e só aceita um tipo específico de objeto, definido por T (generics types).
List<Produto> listCarrinho = [produto1, produto2]; //List<T> vem de System.Collections.Generic

List<Musica> playlist = [musica1, musica2];

// Acessando ou iterando diretamente os itens de uma coleção:
var itemCarrinho1 = arrayList1[0];
var itemCarrinho2 = listCarrinho[1];
string terceiroDia = arrayDiasDaSemana[2];

//Iterando com FOR sobre os itens de uma coleção.
//static void UsandoFor(ArrayList arrayLista)
//static void UsandoFor(string[] arrayLista)
static void UsandoFor(List<Produto> arrayLista)
{
    Console.WriteLine("\nIterando com FOR: List<Produto> listCarrinho");
    for (int i = 0; i < arrayLista.Count; i++)
    //for (int i = 0; i < arrayLista.Length; i++)
    {
        Console.WriteLine($"Item: {i}, Nome: {arrayLista[i].Nome}, Preço: {arrayLista[i].Preco}");
    }
}
UsandoFor(listCarrinho);
// Iterando com FOREACH sobre os itens de uma coleção.
void PercorrendoPlayListMusicas()
{
    Console.WriteLine("\nPercorrendo com Foreach PlayList Musicas");
    foreach (var musica in playlist) // pega o enumerador implicitamente, e usa MoveNext() e Current; LINDO!
    {
        Console.WriteLine($"Título: {musica.Titulo}, Artista: {musica.Artista}");
    }
}
//Então, pra fica bem claro: foreach só pode ser usado em coleções que implementam IEnumerable:
//https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/statements/iteration-statements#the-foreach-statement
static void UsandoForEach(List<Produto> arrayLista)
{
    Console.WriteLine("\nIterando com FOREACH: List<Produto> listCarrinho");
    foreach (var produto in arrayLista)
    {
        Console.WriteLine($"Nome: {produto.Nome}, Preço: {produto.Preco}");
    }
}
UsandoForEach(listCarrinho);

//Coleções personalizadas, precisamos implementar a interface IEnumerable<T> que por sua vez exige a implementação de um enumerador.
var diasDaSemana = new DiasDaSemana();
Console.WriteLine("\nClasse DiasDaSemana, implementando IEnumerable<string>");
foreach (var dia in diasDaSemana)// isso só funciona se DiasDaSemana implementar IEnumerable<string>
{
    Console.WriteLine($"{dia}");
}

//Como o foreach funciona por baixo dos panos? 
//a partir de um objeto responsável por "percorrer" a coleção: o enumerador.
PercorrendoComEnumerator();
void PercorrendoComEnumerator()
{
    var enumerador = diasDaSemana.GetEnumerator();
    Console.WriteLine("\nPercorrendo Com GetEnumerator, DiasDaSemana");
    while (enumerador.MoveNext())
    {
        //a cada chamada de MoveNext(), o cursor avança para o próximo item. Current retorna o item atual.
        var dia = enumerador.Current;
        Console.WriteLine($"{dia}");
    }
}
//esse objeto implementa a interface IEnumerator:
//https://learn.microsoft.com/pt-br/dotnet/api/system.collections.ienumerator
//Recapitulando: IEnumerator tem os métodos MoveNext() e Reset(), e a propriedade Current. 
//IEnumerable é uma interface que representa uma coleção que pode ser enumerada ("percorrida")
//https://learn.microsoft.com/pt-br/dotnet/api/system.collections.generic.ienumerable-1

/*
Vamos reforçar a importância do yield: 
    -quando usamos um IEnumerable, precisamos de um IEnumerator para percorrer a coleção.
    - quando implementamos IEnumerator (e seus membros MoveNext(), Current), acabamos criando uma coleção em memória, o que pode ser ineficiente.
    - o yield faz com que esse trabalho seja delegado para o runtime do .NET, em tempo de execução, somente quando necessário usar algum item da coleção.
    - por exemplo: quero usar a coleção DiasDaSemana para obter somente os três primeiros dias da semana.
    - sem o yield, precisaríamos criar uma coleção em memória, com todos os itens, tremendo desperdício!
    - com o yield, o enumerador só gera os dias quando necessário, economizando memória E processamento.
    - imagina uma coleção com milhares de itens, e você só precisa de alguns poucos?
    - outro exemplo: uma coleção que retorne números pares até um limite informado como parâmetro. 

    Então o yield traz: legibilidade, simplicidade e eficiência (economia de memória e processamento).
    E quando podemos empregar o yield? Em métodos que retornam IEnumerable<T> ou IEnumerator<T>
*/
//Aula 1: Aprofundando o yield - Vídeo 6

//NumerosParesSemYield cria uma lista em memória com todos os números pares até o limite informado, o que pode ser ineficiente se o limite for muito grande.
static IEnumerable<int> NumerosParesSemYield(int limite)
{
    var listPares = new List<int>();
    for (int i = 0; i <= limite; i++)
    {
        //Console.WriteLine($"NumerosParesSemYield, elemento {i}");
        if (i % 2 == 0) listPares.Add(i);
    }
    return listPares;
}
var paresSemYield = NumerosParesSemYield(2000);
Console.WriteLine($"\nNumerosParesSemYield, lista com, {paresSemYield.Count()} números pares");
int contador = 0;
foreach (var nPares in paresSemYield)
{
    contador++;
    Console.Write($"{nPares} ");
    if (contador >= 10) break;
}
//ACABOU FICANDO UM CODIGO MUITO CONFUSO E FOI DEIXADO ASSIM MESMO!!!!!
//NumerosParesComYield não cria uma lista em memória, ele gera os números pares sob demanda, quando forem percorridos.
static IEnumerable<int> NumerosParesComYield(int limite)
{
    for (int i = 0; i <= limite; i++)
    {
        //Console.WriteLine($"NumerosParesComYield, elemento {i}");
        if (i % 2 == 0) yield return i;
    }
}
var paresComYield = NumerosParesComYield(2000); // vai preparar os itens a serem enumerados... 
Console.WriteLine($"\nNumerosParesComYield, com, {paresComYield.Count()} números pares");
foreach (var pares in paresComYield) // ...só executa quando forem percorridos!
{
    Console.Write($"{pares} ");
    //if (contador >= 10) break; // ...e quando necessários (sob demanda; no caso, 10)
}

class DiasDaSemana : IEnumerable<string>
{
    public IEnumerator<string> GetEnumerator()
    {
        //return new DiasDaSemanaEnumerator();// sem yield, precisaríamos criar uma coleção em memória, com todos os itens, exemplo acima!
        // posicao = -1
        //MoveNext(): posicao = 0
        yield return "Domingo"; // Current: array[posicao]
        //MoveNext(): posicao = 1
        yield return "Segunda-feira"; // Current
        //MoveNext(): posicao = 2
        yield return "Terça-feira"; // Current
        yield return "Quarta-feira";
        yield return "Quinta-feira";
        yield return "Sexta-feira";
        yield return "Sábado";
    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
public class Produto
{
    public required string Id { get; set; }
    public required string Nome { get; set; }
    public decimal? Preco { get; set; }
}
public class Musica
{
    public required string Titulo { get; set; }
    public required string Artista { get; set; }
}
/*
 Mas e se quisesse implementar a capacidade de enumeração em uma classe minha?
por exemplo, uma classe DiasDaSemana que representa os dias da semana e eu quero poder usar foreach nela?
aí eu teria que implementar IEnumerable<T> e criar um enumerador que implementa IEnumerator<T>.
onde T é string, porque os dias da semana são strings.
*/
public class DiasDaSemanaEnumerator : IEnumerator<string>
{
    private readonly string[] dias = ["Domingo", "Segunda-feira", "Terça-feira", "Quarta-feira", "Quinta-feira", "Sexta-feira", "Sábado"];
    private int posicao = -1;
    public string Current
    {
        get
        {
            if (posicao < 0 || posicao >= dias.Length)
            {
                throw new InvalidOperationException("Posição inválida.");
            }
            return dias[posicao];
        }
    }
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