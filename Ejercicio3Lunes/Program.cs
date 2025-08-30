// Programa que calcula la distancia recorrida por un ciclista
// Fórmula: distancia = velocidad * tiempo

Console.Write("Ingrese la velocidad promedio en km/h: ");
double velocidad = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese el tiempo recorrido en horas: ");
double tiempo = Convert.ToDouble(Console.ReadLine());

double distancia = velocidad * tiempo;

Console.WriteLine("La distancia total recorrida es: " + distancia + " km");
