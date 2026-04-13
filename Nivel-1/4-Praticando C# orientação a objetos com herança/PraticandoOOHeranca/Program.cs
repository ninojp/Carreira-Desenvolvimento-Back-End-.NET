using PraticandoOOHeranca;
//Curso Alura - Praticando C# orientação a objetos com herança
//Aula 1 - Criando e instanciando a classe base Produto
ProdutoFisico item1 = new ProdutoFisico("Teclado", "Modelo compacto e silencioso, " +
    "perfeito para produtividade diária.",
    80.00m, "Imagem");
Console.WriteLine("\nAula 1 - Criando e instãnciando a classe base Produto");
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine($"\nProduto Físico: {item1.Nome}");
Console.WriteLine($"Descrição: {item1.Descricao}");
Console.WriteLine($"Preço: R${item1.Preco}");
Console.WriteLine($"Disponível: {(item1.EstaDisponivel() ? "Sim" : "Não")}");
Console.WriteLine($"Imagem: {item1.Imagem}");

ProdutoDigital item2 = new ProdutoDigital("Curso", "Curso Orientação a Objetos em C#", 100.00m, "Imagem ilustrativa", "Link para download");
Console.WriteLine($"\nProduto Digital: {item2.Nome}");
Console.WriteLine($"Imagem: {item2.Imagem}");
Console.WriteLine($"Descrição: {item2.Descricao}");
Console.WriteLine($"Preço: R${item2.Preco}");
Console.WriteLine($"Link Para Download: {item2.LinkDownload}");
Console.WriteLine($"Status: {(item2.EstaExpirado() ? "Expirado" : "Válido")}");
Console.ResetColor();

//Aula 2 - Interfaces e implementação
Pedido pedido1 = new Pedido(1, "João Silva", 180.00m);
Console.WriteLine($"\nAula 2 - Interfaces e implementação");
Console.ForegroundColor = ConsoleColor.DarkGreen;
pedido1.ExibirResumo();
Console.ResetColor();

//Aula 3 - Composição e Encapsulamento
Console.WriteLine($"\nAula 3 - Composição e Encapsulamento");
Console.ForegroundColor = ConsoleColor.DarkGreen;
item1.Avaliar(9, "Excelente produto, superou minhas expectativas!");
Console.WriteLine($"Nota: {item1.Avalicao.Nota}");
Console.WriteLine($"Comentário: {item1.Avalicao.Comentario}");
Console.ResetColor();

//Aula 3 - Faça como eu fiz 1
Console.WriteLine($"\nAula 3 - Faça como eu fiz 1");
Console.ForegroundColor = ConsoleColor.DarkGreen;
ClienteVIP cliente1 = new ClienteVIP("Renata", 32, "Ouro", "VIP123A");
ClienteVIP cliente2 = new ClienteVIP("Leonardo", 40, "Diamante", "VIP789X");
Console.WriteLine("\nCliente VIP 1:");
cliente1.Apresentar();
Console.WriteLine("\nCliente VIP 2:");
cliente2.Apresentar();
Console.ResetColor();

//Aula 3 - Faça como eu fiz 2
Console.WriteLine($"\nAula 3 - Faça como eu fiz 2");
Console.ForegroundColor = ConsoleColor.DarkGreen;
Interno f1 = new Interno("Luciana", "Desenvolvedora", 7000.00m);
Freelancer f2 = new Freelancer("Carlos", "Designer", 3500.00m);
Console.WriteLine($"Funcionária {f1.Nome} – Cargo: {f1.Cargo} – Salário: R$ {f1.Salario}");
Console.WriteLine($"Freelancer {f2.Nome} – Cargo: {f2.Cargo} – Projeto atual: R$ {f2.ValorProjeto}");
Console.ResetColor();

//Aula 3 - Faça como eu fiz 3
Console.WriteLine($"\nAula 3 - Faça como eu fiz 3");
Console.ForegroundColor = ConsoleColor.DarkGreen;
Passageiro p1 = new Passageiro("Lúcia", 45, 3);
Passageiro p2 = new Passageiro("Rodrigo", 30, 1);
p1.ExibirInformacoes();
p2.ExibirInformacoes();
Console.ResetColor();

