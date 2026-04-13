namespace PraticandoStringRegex;
//Curso Alura - Praticando C# Strings e Regex

internal partial class Program
{
    static void Main(string[] args)
    {
        //Aula 2: Praticando Regex
        Aula2();


        //==============================================================================================
        /*
        //Aula 1 - Strings em C#

        //Aula 1:  Formatando o relatório - Desafio 6
        Console.WriteLine("\nAula 1:  Formatando o relatório - Desafio 6");

        Console.WriteLine("Digite o nome do cliente:");
        string nome = Console.ReadLine();

        Console.WriteLine("Digite o endereço:");
        string endereco = Console.ReadLine();

        Console.WriteLine("Digite o valor do frete:");
        double frete = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a data de entrega:");
        string data = Console.ReadLine();

        Console.WriteLine("\n========== RELATÓRIO DE ENTREGA ==========\n");
        Console.WriteLine($"Cliente:\t \"{nome}\"");
        Console.WriteLine($"Endereço:\t \"{endereco}\"");
        Console.WriteLine($"Valor do frete: R$ {frete.ToString("0.00")}");
        Console.WriteLine($"Data:\t\t {data}\n");
        Console.WriteLine("==========================================");
        //==============================================================================================
        //Aula 1:  Padronizando alertas em maiúsculas - Desafio 5
        Console.WriteLine("Aula 1:  Padronizando alertas em maiúsculas - Desafio 5");
        string alerta = Console.ReadLine();

        string resultado = alerta.ToUpper();

        Console.WriteLine(resultado);

        //==============================================================================================
        //Aula 1: Dividindo uma string - Desafio 4
        Console.WriteLine("Aula 1: Dividindo uma string - Desafio 4");
        string log = "2025-03-25,Erro,Arquivo não encontrado";

        Console.WriteLine($"Data: {log.Split(',')[0]}");
        Console.WriteLine($"Tipo de erro: {log.Split(',')[1]}");
        Console.WriteLine($"Mensagem: {log.Split(',')[2]}");
        //==============================================================================================
        //Aula 1: Substituindo palavras em uma frase - Desafio 3
        Console.WriteLine("Aula 1: Substituindo palavras em uma frase - Desafio 3");
        Console.WriteLine("Digite uma frase: ");
        string fraseDigitada = Console.ReadLine();

        Console.WriteLine("\nQual palavra você quer substituir? ");
        string palavraAntiga = Console.ReadLine();

        Console.WriteLine("\nPor qual palavra? ");
        string palavraNova = Console.ReadLine();

        string novaFrase = fraseDigitada.Replace(palavraAntiga, palavraNova);
        Console.WriteLine(novaFrase);

        //==============================================================================================
        //Aula 1:  Contando caracteres - Desafio 2
        Console.WriteLine("\nAula 1:  Contando caracteres - Desafio 2");
        Console.Write("Digite uma frase: ");
        string frase = Console.ReadLine();

        Console.WriteLine($"A frase contém {frase.Length} caracteres.");
        //==============================================================================================
        //Aula 1: Encontrando palavras-chave - Desafio 1
        Console.WriteLine("\nAula 1: Encontrando palavras-chave - Desafio 1");
        Console.WriteLine("Digite um texto, sobre C#: ");
        string pesquisa = Console.ReadLine();
        string palavraChave = "C#";
        //string texto = "Aprender C# é muito importante para o desenvolvimento de software.";
        if (pesquisa.Contains(palavraChave))
        {
            Console.WriteLine($"A palavra-chave '{palavraChave}' foi encontrada no texto.");
        }else
        {
            Console.WriteLine($"A palavra-chave '{palavraChave}' não foi encontrada no texto.");
        }

        //=================================================================================================

        string linhaCsv = "João,30,489846784";
        //Split(), faz a divisão de uma string em um array, usando um caractere ou string como separador
        string telefone = linhaCsv.Split(',')[2];
        Console.WriteLine(telefone);
        //Replace(), substitui um caractere ou string por outro
        string novaLinha = linhaCsv.Replace(",", " - ");
        Console.WriteLine(novaLinha);
        //StartWith() e EndsWith(), verifica se uma string começa ou termina com um determinado caractere ou string
        string imagem = "foto.jpg";
        if (imagem.EndsWith(".jpg"))
        {
            Console.WriteLine("É uma imagem JPG");
        }
        else
        {
            Console.WriteLine("Não é uma imagem JPG");
        }
        string email = "exemplo@dominio.com";
        int posicaoArroba = email.IndexOf('@');
        if (posicaoArroba > -1)
        {
            //Com C# 8.0 ou superior, podemos usar o operador de intervalo
            //Spread Operator (..Collection Expressions..) 
            string dominio = email[(posicaoArroba + 1)..];
            //string dominio = email.Substring(posicaoArroba + 1);
            Console.WriteLine($"O Dominio é: {dominio}");
        }
        //============================================================
        Console.Write("Olá! Digite seu nome: ");
        string nome = Console.ReadLine();
        Console.Write("Agora, digite sua idade: ");
        string idade = Console.ReadLine();
        Console.Write("Agora, digite seu telefone: ");
        string telefon = Console.ReadLine();

        //Formas de declarar string
        Console.WriteLine("Nome: "+nome+", Idade: "+idade+", Telefone: "+telefon);
        // $"", Interpolação de string
        Console.WriteLine($"Nome: {nome}, Idade: {idade}, Telefone: {telefon}");
        //Caracter de escape \
        string mensagem = "Ola´! meu email é: \"meuemail@emal.com\"";
        Console.WriteLine(mensagem);
        //Verbatim, ignora caracteres de escape e permite quebra de linha
        string caminho = @"C:\Users\adria\Documents\requisicao.txt
        Após a quebra de linha, IDENTADA, o texto continua...";
        Console.WriteLine(caminho);
        // """""", string literal, permite quebra de linha, sem necessidade de verbatim, e sem necessidade de escape
        string texto = """"""
            Olá! Este é um texto com quebra de linha.
            Ele pode conter "aspas" sem necessidade de escape.
            E também pode conter \barras\ sem necessidade de escape.
            """""";
        Console.WriteLine(texto);
        // Podemos ainda juntar verbatim e string literal, usando @ antes das aspas triplas, para permitir quebra de linha e ignorar caracteres de escape
        string caminho2 = @$"C:\Users\adria\Documents\requisicao.txt
        Após a quebra de linha, IDENTADA, o texto continua...
        podemos ainda usar variáveis: {nome}, {idade}, {telefon}";
        */
    }
}