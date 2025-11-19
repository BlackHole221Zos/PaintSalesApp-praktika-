using System;
using System.Data;
using System.Windows.Forms;

namespace PaintSalesApp
{
    public partial class FormCheckHistory : Form
    {
        private DatabaseHelper dbHelper = new DatabaseHelper();

        public FormCheckHistory()
        {
            InitializeComponent();
            LoadSales();
        }

        private void LoadSales()
        {
            string query = @"
                SELECT [Sales].[Id], [Users].[Login], [Paints].[Name], [Sales].[Quantity], [Sales].[TotalAmount], [Sales].[SaleDate]
                FROM ([Sales] INNER JOIN [Users] ON [Sales].[ClientId] = [Users].[Id])
                INNER JOIN [Paints] ON [Sales].[PaintId] = [Paints].[Id]";

            try
            {
                DataTable dt = dbHelper.ExecuteQuery(query);
                dgvSales.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки истории продаж: {ex.Message}");
            }
        }
    }
}