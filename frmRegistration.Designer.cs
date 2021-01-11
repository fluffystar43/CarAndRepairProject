namespace Прокат_и_ремонт_автомобилей
{
    partial class frmRegistration
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
            this.lblError = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtNumberOfPhone = new System.Windows.Forms.TextBox();
            this.txtDriverLicense = new System.Windows.Forms.TextBox();
            this.txtSeriesAndNumber = new System.Windows.Forms.TextBox();
            this.txtPatronymic = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtFamilyName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.lblNumberOfPhone = new System.Windows.Forms.Label();
            this.lblDriverLicense = new System.Windows.Forms.Label();
            this.lblPassportData = new System.Windows.Forms.Label();
            this.lblPatronymic = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblFamilyName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblError
            // 
            this.lblError.Location = new System.Drawing.Point(166, 229);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(194, 39);
            this.lblError.TabIndex = 39;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(266, 271);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 23);
            this.btnCancel.TabIndex = 38;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(167, 271);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(93, 23);
            this.btnAccept.TabIndex = 37;
            this.btnAccept.Text = "Подтвердить";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "* - Поля, обязательные для заполнения";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(116, 41);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(49, 13);
            this.lblPassword.TabIndex = 35;
            this.lblPassword.Text = "Пароль*";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(123, 15);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(42, 13);
            this.lblLogin.TabIndex = 34;
            this.lblLogin.Text = "Логин*";
            // 
            // txtNumberOfPhone
            // 
            this.txtNumberOfPhone.Location = new System.Drawing.Point(167, 197);
            this.txtNumberOfPhone.Name = "txtNumberOfPhone";
            this.txtNumberOfPhone.Size = new System.Drawing.Size(193, 20);
            this.txtNumberOfPhone.TabIndex = 33;
            // 
            // txtDriverLicense
            // 
            this.txtDriverLicense.Location = new System.Drawing.Point(167, 171);
            this.txtDriverLicense.Name = "txtDriverLicense";
            this.txtDriverLicense.Size = new System.Drawing.Size(193, 20);
            this.txtDriverLicense.TabIndex = 32;
            // 
            // txtSeriesAndNumber
            // 
            this.txtSeriesAndNumber.Location = new System.Drawing.Point(167, 142);
            this.txtSeriesAndNumber.Name = "txtSeriesAndNumber";
            this.txtSeriesAndNumber.Size = new System.Drawing.Size(193, 20);
            this.txtSeriesAndNumber.TabIndex = 31;
            // 
            // txtPatronymic
            // 
            this.txtPatronymic.Location = new System.Drawing.Point(167, 116);
            this.txtPatronymic.Name = "txtPatronymic";
            this.txtPatronymic.Size = new System.Drawing.Size(193, 20);
            this.txtPatronymic.TabIndex = 30;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(167, 90);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(193, 20);
            this.txtName.TabIndex = 29;
            // 
            // txtFamilyName
            // 
            this.txtFamilyName.Location = new System.Drawing.Point(167, 64);
            this.txtFamilyName.Name = "txtFamilyName";
            this.txtFamilyName.Size = new System.Drawing.Size(193, 20);
            this.txtFamilyName.TabIndex = 28;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(167, 38);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(193, 20);
            this.txtPassword.TabIndex = 27;
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(167, 12);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(193, 20);
            this.txtLogin.TabIndex = 26;
            // 
            // lblNumberOfPhone
            // 
            this.lblNumberOfPhone.AutoSize = true;
            this.lblNumberOfPhone.Location = new System.Drawing.Point(68, 200);
            this.lblNumberOfPhone.Name = "lblNumberOfPhone";
            this.lblNumberOfPhone.Size = new System.Drawing.Size(93, 13);
            this.lblNumberOfPhone.TabIndex = 25;
            this.lblNumberOfPhone.Text = "Номер телефона";
            // 
            // lblDriverLicense
            // 
            this.lblDriverLicense.AutoSize = true;
            this.lblDriverLicense.Location = new System.Drawing.Point(3, 174);
            this.lblDriverLicense.Name = "lblDriverLicense";
            this.lblDriverLicense.Size = new System.Drawing.Size(162, 13);
            this.lblDriverLicense.TabIndex = 24;
            this.lblDriverLicense.Text = "Водительское удостоверение*";
            // 
            // lblPassportData
            // 
            this.lblPassportData.AutoSize = true;
            this.lblPassportData.Location = new System.Drawing.Point(29, 145);
            this.lblPassportData.Name = "lblPassportData";
            this.lblPassportData.Size = new System.Drawing.Size(136, 13);
            this.lblPassportData.TabIndex = 23;
            this.lblPassportData.Text = "Серия и номер паспорта*";
            // 
            // lblPatronymic
            // 
            this.lblPatronymic.AutoSize = true;
            this.lblPatronymic.Location = new System.Drawing.Point(107, 119);
            this.lblPatronymic.Name = "lblPatronymic";
            this.lblPatronymic.Size = new System.Drawing.Size(54, 13);
            this.lblPatronymic.TabIndex = 22;
            this.lblPatronymic.Text = "Отчество";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(132, 93);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(33, 13);
            this.lblName.TabIndex = 21;
            this.lblName.Text = "Имя*";
            // 
            // lblFamilyName
            // 
            this.lblFamilyName.AutoSize = true;
            this.lblFamilyName.Location = new System.Drawing.Point(105, 67);
            this.lblFamilyName.Name = "lblFamilyName";
            this.lblFamilyName.Size = new System.Drawing.Size(60, 13);
            this.lblFamilyName.TabIndex = 20;
            this.lblFamilyName.Text = "Фамилия*";
            // 
            // frmRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(372, 328);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.txtNumberOfPhone);
            this.Controls.Add(this.txtDriverLicense);
            this.Controls.Add(this.txtSeriesAndNumber);
            this.Controls.Add(this.txtPatronymic);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtFamilyName);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.lblNumberOfPhone);
            this.Controls.Add(this.lblDriverLicense);
            this.Controls.Add(this.lblPassportData);
            this.Controls.Add(this.lblPatronymic);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblFamilyName);
            this.MaximizeBox = false;
            this.Name = "frmRegistration";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtNumberOfPhone;
        private System.Windows.Forms.TextBox txtDriverLicense;
        private System.Windows.Forms.TextBox txtSeriesAndNumber;
        private System.Windows.Forms.TextBox txtPatronymic;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtFamilyName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label lblNumberOfPhone;
        private System.Windows.Forms.Label lblDriverLicense;
        private System.Windows.Forms.Label lblPassportData;
        private System.Windows.Forms.Label lblPatronymic;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblFamilyName;
    }
}