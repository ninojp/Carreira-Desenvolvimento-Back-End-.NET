namespace PraticandoLoops;
internal class ForEach
{
    public void ParaCada()
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
        foreach (string funcionario in funcionarios)
        {
            string nome = funcionario.Split("-")[0];
            if (nome.Equals("Fernanda"))
            {
                Console.WriteLine($"Dados do funcionário buscado: {funcionario}");
                break;
            }
        }
    }
}
