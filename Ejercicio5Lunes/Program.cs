// Programa que calcula la cantidad de baldes de leche producida en un día
// 1 balde = 20 litros

Console.Write("Ingrese el volumen promedio de leche por vaca (en litros): ");
double litrosPorVaca = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese el número total de vacas ordeñadas: ");
int numeroVacas = Convert.ToInt32(Console.ReadLine());

double litrosTotales = litrosPorVaca * numeroVacas;
double baldes = litrosTotales / 20;

Console.WriteLine("La cantidad total de baldes de leche producida es: " + baldes);
