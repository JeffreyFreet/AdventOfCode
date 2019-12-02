﻿using System;
using System.IO;

namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = (System.IO.File.ReadAllText(@"C:\Users\jeffrey.freet\Desktop\Advent of Code\Day 1\Day1\Day1\Input.txt").Split('\n'));
            double mass = 0;
            double totalMass = 0;

            foreach (string moduleMass in input)
            {
                mass += Math.Floor(Convert.ToDouble(moduleMass) / 3) - 2;
                totalMass += calculatefuelneededforfuel(Convert.ToDouble(moduleMass));
            }

            Console.WriteLine(mass);
            Console.WriteLine(totalMass);

            Console.WriteLine("Press any key to quit...");
            Console.ReadKey();
        }

        static double calculatefuelneededforfuel(double mass)
        {
            double fuelneeded = Math.Floor(mass / 3) - 2;

            if (fuelneeded > 0)
                return fuelneeded + calculatefuelneededforfuel(fuelneeded);

            return 0;
        }
    }
}
