//Leer una serie de numeros hasta que el usuario ingrese el valor -99 y escriba el numero mayor y el menor 

Console.WriteLine("Bienvenido a LeerNum");
Console.WriteLine("Favor de ingresar una serie de numeros para determinar el mayor y el menor");
int numero, mayor = int.MinValue, menor = int.MaxValue;
Console.WriteLine("Para finalizar ingrese -99");


do
{
    Console.Write("Digite un número: ");
    numero = Convert.ToInt32(Console.ReadLine());

    if (numero != -99)
    {
        if (numero > mayor)
        {
            mayor = numero;
        }
        if (numero < menor)
        {
            menor = numero;
        }
    }
} while (numero != -99);

Console.WriteLine($"El número mayor es: {mayor} y el numero menor es: {menor}");
Console.WriteLine("Fin del programa");
