namespace Aula2FacaComoEuFiz;

internal class Cliente
{
    public string NomeCliente { get; }
    public string EnderecoCliente { get; set; }

    public List<Veiculo> ListaVeiculosCliente = [];
    public Cliente(string nomeCliente, string enderecoCliente)
    {
        NomeCliente = nomeCliente;
        EnderecoCliente = enderecoCliente;
    }
    public void AdicionarVeiculoALista(Veiculo veiculo)
    {
        ListaVeiculosCliente.Add(veiculo);
    }
    public void ExibirInformacoesCliente()
    {
        Console.WriteLine($"Nome: {NomeCliente}");
        Console.WriteLine($"Endereço: {EnderecoCliente}");
        if (ListaVeiculosCliente.Count > 0)
        {
            Console.WriteLine("Veículos do cliente:");
            foreach (var veiculo in ListaVeiculosCliente)
            {
                veiculo.ExibirInformacoesVeiculo();
            }
        }
    }
}