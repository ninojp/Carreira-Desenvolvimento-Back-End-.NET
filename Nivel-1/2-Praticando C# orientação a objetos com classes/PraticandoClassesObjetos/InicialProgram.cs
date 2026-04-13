using PraticandoClassesObjetos;
//Aula 1 - Vídeos: 
//Instancia os produtos
//InstanciarProdutos instanciarProdutos = new();
//Cria o obj exibidor de produtos
//ExibeProduto exibeProduto = new();
//Exibi os dados dos produtos com desconto
Console.WriteLine("\nAula 1 - Vídeos");
//exibeProduto.ExibirDadosProduto(instanciarProdutos.ProdutoTeclado, 0.10m);
//exibeProduto.ExibirDadosProduto(instanciarProdutos.ProdutoCadeira, 0.15m);

//Aula 1 - Faça como eu fiz, 1:
Livro meuLivro = new Livro("Dom Casmurro", "Machado de Assis");
Console.WriteLine("\nAula 1 - Faça como eu fiz, 1:");
Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine($"\nO Livro: {meuLivro.Titulo}, é do autor {meuLivro.Autor}");
Console.ResetColor();

//Aula 1 - Faça como eu fiz, 2: emissão de passagem de viagem:
Passagem passagem = new Passagem("João", "Rio de Janeiro");
Console.WriteLine("\nAula 1 - Faça como eu fiz, 2: emissão de passagem de viagem");
Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine($"\nO passageiro: {passagem.Passageiro}, tem como destino {passagem.Destino}");
Console.ResetColor();

//Aula 1 - Faça como eu fiz, 3: criando uma classe conta bancária
ContaBancaria contaBancaria = new ContaBancaria(12345, 1000.00m);
contaBancaria.Depositar(500.00m);
Console.WriteLine("\nAula 1 - Faça como eu fiz, 3: criando uma classe conta bancária");
Console.ForegroundColor = ConsoleColor.DarkYellow;
contaBancaria.ExibirDadosContaBancaria();
Console.ResetColor();

//Aula 1 - Faça como eu fiz: gerenciamento de funcionários
Funcionario funcionario = new Funcionario("Maria", "Analista de Sistemas");
Console.WriteLine("\nAula 1 - Faça como eu fiz, 3: criando uma classe conta bancária");
Console.ForegroundColor = ConsoleColor.DarkYellow;
funcionario.ExibirDadosFuncionario();
funcionario.Promover("Analista de Sistemas");
funcionario.Promover("Gerente de Projetos");
funcionario.ExibirDadosFuncionario();
Console.ResetColor();

//Aula 1 - Faça como eu fiz, 4: representando retângulos e calculando área
Retangulo retangulo = new(5, 8);
Console.WriteLine("\nAula 1 - Faça como eu fiz, 4: representando retângulos e calculando área");
Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine($"\nO retângulo tem altura {retangulo.Altura} e largura {retangulo.Largura}");
Console.WriteLine($"A área do retângulo é {retangulo.CalcularArea()}");
Console.ResetColor();

//Aula 1 - Faça como eu fiz, 5: validação de acesso a filmes
Filme filme = new Filme("Matrix", 16);
Console.WriteLine("\nAula 1 - Faça como eu fiz, 5: validação de acesso a filmes");
Console.ForegroundColor = ConsoleColor.DarkYellow;
filme.ExibirResultado(14);
filme.ExibirResultado(20);
Console.ResetColor();

//Aula 1 - Faça como eu fiz, 6: controle de estoque
Produto produto = new Produto("Notebook", 2750.00m, 10);
Console.WriteLine("\nAula 1 - Faça como eu fiz, 6: controle de estoque");
Console.ForegroundColor = ConsoleColor.DarkYellow;
produto.ExibirEstoque();
Console.WriteLine(produto.Descricao);
produto.Retirar(2);
produto.ExibirEstoque();
produto.Retirar(10);
Console.ResetColor();

//Aula 1 -  Faça como eu fiz, 7: representando um pedido de compra
Pedido pedido = new Pedido("001", "Ana Silva", "Pendente");
Console.WriteLine("\nAula 1 -  Faça como eu fiz, 7: representando um pedido de compra");
Console.ForegroundColor = ConsoleColor.DarkYellow;
pedido.ExibirDetalhesPedido();
pedido.AtualizarStatus("Enviado");
pedido.ExibirDetalhesPedido();
Console.ResetColor();

//Aula 1 - Faça como eu fiz, 8: agendamento médico
Consulta consulta = new Consulta("João Lima", "Dra. Renata", new DateTime(2026, 2, 23));
Console.WriteLine("\nAula 1 - Faça como eu fiz, 8: agendamento médico");
Console.ForegroundColor = ConsoleColor.DarkYellow;
consulta.ExibirDetalhesConsulta();
consulta.ReagendarConsulta(new DateTime(2025, 5, 25));
Console.WriteLine("Reagendando consulta...");
consulta.ExibirDetalhesConsulta();
Console.ResetColor();

//Aula 1 - Faça como eu fiz, 9: modelando um produto digital com informações técnicas
InformacaoTecnica informacaoTecnica = new InformacaoTecnica(128, "Android 12");
ProdutoDigital produtoDigital = new ProdutoDigital("Aplicativo de Edição de Fotos", 19.99m, informacaoTecnica);
Console.WriteLine("\nAula 1 - Faça como eu fiz, 9: modelando um produto digital com informações técnicas");
Console.ForegroundColor = ConsoleColor.DarkYellow;
produtoDigital.ExibirDetalhes();
Console.ResetColor();