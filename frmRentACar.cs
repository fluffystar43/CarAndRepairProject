using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Прокат_и_ремонт_автомобилей
{
    public partial class frmRentACar : Form
    {
        public frmRentACar()
        {
            InitializeComponent();
            DateTime dateTime = new DateTime();
            
            dateTime = DateTime.Now;
            dateTime.AddHours(1);
            dtpRent.MinDate = dateTime;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
