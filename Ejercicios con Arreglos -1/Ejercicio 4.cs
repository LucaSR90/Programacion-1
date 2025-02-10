// Leer 10 números enteros, almacenarlos en un arreglo y determinar cuántos números de los almacenados en dicho arreglo comienzan en dígito primo
using System;

class Program
{
    static void Main()
    {
        int[] numeros = new int[10];
        int contador = 0;

        Console.WriteLine("Ingrese 10 números enteros:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Número {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());

            int primerDigito = ObtenerPrimerDigito(Math.Abs(numeros[i]));
            if (EsPrimo(primerDigito))
            {
                contador++;
            }
        }

        Console.WriteLine($"Cantidad de números que comienzan con un dígito primo: {contador}");
    }

    static int ObtenerPrimerDigito(int numero)
    {
        while (numero >= 10)
        {
            numero /= 10;
        }
        return numero;
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
}
