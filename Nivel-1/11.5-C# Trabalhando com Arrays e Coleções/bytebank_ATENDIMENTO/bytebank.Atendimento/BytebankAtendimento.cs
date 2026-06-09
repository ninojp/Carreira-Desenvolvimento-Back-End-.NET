using bytebank.Modelos.Conta;
using bytebank_ATENDIMENTO.bytebank.Exceptions;

namespace bytebank_ATENDIMENTO.bytebank.Atendimento;

//#nullable disable, permite que o código seja compilado mesmo que haja referências a tipos anuláveis sem tratamento de nulidade.
#nullable disable
internal class BytebankAtendimento
{
    private List<ContaCorrente> _listaDeContas = new() {
        new ContaCorrente(95, "123456-X") {Saldo=100, Titular = new Cliente("André", "123.456.789-00", "Dev") },
        new ContaCorrente(95, "951258-X") {Saldo=200, Titular = new Cliente("Maria", "987.654.321-00", "Analista") },
        new ContaCorrente(94, "987321-W") {Saldo=60, Titular = new Cliente("João", "456.789.123-00", "Gerente") }
};
    public void AtendimentoCliente()
    {
        try
        {
            char opcao = '0';
            while (opcao != '6')
            {
                Console.Clear();
                Console.WriteLine("===============================");
                Console.WriteLine("===       Atendimento       ===");
                Console.WriteLine("===1 - Cadastrar Conta      ===");
                Console.WriteLine("===2 - Listar Contas        ===");
                Console.WriteLine("===3 - Remover Conta        ===");
                Console.WriteLine("===4 - Ordenar Contas       ===");
                Console.WriteLine("===5 - Pesquisar Conta      ===");
                Console.WriteLine("===6 - Sair do Sistema      ===");
                Console.WriteLine("===============================");
                Console.WriteLine("\n\n");
                Console.Write("Digite a opção desejada: ");
                try
                {
                    opcao = Console.ReadLine()[0];
                }
                catch (Exception excecao)
                {
                    throw new BytebankException(excecao.Message);
                }
                switch (opcao)
                {
                    case '1':
                        CadastrarConta();
                        break;
                    case '2':
                        ListarContas();
                        break;
                    case '3':
                        RemoverContas();
                        break;
                    case '4':
                        OrdenarContas();
                        break;
                    case '5':
                        PesquisarContas();
                        break;
                    case '6':
                        EncerrarAplicao();
                        break;
                    default:
                        Console.WriteLine("Opcao não implementada.");
                        break;
                }
            }
        }
        catch (BytebankException excecao)
        {
            Console.WriteLine($"{excecao.Message}");
        }
    }

    private void EncerrarAplicao()
    {
        Console.WriteLine("Encerrando aplicação...");
        Console.ReadKey();
    }

    private void PesquisarContas()
    {
        Console.Clear();
        Console.WriteLine("===============================");
        Console.WriteLine("===    PESQUISAR CONTAS     ===");
        Console.WriteLine("===============================");
        Console.WriteLine("\n");
        Console.Write("Deseja pesquisar por\n (1) NÚMERO DA CONTA\n(2) CPF TITULAR\n(3) NÚMERO DA AGÊNCIA\n(4)   ");
        switch (int.Parse(Console.ReadLine()))
        {
            case 1:
                {
                    Console.Write("Informe o número da Conta: ");
                    string _numeroConta = Console.ReadLine();
                    ContaCorrente consultaConta = ConsultaPorNumeroConta(_numeroConta);
                    Console.WriteLine(consultaConta.ToString());
                    Console.ReadKey();
                    break;
                }
            case 2:
                {
                    Console.Write("Informe o CPF do Titular: ");
                    string _cpf = Console.ReadLine();
                    ContaCorrente consultaCpf = ConsultaPorCPFTitular(_cpf);
                    Console.WriteLine(consultaCpf.ToString());
                    Console.ReadKey();
                    break;
                }
            case 3:
                {
                    Console.Write("Informe o numero da Agência: ");
                    int _numeroAgencia = int.Parse(Console.ReadLine());
                    var contasPorAgencia = ConsultaPorAgencia(_numeroAgencia);
                    ExibirListaDeContas(contasPorAgencia);
                    Console.ReadKey();
                    break;
                }
            default:
                Console.WriteLine("Opção não implementada.");
                break;
        }
    }

    private void ExibirListaDeContas(List<ContaCorrente> contasPorAgencia)
    {
        if (contasPorAgencia == null || contasPorAgencia.Count == 0)
        {
            Console.WriteLine("... Não há contas para esta agência! ...");
            return;
        }
        else
        {
            foreach (var conta in contasPorAgencia)
            {
                Console.WriteLine(conta.ToString());
            }
        }
    }

