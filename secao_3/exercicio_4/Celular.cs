namespace Exercicio;

public class Celular : Produto
{
    public Celular(string nome, decimal valor, IPromocao promocao)
        : base(nome, valor, promocao)
    {
    }
}
