using System;

namespace NumberGuesser2
{
    class Program
    {
        static void Main(string[] args)
        {
            int intUpper;
            int intLower;
            int intMid;
            string strCorrect;
            intUpper = 100;
            intLower = 0;
            intMid = 50;
            bool gameOver = false;


            while (gameOver == false)
            {
                Console.Write("Is your number {0}? 1:Too Large 2:Too Small 3:Just right", intMid);
                strCorrect = Console.ReadLine();
                if (strCorrect == "3")
                {
                    Console.WriteLine("I got it");
                    gameOver = true;
                }
                else if (strCorrect == "1")
                {
                    intLower = intMid;
                }
                else if (strCorrect == "2")
                {
                    intUpper = intMid;
                }
            }
           
        }
    }
}
