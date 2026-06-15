#nullable enable
namespace BoholBusTicketingApp
{
    partial class LoginForm
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
            mainPanel = new Panel();
            buttonPanel = new Panel();
            loginButton = new Button();
            rolePanel = new Panel();
            roleComboBox = new ComboBox();
            roleLabel = new Label();
            passwordPanel = new Panel();
            passwordTextBox = new TextBox();
            passwordLabel = new Label();
            usernamePanel = new Panel();
            usernameTextBox = new TextBox();
            usernameLabel = new Label();
            headerPanel = new Panel();
            subtitleLabel = new Label();
            titleLabel = new Label();
            mainPanel.SuspendLayout();
            buttonPanel.SuspendLayout();
            rolePanel.SuspendLayout();
            passwordPanel.SuspendLayout();
            usernamePanel.SuspendLayout();
            headerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.AutoScroll = true;
            mainPanel.Controls.Add(buttonPanel);
            mainPanel.Controls.Add(rolePanel);
            mainPanel.Controls.Add(passwordPanel);
            mainPanel.Controls.Add(usernamePanel);
            mainPanel.Controls.Add(headerPanel);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(594, 600);
            mainPanel.TabIndex = 0;
            // 
            // buttonPanel
            // 
            buttonPanel.Controls.Add(loginButton);
            buttonPanel.Dock = DockStyle.Top;
            buttonPanel.Location = new Point(0, 384);
            buttonPanel.Name = "buttonPanel";
            buttonPanel.Padding = new Padding(20, 15, 20, 15);
            buttonPanel.Size = new Size(594, 80);
            buttonPanel.TabIndex = 0;
            // 
            // loginButton
            // 
            loginButton.Dock = DockStyle.Fill;
            loginButton.Location = new Point(20, 15);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(554, 50);
            loginButton.TabIndex = 0;
            loginButton.Text = "LOGIN";
            // 
            // rolePanel
            // 
            rolePanel.Controls.Add(roleComboBox);
            rolePanel.Controls.Add(roleLabel);
            rolePanel.Dock = DockStyle.Top;
            rolePanel.Location = new Point(0, 294);
            rolePanel.Name = "rolePanel";
            rolePanel.Padding = new Padding(20, 15, 20, 15);
            rolePanel.Size = new Size(594, 90);
            rolePanel.TabIndex = 1;
            // 
            // roleComboBox
            // 
            roleComboBox.Dock = DockStyle.Top;
            roleComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            roleComboBox.Items.AddRange(new object[] { "Conductor", "Admin" });
            roleComboBox.Location = new Point(20, 35);
            roleComboBox.Margin = new Padding(0, 5, 0, 0);
            roleComboBox.Name = "roleComboBox";
            roleComboBox.Size = new Size(554, 28);
            roleComboBox.TabIndex = 0;
            // 
            // roleLabel
            // 
            roleLabel.Dock = DockStyle.Top;
            roleLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            roleLabel.Location = new Point(20, 15);
            roleLabel.Name = "roleLabel";
            roleLabel.Size = new Size(554, 20);
            roleLabel.TabIndex = 1;
            roleLabel.Text = "Login As";
            // 
            // passwordPanel
            // 
            passwordPanel.Controls.Add(passwordTextBox);
            passwordPanel.Controls.Add(passwordLabel);
            passwordPanel.Dock = DockStyle.Top;
            passwordPanel.Location = new Point(0, 204);
            passwordPanel.Name = "passwordPanel";
            passwordPanel.Padding = new Padding(20, 15, 20, 15);
            passwordPanel.Size = new Size(594, 90);
            passwordPanel.TabIndex = 2;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Dock = DockStyle.Top;
            passwordTextBox.Location = new Point(20, 35);
            passwordTextBox.Margin = new Padding(0, 5, 0, 0);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PlaceholderText = "Enter your password";
            passwordTextBox.Size = new Size(554, 27);
            passwordTextBox.TabIndex = 0;
            passwordTextBox.UseSystemPasswordChar = true;
            // 
            // passwordLabel
            // 
            passwordLabel.Dock = DockStyle.Top;
            passwordLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            passwordLabel.Location = new Point(20, 15);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(554, 20);
            passwordLabel.TabIndex = 1;
            passwordLabel.Text = "Password";
            // 
            // usernamePanel
            // 
            usernamePanel.Controls.Add(usernameTextBox);
            usernamePanel.Controls.Add(usernameLabel);
            usernamePanel.Dock = DockStyle.Top;
            usernamePanel.Location = new Point(0, 114);
            usernamePanel.Name = "usernamePanel";
            usernamePanel.Padding = new Padding(20, 15, 20, 15);
            usernamePanel.Size = new Size(594, 90);
            usernamePanel.TabIndex = 3;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Dock = DockStyle.Top;
            usernameTextBox.Location = new Point(20, 35);
            usernameTextBox.Margin = new Padding(0, 5, 0, 0);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.PlaceholderText = "Enter your username";
            usernameTextBox.Size = new Size(554, 27);
            usernameTextBox.TabIndex = 0;
            // 
            // usernameLabel
            // 
            usernameLabel.Dock = DockStyle.Top;
            usernameLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            usernameLabel.Location = new Point(20, 15);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(554, 20);
            usernameLabel.TabIndex = 1;
            usernameLabel.Text = "Username";
            // 
            // headerPanel
            // 
            headerPanel.Controls.Add(subtitleLabel);
            headerPanel.Controls.Add(titleLabel);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Padding = new Padding(20);
            headerPanel.Size = new Size(594, 114);
            headerPanel.TabIndex = 4;
            // 
            // subtitleLabel
            // 
            subtitleLabel.Dock = DockStyle.Top;
            subtitleLabel.Font = new Font("Segoe UI", 11F);
            subtitleLabel.Location = new Point(20, 85);
            subtitleLabel.Margin = new Padding(0, 10, 0, 0);
            subtitleLabel.Name = "subtitleLabel";
            subtitleLabel.Size = new Size(554, 25);
            subtitleLabel.TabIndex = 0;
            subtitleLabel.Text = "Ticketing Management System";
            subtitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // titleLabel
            // 
            titleLabel.Dock = DockStyle.Top;
            titleLabel.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            titleLabel.Location = new Point(20, 20);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(554, 65);
            titleLabel.TabIndex = 1;
            titleLabel.Text = "🚌 BOHOL BUS";
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            ClientSize = new Size(594, 600);
            Controls.Add(mainPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login - Bohol Bus Ticketing";
            mainPanel.ResumeLayout(false);
            buttonPanel.ResumeLayout(false);
            rolePanel.ResumeLayout(false);
            passwordPanel.ResumeLayout(false);
            passwordPanel.PerformLayout();
            usernamePanel.ResumeLayout(false);
            usernamePanel.PerformLayout();
            headerPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        private System.Windows.Forms.Panel mainPanel = null!;
        private System.Windows.Forms.Panel headerPanel = null!;
        private System.Windows.Forms.Panel usernamePanel = null!;
        private System.Windows.Forms.Panel passwordPanel = null!;
        private System.Windows.Forms.Panel rolePanel = null!;
        private System.Windows.Forms.Panel buttonPanel = null!;

        private System.Windows.Forms.Label titleLabel = null!;
        private System.Windows.Forms.Label subtitleLabel = null!;
        private System.Windows.Forms.Label usernameLabel = null!;
        private System.Windows.Forms.Label passwordLabel = null!;
        private System.Windows.Forms.Label roleLabel = null!;

        private System.Windows.Forms.TextBox usernameTextBox = null!;
        private System.Windows.Forms.TextBox passwordTextBox = null!;
        private System.Windows.Forms.ComboBox roleComboBox = null!;

        private System.Windows.Forms.Button loginButton = null!;
    }
}
