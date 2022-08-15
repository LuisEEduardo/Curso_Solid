namespace Exercicio;

public class PromocaoDiasNamorados : IPromocao
{
    decimal IPromocao.Desconto()
        => 0.1M;
}
