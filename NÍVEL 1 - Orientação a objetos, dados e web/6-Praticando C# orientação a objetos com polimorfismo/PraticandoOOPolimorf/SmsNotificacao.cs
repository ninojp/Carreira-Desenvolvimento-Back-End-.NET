namespace PraticandoOOPolimorf;

internal class SmsNotificacao : INotificacao
{
    public string EnviarMensagem(string mensagem)
    {
        return $"SMS enviado: {mensagem}";
    }
}
