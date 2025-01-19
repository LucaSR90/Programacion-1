using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\nSeleccione un ejercicio para ejecutar:");
            Console.WriteLine("1. Sumar los dígitos de un número de dos dígitos");
            Console.WriteLine("2. Determinar si un número de dos dígitos es primo y negativo");
            Console.WriteLine("3. Verificar si ambos dígitos de un número son primos");
            Console.WriteLine("4. Determinar si la suma de dos números es par");
            Console.WriteLine("5. Identificar la posición del mayor dígito de un número de tres dígitos");
            Console.WriteLine("6. Determinar si algún dígito de un número de tres dígitos es múltiplo de los otros");
            Console.WriteLine("7. Encontrar el mayor de tres números usando dos variables");
            Console.WriteLine("8. Verificar si un número de cinco dígitos es capicúa");
            Console.WriteLine("9. Verificar si el segundo dígito de un número de cuatro dígitos es igual al penúltimo");
            Console.WriteLine("10. Mostrar los números entre dos números si la diferencia es <= 10");
            Console.WriteLine("0. Salir");

            Console.Write("Ingrese su opción: ");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    SumarDigitos();
                    break;
                case 2:
                    DeterminarPrimoNegativo();
                    break;
                case 3:
                    VerificarDigitosPrimos();
                    break;
                case 4:
                    DeterminarSumaPar();
                    break;
                case 5:
                    IdentificarMayorDigito();
                    break;
                case 6:
                    DeterminarDigitoMultiplo();
                    break;
                case 7:
                    EncontrarMayor();
                    break;
                case 8:
                    VerificarCapicua();
                    break;
                case 9:
                    VerificarSegundoIgualPenultimo();
                    break;
                case 10:
                    MostrarNumerosEntreRango();
                    break;
                case 0:
                    return;
                default:
                    Console.WriteLine("Opción inválida. Intente de nuevo.");
                    break;
            }
        }
    }

    static void SumarDigitos()
    {
        Console.Write("Ingrese un número entero de dos dígitos: ");
        int numero = int.Parse(Console.ReadLine());
        int suma = (numero / 10) + (numero % 10);
        Console.WriteLine($"La suma de los dígitos es: {suma}");
    }

    static void DeterminarPrimoNegativo()
    {
        bool esPrimo(int n)
        {
            if (n <= 1) return false;
            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        Console.Write("Ingrese un número entero de dos dígitos: ");
        int numero = int.Parse(Console.ReadLine());
        if (numero < 0)
        {
            Console.WriteLine($"El número es negativo y {(esPrimo(-numero) ? "primo" : "no primo")}.");
        }
        else
        {
            Console.WriteLine($"El número no es negativo y {(esPrimo(numero) ? "primo" : "no primo")}.");
        }
    }

    static void VerificarDigitosPrimos()
    {
        bool esPrimo(int n)
        {
            if (n <= 1) return false;
            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        Console.Write("Ingrese un número entero de dos dígitos: ");
        int numero = Math.Abs(int.Parse(Console.ReadLine()));
        int digito1 = numero / 10;
        int digito2 = numero % 10;
        if (esPrimo(digito1) && esPrimo(digito2))
        {
            Console.WriteLine("Ambos dígitos son primos.");
        }
        else
        {
            Console.WriteLine("No ambos dígitos son primos.");
        }
    }

    static void DeterminarSumaPar()
    {
        Console.Write("Ingrese el primer número entero de dos dígitos: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el segundo número entero de dos dígitos: ");
        int num2 = int.Parse(Console.ReadLine());
        Console.WriteLine((num1 + num2) % 2 == 0 ? "La suma es par." : "La suma no es par.");
    }

    static void IdentificarMayorDigito()
    {
        Console.Write("Ingrese un número entero de tres dígitos: ");
        int numero = Math.Abs(int.Parse(Console.ReadLine()));
        int digito1 = numero / 100;
        int digito2 = (numero / 10) % 10;
        int digito3 = numero % 10;
        if (digito1 >= digito2 && digito1 >= digito3)
        {
            Console.WriteLine("El mayor dígito está en la posición 1.");
        }
        else if (digito2 >= digito1 && digito2 >= digito3)
        {
            Console.WriteLine("El mayor dígito está en la posición 2.");
        }
        else
        {
            Console.WriteLine("El mayor dígito está en la posición 3.");
        }
    }

    static void DeterminarDigitoMultiplo()
    {
        Console.Write("Ingrese un número entero de tres dígitos: ");
        int numero = Math.Abs(int.Parse(Console.ReadLine()));
        int digito1 = numero / 100;
        int digito2 = (numero / 10) % 10;
        int digito3 = numero % 10;

        bool multiploEncontrado = false;

        if (digito2 != 0 && digito1 % digito2 == 0)
        {
            Console.WriteLine($"El dígito {digito1} es múltiplo de {digito2}.");
            multiploEncontrado = true;
        }
        if (digito3 != 0 && digito1 % digito3 == 0)
        {
            Console.WriteLine($"El dígito {digito1} es múltiplo de {digito3}.");
            multiploEncontrado = true;
        }
        if (digito1 != 0 && digito2 % digito1 == 0)
        {
            Console.WriteLine($"El dígito {digito2} es múltiplo de {digito1}.");
            multiploEncontrado = true;
        }
        if (digito3 != 0 && digito2 % digito3 == 0)
        {
            Console.WriteLine($"El dígito {digito2} es múltiplo de {digito3}.");
            multiploEncontrado = true;
        }
        if (digito1 != 0 && digito3 % digito1 == 0)
        {
            Console.WriteLine($"El dígito {digito3} es múltiplo de {digito1}.");
            multiploEncontrado = true;
        }
        if (digito2 != 0 && digito3 % digito2 == 0)
        {
            Console.WriteLine($"El dígito {digito3} es múltiplo de {digito2}.");
            multiploEncontrado = true;
        }

        if (!multiploEncontrado)
        {
            Console.WriteLine("Ningún dígito es múltiplo de los otros.");
        }
    }

    static void EncontrarMayor()
    {
        Console.Write("Ingrese el primer número entero: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el segundo número entero: ");
        int num2 = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el tercer número entero: ");
        int num3 = int.Parse(Console.ReadLine());
        int mayor = Math.Max(num1, Math.Max(num2, num3));
        Console.WriteLine($"El mayor número es: {mayor}");
    }

    static void VerificarCapicua()
    {
        Console.Write("Ingrese un número entero de cinco dígitos: ");
        int numero = Math.Abs(int.Parse(Console.ReadLine()));
        if (numero / 10000 == numero % 10 && (numero / 1000) % 10 == (numero / 10) % 10)
        {
            Console.WriteLine("El número es capicúa.");
        }
        else
        {
            Console.WriteLine("El número no es capicúa.");
        }
    }

    static void VerificarSegundoIgualPenultimo()
    {
        Console.Write("Ingrese un número entero de cuatro dígitos: ");
        int numero = Math.Abs(int.Parse(Console.ReadLine()));
        if ((numero / 100) % 10 == (numero / 10) % 10)
        {
            Console.WriteLine("El segundo dígito es igual al penúltimo.");
        }
        else
        {
            Console.WriteLine("El segundo dígito no es igual al penúltimo.");
        }
    }

    static void MostrarNumerosEntreRango()
    {
        Console.Write("Ingrese el primer número entero: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el segundo número entero: ");
        int num2 = int.Parse(Console.ReadLine());
        int menor = Math.Min(num1, num2);
        int mayor = Math.Max(num1, num2);
        if (mayor - menor <= 10)
        {
            for (int i = menor; i <= mayor; i++)
            {
                Console.WriteLine(i);
            }
        }
        else
        {
            Console.WriteLine("La diferencia entre los números es mayor a 10.");
        }
    }
}
