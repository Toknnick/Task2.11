using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._11
{
    class Program
    {
        static void Main(string[] args)
        {
            int bracketBalance = 0;
            int minStreak = 1;
            int streak = 1;
            int maxStreak = 1;
            char previousSymbol = ' '; 
            string brackets = ")((()))";

            if (brackets[0] == '(' && brackets[brackets.Length - 1] == ')')
            {
                foreach (var symbol in brackets)
                {
                    if (symbol == '(')
                        bracketBalance++;
                    else
                        bracketBalance--;

                    if (bracketBalance < 0)
                    {
                        Console.WriteLine("Закрывающих скобок больше.");
                        break;
                    }

                    if (symbol == previousSymbol)
                        streak++;
                    else
                        streak = minStreak;

                    if (streak > maxStreak)
                        maxStreak = streak;
                }

                if (bracketBalance == 0)
                    Console.WriteLine($"Строка корректная и макс глубина - {maxStreak}");
                else
                    Console.WriteLine("Открыващих скобок больше.");
            }
            else
            {
                Console.WriteLine("Нельзя начинать с ')' или заканчивать '('.");
            }
        }
    }
}
