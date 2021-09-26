using System;
using Xunit;

namespace TopGear.Tests
{
    public class TopGearTests
    {
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
            TopGear topGear = new (3);
            Assert.Equal(3, topGear.SelectGear(1000));
        }
        
        [Fact]
        public void given_rpmEquals2000_and_gearEquals3_when_autoTransmission_then_return_4()
        {
            TopGear topGear = new (3);
            Assert.Equal(4, topGear.SelectGear(2000));
        }
        
        [Fact]
        public void given_rpmEquals300_and_gearEquals3_when_autoTransmission_then_return_2()
        {
            TopGear topGear = new (3);
            Assert.Equal(2, topGear.SelectGear(300));
        }
        
        [Fact]
        public void given_rpmEquals3000_and_gearEquals6_when_autoTransmission_then_return_6()
        {
            TopGear topGear = new (6);
            Assert.Equal(6, topGear.SelectGear(3000));
        }
        
        [Fact]
        public void given_rpmEquals0_and_gearEquals1_when_autoTransmission_then_return_1()
        {
            TopGear topGear = new (1);
            Assert.Equal(1, topGear.SelectGear(0));
        }
    }
}