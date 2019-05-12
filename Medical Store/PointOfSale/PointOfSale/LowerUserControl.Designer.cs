namespace PointOfSale
{
    partial class LowerUserControl
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LowerUserControl));
            this.LabelTime = new System.Windows.Forms.Label();
            this.LabelDate = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LabelUsername = new System.Windows.Forms.Label();
            this.LabelAdminstatus = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelTime
            // 
            this.LabelTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelTime.AutoSize = true;
            this.LabelTime.Font = new System.Drawing.Font("Agency FB", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTime.ForeColor = System.Drawing.Color.White;
            this.LabelTime.Location = new System.Drawing.Point(859, 0);
            this.LabelTime.Name = "LabelTime";
            this.LabelTime.Size = new System.Drawing.Size(0, 77);
            this.LabelTime.TabIndex = 0;
            // 
            // LabelDate
            // 
            this.LabelDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelDate.AutoSize = true;
            this.LabelDate.Font = new System.Drawing.Font("Agency FB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDate.ForeColor = System.Drawing.Color.White;
            this.LabelDate.Location = new System.Drawing.Point(910, 66);
            this.LabelDate.Name = "LabelDate";
            this.LabelDate.Size = new System.Drawing.Size(0, 34);
            this.LabelDate.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
          //  this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
           // this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
          //  this.pictureBox1.Resize += new System.EventHandler(this.pictureBox1_Resize);
            // 
            // LabelUsername
            // 
            this.LabelUsername.AutoSize = true;
            this.LabelUsername.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUsername.ForeColor = System.Drawing.Color.White;
            this.LabelUsername.Location = new System.Drawing.Point(154, 53);
            this.LabelUsername.Name = "LabelUsername";
            this.LabelUsername.Size = new System.Drawing.Size(137, 32);
            this.LabelUsername.TabIndex = 4;
            this.LabelUsername.Text = "Abdullah Sohail";
            // 
            // LabelAdminstatus
            // 
            this.LabelAdminstatus.AutoSize = true;
            this.LabelAdminstatus.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAdminstatus.ForeColor = System.Drawing.Color.White;
            this.LabelAdminstatus.Location = new System.Drawing.Point(153, 13);
            this.LabelAdminstatus.Name = "LabelAdminstatus";
            this.LabelAdminstatus.Size = new System.Drawing.Size(166, 40);
            this.LabelAdminstatus.TabIndex = 5;
            this.LabelAdminstatus.Text = "Admininstrator";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LowerUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LabelAdminstatus);
            this.Controls.Add(this.LabelUsername);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LabelDate);
            this.Controls.Add(this.LabelTime);
            this.Name = "LowerUserControl";
            this.Size = new System.Drawing.Size(1034, 100);
            this.Load += new System.EventHandler(this.LowerUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelTime;
        private System.Windows.Forms.Label LabelDate;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label LabelUsername;
        public System.Windows.Forms.Label LabelAdminstatus;
    }
}