    private List<ContaCorrente> ConsultaPorAgencia(int numeroAgencia)
    {
        var consulta = (
            from conta in _listaDeContas
            where conta.Numero_agencia == numeroAgencia
            select conta).ToList();
        return consulta;
    }

    private ContaCorrente ConsultaPorCPFTitular(string? cpf)
    {
        //ContaCorrente conta = null;
        //for (int i = 0; i < _listaDeContas.Count; i++)
        //{
        //    if (_listaDeContas[i].Titular.Cpf.Equals(cpf))
        //    {
        //        conta = _listaDeContas[i];
        //    }
        //}
        //return conta;

        //return _listaDeContas.Where(conta => conta.Titular.Cpf.Equals(cpf)).FirstOrDefault();

        return (from conta in _listaDeContas
                where conta.Titular.Cpf.Equals(cpf)
                select conta).FirstOrDefault();
    }

    private ContaCorrente ConsultaPorNumeroConta(string? numeroConta)
    {
        //ContaCorrente conta = null;
        //for (int i = 0; i < _listaDeContas.Count; i++)
        //{
        //    if (_listaDeContas[i].Conta.Equals(numeroConta))
        //    {
        //        conta = _listaDeContas[i];
        //    }
        //}
        //return conta;
        return _listaDeContas.Where(conta => conta.Conta.Equals(numeroConta)).FirstOrDefault();
    }

    private void OrdenarContas()
    {
        _listaDeContas.Sort();
        Console.WriteLine("... Contas ordenadas por número da conta! ...");
        Console.ReadKey();
    }

    private void RemoverContas()
    {
        Console.Clear();
        Console.WriteLine("===============================");
        Console.WriteLine("===      REMOVER CONTAS     ===");
        Console.WriteLine("===============================");
        Console.WriteLine("\n");
        Console.Write("Informe o número da Conta: ");
        string numeroConta = Console.ReadLine();
        ContaCorrente conta = null;
        foreach (var item in _listaDeContas)
        {
            if (item.Conta.Equals(numeroConta))
            {
                conta = item;
            }
        }
        if (conta != null)
        {
            _listaDeContas.Remove(conta);
            Console.WriteLine("... Conta removida da lista! ...");
        }
        else
        {
            Console.WriteLine(" ... Conta para remoção não encontrada ...");
        }
        Console.ReadKey();
    }

    private void ListarContas()
    {
        Console.Clear();
        Console.WriteLine("===============================");
        Console.WriteLine("===     LISTA DE CONTAS     ===");
        Console.WriteLine("===============================");
        Console.WriteLine("\n");
        if (_listaDeContas.Count <= 0)
        {
            Console.WriteLine("... Não há contas cadastradas! ...");
            Console.ReadKey();
            return;
        }
        foreach (ContaCorrente item in _listaDeContas)
        {
            //Console.WriteLine("===  Dados da Conta  ===");
            //Console.WriteLine("Número da Conta : " + item.Conta);
            //Console.WriteLine("Saldo da Conta : " + item.Saldo);
            //Console.WriteLine("Titular da Conta: " + item.Titular.Nome);
            //Console.WriteLine("CPF do Titular  : " + item.Titular.Cpf);
            //Console.WriteLine("Profissão do Titular: " + item.Titular.Profissao);
            Console.WriteLine(item.ToString());
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
            Console.ReadKey();
        }

    }

    private void CadastrarConta()
    {
        Console.Clear();
        Console.WriteLine("===============================");
        Console.WriteLine("===   CADASTRO DE CONTAS    ===");
        Console.WriteLine("===============================");
        Console.WriteLine("\n");
        Console.WriteLine("=== Informe dados da conta ===");
        //Console.Write("Número da conta: ");
        //string numeroConta = Console.ReadLine();

        Console.Write("Número da Agência: ");
        int numeroAgencia = int.Parse(Console.ReadLine());

        ContaCorrente conta = new ContaCorrente(numeroAgencia);
        Console.WriteLine($"Número da Nova Conta: {conta.Conta}");

        Console.Write("Informe o saldo inicial: ");
        conta.Saldo = double.Parse(Console.ReadLine());

        //Erro aqui...
        //Console.Write("Infome nome do Titular: ");
        //conta.Titular.Nome = Console.ReadLine();

        Console.Write("Infome CPF do Titular: ");
        conta.Titular.Cpf = Console.ReadLine();

        Console.Write("Infome Profissão do Titular: ");
        conta.Titular.Profissao = Console.ReadLine();

        _listaDeContas.Add(conta);
        //_listaDeContas.Add("Testando... ");
        Console.WriteLine("... Conta cadastrada com sucesso! ...");
        Console.ReadKey();
    }

}
