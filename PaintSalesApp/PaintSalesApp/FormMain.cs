using System;
using System.Windows.Forms;

namespace PaintSalesApp
{
    public partial class FormMain : Form
    {
        private User _currentUser;

        public FormMain(User user)
        {
            InitializeComponent();
            _currentUser = user;
            this.Text = $"Привет, {_currentUser.Login}!";

            if (_currentUser.Role == "Client")
            {
                btnViewCatalog.Visible = true;
                btnViewSales.Visible = false;
                btnAddPaint.Visible = false;
                btnReturn.Visible = false;
            }
            else if (_currentUser.Role == "Admin")
            {
                btnViewCatalog.Visible = true;
                btnViewSales.Visible = true;
                btnAddPaint.Visible = true;
                btnReturn.Visible = true;
            }
        }

        private void btnViewCatalog_Click(object sender, EventArgs e)
        {
            FormCatalog catalog = new FormCatalog(_currentUser);
            catalog.Show();
        }

        private void btnViewSales_Click(object sender, EventArgs e)
        {
            FormCheckHistory history = new FormCheckHistory();
            history.Show();
        }

        private void btnAddPaint_Click(object sender, EventArgs e)
        {
            FormAddPaint addForm = new FormAddPaint();
            addForm.Show();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            FormReturn returnForm = new FormReturn();
            returnForm.Show();
        }
    }
}