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
    public partial class Sales : UserControl
    {
        public Sales()
        {
            InitializeComponent();
        }

        private void dataGridSales_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridSales.CurrentCell.ColumnIndex == 0)
                {
                    if (dataGridSales.CurrentCell.Value.ToString().Length > 2)
                    {
                        string command = "select medicineName,quantity,salePrice,1 * salePrice from stock join medicine on stock.medicneID=medicine.medicineID where barcode =" + dataGridSales.CurrentCell.Value.ToString();
                        DatabaseWorking windowMain = new DatabaseWorking();
                        SqlConnection conn = windowMain.CreateConnectionToSqlDatabase();
                        // windowMain.AddItemsToDataGrid(dataGridSales, command, conn);

                        SqlCommand cmd = new SqlCommand(command, conn);
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        for (int i = 0; i < dt.Columns.Count; i++)
                            dataGridSales.Rows[dataGridSales.CurrentRow.Index].Cells[i + 1].Value = dt.Rows[0][i].ToString();
                        dataGridSales.Rows[dataGridSales.CurrentRow.Index].Cells[2].Value = "1";
                        int item = 0;
                        for (int i = 0; i < dataGridSales.Rows.Count - 1; i++)
                        {

                            item += int.Parse(dataGridSales.Rows[i].Cells[4].Value.ToString());
                        }
                        textBox4.Text = item.ToString();
                        textBox1.Text = item.ToString();
                    }

                    else
                        MessageBox.Show("Invalid Barcode");
                }

                else if (dataGridSales.CurrentCell.ColumnIndex == 2)
                {
                    if (dataGridSales.CurrentCell.Value.ToString().Length > 0)
                    {
                        dataGridSales.Rows[dataGridSales.CurrentRow.Index].Cells[4].Value = int.Parse(dataGridSales.Rows[dataGridSales.CurrentRow.Index].Cells[2].Value.ToString()) * int.Parse(dataGridSales.Rows[dataGridSales.CurrentRow.Index].Cells[3].Value.ToString());

                        int item = 0;
                        for (int i = 0; i < dataGridSales.Rows.Count - 1; i++)
                        {

                            item += int.Parse(dataGridSales.Rows[i].Cells[4].Value.ToString());
                        }
                        textBox4.Text = item.ToString();
                        textBox1.Text = item.ToString();
                    }
                }
                else
                    MessageBox.Show("Invalid Entry", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridSales.SelectedRows.Count > 0)
            {
                for (int i = 0; i < dataGridSales.SelectedRows.Count; i++)
                    dataGridSales.Rows.RemoveAt(dataGridSales.SelectedRows[i].Index);
            }
        }

    

    private void button2_Click(object sender, EventArgs e)
        {
            dataGridSales.Rows.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string itemid = Guid.NewGuid().ToString();
            MessageBox.Show(itemid);
            for (int i = 0; i < dataGridSales.Rows.Count - 1; i++)
            {
                string command;
                //"Declare @medicneID int" +
                //"Set @medicneID =1"+// (select medicineID from medicine where medicineName = ' " + dataGridSales.Rows[i].Cells[1].Value.ToString() + " ') " +
                //"update sale set barcode= ' " + dataGridSales.Rows[i].Cells[0].Value.ToString() + " ' " + ", medicneID= 1 , salePrice =" + dataGridSales.Rows[i].Cells[3].Value.ToString() +
                //", quantity =" + dataGridSales.Rows[i].Cells[2] + ",profit=(select" + int.Parse(dataGridSales.Rows[i].Cells[3].Value.ToString()) + "- costPrice from stock where barcode=" + dataGridSales.Rows[i].Cells[0].Value.ToString() +
                //") ,soldDatewithTime='" + DateTime.Now + "',userID=1 where barcode='" + dataGridSales.Rows[i].Cells[0].Value.ToString()+"'";


                //"Declare @medicneID int" +
                //"Set @medicneID =1"+// (select medicineID from medicine where medicineName = ' " + dataGridSales.Rows[i].Cells[1].Value.ToString() + " ') " +
                // "update sale set barcode= ' " + dataGridSales.Rows[i].Cells[0].Value.ToString() + " ' " + ", medicneID= 1 , salePrice =" + dataGridSales.Rows[i].Cells[3].Value.ToString() +
                // ", quantity =" + dataGridSales.Rows[i].Cells[2] + ",profit=(select" + int.Parse(dataGridSales.Rows[i].Cells[3].Value.ToString()) + "- costPrice from stock where barcode=" + dataGridSales.Rows[i].Cells[0].Value.ToString() +
                // ") ,soldDatewithTime='" + DateTime.Now + "',userID=1 where barcode='" + dataGridSales.Rows[i].Cells[0].Value.ToString() + "'";
                MessageBox.Show(dataGridSales.Rows[i].Cells[0].Value.ToString());
                command = "insert into saleItems values('" + itemid + " ','" + dataGridSales.Rows[i].Cells[0].Value.ToString() + "', (select medicineID from medicine where medicineName = ' " + dataGridSales.Rows[i].Cells[1].Value.ToString() + " ')," + int.Parse(dataGridSales.Rows[i].Cells[3].Value.ToString()) + " , (select " + float.Parse(dataGridSales.Rows[i].Cells[3].Value.ToString()) + " - costPrice from stock where barcode = '" + dataGridSales.Rows[i].Cells[0].Value.ToString() + "')," + int.Parse(dataGridSales.Rows[i].Cells[2].Value.ToString()) + ")";

                DatabaseWorking windowMain = new DatabaseWorking();
                SqlConnection conn = windowMain.CreateConnectionToSqlDatabase();
                SqlCommand cmd = new SqlCommand(command, conn);
                cmd.ExecuteNonQuery();
            }
        }
        static string oldDiscount;

        private void textBox2_Leave(object sender, EventArgs e)
        {
            oldDiscount = textBox2.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (textBox2.Text == "")
                    textBox2.Text = "0";
                if (textBox3.Text == "")
                    textBox3.Text = "0";
                if (textBox4.Text == "")
                    textBox4.Text = "0";

                if (int.Parse(textBox2.Text) >= 0 && int.Parse(textBox2.Text) <= 100)
                {
                    int item = 0;
                    for (int i = 0; i < dataGridSales.Rows.Count - 1; i++)
                    {

                        item += int.Parse(dataGridSales.Rows[i].Cells[4].Value.ToString());
                    }

                    textBox3.Text = ((item * float.Parse(textBox2.Text)) / 100).ToString();
                    textBox4.Text = (item - float.Parse(textBox3.Text)).ToString();


                }
                else
                {
                    DialogResult result = MessageBox.Show("Invalid Entry", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (result == DialogResult.OK)
                    {
                        textBox2.Text = oldDiscount;
                    }
                }
            }
            catch (Exception ex)
            {
                //textBox2.Text = ((TextBox)sender).Text;
                DialogResult result = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (result == DialogResult.OK)
                {
                    textBox2.Text = oldDiscount;
                }
            }
        }
    }
}
