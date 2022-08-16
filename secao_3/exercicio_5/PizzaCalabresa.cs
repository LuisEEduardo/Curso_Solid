namespace Exercicio;

public class PizzaCalabresa : Pizza
{
    public PizzaCalabresa(string nome)
        : base(nome)
    {
    }

    public override int AssarPizza()
    {
        var tempo = 20;
        Console.WriteLine($"Assando pizza de {Nome} por {tempo} minutos");
        return tempo;
    }

}
