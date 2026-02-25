namespace AluraDesafios.Aula3;

internal class Peixe : Animal
{
    private string tipoProprio = "Peixe";
    private string somCaracteristico = "som de bolhas ou silêncio";
    public override void EmitirSom()
    {
        base.EmitirSom();
        Console.WriteLine($"O {tipoProprio} emite um som característico, como um {somCaracteristico}.");
    }
}
