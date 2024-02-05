namespace Ej2.fechas;

class Program
{

    public static void Main(string[] args)
    {
        DateTime fecha = DateTime.Now;

        Console.WriteLine("El día");
        Console.WriteLine(fecha.Day);
        Console.WriteLine("----------");
        Console.WriteLine("El mes");
        Console.WriteLine(fecha.Month);
        Console.WriteLine("----------");
        Console.WriteLine("El año");
        Console.WriteLine(fecha.Year);
        Console.WriteLine("----------");
        Console.WriteLine("La hora");
        Console.WriteLine(fecha.Hour);
        Console.WriteLine("----------");
        Console.WriteLine("Los minutos");
        Console.WriteLine(fecha.Minute);
        Console.WriteLine("Los segundos");
        Console.WriteLine(fecha.Second);
        Console.WriteLine("----------");
        Console.WriteLine("El día de la semana");
        Console.WriteLine(fecha.DayOfWeek);
        Console.WriteLine("----------");
        Console.WriteLine("El día del año");
        Console.WriteLine(fecha.DayOfYear);




    }


}
