#nullable enable
using BoholBusTicketingApp.Services;
using BusTicketingSystem.Models;
using BusTicketingSystem.Services;
using System;
using System.Linq;
using System.Windows.Forms;

namespace BoholBusTicketingApp
{
    public partial class TicketForm : Form
    {
        private readonly ITicketingService? _ticketingService;
        private readonly LocationCoordinateProvider _locationProvider;

        private const string DistanceFormat = "{0:F2} km";
        private const string FareFormat = "₱{0:F2}";
        private const string CurrencySymbol = "₱";

        public TicketForm(ITicketingService? ticketingService = null)
        {
            InitializeComponent();

            _ticketingService = ticketingService;
            _locationProvider = new LocationCoordinateProvider();

            ThemeManager.StyleForm(this);
        }

        private void CalculateFare(object? sender, EventArgs e)
        {
            if (!GetSelectedLocations(out var from, out var to))
                return;

            if (from == to)
            {
                MessageBox.Show("Please select different locations.");
                return;
            }

            if (!_locationProvider.TryGetCoordinates(from!, out var a) ||
                !_locationProvider.TryGetCoordinates(to!, out var b))
                return;

            double distance = FareCalculator.CalculateDistanceKm(a.lat, a.lon, b.lat, b.lon);
            double fare = FareCalculator.CalculateFare(distance);

            distanceValueLabel.Text = string.Format(DistanceFormat, distance);
            fareValueLabel.Text = string.Format(FareFormat, fare);
        }

        private bool GetSelectedLocations(out string? from, out string? to)
        {
            from = fromLocationComboBox.SelectedItem?.ToString();
            to = toLocationComboBox.SelectedItem?.ToString();
            return from != null && to != null;
        }

        private void CreateButton_Click(object? sender, EventArgs e)
        {
            if (!GetSelectedLocations(out var from, out var to))
            {
                MessageBox.Show("Fill all fields");
                return;
            }

            if (_ticketingService == null) return;

            var ticket = new Ticket
            {
                FromLocation = from!,
                ToLocation = to!,
                Fare = ExtractFare(),
                DateIssued = DateTime.Now
            };

            _ticketingService.CreateTicket(ticket);

            MessageBox.Show("Ticket created!");
            ClearForm();
        }

        private double ExtractFare()
        {
            var text = fareValueLabel.Text.Replace(CurrencySymbol, "").Trim();
            return double.TryParse(text, out var f) ? f : 0;
        }

        private void ClearForm()
        {
            fromLocationComboBox.SelectedIndex = -1;
            toLocationComboBox.SelectedIndex = -1;
            fareValueLabel.Text = "₱0.00";
            distanceValueLabel.Text = "0.00 km";
        }
    }
}