using System;
using Xunit;

namespace TopGear.Tests
{
    public class TopGearTests
    {
        private TopGear topGear = new ();

        private int[][] gearRanges =
        {
            new int[] {0, 1400},
            new int[] {400, 1600},
            new int[] {500, 1800},
            new int[] {600, 2000},
            new int[] {700, 2200},
            new int[] {800, 2400}
        };
        
        [Fact]
        public void given_rpmEquals1000_and_gearEquals3_when_autoTransmission_then_return_3()
        {
            Assert.Equal(3, topGear.autoTransmission(1000, 3, gearRanges));
        }
        
        [Fact]
        public void given_rpmEquals2000_and_gearEquals3_when_autoTransmission_then_return_4()
        {
            Assert.Equal(4, topGear.autoTransmission(2000, 3, gearRanges));
        }
        
        [Fact]
        public void given_rpmEquals300_and_gearEquals3_when_autoTransmission_then_return_2()
        {
            Assert.Equal(2, topGear.autoTransmission(300, 3, gearRanges));
        }
        
        [Fact]
        public void given_rpmEquals3000_and_gearEquals6_when_autoTransmission_then_return_6()
        {
            Assert.Equal(6, topGear.autoTransmission(3000, 6, gearRanges));
        }
        
        [Fact]
        public void given_rpmEquals0_and_gearEquals1_when_autoTransmission_then_return_1()
        {
            Assert.Equal(1, topGear.autoTransmission(0, 1, gearRanges));
        }
    }
}