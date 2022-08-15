namespace Exercicio;

public class Perfume : Produto
{
    public Perfume(string nome, decimal valor, IPromocao promocao)
        : base(nome, valor, promocao)
    {
    }
}
