using System.Text.Json.Serialization;

namespace ScreenSoundAPI.Aula2
{
    internal class PersonagemGOT
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("gender")]
        public string Gender { get; set; }

        [JsonPropertyName("titles")]
        public string[] Titles { get; set; }

        public void ExibirDetalhesDoPersonagem()
        {
            Console.WriteLine($"Nome do personagem: {Name}");
            Console.WriteLine($"Gênero: {Gender}");
            Console.WriteLine("Títulos:");
            foreach (var title in Titles)
            {
                Console.WriteLine($"- {title}");
            }
        }
    }
}
