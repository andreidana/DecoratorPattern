using System;

namespace DecoratorExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ISport footballer = new Footballer();
            Console.WriteLine($"A footballer runs with {footballer.Run()} km/h");

            ISport kepper = new Keeper();
            Console.WriteLine($"A keeper runs with {kepper.Run()} km/h");

            ISport fieldPlayer = new FieldPlayer();
            Console.WriteLine($"A fieldPlayer runs with {fieldPlayer.Run()} km/h");
        }
    }
}
