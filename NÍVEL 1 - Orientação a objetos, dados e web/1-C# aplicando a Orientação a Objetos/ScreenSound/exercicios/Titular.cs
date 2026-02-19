namespace ScreenSound.exercicios;
internal class Titular
{
    public string NomeDoTitular { get; set; }
    public string Sobrenome { get; set; }
    public string CPF { get; set; }
    public string Endereco { get; set; }
    public string ExibirNomeCompleto => $"{NomeDoTitular} {Sobrenome}";
}
