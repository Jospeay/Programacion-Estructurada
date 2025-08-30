// Programa que lee y muestra si un año es bisiesto o no bisiesto utilizando operadores lógicos
Console.WriteLine("Ingresa un año para saber si es bisiesto o no:");
Console.Write("Año: ");
int año = Convert.ToInt32(Console.ReadLine());

if ((año % 4 == 0 && año % 100 != 0) || (año % 400 == 0))
{
    Console.WriteLine($"{año} es un año bisiesto.");
}
else
{
    Console.WriteLine($"{año} no es un año bisiesto.");
}
