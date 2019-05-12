namespace PointOfSale
{
    partial class MainWindow
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.Toppanel = new System.Windows.Forms.Panel();
            this.Sidepanel = new System.Windows.Forms.Panel();
            this.Lowpanel = new System.Windows.Forms.Panel();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Sidepanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Toppanel
            // 
            this.Toppanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.Toppanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Toppanel.Location = new System.Drawing.Point(0, 0);
            this.Toppanel.Name = "Toppanel";
            this.Toppanel.Size = new System.Drawing.Size(1300, 50);
            this.Toppanel.TabIndex = 0;
            // 
            // Sidepanel
            // 
            this.Sidepanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(42)))));
            this.Sidepanel.Controls.Add(this.pictureBox1);
            this.Sidepanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Sidepanel.Location = new System.Drawing.Point(0, 50);
            this.Sidepanel.Name = "Sidepanel";
            this.Sidepanel.Size = new System.Drawing.Size(250, 600);
            this.Sidepanel.TabIndex = 1;
            // 
            // Lowpanel
            // 
            this.Lowpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.Lowpanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Lowpanel.Location = new System.Drawing.Point(250, 550);
            this.Lowpanel.Name = "Lowpanel";
            this.Lowpanel.Size = new System.Drawing.Size(1050, 100);
            this.Lowpanel.TabIndex = 2;
            // 
            // ContentPanel
            // 
            this.ContentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(64)))));
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentPanel.Location = new System.Drawing.Point(250, 50);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(1050, 500);
            this.ContentPanel.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(207, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.Lowpanel);
            this.Controls.Add(this.Sidepanel);
            this.Controls.Add(this.Toppanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainWindow";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainWindow";
            this.Sidepanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Toppanel;
        private System.Windows.Forms.Panel Sidepanel;
        private System.Windows.Forms.Panel Lowpanel;
        private System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}