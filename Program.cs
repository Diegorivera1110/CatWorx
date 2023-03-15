﻿using System;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> employees = new List<string>();
            // Collect user values until the value is an empty string
            while (true)
            {
                Console.WriteLine("Please enter a name: ");
                // Get a name from the console and assign it to a variable
                string input = Console.ReadLine() ?? "";
                employees.Add(input);
            }
            for (int i = 0; i < employees.Count; i++)
            {
                Console.WriteLine(employees[i]);
            }

            while (true)
            {
                Console.WriteLine("Please enter a name: (leave empty to exit): ");
                string input = Console.ReadLine() ?? "";
                // Break if the user hits ENTER without typing a name
                if (input == "")
                {
                    break;
                }
            }
        }
    }
}