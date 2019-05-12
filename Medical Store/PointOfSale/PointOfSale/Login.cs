using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PointOfSale
{
    public partial class Login : Form
    {
        public static bool adminstatus;
        public static string name;
        public static string path;

        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void UserTextbox_Enter(object sender, EventArgs e)
        {
            if (UserTextbox.Text == "User")
            {
                UserTextbox.Text = "";
                
            }
            UserTextbox.ForeColor = Color.White;
        }

        private void UserTextbox_Leave(object sender, EventArgs e)
        {
            if (UserTextbox.Text == "")
            {
                UserTextbox.Text = "User"
                   ;
                UserTextbox.ForeColor = Color.DimGray;
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Password")
            {
                textBox1.Clear();
             
            }
            textBox1.ForeColor = Color.White;
            textBox1.UseSystemPasswordChar = true;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Password";
                textBox1.ForeColor = Color.DimGray;
                textBox1.UseSystemPasswordChar = false;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.ActiveControl = label1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
              string command = "select * from users where username = '" + UserTextbox.Text.ToString() +"' and passsword = '"+textBox1.Text.ToString()+"'";
         //   string command = "insert into users values('Anus','Baig','anusbaig57','medical',2,'03343854480','Male','C:\\Users\\anasb\\Documents\\MedicalStore\\UserImages\\AnusBaig.jpg')";
            DatabaseWorking db = new DatabaseWorking();
            SqlConnection conn= db.CreateConnectionToSqlDatabase();
            SqlCommand cmd = new SqlCommand(command,conn);

            
             SqlDataAdapter adapter = new SqlDataAdapter(cmd);
             DataTable dt = new DataTable();
             adapter.Fill(dt);

            try
            {
                if (dt.Rows[0][3].ToString() == UserTextbox.Text && dt.Rows[0][4].ToString() == textBox1.Text)
                {
                    name = dt.Rows[0][1].ToString() + " " + dt.Rows[0][2].ToString();
                    path = dt.Rows[0][8].ToString();
                    adminstatus = bool.Parse(dt.Rows[0][5].ToString());
                    WindowMain WindowMain = new WindowMain();
                    WindowMain.Show();
                    this.Close();
                }
                else
                {
                    DialogResult dialogueResult = MessageBox.Show("Incorrect UserName or Password", "Incoorect Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    if (dialogueResult == DialogResult.Cancel)
                    this.Close();
                }
            }
            catch( Exception ex)
            {
                MessageBox.Show("You are not a member of this Software's users", "Incoorect Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
    }
}
