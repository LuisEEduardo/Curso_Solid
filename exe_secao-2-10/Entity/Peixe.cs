namespace Exercicio.Entity;

public class Peixe : Animal
{

    public Peixe(string tipo)
        : base(tipo)
    {
    }

    public override void Mover()
    {
        Console.WriteLine("Nadar ...");
    }
}
