namespace PointOfSale
{
    partial class Providers
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelStockShare = new System.Windows.Forms.Panel();
            this.chartStockShares = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelStockShare = new System.Windows.Forms.Label();
            this.panelProvidersInfo = new System.Windows.Forms.Panel();
            this.dataGridViewProviderInfo = new System.Windows.Forms.DataGridView();
            this.ColumnPicture = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAdress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDues = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelStockShare.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartStockShares)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelProvidersInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProviderInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelStockShare
            // 
            this.panelStockShare.BackColor = System.Drawing.Color.White;
            this.panelStockShare.Controls.Add(this.chartStockShares);
            this.panelStockShare.Controls.Add(this.panel1);
            this.panelStockShare.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelStockShare.Location = new System.Drawing.Point(697, 0);
            this.panelStockShare.Name = "panelStockShare";
            this.panelStockShare.Size = new System.Drawing.Size(337, 461);
            this.panelStockShare.TabIndex = 0;
            // 
            // chartStockShares
            // 
            chartArea1.Name = "ChartArea1";
            this.chartStockShares.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartStockShares.Legends.Add(legend1);
            this.chartStockShares.Location = new System.Drawing.Point(5, 95);
            this.chartStockShares.Name = "chartStockShares";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartStockShares.Series.Add(series1);
            this.chartStockShares.Size = new System.Drawing.Size(334, 323);
            this.chartStockShares.TabIndex = 1;
            this.chartStockShares.Text = "chart1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(121)))), ((int)(((byte)(97)))));
            this.panel1.Controls.Add(this.labelStockShare);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 40);
            this.panel1.TabIndex = 0;
            // 
            // labelStockShare
            // 
            this.labelStockShare.AutoSize = true;
            this.labelStockShare.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStockShare.ForeColor = System.Drawing.Color.White;
            this.labelStockShare.Location = new System.Drawing.Point(70, 0);
            this.labelStockShare.Name = "labelStockShare";
            this.labelStockShare.Size = new System.Drawing.Size(188, 33);
            this.labelStockShare.TabIndex = 0;
            this.labelStockShare.Text = "Stock Shares";
            // 
            // panelProvidersInfo
            // 
            this.panelProvidersInfo.Controls.Add(this.dataGridViewProviderInfo);
            this.panelProvidersInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProvidersInfo.Location = new System.Drawing.Point(0, 0);
            this.panelProvidersInfo.Name = "panelProvidersInfo";
            this.panelProvidersInfo.Size = new System.Drawing.Size(697, 461);
            this.panelProvidersInfo.TabIndex = 1;
            // 
            // dataGridViewProviderInfo
            // 
            this.dataGridViewProviderInfo.AllowUserToResizeColumns = false;
            this.dataGridViewProviderInfo.AllowUserToResizeRows = false;
            this.dataGridViewProviderInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridViewProviderInfo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewProviderInfo.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewProviderInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProviderInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewProviderInfo.ColumnHeadersHeight = 40;
            this.dataGridViewProviderInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnPicture,
            this.ColumnName,
            this.ColumnContact,
            this.ColumnAdress,
            this.ColumnDues});
            this.dataGridViewProviderInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewProviderInfo.EnableHeadersVisualStyles = false;
            this.dataGridViewProviderInfo.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewProviderInfo.Name = "dataGridViewProviderInfo";
            this.dataGridViewProviderInfo.RowHeadersVisible = false;
            this.dataGridViewProviderInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProviderInfo.Size = new System.Drawing.Size(697, 461);
            this.dataGridViewProviderInfo.TabIndex = 0;
            // 
            // ColumnPicture
            // 
            this.ColumnPicture.HeaderText = "Picture";
            this.ColumnPicture.Name = "ColumnPicture";
            this.ColumnPicture.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnPicture.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnPicture.Width = 104;
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Name";
            this.ColumnName.Name = "ColumnName";
            // 
            // ColumnContact
            // 
            this.ColumnContact.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnContact.HeaderText = "Contact";
            this.ColumnContact.Name = "ColumnContact";
            // 
            // ColumnAdress
            // 
            this.ColumnAdress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnAdress.HeaderText = "Adress";
            this.ColumnAdress.Name = "ColumnAdress";
            // 
            // ColumnDues
            // 
            this.ColumnDues.HeaderText = "Dues";
            this.ColumnDues.Name = "ColumnDues";
            this.ColumnDues.Width = 86;
            // 
            // Providers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelProvidersInfo);
            this.Controls.Add(this.panelStockShare);
            this.Name = "Providers";
            this.Size = new System.Drawing.Size(1034, 461);
            this.panelStockShare.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartStockShares)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelProvidersInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProviderInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelStockShare;
        private System.Windows.Forms.Panel panelProvidersInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelStockShare;
        public System.Windows.Forms.DataGridView dataGridViewProviderInfo;
        private System.Windows.Forms.DataGridViewImageColumn ColumnPicture;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAdress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDues;
        public System.Windows.Forms.DataVisualization.Charting.Chart chartStockShares;
    }
}
