using System;

public abstract class Ave
{
    public abstract void Volar();

    public void Comer()
    {
        Console.WriteLine("El ave está comiendo.");
    }
}

public class Aguila : Ave
{
    public override void Volar()
    {
        Console.WriteLine("El águila está volando.");
    }
}

class Program
{
    static void Main()
    {
        Aguila miAguila = new Aguila();
        miAguila.Comer();
        miAguila.Volar();

        Console.WriteLine("Presiona cualquier tecla para salir...");
        Console.ReadLine();
    }
}
