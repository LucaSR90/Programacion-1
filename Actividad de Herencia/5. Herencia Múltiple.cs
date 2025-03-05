using System;

public interface IVolar
{
    void Volar();
}

public interface INadar
{
    void Nadar();
}

public class Pato : IVolar, INadar
{
    public void Volar()
    {
        Console.WriteLine("El pato está volando.");
    }

    public void Nadar()
    {
        Console.WriteLine("El pato está nadando.");
    }
}

class Program
{
    static void Main()
    {
        Pato miPato = new Pato();
        miPato.Volar();
        miPato.Nadar();

        Console.WriteLine("Presiona cualquier tecla para salir...");
        Console.ReadLine();
    }
}
