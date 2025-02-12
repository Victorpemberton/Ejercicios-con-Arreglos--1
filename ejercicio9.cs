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

        Console.WriteLine("Factoriales de los números ingresados:");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Número: {numeros[i]}, Factorial: {factoriales[i]}");
        }
    }

    static long CalcularFactorial(int numero)
    {
        if (numero < 0) return -1; 
        long factorial = 1;
        for (int i = 1; i <= numero; i++)
        {
            factorial *= i;
        }
        return factorial;
    }
}
