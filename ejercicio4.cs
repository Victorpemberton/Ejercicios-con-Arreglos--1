

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

        int contador = 0;
        foreach (int numero in numeros)
        {
            if (ComienzaConDigitoPrimo(numero))
            {
                contador++;
            }
        }

        Console.WriteLine($"Cantidad de números que comienzan con un dígito primo: {contador}");
    }

    static bool ComienzaConDigitoPrimo(int numero)
    {
        string numStr = Math.Abs(numero).ToString();
        char primerDigito = numStr[0];

        return primerDigito == '2' || primerDigito == '3' || primerDigito == '5' || primerDigito == '7';
    }
}

