namespace Exercicio;

public class CalcularImpostoBrasil : ICalculaImpostoPais
{
    public decimal TotolRenda { get; set; }
    public decimal TotolDeducao { get; set; }

    public decimal CalcularValorImposto()
    {
        decimal valorBase = TotolRenda - TotolDeducao;
        return valorBase * 0.20M;
    }
}
