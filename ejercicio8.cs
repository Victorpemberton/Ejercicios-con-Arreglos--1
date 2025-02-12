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

        int contadorNegativos = 0;
        foreach (int numero in numeros)
        {
            if (numero < 0)
            {
                contadorNegativos++;
            }
        }

        Console.WriteLine($"Cantidad de números negativos en el arreglo: {contadorNegativos}");
    }
}
