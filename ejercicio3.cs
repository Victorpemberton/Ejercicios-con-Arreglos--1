static void EncontrarMayorNumeroPrimo(int[] numeros)
{
    int maxPrimo = numeros.Where(EsPrimo).DefaultIfEmpty(int.MinValue).Max();
    int posMaxPrimo = Array.IndexOf(numeros, maxPrimo);
    
    if (maxPrimo == int.MinValue)
        Console.WriteLine("No hay números primos en el arreglo.");
    else
        Console.WriteLine($"El número primo mayor es {maxPrimo} y está en la posición {posMaxPrimo}.");
}
