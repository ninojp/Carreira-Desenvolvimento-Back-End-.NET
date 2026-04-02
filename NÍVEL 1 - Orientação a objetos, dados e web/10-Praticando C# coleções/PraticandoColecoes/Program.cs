using PraticandoColecoes.Aula1;

//==========================================================================
//Aula 3: Dicionários - Desafios

Console.WriteLine("\nAula 3: Manipulando dicionários - Desafio 3");
Dictionary<string, string> tarefas = new Dictionary<string, string>()
        {
            { "Refatorar módulo de login", "Ana" },
            { "Testar API de pagamentos", "Pedro" }
        };

tarefas.Clear();

tarefas.Add("Implementar autenticação OAuth", "João");
tarefas.Add("Otimizar consultas SQL", "Maria");
tarefas.Add("Atualizar documentação", "Carlos");

Console.WriteLine("Tarefas do próximo sprint:");
foreach (var tarefa in tarefas)
{
    Console.WriteLine($"- {tarefa.Key}: {tarefa.Value}");
}
//==========================================================================
//Aula 3: Dicionários - Desafios

Console.WriteLine("\nAula 3: Gerenciando itens no inventário - Desafio 2");
Dictionary<int, string> inventario = new Dictionary<int, string>()
        {
            { 1, "Espada Longa" },
            { 2, "Arco Curto" },
            { 3, "Escudo de Ferro" }
        };

Console.WriteLine("Itens no inventário inicial:");
foreach (var item in inventario)
{
    Console.WriteLine($"ID: {item.Key} - {item.Value}");
}

Console.WriteLine("---------------------");

inventario.Remove(2);

inventario.Add(4, "Poção de Vida");

Console.WriteLine("Itens no inventário atualizado:");
foreach (var item in inventario)
{
    Console.WriteLine($"ID: {item.Key} - {item.Value}");
}
//==========================================================================
//Aula 3: Dicionários - Desafios

