using System;
using System.Collections.Generic;
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

            if (String.IsNullOrEmpty(inputString))
                return string.Empty;

            for (int i = inputString.Length - 1; i >= 0; i--)
                result += inputString[i];

            return result;
        }

        public static string ReverseEachString(string inputString)
        {
            string result = "";

            if (string.IsNullOrEmpty(inputString))
                return string.Empty;

            string[] array = inputString.Split(" ");

            for (int i = 0; i < array.Length; i++)
            {
                result += ReverseString(array[i]) + " ";
            }

            return result;
        }

        public static int GetWorldCount(string inputString)
        {
            if (string.IsNullOrEmpty(inputString))
                return 0;
            return inputString.Split(' ').Length;
        }


        public static bool CheckPalindrome(string inputSting)
        {
            bool result = true;

            if (string.IsNullOrEmpty(inputSting))
                return false;

            int min = 0;
            int max = inputSting.Length - 1;

            while (min < max)
            {
                if (inputSting[min] == inputSting[max])
                {
                    max--;
                    min++;
                }
                else
                {
                    return false;
                }
            }

            return result;
        }


        public static char? CheckMaxOccuranceOfChar(string inputSting)
        {
            int numOccuranceOfChar = 0;
            char? occuranceOfChar = null;

            if (string.IsNullOrEmpty(inputSting))
                return null;

            Dictionary<char, int> numOccurances = new Dictionary<char, int>();

            for (int i = 0; i < inputSting.Length; i++)
            {
                if (!numOccurances.ContainsKey(inputSting[i]))
                {
                    numOccurances.Add(inputSting[i], 1);
                }
                else
                {
                    numOccurances[inputSting[i]]++;
                }
            }

            foreach (KeyValuePair<char, int> item in numOccurances)
            {
                if (item.Value > numOccuranceOfChar)
                {
                    occuranceOfChar = item.Key;
                    numOccuranceOfChar = item.Value;
                }
            }

            return occuranceOfChar;
        }




        public static void GetPossibleSubstring(string inputSting)
        {
            if (!string.IsNullOrEmpty(inputSting))
            {
                for (int i = 0; i < inputSting.Length; i++)
                {
                    for (int j = 0; j < inputSting.Length - i; j++)
                    {
                        Console.WriteLine(inputSting.Substring(i, j + 1));
                    }
                }
            }
        }


        public static void GetFirstCharForEachWord(string inputString)
        {
            if (!string.IsNullOrEmpty(inputString))
            {
                string[] array = inputString.Split(' ');

                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i].Substring(0, 1).ToUpper() + " ");
                }
            }
        }


        public static void BinarySearchOnstring()
        {
            string[] arr = new string[] { "Hi", "Guest", "I", "Mukesh", "Am" };
            Array.Sort(arr); // Am, Guest, Hi, I, Mukesh 
            var index = Array.BinarySearch<string>(arr, "Hi");
            Console.Write("The position of 'Hi' in array is " + index);
        }


        static void Main(string[] args)
        {
            Console.WriteLine(FindDublicate("aaabbbcccddd"));
            Console.WriteLine(FindUnique("aaabbbcccddd"));
            Console.WriteLine(ReverseString("aaabbbcccddd"));
            Console.WriteLine(ReverseEachString("This Is My Name"));
            Console.WriteLine(GetWorldCount("This Is My Name Md. Rubel"));
            Console.WriteLine(CheckPalindrome("madam"));
            Console.WriteLine(CheckMaxOccuranceOfChar("Hello Wwwwworld!"));
            GetPossibleSubstring("abcdef");
            GetFirstCharForEachWord("i love bangladesh");
            BinarySearchOnstring();
            Console.ReadKey();
        }
    }
}
