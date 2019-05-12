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
    public partial class LowerUserControl : UserControl
    {
        public LowerUserControl()
        {
            InitializeComponent();
        }

        private void LowerUserControl_Load(object sender, EventArgs e)
        {
            LabelDate.Text = string.Format(@"{0}/{1}/{2}", DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year);
            timer1.Start();
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var x = DateTime.Now;
            LabelTime.Text = string.Format("{0}:{1}:{2}", x.TimeOfDay.Hours, x.TimeOfDay.Minutes, x.TimeOfDay.Seconds);
        }

        
    }
}
