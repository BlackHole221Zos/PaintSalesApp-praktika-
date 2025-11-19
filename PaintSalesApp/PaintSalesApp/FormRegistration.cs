using System;
using System.Windows.Forms;

namespace PaintSalesApp
{
    public partial class FormRegistration : Form
    {
        private DatabaseHelper dbHelper = new DatabaseHelper();

        public FormRegistration()
        {
            InitializeComponent();

            cbRole.Items.Add("Client");
            cbRole.Items.Add("Admin");
            cbRole.SelectedIndex = 0;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string login = tbLogin.Text;
            string password = tbPassword.Text;
            string role = cbRole.SelectedItem.ToString();

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }

            string query = "INSERT INTO [Users] ([Login], [Password], [Role]) VALUES (?, ?, ?)";

            try
            {
                dbHelper.ExecuteNonQueryWithParams(query, login, password, role);
                MessageBox.Show("Регистрация прошла успешно!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }
    }
}