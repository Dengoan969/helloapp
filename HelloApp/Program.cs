using System;

namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello everyone");
            WhiteGreeting();
            GreetBlack();
        }
        public static void WhiteGreeting()
        {
            Console.WriteLine("hello white");
        }
        
        public static void GreetBlack()
        {
            Console.WriteLine("hello black");
        }
    }
}
