using System;

namespace CSharpConcepts
{
    internal class Funcexample
    {
        internal static void FuncExample()
        {
            Console.WriteLine("Enter value between 1- 10");
            string input = Console.ReadLine();

            int number;
            bool result = Int32.TryParse(input, out number);

            if (result && (number >= 1 && number <= 10))
            {
                //Example -1 ---Func - Gets 3 times of the number.     
                int res = GetThreeTimesNumber(number, DoubletheNumber);
                Console.WriteLine($"Three times of the number is  {res}");

                //Example - 2 ---Func - Gets Reverse name.           
                var reverseName = GetCompleteName(1, s => GetReverseName(s.fname, s.sname));
                Console.WriteLine($"The Reverse Name is {reverseName}");

                //Example - 3 ---Func - Gets complete name.            
                ValidateUser();
            }
            else
            {
                Console.WriteLine("Invalid input!!!");
            }           

          
        }

        private static int GetThreeTimesNumber(int userInput, Func<int, int> secondInput)
        {
            return userInput + DoubletheNumber(userInput);
        }

        private static int DoubletheNumber(int firstNumber)
        {
            return firstNumber * 2;
        }

        private static string GetCompleteName(int id, Func<student, string> fullName)
        {
            string completename = string.Empty;
            if (id == 1)
            {
                completename = fullName(new student { fname = "Ashwin", sname = "Kumar" });
            }

            return completename;
        }

        private static string GetReverseName(string fname, string sname)
        {

            return (sname + " " + fname).ToUpper();
        }

        private static void ValidateUser()
        {
            Func<string, string, string> concatenateuser = (x, y) => x + y;
            GetConcatenatedName(concatenateuser);
        }

        private static void GetConcatenatedName(Func<string, string, string> getFullName)
        {
            Console.WriteLine($"The complete name is {getFullName("Ashwin", "Kumar.H")}");
        }
    }
}
