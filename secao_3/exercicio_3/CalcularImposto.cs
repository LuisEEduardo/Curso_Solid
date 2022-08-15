namespace Exercicio;

public class CalcularImposto
{
    public decimal Calcular(ICalculaImpostoPais calculaImpostoPais)
    {
        return calculaImpostoPais.CalcularValorImposto();
    }
}
