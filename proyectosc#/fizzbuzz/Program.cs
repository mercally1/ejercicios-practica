
class Program
{
    public static void Main(string[] args)
    {
        for (int i = 1; i <= 100; i++)
        {
            var divisortres = i % 3 == 0;
            var divisorcinco = i % 5 == 0;

            if (divisortres && divisorcinco)
            {
                Console.WriteLine($"{i}.- Fizzbuzz\n");
            }
            else if (divisortres)
            {
                Console.WriteLine($"{i}.- Fizz\n");
            }
            else if (divisorcinco)
            {
                Console.WriteLine($"{i}.- buzz \n");
            }
            else
            {
                Console.WriteLine($"{i}\n");
            }
        }
    }
}
