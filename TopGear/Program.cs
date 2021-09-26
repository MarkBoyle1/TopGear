using System;
using Microsoft.VisualBasic.CompilerServices;

namespace TopGear
{
    public class Program
    {
        static void Main(string[] args)
        {
            TopGear topGear = new TopGear(3);

            topGear.SelectGear(1000);
        }
    }
}