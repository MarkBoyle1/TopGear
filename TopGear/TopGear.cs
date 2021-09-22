using System;
using System.Linq;

namespace TopGear
{
    public class TopGear
    {
        public int autoTransmission(int rpm, int gear, int[][] gearRanges)
        {
            int e = 0;

            if (rpm > gearRanges[gear-1].Max() && gear < gearRanges.Length)
                {
                    gear++;
                }
                else if (rpm < gearRanges[gear-1].Min() && gear > 1)
                {
                    gear--;
                }

            e = rpm;
            return gear;
        }
    }
}