using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello User! What is your name?");
            string strName = "";
            strName = Console.ReadLine();
            Console.WriteLine("Hi " + strName + " I hope you are well.");
            Console.WriteLine("How old are you?");
            int intAge = 1;
            intAge = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < 5; i++)
            {
                intAge = intAge * 2;
                Console.WriteLine("Twice your age is " + intAge.ToString());
            }
        }
    }
}
