namespace PaintSalesApp
{
    partial class FormCheckHistory
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
            this.dgvSales = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSales
            // 
            this.dgvSales.AllowUserToAddRows = false;
            this.dgvSales.AllowUserToDeleteRows = false;
            this.dgvSales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSales.Location = new System.Drawing.Point(0, 0);
            this.dgvSales.Name = "dgvSales";
            this.dgvSales.ReadOnly = true;
            this.dgvSales.RowHeadersWidth = 51;
            this.dgvSales.RowTemplate.Height = 24;
            this.dgvSales.Size = new System.Drawing.Size(800, 450);
            this.dgvSales.TabIndex = 0;
            // 
            // FormCheckHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvSales);
            this.Name = "FormCheckHistory";
            this.Text = "История продаж";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.DataGridView dgvSales;
    }
}