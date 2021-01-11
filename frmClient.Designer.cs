namespace Прокат_и_ремонт_автомобилей
{
    partial class frmClient
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
            this.tcClient = new System.Windows.Forms.TabControl();
            this.tpListNotRentCars = new System.Windows.Forms.TabPage();
            this.btnRentACar = new System.Windows.Forms.Button();
            this.dgvCarsNotInRent = new System.Windows.Forms.DataGridView();
            this.NameCar_ListCarNotInRent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Transmission_ListCarNotInRent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mileage_ListCarNotInRent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rate_ListCarNotInRent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost_ListCarNotInRent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpRepairCar = new System.Windows.Forms.TabPage();
            this.cbListCars = new System.Windows.Forms.ComboBox();
            this.lblCar = new System.Windows.Forms.Label();
            this.tcClient.SuspendLayout();
            this.tpListNotRentCars.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarsNotInRent)).BeginInit();
            this.tpRepairCar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcClient
            // 
            this.tcClient.Controls.Add(this.tpListNotRentCars);
            this.tcClient.Controls.Add(this.tpRepairCar);
            this.tcClient.Location = new System.Drawing.Point(0, 0);
            this.tcClient.Name = "tcClient";
            this.tcClient.SelectedIndex = 0;
            this.tcClient.Size = new System.Drawing.Size(745, 477);
            this.tcClient.TabIndex = 1;
            // 
            // tpListNotRentCars
            // 
            this.tpListNotRentCars.Controls.Add(this.btnRentACar);
            this.tpListNotRentCars.Controls.Add(this.dgvCarsNotInRent);
            this.tpListNotRentCars.Location = new System.Drawing.Point(4, 22);
            this.tpListNotRentCars.Name = "tpListNotRentCars";
            this.tpListNotRentCars.Padding = new System.Windows.Forms.Padding(3);
            this.tpListNotRentCars.Size = new System.Drawing.Size(737, 451);
            this.tpListNotRentCars.TabIndex = 0;
            this.tpListNotRentCars.Text = "Список неарендованных машин";
            this.tpListNotRentCars.UseVisualStyleBackColor = true;
            // 
            // btnRentACar
            // 
            this.btnRentACar.Location = new System.Drawing.Point(8, 346);
            this.btnRentACar.Name = "btnRentACar";
            this.btnRentACar.Size = new System.Drawing.Size(153, 23);
            this.btnRentACar.TabIndex = 1;
            this.btnRentACar.Text = "Арендовать машину";
            this.btnRentACar.UseVisualStyleBackColor = true;
            this.btnRentACar.Click += new System.EventHandler(this.btnRentACar_Click);
            // 
            // dgvCarsNotInRent
            // 
            this.dgvCarsNotInRent.AllowUserToAddRows = false;
            this.dgvCarsNotInRent.AllowUserToDeleteRows = false;
            this.dgvCarsNotInRent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCarsNotInRent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarsNotInRent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameCar_ListCarNotInRent,
            this.Transmission_ListCarNotInRent,
            this.Mileage_ListCarNotInRent,
            this.Rate_ListCarNotInRent,
            this.Cost_ListCarNotInRent});
            this.dgvCarsNotInRent.Location = new System.Drawing.Point(0, 0);
            this.dgvCarsNotInRent.Name = "dgvCarsNotInRent";
            this.dgvCarsNotInRent.ReadOnly = true;
            this.dgvCarsNotInRent.Size = new System.Drawing.Size(737, 340);
            this.dgvCarsNotInRent.TabIndex = 0;
            // 
            // NameCar_ListCarNotInRent
            // 
            this.NameCar_ListCarNotInRent.HeaderText = "Название автомобиля";
            this.NameCar_ListCarNotInRent.Name = "NameCar_ListCarNotInRent";
            this.NameCar_ListCarNotInRent.ReadOnly = true;
            // 
            // Transmission_ListCarNotInRent
            // 
            this.Transmission_ListCarNotInRent.HeaderText = "Коробка передач";
            this.Transmission_ListCarNotInRent.Name = "Transmission_ListCarNotInRent";
            this.Transmission_ListCarNotInRent.ReadOnly = true;
            // 
            // Mileage_ListCarNotInRent
            // 
            this.Mileage_ListCarNotInRent.HeaderText = "Пробег";
            this.Mileage_ListCarNotInRent.Name = "Mileage_ListCarNotInRent";
            this.Mileage_ListCarNotInRent.ReadOnly = true;
            // 
            // Rate_ListCarNotInRent
            // 
            this.Rate_ListCarNotInRent.HeaderText = "Тариф";
            this.Rate_ListCarNotInRent.Name = "Rate_ListCarNotInRent";
            this.Rate_ListCarNotInRent.ReadOnly = true;
            // 
            // Cost_ListCarNotInRent
            // 
            this.Cost_ListCarNotInRent.HeaderText = "Стоимость\\сутки";
            this.Cost_ListCarNotInRent.Name = "Cost_ListCarNotInRent";
            this.Cost_ListCarNotInRent.ReadOnly = true;
            // 
            // tpRepairCar
            // 
            this.tpRepairCar.Controls.Add(this.cbListCars);
            this.tpRepairCar.Controls.Add(this.lblCar);
            this.tpRepairCar.Location = new System.Drawing.Point(4, 22);
            this.tpRepairCar.Name = "tpRepairCar";
            this.tpRepairCar.Padding = new System.Windows.Forms.Padding(3);
            this.tpRepairCar.Size = new System.Drawing.Size(737, 451);
            this.tpRepairCar.TabIndex = 1;
            this.tpRepairCar.Text = "Ремонт машины";
            this.tpRepairCar.UseVisualStyleBackColor = true;
            this.tpRepairCar.Enter += new System.EventHandler(this.tpRepairCar_Enter);
            // 
            // cbListCars
            // 
            this.cbListCars.FormattingEnabled = true;
            this.cbListCars.Location = new System.Drawing.Point(138, 25);
            this.cbListCars.Name = "cbListCars";
            this.cbListCars.Size = new System.Drawing.Size(164, 21);
            this.cbListCars.Sorted = true;
            this.cbListCars.TabIndex = 1;
            // 
            // lblCar
            // 
            this.lblCar.AutoSize = true;
            this.lblCar.Location = new System.Drawing.Point(8, 28);
            this.lblCar.Name = "lblCar";
            this.lblCar.Size = new System.Drawing.Size(124, 13);
            this.lblCar.TabIndex = 0;
            this.lblCar.Text = "Выберите автомобиль:";
            // 
            // frmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(744, 476);
            this.Controls.Add(this.tcClient);
            this.MinimizeBox = false;
            this.Name = "frmClient";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вы вошли как клиент";
            this.tcClient.ResumeLayout(false);
            this.tpListNotRentCars.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarsNotInRent)).EndInit();
            this.tpRepairCar.ResumeLayout(false);
            this.tpRepairCar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcClient;
        private System.Windows.Forms.TabPage tpListNotRentCars;
        private System.Windows.Forms.Button btnRentACar;
        private System.Windows.Forms.DataGridView dgvCarsNotInRent;
        private System.Windows.Forms.TabPage tpRepairCar;
        private System.Windows.Forms.ComboBox cbListCars;
        private System.Windows.Forms.Label lblCar;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameCar_ListCarNotInRent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Transmission_ListCarNotInRent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mileage_ListCarNotInRent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rate_ListCarNotInRent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost_ListCarNotInRent;
    }
}