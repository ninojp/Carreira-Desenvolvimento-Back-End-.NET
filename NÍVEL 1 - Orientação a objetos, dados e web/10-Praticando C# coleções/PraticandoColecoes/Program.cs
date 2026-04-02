using PraticandoColecoes.Aula1;
//Aula 1: ARRAYS

Console.WriteLine("\nAula 1: Desvendando o código - Desafio 3");
DesvendandoOCodigo desvendar = new();
desvendar.DesvendarCodigo();
//===================================================================
Console.WriteLine("\nAula 1: Ordenando listas - Desafio 2");
OrdenandoLista ordenandoLista = new();
ordenandoLista.OrdenarLista();
//===================================================================
Console.WriteLine("\nAula 1: Somando os valores do array - Desafio 1");
Somando somando = new();
somando.SomarDoacoes();
//===================================================================
void TrabalhandoComArrays()
{
    string[] funcionarios = ["João", "Maria", "Pedro", "Ana", "Carlos"];
    Console.WriteLine($"\nO funcionário na posição 0 é {funcionarios[0]}");
    //Obtendo o Indice de um elemento do array.
    int indice = Array.IndexOf(funcionarios, "Pedro");
    Console.WriteLine($"\nArray.IndexOf(), O funcionário \"Pedro\" está na posição {indice}");
    //Ordenando o array.
    Array.Sort(funcionarios);
    Console.WriteLine("\nArray.Sort(), Funcionários ordenados:");
    foreach (var funcionario in funcionarios)
    {
        Console.WriteLine($""" - {funcionario}""");
    }
    //Copiando um array para outro.
    string[] novoArray = new string[5];
    Array.Copy(funcionarios, novoArray, funcionarios.Length);
    Console.WriteLine("\nArray.Copy(), Novo array:");
    foreach (var funcionario in novoArray)
    {
        Console.WriteLine($""" - {funcionario}""");
    }
    Console.WriteLine("\nArray.Copy(), Novo array após alteração:");
    novoArray[4] = "NovoFuncionário";
    foreach (var funcionario in novoArray)
    {
        Console.WriteLine($""" - {funcionario}""");
    }
}
//TrabalhandoComArrays();