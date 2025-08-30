// See https://aka.ms/new-console-template for more information

int num;

Console.WriteLine("Programa para saber si un numéro es positivo o negativo");
Console.WriteLine("Introduce un número");
num = Convert.ToInt32(Console.ReadLine());

if (num >= 0)
{
    Console.WriteLine("El número es positivo");
}
else
{
    Console.WriteLine("El número es negativo");
}
