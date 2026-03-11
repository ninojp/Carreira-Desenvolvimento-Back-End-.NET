namespace PraticandoOOPolimorf;

internal class EmailNotificacao : INotificacao
{
    public string EnviarMensagem(string mensagem)
    {
        return $"Email enviado: {mensagem}";
    }
}
