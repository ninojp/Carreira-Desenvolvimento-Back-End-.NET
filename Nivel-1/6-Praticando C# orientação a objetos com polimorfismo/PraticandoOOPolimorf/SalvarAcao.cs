namespace PraticandoOOPolimorf;

internal class SalvarAcao : IAcaoBotao
{
    //Polimorfisdmo de sobrescrita: cada classe implementa a interface de maneira diferente, mas todas podem ser tratadas como IAcaoBotao
    public void Executar()
    {
        Console.WriteLine("Salvando o arquivo...");
    }
}
