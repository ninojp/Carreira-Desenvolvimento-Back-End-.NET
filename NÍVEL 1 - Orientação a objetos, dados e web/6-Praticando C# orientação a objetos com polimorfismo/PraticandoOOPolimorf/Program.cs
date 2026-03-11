using PraticandoOOPolimorf;

//Aula 2 - Faça como eu fiz, 1: calculadora com sobrecarga de método
Console.WriteLine("\nAula 2 - Faça como eu fiz, 1: calculadora com sobrecarga de método");
Calculadora calc = new Calculadora();
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine(calc.SomarSobrecarregado(2, 3));
Console.WriteLine(calc.SomarSobrecarregado(2, 3, 4));
Console.WriteLine(calc.SomarSobrecarregado(2.5, 3.5));
Console.ResetColor();

//Aula 2 - Faça como eu fiz, 2: relatório de funcionários
Console.WriteLine("\nAula 2 - Faça como eu fiz, 2: relatório de funcionários");
Funcionario funcionario = new Funcionario();
Funcionario funcionarioGerente = new Gerente();
Funcionario funcionarioDesenvolvedor = new Desenvolvedor();
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine(funcionario.GerarRelatorio());
Console.WriteLine(funcionarioGerente.GerarRelatorio());
Console.WriteLine(funcionarioDesenvolvedor.GerarRelatorio());
Console.ResetColor();

//Aula 2 - Faça como eu fiz, 3: notificações de sistema
Console.WriteLine("\nAula 2 - Faça como eu fiz, 3: notificações de sistema");
List<INotificacao> notificacoes = new List<INotificacao>
{
    new EmailNotificacao(),
    new SmsNotificacao(),
    new PushNotificacao()
};
foreach (var notificacao in notificacoes)
{
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine(notificacao.EnviarMensagem("Sistema fora do ar!"));
    Console.ResetColor();
}

//Aula 2 - Faça como eu fiz, 4: execução de tarefas agendadas
Console.WriteLine("\nAula 2 - Faça como eu fiz, 4: execução de tarefas agendadas");
List<TarefaAgendada> ListaTarefas = new List<TarefaAgendada>
{
    new BackupTarefa(),
    new RelatorioTarefa(),
    new LimpezaTarefa()
};
foreach (var tarefa in ListaTarefas)
{
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    tarefa.Executar();
    Console.ResetColor();
}

//Aula 2 - Faça como eu fiz, 5: exibindo mídias
Console.WriteLine("\nAula 2 - Faça como eu fiz, 5: exibindo mídias");
List<Midia> listaMidias = new List<Midia>
{
    new Imagem("Foto de Praia", "1920x1080"),
    new Video("Vídeo de Viagem", 120)
};
foreach (var midia in listaMidias)
{
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    midia.ExibirDetalhes();
    Console.ResetColor();
}

//Aula 2 - Faça como eu fiz, 6: reservas de experiências
Console.WriteLine("\nAula 2 - Faça como eu fiz, 6: reservas de experiências");
List<Reserva> listaReservas = new List<Reserva>
{
    new ReservaPresencial("Tour pela Cidade"),
    new ReservaOnline("Aula de Culinária Online")
};
foreach (var reserva in listaReservas)
{
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    reserva.Confirmar();
    Console.ResetColor();
}

//Aula 2 - Faça como eu fiz, 7: avaliação de conteúdos em uma plataforma
Console.WriteLine("\nAula 2 - Faça como eu fiz, 7: avaliação de conteúdos em uma plataforma");
List<Conteudo> listaConteudos = new List<Conteudo>
{
    new AulaGravada("Aula de C# para Iniciantes", 60),
    new MaterialComplementar("E-book de C#", "Um guia completo para aprender C#")
};
foreach (var conteudo in listaConteudos)
{
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    conteudo.ExibirInfo();
    Console.ResetColor();
}

//Aula 2 - Faça como eu fiz ,8: simulador de transporte urbano
Console.WriteLine("\nAula 2 - Faça como eu fiz, 8: simulador de transporte urbano");
List<Transporte> opcoes = new List<Transporte>
{
    new Onibus(),
    new Metro(),
    new Bicicleta()
};
int distancia = 10;
foreach (var transporte in opcoes)
{
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine($"{transporte.GetType().Name}: {transporte.CalcularTempo(distancia)} min");
    Console.ResetColor();
}

//Aula 2 - Faça como eu fiz, 9: cálculo de juros para diferentes perfis de empréstimo
Console.WriteLine("\nAula 2 - Faça como eu fiz, 9: cálculo de juros para diferentes perfis de empréstimo");
List<IEmprestimo> perfis = new List<IEmprestimo>
{
    new EmprestimoEstudante(),
    new EmprestimoEmpresario(),
    new EmprestimoAposentado()
};
foreach (var perfil in perfis)
{
    decimal total = perfil.CalcularValorFinal(1000m, 12);
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine($"{perfil.GetType().Name}: R${total:0.00}");
    Console.ResetColor();
}

//Aula 2 - Faça como eu fiz, 10: ações em botões de interface gráfica
Console.WriteLine("\nAula 2 - Faça como eu fiz, 10: ações em botões de interface gráfica");
List<IAcaoBotao> acoes = new List<IAcaoBotao>
{
    new SalvarAcao(),
    new EditarAcao(),
    new ExcluirAcao()
};
foreach (var acao in acoes)
{
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    acao.Executar();
    Console.ResetColor();
}