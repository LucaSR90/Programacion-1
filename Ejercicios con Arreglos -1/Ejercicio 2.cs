// 2.   Leer 10 enteros, almacenarlos en un arreglo y determinar en qué posición de del arreglo está el mayor número par leído.
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
            while (!int.TryParse(Console.ReadLine(), out numeros[i]))
            {
                Console.WriteLine("Entrada inválida. Intente nuevamente con un número entero.");
                Console.Write($"Número {i + 1}: ");
            }
        }

        int maxPar = int.MinValue;
        int posicionMaxPar = -1;

        // Encontrar el mayor número par y su posición
        for (int i = 0; i < 10; i++)
        {
            if (numeros[i] % 2 == 0 && numeros[i] > maxPar)
            {
                maxPar = numeros[i];
                posicionMaxPar = i;
            }
        }

        if (posicionMaxPar >= 0)
        {
            Console.WriteLine($"\nEl mayor número par es {maxPar} y está en la posición {posicionMaxPar}.");
        }
        else
        {
            Console.WriteLine("\nNo se ingresaron números pares.");
        }

        Console.WriteLine("Presione cualquier tecla para salir...");
        Console.ReadKey();
    }
}
