namespace PointOfSale
{
    partial class Reports
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
            this.chartSalesPerday = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelFrom = new System.Windows.Forms.Label();
            this.comboBoxFromdate = new System.Windows.Forms.ComboBox();
            this.labelTill = new System.Windows.Forms.Label();
            this.comboBoxTillDate = new System.Windows.Forms.ComboBox();
            this.buttonPlot = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartSalesPerday)).BeginInit();
            this.SuspendLayout();
            // 
            // chartSalesPerday
            // 
            chartArea1.Name = "ChartArea1";
            this.chartSalesPerday.ChartAreas.Add(chartArea1);
            this.chartSalesPerday.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartSalesPerday.Legends.Add(legend1);
            this.chartSalesPerday.Location = new System.Drawing.Point(0, 0);
            this.chartSalesPerday.Name = "chartSalesPerday";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartSalesPerday.Series.Add(series1);
            this.chartSalesPerday.Size = new System.Drawing.Size(1034, 461);
            this.chartSalesPerday.TabIndex = 0;
            this.chartSalesPerday.Text = "chart1";
            this.chartSalesPerday.Click += new System.EventHandler(this.chartSalesPerday_Click);
            // 
            // labelFrom
            // 
            this.labelFrom.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelFrom.AutoSize = true;
            this.labelFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFrom.Location = new System.Drawing.Point(900, 111);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(70, 29);
            this.labelFrom.TabIndex = 1;
            this.labelFrom.Text = "From";
            // 
            // comboBoxFromdate
            // 
            this.comboBoxFromdate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.comboBoxFromdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFromdate.FormattingEnabled = true;
            this.comboBoxFromdate.Location = new System.Drawing.Point(905, 144);
            this.comboBoxFromdate.Name = "comboBoxFromdate";
            this.comboBoxFromdate.Size = new System.Drawing.Size(108, 32);
            this.comboBoxFromdate.TabIndex = 3;
            this.comboBoxFromdate.SelectedIndexChanged += new System.EventHandler(this.comboBoxFromdate_SelectedIndexChanged);
            // 
            // labelTill
            // 
            this.labelTill.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelTill.AutoSize = true;
            this.labelTill.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTill.Location = new System.Drawing.Point(900, 178);
            this.labelTill.Name = "labelTill";
            this.labelTill.Size = new System.Drawing.Size(47, 29);
            this.labelTill.TabIndex = 4;
            this.labelTill.Text = "Till";
            this.labelTill.Click += new System.EventHandler(this.labelTill_Click);
            // 
            // comboBoxTillDate
            // 
            this.comboBoxTillDate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.comboBoxTillDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTillDate.FormattingEnabled = true;
            this.comboBoxTillDate.Location = new System.Drawing.Point(905, 211);
            this.comboBoxTillDate.Name = "comboBoxTillDate";
            this.comboBoxTillDate.Size = new System.Drawing.Size(108, 32);
            this.comboBoxTillDate.TabIndex = 5;
            this.comboBoxTillDate.SelectedIndexChanged += new System.EventHandler(this.comboBoxTillDate_SelectedIndexChanged);
            // 
            // buttonPlot
            // 
            this.buttonPlot.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonPlot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(66)))));
            this.buttonPlot.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlot.ForeColor = System.Drawing.Color.White;
            this.buttonPlot.Location = new System.Drawing.Point(901, 276);
            this.buttonPlot.Name = "buttonPlot";
            this.buttonPlot.Size = new System.Drawing.Size(112, 77);
            this.buttonPlot.TabIndex = 6;
            this.buttonPlot.Text = "Plot";
            this.buttonPlot.UseVisualStyleBackColor = false;
            this.buttonPlot.Click += new System.EventHandler(this.buttonPlot_Click);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.buttonPlot);
            this.Controls.Add(this.comboBoxTillDate);
            this.Controls.Add(this.labelTill);
            this.Controls.Add(this.comboBoxFromdate);
            this.Controls.Add(this.labelFrom);
            this.Controls.Add(this.chartSalesPerday);
            this.Name = "Reports";
            this.Size = new System.Drawing.Size(1034, 461);
            ((System.ComponentModel.ISupportInitialize)(this.chartSalesPerday)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.Label labelTill;
        public System.Windows.Forms.DataVisualization.Charting.Chart chartSalesPerday;
        public System.Windows.Forms.ComboBox comboBoxFromdate;
        public System.Windows.Forms.ComboBox comboBoxTillDate;
        public System.Windows.Forms.Button buttonPlot;
    }
}
