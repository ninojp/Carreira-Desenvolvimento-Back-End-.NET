using PraticandoOOEncaps;

Produto produto = new Produto("Notebook", "Ótimo Notebook Gamer", 5000.00m, 10, "http://www.sem.nada.urlDaImagem");
//produto.CriarProduto("Notebook2", "Segundo Notebook Gamer", 3000.00m, 5);
//produto.nome = "Notebook";
//produto.descricao = "Notebook Gamer";
//produto.preco = 5000.00m;
//produto.estoque = 10;
Console.WriteLine("\nAula 1 - Encapsulamento e Modificadores de Acesso");
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine($"\nProduto: {produto.Nome}");
Console.WriteLine($"Descrição: {produto.Descricao}");
Console.WriteLine($"Preço: {produto.Preco}");
Console.WriteLine($"Estoque: {produto.Estoque}");
Console.WriteLine($"URL Imagem: {produto.ImagemUrl}");

Console.WriteLine($"Disponível: {produto.EstaDisponivel()}");
produto.AlterarPrecoComDesconto(0.1m);
Console.WriteLine($"Preço com desconto: {produto.Preco}");
//produto.Preco = 1000.00m;//Erro esperado - não é possível alterar diretamente devido ao private set
Console.WriteLine($"Preço alterado diretamente: {produto.Preco}");
Console.ResetColor();

//Aula 2 - Faça como eu fiz, 1: controle de velocidade
Console.WriteLine("\nAula 2 - Faça como eu fiz, 1: controle de velocidade");
Console.ForegroundColor = ConsoleColor.DarkGreen;
Veiculo veiculo = new("ABC-1234");
veiculo.AtualizarVelocidade(72.5);
Console.WriteLine($"\nVeículo: {veiculo.Placa}");
Console.WriteLine($"Velocidade Atual: {veiculo.VelocidadeAtual} km/h");
Console.ResetColor();

//Aula 2 - Faça como eu fiz, 2: validação de nota mínima
Console.WriteLine("\nAula 2 - Faça como eu fiz, 2: validação de nota mínima");
Console.ForegroundColor = ConsoleColor.DarkGreen;
Avaliacao avaliacao = new Avaliacao("Carla Silva");
Console.WriteLine($"\nAluno: {avaliacao.Aluno}");
Console.WriteLine($"Nota: {avaliacao.Nota}");
var resultado = avaliacao.AtribuirNota(11);   // inválido
Console.WriteLine(resultado);
resultado = avaliacao.AtribuirNota(8.5);  // válido
Console.WriteLine(resultado);
Console.WriteLine($"\nAluno: {avaliacao.Aluno}");
Console.WriteLine($"Nota: {avaliacao.Nota}");
Console.ResetColor();

//Aula 2 - Faça como eu fiz, 3: controlando acesso
Paciente paciente = new Paciente("Luiz Costa", 42);
HistoricoMedico historico = new HistoricoMedico("XPT-9987");
Console.WriteLine("\nAula 2 - Faça como eu fiz, 3: controlando acesso");
Console.ForegroundColor = ConsoleColor.DarkGreen;
historico.ExibirCodigo();
Console.ResetColor();

//Aula 2 - Faça como eu fiz, 4: encapsulando reajuste de salário
Funcionario funcionario = new Funcionario("Fernanda Lima", 4000);
Console.WriteLine("\nAula 2 - Faça como eu fiz, 4: encapsulando reajuste de salário");
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine("Funcionário: " + funcionario.Nome);
Console.WriteLine("Salário Inicial: R$ " + funcionario.Salario.ToString("F2"));

Console.WriteLine("\nTentativa de reajuste para R$ 3500,00:");
funcionario.ReajustarSalario(3500);
Console.WriteLine("Salário atual: R$ " + funcionario.Salario.ToString("F2"));

