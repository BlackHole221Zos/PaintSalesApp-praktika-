using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace PaintSalesApp
{
    public partial class FormReturn : Form
    {
        private DatabaseHelper dbHelper = new DatabaseHelper();

        public FormReturn()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int saleId = (int)numericSaleId.Value;

            string query = $@"
                SELECT [Sales].[Id], [Users].[Login], [Paints].[Name], [Sales].[Quantity], [Sales].[TotalAmount], [Sales].[SaleDate]
                FROM ([Sales] INNER JOIN [Users] ON [Sales].[ClientId] = [Users].[Id])
                INNER JOIN [Paints] ON [Sales].[PaintId] = [Paints].[Id]
                WHERE [Sales].[Id] = {saleId}";

            try
            {
                DataTable dt = dbHelper.ExecuteQuery(query);

                if (dt.Rows.Count > 0)
                {
                    dgvSaleInfo.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Продажа не найдена!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка поиска продажи: {ex.Message}");
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            int saleId = (int)numericSaleId.Value;
            int quantity = (int)numericReturnQuantity.Value;
            string reason = tbReason.Text;

            if (quantity <= 0)
            {
                MessageBox.Show("Введите корректное количество!");
                return;
            }

            try
            {
                string insertQuery = "INSERT INTO [Returns] ([SaleId], [Quantity], [Reason]) VALUES (?, ?, ?)";
                dbHelper.ExecuteNonQueryWithParams(insertQuery, saleId, quantity, reason);

                MessageBox.Show("Возврат оформлен!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка оформления возврата: {ex.Message}");
            }
        }
    }
}