//Aula 3 - Faça como eu fiz 4
Console.WriteLine($"\nAula 3 - Faça como eu fiz 4");
Console.ForegroundColor = ConsoleColor.DarkGreen;
Analista analista = new Analista("Analista de Sistemas");
Docente docente = new Docente("Docente de Matemática");
Certificado certf1 = new Certificado(analista);
Certificado certf2 = new Certificado(docente);
Console.ResetColor();

//Aula 3 - Faça como eu fiz 5
Console.WriteLine($"\nAula 3 - Faça como eu fiz 5");
Console.ForegroundColor = ConsoleColor.DarkGreen;
Pergaminho pergaminhoAntigo = new Pergaminho("Segredos_Antigos.txt", "A chave para a sabedoria reside na observação...");
pergaminhoAntigo.MostrarDetalhes();
Console.ResetColor();

//Aula 3 - Faça como eu fiz 6
Console.WriteLine($"\nAula 3 - Faça como eu fiz 6");
Console.ForegroundColor = ConsoleColor.DarkGreen;
SensorTemperatura sensorTemp = new SensorTemperatura();
sensorTemp.Ativar();
sensorTemp.LerTemperatura();
sensorTemp.Desativar();

SensorPresenca sensorPresenca = new SensorPresenca();
sensorPresenca.Ativar();
sensorPresenca.DetectarPresenca();
sensorPresenca.Desativar();
Console.ResetColor();

//Aula 3 - Faça como eu fiz, 7: montagem de computadores
Console.WriteLine($"\nAula 3 - Faça como eu fiz, 7: montagem de computadores");
Console.ForegroundColor = ConsoleColor.DarkGreen;
Processador cpu = new Processador("Intel", "i7-12700K");

 
PlacaMae mobo = new PlacaMae("ASUS", "LGA1700");
Computador pc = new Computador(cpu, mobo);
pc.ExibirConfiguracao();
Console.ResetColor();

//Aula 3 - Faça como eu fiz, 8: sistema de pagamentos
Console.WriteLine($"\nAula 3 - Faça como eu fiz, 8: sistema de pagamentos");
Console.ForegroundColor = ConsoleColor.DarkGreen;
PagamentoBoleto boleto = new PagamentoBoleto("João Silva", 30);
PagamentoCredito credito = new PagamentoCredito("Maria Souza", 28, "maria.souza@example.com");
boleto.ProcessarPagamento(150.00m);
credito.ProcessarPagamento(200.00m);
Console.ResetColor();

//Aula 3 - Faça como eu fiz, 9: gestão de serviços
Console.WriteLine($"\nAula 3 - Faça como eu fiz, 9: gestão de serviços");
Console.ForegroundColor = ConsoleColor.DarkGreen;
Funcionario func1 = new Funcionario("Ana", 30, "Manutenção", "Técnica");
Funcionario func2 = new Funcionario("Bruno", 35, "Consultoria", "Consultor");
Manutencao manutencao = new Manutencao("Atualização de Software", func1);
Consultoria consultoria = new Consultoria("Planejamento estratégico", func2);
manutencao.ExecutarServico();
consultoria.ExecutarServico();
Console.ResetColor();

//Aula 3 - Faça como eu fiz, 10: Plataforma de cursos
Console.WriteLine($"\nAula 3 - Faça como eu fiz, 10: Plataforma de cursos");
Console.ForegroundColor = ConsoleColor.DarkGreen;
Instrutor instrutor1 = new Instrutor("Carla", 30, "Back-end");
//Usando a interface ICurso para instanciar cursos de programação e design, demonstrando polimorfismo
ICurso curso1 = new CursoProgramacao("Curso de C# com POO", instrutor1);
curso1.PublicarCurso();
curso1.ValidarConteudo();
Instrutor instrutor2 = new Instrutor("Felipe", 44, "UI/UX");
ICurso curso2 = new CursoDesign("Design de Interfaces", instrutor2);
curso2.PublicarCurso();
curso2.ValidarConteudo();
Console.ResetColor();
