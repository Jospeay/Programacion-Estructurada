//Tarea sobre calificaciones utilizando Switch para asi poder tener diferentes casos y resultados.
Console.WriteLine("Bienvenido a SwitchTarea");
Console.WriteLine("Favor de ingresar su nota para poder verificar su calificación");
Console.Write("Nota:");

int nota = Convert.ToInt32(Console.ReadLine());

switch (nota)
{
    case >= 90:
        Console.WriteLine("Excelente");
        break;

    case >= 80:
        Console.WriteLine("Bien hecho");
        break;

    case >= 70:
        Console.WriteLine("Pasaste");
        break;

    case >= 60:
        Console.WriteLine("Derecho a rescate");
        break;

    default:
        Console.WriteLine("Reprobado");
        break;
}

  
