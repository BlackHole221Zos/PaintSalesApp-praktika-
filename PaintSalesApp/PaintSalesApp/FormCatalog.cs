using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace PaintSalesApp
{
    public partial class FormCatalog : Form
    {
        private User _user;
        private DatabaseHelper dbHelper = new DatabaseHelper();

        public FormCatalog(User user)
        {
            InitializeComponent();
            _user = user;
            LoadPaints();
        }

        private void LoadPaints()
        {
            string query = "SELECT * FROM CurrentPaintQuantities";
            DataTable dt = dbHelper.ExecuteQuery(query);
            dgvPaints.DataSource = dt;
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            if (dgvPaints.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите краску!");
                return;
            }

            int paintId = (int)dgvPaints.SelectedRows[0].Cells["Id"].Value;
            int quantity = (int)numQuantity.Value;

            if (quantity <= 0)
            {
                MessageBox.Show("Введите количество!");
                return;
            }

            string checkQuery = "SELECT CurrentQuantity FROM CurrentPaintQuantities WHERE Id = ?";
            object stockObj = null;
            using (OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=PaintSales.accdb;"))
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand(checkQuery, conn);
                cmd.Parameters.AddWithValue("?", paintId);
                stockObj = cmd.ExecuteScalar();
            }

            if (stockObj == null || stockObj == DBNull.Value)
            {
                MessageBox.Show("Ошибка: краска не найдена.");
                return;
            }

            int stock = Convert.ToInt32(stockObj);

            if (quantity > stock)
            {
                MessageBox.Show("Недостаточно товара на складе!");
                return;
            }

            decimal price = Convert.ToDecimal(dgvPaints.SelectedRows[0].Cells["Price"].Value);
            decimal total = price * quantity;

            string insertQuery = "INSERT INTO [Sales] ([ClientId], [PaintId], [Quantity], [TotalAmount]) VALUES (?, ?, ?, ?)";
            dbHelper.ExecuteNonQueryWithParams(insertQuery, _user.Id, paintId, quantity, total);

            MessageBox.Show("Покупка оформлена!");
            LoadPaints();
        }
    }
}