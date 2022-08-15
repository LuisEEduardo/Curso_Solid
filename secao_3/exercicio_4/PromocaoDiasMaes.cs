namespace Exercicio;

public class PromocaoDiasMaes : IPromocao
{
    public decimal CalcularPromocao(Produto produto)
        => produto.Valor - (produto.Valor * 0.5M);
}
