using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transportpris;
using Xunit;

namespace TestTransportpris
{
    public class TransportBeregnerTest
    {
        [InlineData(4, 4, 0)]
        [InlineData(4, 10, 50)]
        [InlineData(5, 4, 75)]
        [InlineData(5, 10, 100)]
        [Theory]
        public void Kan_beregne_med_gyldige_data(int afstand, int vaegt, int forventetPris)
        {
            // Arrange
            TransportBeregner beregner = new TransportBeregner();

            // Act
            int beregnetPris = beregner.getTransportPris(afstand, vaegt);

            // Assert
            Assert.Equal(forventetPris, beregnetPris);
        }
    }
}
