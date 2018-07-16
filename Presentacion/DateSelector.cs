using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class DateSelector : Form
    {
        public DateSelector()
        {
            InitializeComponent();
            this.CenterToParent();
        }

        private void select(object sender, EventArgs e)
        {
            DateTime d = dtpSelector.Value.Date;
            if (d > DateTime.Today)
                { MessageBox.Show("No puede seleccionar un dia posterior al actual");
                return;
            }
            FormControlGeneral.setReportDay(d);
            this.Close();
        }
    }
}
