using System.Text.Json;

namespace ScreenSoundAPI.Models
{
    internal class MusicasPreferidas
    {
        public string? Nome { get; set; }
        public List<Musica> ListaDeMusicasFavoritas { get; } = [];
        public MusicasPreferidas(string nome)
        {
            Nome = nome;
        }
        public void AdicionarMusicasFavoritas(Musica musica)
        {
            ListaDeMusicasFavoritas.Add(musica);
        }
        public void ExibirMusicasFavoritas()
        {
            Console.WriteLine($"\nMúsicas favoritas de {Nome}:");
            foreach (var musica in ListaDeMusicasFavoritas)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"- {musica.SongNome} ({musica.Artista})");
                Console.ResetColor();
            }
        }
        public void GerarArquivoJSONMusicasFavoritas()
        {
            //Criamos um objeto anônimo NEW{}, para serializar temporariamente, apenas as informações relevantes.
            string json = JsonSerializer.Serialize(new
            {
                nome = Nome,
                musicasFavoritas = ListaDeMusicasFavoritas
            });
            string nomeArquivo = $"{Nome}MusicasFavoritas.json";
            File.WriteAllText(nomeArquivo, json);
            Console.WriteLine($"\nArquivo JSON: {nomeArquivo}, gerado com sucesso.\nNo endereço: {Path.GetFullPath(nomeArquivo)}");
        }
        public void GerarArquivoTXTMusicasFavoritas()
        {
            string nomeDoArquivo = $"musicas-favoritas-{Nome}.txt";
            using (StreamWriter arquivo = new StreamWriter(nomeDoArquivo))
            {
                arquivo.WriteLine($"Músicas favoritas do {Nome}\n");
                foreach (var musica in ListaDeMusicasFavoritas)
                {
                    arquivo.WriteLine($"- {musica.SongNome}");
                }
                arquivo.Close();
            }
            Console.WriteLine("txt gerado com sucesso!");
        }

    }
}
