namespace app.Entity;

public class ClienteVIPDesconto : ICalculaDescontoStatusConta
{
    public decimal AplicarDescontoStatusConta(decimal preco)
        => (preco - (Contantes.DESCONTO_CLIENTE_VIP * preco));
}
