using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpConcepts
{
    internal class Funcexample
    {
        public static void FuncExample()
        {
            Console.WriteLine("Enter value between 1- 10");
            string input = Console.ReadLine();

            int number;
            bool result = Int32.TryParse(input, out number);

            if (result)
            {
                int res = GetThreeTimesNumber(number, DoubletheNumber);
                Console.WriteLine($"Three times of the number is  {res}");
            }            

            //Example - 2 ---Func - Gets Reverse name.           
            var reverseName = GetCompleteName(1, s => GetReverseName(s.fname, s.sname));
            Console.WriteLine($"The Reverse Name is {reverseName}");

            //Example - 3 ---Func - Gets complete name.            
            ValidateUser();
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

        public class student
        {
            public string fname { get; set; }
            public string sname { get; set; }
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
