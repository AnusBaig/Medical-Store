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
    public partial class Newitem : UserControl
    {
        public Newitem()
        {
            InitializeComponent();
        }

        

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            textBoxBarcode.Text = Stock.random;
            if (textBoxBarcode.Text.Length == 12 && textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.ToString() != "" && textBox5.Text != "" && textBox6.Text!= "" && textBox7.Text!= "")
            {
                DatabaseWorking database = new DatabaseWorking();
                SqlConnection conn = database.CreateConnectionToSqlDatabase();
                string command = "insert into stock values('"+textBoxBarcode.Text+"', (select medicineID from medicine where medicineName='"+ textBox1 .Text+ "') ,"+textBox2.Text+ " ,"+ textBox3 .Text+ " , "+textBox4.Text+ ", (select supplierID from supplier where SupplierName='"+ textBox5.Text+ "'),'"+textBox6.Text+ "','"+textBox7 .Text+ "')";

                SqlCommand cmd = new SqlCommand(command, conn);
                int affected = cmd.ExecuteNonQuery();

                if (affected > 0)
                {
                    MessageBox.Show("item inserted into stock successfully");
                    textBoxBarcode.Text = "";
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5 .Text= "";
                    textBox6.Text= "";
                    textBox7.Text = "";
                }
                else
                    MessageBox.Show("Some Error caused in insertion");
            }
            else
            {
                MessageBox.Show("Please fill all required fields");
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
