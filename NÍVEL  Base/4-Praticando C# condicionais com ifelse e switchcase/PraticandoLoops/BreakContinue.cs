using System.Diagnostics;

namespace PraticandoLoops;

internal class BreakContinue
{
    //Aula 2 -  Manipulando laços: break e continue - Vídeo 2
    public void ControlandoLoops()
    {
        List<string> funcionarios = new List<string>
        {
            "João-Gerente-8500",
            "Maria-Analista de Sistemas-6200",
            "Carlos-Desenvolvedor-5500",
            "Ana-Designer-4800",
            "Pedro-Suporte Técnico-3900",
            "Fernanda-Coordenadora de Projetos-7300",
            "Ricardo-Contador-6000",
            "Juliana-RH-4500"
        };
        //Exibe a lista completa
        Console.WriteLine("\nExibe a lista completa");
        for (int i = 0; i < funcionarios.Count; i++)
        {
            Console.WriteLine($"Da lista Nome: {funcionarios[i]}");
        }
        //Usando o BREAK
        Console.WriteLine("\nUsando o Break");
        for (int i = 0; i < funcionarios.Count; i++)
        {
            string nome = funcionarios[i].Split("-")[0];
            if (nome.Equals("Ana"))
            {
                Console.WriteLine($"Da lista o nome digitado foi: {funcionarios[i]}.");
                Console.WriteLine($"Da lista Nome: {funcionarios[i].Split("-")[0]}.");
                Console.WriteLine($"Da lista Cargo: {funcionarios[i].Split("-")[1]}.");
                Console.WriteLine($"Da lista Salário: {funcionarios[i].Split("-")[2]}.");
                break;
            }
        }
        //usando o CONTINUE
        Console.WriteLine("\nUsando o CONTINUE");
        for (int i = 0; i < funcionarios.Count; i++)
        {
            string salario = funcionarios[i].Split("-")[2];
            int intSalario = int.Parse(salario);
            if (intSalario > 5000)
            {
                continue;
            }
            Console.WriteLine($"\nDa lista os salários abaixo de R$5000,00: {funcionarios[i]}.");
        }
        // Exemplos da I.A
        // BREAK - Para completamente
        for (int i = 1; i <= 5; i++)
        {
            if (i == 3) break;
            Console.WriteLine(i);
        }
        // Resultado: 1, 2
        //------------------------------
        // CONTINUE - Pula só o 3
        for (int i = 1; i <= 5; i++)
        {
            if (i == 3) continue;
            Console.WriteLine(i);
        }
        // Resultado: 1, 2, 4, 5
    }
    // RETURN - Sai do método
    public void Exemplo()
    {
        for (int i = 1; i <= 5; i++)
        {
            if (i == 3) return;
            Console.WriteLine(i);
        }
        Console.WriteLine("Isso não será executado");
    }
    // Resultado: 1, 2
}
