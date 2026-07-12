namespace bytebank.Modelos.Conta
{
    public class Cliente
    {
        private string _nome;
        public string Nome
        {
            get { return _nome; }
            set { if (value.Length < 3)
                {
                    Console.WriteLine("Nome do titular precisa ter pelo menos 3 caracteres.");
                }
                _nome = value;
            }
        }
        public string Cpf { get; set; }
        public string Profissao { get; set; }
        public static int TotalClientesCadastrados { get; set; }

        public Cliente(string nome, string cpf, string profissao)
        {
            Nome = nome;
            Cpf = cpf;
            Profissao = profissao;
            TotalClientesCadastrados = TotalClientesCadastrados + 1;
        }
    }
}
