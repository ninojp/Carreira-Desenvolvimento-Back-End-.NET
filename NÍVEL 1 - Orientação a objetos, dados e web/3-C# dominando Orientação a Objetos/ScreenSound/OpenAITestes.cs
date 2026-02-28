using OpenAI;
//OpenAI_API (API usada no curso) não funciona mais, foi necessário usar a nova biblioteca oficial da OpenAI para C#.
using OpenAI.Chat;
//Minha chave OpenAI: API Key
//TestKey: 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
//Minha chave de teste
//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

namespace ScreenSound
{
    internal class OpenAITestes
    {
        //================================================================
        //OpenAI Oficial API, Testes
        public async Task TestarAPI()
        {
            // Use variável de ambiente ao invés de hardcoded
            string apiKey = Environment.GetEnvironmentVariable("OPENAI_API_KEY") 
                ?? "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";
            
            var client = new OpenAIClient(apiKey);
            
            ChatClient chatClient = client.GetChatClient("gpt-5.2");
            
            var response = await chatClient.CompleteChatAsync("Resuma a banda Ira! em 1 parágrafo. Adote um estilo informal.");

            Console.WriteLine($"resultado foi: {response}");
            Console.WriteLine(response.Value.Content[0].Text);
        }
    }
}
