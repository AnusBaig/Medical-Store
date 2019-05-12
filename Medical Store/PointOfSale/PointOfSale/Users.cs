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
    public partial class Users : UserControl
    {
        public Users()
        {
            InitializeComponent();
           
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            var x = new AddNewUser();
            x.Size = new Size(1034, 561);
            x.Dock = DockStyle.Fill;
            this.Controls.Clear();
            this.Controls.Add(x);




        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DatabaseWorking database = new DatabaseWorking();
            SqlConnection conn= database.CreateConnectionToSqlDatabase();

            if (dataGridViewUsers.SelectedRows.Count > 0)
            {
                string command="";
                for (int i = 0; i < dataGridViewUsers.SelectedRows.Count; i++)
                {
                    command = "delete from users where username='" + dataGridViewUsers.SelectedRows[i].Cells[1].Value.ToString() + "'";

                    SqlCommand cmd = new SqlCommand(command, conn);
                    int affected = cmd.ExecuteNonQuery();

                    if (affected > 0)
                    {
                        MessageBox.Show("User succesfully deleted");
                        dataGridViewUsers.Rows.RemoveAt(dataGridViewUsers.SelectedRows[i].Index);

                    }
                    else
                        MessageBox.Show("Deletion not possible");
                }
            }
        }
    }
}
