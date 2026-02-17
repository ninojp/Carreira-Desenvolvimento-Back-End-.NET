using ScreenSound;

void exibirLogo()
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
exibirLogo();
//==============================
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
*/

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






