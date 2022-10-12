using System;

namespace Selection
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            int intAge;
            Console.Write("How old are you?:");
            intAge = Convert.ToInt32(Console.ReadLine());

            if (intAge == 16)
            {
                Console.WriteLine("You cant drive a car. However you can drive a Tractor and a Motoscooter");
            }
            else if (intAge < 17)
            {
                Console.WriteLine("You can't drive");
            }
            else if (intAge >= 17)
            {
                Console.WriteLine("You can drive");
            }

            int intWindspeed;
            Console.Write("What is the wind speed in miles per hour?:");
            intWindspeed = Convert.ToInt32(Console.ReadLine());
            if (intWindspeed < 20)
            {
                Console.WriteLine("That is a Breeze");
            }
            else if (intWindspeed > 50)
            {
                Console.WriteLine("That is a Storm");
            }
            else if (intWindspeed <= 20)
            {
                Console.WriteLine("That is a Gale");
            }


            
            Double dbleWorkedhours;
            Double dbleWage;

            Console.Write("How many hours did you work last week? (For 1Hr 30Mins put 1.5 ect):");
            dbleWorkedhours = Convert.ToDouble(Console.ReadLine());
            if (dbleWorkedhours > 0.0 && dbleWorkedhours < 60)
            {
                Console.Write("How much do you earn per hour in £s?:");
                dbleWage = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("You made {0:C2}", dbleWorkedhours * dbleWage);
            }
           else
            {
                Console.WriteLine("That looks incorrect. You can only work between 0-60 Hours")
            }
            */
            int intMarks;
            Console.Write("How many marks did you acheive?:");
            intMarks = Convert.ToInt32(Console.ReadLine());

            switch (intMarks)
            {
                case int i when i > 90:
                    Console.WriteLine("You got an A*");
                    break;
                case int i when i >= 80 && i < 90:
                    Console.WriteLine("You got an A");
                    break;
                case int i when i >= 70 && i < 80:
                    Console.WriteLine("You got an B");
                    break;
                case int i when i >= 60 && i < 70:
                    Console.WriteLine("You got a C");
                    break;
                case int i when i >= 50 && i > 60:
                    Console.WriteLine
                
                
                
                
                default:
                    break;
            }

        }
    }
}
