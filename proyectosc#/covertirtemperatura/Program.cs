// See https://aka.ms/new-console-template for more information
Console.WriteLine("CONVERTIR TEMPERATURA");

Console.WriteLine("Elige una opcion de la siguientes\n " +
"1. Celsius → Fahrenheit\n 2. Celsius → Kelvin\n 3. Fahrenheit → Celsius\n 4. Fahrenheit → Kelvin\n" +
" 5. Kelvin → Celsius\n 6. Kelvin → Fahrenheit");

string opcion = Console.ReadLine();

switch (opcion)
{
    case "1":
        Console.WriteLine("Convertir Celsius a Fahrenheit");
        Console.WriteLine("Ingrese la cantidad que desea convertir:");
        double fahrenheit = Double.Parse(Console.ReadLine());
        double conversion = (fahrenheit * 1.8) + 32;
        Console.WriteLine($"La temperatura es\n{Math.Ceiling(conversion)} F");
        break;
    case "2":
        Console.WriteLine("Convertir Celsius a Kelvin");
        Console.WriteLine("Ingrese la cantidad que desea convertir:");
        double kelvin = Double.Parse(Console.ReadLine());
        double conkelvin = kelvin + 273.15;
        Console.WriteLine($"La temperatura es\n {Math.Ceiling(conkelvin)} K");
        break;
    case "3":
        Console.WriteLine("Convertir Fahrenheit a Celsius");
        Console.WriteLine("Ingrese la cantidad que desea convertir:");
        double Celsius = Double.Parse(Console.ReadLine());
        double converCelsius = (Celsius - 32) * 32;
        Console.WriteLine($"La temperatura es\n {Math.Ceiling(converCelsius)} C");
        break;
    case "4":
        Console.WriteLine("Convertir Fahrenheit a Kelvin");
        Console.WriteLine("Ingrese la cantidad que desea convertir:");
        double fKelvin = Double.Parse(Console.ReadLine());
        double converKelvin = (fKelvin - 32) * 1.8 + 273.15;
        Console.WriteLine($"La temperatura es\n{Math.Ceiling(converKelvin)} K");
        break;
    case "5":
        Console.WriteLine("Convertir Kelvin a Celsius ");
        Console.WriteLine("Ingrese la cantidad que desea convertir:");
        double kCelsius = Double.Parse(Console.ReadLine());
        double convekelvin = kCelsius - 273.15;
        Console.WriteLine($"La temperatura es\n {Math.Ceiling(convekelvin)} C");
        break;
    case "6":
        Console.WriteLine("Convertir Kelvin a Fahrenheit");
        Console.WriteLine("Ingrese la cantidad que desea convertir:");
        double kfahren = Double.Parse(Console.ReadLine());
        double converfahren = (kfahren - 273.15) * 1.8 + 32;
        Console.WriteLine($"La temperatura es\n {Math.Ceiling(converfahren)} C");
        break;
    default:
        Console.WriteLine("Esta conversion no existe");
        break;    
}



