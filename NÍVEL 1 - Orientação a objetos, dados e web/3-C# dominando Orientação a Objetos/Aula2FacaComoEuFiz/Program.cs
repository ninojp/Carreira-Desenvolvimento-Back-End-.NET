using Aula2FacaComoEuFiz;
internal class Program
{
    //3. Criar um programa Program.cs e simular o funcionamento do programa.
    private static void Main(string[] args)
    {
        //Aula 2 - 1. Modelar um Pet Shop com classes como Pet, Dono, Consulta e médico.
        Console.WriteLine($"\nAula 2 - 1. Modelar um Pet Shop com classes como Pet, Dono, Consulta e médico.");
        Pet pet1 = new Pet("Rex", "Cachorro", 5);
        Pet pet2 = new Pet("Mia", "Gato", 3);
        DonoPet dono1 = new DonoPet("João", "Rua A, 123", 123456789);
        dono1.AdicionarPetALista(pet1);
        dono1.AdicionarPetALista(pet2);
        Medico medico1 = new Medico("Dra. Ana", "Veterinária");
        Consulta consulta1 = new Consulta(dono1, pet1, medico1);
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        consulta1.ExibirInformacoesConsulta();
        Console.ResetColor();

        //Aula 2 - 2. Modelar o funcionamento de uma oficina automobilistica.
        Console.WriteLine("\nAula 2 - 2. Modelar o funcionamento de uma oficina automobilistica.");
        Veiculo veiculo1 = new Veiculo("Toyota", "Corolla", 2020, "ABC-1234");
        Cliente cliente1 = new Cliente("Maria", "Rua B, 456");
        Mecanico mecanico1 = new Mecanico("Carlos", "Mecânica Geral");
        Oficina oficina1 = new Oficina();
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        oficina1.AgendarServico(veiculo1, cliente1, mecanico1, "01/05/2024");
        oficina1.RealizarServico(veiculo1, mecanico1);
        Console.ResetColor();

        // Aula 2 - 4. Escrever um programa que funcione como uma calculadora, que pode realizar as 4 operações básicas,
        //além de calcular raiz quadrada e potências. O usuario deve entrar com dois números e um simbolo que represente a operação a ser feita.
        Console.WriteLine("\nAula 2 - 4. Escrever um programa que funcione como uma calculadora, que pode realizar as 4 operações básicas.");
        Calculadora calculadora = new Calculadora();
        Console.Write("Digite o primeiro número: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Digite o segundo número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine($"Soma: {num1} + {num2} = {calculadora.RealizarOperacao(num1, num2, "+")}");
        Console.WriteLine($"Subtração: {num1} - {num2} = {calculadora.RealizarOperacao(num1, num2, "-")}");
        Console.WriteLine($"Multiplicação: {num1} * {num2} = {calculadora.RealizarOperacao(num1, num2, "*")}");
        Console.WriteLine($"Divisão: {num1} / {num2} = {calculadora.RealizarOperacao(num1, num2, "/")}");
        Console.ResetColor();
        Console.Write("Digite a base da potência: ");
        double num3 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Digite o expoente da potência: ");
        double num4 = Convert.ToDouble(Console.ReadLine());
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("Potência: " + calculadora.RealizarOperacao(num3, num4, "pow"));
        Console.ResetColor();
    }
}