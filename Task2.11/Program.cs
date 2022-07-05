using System;

namespace Task2._11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string backets = "(()(()))";
            bool isRight = false;
            bool isWrong = false;
            int depthOfBackets = 0;
            char[] expressionOfBackets = backets.ToCharArray();

            while (isRight == false && isWrong == false)
            {
                string tempString = "";
                depthOfBackets++;

                for (int i = 0; i < expressionOfBackets.Length - 1; i++)
                {
                    if (expressionOfBackets[i] == '(' && expressionOfBackets[i + 1] == ')')
                    {
                        expressionOfBackets[i] = '.';
                        expressionOfBackets[i + 1] = '.';
                    }
                }

                foreach (char symbol in expressionOfBackets)
                {
                    if (symbol != '.')
                    {
                        tempString += symbol;
                    }
                }

                if (tempString == "")
                {
                    isRight = true;
                }

                if (expressionOfBackets.Length == tempString.Length)
                {
                    isWrong = true;
                }

                expressionOfBackets = tempString.ToCharArray();
            }

            if (isRight == true)
            {
                Console.WriteLine($"Скобки расставлены правильно\nМаксимальная глубина скобок: {depthOfBackets}");
            }
            else if (isWrong == true)
            {
                Console.WriteLine("Скобки расставлены неправильно");
            }
        }
    }
}
