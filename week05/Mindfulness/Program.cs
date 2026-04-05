using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<string> history = new List<string>();
        string choice = "";

        while (choice != "6")
        {
            Console.Clear();
            Console.WriteLine("=== Mindfulness Program ===\n");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Gratitude Activity");
            Console.WriteLine("5. View History");
            Console.WriteLine("6. Quit");
            Console.Write("\nChoose: ");

            choice = Console.ReadLine();

            if (choice == "1")
            {
                new BreathingActivity().Run();
                history.Add("Breathing - " + DateTime.Now);
            }
            else if (choice == "2")
            {
                new ReflectingActivity().Run();
                history.Add("Reflecting - " + DateTime.Now);
            }
            else if (choice == "3")
            {
                new ListingActivity().Run();
                history.Add("Listing - " + DateTime.Now);
            }
            else if (choice == "4")
            {
                new GratitudeActivity().Run();
                history.Add("Gratitude - " + DateTime.Now);
            }
            else if (choice == "5")
            {
                Console.Clear();
                Console.WriteLine("=== History ===\n");

                foreach (string item in history)
                {
                    Console.WriteLine(item);
                }

                Console.WriteLine("\nPress Enter...");
                Console.ReadLine();
            }
        }
    }
}

/*
EXCEEDING REQUIREMENTS:
- Added Gratitude Activity
- Added activity history tracking
- Improved animations
*/