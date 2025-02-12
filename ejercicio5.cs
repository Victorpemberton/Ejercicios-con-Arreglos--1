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

        int maxPrimoIndex = -1;
        int maxPares = -1;

        for (int i = 0; i < 10; i++)
        {
            if (EsPrimo(numeros[i]))
            {
                int pares = ContarDigitosPares(numeros[i]);
                if (pares > maxPares)
                {
                    maxPares = pares;
                    maxPrimoIndex = i;
                }
            }
        }

        if (maxPrimoIndex != -1)
        {
            Console.WriteLine($"El número primo con más dígitos pares está en la posición: {maxPrimoIndex}");
        }
        else
        {
            Console.WriteLine("No se encontraron números primos en la lista.");
        }
    }

    static bool EsPrimo(int numero)
    {
        if (numero < 2) return false;
        for (int i = 2; i * i <= numero; i++)
        {
            if (numero % i == 0) return false;
        }
        return true;
    }

    static int ContarDigitosPares(int numero)
    {
        int count = 0;
        foreach (char digito in Math.Abs(numero).ToString())
        {
            if ((digito - '0') % 2 == 0)
            {
                count++;
            }
        }
        return count;
    }
}
