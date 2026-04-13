namespace PraticandoLoops;
internal class BuscandoNome
{
    //Buscando em uma lista - Desafio 4
    public void BuscarUmNome()
    {
        List<string> alunos = new List<string> { "Ana", "Carlos", "Bianca", "João", "Marina" };
        alunos.ForEach(nome => Console.WriteLine($"- {nome}"));
        Console.WriteLine("Digite o nome do aluno:");
        string nomeBusca = Console.ReadLine();
        int indice = 0;
        bool encontrado = false;
        while (indice < alunos.Count)
        {
            if (alunos[indice] == nomeBusca)
            {
                encontrado = true;
                break;
            }
            indice++;
        }
        if (encontrado)
        {
            Console.WriteLine($"Aluno encontrado na posição: {indice}");
        }
        else
        {
            Console.WriteLine("Aluno não está presente na lista");
        }

    }
}
