namespace AluraDesafios.Aula3;

internal class Mamifero : Animal
{
    private string tipoProprio = "Mamífero";
    private string somCaracteristico = "latido ou miado";
    public override void EmitirSom()
    {
        base.EmitirSom();
        Console.WriteLine($"O {tipoProprio} emite um som característico, como um {somCaracteristico}.");
    }
}
