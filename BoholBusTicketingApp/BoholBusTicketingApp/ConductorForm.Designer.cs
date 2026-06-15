#nullable enable
namespace BoholBusTicketingApp
{
    partial class ConductorForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Name = "ConductorForm";
            this.Text = "Conductor - Ticket Creation";
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            // Navigation Bar
            this.navPanel = new System.Windows.Forms.Panel();
            this.navPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.navPanel.Height = 60;
            this.navPanel.Padding = new System.Windows.Forms.Padding(20);
            this.navPanel.BackColor = System.Drawing.Color.FromArgb(33, 150, 243);

            this.welcomeLabel = new System.Windows.Forms.Label();
            this.welcomeLabel.Text = "Welcome";
            this.welcomeLabel.Font = new System.Drawing.Font("Segoe UI", 14, System.Drawing.FontStyle.Bold);
            this.welcomeLabel.ForeColor = System.Drawing.Color.White;
            this.welcomeLabel.AutoSize = false;
            this.welcomeLabel.Height = 20;
            this.welcomeLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.welcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.hardwareStatusLabel = new System.Windows.Forms.Label();

            this.hardwareStatusLabel.Text = "Printer Status";
            this.hardwareStatusLabel.ForeColor = System.Drawing.Color.White;
            this.hardwareStatusLabel.Font =
                new System.Drawing.Font("Segoe UI", 10F,
                System.Drawing.FontStyle.Bold);

            this.hardwareStatusLabel.AutoSize = true;

