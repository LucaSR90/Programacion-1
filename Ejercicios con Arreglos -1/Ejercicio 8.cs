// Leer 10 números enteros, almacenarlos en un arreglo y determinar cuántos números negativos hay.
using System;

class Program
{
    static void Main()
    {
        int[] numeros = new int[10];
        int contadorNegativos = 0;

        Console.WriteLine("Ingrese 10 números enteros:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Número {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());
            if (numeros[i] < 0) contadorNegativos++;
        }

        Console.WriteLine($"Cantidad de números negativos: {contadorNegativos}");
    }
}
