Console.WriteLine("Bienvenido a EjerciciopracticaViernes");

// Realización de la suma de números pares e impares del 1 al 200
int i, sumapar = 0, sumaimpar = 0;
for (i = 1; i < 200; i++)
{
    if (i % 2 == 0)
    {
        sumapar += i;
    }
    else
    {
        sumaimpar += i;
    }
}

Console.WriteLine($"La suma de los números pares es: {sumapar}");
Console.WriteLine($"La suma de los números impares es: {sumaimpar}");
Console.WriteLine("Fin del programa");
