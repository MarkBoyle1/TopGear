using System;
using Microsoft.VisualBasic.CompilerServices;

namespace TopGear
{
    public class Program
    {
        static void Main(string[] args)
        {
            TopGear topGear = new TopGear();
            GearRanges gearRanges = new GearRanges();
            
            int currentGear = topGear.autoTransmission(1000, 3, gearRanges.gearRanges);
            Console.WriteLine(currentGear);
        }
    }
}