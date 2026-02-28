namespace AluraDesafios.Aula3;

internal class Ave : Animal
{
    private string tipoProprio = "Ave";
    private string somCaracteristico = "Canto Maravilhoso (Algumas kkkk)";
    public override void EmitirSom()
    {
        base.EmitirSom();
        Console.WriteLine($"O {tipoProprio} emite um som característico, como um {somCaracteristico}.");
    }
}
