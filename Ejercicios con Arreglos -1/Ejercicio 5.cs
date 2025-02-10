// Leer 10 números enteros, almacenarlos en un arreglo y determinar en qué posición se encuentra el número primo con mayor cantidad de dígitos pares.
using System;

class Program
{
    static void Main()
    {
        int[] numeros = new int[10];
        int posicionMayor = -1;
        int maxDigitosPares = -1;

        Console.WriteLine("Ingrese 10 números enteros:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Número {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());

            if (EsPrimo(numeros[i]))
            {
                int digitosPares = ContarDigitosPares(numeros[i]);
                if (digitosPares > maxDigitosPares)
                {
                    maxDigitosPares = digitosPares;
                    posicionMayor = i;
                }
            }
        }

        if (posicionMayor != -1)
            Console.WriteLine($"El número primo con más dígitos pares está en la posición: {posicionMayor + 1}");
        else
            Console.WriteLine("No se encontró ningún número primo con dígitos pares.");
    }

    static bool EsPrimo(int numero)
    {
        if (numero < 2) return false;
        for (int i = 2; i <= Math.Sqrt(numero); i++)
        {
            if (numero % i == 0) return false;
        }
        return true;
    }

    static int ContarDigitosPares(int numero)
    {
        int contador = 0;
        while (numero > 0)
        {
            int digito = numero % 10;
            if (digito % 2 == 0) contador++;
            numero /= 10;
        }
        return contador;
    }
}
