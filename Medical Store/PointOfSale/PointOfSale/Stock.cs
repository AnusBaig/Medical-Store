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
    public partial class Stock : UserControl
    {
        public Stock()
        {
            InitializeComponent();
        }

        public string GenerateNumber()
        {
            Random random = new Random();
            string r = "";
            int i;
            for (i = 1; i < 13; i++)
            {
                r += random.Next(0, 9).ToString();
            }
            return r;
        }
        public static string random;
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var x = new Newitem();

            x.Size = new Size(1034, 561);
            x.Dock = DockStyle.Fill;
            this.Controls.Clear();
            this.Controls.Add(x);

            random = this.GenerateNumber();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            DatabaseWorking database = new DatabaseWorking();
            SqlConnection conn = database.CreateConnectionToSqlDatabase();

            if (dataGridViewStock.SelectedRows.Count > 0)
            {
                string command = "";
                for (int i = 0; i < dataGridViewStock.SelectedRows.Count; i++)
                {
                    command = "delete from stock where barcode='" + dataGridViewStock.SelectedRows[i].Cells[0].Value.ToString() + "'";

                    SqlCommand cmd = new SqlCommand(command, conn);
                    int affected = cmd.ExecuteNonQuery();

                    if (affected > 0)
                    {
                        MessageBox.Show("Item from stock deleted");
                        dataGridViewStock.Rows.RemoveAt(dataGridViewStock.SelectedRows[i].Index);

                    }
                    else
                        MessageBox.Show("Deletion not possible");
                }
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            DatabaseWorking database = new DatabaseWorking();
            SqlConnection conn = database.CreateConnectionToSqlDatabase();
            DataGridViewRow row= dataGridViewStock.Rows[dataGridViewStock.SelectedRows[0].Index];
            string command = "update stock set medicneID = (select medicineID from medicine where medicineName='" + row.Cells[1].Value +"'), salePrice = '"+ dataGridViewStock.Rows[dataGridViewStock.SelectedRows[0].Index].Cells[2].Value + "', costPrice = '"+ dataGridViewStock.Rows[dataGridViewStock.SelectedRows[0].Index].Cells[3].Value + "', quantity = '"+ dataGridViewStock.Rows[dataGridViewStock.SelectedRows[0].Index].Cells[4].Value + "', expirayDate = '"+ dataGridViewStock.Rows[dataGridViewStock.SelectedRows[0].Index].Cells[5].Value + "' from stock where barcode='"+ dataGridViewStock.Rows[dataGridViewStock.SelectedRows[0].Index].Cells[0].Value+"'";
            if (dataGridViewStock.SelectedRows.Count==1)
            {
                SqlCommand cmd = new SqlCommand(command, conn);
                int affected = cmd.ExecuteNonQuery();

                if (affected > 0)
                {
                    MessageBox.Show("Item updated succesfully");
                }
                else
                    MessageBox.Show("Updation not possible");
            
        }
        }
    }
}
