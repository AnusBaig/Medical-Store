namespace PointOfSale
{
    partial class Purcahse
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PanelPurchase = new System.Windows.Forms.Panel();
            this.textBoxDues = new System.Windows.Forms.TextBox();
            this.labelDues = new System.Windows.Forms.Label();
            this.buttonReturnStock = new System.Windows.Forms.Button();
            this.buttonPurchase = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelSupplier = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.dataGridViewPurchase = new System.Windows.Forms.DataGridView();
            this.ColumnBarcode2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProduct2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPurchaseQTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnExpired = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanelButtons = new System.Windows.Forms.Panel();
            this.groupBoxManualadd = new System.Windows.Forms.GroupBox();
            this.buttonManualadd = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupFilter = new System.Windows.Forms.GroupBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddAll = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.buttonSale = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.PanelStock = new System.Windows.Forms.Panel();
            this.DatagridStock = new System.Windows.Forms.DataGridView();
            this.ColumnBarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnQTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnExpiry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanelPurchase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPurchase)).BeginInit();
            this.PanelButtons.SuspendLayout();
            this.groupBoxManualadd.SuspendLayout();
            this.groupFilter.SuspendLayout();
            this.PanelStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatagridStock)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelPurchase
            // 
            this.PanelPurchase.Controls.Add(this.textBoxDues);
            this.PanelPurchase.Controls.Add(this.labelDues);
            this.PanelPurchase.Controls.Add(this.buttonReturnStock);
            this.PanelPurchase.Controls.Add(this.buttonPurchase);
            this.PanelPurchase.Controls.Add(this.buttonClear);
            this.PanelPurchase.Controls.Add(this.comboBox1);
            this.PanelPurchase.Controls.Add(this.labelSupplier);
            this.PanelPurchase.Controls.Add(this.buttonDelete);
            this.PanelPurchase.Controls.Add(this.dataGridViewPurchase);
            this.PanelPurchase.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelPurchase.Location = new System.Drawing.Point(600, 0);
            this.PanelPurchase.Name = "PanelPurchase";
            this.PanelPurchase.Size = new System.Drawing.Size(434, 461);
            this.PanelPurchase.TabIndex = 0;
            // 
            // textBoxDues
            // 
            this.textBoxDues.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDues.Location = new System.Drawing.Point(133, 374);
            this.textBoxDues.Name = "textBoxDues";
            this.textBoxDues.Size = new System.Drawing.Size(285, 32);
            this.textBoxDues.TabIndex = 10;
            // 
            // labelDues
            // 
            this.labelDues.AutoSize = true;
            this.labelDues.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDues.Location = new System.Drawing.Point(12, 374);
            this.labelDues.Name = "labelDues";
            this.labelDues.Size = new System.Drawing.Size(75, 33);
            this.labelDues.TabIndex = 9;
            this.labelDues.Text = "Cost";
            // 
            // buttonReturnStock
            // 
            this.buttonReturnStock.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonReturnStock.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonReturnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReturnStock.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReturnStock.ForeColor = System.Drawing.Color.White;
            this.buttonReturnStock.Location = new System.Drawing.Point(0, 409);
            this.buttonReturnStock.Name = "buttonReturnStock";
            this.buttonReturnStock.Size = new System.Drawing.Size(434, 52);
            this.buttonReturnStock.TabIndex = 8;
            this.buttonReturnStock.Text = "Return";
            this.buttonReturnStock.UseVisualStyleBackColor = false;
            this.buttonReturnStock.Click += new System.EventHandler(this.buttonReturnStock_Click);
            // 
            // buttonPurchase
            // 
            this.buttonPurchase.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonPurchase.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPurchase.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPurchase.ForeColor = System.Drawing.Color.White;
            this.buttonPurchase.Location = new System.Drawing.Point(0, 409);
            this.buttonPurchase.Name = "buttonPurchase";
            this.buttonPurchase.Size = new System.Drawing.Size(434, 52);
            this.buttonPurchase.TabIndex = 7;
            this.buttonPurchase.Text = "Purchase";
            this.buttonPurchase.UseVisualStyleBackColor = false;
            this.buttonPurchase.Click += new System.EventHandler(this.buttonPurchase_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.ForeColor = System.Drawing.Color.White;
            this.buttonClear.Location = new System.Drawing.Point(220, 280);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(208, 52);
            this.buttonClear.TabIndex = 6;
            this.buttonClear.Text = "Clear All";
            this.buttonClear.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(133, 338);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(285, 33);
            this.comboBox1.TabIndex = 4;
            // 
            // labelSupplier
            // 
            this.labelSupplier.AutoSize = true;
            this.labelSupplier.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSupplier.Location = new System.Drawing.Point(12, 338);
            this.labelSupplier.Name = "labelSupplier";
            this.labelSupplier.Size = new System.Drawing.Size(118, 33);
            this.labelSupplier.TabIndex = 3;
            this.labelSupplier.Text = "Supplier";
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(6, 280);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(208, 52);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // dataGridViewPurchase
            // 
            this.dataGridViewPurchase.AllowUserToResizeColumns = false;
            this.dataGridViewPurchase.AllowUserToResizeRows = false;
            this.dataGridViewPurchase.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPurchase.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPurchase.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPurchase.ColumnHeadersHeight = 45;
            this.dataGridViewPurchase.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnBarcode2,
            this.ColumnProduct2,
            this.ColumnPurchaseQTY,
            this.ColumnExpired});
            this.dataGridViewPurchase.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewPurchase.EnableHeadersVisualStyles = false;
            this.dataGridViewPurchase.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewPurchase.Name = "dataGridViewPurchase";
            this.dataGridViewPurchase.RowHeadersVisible = false;
            this.dataGridViewPurchase.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPurchase.Size = new System.Drawing.Size(434, 275);
            this.dataGridViewPurchase.TabIndex = 0;
            // 
            // ColumnBarcode2
            // 
            this.ColumnBarcode2.FillWeight = 70F;
            this.ColumnBarcode2.HeaderText = "Barcode";
            this.ColumnBarcode2.Name = "ColumnBarcode2";
            this.ColumnBarcode2.ReadOnly = true;
            // 
            // ColumnProduct2
            // 
            this.ColumnProduct2.HeaderText = "Product";
            this.ColumnProduct2.Name = "ColumnProduct2";
            // 
            // ColumnPurchaseQTY
            // 
            this.ColumnPurchaseQTY.FillWeight = 80F;
            this.ColumnPurchaseQTY.HeaderText = "Purchase QTY";
            this.ColumnPurchaseQTY.Name = "ColumnPurchaseQTY";
            this.ColumnPurchaseQTY.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ColumnExpired
            // 
            this.ColumnExpired.FillWeight = 50F;
            this.ColumnExpired.HeaderText = "Expired";
            this.ColumnExpired.Name = "ColumnExpired";
            this.ColumnExpired.ReadOnly = true;
            // 
            // PanelButtons
            // 
            this.PanelButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelButtons.Controls.Add(this.groupBoxManualadd);
            this.PanelButtons.Controls.Add(this.groupFilter);
            this.PanelButtons.Controls.Add(this.buttonAddAll);
            this.PanelButtons.Controls.Add(this.buttonAdd);
            this.PanelButtons.Controls.Add(this.buttonReturn);
            this.PanelButtons.Controls.Add(this.buttonSale);
            this.PanelButtons.Controls.Add(this.button1);
            this.PanelButtons.Controls.Add(this.shapeContainer1);
            this.PanelButtons.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelButtons.Location = new System.Drawing.Point(471, 0);
            this.PanelButtons.Name = "PanelButtons";
            this.PanelButtons.Size = new System.Drawing.Size(129, 461);
            this.PanelButtons.TabIndex = 1;
            // 
            // groupBoxManualadd
            // 
            this.groupBoxManualadd.Controls.Add(this.buttonManualadd);
            this.groupBoxManualadd.Controls.Add(this.textBox2);
            this.groupBoxManualadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxManualadd.Location = new System.Drawing.Point(3, 143);
            this.groupBoxManualadd.Name = "groupBoxManualadd";
            this.groupBoxManualadd.Size = new System.Drawing.Size(121, 98);
            this.groupBoxManualadd.TabIndex = 7;
            this.groupBoxManualadd.TabStop = false;
            this.groupBoxManualadd.Text = "Barcode";
            // 
            // buttonManualadd
            // 
            this.buttonManualadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(121)))), ((int)(((byte)(197)))));
            this.buttonManualadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonManualadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonManualadd.ForeColor = System.Drawing.Color.White;
            this.buttonManualadd.Location = new System.Drawing.Point(10, 63);
            this.buttonManualadd.Name = "buttonManualadd";
            this.buttonManualadd.Size = new System.Drawing.Size(101, 31);
            this.buttonManualadd.TabIndex = 2;
            this.buttonManualadd.Text = "Add";
            this.buttonManualadd.UseVisualStyleBackColor = false;
            this.buttonManualadd.Click += new System.EventHandler(this.buttonManualadd_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(10, 26);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(101, 31);
            this.textBox2.TabIndex = 1;
            // 
            // groupFilter
            // 
            this.groupFilter.Controls.Add(this.buttonSearch);
            this.groupFilter.Controls.Add(this.textBox1);
            this.groupFilter.Controls.Add(this.label1);
            this.groupFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupFilter.Location = new System.Drawing.Point(4, 243);
            this.groupFilter.Name = "groupFilter";
            this.groupFilter.Size = new System.Drawing.Size(120, 108);
            this.groupFilter.TabIndex = 6;
            this.groupFilter.TabStop = false;
            this.groupFilter.Text = "Filter";
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(121)))), ((int)(((byte)(197)))));
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.ForeColor = System.Drawing.Color.White;
            this.buttonSearch.Location = new System.Drawing.Point(10, 71);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(101, 31);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(72, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(39, 31);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "QTY<";
            // 
            // buttonAddAll
            // 
            this.buttonAddAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(121)))), ((int)(((byte)(197)))));
            this.buttonAddAll.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonAddAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddAll.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddAll.ForeColor = System.Drawing.Color.White;
            this.buttonAddAll.Location = new System.Drawing.Point(0, 410);
            this.buttonAddAll.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.buttonAddAll.Name = "buttonAddAll";
            this.buttonAddAll.Size = new System.Drawing.Size(127, 49);
            this.buttonAddAll.TabIndex = 5;
            this.buttonAddAll.Text = "Add All";
            this.buttonAddAll.UseVisualStyleBackColor = false;
            this.buttonAddAll.Click += new System.EventHandler(this.buttonAddAll_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(121)))), ((int)(((byte)(197)))));
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(0, 357);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(129, 49);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonReturn
            // 
            this.buttonReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(66)))));
            this.buttonReturn.FlatAppearance.BorderSize = 0;
            this.buttonReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReturn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReturn.ForeColor = System.Drawing.Color.White;
            this.buttonReturn.Location = new System.Drawing.Point(62, 62);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(67, 63);
            this.buttonReturn.TabIndex = 2;
            this.buttonReturn.Text = "Return";
            this.buttonReturn.UseVisualStyleBackColor = false;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // buttonSale
            // 
            this.buttonSale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(121)))), ((int)(((byte)(197)))));
            this.buttonSale.FlatAppearance.BorderSize = 0;
            this.buttonSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSale.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSale.ForeColor = System.Drawing.Color.White;
            this.buttonSale.Location = new System.Drawing.Point(0, 62);
            this.buttonSale.Name = "buttonSale";
            this.buttonSale.Size = new System.Drawing.Size(69, 63);
            this.buttonSale.TabIndex = 1;
            this.buttonSale.Text = "Sale";
            this.buttonSale.UseVisualStyleBackColor = false;
            this.buttonSale.Click += new System.EventHandler(this.buttonSale_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(121)))), ((int)(((byte)(197)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Functions";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(127, 459);
            this.shapeContainer1.TabIndex = 3;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.Blue;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 5;
            this.lineShape2.X2 = 123;
            this.lineShape2.Y1 = 139;
            this.lineShape2.Y2 = 139;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.Blue;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 4;
            this.lineShape1.X2 = 122;
            this.lineShape1.Y1 = 51;
            this.lineShape1.Y2 = 51;
            // 
            // PanelStock
            // 
            this.PanelStock.Controls.Add(this.DatagridStock);
            this.PanelStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelStock.Location = new System.Drawing.Point(0, 0);
            this.PanelStock.Name = "PanelStock";
            this.PanelStock.Size = new System.Drawing.Size(471, 461);
            this.PanelStock.TabIndex = 2;
            // 
            // DatagridStock
            // 
            this.DatagridStock.AllowUserToOrderColumns = true;
            this.DatagridStock.AllowUserToResizeColumns = false;
            this.DatagridStock.AllowUserToResizeRows = false;
            this.DatagridStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DatagridStock.BackgroundColor = System.Drawing.Color.White;
            this.DatagridStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DatagridStock.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DatagridStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DatagridStock.ColumnHeadersHeight = 40;
            this.DatagridStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnBarcode,
            this.ColumnPN,
            this.ColumnQTY,
            this.ColumnExpiry});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DatagridStock.DefaultCellStyle = dataGridViewCellStyle4;
            this.DatagridStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DatagridStock.EnableHeadersVisualStyles = false;
            this.DatagridStock.Location = new System.Drawing.Point(0, 0);
            this.DatagridStock.Name = "DatagridStock";
            this.DatagridStock.RowHeadersVisible = false;
            this.DatagridStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DatagridStock.Size = new System.Drawing.Size(471, 461);
            this.DatagridStock.TabIndex = 0;
            // 
            // ColumnBarcode
            // 
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            this.ColumnBarcode.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColumnBarcode.FillWeight = 150F;
            this.ColumnBarcode.HeaderText = "Barcode";
            this.ColumnBarcode.Name = "ColumnBarcode";
            // 
            // ColumnPN
            // 
            this.ColumnPN.FillWeight = 250F;
            this.ColumnPN.HeaderText = "Product Name";
            this.ColumnPN.Name = "ColumnPN";
            // 
            // ColumnQTY
            // 
            this.ColumnQTY.HeaderText = "QTY";
            this.ColumnQTY.Name = "ColumnQTY";
            // 
            // ColumnExpiry
            // 
            this.ColumnExpiry.HeaderText = "Expired";
            this.ColumnExpiry.Name = "ColumnExpiry";
            // 
            // Purcahse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.PanelStock);
            this.Controls.Add(this.PanelButtons);
            this.Controls.Add(this.PanelPurchase);
            this.Name = "Purcahse";
            this.Size = new System.Drawing.Size(1034, 461);
            this.PanelPurchase.ResumeLayout(false);
            this.PanelPurchase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPurchase)).EndInit();
            this.PanelButtons.ResumeLayout(false);
            this.groupBoxManualadd.ResumeLayout(false);
            this.groupBoxManualadd.PerformLayout();
            this.groupFilter.ResumeLayout(false);
            this.groupFilter.PerformLayout();
            this.PanelStock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DatagridStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelPurchase;
        private System.Windows.Forms.Panel PanelButtons;
        private System.Windows.Forms.Panel PanelStock;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBarcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnQTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnExpiry;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.Button buttonSale;
        private System.Windows.Forms.Button buttonAdd;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Button buttonAddAll;
        private System.Windows.Forms.GroupBox groupFilter;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxManualadd;
        private System.Windows.Forms.Button buttonManualadd;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label labelSupplier;
        private System.Windows.Forms.Button buttonPurchase;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonReturnStock;
        private System.Windows.Forms.TextBox textBoxDues;
        private System.Windows.Forms.Label labelDues;
        public System.Windows.Forms.DataGridView DatagridStock;
        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBarcode2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProduct2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPurchaseQTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnExpired;
        public System.Windows.Forms.DataGridView dataGridViewPurchase;
    }
}
