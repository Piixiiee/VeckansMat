using System;
using System.Collections.Generic;
using System.IO;

namespace VeckansMat
{
    class Program
    {
        static void Main(string[] args)
        {

            string filePath = Path.GetFullPath("..\\..\\..\\VeckansMatMatlista.txt");
            string[] listOfFoods = System.IO.File.ReadAllLines(filePath);
            List<string> allMeals = new List<string>(listOfFoods);
            Random random = new Random(); 
            bool satisfied = false;

            //Programmet frågar efter antal rätter och loppar en while loop så länge användaren inte är satisfied
            Console.WriteLine("Hur många rätter vill du ha?");
            int amount = Convert.ToInt32(Console.ReadLine());
            while (!satisfied)
            {
                //Lista för dom index som slumpas fram

                List<int> chosenIndexes = new List<int>();

                // For loop för att se till att en maträtt bara kan uppkomma en gång 

                for (int i = 0; chosenIndexes.Count < amount; i++)
                {
                    int index = random.Next(allMeals.Count);
                    if (!chosenIndexes.Contains(index))
                    {
                        chosenIndexes.Add(index);
                    }
                    
                }
                //For loop för att kolla alla index som blivit slumpade och sedan matcha dom med maträtten som represenetras av ett index
                Console.WriteLine("Här är matlistan:");
                for (int i = 0; i < chosenIndexes.Count; i++)
                {
                    Console.WriteLine(i + 1 + ". " + allMeals[chosenIndexes[i]]);
                }

                // Fråga för att se om programmet ska slumpa nya maträtter eller om användaren är nöjd med sina maträtter 

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
