namespace PraticandoOOEncaps;

internal class SegurancaConta
{
    //apenas autoriza saques de até R$ 1000
    public bool ValidarSaque(decimal valor)
    {
        return valor <= 1000;
    }
}
