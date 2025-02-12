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

        int suma = 0;
        foreach (int numero in numeros)
        {
            suma += numero;
        }

        int promedio = suma / 10;
        Console.WriteLine($"El promedio entero de los datos del arreglo es: {promedio}");
    }
}

