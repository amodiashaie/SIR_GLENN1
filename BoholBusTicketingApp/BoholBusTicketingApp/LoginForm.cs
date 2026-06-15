using System;
using System.Drawing;
using System.Windows.Forms;

namespace BoholBusTicketingApp
{
    public partial class LoginForm : Form
    {
        public string? SelectedRole { get; private set; }
        public string? EnteredUsername { get; private set; }

        private const string EmptyFieldsErrorMessage = "Please fill in all fields.";
        private const string InvalidCredentialsMessage = "Invalid username or password.";
        private const string SuccessMessage = "Login successful!";

        private const string ConductorUsername = "conductor";
        private const string ConductorPassword = "conductor123";
        private const string AdminUsername = "admin";
        private const string AdminPassword = "admin123";

        public LoginForm()
        {
            InitializeComponent();
            ThemeManager.StyleForm(this);

            loginButton.Click += LoginButton_Click;
        }

        private void LoginButton_Click(object? sender, EventArgs e)
        {
            if (!ValidateLogin()) return;

            if (!Authenticate())
            {
                MessageBox.Show(InvalidCredentialsMessage);
                return;
            }

            SelectedRole = roleComboBox.SelectedItem?.ToString();
            EnteredUsername = usernameTextBox.Text.Trim();

            MessageBox.Show(SuccessMessage);

            DialogResult = DialogResult.OK;
            Close();
        }

        private bool ValidateLogin()
        {
            if (string.IsNullOrWhiteSpace(usernameTextBox.Text) ||
                string.IsNullOrWhiteSpace(passwordTextBox.Text) ||
                roleComboBox.SelectedIndex == -1)
            {
                MessageBox.Show(EmptyFieldsErrorMessage);
                return false;
            }
            return true;
        }

        private bool Authenticate()
        {
            var user = usernameTextBox.Text.Trim();
            var pass = passwordTextBox.Text;
            var role = roleComboBox.SelectedItem?.ToString();

            return role switch
            {
                "Conductor" => user == ConductorUsername && pass == ConductorPassword,
                "Admin" => user == AdminUsername && pass == AdminPassword,
                _ => false
            };
        }
    }
}