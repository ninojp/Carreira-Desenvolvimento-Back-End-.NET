using ScreenSound.Models;

namespace ScreenSound.Menus;

internal class MenuSair : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTituloDaOpcao("Saindo do Screen Sound...");
        Console.WriteLine("Obrigado por usar o Screen Sound, volte sempre!");
        Thread.Sleep(3000);
        Console.Clear();
    }
}
