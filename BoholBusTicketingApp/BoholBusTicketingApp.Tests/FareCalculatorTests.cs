using BoholBusTicketingApp.Services;
using System;
using Xunit;

namespace BoholBusTicketingApp.Tests
{
    public class FareCalculatorTests
    {
        [Fact]
        public void CalculateFare_ShouldReturnBasePlusPerKm()
        {
            double fare = FareCalculator.CalculateFare(10.0);
            Assert.Equal(FareCalculator.BaseFare + 10.0 * FareCalculator.PerKmRate, fare, 2);
        }

        [Fact]
        public void CalculateDistanceKm_ShouldReturnPositive()
        {
            double d = FareCalculator.CalculateDistanceKm(9.6412, 123.8854, 9.5500, 123.7833);
            Assert.True(d > 0);
        }
    }
}