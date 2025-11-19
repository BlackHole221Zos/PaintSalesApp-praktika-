using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PaintSalesApp
{
    public partial class FormAddPaint : Form
    {
        private DatabaseHelper dbHelper = new DatabaseHelper();

        public FormAddPaint()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            string color = tbColor.Text;
            decimal price = numericPrice.Value;
            int quantity = (int)numericQuantity.Value;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(color))
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }

            string query = $"INSERT INTO Paints (Name, Color, Price, Quantity) VALUES ('{name}', '{color}', {price}, {quantity})";
            dbHelper.ExecuteNonQuery(query);

            MessageBox.Show("Краска добавлена!");
            this.Close();
        }
    }
}