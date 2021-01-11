using System;
using System.Windows.Forms;
using System.Linq;
using System.Linq.Expressions;

namespace Прокат_и_ремонт_автомобилей
{
    public partial class frmLogin : Form
    {
        CarAndRepairDBModel db = new CarAndRepairDBModel();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            frmRegistration frmRegistration = new frmRegistration();
            frmRegistration.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblErrorLoginOrPassword.Text = string.Empty;
            if (txtLogin.Text == "admincar" && txtPassword.Text == "admincar")
            {
                frmCompany frmCompany = new frmCompany();
                frmCompany.Show();
                txtLogin.Text = string.Empty;
                txtPassword.Text = string.Empty;
            }
            else
            {
                var result = from registration in db.Registration
                             select new { registration.Login, registration.Password };
                try
                {
                    foreach (var f in result)
                    {
                        if (f.Login.ToString() == txtLogin.Text && f.Password.ToString() == txtPassword.Text)
                        {
                            frmClient frmClient = new frmClient();
                            frmClient.Show();
                            return;
                        }
                    }
                }
                finally
                {
                    lblErrorLoginOrPassword.Text = "Вы ввели неправильный логин и/или пароль!";
                }
            }
        }

        private void cbPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = cbPassword.Checked ? '\0' : '*';
        }
    }
}
