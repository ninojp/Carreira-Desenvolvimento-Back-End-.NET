namespace PraticandoOOPolimorf;

internal class PushNotificacao : INotificacao
{
    public string EnviarMensagem(string mensagem)
    {
        return $"Push enviado: {mensagem}";
    }
}
