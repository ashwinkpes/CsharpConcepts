using System;

namespace CSharpConcepts
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Showmenu();
            }
        }

        private static void Showmenu()
        {
            Console.WriteLine("Select task to perform...");
            Console.WriteLine("Enter 1 for Func");
            Console.WriteLine("Enter 2 for Action");
            Console.WriteLine("Enter 0 for exit");

            ConsoleKeyInfo keyInfo = Console.ReadKey(true);

            switch(keyInfo.Key)
            {
                case ConsoleKey.D1: Console.WriteLine("1 was pressed , 3 examples of Func will get executed"); Funcexample.FuncExample(); break;
                case ConsoleKey.D2: Console.WriteLine("2 was pressed"); break;
                case ConsoleKey.D0: Console.WriteLine("0 was pressed"); Environment.Exit(-1); break;
                default: Console.WriteLine("Enter valid input!!!"); break;
            }
        }

        
        
    }
}
