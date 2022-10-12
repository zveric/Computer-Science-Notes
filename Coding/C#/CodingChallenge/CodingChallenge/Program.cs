using System;

namespace CodingChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string strUsrname;
            double dbleWeight;
            double dbleHight;
            double dbleBmi;

            Console.WriteLine("Welcome to Eric's BMI Calculator\n");
            Console.Write("What is your name?:");
            strUsrname = Console.ReadLine();
            Console.Write("Hi {0}, How heavy are you in KG?:", strUsrname);
            dbleWeight = Convert.ToDouble(Console.ReadLine());
            Console.Write("How tall are you in M?:");
            dbleHight = Convert.ToDouble(Console.ReadLine());
            dbleBmi = dbleWeight / (dbleHight * dbleHight);
            Console.WriteLine("{0}, Your BMI is: {1:F1}", strUsrname, dbleBmi);



            


        }
    }
}
