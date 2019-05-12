using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PointOfSale
{
    public partial class AddNewUser : UserControl
    {
        private string imagePath;
        public AddNewUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialogPicture.ShowDialog()==DialogResult.OK)
            {
                pictureBox1.Image =new Bitmap(openFileDialogPicture.FileName) ;
                imagePath = openFileDialogPicture.FileName;
            }
            
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int admincheck;
            if (checkBox1.Checked)
            {
                admincheck = 1;
            }
            else if (checkBox2.Checked)
                admincheck = 0;
            else
                admincheck = 0;

            if(textBoxFirstName.Text!="" && textBoxLastName.Text != "" && textBoxUsername.Text != "" && textBoxPassword.Text != "" && admincheck.ToString() != "" && textBox1.Text != "" && imagePath!="" && comboBox1.SelectedItem.ToString()!="")
            {
                DatabaseWorking database = new DatabaseWorking();
                SqlConnection conn = database.CreateConnectionToSqlDatabase();
                string command = "insert into users values('" + textBoxFirstName.Text + "','" + textBoxLastName.Text + "','" + textBoxUsername.Text + "','" + textBoxPassword.Text + "','" + admincheck.ToString() + "','" + textBox1.Text + "','" + comboBox1.SelectedItem + "','" + imagePath + "')";

                SqlCommand cmd = new SqlCommand(command, conn);
                int affected = cmd.ExecuteNonQuery();

                if (affected > 0)
                {
                    MessageBox.Show("User inserted successfully");
                    textBoxFirstName.Text = "";
                    textBoxLastName.Text = "";
                    textBoxUsername.Text = "";
                    textBoxPassword.Text = "";
                    textBox1.Text = "";
                    imagePath = "";
                    pictureBox1.ImageLocation = "";
                }
                else
                    MessageBox.Show("Some Error caused in insertion");
            }
            else
            {
                MessageBox.Show("Please fill all required fields");
            }
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
