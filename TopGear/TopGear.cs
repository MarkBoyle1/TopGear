using System;
using System.Linq;

namespace TopGear
{
    public class TopGear
    {
        private GearRanges _gearRanges;
        private int _gear;
        private int gearRpmMax;
        private int gearRpmMin;

        private int totalNumberOfGears;

        public TopGear(int gear)
        {
            _gear = gear;
            _gearRanges = new GearRanges();
            gearRpmMax = _gearRanges.gearRanges[_gear - 1].Max();
            gearRpmMin = _gearRanges.gearRanges[_gear - 1].Min();
            totalNumberOfGears = _gearRanges.gearRanges.Length;
        }
        public int SelectGear(int rpm)
        {
            if (rpm > gearRpmMax && _gear < totalNumberOfGears)
            {
                _gear++;
            }
            else if (rpm < gearRpmMin && _gear > 1)
            {
                _gear--;
            }
            
            return _gear;
        }
    }
}