Console.WriteLine("\nAula 3: Listando os alunos e suas respectivas notas - Desafio 1");
Dictionary<string, double> alunos = new()
{
    { "João", 85.5 },
    { "Maria", 92.0 },
    { "Pedro", 78.0 },
    { "Ana", 88.5 },
    { "Carlos", 90.0 }
};
foreach (KeyValuePair<string, double> aluno in alunos)
{
    Console.WriteLine($"Aluno: {aluno.Key}, Nota: {aluno.Value}");
}
//==========================================================================
/*
//Aula 3: Dicionários - Vídeo 1
Console.WriteLine("\nAula 3: Dicionários - Vídeo 1");
Dictionary<string, string> dicionario = new()
{
    { "Chave1", "Valor1" },
    { "Chave2", "Valor2" },
    { "Chave3", "Valor3" }
};
//------------------------------------------------------------
Dictionary<int, string> produtos = new Dictionary<int, string>
    {
        { 4587963, "Teclado" },
        { 3374561, "Cadeira gamer" },
        { 2456987, "Notebook" },
        { 6356984, "Teclado" },
        { 8647921, "Mouse" },
    };

Console.WriteLine($"\ndicionario[\"Chave2\"], tem o valor: {dicionario["Chave2"]}");

foreach (var item in produtos)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}
//==========================================================================
//Aula 2: Desafio 4
Console.WriteLine("\nAula 2: Consolidando listas de produtos - Desafio 4");
List<string> produtosPrincipal = new List<string> { "Mouse", "Teclado", "Monitor", "Joystick" };

List<string> produtosSecundaria = new List<string> { "Headset", "Webcam", "Smartphone", "Mousepad" };

foreach (string produto in produtosSecundaria)
{
    produtosPrincipal.Add(produto);
}

Console.WriteLine("Lista consolidada:");
foreach (string produto in produtosPrincipal)
{
    Console.WriteLine(produto);
}
//==========================================================================
//Aula 2: Desafio 3
Console.WriteLine("\nAula 2: Manipulando listas - Desafio 3");
List<string> nomes = new List<string> { "Ana", "Carlos", "Mariana", "João", "Lúcia" };
Console.WriteLine("Lista original:");
Console.WriteLine(string.Join(", ", nomes));

nomes.Sort();
Console.WriteLine("\nApós Sort (ordem alfabética):");
Console.WriteLine(string.Join(", ", nomes));

nomes.Reverse();
Console.WriteLine("\nApós Reverse (ordem invertida):");
Console.WriteLine(string.Join(", ", nomes));

string primeiroNome = nomes[0];
nomes.Remove(primeiroNome);
nomes.Add(primeiroNome);
Console.WriteLine("\nApós remover o primeiro e adicioná-lo no fim:");
Console.WriteLine(string.Join(", ", nomes));

Console.WriteLine($"\nA pessoa sorteada foi: {nomes[3]}");
//==========================================================================
//Aula 2: Desafio 2
Console.WriteLine("\nAula 2: Revelando mensagens - Desafio 2");
List<string> Letras = new() { "o", "d", "n", "u", "m", " ", "á", "l", "o" };
Letras.Reverse();
foreach (string letra in Letras)
{
    Console.Write(letra);
}
//====================================================================
//Aula 2: Desafio 1
Console.WriteLine("\nAula 2: Organizando elementos únicos - Desafio 1");
HashSet<int> scores = new() { 150, 90, 120, 80, 180, 200 };
List<int> listaScores = new(scores);
listaScores.Sort();
foreach (int score in listaScores)
{
    Console.WriteLine($"""- {score}""");
}
//====================================================================
//Aula 2: Vídeo 2 - HashSet
//HashSet é uma coleção que armazena elementos únicos, ou seja, não permite duplicatas.
//Ele é baseado em uma tabela hash, o que proporciona uma busca rápida e eficiente.
//O HashSet é útil quando você precisa garantir que não haja elementos duplicados em uma coleção e quando a ordem dos elementos não é importante.

Console.WriteLine("\nAula 2: HashSet - Video 2");
HashSet<string> hashSetFuncionarios = new() { "João", "Maria", "Pedro", "Ana", "Carlos" };
//Adicionando um elemento ao HashSet.
hashSetFuncionarios.Add("NovoFuncionário");
//Removendo um elemento do HashSet.
hashSetFuncionarios.Remove("Carlos");

foreach (string funcionario in hashSetFuncionarios)
{
    Console.WriteLine($""" - {funcionario}""");
}
//====================================================================
//Aula 2: Vídeo 1 - LISTAS

Console.WriteLine("\nAula 2: Listas - Video 1");
List<string> listaFuncionario = new() { "João", "Maria", "Pedro", "Ana", "Carlos" };
Console.WriteLine($"O Elemento no INDICE 2 é: {listaFuncionario[2]}");
Console.WriteLine($"O Índice do elemento \"Ana\" é: {listaFuncionario.IndexOf("Ana")}");
//Ordenando a lista.
listaFuncionario.Sort();
Console.WriteLine($"""Sort(), Lista Ordenada:""");
foreach (string funcionario in listaFuncionario)
{
    Console.WriteLine($"""- {funcionario}""");
}
//Adicionando um elemento à lista.
listaFuncionario.Add("NovoFuncionário");
listaFuncionario.Add("Funcionário");
//Remover um elemento da lista.
listaFuncionario.Remove("Funcionário");
//Invertendo as posições dos elementos da lista.
listaFuncionario.Reverse();

//====================================================================
//Aula 1: ARRAYS

Console.WriteLine("\nAula 1: Desvendando o código - Desafio 3");
DesvendandoOCodigo desvendar = new();
//desvendar.DesvendarCodigo();
//===================================================================
Console.WriteLine("\nAula 1: Ordenando listas - Desafio 2");
OrdenandoLista ordenandoLista = new();
//ordenandoLista.OrdenarLista();
//===================================================================
Console.WriteLine("\nAula 1: Somando os valores do array - Desafio 1");
Somando somando = new();
//somando.SomarDoacoes();
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

*/