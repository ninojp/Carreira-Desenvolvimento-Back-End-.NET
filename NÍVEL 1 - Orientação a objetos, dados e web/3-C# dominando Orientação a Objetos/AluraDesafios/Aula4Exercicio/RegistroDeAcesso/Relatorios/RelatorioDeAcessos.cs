namespace AluraDesafios.Aula4Exercicio.RegistroDeAcesso.Relatorios;

internal class RelatorioDeAcessos
{
    private List<AcessoAoPredio> acessos = new();

    public void RegistrarEntrada(string resumo)
    {
        acessos.Add(new AcessoAoPredio(DateTime.Now, resumo));
    }

    public void ExibirRegistroDoMes()
    {
        Console.WriteLine("Acessos registrados no mês:");
        foreach (var acesso in acessos)
        {
            Console.WriteLine($"- {acesso.Resumo} em {acesso.Entrada}");
        }
    }
}
