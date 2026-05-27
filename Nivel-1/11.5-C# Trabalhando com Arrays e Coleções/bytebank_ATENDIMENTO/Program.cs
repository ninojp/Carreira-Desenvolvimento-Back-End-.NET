using bytebank.Modelos.Conta;

Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");

#region Exemplos com array de inteiros
//TestaArrayInt();
static void TestaArrayInt()
{
    int[] idades = new int[5];
    idades[0] = 30;
    idades[1] = 25;
    idades[2] = 28;
    idades[3] = 35;
    idades[4] = 22;

    Console.WriteLine($"Tamanho do array: {idades.Length}");
    var acumulador = 0;
    for( int i = 0; i < idades.Length; i++ )
    {
        int idade = idades[i];
        acumulador += idade;
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"Idade na posição {i}: {idades[i]}");
        Console.ResetColor();
    }
    int media = acumulador / idades.Length;
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("Média de idades: " + media);
    Console.ResetColor();
}
#endregion
//=============================================================

#region Exemplo com array de string
//TestaBuscarPalavra();
static void TestaBuscarPalavra()
{
    string[] arrayDePalavras = new string[5];

    for (int i = 0; i < arrayDePalavras.Length; i++)
    {
        Console.Write($"Digite a {i + 1}ª Palavra: ");
        arrayDePalavras[i] = Console.ReadLine();
    }

    Console.Write("Digite a palavra a ser encontrada: ");
    var busca = Console.ReadLine();
    foreach (string palavra in arrayDePalavras)
    {
        if (palavra.Equals(busca))
        {
            Console.WriteLine($"Palavra encontrada = {busca}.");
        }
        break;
    }
}
#endregion
//=============================================================
#region Exemplo com array de double para calcular a mediana
Array amostra = Array.CreateInstance(typeof(double), 5);
amostra.SetValue(5.9, 0);
amostra.SetValue(1.8, 1);
amostra.SetValue(7.1, 2);
amostra.SetValue(10, 3);
amostra.SetValue(6.9, 4);
//TestaMediana(amostra);
void TestaMediana(Array array)
{
    if ((array == null) || (array.Length == 0))
    {
        Console.WriteLine("Array para cálculo da mediana está vazio ou nulo.");
    }

    double[] numerosOrdenados = (double[])array.Clone();
    Array.Sort(numerosOrdenados);
    //[1,8][5,9][6,9][7,1][10]

    int tamanho = numerosOrdenados.Length;
    int meio = tamanho / 2;
    double mediana = (tamanho % 2 != 0) ? numerosOrdenados[meio] : (numerosOrdenados[meio] + numerosOrdenados[meio - 1]) / 2;
    Console.WriteLine($"Com base na amostra a mediana = {mediana}");
}
#endregion
//=============================================================

TestaArrayDeContasCorrentes();
void TestaArrayDeContasCorrentes()
{
    ContaCorrente[] listaDeContas =
    [
        new(874, "5679787-A"),
        new(874, "4456668-B"),
        new(874, "7781438-C")
    ];

    for (int i = 0; i < listaDeContas.Length; i++)
    {
        ContaCorrente contaAtual = listaDeContas[i];
        Console.WriteLine($"Índice{i} - Conta:{contaAtual.Conta}");
    }
}