            this.logoutButton = new System.Windows.Forms.Button();
            this.logoutButton.Text = "LOGOUT";
            this.logoutButton.Width = 100;
            this.logoutButton.Height = 35;
            this.logoutButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.logoutButton.BackColor = System.Drawing.Color.FromArgb(244, 67, 54);
            this.logoutButton.ForeColor = System.Drawing.Color.White;
            this.logoutButton.Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold);

            this.navPanel.Controls.Add(this.logoutButton);
            this.navPanel.Controls.Add(this.hardwareStatusLabel);
            this.navPanel.Controls.Add(this.welcomeLabel);

            // Main Panel
            this.mainPanel = new System.Windows.Forms.Panel();
            this.mainPanel.AutoScroll = true;
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;

            // Header
            this.headerPanel = new System.Windows.Forms.Panel();
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Height = 80;
            this.headerPanel.Padding = new System.Windows.Forms.Padding(20);

            this.titleLabel = new System.Windows.Forms.Label();
            this.titleLabel.Text = "Create Ticket";
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 20, System.Drawing.FontStyle.Bold);
            this.titleLabel.AutoSize = false;
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.headerPanel.Controls.Add(this.titleLabel);

            // From Location Section
            this.fromLocationPanel = new System.Windows.Forms.Panel();
            this.fromLocationPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.fromLocationPanel.Height = 90;
            this.fromLocationPanel.Padding = new System.Windows.Forms.Padding(20, 15, 20, 15);

            this.fromLocationLabel = new System.Windows.Forms.Label();
            this.fromLocationLabel.Text = "From Location";
            this.fromLocationLabel.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
            this.fromLocationLabel.AutoSize = false;
            this.fromLocationLabel.Height = 20;
            this.fromLocationLabel.Dock = System.Windows.Forms.DockStyle.Top;

            this.fromLocationComboBox = new System.Windows.Forms.ComboBox();
            this.fromLocationComboBox.Height = 40;
            this.fromLocationComboBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.fromLocationComboBox.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.fromLocationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.fromLocationPanel.Controls.Add(this.fromLocationComboBox);
            this.fromLocationPanel.Controls.Add(this.fromLocationLabel);

            // To Location Section
            this.toLocationPanel = new System.Windows.Forms.Panel();
            this.toLocationPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.toLocationPanel.Height = 90;
            this.toLocationPanel.Padding = new System.Windows.Forms.Padding(20, 15, 20, 15);

            this.toLocationLabel = new System.Windows.Forms.Label();
            this.toLocationLabel.Text = "To Location";
            this.toLocationLabel.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
            this.toLocationLabel.AutoSize = false;
            this.toLocationLabel.Height = 20;
            this.toLocationLabel.Dock = System.Windows.Forms.DockStyle.Top;

            this.toLocationComboBox = new System.Windows.Forms.ComboBox();
            this.toLocationComboBox.Height = 40;
            this.toLocationComboBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.toLocationComboBox.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.toLocationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.toLocationPanel.Controls.Add(this.toLocationComboBox);
            this.toLocationPanel.Controls.Add(this.toLocationLabel);

            // Distance Display Section
            this.distancePanel = new System.Windows.Forms.Panel();
            this.distancePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.distancePanel.Height = 80;
            this.distancePanel.Padding = new System.Windows.Forms.Padding(20, 15, 20, 15);

            this.distanceLabel = new System.Windows.Forms.Label();
            this.distanceLabel.Text = "Distance";
            this.distanceLabel.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
            this.distanceLabel.AutoSize = false;
            this.distanceLabel.Height = 20;
            this.distanceLabel.Dock = System.Windows.Forms.DockStyle.Top;

            this.distanceValueLabel = new System.Windows.Forms.Label();
            this.distanceValueLabel.Text = "0.00 km";
            this.distanceValueLabel.AutoSize = false;
            this.distanceValueLabel.Height = 30;
            this.distanceValueLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.distanceValueLabel.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);

            this.distancePanel.Controls.Add(this.distanceValueLabel);
            this.distancePanel.Controls.Add(this.distanceLabel);

            // Fare Display Section
            this.farePanel = new System.Windows.Forms.Panel();
            this.farePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.farePanel.Height = 80;
            this.farePanel.Padding = new System.Windows.Forms.Padding(20, 15, 20, 15);

            this.fareLabel = new System.Windows.Forms.Label();
            this.fareLabel.Text = "Fare";
            this.fareLabel.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
            this.fareLabel.AutoSize = false;
            this.fareLabel.Height = 20;
            this.fareLabel.Dock = System.Windows.Forms.DockStyle.Top;

            this.fareValueLabel = new System.Windows.Forms.Label();
            this.fareValueLabel.Text = "₱0.00";
            this.fareValueLabel.AutoSize = false;
            this.fareValueLabel.Height = 30;
            this.fareValueLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.fareValueLabel.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);

            this.farePanel.Controls.Add(this.fareValueLabel);
            this.farePanel.Controls.Add(this.fareLabel);

            // Button Panel
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.buttonPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPanel.Height = 70;
            this.buttonPanel.Padding = new System.Windows.Forms.Padding(20);

            this.createButton = new System.Windows.Forms.Button();
            this.createButton.Text = "CREATE TICKET";
            this.createButton.Height = 40;
            this.createButton.Width = 150;
            this.createButton.Location = new System.Drawing.Point(20, 15);

            this.cancelButton = new System.Windows.Forms.Button();
            this.cancelButton.Text = "CANCEL";
            this.cancelButton.Height = 40;
            this.cancelButton.Width = 150;
            this.cancelButton.Location = new System.Drawing.Point(180, 15);

            this.buttonPanel.Controls.Add(this.cancelButton);
            this.buttonPanel.Controls.Add(this.createButton);

            // Add all to main panel
            this.mainPanel.Controls.Add(this.buttonPanel);
            this.mainPanel.Controls.Add(this.farePanel);
            this.mainPanel.Controls.Add(this.distancePanel);
            this.mainPanel.Controls.Add(this.toLocationPanel);
            this.mainPanel.Controls.Add(this.fromLocationPanel);
            this.mainPanel.Controls.Add(this.headerPanel);
            this.mainPanel.Controls.Add(this.navPanel);

            this.Controls.Add(this.mainPanel);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel mainPanel = null!;
        private System.Windows.Forms.Panel navPanel = null!;
        private System.Windows.Forms.Panel headerPanel = null!;
        private System.Windows.Forms.Panel fromLocationPanel = null!;
        private System.Windows.Forms.Panel toLocationPanel = null!;
        private System.Windows.Forms.Panel distancePanel = null!;
        private System.Windows.Forms.Panel farePanel = null!;
        private System.Windows.Forms.Panel buttonPanel = null!;

        private System.Windows.Forms.Label welcomeLabel = null!;
        private System.Windows.Forms.Label titleLabel = null!;
        private System.Windows.Forms.Label fromLocationLabel = null!;
        private System.Windows.Forms.Label toLocationLabel = null!;
        private System.Windows.Forms.Label distanceLabel = null!;
        private System.Windows.Forms.Label distanceValueLabel = null!;
        private System.Windows.Forms.Label fareLabel = null!;
        private System.Windows.Forms.Label fareValueLabel = null!;
        private System.Windows.Forms.Label hardwareStatusLabel = null!;

        private System.Windows.Forms.ComboBox fromLocationComboBox = null!;
        private System.Windows.Forms.ComboBox toLocationComboBox = null!;

        private System.Windows.Forms.Button logoutButton = null!;
        private System.Windows.Forms.Button createButton = null!;
        private System.Windows.Forms.Button cancelButton = null!;
    }
}
