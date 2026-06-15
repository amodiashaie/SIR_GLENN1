#nullable enable
namespace BoholBusTicketingApp
{
    partial class AdminForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            mainPanel = new Panel();
            gridPanel = new Panel();
            ticketDataGridView = new DataGridView();
            filterPanel = new Panel();
            exportButton = new Button();
            refreshButton = new Button();
            searchTextBox = new TextBox();
            searchLabel = new Label();
            headerPanel = new Panel();
            titleLabel = new Label();
            navPanel = new Panel();
            logoutButton = new Button();
            welcomeLabel = new Label();
            footerPanel = new Panel();
            totalLabel = new Label();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            mainPanel.SuspendLayout();
            gridPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ticketDataGridView).BeginInit();
            filterPanel.SuspendLayout();
            headerPanel.SuspendLayout();
            navPanel.SuspendLayout();
            footerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.Controls.Add(gridPanel);
            mainPanel.Controls.Add(filterPanel);
            mainPanel.Controls.Add(headerPanel);
            mainPanel.Controls.Add(navPanel);
            mainPanel.Controls.Add(footerPanel);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1000, 700);
            mainPanel.TabIndex = 0;
            // 
            // gridPanel
            // 
            gridPanel.Controls.Add(ticketDataGridView);
            gridPanel.Dock = DockStyle.Fill;
            gridPanel.Location = new Point(0, 311);
            gridPanel.Name = "gridPanel";
            gridPanel.Padding = new Padding(20);
            gridPanel.Size = new Size(1000, 339);
            gridPanel.TabIndex = 0;
            // 
            // ticketDataGridView
            // 
            ticketDataGridView.AllowUserToAddRows = false;
            ticketDataGridView.AllowUserToDeleteRows = false;
            ticketDataGridView.ColumnHeadersHeight = 29;
            ticketDataGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5 });
            ticketDataGridView.Dock = DockStyle.Fill;
            ticketDataGridView.Location = new Point(20, 20);
            ticketDataGridView.Name = "ticketDataGridView";
            ticketDataGridView.ReadOnly = true;
            ticketDataGridView.RowHeadersVisible = false;
            ticketDataGridView.RowHeadersWidth = 51;
            ticketDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ticketDataGridView.Size = new Size(960, 299);
            ticketDataGridView.TabIndex = 0;
            // 
            // filterPanel
            // 
            filterPanel.Controls.Add(exportButton);
            filterPanel.Controls.Add(refreshButton);
            filterPanel.Controls.Add(searchTextBox);
            filterPanel.Controls.Add(searchLabel);
            filterPanel.Dock = DockStyle.Top;
            filterPanel.Location = new Point(0, 241);
            filterPanel.Name = "filterPanel";
            filterPanel.Padding = new Padding(20, 10, 20, 10);
            filterPanel.Size = new Size(1000, 70);
            filterPanel.TabIndex = 1;
            // 
            // exportButton
            // 
            exportButton.Location = new Point(440, 10);
            exportButton.Name = "exportButton";
            exportButton.Size = new Size(100, 35);
            exportButton.TabIndex = 0;
            exportButton.Text = "EXPORT";
            // 
            // refreshButton
            // 
            refreshButton.Location = new Point(330, 10);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(100, 35);
            refreshButton.TabIndex = 1;
            refreshButton.Text = "REFRESH";
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(70, 10);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.PlaceholderText = "Search by location";
            searchTextBox.Size = new Size(250, 27);
            searchTextBox.TabIndex = 2;
            // 
            // searchLabel
            // 
            searchLabel.AutoSize = true;
            searchLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            searchLabel.Location = new Point(10, 10);
            searchLabel.Name = "searchLabel";
            searchLabel.Size = new Size(68, 23);
            searchLabel.TabIndex = 3;
            searchLabel.Text = "Search:";
            // 
            // headerPanel
            // 
            headerPanel.Controls.Add(titleLabel);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 161);
            headerPanel.Name = "headerPanel";
            headerPanel.Padding = new Padding(20);
            headerPanel.Size = new Size(1000, 80);
            headerPanel.TabIndex = 2;
            // 
            // titleLabel
            // 
            titleLabel.Dock = DockStyle.Fill;
            titleLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            titleLabel.Location = new Point(20, 20);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(960, 40);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Ticket Inventory";
            titleLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // navPanel
            // 
            navPanel.BackColor = Color.FromArgb(33, 150, 243);
            navPanel.Controls.Add(logoutButton);
            navPanel.Controls.Add(welcomeLabel);
            navPanel.Dock = DockStyle.Top;
            navPanel.Location = new Point(0, 0);
            navPanel.Name = "navPanel";
            navPanel.Padding = new Padding(20);
            navPanel.Size = new Size(1000, 161);
            navPanel.TabIndex = 3;
            // 
            // logoutButton
            // 
            logoutButton.BackColor = Color.FromArgb(244, 67, 54);
            logoutButton.Dock = DockStyle.Right;
            logoutButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            logoutButton.ForeColor = Color.White;
            logoutButton.Location = new Point(880, 20);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(100, 121);
            logoutButton.TabIndex = 0;
            logoutButton.Text = "LOGOUT";
            logoutButton.UseVisualStyleBackColor = false;
            // 
            // welcomeLabel
            // 
            welcomeLabel.Dock = DockStyle.Left;
            welcomeLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            welcomeLabel.ForeColor = Color.White;
            welcomeLabel.Location = new Point(20, 20);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(100, 121);
            welcomeLabel.TabIndex = 1;
            welcomeLabel.Text = "Admin Dashboard";
            welcomeLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // footerPanel
            // 
            footerPanel.Controls.Add(totalLabel);
            footerPanel.Dock = DockStyle.Bottom;
            footerPanel.Location = new Point(0, 650);
            footerPanel.Name = "footerPanel";
            footerPanel.Padding = new Padding(20);
            footerPanel.Size = new Size(1000, 50);
            footerPanel.TabIndex = 4;
            // 
            // totalLabel
            // 
            totalLabel.Dock = DockStyle.Left;
            totalLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            totalLabel.Location = new Point(20, 20);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(100, 10);
            totalLabel.TabIndex = 0;
            totalLabel.Text = "Total Tickets: 0";
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "ID";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "From";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "To";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Fare";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Date Issued";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            dataGridViewTextBoxColumn5.Width = 125;
            // 
            // AdminForm
            // 
            ClientSize = new Size(1000, 700);
            Controls.Add(mainPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Dashboard - Ticket Inventory";
            mainPanel.ResumeLayout(false);
            gridPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ticketDataGridView).EndInit();
            filterPanel.ResumeLayout(false);
            filterPanel.PerformLayout();
            headerPanel.ResumeLayout(false);
            navPanel.ResumeLayout(false);
            footerPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        private System.Windows.Forms.Panel mainPanel = null!;
        private System.Windows.Forms.Panel navPanel = null!;
        private System.Windows.Forms.Panel headerPanel = null!;
        private System.Windows.Forms.Panel filterPanel = null!;
        private System.Windows.Forms.Panel gridPanel = null!;
        private System.Windows.Forms.Panel footerPanel = null!;

        private System.Windows.Forms.Label welcomeLabel = null!;
        private System.Windows.Forms.Label titleLabel = null!;
        private System.Windows.Forms.Label searchLabel = null!;
        private System.Windows.Forms.Label totalLabel = null!;

        private System.Windows.Forms.TextBox searchTextBox = null!;
        private System.Windows.Forms.DataGridView ticketDataGridView = null!;

        private System.Windows.Forms.Button logoutButton = null!;
        private System.Windows.Forms.Button refreshButton = null!;
        private System.Windows.Forms.Button exportButton = null!;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1 = null!;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2 = null!;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3 = null!;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4 = null!;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5 = null!;
    }
}
