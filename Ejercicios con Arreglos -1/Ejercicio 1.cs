// 1.Leer 10 enteros, almacenarlos en un arreglo y determinar en qué posición del arreglo está el mayor número leído.
using System;

class Program
{
    static void Main()
    {
        int[] numeros = new int[10];
        Console.WriteLine("Ingrese 10 números enteros:");

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Número {i + 1}: ");
            while (!int.TryParse(Console.ReadLine(), out numeros[i]))
            {
                Console.WriteLine("Entrada inválida. Intente nuevamente con un número entero.");
                Console.Write($"Número {i + 1}: ");
            }
        }

        int maxNumero = numeros[0];
        int maxIndex = 0;

        for (int i = 1; i < 10; i++)
        {
            if (numeros[i] > maxNumero)
            {
                maxNumero = numeros[i];
                maxIndex = i;
            }
        }

        Console.WriteLine($"\nEl mayor número es {maxNumero} y está en la posición {maxIndex}.");
        Console.WriteLine("Presione cualquier tecla para salir...");
        Console.ReadKey();
    }
}
