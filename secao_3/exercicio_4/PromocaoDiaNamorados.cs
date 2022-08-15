namespace Exercicio;

public class PromocaoDiasNamorados : IPromocao
{
    public decimal CalcularPromocao(Produto produto)
        => produto.Valor - (produto.Valor * 0.2M);
}
