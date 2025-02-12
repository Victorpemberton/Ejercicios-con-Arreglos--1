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

        Console.Write("Ingrese un número entero adicional: ");
        int numeroExtra = int.Parse(Console.ReadLine());

        int contadorDivisores = 0;
        foreach (int numero in numeros)
        {
            if (numero != 0 && numeroExtra % numero == 0)
            {
                contadorDivisores++;
            }
        }

        Console.WriteLine($"El número {numeroExtra} tiene {contadorDivisores} divisores exactos en el arreglo.");
    }
}
