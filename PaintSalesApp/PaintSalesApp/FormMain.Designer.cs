namespace PaintSalesApp
{
    partial class FormMain
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
            this.btnViewCatalog = new System.Windows.Forms.Button();
            this.btnViewSales = new System.Windows.Forms.Button();
            this.btnAddPaint = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnViewCatalog
            // 
            this.btnViewCatalog.Location = new System.Drawing.Point(50, 50);
            this.btnViewCatalog.Name = "btnViewCatalog";
            this.btnViewCatalog.Size = new System.Drawing.Size(150, 40);
            this.btnViewCatalog.TabIndex = 0;
            this.btnViewCatalog.Text = "Каталог красок";
            this.btnViewCatalog.UseVisualStyleBackColor = true;
            this.btnViewCatalog.Click += new System.EventHandler(this.btnViewCatalog_Click);
            // 
            // btnViewSales
            // 
            this.btnViewSales.Location = new System.Drawing.Point(50, 110);
            this.btnViewSales.Name = "btnViewSales";
            this.btnViewSales.Size = new System.Drawing.Size(150, 40);
            this.btnViewSales.TabIndex = 1;
            this.btnViewSales.Text = "История продаж";
            this.btnViewSales.UseVisualStyleBackColor = true;
            this.btnViewSales.Click += new System.EventHandler(this.btnViewSales_Click);
            // 
            // btnAddPaint
            // 
            this.btnAddPaint.Location = new System.Drawing.Point(50, 170);
            this.btnAddPaint.Name = "btnAddPaint";
            this.btnAddPaint.Size = new System.Drawing.Size(150, 40);
            this.btnAddPaint.TabIndex = 2;
            this.btnAddPaint.Text = "Добавить краску";
            this.btnAddPaint.UseVisualStyleBackColor = true;
            this.btnAddPaint.Click += new System.EventHandler(this.btnAddPaint_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(50, 230);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(150, 40);
            this.btnReturn.TabIndex = 3;
            this.btnReturn.Text = "Оформить возврат";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 320);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnAddPaint);
            this.Controls.Add(this.btnViewSales);
            this.Controls.Add(this.btnViewCatalog);
            this.Name = "FormMain";
            this.Text = "Главная";
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button btnViewCatalog;
        private System.Windows.Forms.Button btnViewSales;
        private System.Windows.Forms.Button btnAddPaint;
        private System.Windows.Forms.Button btnReturn;
    }
}