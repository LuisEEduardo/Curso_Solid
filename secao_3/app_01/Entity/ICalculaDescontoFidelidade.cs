namespace app.Entity;

public interface ICalculaDescontoFidelidade
{
    decimal AplicarDescontoFidelidade(decimal preco, int tempoDeContaEmAnos);
}
