using System;
using System.Windows.Forms;
using BoholBusTicketingApp;
using BusTicketingSystem.Repositories;
using BusTicketingSystem.Services;
using BusTicketingSystem.Hardware;

static class Program
{
    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        var conductorRepo = new ConductorRepository();
        var ticketRepo = new TicketRepository();
        var routeRepo = new RouteRepository();
        var printer = new PrintingMachine();

        var service = new TicketingService(
            new ConductorRepository(),
            new TicketRepository(),
            new RouteRepository(),
            new PrintingMachine()
        );

        while (true)
        {
            using var login = new LoginForm();

            if (login.ShowDialog() != DialogResult.OK)
                break;

            if (login.SelectedRole == "Admin")
            {
                using var form = new AdminForm(service);
                form.ShowDialog();
            }
            else if (login.SelectedRole == "Conductor")
            {
                using var form = new ConductorForm(service, login.EnteredUsername);
                form.ShowDialog();
            }
        }
    }
}