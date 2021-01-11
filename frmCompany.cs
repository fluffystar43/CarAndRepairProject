using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Прокат_и_ремонт_автомобилей
{
    public partial class frmCompany : Form
    {
        CarAndRepairDBModel db = new CarAndRepairDBModel();
        
        public frmCompany()
        {
            InitializeComponent();
            LoadInfoCarInRent();
            //conn = new SqlConnection("Data Source=DESKTOP-TV8GA2P\\MSSQLSERVER;Initial Catalog = CarAndRepairDataBe;Integrated Security = True; Connect Timeout = 30;");
        }
        private void LoadInfoCarNotInRent()
        {
            //int CountRow = 0;
            //dgvNotInRent.RowCount = 0;
            //var notrentacar = from car in db.Car
            //               join rent in db.RentACar on car.IDcar equals rent.IDcar
            //               select new
            //               {
            //                   IDcar = car.IDcar,
            //                   NameCar = car.Brand + " " + car.Class,
            //               };
            //var carxD = from car1 in db.Car
            //            select car1;
            //carxD.ToList()

            //var result = carxD.ToList().Except(notrentacar).ToList();



            //foreach (var f in result)
            //{
            //    dgvRentACar.RowCount++;
            //    dgvRentACar.Rows[CountRow].Cells[0].Value = f.IDcar.ToString();
            //    dgvRentACar.Rows[CountRow].Cells[1].Value = f.NameCar.ToString();
            //    dgvRentACar.Rows[CountRow].Cells[2].Value = f.IDclient.ToString();
            //    dgvRentACar.Rows[CountRow].Cells[3].Value = f.FamilyName.ToString();
            //    dgvRentACar.Rows[CountRow].Cells[4].Value = f.NameClient.ToString();
            //    dgvRentACar.Rows[CountRow].Cells[5].Value = f.Patronymic.ToString();
            //    dgvRentACar.Rows[CountRow].Cells[6].Value = f.RentStartTime.ToString();
            //    CountRow++;
            //}
        }

        private void LoadInfoWorkingPersonnel()
        {
            int CountRow = 0;
            dgvWorkingPersonnel.RowCount = 0;
            var result = from workingpersonnel in db.WorkingPersonnel
                         select workingpersonnel;
            foreach (var f in result)
            {
                dgvWorkingPersonnel.RowCount++;
                dgvWorkingPersonnel.Rows[CountRow].Cells[0].Value = f.IDworker.ToString();
                dgvWorkingPersonnel.Rows[CountRow].Cells[1].Value = f.FamilyName.ToString();
                dgvWorkingPersonnel.Rows[CountRow].Cells[2].Value = f.Name.ToString();
                dgvWorkingPersonnel.Rows[CountRow].Cells[3].Value = f.Patronymic.ToString();
                dgvWorkingPersonnel.Rows[CountRow].Cells[4].Value = f.Specialization.ToString();
                CountRow++;
            }
        }

        private void LoadInfoClients()
        {
            int CountRow = 0;
            dgvInfoClients.RowCount = 0;
            var result = from client in db.Client
                         select client;
            foreach (var f in result)
            {
                dgvInfoClients.RowCount++;
                dgvInfoClients.Rows[CountRow].Cells[0].Value = f.IDclient.ToString();
                dgvInfoClients.Rows[CountRow].Cells[1].Value = f.FamilyName.ToString();
                dgvInfoClients.Rows[CountRow].Cells[2].Value = f.Name.ToString();
                dgvInfoClients.Rows[CountRow].Cells[3].Value = f.Patronymic.ToString();
                dgvInfoClients.Rows[CountRow].Cells[4].Value = f.PassportData.ToString();
                dgvInfoClients.Rows[CountRow].Cells[5].Value = f.DriversLicense.ToString();
                dgvInfoClients.Rows[CountRow].Cells[6].Value = f.NumberOfPhone.ToString();
                CountRow++;
            }
        }
        private void LoadInfoCarInRepair() 
        {
            int CountRow = 0;
            dgvCarInRepair.RowCount = 0;
            var result = from car in db.Car
                         join repair in db.Repair on car.IDcar equals repair.IDcar
                         join cont in db.Contract on repair.IDcar equals cont.IDcar
                         join client in db.Client on cont.IDclient equals client.IDclient
                         join workpersonnel in db.WorkingPersonnel on repair.IDworker equals workpersonnel.IDworker
                         select new
                         {
                             car.IDcar,
                             NameCar = car.Brand + " " + car.Class,
                             FIOclient = client.FamilyName + " " + client.Name + " " + client.Patronymic,
                             workpersonnel.IDworker,
                             FIOWorker = workpersonnel.FamilyName + " " + workpersonnel.Name + " " + workpersonnel.Patronymic
                         };


            foreach (var f in result)
            {
                dgvCarInRepair.RowCount++;
                dgvCarInRepair.Rows[CountRow].Cells[0].Value = f.IDcar.ToString();
                dgvCarInRepair.Rows[CountRow].Cells[1].Value = f.NameCar.ToString();
                dgvCarInRepair.Rows[CountRow].Cells[2].Value = f.FIOclient.ToString();
                dgvCarInRepair.Rows[CountRow].Cells[3].Value = f.IDworker.ToString();
                dgvCarInRepair.Rows[CountRow].Cells[4].Value = f.FIOWorker.ToString();
                CountRow++;
            }

        }
        private void LoadInfoCarInRent()
        {
            int CountRow = 0;
            dgvRentACar.RowCount = 0;
            var result = from car in db.Car
                         join rent in db.RentACar on car.IDcar equals rent.IDcar
                         join cl in db.Client on rent.IDclient equals cl.IDclient
                         select new
                         {
                             car.IDcar,
                             NameCar = car.Brand + " " + car.Class,
                             cl.IDclient,
                             cl.FamilyName,
                             NameClient = cl.Name,
                             cl.Patronymic,
                             RentStartTime = rent.DateOfIssue
                         };
            

            foreach (var f in result)
            {
                dgvRentACar.RowCount++;
                dgvRentACar.Rows[CountRow].Cells[0].Value = f.IDcar.ToString();
                dgvRentACar.Rows[CountRow].Cells[1].Value = f.NameCar.ToString();
                dgvRentACar.Rows[CountRow].Cells[2].Value = f.IDclient.ToString();
                dgvRentACar.Rows[CountRow].Cells[3].Value = f.FamilyName.ToString();
                dgvRentACar.Rows[CountRow].Cells[4].Value = f.NameClient.ToString();
                dgvRentACar.Rows[CountRow].Cells[5].Value = f.Patronymic.ToString();
                dgvRentACar.Rows[CountRow].Cells[6].Value = f.RentStartTime.ToString();
                CountRow++;
            }
        }
        private void btnUpdateData_Click(object sender, EventArgs e)
        {
            LoadInfoCarInRent();
        }

        private void tpInfoWorkingPersonnel_Enter(object sender, EventArgs e)
        {
            LoadInfoWorkingPersonnel();
        }

        private void tpCarInRepair_Enter(object sender, EventArgs e)
        {
            LoadInfoCarInRepair();
        }

        private void tpCarInRent_Enter(object sender, EventArgs e)
        {
            LoadInfoCarInRent();
        }

        private void tbClients_Enter(object sender, EventArgs e)
        {
            LoadInfoClients();
        }       

        private void tbPageInfoClients_Enter(object sender, EventArgs e)
        {
            LoadInfoClients();
        }

        private void btnUpdateDataCarInRepair_Click(object sender, EventArgs e)
        {
            LoadInfoCarInRepair();
        }

        private void btnUpdateDataInfoWorkingPersonnel_Click(object sender, EventArgs e)
        {
            LoadInfoWorkingPersonnel();
        }

        private void btnBlockClient_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateDataInfoClients_Click(object sender, EventArgs e)
        {
            LoadInfoClients();
        }

        private void btnUpdateDataCarNotInRent_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteWorker_Click(object sender, EventArgs e)
        {
            if (dgvWorkingPersonnel.CurrentRow != null)
            {
                //var result = from client in db.Client
                //             select client
                long id = Convert.ToInt64(dgvWorkingPersonnel.CurrentRow.Cells[0].Value);
                WorkingPersonnel workingPersonnel = db.WorkingPersonnel.Where(o => o.IDworker == id).FirstOrDefault();

                db.WorkingPersonnel.Remove(workingPersonnel);
                db.SaveChanges();

            }
        }

        private void btnAddWorker_Click(object sender, EventArgs e)
        {
            WorkingPersonnel working = new WorkingPersonnel
            {
                IDworker = 2,
                FamilyName = "Ванов",
                Name = "Вася",
                Patronymic = "ХАХАХА",
                Specialization = "Roflanebalo"
            };

            db.WorkingPersonnel.Add(working);
            db.SaveChanges();
        }
    }
}
