namespace app.Entity;

public class CalculaDescontoFidelidade : ICalculaDescontoFidelidade
{
    public decimal AplicarDescontoFidelidade(decimal preco, int tempoDeContaEmAnos)
    {
        decimal descontoPorFidelidade = (tempoDeContaEmAnos > Contantes.DESCONTO_MAXIMO_POR_FIDELIDADE) ? (decimal)Contantes.DESCONTO_MAXIMO_POR_FIDELIDADE / 100 : (decimal)tempoDeContaEmAnos / 100;

        return preco - (descontoPorFidelidade * preco);
    }
}
