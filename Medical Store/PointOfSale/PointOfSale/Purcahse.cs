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
using System.Collections;

namespace PointOfSale
{
    public partial class Purcahse : UserControl
    {
        public Purcahse()
        {
            InitializeComponent();
        }

        string connectionString = "Data Source=ANUS-PC\\SQLEXPRESS;Initial Catalog=medicalStore;Integrated Security=True";
        SqlConnection conn;

        private void LabelQuantity_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void LabelSupplier_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LabelPurchaseCost_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSale_Click(object sender, EventArgs e)
        {
            buttonReturnStock.Hide();
            buttonPurchase.Show();
            buttonReturn.BackColor = Color.FromArgb(64, 64, 66);
            buttonReturn.ForeColor = Color.Black;
            buttonSale.BackColor = Color.FromArgb(1, 121, 197);
            buttonSale.ForeColor = Color.White;
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            buttonPurchase.Hide();
            buttonReturnStock.Show();
            buttonSale.BackColor = Color.FromArgb(64, 64, 66);
            buttonSale.ForeColor = Color.Black;
            buttonReturn.BackColor = Color.FromArgb(1, 121, 197);
            buttonReturn.ForeColor = Color.White;
        }

        private void buttonManualadd_Click(object sender, EventArgs e)
        {

            conn = new SqlConnection(connectionString);
            SqlCommand cmd;
            string sql = "select barcode as Barcode, medicineName as Product, quantity as Quantity, expirayDate as [Expiry Date] from stock join medicine on stock.medicneID = medicine.medicineID where barcode = " + textBox2.Text;

            try
            {
                ArrayList row = new ArrayList();
                conn.Open();
                cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                foreach (DataRow dataRow in dt.Rows)
                {
                    string[] items = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        items[i] = dataRow[i].ToString();
                    }
                    items[2] = 1.ToString();
                    row.Add(items);
                }
                foreach (string[] rowaray in row)
                {
                    dataGridViewPurchase.Rows.Add(rowaray);
                }
                conn.Close();
            }
            catch
            {
                conn.Close();
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string sql = "select barcode as Barcode, medicineName as Prouct, quantity as Quantity, expirayDate as [Expiry Date] from stock join medicine on stock.medicneID = medicine.medicineID where quantity<" + textBox1.Text;

            DatabaseWorking windowMain = new DatabaseWorking();
            SqlConnection conn = windowMain.CreateConnectionToSqlDatabase();
            DatagridStock.Rows.Clear();
            windowMain.AddItemsToDataGrid(DatagridStock, sql, conn);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (DatagridStock.SelectedRows.Count > 0)
            {
                for (int i = 0; i < DatagridStock.SelectedRows.Count; i++)
                {
                    string[] item = new string[]
                    {
                        DatagridStock.SelectedRows[i].Cells[0].Value.ToString(),
                        DatagridStock.SelectedRows[i].Cells[1].Value.ToString(),
                        DatagridStock.SelectedRows[i].Cells[2].Value.ToString(),
                        DatagridStock.SelectedRows[i].Cells[3].Value.ToString()
                    };

                    dataGridViewPurchase.Rows.Add(item);
                }
            }
        }

        private void buttonAddAll_Click(object sender, EventArgs e)
        {
            if (DatagridStock.Rows.Count > 0)
            {
                for (int i = 0; i < DatagridStock.Rows.Count - 1; i++)
                {
                    string[] item = new string[]
                    {
                        DatagridStock.Rows[i].Cells[0].Value.ToString(),
                        DatagridStock.Rows[i].Cells[1].Value.ToString(),
                        DatagridStock.Rows[i].Cells[2].Value.ToString(),
                        DatagridStock.Rows[i].Cells[3].Value.ToString()
                    };

                    dataGridViewPurchase.Rows.Add(item);
                }
            }
        }

        private void buttonPurchase_Click(object sender, EventArgs e)
        {
            DatabaseWorking windowMain = new DatabaseWorking();
            SqlConnection conn = windowMain.CreateConnectionToSqlDatabase();
            dataGridViewPurchase.Rows.Clear();
            SqlCommand cmd;

            MessageBox.Show(dataGridViewPurchase.Rows.Count.ToString());
           for (int i = 0; i < dataGridViewPurchase.Rows.Count - 1; i++)
           {
                MessageBox.Show("Item"+ dataGridViewPurchase.Rows[0].Cells[1].Value.ToString());
                string command =
"select barcode , medicineName , quantity , expirayDate from stock join medicine on stock.medicneID=medicine.medicineID where barcode = '" + dataGridViewPurchase.Rows[0].Cells[0].Value + "' and medicineName = '" + dataGridViewPurchase.Rows[0].Cells[1].Value + "'" +
"if @@ROWCOUNT > 0" +
"Begin " +
"update stock set quantity = quantity + '" + dataGridViewPurchase.Rows[0].Cells[2].Value + "' , supplierID = (select supplierID from supplier where SupplierName = '" + comboBox1.SelectedItem + "')  where barcode = '" + dataGridViewPurchase.Rows[0].Cells[0].Value + "'" +
" End";
                
                cmd = new SqlCommand(command, conn);

                int affected = cmd.ExecuteNonQuery();

                if (affected > 0)
                    MessageBox.Show("Purcahsed successfull !");
                else
                    MessageBox.Show("Purcahsed unsuccessfull !" +affected);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewPurchase.SelectedRows.Count > 0)
            {
                for (int i = 0; i < dataGridViewPurchase.SelectedRows.Count; i++)
                    dataGridViewPurchase.Rows.RemoveAt(dataGridViewPurchase.SelectedRows[i].Index);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            dataGridViewPurchase.Rows.Clear();
        }

        private void buttonReturnStock_Click(object sender, EventArgs e)
        {

        }
    }
}
