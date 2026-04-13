using System.Text.RegularExpressions;
namespace PraticandoStringRegex;

internal partial class Program
{
    static void Aula2()
    {
        //Aula 2: Praticando Regex - Vídeo 2;
        //ChavePix.TipoChavePix();
        //===================================

        //Aula 2: Substituindo links para o formato ''[LINK]'' - Desafio 5
        Console.WriteLine("\nAula 2: Substituindo links para o formato ''[LINK]'' - Desafio 5");
        Console.WriteLine("Digite um texto contendo links: ");
        string texto = Console.ReadLine();

        string regexUrl = @"https?://\S+";

        string resultado = Regex.Replace(texto, regexUrl, "[LINK]");

        Console.WriteLine(resultado);

        /*
        //===================================
        //Aula 2: Validando datas - Desafio 4
        Console.WriteLine("\nAula 2: Validando datas - Desafio 4");
        string regexData = @"^\d{2}/\d{2}/\d{4}$";

        Console.WriteLine("Digite a data (dd/mm/aaaa):");
        string data = Console.ReadLine();

        bool formatoCorreto = Regex.IsMatch(data, regexData);

        if (formatoCorreto)
        {
            Console.WriteLine("A data está no formato correto.");
        }
        else
        {
            Console.WriteLine("Formato inválido! Use dd/mm/aaaa.");
        }

        //==================================================
        //Aula 2: Substituindo espaços em branco - Desafio 3
        Console.WriteLine("\nAula 2: Substituindo espaços em branco - Desafio 3");
        string regexSpaco = @"\s+";
        Console.WriteLine("Digite sua frase: ");
        string frase = Console.ReadLine();

        string textoLimpo = Regex.Replace(frase, regexSpaco, " ").Trim();
        Console.WriteLine("Texto limpo: " + textoLimpo + "");
        //===================================================

        //Aula 2: Extraindo o valor de uma moeda - Desafio 2
        Console.WriteLine("\nAula 2: Extraindo o valor de uma moeda - Desafio 2");
        Console.WriteLine("Digite o texto(contendo valores monetários no formato \"R$ XX,XX\".) do recibo: ");
        string texto = Console.ReadLine();

        string regexTexto = @"R\$ \d+,\d{2}";

        string valor = Regex.Match(texto, regexTexto).Value;

        Console.WriteLine("Valor encontrado: " + valor);

        //=================================================
        //Aula 2: Verificando Strings numéricas - Desafio 1

        Console.WriteLine("Digite o código (apenas dígitos numéricos 0-9) do cupom: ");
        string codigo = Console.ReadLine();
        string regexDigitos = @"^\d+$";
        bool ehValido = Regex.IsMatch(codigo, regexDigitos);
        if (ehValido)
        {
            Console.WriteLine("O código é válido.");
        }
        else
        {
            Console.WriteLine("O código não é válido.");
        }
        */
    }
}
