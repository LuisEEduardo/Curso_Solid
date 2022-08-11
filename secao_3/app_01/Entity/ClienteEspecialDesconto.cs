namespace app.Entity;

public class ClienteEspecialDesconto : ICalculaDescontoStatusConta
{
    public decimal AplicarDescontoStatusConta(decimal preco)
        => (preco - (Contantes.DESCONTO_CLIENTE_ESPECIAL * preco));
}
