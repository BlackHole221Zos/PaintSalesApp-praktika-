using System;
using System.Data;
using System.Windows.Forms;

namespace PaintSalesApp
{
    public partial class FormAuthorization : Form
    {
        private DatabaseHelper dbHelper = new DatabaseHelper();

        public FormAuthorization()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string login = tbLogin.Text;
            string password = tbPassword.Text;

            string query = $"SELECT * FROM Users WHERE Login = '{login}' AND Password = '{password}'";
            DataTable dt = dbHelper.ExecuteQuery(query);

            if (dt.Rows.Count > 0)
            {
                var row = dt.Rows[0];
                User currentUser = new User
                {
                    Id = (int)row["Id"],
                    Login = row["Login"].ToString(),
                    Role = row["Role"].ToString()
                };

                this.Hide();
                FormMain mainForm = new FormMain(currentUser);
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль!");
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            FormRegistration regForm = new FormRegistration();
            regForm.Show();
        }
    }
}