// Leer 10 números enteros, almacenarlos en un arreglo y calcular la factorial a cada uno de los números leídos almacenándolos en otro arreglo
using System;

class Program
{
    static void Main()
    {
        int[] numeros = new int[10];
        long[] factoriales = new long[10];

        Console.WriteLine("Ingrese 10 números enteros:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Número {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());
            factoriales[i] = CalcularFactorial(numeros[i]);
        }

        Console.WriteLine("Factoriales de los números leídos:");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Número: {numeros[i]}, Factorial: {factoriales[i]}");
        }
    }

    static long CalcularFactorial(int numero)
    {
        if (numero < 0) return 0;
        long factorial = 1;
        for (int i = 1; i <= numero; i++)
        {
            factorial *= i;
        }
        return factorial;
    }
}
