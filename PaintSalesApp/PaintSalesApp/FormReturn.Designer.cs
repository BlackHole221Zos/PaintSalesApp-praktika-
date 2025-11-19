namespace PaintSalesApp
{
    partial class FormReturn
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
            this.numericSaleId = new System.Windows.Forms.NumericUpDown();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvSaleInfo = new System.Windows.Forms.DataGridView();
            this.numericReturnQuantity = new System.Windows.Forms.NumericUpDown();
            this.tbReason = new System.Windows.Forms.TextBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblSaleId = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblReason = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericSaleId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericReturnQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // numericSaleId
            // 
            this.numericSaleId.Location = new System.Drawing.Point(120, 20);
            this.numericSaleId.Name = "numericSaleId";
            this.numericSaleId.Size = new System.Drawing.Size(120, 22);
            this.numericSaleId.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(250, 15);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 30);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Поиск";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvSaleInfo
            // 
            this.dgvSaleInfo.AllowUserToAddRows = false;
            this.dgvSaleInfo.AllowUserToDeleteRows = false;
            this.dgvSaleInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSaleInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSaleInfo.Location = new System.Drawing.Point(12, 60);
            this.dgvSaleInfo.Name = "dgvSaleInfo";
            this.dgvSaleInfo.ReadOnly = true;
            this.dgvSaleInfo.RowHeadersWidth = 51;
            this.dgvSaleInfo.RowTemplate.Height = 24;
            this.dgvSaleInfo.Size = new System.Drawing.Size(600, 150);
            this.dgvSaleInfo.TabIndex = 2;
            // 
            // numericReturnQuantity
            // 
            this.numericReturnQuantity.Location = new System.Drawing.Point(120, 230);
            this.numericReturnQuantity.Name = "numericReturnQuantity";
            this.numericReturnQuantity.Size = new System.Drawing.Size(120, 22);
            this.numericReturnQuantity.TabIndex = 3;
            // 
            // tbReason
            // 
            this.tbReason.Location = new System.Drawing.Point(120, 270);
            this.tbReason.Multiline = true;
            this.tbReason.Name = "tbReason";
            this.tbReason.Size = new System.Drawing.Size(200, 60);
            this.tbReason.TabIndex = 4;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(120, 340);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(100, 30);
            this.btnReturn.TabIndex = 5;
            this.btnReturn.Text = "Вернуть";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblSaleId
            // 
            this.lblSaleId.AutoSize = true;
            this.lblSaleId.Location = new System.Drawing.Point(12, 22);
            this.lblSaleId.Name = "lblSaleId";
            this.lblSaleId.Size = new System.Drawing.Size(67, 16);
            this.lblSaleId.TabIndex = 6;
            this.lblSaleId.Text = "ID продажи:";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(12, 232);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(79, 16);
            this.lblQuantity.TabIndex = 7;
            this.lblQuantity.Text = "Количество:";
            // 
            // lblReason
            // 
            this.lblReason.AutoSize = true;
            this.lblReason.Location = new System.Drawing.Point(12, 273);
            this.lblReason.Name = "lblReason";
            this.lblReason.Size = new System.Drawing.Size(58, 16);
            this.lblReason.TabIndex = 8;
            this.lblReason.Text = "Причина:";
            // 
            // FormReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 390);
            this.Controls.Add(this.lblReason);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblSaleId);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.tbReason);
            this.Controls.Add(this.numericReturnQuantity);
            this.Controls.Add(this.dgvSaleInfo);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.numericSaleId);
            this.Name = "FormReturn";
            this.Text = "Оформление возврата";
            ((System.ComponentModel.ISupportInitialize)(this.numericSaleId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericReturnQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.NumericUpDown numericSaleId;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvSaleInfo;
        private System.Windows.Forms.NumericUpDown numericReturnQuantity;
        private System.Windows.Forms.TextBox tbReason;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblSaleId;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblReason;
    }
}