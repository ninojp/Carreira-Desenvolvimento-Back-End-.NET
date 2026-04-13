using OpenAI;
//OpenAI_API (API usada no curso) não funciona mais, foi necessário usar a nova biblioteca oficial da OpenAI para C#.
using OpenAI.Chat;

namespace ScreenSound
{
    internal class OpenAITestes
    {
        //OpenAI Oficial API, Testes
        public async Task TestarAPI()
        {
            // Use variável de ambiente ao invés de hardcoded
            string apiKey = Environment.GetEnvironmentVariable("OPENAI_API_KEY") 
                ?? "KEY_REMOVIDA_POR_SEGURANCA";
            
            var client = new OpenAIClient(apiKey);
            
            ChatClient chatClient = client.GetChatClient("gpt-5.2");
            
            var response = await chatClient.CompleteChatAsync("Resuma a banda Ira! em 1 parágrafo. Adote um estilo informal.");

            Console.WriteLine($"resultado foi: {response}");
            Console.WriteLine(response.Value.Content[0].Text);
        }
    }
}
