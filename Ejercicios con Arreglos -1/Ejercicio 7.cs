// Leer 10 números enteros, almacenarlos en un arreglo y determinar a cuánto es igual el promedio entero de los datos del arreglo

class Program
{
    static void Main()
    {
        int[] numeros = new int[10];
        int suma = 0;

        Console.WriteLine("Ingrese 10 números enteros:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Número {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());
            suma += numeros[i];
        }

        int promedio = suma / 10;
        Console.WriteLine($"El promedio entero de los datos del arreglo es: {promedio}");
    }
}
