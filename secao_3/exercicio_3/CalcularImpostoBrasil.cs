namespace Exercicio;

public class CalcularImpostoBrasil : CalcularImposto
{
    public override decimal Calcular(decimal valor, decimal deducao)
    {
        decimal valorImposto = 0;
        decimal valorBase = valor - deducao;
        valorImposto = valorBase + (valorBase * 0.1M);
        return valorImposto;
    }
}
