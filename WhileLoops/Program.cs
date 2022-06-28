using System;

namespace WhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numberGen = new Random();
            int numberOfAttempts = 0;
            int attempt = 0;

            while (attempt != 6)
            {
                attempt = numberGen.Next(1, 7);
                Console.WriteLine("Tim rolled: " + attempt + ".");
                 numberOfAttempts++;
            }
            Console.WriteLine("It took Tim " + numberOfAttempts + " attempts to roll a six. ");
            
            Console.ReadKey();
        }
    }
}
