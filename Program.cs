using System;

namespace auladepc1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Equivalência de km e milhas");

            Double X = 10;
            Double Y = 1.609;
            Double Divisão = X / Y;
            Console.WriteLine($"{X} / {Y} = {Divisão.ToString("F")}");

            Console.WriteLine("10 km é igual a 6,215040397762586 em milhas");
        }
    }
}
