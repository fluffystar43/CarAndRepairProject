namespace Прокат_и_ремонт_автомобилей
{
    partial class frmRentACar
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
            this.lblTakeCar = new System.Windows.Forms.Label();
            this.lblTypeRate = new System.Windows.Forms.Label();
            this.lblСost = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnAcceptRent = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dtpRent = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblTakeCar
            // 
            this.lblTakeCar.AutoSize = true;
            this.lblTakeCar.Location = new System.Drawing.Point(38, 9);
            this.lblTakeCar.Name = "lblTakeCar";
            this.lblTakeCar.Size = new System.Drawing.Size(124, 13);
            this.lblTakeCar.TabIndex = 0;
            this.lblTakeCar.Text = "Выберите автомобиль:";
            // 
            // lblTypeRate
            // 
            this.lblTypeRate.AutoSize = true;
            this.lblTypeRate.Location = new System.Drawing.Point(119, 36);
            this.lblTypeRate.Name = "lblTypeRate";
            this.lblTypeRate.Size = new System.Drawing.Size(43, 13);
            this.lblTypeRate.TabIndex = 1;
            this.lblTypeRate.Text = "Тариф:";
            // 
            // lblСost
            // 
            this.lblСost.AutoSize = true;
            this.lblСost.Location = new System.Drawing.Point(97, 63);
            this.lblСost.Name = "lblСost";
            this.lblСost.Size = new System.Drawing.Size(65, 13);
            this.lblСost.TabIndex = 2;
            this.lblСost.Text = "Стоимость:";
            this.lblСost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(165, 92);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(140, 13);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "Выберите период аренды:\r\n";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // btnAcceptRent
            // 
            this.btnAcceptRent.Location = new System.Drawing.Point(168, 185);
            this.btnAcceptRent.Name = "btnAcceptRent";
            this.btnAcceptRent.Size = new System.Drawing.Size(75, 23);
            this.btnAcceptRent.TabIndex = 4;
            this.btnAcceptRent.Text = "Арендовать";
            this.btnAcceptRent.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(249, 185);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(168, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(155, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(168, 33);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(155, 21);
            this.comboBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(168, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 20);
            this.textBox1.TabIndex = 8;
            // 
            // dtpRent
            // 
            this.dtpRent.Location = new System.Drawing.Point(167, 108);
            this.dtpRent.Name = "dtpRent";
            this.dtpRent.Size = new System.Drawing.Size(156, 20);
            this.dtpRent.TabIndex = 9;
            // 
            // frmRentACar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(373, 220);
            this.Controls.Add(this.dtpRent);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAcceptRent);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblСost);
            this.Controls.Add(this.lblTypeRate);
            this.Controls.Add(this.lblTakeCar);
            this.MaximizeBox = false;
            this.Name = "frmRentACar";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Арена машины";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTakeCar;
        private System.Windows.Forms.Label lblTypeRate;
        private System.Windows.Forms.Label lblСost;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnAcceptRent;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dtpRent;
    }
}