using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

namespace PointOfSale
{
    class DatabaseWorking
    {
        public SqlConnection CreateConnectionToSqlDatabase()
        {
            string connectionString = "Data Source=ANUS-PC\\SQLEXPRESS;Initial Catalog=medicalStore;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            if (conn.State == ConnectionState.Open)
                return conn;
            else
            {
                MessageBox.Show("The connection to server is not possible!", "Server Down", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return null;
            }
        }

        public void AddItemsToDataGrid(DataGridView grid, string command, SqlConnection conn)
        {
            try
            {
                ArrayList row = new ArrayList();

                SqlCommand cmd = new SqlCommand(command, conn);
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
                    row.Add(items);
                }

                foreach (string[] rowaray in row)
                    grid.Rows.Add(rowaray);
                conn.Close();

            }
            catch
            {
                if (conn.State != ConnectionState.Open)
                    MessageBox.Show("The connection to server is not possible!", "Server Down", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                else
                    conn.Close();
            }
        }

        public void AddItemsToCombobox(ComboBox comboBox, string command, SqlConnection conn)
        {
            try
            {
                ArrayList row = new ArrayList();

                SqlCommand cmd = new SqlCommand(command, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                foreach (DataRow dataRow in dt.Rows)
                {
                    string item = dataRow[0].ToString();
                    comboBox.Items.Add(item);
                }
                conn.Close();
            }
            catch
            {
                if (conn.State != ConnectionState.Open)
                    MessageBox.Show("The connection to server is not possible!", "Server Down", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                else
                    conn.Close();
            }
        }

        public void AddItemsToComboboxOnDate(ComboBox comboBox, string command, SqlConnection conn)
        {
            try
            {
                ArrayList row = new ArrayList();

                SqlCommand cmd = new SqlCommand(command, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                foreach (DataRow dataRow in dt.Rows)
                {
                    string item = dataRow[0].ToString();
                    comboBox.Items.Add(item);
                }
                conn.Close();
            }
            catch
            {
                if (conn.State != ConnectionState.Open)
                    MessageBox.Show("The connection to server is not possible!", "Server Down", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                else
                    conn.Close();
            }
        }
    }
}
