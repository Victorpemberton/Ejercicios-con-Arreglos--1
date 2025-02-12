static void EncontrarMayorNumero(int[] numeros)
{
    int maxValor = numeros.Max();
    int posMax = Array.IndexOf(numeros, maxValor);
    Console.WriteLine($"El número mayor es {maxValor} y está en la posición {posMax}.");
}

