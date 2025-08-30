// Programa que calcula el volumen de un tanque rectangular en metros cúbicos
// Fórmula: volumen = longitud * ancho * altura

Console.Write("Ingrese la longitud del tanque en metros: ");
double longitud = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese el ancho del tanque en metros: ");
double ancho = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese la altura del tanque en metros: ");
double altura = Convert.ToDouble(Console.ReadLine());

double volumen = longitud * ancho * altura;

Console.WriteLine("El volumen total de agua en el tanque es: " + volumen + " m³");
