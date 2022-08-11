namespace app.Entity;

public class ClienteComumDesconto : ICalculaDescontoStatusConta
{
    public decimal AplicarDescontoStatusConta(decimal preco)
        => (preco - (Contantes.DESCONTO_CLIENTE_COMUM * preco));
}
