namespace Exercicio.Entity;

public abstract class Animal
{
    protected Animal(string tipo)
    {
        Tipo = tipo;
    }

    public string Tipo { get; set; }

    public abstract void Mover();

}
