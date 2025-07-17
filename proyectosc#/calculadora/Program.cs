using System.Diagnostics.CodeAnalysis;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("La calculadora de la bebe de la nena chunga");

        Console.WriteLine("Puede elegir entre estas opciones\n" +
        "1. Suma\n2. Resta\n3. Multiplicacion\n4. division");

        string opcion = Console.ReadLine();

        Console.WriteLine("Escriba el primero numero:");
        decimal oneNumber = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Escriba el segundo numero:");
        decimal secondNumber = decimal.Parse(Console.ReadLine());

        switch (opcion)
        {
            case "1":
                decimal suma = oneNumber + secondNumber;
                Console.WriteLine("El resultado de la suma es: " + suma);
                break;
            case "2":
                decimal resta = oneNumber - secondNumber;
                Console.WriteLine("El resultado de la resta es: " + resta);
                break;
            case "3":
                decimal multipla = oneNumber * secondNumber;
                Console.WriteLine("El resultado de la multiplicacion es: " + multipla);
                break;
            case "4":
                if (secondNumber != 0)
                {
                    decimal divide = oneNumber / secondNumber;
                    Console.WriteLine("El resultado de la division es: " + divide);
                }
                else
                {
                    Console.WriteLine("No se puede realizar la division " +
                    $"el {secondNumber} es incorrecto");
                }
                break;
            default:
                Console.WriteLine("Intente de nuevo");
                break;
        } 
    }
}
