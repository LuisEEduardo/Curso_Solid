namespace Exercicio;

public class Produto
{
    public string Nome { get; private set; }
    public decimal Preco { get; private set; }
    protected IPromocao _promocao;

    public Produto(string nome, decimal preco, IPromocao promocao)
    {
        Nome = nome;
        Preco = preco;
        _promocao = promocao;
    }

    public void AlterarNome(string nome)
    {
        Nome = nome;
    }

    public void AlterarPreco(decimal preco)
    {
        Preco = preco;
    }

    public decimal DescontoPromocao()
        => _promocao.Desconto();

    public decimal PrecoVenda()
        => Preco - (Preco * DescontoPromocao());

}
