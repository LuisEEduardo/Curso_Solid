namespace app.Entity;

public class GerenciadorDeDescontos
{
    private readonly ICalculaDescontoStatusContaFactory _descontoStatusConta;
    private readonly ICalculaDescontoFidelidade _descontoFidelidade;

    public GerenciadorDeDescontos(ICalculaDescontoStatusContaFactory descontoStatusConta, ICalculaDescontoFidelidade descontoFidelidade)
    {
        _descontoStatusConta = descontoStatusConta;
        _descontoFidelidade = descontoFidelidade;
    }

    public decimal AplicarDesconto(decimal precoProduto, StatusContaCliente statusContaCliente, int tempoDeContaEmAnos)
    {
        decimal precoAposDesconto = 0;

        precoAposDesconto = _descontoStatusConta.GetCalculaDescontosStatusConta(statusContaCliente).AplicarDescontoStatusConta(precoProduto);

        precoAposDesconto = _descontoFidelidade.AplicarDescontoFidelidade(precoAposDesconto, tempoDeContaEmAnos);

        return precoAposDesconto;
    }
}
