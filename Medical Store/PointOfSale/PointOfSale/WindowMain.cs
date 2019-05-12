using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Data.SqlClient;
using System.Collections;

namespace PointOfSale
{
    public partial class WindowMain : Form
    {
       
        public WindowMain()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (Sidebar.Width == 250)
                Sidebar.Width = 71;
            else
                Sidebar.Width = 250;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            MaximizeIcon.Visible = false;
            SmallisizeIcon.Visible =true ;
           
        }

        private void SmallisizeIcon_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            MaximizeIcon.Visible = true;
            SmallisizeIcon.Visible = false;
        }

        private void MinimizeIcon_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void WindowMain_Load(object sender, EventArgs e)
        {
            LowerUserControl infoPanel = new LowerUserControl();
            if (Login.adminstatus)
                infoPanel.LabelAdminstatus.Text = "Administrator";
            else
                infoPanel.LabelAdminstatus.Text = "Faculty Member";

            infoPanel.LabelUsername.Text = Login.name;

            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(10, 10, pictureBox1.Width - 3, pictureBox1.Height - 3);
            Region rg = new Region(gp);
            pictureBox1.Region = rg;
            infoPanel.pictureBox1.ImageLocation = Login.path;

            SmallisizeIcon.Visible = false;
            this.WindowState = FormWindowState.Maximized;
            AuthorPanel.Controls.Add(infoPanel);
            CreateUserControl(new Welcome());
        }

        
        private void ToggleColor(Button sender)
        {
            var buttonlist = new List<Button>();
            buttonlist.Add(ButtonDashboard);
            buttonlist.Add(ButtonEmployees);
            buttonlist.Add(ButtonProviders);
            buttonlist.Add(ButtonPurchase);
            buttonlist.Add(ButtonReports);
            buttonlist.Add(ButtonStock);
            buttonlist.Add(ButtonSale);

            foreach (var Butto in buttonlist)
                {
                if (Butto.Equals(sender))
                    sender.BackColor = Color.FromArgb(45, 45, 45);
                else
                Butto.BackColor = Color.FromArgb(1,121,197);
            }


        }

        private void ButtonDashboard_MouseDown(object sender, MouseEventArgs e)
        {
            ToggleColor(ButtonDashboard);
        }

        private void ButtonSale_Click(object sender, EventArgs e)
        {
            ToggleColor(ButtonSale);
            ContentPanel.Controls.Clear();
            CreateUserControl(new Sales());
        }

        private void ButtonPurchase_Click(object sender, EventArgs e)
        {
            DatabaseWorking working = new DatabaseWorking();
            Purcahse purcahseTab = new Purcahse();
            ToggleColor(ButtonPurchase);
            ContentPanel.Controls.Clear();
            CreateUserControl(purcahseTab);

            if (purcahseTab.DatagridStock.Rows.Count != 0)
            {
                string[] sql = new string[2];
                sql[0] = "select barcode as Barcode, medicineName as Prouct, quantity as Quantity, expirayDate as [Expiry Date] from stock join medicine on stock.medicneID = medicine.medicineID";
                sql[1] = "select SupplierName from supplier";

                SqlConnection conn = working.CreateConnectionToSqlDatabase();
                working.AddItemsToDataGrid(purcahseTab.DatagridStock, sql[0], conn);
                working.AddItemsToCombobox(purcahseTab.comboBox1, sql[1], conn);
                purcahseTab.comboBox1.SelectedIndex = 0;
            }
        }

        private void ButtonProviders_Click(object sender, EventArgs e)
        {
            Providers providers = new Providers();
            ToggleColor(ButtonProviders);
            ContentPanel.Controls.Clear();
            CreateUserControl(providers);

            DatabaseWorking database = new DatabaseWorking();
            SqlConnection conn = database.CreateConnectionToSqlDatabase();
            string command = "select photo,SupplierName,phone,address,dues from supplier";

            SqlCommand cmd = new SqlCommand(command, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);


            foreach (DataRow dataRow in dt.Rows)
            {
                int rowIndex = providers.dataGridViewProviderInfo.Rows.Add();
                Image image = Image.FromFile(dataRow[0].ToString());
                image = (Image)(new Bitmap(image, new Size(150, 150)));

                // providers.dataGridViewProviderInfo.Rows[rowIndex].Cells[0].Size = new Size(50, 50);
                providers.dataGridViewProviderInfo.Rows[rowIndex].Cells[0].Value = image;
                for (int i = 1; i < dt.Columns.Count; i++)
                {
                    providers.dataGridViewProviderInfo.Rows[rowIndex].Cells[i].Value = dataRow[i].ToString();
                    // providers.dataGridViewProviderInfo.Rows[rowIndex].Cells[providers.dataGridViewProviderInfo.Rows.Count - 1].Value = "Clear Dues";
                }
            }
            providers.dataGridViewProviderInfo.Rows[0].Selected = false;

            command = "select SupplierName , count(barcode)*sum(costPrice) from stock join supplier on stock.supplierID=supplier.supplierID group by SupplierName";
            cmd = new SqlCommand(command, conn);
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);

            providers.chartStockShares.Series["Series1"].Points.RemoveAt(0);
            foreach (DataRow dataRow in dt.Rows)
            {
                providers.chartStockShares.Series["Series1"].Points.AddXY(dataRow[0].ToString(), dataRow[1].ToString());
            }
        }

        private void ButtonEmployees_Click(object sender, EventArgs e)
        {
            Users user = new Users();
            ToggleColor(ButtonEmployees);
            ContentPanel.Controls.Clear();
            CreateUserControl(user);

            DatabaseWorking database = new DatabaseWorking();
            SqlConnection conn = database.CreateConnectionToSqlDatabase();
            string command = "select photo, username,phone,passsword from users";

            SqlCommand cmd = new SqlCommand(command, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);


            foreach (DataRow dataRow in dt.Rows)
            {
                int rowIndex = user.dataGridViewUsers.Rows.Add();
                Image image = Image.FromFile(dataRow[0].ToString());
                image = (Image)(new Bitmap(image, new Size(150, 150)));

                // providers.dataGridViewProviderInfo.Rows[rowIndex].Cells[0].Size = new Size(50, 50);
                user.dataGridViewUsers.Rows[rowIndex].Cells[0].Value = image;
                for (int i = 1; i < dt.Columns.Count; i++)
                {
                    user.dataGridViewUsers.Rows[rowIndex].Cells[i].Value = dataRow[i].ToString();
                    // providers.dataGridViewProviderInfo.Rows[rowIndex].Cells[providers.dataGridViewProviderInfo.Rows.Count - 1].Value = "Clear Dues";
                }
            }

            user.dataGridViewUsers.Rows[0].Selected=false;

        }

        private void ButtonStock_Click(object sender, EventArgs e)
        {
            Stock stock = new Stock();
            ToggleColor(ButtonStock);
            ContentPanel.Controls.Clear();
            CreateUserControl(stock);

            DatabaseWorking database = new DatabaseWorking();
            string command = "select barcode,medicineName,salePrice,costPrice,quantity,expirayDate from stock join medicine on stock.medicneID=medicine.medicineID;";
            SqlConnection sqlConnection = database.CreateConnectionToSqlDatabase();

            database.AddItemsToDataGrid(stock.dataGridViewStock,command,sqlConnection);

        }

        private void ButtonReports_Click(object sender, EventArgs e)
        {
            Reports reports = new Reports();
            ToggleColor(ButtonReports);
            ContentPanel.Controls.Clear();
            CreateUserControl(reports);

            DatabaseWorking database = new DatabaseWorking();
            string command = "select distinct soldDate from saleOrder";
            SqlConnection sqlConnection= database.CreateConnectionToSqlDatabase();
            
            database.AddItemsToCombobox( reports.comboBoxFromdate,command, sqlConnection);
            database.AddItemsToCombobox(reports.comboBoxTillDate, command, sqlConnection);

            command = "select soldDate, SUM([totalPrice]) from saleOrder   group by soldDate ";
            SqlCommand cmd = new SqlCommand(command,sqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            foreach(DataRow dataRow in dt.Rows)
                reports.chartSalesPerday.Series["Series1"].Points.AddXY(dataRow[0].ToString(), dataRow[1].ToString());


        }

        private void ButtonDashboard_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            ContentPanel.Controls.Clear();
            CreateUserControl(dashboard);

            DatabaseWorking database = new DatabaseWorking();
            string command = "select count(supplierID) from supplier ";
            SqlConnection sqlConnection = database.CreateConnectionToSqlDatabase();

            SqlCommand cmd = new SqlCommand(command, sqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dashboard.labelTotalProviders.Text = dt.Rows[0][0].ToString();

            command = "select sum(totalPrice) from saleOrder";
            cmd = new SqlCommand(command, sqlConnection);
            adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            dashboard.labelSales.Text ="RS "+ dt.Rows[0][0].ToString();

            command = "select count(distinct medicneID) from stock ";
            cmd = new SqlCommand(command, sqlConnection);
            adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            dashboard.labelProducts.Text = dt.Rows[0][0].ToString();

            command = "select count(orderID) from saleOrder";
            cmd = new SqlCommand(command, sqlConnection);
            adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            dashboard.labelServed.Text = dt.Rows[0][0].ToString();

            command = "select count(userID) from users";
            cmd = new SqlCommand(command, sqlConnection);
            adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            dashboard.labelTotalEmployees.Text = dt.Rows[0][0].ToString();

            command = "select count(CompanyName) from stock join medicine on stock.medicneID=medicine.medicineID";
            cmd = new SqlCommand(command, sqlConnection);
            adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            dashboard.labelBrands.Text = dt.Rows[0][0].ToString();

        }

        public void CreateUserControl(UserControl UC)
        {

            
            
                UC.Size = new Size(1034, 561);
                UC.Dock = DockStyle.Fill;
           
           
                
            ContentPanel.Controls.Add(UC);

        }

        private void PictureboxLogout_Click(object sender, EventArgs e)
        {
            var z = PointOfSale.WindowMain.ActiveForm;
            z.Hide();
            var x = new Login();
            x.Show();
            



        }
    }
}
