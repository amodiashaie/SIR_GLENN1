using System.Drawing;
using System.Windows.Forms;

namespace BoholBusTicketingApp
{
    public static class ThemeManager
    {
        public static class Colors
        {
            public static Color Primary = Color.FromArgb(37, 99, 235);
            public static Color Secondary = Color.FromArgb(15, 23, 42);
            public static Color Background = Color.FromArgb(241, 245, 249);
            public static Color Card = Color.White;
            public static Color TextPrimary = Color.FromArgb(15, 23, 42);
            public static Color TextSecondary = Color.FromArgb(100, 116, 139);
            public static Color Success = Color.FromArgb(16, 185, 129);
            public static Color Danger = Color.FromArgb(239, 68, 68);
            public static Color Border = Color.FromArgb(226, 232, 240);
        }

        public static class Typography
        {
            public static Font Heading1 = new Font("Segoe UI", 22, FontStyle.Bold);
            public static Font Heading2 = new Font("Segoe UI", 16, FontStyle.Bold);
            public static Font BodyText = new Font("Segoe UI", 10);
            public static Font ButtonText = new Font("Segoe UI", 10, FontStyle.Bold);
        }

        public static void StyleForm(Form form)
        {
            form.BackColor = Colors.Background;
            form.Font = Typography.BodyText;
        }

        public static void StyleButton(Button button, bool isPrimary = true)
        {
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.Cursor = Cursors.Hand;

            button.Font = Typography.ButtonText;
            button.ForeColor = Color.White;

            button.BackColor = isPrimary
                ? Colors.Primary
                : Colors.Secondary;

            button.Height = 45;
        }

        public static void StyleTextBox(TextBox textBox)
        {
            textBox.BorderStyle = BorderStyle.FixedSingle;
            textBox.Font = Typography.BodyText;
            textBox.BackColor = Color.White;
        }

        public static void StyleComboBox(ComboBox comboBox)
        {
            comboBox.FlatStyle = FlatStyle.Flat;
            comboBox.Font = Typography.BodyText;
            comboBox.BackColor = Color.White;
        }

        public static void StyleLabel(Label label)
        {
            label.ForeColor = Colors.TextPrimary;
            label.Font = Typography.BodyText;
        }
    }
}