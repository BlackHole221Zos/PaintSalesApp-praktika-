namespace PaintSalesApp
{
    partial class FormAddPaint
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbColor = new System.Windows.Forms.TextBox();
            this.numericPrice = new System.Windows.Forms.NumericUpDown();
            this.numericQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(150, 30);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(150, 22);
            this.tbName.TabIndex = 0;
            // 
            // tbColor
            // 
            this.tbColor.Location = new System.Drawing.Point(150, 70);
            this.tbColor.Name = "tbColor";
            this.tbColor.Size = new System.Drawing.Size(150, 22);
            this.tbColor.TabIndex = 1;
            // 
            // numericPrice
            // 
            this.numericPrice.DecimalPlaces = 2;
            this.numericPrice.Location = new System.Drawing.Point(150, 110);
            this.numericPrice.Name = "numericPrice";
            this.numericPrice.Size = new System.Drawing.Size(150, 22);
            this.numericPrice.TabIndex = 2;
            // 
            // numericQuantity
            // 
            this.numericQuantity.Location = new System.Drawing.Point(150, 150);
            this.numericQuantity.Name = "numericQuantity";
            this.numericQuantity.Size = new System.Drawing.Size(150, 22);
            this.numericQuantity.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(150, 190);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 30);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(30, 33);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(71, 16);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Название:";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(30, 73);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(48, 16);
            this.lblColor.TabIndex = 6;
            this.lblColor.Text = "Цвет:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(30, 112);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(48, 16);
            this.lblPrice.TabIndex = 7;
            this.lblPrice.Text = "Цена:";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(30, 152);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(79, 16);
            this.lblQuantity.TabIndex = 8;
            this.lblQuantity.Text = "Количество:";
            // 
            // FormAddPaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 250);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.numericQuantity);
            this.Controls.Add(this.numericPrice);
            this.Controls.Add(this.tbColor);
            this.Controls.Add(this.tbName);
            this.Name = "FormAddPaint";
            this.Text = "Добавить краску";
            ((System.ComponentModel.ISupportInitialize)(this.numericPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbColor;
        private System.Windows.Forms.NumericUpDown numericPrice;
        private System.Windows.Forms.NumericUpDown numericQuantity;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblQuantity;
    }
}