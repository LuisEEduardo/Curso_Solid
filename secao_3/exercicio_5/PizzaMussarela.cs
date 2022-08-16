namespace Exercicio;

public class PizzaMussarela : Pizza
{
    public PizzaMussarela(string nome)
        : base(nome)
    {
    }

    public override int AssarPizza()
    {
        var tempo = 25;
        Console.WriteLine($"Assando pizza de {Nome} por tempo {tempo} minutos");
        return tempo;
    }
}
