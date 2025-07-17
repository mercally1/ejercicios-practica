using System.Reflection.Metadata;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Los dias de la semana\n" +
        "Ingrese un numero entre 1 al 7" +
        "1. Lunes\n2. Martes\n3. Miercoles\n4. Jueves\n5. Viernes\n6. Sabado\n7. Domingo");

        decimal diaSemana = decimal.Parse(Console.ReadLine());

        if (diaSemana <= 7)
        {
            switch (diaSemana)
            {
                case 1:
                    Console.WriteLine("lunes");
                    break;
                case 2:
                    Console.WriteLine("Martes");
                    break;
                case 3:
                    Console.WriteLine("Miercoles");
                    break;
                case 4:
                    Console.WriteLine("Jueves");
                    break;
                case 5:
                    Console.WriteLine("Viernes");
                    break;
                case 6:
                    Console.WriteLine("Sabado");
                    break;
                case 7:
                    Console.WriteLine("domingo");
                    break;
                default:
                    Console.WriteLine("dia de la semana no existe");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Numero invalido, intentelo de nuevo");
        }
    }
}
