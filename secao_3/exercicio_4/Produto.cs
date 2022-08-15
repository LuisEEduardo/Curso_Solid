namespace Exercicio;

public class Produto
{
    public Produto(string nome, decimal valor)
    {
        Nome = nome;
        Valor = valor;
    }

    public string Nome { get; private set; }
    public decimal Valor { get; private set; }

    public void AlterarNome(string nome)
    {
        Nome = nome;
    }

    public void AlterarValor(decimal valor)
    {
        Valor = valor;
    }

}
