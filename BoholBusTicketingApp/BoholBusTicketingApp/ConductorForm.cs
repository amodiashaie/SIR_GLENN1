using BoholBusTicketingApp.Services;
using BusTicketingSystem.Models;
using BusTicketingSystem.Services;
using System;
using System.Windows.Forms;

namespace BoholBusTicketingApp
{
    public partial class ConductorForm : Form
    {
        private readonly ITicketingService _service;
        private readonly LocationCoordinateProvider _locationProvider;
        private readonly string _conductorName;

        public ConductorForm(ITicketingService service, string? conductorName = null)
        {
            InitializeComponent();

            _service = service;
            _locationProvider = new LocationCoordinateProvider();
            _conductorName = conductorName ?? "Conductor";

            welcomeLabel.Text = $"Welcome, {_conductorName}";

            LoadLocations();
            HookEvents();
        }

        private void LoadLocations()
        {
            var locations = _locationProvider.GetAllLocations().Keys;
            fromLocationComboBox.Items.AddRange(locations);
            toLocationComboBox.Items.AddRange(locations);
        }

        private void HookEvents()
        {
            fromLocationComboBox.SelectedIndexChanged += CalculateFare;
            toLocationComboBox.SelectedIndexChanged += CalculateFare;
            createButton.Click += CreateTicket;
            cancelButton.Click += (s, e) => ResetForm();
            logoutButton.Click += (s, e) => Close();
        }

        private void CalculateFare(object? sender, EventArgs e)
        {
            if (fromLocationComboBox.SelectedItem == null ||
                toLocationComboBox.SelectedItem == null)
                return;

            var from = fromLocationComboBox.SelectedItem.ToString();
            var to = toLocationComboBox.SelectedItem.ToString();

            if (from == to)
            {
                MessageBox.Show("Same location not allowed.");
                return;
            }

            _locationProvider.TryGetCoordinates(from, out var a);
            _locationProvider.TryGetCoordinates(to, out var b);

            var distance = FareCalculator.CalculateDistanceKm(a.lat, a.lon, b.lat, b.lon);
            var fare = FareCalculator.CalculateFare(distance);

            distanceValueLabel.Text = $"{distance:F2} km";
            fareValueLabel.Text = $"₱{fare:F2}";
        }

        private void CreateTicket(object? sender, EventArgs e)
        {
            if (fromLocationComboBox.SelectedItem == null ||
                toLocationComboBox.SelectedItem == null)
            {
                MessageBox.Show("Select locations first.");
                return;
            }

            var ticket = new Ticket
            {
                ConductorId = _conductorName,
                FromLocation = fromLocationComboBox.Text,
                ToLocation = toLocationComboBox.Text,
                Fare = double.Parse(fareValueLabel.Text.Replace("₱", "")),
                DateIssued = DateTime.Now
            };

            _service.CreateTicket(ticket);

            MessageBox.Show("Ticket created!");
            ResetForm();
        }

        private void ResetForm()
        {
            fromLocationComboBox.SelectedIndex = -1;
            toLocationComboBox.SelectedIndex = -1;
            distanceValueLabel.Text = "0.00 km";
            fareValueLabel.Text = "₱0.00";
        }
    }
}