static void EncontrarMayorNumeroPar(int[] numeros)
{
    int maxPar = numeros.Where(n => n % 2 == 0).DefaultIfEmpty(int.MinValue).Max();
    int posMaxPar = Array.IndexOf(numeros, maxPar);
    
    if (maxPar == int.MinValue)
        Console.WriteLine("No hay números pares en el arreglo.");
    else
        Console.WriteLine($"El número par mayor es {maxPar} y está en la posición {posMaxPar}.");
}
