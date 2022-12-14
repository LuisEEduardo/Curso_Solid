namespace app.Entity;

public class CalculaDescontosStatusFactory : ICalculaDescontoStatusContaFactory
{
    public ICalculaDescontoStatusConta GetCalculaDescontosStatusConta(StatusContaCliente statusContaCliente)
    {
        ICalculaDescontoStatusConta calcular;

        switch (statusContaCliente)
        {
            case StatusContaCliente.NaoRegistrado:
                calcular = new ClienteNaoRegistradoDesconto();
                break;
            case StatusContaCliente.ClienteComum:
                calcular = new ClienteComumDesconto();
                break;
            case StatusContaCliente.ClienteEspecial:
                calcular = new ClienteEspecialDesconto();
                break;
            case StatusContaCliente.ClienteVip:
                calcular = new ClienteVIPDesconto();
                break;
            default:
                throw new NotImplementedException();
        }

        return calcular;
    }
}
