namespace Прокат_и_ремонт_автомобилей
{
    partial class frmCompany
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tpInfoWorkingPersonnel = new System.Windows.Forms.TabPage();
            this.btnDeleteWorker = new System.Windows.Forms.Button();
            this.btnUpdateWorker = new System.Windows.Forms.Button();
            this.btnAddWorker = new System.Windows.Forms.Button();
            this.btnUpdateDataInfoWorkingPersonnel = new System.Windows.Forms.Button();
            this.dgvWorkingPersonnel = new System.Windows.Forms.DataGridView();
            this.IDworker_InfoWorkers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FamilyName_InfoWorkers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_InfoWorkers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Patronymic_InfoWorkers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Specialization_InfoWorkers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpAddCar = new System.Windows.Forms.TabPage();
            this.tbPageInfoClients = new System.Windows.Forms.TabPage();
            this.tbClients = new System.Windows.Forms.TabControl();
            this.tpListClients = new System.Windows.Forms.TabPage();
            this.btnUpdateDataInfoClients = new System.Windows.Forms.Button();
            this.dgvInfoClients = new System.Windows.Forms.DataGridView();
            this.IDclient_InfoClients = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FamilyName_InfoClients = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_InfoClients = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Patronymic_InfoClients = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PassportData_InfoClients = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DriversLicence_InfoClients = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOfPhone_InfoClients = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBlockClient = new System.Windows.Forms.Button();
            this.tpCarsInfo = new System.Windows.Forms.TabPage();
            this.tbcInfoCarsHelp = new System.Windows.Forms.TabControl();
            this.tpCarInRent = new System.Windows.Forms.TabPage();
            this.btnUpdateDataCarInRent = new System.Windows.Forms.Button();
            this.dgvRentACar = new System.Windows.Forms.DataGridView();
            this.IDcar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameCar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDclient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FamilyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Patronymic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpCarInRepair = new System.Windows.Forms.TabPage();
            this.btnUpdateDataCarInRepair = new System.Windows.Forms.Button();
            this.dgvCarInRepair = new System.Windows.Forms.DataGridView();
            this.IDcar_CarInRepair = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameCar_CarInReapir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDworker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FIOworker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpCarsNotInRent = new System.Windows.Forms.TabPage();
            this.btnUpdateDataCarNotInRent = new System.Windows.Forms.Button();
            this.dgvNotInRent = new System.Windows.Forms.DataGridView();
            this.IDcar_notinrent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameCar_carnotinrent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcInfoCars = new System.Windows.Forms.TabControl();
            this.tpInfoWorkingPersonnel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkingPersonnel)).BeginInit();
            this.tbPageInfoClients.SuspendLayout();
            this.tbClients.SuspendLayout();
            this.tpListClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoClients)).BeginInit();
            this.tpCarsInfo.SuspendLayout();
            this.tbcInfoCarsHelp.SuspendLayout();
            this.tpCarInRent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentACar)).BeginInit();
            this.tpCarInRepair.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarInRepair)).BeginInit();
            this.tpCarsNotInRent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotInRent)).BeginInit();
            this.tbcInfoCars.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpInfoWorkingPersonnel
            // 
            this.tpInfoWorkingPersonnel.Controls.Add(this.btnDeleteWorker);
            this.tpInfoWorkingPersonnel.Controls.Add(this.btnUpdateWorker);
            this.tpInfoWorkingPersonnel.Controls.Add(this.btnAddWorker);
            this.tpInfoWorkingPersonnel.Controls.Add(this.btnUpdateDataInfoWorkingPersonnel);
            this.tpInfoWorkingPersonnel.Controls.Add(this.dgvWorkingPersonnel);
            this.tpInfoWorkingPersonnel.Location = new System.Drawing.Point(4, 22);
            this.tpInfoWorkingPersonnel.Name = "tpInfoWorkingPersonnel";
            this.tpInfoWorkingPersonnel.Padding = new System.Windows.Forms.Padding(3);
            this.tpInfoWorkingPersonnel.Size = new System.Drawing.Size(827, 434);
            this.tpInfoWorkingPersonnel.TabIndex = 3;
            this.tpInfoWorkingPersonnel.Text = "Информация об сотрудниках";
            this.tpInfoWorkingPersonnel.UseVisualStyleBackColor = true;
            this.tpInfoWorkingPersonnel.Enter += new System.EventHandler(this.tpInfoWorkingPersonnel_Enter);
            // 
            // btnDeleteWorker
            // 
            this.btnDeleteWorker.Location = new System.Drawing.Point(539, 392);
            this.btnDeleteWorker.Name = "btnDeleteWorker";
            this.btnDeleteWorker.Size = new System.Drawing.Size(125, 23);
            this.btnDeleteWorker.TabIndex = 6;
            this.btnDeleteWorker.Text = "Удалить сотрудника";
            this.btnDeleteWorker.UseVisualStyleBackColor = true;
            this.btnDeleteWorker.Click += new System.EventHandler(this.btnDeleteWorker_Click);
            // 
            // btnUpdateWorker
            // 
            this.btnUpdateWorker.Location = new System.Drawing.Point(358, 392);
            this.btnUpdateWorker.Name = "btnUpdateWorker";
            this.btnUpdateWorker.Size = new System.Drawing.Size(175, 23);
            this.btnUpdateWorker.TabIndex = 5;
            this.btnUpdateWorker.Text = "Изменить данные сотрудника";
            this.btnUpdateWorker.UseVisualStyleBackColor = true;
            // 
            // btnAddWorker
            // 
            this.btnAddWorker.Location = new System.Drawing.Point(217, 392);
            this.btnAddWorker.Name = "btnAddWorker";
            this.btnAddWorker.Size = new System.Drawing.Size(135, 23);
            this.btnAddWorker.TabIndex = 4;
            this.btnAddWorker.Text = "Добавить сотрудника";
            this.btnAddWorker.UseVisualStyleBackColor = true;
            this.btnAddWorker.Click += new System.EventHandler(this.btnAddWorker_Click);
            // 
            // btnUpdateDataInfoWorkingPersonnel
            // 
            this.btnUpdateDataInfoWorkingPersonnel.Location = new System.Drawing.Point(3, 392);
            this.btnUpdateDataInfoWorkingPersonnel.Name = "btnUpdateDataInfoWorkingPersonnel";
            this.btnUpdateDataInfoWorkingPersonnel.Size = new System.Drawing.Size(164, 23);
            this.btnUpdateDataInfoWorkingPersonnel.TabIndex = 3;
            this.btnUpdateDataInfoWorkingPersonnel.Text = "Обновить данные в таблице";
            this.btnUpdateDataInfoWorkingPersonnel.UseVisualStyleBackColor = true;
            this.btnUpdateDataInfoWorkingPersonnel.Click += new System.EventHandler(this.btnUpdateDataInfoWorkingPersonnel_Click);
            // 
            // dgvWorkingPersonnel
            // 
            this.dgvWorkingPersonnel.AllowUserToAddRows = false;
            this.dgvWorkingPersonnel.AllowUserToDeleteRows = false;
            this.dgvWorkingPersonnel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvWorkingPersonnel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorkingPersonnel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDworker_InfoWorkers,
            this.FamilyName_InfoWorkers,
            this.Name_InfoWorkers,
            this.Patronymic_InfoWorkers,
            this.Specialization_InfoWorkers});
            this.dgvWorkingPersonnel.Location = new System.Drawing.Point(3, 6);
            this.dgvWorkingPersonnel.Name = "dgvWorkingPersonnel";
            this.dgvWorkingPersonnel.ReadOnly = true;
            this.dgvWorkingPersonnel.Size = new System.Drawing.Size(809, 380);
            this.dgvWorkingPersonnel.TabIndex = 0;
            // 
            // IDworker_InfoWorkers
            // 
            this.IDworker_InfoWorkers.HeaderText = "Код работника";
            this.IDworker_InfoWorkers.Name = "IDworker_InfoWorkers";
            this.IDworker_InfoWorkers.ReadOnly = true;
            // 
            // FamilyName_InfoWorkers
            // 
            this.FamilyName_InfoWorkers.HeaderText = "Фамилия";
            this.FamilyName_InfoWorkers.Name = "FamilyName_InfoWorkers";
            this.FamilyName_InfoWorkers.ReadOnly = true;
            // 
            // Name_InfoWorkers
            // 
            this.Name_InfoWorkers.HeaderText = "Имя";
            this.Name_InfoWorkers.Name = "Name_InfoWorkers";
            this.Name_InfoWorkers.ReadOnly = true;
            // 
            // Patronymic_InfoWorkers
            // 
            this.Patronymic_InfoWorkers.HeaderText = "Отчество";
            this.Patronymic_InfoWorkers.Name = "Patronymic_InfoWorkers";
            this.Patronymic_InfoWorkers.ReadOnly = true;
            // 
            // Specialization_InfoWorkers
            // 
            this.Specialization_InfoWorkers.HeaderText = "Специализация";
            this.Specialization_InfoWorkers.Name = "Specialization_InfoWorkers";
            this.Specialization_InfoWorkers.ReadOnly = true;
            // 
            // tpAddCar
            // 
            this.tpAddCar.Location = new System.Drawing.Point(4, 22);
            this.tpAddCar.Name = "tpAddCar";
            this.tpAddCar.Padding = new System.Windows.Forms.Padding(3);
            this.tpAddCar.Size = new System.Drawing.Size(827, 434);
            this.tpAddCar.TabIndex = 2;
            this.tpAddCar.Text = "Добавить автомобиль";
            this.tpAddCar.UseVisualStyleBackColor = true;
            // 
            // tbPageInfoClients
            // 
            this.tbPageInfoClients.Controls.Add(this.tbClients);
            this.tbPageInfoClients.Location = new System.Drawing.Point(4, 22);
            this.tbPageInfoClients.Name = "tbPageInfoClients";
            this.tbPageInfoClients.Padding = new System.Windows.Forms.Padding(3);
            this.tbPageInfoClients.Size = new System.Drawing.Size(827, 434);
            this.tbPageInfoClients.TabIndex = 1;
            this.tbPageInfoClients.Text = "Информация о клиентах";
            this.tbPageInfoClients.UseVisualStyleBackColor = true;
            this.tbPageInfoClients.Enter += new System.EventHandler(this.tbPageInfoClients_Enter);
            // 
            // tbClients
            // 
            this.tbClients.Controls.Add(this.tpListClients);
            this.tbClients.Location = new System.Drawing.Point(0, 0);
            this.tbClients.Name = "tbClients";
            this.tbClients.SelectedIndex = 0;
            this.tbClients.Size = new System.Drawing.Size(820, 425);
            this.tbClients.TabIndex = 0;
            this.tbClients.Enter += new System.EventHandler(this.tbClients_Enter);
            // 
            // tpListClients
            // 
            this.tpListClients.Controls.Add(this.btnUpdateDataInfoClients);
            this.tpListClients.Controls.Add(this.dgvInfoClients);
            this.tpListClients.Controls.Add(this.btnBlockClient);
            this.tpListClients.Location = new System.Drawing.Point(4, 22);
            this.tpListClients.Name = "tpListClients";
            this.tpListClients.Padding = new System.Windows.Forms.Padding(3);
            this.tpListClients.Size = new System.Drawing.Size(812, 399);
            this.tpListClients.TabIndex = 0;
            this.tpListClients.Text = "Список клиентов";
            this.tpListClients.UseVisualStyleBackColor = true;
            // 
            // btnUpdateDataInfoClients
            // 
            this.btnUpdateDataInfoClients.Location = new System.Drawing.Point(6, 368);
            this.btnUpdateDataInfoClients.Name = "btnUpdateDataInfoClients";
            this.btnUpdateDataInfoClients.Size = new System.Drawing.Size(169, 25);
            this.btnUpdateDataInfoClients.TabIndex = 4;
            this.btnUpdateDataInfoClients.Text = "Обновить данные в таблице";
            this.btnUpdateDataInfoClients.UseVisualStyleBackColor = true;
            this.btnUpdateDataInfoClients.Click += new System.EventHandler(this.btnUpdateDataInfoClients_Click);
            // 
            // dgvInfoClients
            // 
            this.dgvInfoClients.AllowUserToAddRows = false;
            this.dgvInfoClients.AllowUserToDeleteRows = false;
            this.dgvInfoClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInfoClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfoClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDclient_InfoClients,
            this.FamilyName_InfoClients,
            this.Name_InfoClients,
            this.Patronymic_InfoClients,
            this.PassportData_InfoClients,
            this.DriversLicence_InfoClients,
            this.NumberOfPhone_InfoClients});
            this.dgvInfoClients.Location = new System.Drawing.Point(6, 6);
            this.dgvInfoClients.Name = "dgvInfoClients";
            this.dgvInfoClients.ReadOnly = true;
            this.dgvInfoClients.Size = new System.Drawing.Size(798, 358);
            this.dgvInfoClients.TabIndex = 1;
            // 
            // IDclient_InfoClients
            // 
            this.IDclient_InfoClients.HeaderText = "Код клиента";
            this.IDclient_InfoClients.Name = "IDclient_InfoClients";
            this.IDclient_InfoClients.ReadOnly = true;
            // 
            // FamilyName_InfoClients
            // 
            this.FamilyName_InfoClients.HeaderText = "Фамилия";
            this.FamilyName_InfoClients.Name = "FamilyName_InfoClients";
            this.FamilyName_InfoClients.ReadOnly = true;
            // 
            // Name_InfoClients
            // 
            this.Name_InfoClients.HeaderText = "Имя";
            this.Name_InfoClients.Name = "Name_InfoClients";
            this.Name_InfoClients.ReadOnly = true;
            // 
            // Patronymic_InfoClients
            // 
            this.Patronymic_InfoClients.HeaderText = "Отчество";
            this.Patronymic_InfoClients.Name = "Patronymic_InfoClients";
            this.Patronymic_InfoClients.ReadOnly = true;
            // 
            // PassportData_InfoClients
            // 
            this.PassportData_InfoClients.HeaderText = "Паспортные данные";
            this.PassportData_InfoClients.Name = "PassportData_InfoClients";
            this.PassportData_InfoClients.ReadOnly = true;
            // 
            // DriversLicence_InfoClients
            // 
            this.DriversLicence_InfoClients.HeaderText = "Водительское удостоверение";
            this.DriversLicence_InfoClients.Name = "DriversLicence_InfoClients";
            this.DriversLicence_InfoClients.ReadOnly = true;
            // 
            // NumberOfPhone_InfoClients
            // 
            this.NumberOfPhone_InfoClients.HeaderText = "Номер телефона";
            this.NumberOfPhone_InfoClients.Name = "NumberOfPhone_InfoClients";
            this.NumberOfPhone_InfoClients.ReadOnly = true;
            // 
            // btnBlockClient
            // 
            this.btnBlockClient.Location = new System.Drawing.Point(248, 368);
            this.btnBlockClient.Name = "btnBlockClient";
            this.btnBlockClient.Size = new System.Drawing.Size(169, 25);
            this.btnBlockClient.TabIndex = 0;
            this.btnBlockClient.Text = "Заблокировать клиента";
            this.btnBlockClient.UseVisualStyleBackColor = true;
            this.btnBlockClient.Click += new System.EventHandler(this.btnBlockClient_Click);
            // 
            // tpCarsInfo
            // 
            this.tpCarsInfo.Controls.Add(this.tbcInfoCarsHelp);
            this.tpCarsInfo.Location = new System.Drawing.Point(4, 22);
            this.tpCarsInfo.Name = "tpCarsInfo";
            this.tpCarsInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpCarsInfo.Size = new System.Drawing.Size(827, 434);
            this.tpCarsInfo.TabIndex = 0;
            this.tpCarsInfo.Text = "Информация о машинах";
            this.tpCarsInfo.UseVisualStyleBackColor = true;
            // 
            // tbcInfoCarsHelp
            // 
            this.tbcInfoCarsHelp.Controls.Add(this.tpCarInRent);
            this.tbcInfoCarsHelp.Controls.Add(this.tpCarInRepair);
            this.tbcInfoCarsHelp.Controls.Add(this.tpCarsNotInRent);
            this.tbcInfoCarsHelp.Location = new System.Drawing.Point(0, 0);
            this.tbcInfoCarsHelp.Name = "tbcInfoCarsHelp";
            this.tbcInfoCarsHelp.SelectedIndex = 0;
            this.tbcInfoCarsHelp.Size = new System.Drawing.Size(822, 427);
            this.tbcInfoCarsHelp.TabIndex = 0;
            // 
            // tpCarInRent
            // 
            this.tpCarInRent.Controls.Add(this.btnUpdateDataCarInRent);
            this.tpCarInRent.Controls.Add(this.dgvRentACar);
            this.tpCarInRent.Location = new System.Drawing.Point(4, 22);
            this.tpCarInRent.Name = "tpCarInRent";
            this.tpCarInRent.Padding = new System.Windows.Forms.Padding(3);
            this.tpCarInRent.Size = new System.Drawing.Size(814, 401);
            this.tpCarInRent.TabIndex = 0;
            this.tpCarInRent.Text = "Машины в прокате";
            this.tpCarInRent.UseVisualStyleBackColor = true;
            this.tpCarInRent.Enter += new System.EventHandler(this.tpCarInRent_Enter);
            // 
            // btnUpdateDataCarInRent
            // 
            this.btnUpdateDataCarInRent.Location = new System.Drawing.Point(6, 372);
            this.btnUpdateDataCarInRent.Name = "btnUpdateDataCarInRent";
            this.btnUpdateDataCarInRent.Size = new System.Drawing.Size(169, 25);
            this.btnUpdateDataCarInRent.TabIndex = 1;
            this.btnUpdateDataCarInRent.Text = "Обновить данные в таблице";
            this.btnUpdateDataCarInRent.UseVisualStyleBackColor = true;
            this.btnUpdateDataCarInRent.Click += new System.EventHandler(this.btnUpdateData_Click);
            // 
            // dgvRentACar
            // 
            this.dgvRentACar.AllowUserToAddRows = false;
            this.dgvRentACar.AllowUserToDeleteRows = false;
            this.dgvRentACar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRentACar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRentACar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDcar,
            this.NameCar,
            this.IDclient,
            this.FamilyName,
            this.NameClient,
            this.Patronymic,
            this.Time});
            this.dgvRentACar.Location = new System.Drawing.Point(6, 6);
            this.dgvRentACar.Name = "dgvRentACar";
            this.dgvRentACar.ReadOnly = true;
            this.dgvRentACar.Size = new System.Drawing.Size(802, 361);
            this.dgvRentACar.TabIndex = 0;
            // 
            // IDcar
            // 
            this.IDcar.HeaderText = "ID Машины";
            this.IDcar.Name = "IDcar";
            this.IDcar.ReadOnly = true;
            // 
            // NameCar
            // 
            this.NameCar.HeaderText = "Название машины";
            this.NameCar.Name = "NameCar";
            this.NameCar.ReadOnly = true;
            // 
            // IDclient
            // 
            this.IDclient.HeaderText = "ID Клиента";
            this.IDclient.Name = "IDclient";
            this.IDclient.ReadOnly = true;
            // 
            // FamilyName
            // 
            this.FamilyName.HeaderText = "Фамилия";
            this.FamilyName.Name = "FamilyName";
            this.FamilyName.ReadOnly = true;
            // 
            // NameClient
            // 
            this.NameClient.HeaderText = "Имя";
            this.NameClient.Name = "NameClient";
            this.NameClient.ReadOnly = true;
            // 
            // Patronymic
            // 
            this.Patronymic.HeaderText = "Отчество";
            this.Patronymic.Name = "Patronymic";
            this.Patronymic.ReadOnly = true;
            // 
            // Time
            // 
            this.Time.HeaderText = "Начальное время аренды";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            // 
            // tpCarInRepair
            // 
            this.tpCarInRepair.Controls.Add(this.btnUpdateDataCarInRepair);
            this.tpCarInRepair.Controls.Add(this.dgvCarInRepair);
            this.tpCarInRepair.Location = new System.Drawing.Point(4, 22);
            this.tpCarInRepair.Name = "tpCarInRepair";
            this.tpCarInRepair.Padding = new System.Windows.Forms.Padding(3);
            this.tpCarInRepair.Size = new System.Drawing.Size(814, 401);
            this.tpCarInRepair.TabIndex = 1;
            this.tpCarInRepair.Text = "Машины в ремонте";
            this.tpCarInRepair.UseVisualStyleBackColor = true;
            this.tpCarInRepair.Enter += new System.EventHandler(this.tpCarInRepair_Enter);
            // 
            // btnUpdateDataCarInRepair
            // 
            this.btnUpdateDataCarInRepair.Location = new System.Drawing.Point(6, 370);
            this.btnUpdateDataCarInRepair.Name = "btnUpdateDataCarInRepair";
            this.btnUpdateDataCarInRepair.Size = new System.Drawing.Size(169, 25);
            this.btnUpdateDataCarInRepair.TabIndex = 2;
            this.btnUpdateDataCarInRepair.Text = "Обновить данные в таблице";
            this.btnUpdateDataCarInRepair.UseVisualStyleBackColor = true;
            this.btnUpdateDataCarInRepair.Click += new System.EventHandler(this.btnUpdateDataCarInRepair_Click);
            // 
            // dgvCarInRepair
            // 
            this.dgvCarInRepair.AllowUserToAddRows = false;
            this.dgvCarInRepair.AllowUserToDeleteRows = false;
            this.dgvCarInRepair.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCarInRepair.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCarInRepair.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarInRepair.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDcar_CarInRepair,
            this.NameCar_CarInReapir,
            this.FIO,
            this.IDworker,
            this.FIOworker});
            this.dgvCarInRepair.Location = new System.Drawing.Point(6, 6);
            this.dgvCarInRepair.Name = "dgvCarInRepair";
            this.dgvCarInRepair.ReadOnly = true;
            this.dgvCarInRepair.Size = new System.Drawing.Size(802, 361);
            this.dgvCarInRepair.TabIndex = 0;
            // 
            // IDcar_CarInRepair
            // 
            this.IDcar_CarInRepair.HeaderText = "Код автомобиля";
            this.IDcar_CarInRepair.Name = "IDcar_CarInRepair";
            this.IDcar_CarInRepair.ReadOnly = true;
            // 
            // NameCar_CarInReapir
            // 
            this.NameCar_CarInReapir.HeaderText = "Название автомобиля";
            this.NameCar_CarInReapir.Name = "NameCar_CarInReapir";
            this.NameCar_CarInReapir.ReadOnly = true;
            // 
            // FIO
            // 
            this.FIO.HeaderText = "Владелец автомобиля";
            this.FIO.Name = "FIO";
            this.FIO.ReadOnly = true;
            // 
            // IDworker
            // 
            this.IDworker.HeaderText = "Код работника";
            this.IDworker.Name = "IDworker";
            this.IDworker.ReadOnly = true;
            // 
            // FIOworker
            // 
            this.FIOworker.HeaderText = "Работник: (ФИО)";
            this.FIOworker.Name = "FIOworker";
            this.FIOworker.ReadOnly = true;
            // 
            // tpCarsNotInRent
            // 
            this.tpCarsNotInRent.Controls.Add(this.btnUpdateDataCarNotInRent);
            this.tpCarsNotInRent.Controls.Add(this.dgvNotInRent);
            this.tpCarsNotInRent.Location = new System.Drawing.Point(4, 22);
            this.tpCarsNotInRent.Name = "tpCarsNotInRent";
            this.tpCarsNotInRent.Padding = new System.Windows.Forms.Padding(3);
            this.tpCarsNotInRent.Size = new System.Drawing.Size(814, 401);
            this.tpCarsNotInRent.TabIndex = 2;
            this.tpCarsNotInRent.Text = "Машины не в прокате";
            this.tpCarsNotInRent.UseVisualStyleBackColor = true;
            // 
            // btnUpdateDataCarNotInRent
            // 
            this.btnUpdateDataCarNotInRent.Location = new System.Drawing.Point(6, 372);
            this.btnUpdateDataCarNotInRent.Name = "btnUpdateDataCarNotInRent";
            this.btnUpdateDataCarNotInRent.Size = new System.Drawing.Size(169, 25);
            this.btnUpdateDataCarNotInRent.TabIndex = 3;
            this.btnUpdateDataCarNotInRent.Text = "Обновить данные в таблице";
            this.btnUpdateDataCarNotInRent.UseVisualStyleBackColor = true;
            this.btnUpdateDataCarNotInRent.Click += new System.EventHandler(this.btnUpdateDataCarNotInRent_Click);
            // 
            // dgvNotInRent
            // 
            this.dgvNotInRent.AllowUserToAddRows = false;
            this.dgvNotInRent.AllowUserToDeleteRows = false;
            this.dgvNotInRent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNotInRent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotInRent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDcar_notinrent,
            this.NameCar_carnotinrent});
            this.dgvNotInRent.Location = new System.Drawing.Point(6, 6);
            this.dgvNotInRent.Name = "dgvNotInRent";
            this.dgvNotInRent.ReadOnly = true;
            this.dgvNotInRent.Size = new System.Drawing.Size(802, 361);
            this.dgvNotInRent.TabIndex = 0;
            // 
            // IDcar_notinrent
            // 
            this.IDcar_notinrent.HeaderText = "Код автомобиля";
            this.IDcar_notinrent.Name = "IDcar_notinrent";
            this.IDcar_notinrent.ReadOnly = true;
            // 
            // NameCar_carnotinrent
            // 
            this.NameCar_carnotinrent.HeaderText = "Название";
            this.NameCar_carnotinrent.Name = "NameCar_carnotinrent";
            this.NameCar_carnotinrent.ReadOnly = true;
            // 
            // tbcInfoCars
            // 
            this.tbcInfoCars.Controls.Add(this.tpCarsInfo);
            this.tbcInfoCars.Controls.Add(this.tbPageInfoClients);
            this.tbcInfoCars.Controls.Add(this.tpAddCar);
            this.tbcInfoCars.Controls.Add(this.tpInfoWorkingPersonnel);
            this.tbcInfoCars.Location = new System.Drawing.Point(0, 0);
            this.tbcInfoCars.Name = "tbcInfoCars";
            this.tbcInfoCars.SelectedIndex = 0;
            this.tbcInfoCars.Size = new System.Drawing.Size(835, 460);
            this.tbcInfoCars.TabIndex = 1;
            // 
            // frmCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(828, 452);
            this.Controls.Add(this.tbcInfoCars);
            this.MaximizeBox = false;
            this.Name = "frmCompany";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вы вошли как администратор";
            this.tpInfoWorkingPersonnel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkingPersonnel)).EndInit();
            this.tbPageInfoClients.ResumeLayout(false);
            this.tbClients.ResumeLayout(false);
            this.tpListClients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoClients)).EndInit();
            this.tpCarsInfo.ResumeLayout(false);
            this.tbcInfoCarsHelp.ResumeLayout(false);
            this.tpCarInRent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentACar)).EndInit();
            this.tpCarInRepair.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarInRepair)).EndInit();
            this.tpCarsNotInRent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotInRent)).EndInit();
            this.tbcInfoCars.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tpInfoWorkingPersonnel;
        private System.Windows.Forms.Button btnDeleteWorker;
        private System.Windows.Forms.Button btnUpdateWorker;
        private System.Windows.Forms.Button btnAddWorker;
        private System.Windows.Forms.Button btnUpdateDataInfoWorkingPersonnel;
        private System.Windows.Forms.DataGridView dgvWorkingPersonnel;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDworker_InfoWorkers;
        private System.Windows.Forms.DataGridViewTextBoxColumn FamilyName_InfoWorkers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_InfoWorkers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Patronymic_InfoWorkers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Specialization_InfoWorkers;
        private System.Windows.Forms.TabPage tpAddCar;
        private System.Windows.Forms.TabPage tbPageInfoClients;
        private System.Windows.Forms.TabControl tbClients;
        private System.Windows.Forms.TabPage tpListClients;
        private System.Windows.Forms.Button btnUpdateDataInfoClients;
        private System.Windows.Forms.DataGridView dgvInfoClients;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDclient_InfoClients;
        private System.Windows.Forms.DataGridViewTextBoxColumn FamilyName_InfoClients;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_InfoClients;
        private System.Windows.Forms.DataGridViewTextBoxColumn Patronymic_InfoClients;
        private System.Windows.Forms.DataGridViewTextBoxColumn PassportData_InfoClients;
        private System.Windows.Forms.DataGridViewTextBoxColumn DriversLicence_InfoClients;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfPhone_InfoClients;
        private System.Windows.Forms.Button btnBlockClient;
        private System.Windows.Forms.TabPage tpCarsInfo;
        private System.Windows.Forms.TabControl tbcInfoCarsHelp;
        private System.Windows.Forms.TabPage tpCarInRent;
        private System.Windows.Forms.Button btnUpdateDataCarInRent;
        private System.Windows.Forms.DataGridView dgvRentACar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDcar;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameCar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDclient;
        private System.Windows.Forms.DataGridViewTextBoxColumn FamilyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn Patronymic;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.TabPage tpCarInRepair;
        private System.Windows.Forms.Button btnUpdateDataCarInRepair;
        private System.Windows.Forms.DataGridView dgvCarInRepair;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDcar_CarInRepair;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameCar_CarInReapir;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDworker;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIOworker;
        private System.Windows.Forms.TabPage tpCarsNotInRent;
        private System.Windows.Forms.Button btnUpdateDataCarNotInRent;
        private System.Windows.Forms.DataGridView dgvNotInRent;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDcar_notinrent;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameCar_carnotinrent;
        private System.Windows.Forms.TabControl tbcInfoCars;
    }
}