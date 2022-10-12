using System;

namespace FormattingTasks
{
    class Program
    {
        static void Main(string[] args)

        {
            int Num1 = 0;
            int Num2 = 0;
            int Num3 = 0;
            int Len = 0;
            int Hei = 0;
            int Dep = 0;
            double Dble1 = 0.0;
            double Dble2 = 0.0;

            
            // Write a program that will output your forename and surname on different lines.
            
            Console.WriteLine("Eric\nTurner\n");

            //Write a program that will output the number 5 on a dice

            Console.Write("ooooooooooo\n" +
                          "o         o\n" +
                          "o #     # o\n" +
                          "o    #    o\n" +
                          "o #     # o\n" +
                          "o         o\n" +
                          "ooooooooooo\n\n");

            //Write a program to output the number 6 as a dice.

            Console.Write("ooooooooooo\n" +
                          "o         o\n" +
                          "o #     # o\n" +
                          "o #     # o\n" +
                          "o #     # o\n" +
                          "o         o\n" +
                          "ooooooooooo\n\n");

            //Write a program that will read in three integers and display the sum.
            
            Console.Write("Enter the first number:");
            Num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number:");
            Num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the third number:");
            Num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The sum is {0} \n", Num1 + Num2 + Num3);


            //Write a program that will read in three test marks out of 100 and output the average

            Console.Write("Enter the first percentage:");
            Num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second percentage:");
            Num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the third percentage:");
            Num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The average is {0} \n", (Num1 + Num2 + Num3) / 3);

            //Enter the length, depth and height of a fish tank in cm. Calculate the volume of water
            //required to fill the tank and display this volume in litres
            
            
            Console.Write("Enter the Height in CM:");
            Hei = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Length in CM:");
            Len = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Depth in CM:");
            Dep = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The volume in Liters is {0} \n", (Len * Dep * Hei)/1000);

            //Write a program that will ask the user for their first name. The program should then concatenate the name with a message,
            //such as ‘Hello Fred. How are you?’ and output this string to the user

            string Name = "";  
            Console.Write("Please enter your name:");
            Name = Console.ReadLine();
            Console.WriteLine("Hello {0}, How are you?:\n", Name);

            

            // Write a program that asks the user to enter two numbers which are allowed to have fractional parts (e.g. 10.45 and 9.3),
            // and displays the product of these two numbers to 2 decimal places, with user-friendly messages.

            Console.Write("Enter first number:");
            Dble1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second number:");
            Dble2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The product of these numbers is: {0:F2}", Dble1 * Dble2);

           

            //Write a program to enter a temperature in degrees Fahrenheit and display the equivalent temperature in degrees Centigrade.
            
            
            Console.Write("Enter a temperature in fahrenheit:");
            Num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The temperature in centigrade is: {0} Degrees", ((Num1 - 32) * (5.0 / 9.0)));

            Console.Write("Enter your height in inches:");
            Dble1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter your weight in stone:");
            Dble2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("You are {0} CM Tall You are {1} KG", (Dble1 * 2.54), (Dble2 * 6.35));






        }
    }
}
