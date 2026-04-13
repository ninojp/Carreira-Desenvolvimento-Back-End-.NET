namespace ScreenSound.Models;

internal interface IAvaliavel
{
    //Métodos de uma interface são public por padrão.
    void AdicionarNota(Avaliacao nota);
    double MediaNotas { get; }
    //Propriedade para contar quantas vezes a classe foi instanciada. O valor é definido na classe que implementa a interface.
    int ContadorDeObjetos { get; }
}
