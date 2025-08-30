// Programa que calcula el área en manzanas de un terreno rectangular
// 1 manzana = 1428.8 varas²

Console.Write("Ingrese la longitud del terreno en varas: ");
double longitud = Convert.ToDouble(Console.ReadLine());

// Utilizamos un ancho fijo de 5 varas
double ancho = 5;

// Hacemos el cálculo del área en varas²
double areaVaras = longitud * ancho;

// Convertimos el área a manzanas
double areaManzanas = areaVaras / 1428.8;

Console.WriteLine("El área total del terreno es: " + areaManzanas + " manzanas");
