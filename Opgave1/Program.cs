
using Opgave3;

Fibonacci fib = new Fibonacci();
Console.WriteLine(fib.fibonacci(10));
while (true)
{
    Console.WriteLine("Enter a number: ");
    string input = Console.ReadLine();
    int tal = int.Parse(input);

    if (tal == 0)
    {
        break;
    }
    else
    {     
        foreach (int i in Enumerable.Range(0, tal))
        {
            Console.WriteLine(fib.fibonacci(i));
        }
     Console.WriteLine("Fibonacci numbers: ");
   
    }
}





