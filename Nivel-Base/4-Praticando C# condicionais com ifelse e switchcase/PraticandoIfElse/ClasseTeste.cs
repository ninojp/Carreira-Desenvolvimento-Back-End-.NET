using System;

    public class ClasseTeste
    {
        static void Teste()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Classe de testes, sobre estrutura básica de uma classe.");
            Console.ResetColor();
        }
        void Teste2()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Exemplo Maneiro de ASCII");
            Console.WriteLine(@"
                __________                __  .__                          .___             _________    _  _   
                \______   \____________ _/  |_|__| ____ _____    ____    __| _/____         \_   ___ \__| || |__
                 |     ___/\_  __ \__  \\   __\  |/ ___\\__  \  /    \  / __ |/  _ \        /    \  \/\   __   /
                 |    |     |  | \// __ \|  | |  \  \___ / __ \|   |  \/ /_/ (  <_> )       \     \____|  ||  | 
                 |____|     |__|  (____  /__| |__|\___  >____  /___|  /\____ |\____/         \______  /_  ~~  _\
                                       \/             \/     \/     \/      \/                \/
            ");
            Console.ResetColor();
    }
}

//Top - level statements

//A partir da versão 9.0 do C#, não é mais necessário escrever using System;
//ou criar uma classe Program com o método Main. Isso acontece graças ao recurso chamado
//top-level statements (ou instruções de nível superior), que permite eliminar a estrutura tradicional
//usada como ponto de entrada do programa. Antes, um aplicativo de console típico era escrito assim:

//using System;
//namespace Application
//{
    //class Program
    //{
        //static void Main(string[] args)
        //{
            //Console.WriteLine("Hello, World!");
        //}
    //}
//}

//Com as instruções de nível superior, você pode simplificar e escrever apenas:

//Console.WriteLine("Hello, World!");