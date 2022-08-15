namespace Exercicio;

public class CalcularImpostoEUA : ICalculaImpostoPais
{
    public decimal TotolRenda { get; set; }
    public decimal TotolDeducao { get; set; }

    public decimal CalcularValorImposto()
    {
        decimal valorBase = TotolRenda - TotolDeducao;
        return valorBase * 0.30M;
    }
}
