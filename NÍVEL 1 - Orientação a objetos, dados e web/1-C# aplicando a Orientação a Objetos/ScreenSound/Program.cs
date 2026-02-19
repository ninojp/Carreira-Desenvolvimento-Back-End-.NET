using ScreenSound;
using ScreenSound.exercicios;

void ExibirLogo()
{
    Console.BackgroundColor = ConsoleColor.DarkGreen;
    Console.ForegroundColor = ConsoleColor.Black;
    Console.WriteLine(" Curso Alura C#: aplicando a Orientação a Objetos ");
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine(@"
                ░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
                ██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
                ╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
                ░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
                ██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
                ╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
    Console.ResetColor();
}
ExibirLogo();
//==============================
/*****************************************************************************
 * Aulas 1 e 2: Orientação a Objetos - conceitos básicos
Musica musica1 = new Musica();
musica1.Nome = "Roxane";
musica1.Artista = "The Police";
musica1.Duracao = 273;
//musica1.EscreveDisponivel(true);
musica1.Disponivel = true;
Console.WriteLine($"\n O nome do artista é {musica1.Artista} e sua musica: {musica1.Nome}");
Console.ForegroundColor = ConsoleColor.DarkYellow;
//Console.WriteLine(musica1.LeDisponivel());
Console.WriteLine(musica1.Disponivel);
musica1.ExibirFichaTecnica();
//musica1.DescricaoResumida = "qualquer coisa";
Console.WriteLine(musica1.DescricaoResumida);
Console.ResetColor();

Musica musica2 = new Musica();
musica2.Nome = "Vertigo";
musica2.Artista = "U2";
musica2.Duracao = 367;
//musica2.EscreveDisponivel(false);
Console.WriteLine($"\n O nome do artista é {musica2.Artista} e sua musica: {musica2.Nome}");
Console.ForegroundColor = ConsoleColor.DarkYellow;
//Console.WriteLine(musica2.LeDisponivel());
Console.WriteLine(musica2.Disponivel);
musica2.ExibirFichaTecnica();
Console.ResetColor();
*/
//===========================================================================================
//Aula 3

//Instância os objetos, a partir das classes e atribui seus valores.
Genero generoRock = new()
{
    NomeGenero = "Rock"
};
//-----------------------------
Artista artistaQueen = new()
{
    NomeArtista = "Queen"
};
//---------------------------------
Album albumQueen = new()
{
    NomeDoAlbum = "A Night at the Opera"
};
//----------------------------------------------
Musica musica1 = new()
{
    NomeDaMusica = "Love of My Life",
    Duracao = 217,
    Genero = generoRock
};
//-----------------------------------
Musica musica2 = new()
{
    NomeDaMusica = "Bohemian Rhapsody",
    Duracao = 354,
    Genero = generoRock
};
//Popula os objetos com os relacionamentos entre eles, utilizando os métodos e propriedades criados nas classes.
artistaQueen.AdicionarAlbumAoArtista(albumQueen);
albumQueen.Artista = artistaQueen;
albumQueen.AdicionarMusica(musica1);
albumQueen.AdicionarMusica(musica2);
//Exibe as informações do álbum, incluindo o nome do álbum, o nome do artista, a lista de músicas e a duração total do álbum.
Console.ForegroundColor = ConsoleColor.DarkYellow;
artistaQueen.ExibirArtistaEAlbuns();
albumQueen.ExibirDetalhesDoAlbum();
Console.ResetColor();

//Aula 3 - Desafio:
//Crie uma classe chamada Genero, que armazena o nome do gênero musical,
//e crie um relacionamento desta nova classe em nossa aplicação.


/***********************************************************************************************************
//Exercícios da aula 1.

//1. Criar uma classe que representa uma conta bancária, com um número indicador, titular, saldo e senha.
Console.WriteLine($"\nExercícios da aula 1.\n1. Criar uma classe que representa uma conta bancária, com um número indicador, titular, saldo e senha.");

//===========================================================================================

//2. Criar um objeto do tipo Conta, adicionar dados e mostrar as informações titular e saldo no console, utilizando interpolação de strings.
ContaBancaria novaContaBancaria = new ContaBancaria();
novaContaBancaria.titular = "Maria";
novaContaBancaria.numeroIndicador = 12345;
novaContaBancaria.saldo = 1000.50m;
novaContaBancaria.senha = "senha123";
Console.WriteLine($"\n2. Criar um objeto do tipo Conta, adicionar dados e mostrar as informações titular e saldo no console, utilizando interpolação de strings.");
Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine($"Titular: {novaContaBancaria.titular}, Saldo: {novaContaBancaria.saldo}");
Console.ResetColor();
//===========================================================================================

//3. Desenvolver um método da classe Conta que exibe suas informações.
Console.WriteLine($"\n3. Desenvolver um método da classe Conta que exibe suas informações.");
Console.ForegroundColor = ConsoleColor.DarkYellow;
novaContaBancaria.exibirDados();
Console.ResetColor();
//===========================================================================================

//Exercícios da aula 2.
Carros carro1 = new Carros();
carro1.FabricantePropriedade = "BMW";
carro1.ModeloPropriedade = "Sport";
carro1.AnoPropriedade = 1981;
//4. Desenvolver uma classe que modele um carro, e que contenha os métodos acelerar, frear e buzinar
Console.WriteLine($"\nAula 1: 4. Desenvolver uma classe que modele um carro, e que contenha os métodos acelerar, frear e buzinar");
//2. Reescrever os atributos da classe Carro, de modo que eles sejam properties,
//e adicionar uma nova propertie DescricaoDetalhada, que mostra o fabricante, modelo e ano do carro.
Console.WriteLine($"\nAula 2: 2. Reescrever os atributos da classe Carro, de modo que eles sejam properties");
Console.ForegroundColor = ConsoleColor.DarkYellow;
carro1.Acelerar();
carro1.Frear();
carro1.Buzinar();
Console.WriteLine(carro1.DescricaoDetalhada);
Console.ResetColor();
//===========================================================================================

//Aula 2 - Para saber mais: funções lambda
Lambdas Novaslambidas = new Lambdas();
Console.WriteLine($"\nAula 2 - Para saber mais: funções lambda");
Console.ForegroundColor = ConsoleColor.DarkYellow;
Novaslambidas.FuncaoSemLambda();
Novaslambidas.FuncaoComLambda();
Novaslambidas.SomarComLambda(5, 3);
Console.ResetColor();
//===========================================================================================

//Aula 2: Exercício, 4. Desenvolver a classe Produto, com os atributos nome, marca, preco e estoque.
Produto produto1 = new Produto();
produto1.NomePropriedade = "Notebook";
produto1.MarcaPropriedade = "Dell";
produto1.PrecoPropriedade = 5000.00m;
produto1.EstoquePropriedade = 10;
Console.WriteLine($"\nAula 2: Exercício, 4. Desenvolver a classe Produto, com os atributos nome, marca, preco e estoque.");
Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine(produto1.DescricaoProduto);
Console.ResetColor();
//===========================================================================================

//Aula 3:
//1. Modelar uma classe Conta, que tenha como atributos uma classe Titular, além de informações da conta,
//como agência, número da conta, saldo e limite, bem como um método que devolva as informações da conta de forma detalhada.
Console.WriteLine($"\nAula 3: 1. Modelar uma classe Conta, que tenha como atributos uma classe Titular...");

//===========================================================================================

//2. Instanciar um objeto do tipo Conta e um do tipo Titular e mostrar as informações de Titular, a partir da Conta.
ContaBancaria novaContaBancaria = new ContaBancaria();
novaContaBancaria.NumeroDaConta = 12345;
novaContaBancaria.Agencia = 6789;
novaContaBancaria.Limite = 5000.00;
novaContaBancaria.Saldo = 1000.50m;
novaContaBancaria.Senha = "senha123";
novaContaBancaria.TitularDaConta = new Titular
{
    NomeDoTitular = "Maria",
    Sobrenome = "Silva",
    CPF = "123.456.789-00",
    Endereco = "Rua das Flores, 123",
};
Console.WriteLine($"\nAula 3: 2. Instanciar, Conta e Titular. Mostrar informações Titular, a partir da Conta.\n");
Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine(novaContaBancaria.ExibirInformacoes);
Console.ResetColor();
//===========================================================================================

//3. Desenvolver uma classe que represente um estoque de produtos, e que tenha as funcionalidades de
//adicionar novos produtos, e exibir todos os produtos no estoque.
ControleDeEstoque controleDeEstoque = new ControleDeEstoque();
Console.WriteLine($"\nAula 3: 3. Desenvolver uma classe que represente um estoque de produtos...");
Console.ForegroundColor = ConsoleColor.DarkYellow;
controleDeEstoque.exibirMenu();
Console.ResetColor();
//===========================================================================================

//4.Modelar o sistema de uma escola. Crie classes para Aluno, Professor e Disciplina.
//Instancia o objeto Aluno e atribui seus valores.
Aluno aluno1 = new Aluno();
aluno1.NomeAluno = "NinoJP";
aluno1.AnoNascimento = 2000;
aluno1.NotasAlunos = new List<double> { 8.5, 9.0, 7.5 };
//Instancia o objeto Professor e atribui seus valores.
Professor professor1 = new Professor();
professor1.NomeProfessor = "ProfessorEd";
professor1.DisciplinasProfessor = new List<string> { "Matemática", "Física" };
//Instancia o objeto Disciplina e atribui seus valores.
Disciplina disciplina1 = new Disciplina();
disciplina1.NomeDisciplina = "Matemática";
disciplina1.Alunos = new List<Aluno> { aluno1 };
Console.WriteLine($"\nAula 3: 4. Modelar o sistema de uma escola. Crie classes para Aluno, Professor e Disciplina.");
Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine($"\nO aluno {aluno1.NomeAluno}, está cursando a disciplina {disciplina1.NomeDisciplina} com o professor {professor1.NomeProfessor}.");
Console.ResetColor();
//===========================================================================================

//5. Modelar um sistema para um restaurante com classes como Restaurante, Mesa, Pedido e Cardapio.
//A classe Restaurante deve ter mesas que podem ser reservadas e um cardápio com itens que podem ser pedidos.
//Os pedidos podem estar associados a uma mesa.
Restaurante restaurante = new();
Console.WriteLine($"\nAula 3: 5. Modelar um sistema para um restaurante com classes como Restaurante, Mesa, Pedido e Cardapio.");
Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine($"\nO restaurante tem {restaurante.Mesas.Count} mesas disponíveis e um cardápio com {restaurante.Cardapio.Itens.Count} itens.");
Console.ResetColor();

*/
