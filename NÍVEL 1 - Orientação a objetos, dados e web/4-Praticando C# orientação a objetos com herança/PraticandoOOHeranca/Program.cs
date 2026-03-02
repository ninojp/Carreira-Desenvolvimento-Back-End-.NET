using PraticandoOOHeranca;
//Curso Alura - Praticando C# orientação a objetos com herança
//Aula 1 - Criando e instanciando a classe base Produto
ProdutoFisico item1 = new ProdutoFisico("Teclado", "Modelo compacto e silencioso, " +
    "perfeito para produtividade diária.",
    80.00m, "Imagem");
Console.WriteLine("\nAula 1 - Criando e instãnciando a classe base Produto");
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine($"\nProduto Físico: {item1.Nome}");
Console.WriteLine($"Descrição: {item1.Descricao}");
Console.WriteLine($"Preço: R${item1.Preco}");
Console.WriteLine($"Disponível: {(item1.EstaDisponivel() ? "Sim" : "Não")}");
Console.WriteLine($"Imagem: {item1.Imagem}");

ProdutoDigital item2 = new ProdutoDigital("Curso", "Curso Orientação a Objetos em C#", 100.00m, "Imagem ilustrativa", "Link para download");
Console.WriteLine($"\nProduto Digital: {item2.Nome}");
Console.WriteLine($"Imagem: {item2.Imagem}");
Console.WriteLine($"Descrição: {item2.Descricao}");
Console.WriteLine($"Preço: R${item2.Preco}");
Console.WriteLine($"Link Para Download: {item2.LinkDownload}");
Console.WriteLine($"Status: {(item2.EstaExpirado() ? "Expirado" : "Válido")}");
//Aula 2 - Interfaces e implementação
Pedido pedido1 = new Pedido(1, "João Silva", 180.00m);
Console.WriteLine($"\n");
pedido1.ExibirResumo();

Console.ResetColor();