namespace Exercicio;

public abstract class Pizza
{
    protected Pizza(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; private set; }

    public void AlterarNome(string nome)
    {
        Nome = nome;
    }

    public abstract int AssarPizza();

    public void DeliveryPizza()
    {
        Console.WriteLine($"Entregar pizza de {Nome}");
    }

}
