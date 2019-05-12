namespace PointOfSale
{
    partial class Stock
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewStock = new System.Windows.Forms.DataGridView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.ColumnBarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMedicine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSalePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCostPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnExpiryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStock)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewStock
            // 
            this.dataGridViewStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewStock.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewStock.ColumnHeadersHeight = 40;
            this.dataGridViewStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnBarcode,
            this.ColumnMedicine,
            this.ColumnSalePrice,
            this.ColumnCostPrice,
            this.ColumnQuantity,
            this.ColumnExpiryDate});
            this.dataGridViewStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewStock.EnableHeadersVisualStyles = false;
            this.dataGridViewStock.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewStock.MultiSelect = false;
            this.dataGridViewStock.Name = "dataGridViewStock";
            this.dataGridViewStock.RowHeadersVisible = false;
            this.dataGridViewStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewStock.Size = new System.Drawing.Size(1034, 461);
            this.dataGridViewStock.TabIndex = 0;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(121)))), ((int)(((byte)(197)))));
            this.buttonAdd.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(307, 402);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(137, 56);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(121)))), ((int)(((byte)(197)))));
            this.buttonEdit.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit.ForeColor = System.Drawing.Color.White;
            this.buttonEdit.Location = new System.Drawing.Point(450, 402);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(137, 56);
            this.buttonEdit.TabIndex = 2;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(121)))), ((int)(((byte)(197)))));
            this.buttonRemove.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemove.ForeColor = System.Drawing.Color.White;
            this.buttonRemove.Location = new System.Drawing.Point(593, 402);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(137, 56);
            this.buttonRemove.TabIndex = 3;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = false;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // ColumnBarcode
            // 
            this.ColumnBarcode.HeaderText = "Barcode";
            this.ColumnBarcode.Name = "ColumnBarcode";
            this.ColumnBarcode.ReadOnly = true;
            // 
            // ColumnMedicine
            // 
            this.ColumnMedicine.HeaderText = "Medicine";
            this.ColumnMedicine.Name = "ColumnMedicine";
            // 
            // ColumnSalePrice
            // 
            this.ColumnSalePrice.HeaderText = "Sale Price";
            this.ColumnSalePrice.Name = "ColumnSalePrice";
            // 
            // ColumnCostPrice
            // 
            this.ColumnCostPrice.HeaderText = "Cost Price";
            this.ColumnCostPrice.Name = "ColumnCostPrice";
            // 
            // ColumnQuantity
            // 
            this.ColumnQuantity.HeaderText = "Quantity";
            this.ColumnQuantity.Name = "ColumnQuantity";
            // 
            // ColumnExpiryDate
            // 
            this.ColumnExpiryDate.HeaderText = "Expiry Date";
            this.ColumnExpiryDate.Name = "ColumnExpiryDate";
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridViewStock);
            this.Name = "Stock";
            this.Size = new System.Drawing.Size(1034, 461);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonRemove;
        public System.Windows.Forms.DataGridView dataGridViewStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBarcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMedicine;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSalePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCostPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnExpiryDate;
    }
}
