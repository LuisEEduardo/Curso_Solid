namespace Exercicio.Entity;

public class Ave : Animal
{
    public Ave(string tipo)
        : base(tipo)
    {
    }

    public override void Mover()
    {
        Console.WriteLine("Voando ...");
    }
}
