using bytebank.Modelos.Conta;
using bytebank_ATENDIMENTO.bytebank.Atendimento;
using bytebank_ATENDIMENTO.bytebank.Util;

Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");

new BytebankAtendimento().AtendimentoCliente();

#region Exemplos Arrays em C#
//TestaArrayInt();
//TestaBuscarPalavra();

void TestaArrayInt()
{
    int[] idades = new int[5];
    idades[0] = 30;
    idades[1] = 40;
    idades[2] = 17;
    idades[3] = 21;
    idades[4] = 18;

    Console.WriteLine($"Tamanho do Array {idades.Length}");

    int acumulador = 0;
    for (int i = 0; i < idades.Length; i++)
    {
        int idade = idades[i];
        Console.WriteLine($"índice [{i}] = {idade}");
        acumulador += idade;
    }

    int media = acumulador / idades.Length;
    Console.WriteLine($"Média de idades = {media}");
}

void TestaBuscarPalavra()
{
    string[] arrayDePalavras = new string[5];

    for (int i = 0; i < arrayDePalavras.Length; i++)
    {
        Console.Write($"Digite {i + 1}ª Palavra: ");
        arrayDePalavras[i] = Console.ReadLine();
    }

    Console.Write("Digite palavara a ser encontrada: ");
    var busca = Console.ReadLine();

    foreach (string palavra in arrayDePalavras)
    {
        if (palavra.Equals(busca))
        {
            Console.WriteLine($"Palavra encontrada = {busca}.");
            break;
        }
    }

}

//[5,9][1,8][7,1][10][6,9]
//Array amostra = Array.CreateInstance(typeof(double), 5);
Array amostra = new double[5];
amostra.SetValue(5.9, 0);
amostra.SetValue(1.8, 1);
amostra.SetValue(7.1, 2);
amostra.SetValue(10, 3);
amostra.SetValue(6.9, 4);

///TestaMediana(amostra);

void TestaMediana(Array array)
{
    if ((array == null) || (array.Length == 0))
    {
        Console.WriteLine("Array para cálculo da  mediana está vazio ou nulo.");
    }

    //Mediana
    double[] numerosOrdenados = (double[])array.Clone();

    Array.Sort(numerosOrdenados);
    //[1,8][5,9][6,9][7,1][10]

    int tamanho = numerosOrdenados.Length;
    int meio = tamanho / 2;
    double mediana = (tamanho % 2 != 0) ? numerosOrdenados[meio] : (numerosOrdenados[meio] +
        numerosOrdenados[meio - 1]) / 2;

    Console.WriteLine($"Com base na amostra a mediana = {mediana}.");
}

void TestaArrayDeContasCorrentes()
{

    ListaDeContasCorrentes listaDeContas = new ListaDeContasCorrentes();
    listaDeContas.Adicionar(new ContaCorrente(874, "5679787-A"));
    listaDeContas.Adicionar(new ContaCorrente(874, "4456668-B"));
    listaDeContas.Adicionar(new ContaCorrente(874, "7781438-C"));
    listaDeContas.Adicionar(new ContaCorrente(874, "7781438-C"));
    listaDeContas.Adicionar(new ContaCorrente(874, "7781438-C"));
    listaDeContas.Adicionar(new ContaCorrente(874, "7781438-C"));
    var contaDoAndre = new ContaCorrente(963, "123456-X");
    listaDeContas.Adicionar(contaDoAndre);
    //listaDeContas.ExibeLista();
    //Console.WriteLine("============");
    //listaDeContas.Remover(contaDoAndre);
    //listaDeContas.ExibeLista();

    for (int i = 0; i < listaDeContas.Tamanho; i++)
    {
        ContaCorrente conta = listaDeContas[i];
        Console.WriteLine($"Indice [{i}] = {conta.Conta}/{conta.Numero_agencia}");
    }

}

//TestaArrayDeContasCorrentes();
#endregion
//====================
#region Exemplos de Generics em C#
//Generica<int> teste1 = new();
//teste1.MostrarMensagem(123);
//Generica<string> teste2 = new();
//teste2.MostrarMensagem("Olá, mundo!");
//public class Generica<T>
//{
//    public void MostrarMensagem(T valor)
//    {
//        Console.WriteLine($"Valor: {valor}");
//    }
//}
#endregion
//=========================
#region Exemplos de List<T> em C#
//List<ContaCorrente> _listaDeContas2 = new()
//{
//    new ContaCorrente(874, "5679787-A"),
//    new ContaCorrente(874, "4456668-B"),
//    new ContaCorrente(874, "7781438-C")
//};
//List<ContaCorrente> _listaDeContas3 = new List<ContaCorrente>()
//{
//    new ContaCorrente(951, "5679787-E"),
//    new ContaCorrente(321, "4456668-F"),
//    new ContaCorrente(719, "7781438-G")
//};
//AddRange() é um método da classe List<T> que permite adicionar uma coleção de elementos a uma lista existente. Ele recebe como parâmetro uma coleção (como outra lista, um array ou qualquer objeto que implemente IEnumerable<T>) e adiciona todos os elementos dessa coleção à lista atual. No exemplo abaixo, estamos usando AddRange() para adicionar os elementos da lista _listaDeContas3 à lista _listaDeContas2:
//_listaDeContas2.AddRange(_listaDeContas3);

//for(int i = 0; i < _listaDeContas2.Count; i++)
//{
//    Console.WriteLine($"Indice [{i}]: {_listaDeContas2[i].Conta}");
//}
//==================================================================
//GetRange() é um método da classe List<T> que permite obter uma sublista de elementos a partir de uma lista existente. Ele recebe dois parâmetros: o índice inicial (zero-based) e o número de elementos a serem incluídos na sublista. O método retorna uma nova lista contendo os elementos especificados. No exemplo abaixo, estamos usando GetRange() para obter os primeiros dois elementos da lista _listaDeContas3 e armazená-los em uma nova lista chamada range:
//var range = _listaDeContas3.GetRange(0, 2);
//for(int i = 0; i < range.Count; i++)
//{
//    Console.WriteLine($"Indice [{i}] = Conta {range[i].Conta}");
//}
//==================================================================
//Reverse() é um método da classe List<T> que inverte a ordem dos elementos em uma lista. Ele não recebe parâmetros e modifica a lista original, ou seja, os elementos são rearranjados de forma que o primeiro elemento se torna o último, o segundo elemento se torna o penúltimo, e assim por diante. No exemplo abaixo, estamos usando Reverse() para inverter a ordem dos elementos na lista _listaDeContas2:
//_listaDeContas2.AddRange(_listaDeContas3);
//_listaDeContas2.Reverse();
//for (int i = 0; i < _listaDeContas2.Count; i++)
//{
//    Console.WriteLine($"Indice [{i}]: {_listaDeContas2[i].Conta}");
//}
//==================================================================

//Clear() é um método da classe List<T> que remove todos os elementos de uma lista, deixando-a vazia. Ele não recebe parâmetros e modifica a lista original, ou seja, após chamar Clear(), a lista terá uma contagem de elementos igual a zero. No exemplo abaixo, estamos usando Clear() para remover todos os elementos da lista _listaDeContas2:
//_listaDeContas2.Clear();
//for (int i = 0; i < _listaDeContas2.Count; i++)
//{
//    Console.WriteLine($"Indice [{i}]: {_listaDeContas2[i].Conta}");
//}
#endregion
//========================

