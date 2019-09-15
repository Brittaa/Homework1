using System;

namespace Homework1
{
    class Program
    {

        public static bool BetweenRanges(int a, int b, int number)


        {
            return (a <= number && number <= b);

        }
   

        static void Main(string[] args)

        { 

                Console.WriteLine("Hello!");

                string firstName;
                string lastName;


                Console.WriteLine("What is your first name?");
                firstName = Console.ReadLine();
                Console.WriteLine("Hello, " + firstName + "!");

                Console.WriteLine("What is your last name?");
                lastName = Console.ReadLine();
                Console.WriteLine("Nice to meet you, {0} {1}!", firstName, lastName);
                



                Console.WriteLine("How old are you?");
                int numberOfYearsInput = Convert.ToInt16(Console.ReadLine());

                while (!BetweenRanges(20, 65, numberOfYearsInput))
                {
                    Console.WriteLine("This program only gives accurate results between the ages of 20-65 and body mass index is not calculated.");
                    numberOfYearsInput = Convert.ToInt16(Console.ReadLine());
                }

                Console.WriteLine("To calculate your BMI, please insert your body height in m: ");
                double height;
                height = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Your weight in kg: ");
                double weight;
                weight = Convert.ToDouble(Console.ReadLine());

                double bmi = weight/(height*height);
                Console.WriteLine("Your BMI is: {0}", Math.Round(bmi, 4));

                if (bmi < 18.5)
                Console.WriteLine("You are underweight.");
                else if (bmi > 18.5 && bmi < 23)
                Console.WriteLine("You are normal weight.");
                else if (bmi > 23)
                Console.WriteLine("You are overweight.");



        }

    }
}
