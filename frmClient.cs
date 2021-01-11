using System;
using System.Windows.Forms;
using System.Linq;

namespace Прокат_и_ремонт_автомобилей
{
    public partial class frmClient : Form
    {
        CarAndRepairDBModel db = new CarAndRepairDBModel();
        public frmClient()
        {
            InitializeComponent();
            cbListCars.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void btnRentACar_Click(object sender, EventArgs e)
        {
            frmRentACar frmRentACar = new frmRentACar();
            frmRentACar.Show();
        }

        private void LoadInfoСars()
        {
            var result = from c in db.Car
                         select c;
            foreach (var f in result)
            {               
                cbListCars.Items.Add(f.Brand + " " + f.Class);
            }   
        }

        //private void LoadInfoСarsNotInRent()
        //{
        //    var result = from c in db.Car 
        //                 join rent in db.RentACar on c.IDcar equals rent.IDcar
        //                 join rate in db.Rate on rent.IDrate equals rate.IDRate
        //                 select new 
        //                 { 
        //                     NameCar = c.Brand + "" + c.Class,
                             
                             
        //                 };
        //    foreach (var f in result)
        //    {
        //        cbListCars.Items.Add(f.Brand + " " + f.Class);
        //    }



        //    int CountRow = 0;
        //    dgvInfoClients.RowCount = 0;
        //    var result = from client in db.Client
        //                 select client;
        //    foreach (var f in result)
        //    {
        //        dgvInfoClients.RowCount++;
        //        dgvInfoClients.Rows[CountRow].Cells[0].Value = f.IDclient.ToString();
        //        dgvInfoClients.Rows[CountRow].Cells[1].Value = f.FamilyName.ToString();
        //        dgvInfoClients.Rows[CountRow].Cells[2].Value = f.Name.ToString();
        //        dgvInfoClients.Rows[CountRow].Cells[3].Value = f.Patronymic.ToString();
        //        dgvInfoClients.Rows[CountRow].Cells[4].Value = f.PassportData.ToString();
        //        dgvInfoClients.Rows[CountRow].Cells[5].Value = f.DriversLicense.ToString();
        //        dgvInfoClients.Rows[CountRow].Cells[6].Value = f.NumberOfPhone.ToString();
        //        CountRow++;
        //    }
        //}

        private void tpRepairCar_Enter(object sender, EventArgs e)
        {
            LoadInfoСars();
        }
    }
}
