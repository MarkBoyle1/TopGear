namespace TopGear
{
    public class GearRanges
    {
        public int[][] gearRanges;

        public GearRanges()
        {
            gearRanges = new int[][]
            {
                new int[] {0, 1400},
                new int[] {400, 1600},
                new int[] {500, 1800},
                new int[] {600, 2000},
                new int[] {700, 2200},
                new int[] {800, 2400}
            };
        }
    }
}