using BoholBusTicketingApp.Services;
using BusTicketingSystem.Models;
using System;
using System.Collections.Generic;
using Xunit;

namespace BoholBusTicketingApp.Tests
{
    public class ReportAggregatorTests
    {
        [Fact]
        public void Aggregate_ShouldSumTicketsAndFare()
        {
            var tickets = new List<Ticket>
            {
                new Ticket { Fare = 10 },
                new Ticket { Fare = 20 }
            };

            var (count, fare) = ReportAggregator.Aggregate(tickets);
            Assert.Equal(2, count);
            Assert.Equal(30, fare);
        }

        [Fact]
        public void BuildDailyReport_ShouldContainDateAndTotals()
        {
            var tickets = new List<Ticket>
            {
                new Ticket { Fare = 5 },
            };
            var report = ReportAggregator.BuildDailyReport(DateTime.Today, tickets);
            Assert.Equal(DateTime.Today.Date, report.Date);
            Assert.Equal(1, report.TotalTickets);
            Assert.Equal(5, report.TotalFare);
        }
    }
}