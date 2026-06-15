using System;
using System.Windows.Forms;
using BusTicketingSystem.Services;

namespace BoholBusTicketingApp
{
    public partial class AdminForm : Form
    {
        private readonly ITicketingService _service;

        public AdminForm(ITicketingService service)
        {
            InitializeComponent();
            _service = service;
            LoadTickets();
        }

        private void LoadTickets()
        {
            ticketDataGridView.Rows.Clear();

            var tickets = _service.GetAllTickets();

            foreach (var t in tickets)
            {
                ticketDataGridView.Rows.Add(
                    t.Id,
                    t.FromLocation,
                    t.ToLocation,
                    t.Fare,
                    t.DateIssued
                );
            }

            totalLabel.Text = $"Total Tickets: {tickets.Count}";
        }
    }
}