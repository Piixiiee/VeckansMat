using System;
using System.Collections.Generic;

namespace VeckansMat
{
    class Program
    {

         

        static void Main(string[] args)
        {

            var allMeals = new List<string> { "Spaghetti med sojafärssås", "Currygryta med ris", "Halloumistroganoff med ris",};
            var random = new Random();
            bool satisfied = false;

            Console.WriteLine("Hur många rätter vill du ha?");
            int amount = Convert.ToInt32(Console.ReadLine());
            while (!satisfied)
            {
                Console.WriteLine("Här är matlistan:");
                for (int i = 0; i < amount; i++)
                {
                    int index = random.Next(allMeals.Count);
                    Console.WriteLine(i + 1 + ". " + allMeals[index]);
                }

                Console.WriteLine("Är du nöjd med matlistan? y/n ");
                string answer = Console.ReadLine();
                if (answer == "y")
                {
                    satisfied = true;
                    Console.WriteLine("Varsågod!");
                }
            }
        }
    }
}
