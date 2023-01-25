using System;
using System.Text;

namespace ProblemSolvingDemoTwo
{
    class Program
    {

        public static StringBuilder FindDublicate(string inputString)
        {
            StringBuilder result = new StringBuilder();
            StringBuilder duplicate = new StringBuilder();

            foreach (var item in inputString)
            {
                if (result.ToString().IndexOf(item.ToString().ToLower()) == -1)
                {
                    result.Append(item);
                }
                else
                {
                    duplicate.Append(item);
                }
            }

            return duplicate;
        }

        public static StringBuilder FindUnique(string inputString)
        {
            StringBuilder result = new StringBuilder();
            StringBuilder duplicate = new StringBuilder();
            foreach (var item in inputString)
            {
                if (result.ToString().IndexOf(item.ToString().ToLower()) == -1)
                {
                    result.Append(item);
                }
                else
                {
                    duplicate.Append(item);
                }
            }
            return result;
        }


        public static string ReverseString(string inputString)
        {
            string result = "";
            for (int i = inputString.Length-1; i > 0; i--)
            {
                result += inputString[i];
            }
            return result;
        }


        static void Main(string[] args)
        {
            Console.WriteLine(FindDublicate("aaabbbcccddd"));
            Console.WriteLine(FindUnique("aaabbbcccddd"));
            Console.WriteLine(ReverseString("aaabbbcccddd"));
            Console.WriteLine("Hello World!");
        }
    }
}
