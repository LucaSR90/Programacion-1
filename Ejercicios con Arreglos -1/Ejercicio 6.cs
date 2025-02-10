// Leer 10 números enteros, almacenarlos en un arreglo y determinar en qué posiciones se encuentran los números con más de 3 dígitosusing System;

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
            numeros[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Posiciones de los números con más de 3 dígitos:");
        bool encontrado = false;

        for (int i = 0; i < 10; i++)
        {
            if (Math.Abs(numeros[i]).ToString().Length > 3)
            {
                Console.WriteLine($"Número en la posición {i + 1}");
                encontrado = true;
            }
        }

        if (!encontrado)
        {
            Console.WriteLine("No se encontró ningún número con más de 3 dígitos.");
        }
    }
}