Console.WriteLine("\nMais uma tentativa de reajuste para R$ 4500,00:");
funcionario.ReajustarSalario(4500);
Console.WriteLine("Salário atual: R$ " + funcionario.Salario.ToString("F2"));

Console.WriteLine("\nMais uma tentativa de reajuste para R$ -500,00:");
funcionario.ReajustarSalario(-500);
Console.WriteLine("Salário atual: R$ " + funcionario.Salario.ToString("F2"));
Console.ResetColor();

//Aula 2 - Faça como eu fiz, 5: controle de tarefas
Console.WriteLine("\nAula 2 - Faça como eu fiz, 5: controle de tarefas");
Console.ForegroundColor = ConsoleColor.DarkGreen;
Projeto projeto = new Projeto("Sistema de Inventário");
projeto.AdicionarTarefa("Criar tela de login");
projeto.AdicionarTarefa("Implementar banco de dados");
projeto.ExibirTarefas();
Console.ResetColor();

//Aula 2 - Faça como eu fiz, 6: validação de saque
Console.WriteLine("\nAula 2 - Faça como eu fiz, 6: validação de saque");
Console.ForegroundColor = ConsoleColor.DarkGreen;
ContaBancaria conta = new ContaBancaria("Carlos Silva", 2500);
conta.Sacar(1500);
conta.Sacar(800);
Console.WriteLine("Saldo atual: R$ " + conta.Saldo.ToString("F2"));
Console.ResetColor();

//Aula 2 - Faça como eu fiz, 7: agenda com controle de contatos duplicados
Console.WriteLine("\nAula 2 - Faça como eu fiz, 7: agenda com controle de contatos duplicados");
Agenda agenda = new Agenda("Marina Souza");
Console.ForegroundColor = ConsoleColor.DarkGreen;
agenda.AdicionarContato(new Contato("Carlos", "11998887777"));
agenda.AdicionarContato(new Contato("Carlos", "11991112222")); // duplicado
agenda.AdicionarContato(new Contato("Julia", "21988776655"));
agenda.ListarContatos();
Console.ResetColor();

//Aula 2 -  Faça como eu fiz, 8: determinando a situação de um estudante com base na média
Console.WriteLine("\nAula 2 -  Faça como eu fiz, 8: determinando a situação de um estudante com base na média");
Console.ForegroundColor = ConsoleColor.DarkGreen;
Estudante estudante = new Estudante("Lucas Rocha");
estudante.Nota1 = 7.5;
estudante.Nota2 = 5.0;
Console.WriteLine("\nEstudante: " + estudante.Nome);
Console.WriteLine("Média: " + estudante.Media.ToString("F2"));
Console.WriteLine("Situação: " + estudante.Situacao);
Console.ResetColor();

//Aula 2 - Faça como eu fiz, 9: controle de matrícula
Console.WriteLine("\nAula 2 - Faça como eu fiz, 9: controle de matrícula");
Console.ForegroundColor = ConsoleColor.DarkGreen;
Curso curso = new Curso("Lógica de Programação", 2);
curso.Matricular(new Estudante("Rafaela"));
curso.Matricular(new Estudante("João"));
curso.Matricular(new Estudante("Mirela")); // excede o limite
curso.ListarMatriculados();
Console.ResetColor();

//Aula 2 - Faça como eu fiz, 10: sistema de reservas em hotel
Console.WriteLine("\nAula 2 - Faça como eu fiz, 10: sistema de reservas em hotel");
Console.ForegroundColor = ConsoleColor.DarkGreen;
Hospede hospede = new Hospede("Juliana Moura");
Quarto quarto = new Quarto(101);
quarto.ValorDiaria = 250;
Reserva reserva = new Reserva(hospede, quarto, 3);
Console.WriteLine("Reserva para: " + reserva.Hospede.Nome);
Console.WriteLine("Quarto: " + reserva.Quarto.Numero);
Console.WriteLine("Valor total: R$ " + reserva.ValorTotal.ToString("F2"));
Console.ResetColor();