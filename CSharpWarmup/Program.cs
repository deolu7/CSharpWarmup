using System;
class program
{

    static void Main()
    {
        Console.Write("What is your name?:");
        string name = Console.ReadLine();

        Console.Write($"Hi {name}! Please enter your age as a number:");
        string ageInput = Console.ReadLine();

        int currentYear = DateTime.Now.Year;

        if (int.TryParse(ageInput, out int age))
        {
            if (age >= 100)
            {
                int year100 = currentYear - (age - 100);
                Console.WriteLine($"Hi {name}! Wow, you already turned 100 in the year {year100}!");
            }
            else
            {
                int yearsToGo = 100 - age;
                int year100 = currentYear + yearsToGo;
                Console.WriteLine($"Hi {name}! You'll turn 100 in the year {year100}.");
            }
        }
        else
        {
            Console.WriteLine($"Hi {name}! Please enter your age as a number.");
        }

            
    }


}