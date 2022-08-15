namespace Exercicio;

public interface ICalculaImpostoPais
{
    decimal TotolRenda { get; set; }
    decimal TotolDeducao { get; set; }

    decimal CalcularValorImposto();
}
