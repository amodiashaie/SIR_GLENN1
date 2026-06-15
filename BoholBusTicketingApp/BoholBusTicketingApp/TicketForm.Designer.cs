namespace BoholBusTicketingApp
{
    partial class TicketForm
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
            // ==================== FORM SETUP ====================
            this.ClientSize = new System.Drawing.Size(600, 750);
            this.Name = "TicketForm";
            this.Text = "Create Ticket - Bohol Bus Ticketing";
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            // ==================== MAIN PANEL ====================
            this.mainPanel = new System.Windows.Forms.Panel();
            this.mainPanel.AutoScroll = true;
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;

            // ==================== HEADER SECTION ====================
            this.headerPanel = new System.Windows.Forms.Panel();
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Height = 80;
            this.headerPanel.Padding = new System.Windows.Forms.Padding(20);

            this.titleLabel = new System.Windows.Forms.Label();
            this.titleLabel.Text = "Create New Ticket";
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 20, System.Drawing.FontStyle.Bold);
            this.titleLabel.AutoSize = false;
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.headerPanel.Controls.Add(this.titleLabel);

            // ==================== PASSENGER SECTION ====================
            this.passengerPanel = new System.Windows.Forms.Panel();
            this.passengerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.passengerPanel.Height = 90;
            this.passengerPanel.Padding = new System.Windows.Forms.Padding(20, 15, 20, 15);

            this.passengerNameLabel = new System.Windows.Forms.Label();
            this.passengerNameLabel.Text = "Passenger Name";
            this.passengerNameLabel.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
            this.passengerNameLabel.AutoSize = false;
            this.passengerNameLabel.Height = 20;
            this.passengerNameLabel.Dock = System.Windows.Forms.DockStyle.Top;

            this.passengerNameTextBox = new System.Windows.Forms.TextBox();
            this.passengerNameTextBox.Height = 35;
            this.passengerNameTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.passengerNameTextBox.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.passengerNameTextBox.PlaceholderText = "e.g., Juan Dela Cruz";

            this.passengerPanel.Controls.Add(this.passengerNameTextBox);
            this.passengerPanel.Controls.Add(this.passengerNameLabel);

            // ==================== ROUTE SECTION ====================
            this.routePanel = new System.Windows.Forms.Panel();
            this.routePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.routePanel.Height = 200;
            this.routePanel.Padding = new System.Windows.Forms.Padding(20, 15, 20, 15);

            // From Location
            this.fromLocationLabel = new System.Windows.Forms.Label();
            this.fromLocationLabel.Text = "From Location";
            this.fromLocationLabel.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
            this.fromLocationLabel.AutoSize = false;
            this.fromLocationLabel.Height = 20;
            this.fromLocationLabel.Dock = System.Windows.Forms.DockStyle.Top;

            this.fromLocationComboBox = new System.Windows.Forms.ComboBox();
            this.fromLocationComboBox.Height = 35;
            this.fromLocationComboBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.fromLocationComboBox.Margin = new System.Windows.Forms.Padding(0, 5, 0, 10);
            this.fromLocationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            // To Location
            this.toLocationLabel = new System.Windows.Forms.Label();
            this.toLocationLabel.Text = "To Location";
            this.toLocationLabel.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
            this.toLocationLabel.AutoSize = false;
            this.toLocationLabel.Height = 20;
            this.toLocationLabel.Dock = System.Windows.Forms.DockStyle.Top;

            this.toLocationComboBox = new System.Windows.Forms.ComboBox();
            this.toLocationComboBox.Height = 35;
            this.toLocationComboBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.toLocationComboBox.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.toLocationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.routePanel.Controls.Add(this.toLocationComboBox);
            this.routePanel.Controls.Add(this.toLocationLabel);
            this.routePanel.Controls.Add(this.fromLocationComboBox);
            this.routePanel.Controls.Add(this.fromLocationLabel);

            // ==================== FARE CALCULATION SECTION ====================
            this.fareCalcPanel = new System.Windows.Forms.Panel();
            this.fareCalcPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.fareCalcPanel.Height = 150;
            this.fareCalcPanel.Padding = new System.Windows.Forms.Padding(20, 15, 20, 15);
            this.fareCalcPanel.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);

            // Distance Row (2 columns)
            this.distanceContainerPanel = new System.Windows.Forms.Panel();
            this.distanceContainerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.distanceContainerPanel.Height = 65;
            this.distanceContainerPanel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);

            this.distanceLabel = new System.Windows.Forms.Label();
            this.distanceLabel.Text = "Distance";
            this.distanceLabel.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
            this.distanceLabel.AutoSize = false;
            this.distanceLabel.Height = 20;
            this.distanceLabel.Dock = System.Windows.Forms.DockStyle.Top;

            this.distanceValueLabel = new System.Windows.Forms.Label();
            this.distanceValueLabel.Text = "0.00 km";
            this.distanceValueLabel.Font = new System.Drawing.Font("Segoe UI", 14, System.Drawing.FontStyle.Bold);
            this.distanceValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.distanceValueLabel.AutoSize = false;
            this.distanceValueLabel.Height = 35;
            this.distanceValueLabel.Dock = System.Windows.Forms.DockStyle.Top;

            this.distanceContainerPanel.Controls.Add(this.distanceValueLabel);
            this.distanceContainerPanel.Controls.Add(this.distanceLabel);

            // Fare Row (2 columns)
            this.fareContainerPanel = new System.Windows.Forms.Panel();
            this.fareContainerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.fareContainerPanel.Height = 65;

            this.fareLabel = new System.Windows.Forms.Label();
            this.fareLabel.Text = "Total Fare";
            this.fareLabel.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
            this.fareLabel.AutoSize = false;
            this.fareLabel.Height = 20;
            this.fareLabel.Dock = System.Windows.Forms.DockStyle.Top;

            this.fareValueLabel = new System.Windows.Forms.Label();
            this.fareValueLabel.Text = "₱0.00";
            this.fareValueLabel.Font = new System.Drawing.Font("Segoe UI", 16, System.Drawing.FontStyle.Bold);
            this.fareValueLabel.ForeColor = System.Drawing.Color.FromArgb(56, 142, 60); // Green
            this.fareValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fareValueLabel.AutoSize = false;
            this.fareValueLabel.Height = 35;
            this.fareValueLabel.Dock = System.Windows.Forms.DockStyle.Top;

            this.fareContainerPanel.Controls.Add(this.fareValueLabel);
            this.fareContainerPanel.Controls.Add(this.fareLabel);

            this.fareCalcPanel.Controls.Add(this.fareContainerPanel);
            this.fareCalcPanel.Controls.Add(this.distanceContainerPanel);

            // ==================== BUTTON SECTION ====================
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.buttonPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPanel.Height = 80;
            this.buttonPanel.Padding = new System.Windows.Forms.Padding(20, 15, 20, 15);

            // Button container for side-by-side layout
            this.buttonContainerPanel = new System.Windows.Forms.Panel();
            this.buttonContainerPanel.Dock = System.Windows.Forms.DockStyle.Fill;

            this.createButton = new System.Windows.Forms.Button();
            this.createButton.Text = "CREATE TICKET";
            this.createButton.Width = 270;
            this.createButton.Height = 45;
            this.createButton.Location = new System.Drawing.Point(0, 0);
            this.createButton.TabIndex = 0;

            this.cancelButton = new System.Windows.Forms.Button();
            this.cancelButton.Text = "CANCEL";
            this.cancelButton.Width = 270;
            this.cancelButton.Height = 45;
            this.cancelButton.Location = new System.Drawing.Point(280, 0);
            this.cancelButton.TabIndex = 1;

            this.buttonContainerPanel.Controls.Add(this.cancelButton);
            this.buttonContainerPanel.Controls.Add(this.createButton);

            this.buttonPanel.Controls.Add(this.buttonContainerPanel);

            // ==================== ADD SECTIONS TO MAIN PANEL ====================
            this.mainPanel.Controls.Add(this.buttonPanel);
            this.mainPanel.Controls.Add(this.fareCalcPanel);
            this.mainPanel.Controls.Add(this.routePanel);
            this.mainPanel.Controls.Add(this.passengerPanel);
            this.mainPanel.Controls.Add(this.headerPanel);

            // ==================== ADD MAIN PANEL TO FORM ====================
            this.Controls.Add(this.mainPanel);

            this.ResumeLayout(false);
        }

        // ==================== PANEL CONTROLS ====================
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Panel passengerPanel;
        private System.Windows.Forms.Panel routePanel;
        private System.Windows.Forms.Panel fareCalcPanel;
        private System.Windows.Forms.Panel distanceContainerPanel;
        private System.Windows.Forms.Panel fareContainerPanel;
        private System.Windows.Forms.Panel buttonPanel;
        private System.Windows.Forms.Panel buttonContainerPanel;

        // ==================== LABEL CONTROLS ====================
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label passengerNameLabel;
        private System.Windows.Forms.Label fromLocationLabel;
        private System.Windows.Forms.Label toLocationLabel;
        private System.Windows.Forms.Label distanceLabel;
        private System.Windows.Forms.Label distanceValueLabel;
        private System.Windows.Forms.Label fareLabel;
        private System.Windows.Forms.Label fareValueLabel;

        // ==================== INPUT CONTROLS ====================
        private System.Windows.Forms.TextBox passengerNameTextBox;
        private System.Windows.Forms.ComboBox fromLocationComboBox;
        private System.Windows.Forms.ComboBox toLocationComboBox;

        // ==================== BUTTON CONTROLS ====================
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button cancelButton;
    }
}