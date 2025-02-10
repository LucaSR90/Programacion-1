// Ejercicio 3: Leer 10 enteros, almacenarlos en un arreglo y determinar en qué posición del arreglo está el mayor número primo leído.

using System;

class Program
{
    static void Main()
    {
        int[] numeros = new int[10];
        Console.WriteLine("Ingrese 10 números enteros:");

        // Leer los números
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Número {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        int maxPrimo = -1;
        int posicionMaxPrimo = -1;

        // Buscar el mayor número primo
        for (int i = 0; i < 10; i++)
        {
            if (EsPrimo(numeros[i]) && numeros[i] > maxPrimo)
            {
                maxPrimo = numeros[i];
                posicionMaxPrimo = i;
            }
        }

        if (posicionMaxPrimo != -1)
        {
            Console.WriteLine($"\nEl mayor número primo es {maxPrimo} y está en la posición {posicionMaxPrimo}.");
        }
        else
        {
            Console.WriteLine("\nNo hay números primos en el arreglo.");
        }

        Console.ReadKey();
    }

    // Método para verificar si un número es primo
    static bool EsPrimo(int num)
    {
        if (num < 2) return false;
        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0) return false;
        }
        return true;
    }
}
