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
musica1.nome = "Roxane";
musica1.artista = "The Police";
musica1.duracao = 273;
musica1.disponivel = true;
Console.WriteLine($"\n O nome do artista é {musica1.artista} e sua musica: {musica1.nome}");
Console.ForegroundColor = ConsoleColor.DarkYellow;
musica1.ExibirFichaTecnica();
Console.ResetColor();

Musica musica2 = new Musica();
musica2.nome = "Vertigo";
musica2.artista = "U2";
musica2.duracao = 367;
musica2.disponivel = false;
Console.WriteLine($"\n O nome do artista é {musica2.artista} e sua musica: {musica2.nome}");
Console.ForegroundColor = ConsoleColor.DarkYellow;
musica2.ExibirFichaTecnica();
Console.ResetColor();

//==========================================================================================
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

//4. Desenvolver uma classe que modele um carro, e que contenha os métodos acelerar, frear e buzinar
Console.WriteLine($"\n4. Desenvolver uma classe que modele um carro, e que contenha os métodos acelerar, frear e buzinar");
Carros carro1 = new Carros();
Console.ForegroundColor = ConsoleColor.DarkYellow;
carro1.Acelerar();
carro1.Frear();
carro1.Buzinar();
Console.ResetColor();
//===========================================================================================
