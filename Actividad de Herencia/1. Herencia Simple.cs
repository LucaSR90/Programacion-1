﻿using System;

public class Animal
{
    public void Comer()
    {
        Console.WriteLine("El animal está comiendo.");
    }
}

public class Perro : Animal
{
    public void Ladrar()
    {
        Console.WriteLine("El perro está ladrando.");
    }
}

class Program
{
    static void Main()
    {
        Perro miPerro = new Perro();
        miPerro.Comer();
        miPerro.Ladrar();

       
        Console.WriteLine("Presiona cualquier tecla para salir...");
        Console.ReadLine();
    }
}

