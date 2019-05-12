namespace PointOfSale
{
    partial class Users
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.ColumnPicture = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columncontact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonDelete);
            this.panel2.Controls.Add(this.buttonAddUser);
            this.panel2.Controls.Add(this.dataGridViewUsers);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1034, 461);
            this.panel2.TabIndex = 1;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(121)))), ((int)(((byte)(97)))));
            this.buttonDelete.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(520, 401);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(124, 57);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonAddUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(121)))), ((int)(((byte)(97)))));
            this.buttonAddUser.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddUser.ForeColor = System.Drawing.Color.White;
            this.buttonAddUser.Location = new System.Drawing.Point(390, 401);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(124, 57);
            this.buttonAddUser.TabIndex = 1;
            this.buttonAddUser.Text = "Add";
            this.buttonAddUser.UseVisualStyleBackColor = false;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.AllowUserToResizeRows = false;
            this.dataGridViewUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUsers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewUsers.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewUsers.ColumnHeadersHeight = 40;
            this.dataGridViewUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnPicture,
            this.ColumnName,
            this.Columncontact,
            this.ColumnPassword});
            this.dataGridViewUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewUsers.EnableHeadersVisualStyles = false;
            this.dataGridViewUsers.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.RowHeadersVisible = false;
            this.dataGridViewUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUsers.Size = new System.Drawing.Size(1034, 461);
            this.dataGridViewUsers.TabIndex = 0;
            // 
            // ColumnPicture
            // 
            this.ColumnPicture.HeaderText = "Picture";
            this.ColumnPicture.Name = "ColumnPicture";
            this.ColumnPicture.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnPicture.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Name";
            this.ColumnName.Name = "ColumnName";
            // 
            // Columncontact
            // 
            this.Columncontact.HeaderText = "Contact";
            this.Columncontact.Name = "Columncontact";
            // 
            // ColumnPassword
            // 
            this.ColumnPassword.HeaderText = "Password";
            this.ColumnPassword.Name = "ColumnPassword";
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Name = "Users";
            this.Size = new System.Drawing.Size(1034, 461);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAddUser;
        public System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.DataGridViewImageColumn ColumnPicture;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columncontact;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPassword;
    }
}
