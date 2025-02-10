//  Leer 10 números enteros, almacenarlos en un arreglo. Luego leer un entero y determinar cuántos divisores exactos tiene este último número entre los valores almacenados en el arreglo.

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

        Console.Write("Ingrese un número adicional para encontrar sus divisores exactos: ");
        int numeroAdicional = int.Parse(Console.ReadLine());
        int contadorDivisores = 0;

        foreach (int num in numeros)
        {
            if (num != 0 && numeroAdicional % num == 0)
            {
                contadorDivisores++;
            }
        }

        Console.WriteLine($"El número {numeroAdicional} tiene {contadorDivisores} divisores exactos en el arreglo.");
    }
}
