using System;

public class SerVivo
{
    public void Respirar()
    {
        Console.WriteLine("El ser vivo está respirando.");
    }
}

public class Mamifero : SerVivo
{
    public void Amamantar()
    {
        Console.WriteLine("El mamífero está amamantando.");
    }
}

public class Humano : Mamifero
{
    public void Hablar()
    {
        Console.WriteLine("El humano está hablando.");
    }
}

class Program
{
    static void Main()
    {
        Humano persona = new Humano();
        persona.Respirar();
        persona.Amamantar();
        persona.Hablar();

        Console.WriteLine("Presiona cualquier tecla para salir...");
        Console.ReadLine();
    }
}
