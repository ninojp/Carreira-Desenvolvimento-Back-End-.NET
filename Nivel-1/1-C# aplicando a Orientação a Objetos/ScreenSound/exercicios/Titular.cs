namespace ScreenSound.exercicios
{
    internal class Titular
    {
        public Titular(string nomeDoTitular, string sobrenome, string cpf, string endereco)
        {
            NomeDoTitular = nomeDoTitular;
            Sobrenome = sobrenome;
            CPF = cpf;
            Endereco = endereco;
        }
        public string NomeDoTitular { get; set; }
        public string Sobrenome { get; set; }
        public string CPF { get; set; }
        public string Endereco { get; set; }
        public string ExibirNomeCompleto => $"{NomeDoTitular} {Sobrenome}";
    }
}
