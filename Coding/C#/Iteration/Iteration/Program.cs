using System;

namespace Iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string strWord;
            char charLetter;
            int intCounter = 0;

            Console.Write("Enter a word:");
            strWord = Console.ReadLine();
            Console.Write("Enter a letter:");
            charLetter = Convert.ToChar(Console.ReadLine());

            foreach (char charL in strWord)
            {
                if (charL == charLetter)
                {
                    intCounter++;
                }
            }

            Console.WriteLine(intCounter);
            

            long longTotal = 1;

            Console.Write("Enter a number:");
            int intNum = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= intNum; i++)
            {
                longTotal = longTotal * i;
            }
            Console.WriteLine(longTotal);
            */

            Console.Write("Enter a binary number:");
            string strBinary = Console.ReadLine();
            for (int i = strBinary.Length-1; i>=0; i--)
            {
                if (strBinary[i] == '1')
                {
                    ans = ans + index
                    index = index * 2
                }
            }

















        }
    }
}
