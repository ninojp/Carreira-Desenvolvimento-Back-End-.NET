namespace ScreenSoundAPI.Aula1;

internal class ClassInicial
{
    public void Executar()
    {
        // Aula 1 - Escrever um programa que faça uam requisição para a API de games CheapShark
        CheapShark conectCheapShark = new();
        string? respostaCheapShark = conectCheapShark.ConnectionAPICheapShark();
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine(respostaCheapShark);
        Console.ResetColor();
        //==================================================

        // Aula 1 - Escrever um programa que solicite dois números a e b lidos do teclado e realize a divisão de a por b.
        //Caso essa operação não seja possível, mostrar uma mensagem no console que deixe claro o erro ocorrido.
        DividirAB dividirAB = new();
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        dividirAB.Dividir();
        Console.ResetColor();
        //==================================================

        // Aula 1 - Declarar uma lista de inteiros e tente acessar um elemento em um índice inexistente. Tratar a exceção apropriada.
        List<int> numeros = new List<int> { 1, 2, 3 };
        try
        {
            Console.WriteLine(numeros[5]);
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Erro: índice inexistente na lista.");
            Console.ResetColor();
        }
        //==============================================================

        // Aula 1 - Criar uma classe simples com um método e chame esse método em um objeto nulo. Tratar a exceção de método em objeto nulo.
        //try
        //{
        //    ClasseNula objetoNulo = null;
        //    objetoNulo.Meumetodo();
        //}
        //catch (NullReferenceException ex)
        //{
        //    Console.WriteLine($"Erro: {ex.Message}");
        //}
    }
}