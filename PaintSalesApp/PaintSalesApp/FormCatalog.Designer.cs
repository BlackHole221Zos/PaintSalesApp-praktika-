namespace PaintSalesApp
{
    partial class FormCatalog
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
            this.dgvPaints = new System.Windows.Forms.DataGridView();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnBuy = new System.Windows.Forms.Button();
            this.lblQuantity = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaints)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPaints
            // 
            this.dgvPaints.AllowUserToAddRows = false;
            this.dgvPaints.AllowUserToDeleteRows = false;
            this.dgvPaints.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPaints.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPaints.Location = new System.Drawing.Point(12, 12);
            this.dgvPaints.Name = "dgvPaints";
            this.dgvPaints.ReadOnly = true;
            this.dgvPaints.RowHeadersWidth = 51;
            this.dgvPaints.RowTemplate.Height = 24;
            this.dgvPaints.Size = new System.Drawing.Size(600, 300);
            this.dgvPaints.TabIndex = 0;
            // 
            // numQuantity
            // 
            this.numQuantity.Location = new System.Drawing.Point(12, 330);
            this.numQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(120, 22);
            this.numQuantity.TabIndex = 1;
            this.numQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnBuy
            // 
            this.btnBuy.Location = new System.Drawing.Point(150, 325);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(100, 30);
            this.btnBuy.TabIndex = 2;
            this.btnBuy.Text = "Купить";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(12, 310);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(79, 16);
            this.lblQuantity.TabIndex = 3;
            this.lblQuantity.Text = "Количество:";
            // 
            // FormCatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 361);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.numQuantity);
            this.Controls.Add(this.dgvPaints);
            this.Name = "FormCatalog";
            this.Text = "Каталог красок";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaints)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.DataGridView dgvPaints;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Label lblQuantity;
    }
}