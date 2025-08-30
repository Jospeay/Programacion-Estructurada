// See https://aka.ms/new-console-template for more information

int calificacion = 85;
Console.WriteLine("Proyecto de Notas");
Console.WriteLine("Por favor ingresa tu calificación");
calificacion = Convert.ToInt32(Console.ReadLine());

if (calificacion >= 70)
{
    Console.WriteLine("Aprobaste el curso");
}
else if (calificacion >= 50 && calificacion <=69)
{
    Console.WriteLine("Iras a recuperación");
}
else if (calificacion <= 50)
{
    Console.WriteLine("Reprobaste el curso");
}
