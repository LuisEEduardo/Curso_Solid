namespace app.Entity;

public class ClienteNaoRegistradoDesconto : ICalculaDescontoStatusConta
{
    public decimal AplicarDescontoStatusConta(decimal preco)
        => preco;
}
