using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSale
{
    public partial class Providers : UserControl
    {
        public Providers()
        {
            InitializeComponent();
            chartStockShares.Titles.Add("Stock Shares");
            chartStockShares.Series["Series1"].Points.AddXY("1","20");
        }
    }
}
