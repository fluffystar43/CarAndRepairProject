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
    public partial class frmRegistration : Form
    {
        public frmRegistration()
        {
            InitializeComponent();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            try
            {
                lblError.Text = String.Empty;
                if (txtLogin.Text == String.Empty || txtPassword.Text == String.Empty ||
                    txtFamilyName.Text == String.Empty || txtName.Text == String.Empty ||
                    txtSeriesAndNumber.Text == String.Empty || txtDriverLicense.Text == String.Empty)
                    lblError.Text = "Одно из обязательных полей не заполнено! (*)";
                else
                {
                    Registration reg = new Registration();                    
                    reg.Login = txtLogin.Text;
                    reg.Password = txtPassword.Text;
                    reg.FamilyName = txtFamilyName.Text;
                    reg.Name = txtName.Text;
                    reg.Patronymic = txtPatronymic.Text;
                    reg.SeriesAndNumber = txtSeriesAndNumber.Text;
                    reg.DriverLicense = txtDriverLicense.Text;
                    reg.NumberOfPhone = txtNumberOfPhone.Text;
                    var registration = new CarAndRepairDBModel();                    
                    registration.Registration.Add(reg);
                    registration.SaveChanges();
                }
            }
            catch
            {

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
