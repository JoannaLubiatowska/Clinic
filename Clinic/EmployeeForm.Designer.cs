namespace Clinic
{
    partial class EmployeeForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label cityIDLabel1;
            System.Windows.Forms.Label phoneNumberLabel1;
            System.Windows.Forms.Label label13;
            System.Windows.Forms.Label userGroupIDLabel;
            System.Windows.Forms.Label firstNameLabel1;
            System.Windows.Forms.Label postalCodeLabel1;
            System.Windows.Forms.Label employeeDescriptionLabel;
            System.Windows.Forms.Label lastNameLabel1;
            System.Windows.Forms.Label streetNumerLabel1;
            System.Windows.Forms.Label userPasswordLabel;
            System.Windows.Forms.Label userLoginLabel;
            System.Windows.Forms.Label streetLabel1;
            System.Windows.Forms.Label medicalSpecializationNameLabel;
            System.Windows.Forms.Label label3;
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.comboBoxEmployeeGroup = new System.Windows.Forms.ComboBox();
            this.comboBoxEmployeeCity = new System.Windows.Forms.ComboBox();
            this.comboBoxEmployeeVoivodeship = new System.Windows.Forms.ComboBox();
            this.textBoxEmployeePasswordConfirm = new System.Windows.Forms.TextBox();
            this.textBoxEmployeeLogin = new System.Windows.Forms.TextBox();
            this.textBoxEmployeePassword = new System.Windows.Forms.TextBox();
            this.textBoxEmployeePhoneNo = new System.Windows.Forms.TextBox();
            this.textBoxEmployeeDescription = new System.Windows.Forms.TextBox();
            this.textBoxEmployeePostalCode = new System.Windows.Forms.TextBox();
            this.textBoxEmployeeStreet = new System.Windows.Forms.TextBox();
            this.textBoxEmployeeStreetNo = new System.Windows.Forms.TextBox();
            this.textBoxEmployeeFirstName = new System.Windows.Forms.TextBox();
            this.textBoxEmployeeLastName = new System.Windows.Forms.TextBox();
            this.textBoxEmployeePicture = new System.Windows.Forms.TextBox();
            this.textBoxEmployeeSpecialization = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxEmployeeNewSpecialization = new System.Windows.Forms.TextBox();
            this.comboBoxEmployeeAddSpecialization = new System.Windows.Forms.ComboBox();
            this.buttonAddEmployee = new System.Windows.Forms.Button();
            this.buttonLoadPicture = new System.Windows.Forms.Button();
            this.dataSet = new Clinic.DataSet();
            this.employee_viewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employee_viewTableAdapter = new Clinic.DataSetTableAdapters.Employee_viewTableAdapter();
            this.tableAdapterManager = new Clinic.DataSetTableAdapters.TableAdapterManager();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            label4 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            cityIDLabel1 = new System.Windows.Forms.Label();
            phoneNumberLabel1 = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            userGroupIDLabel = new System.Windows.Forms.Label();
            firstNameLabel1 = new System.Windows.Forms.Label();
            postalCodeLabel1 = new System.Windows.Forms.Label();
            employeeDescriptionLabel = new System.Windows.Forms.Label();
            lastNameLabel1 = new System.Windows.Forms.Label();
            streetNumerLabel1 = new System.Windows.Forms.Label();
            userPasswordLabel = new System.Windows.Forms.Label();
            userLoginLabel = new System.Windows.Forms.Label();
            streetLabel1 = new System.Windows.Forms.Label();
            medicalSpecializationNameLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_viewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(12, 389);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(70, 13);
            label4.TabIndex = 83;
            label4.Text = "Specjalności:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(381, 9);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(45, 13);
            label2.TabIndex = 82;
            label2.Text = "Zdjęcie:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 139);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(77, 13);
            label1.TabIndex = 81;
            label1.Text = "Województwo:";
            // 
            // cityIDLabel1
            // 
            cityIDLabel1.AutoSize = true;
            cityIDLabel1.Location = new System.Drawing.Point(12, 166);
            cityIDLabel1.Name = "cityIDLabel1";
            cityIDLabel1.Size = new System.Drawing.Size(41, 13);
            cityIDLabel1.TabIndex = 74;
            cityIDLabel1.Text = "Miasto:";
            // 
            // phoneNumberLabel1
            // 
            phoneNumberLabel1.AutoSize = true;
            phoneNumberLabel1.Location = new System.Drawing.Point(12, 192);
            phoneNumberLabel1.Name = "phoneNumberLabel1";
            phoneNumberLabel1.Size = new System.Drawing.Size(82, 13);
            phoneNumberLabel1.TabIndex = 75;
            phoneNumberLabel1.Text = "Numer telefonu:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new System.Drawing.Point(12, 336);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(39, 13);
            label13.TabIndex = 80;
            label13.Text = "Hasło:";
            // 
            // userGroupIDLabel
            // 
            userGroupIDLabel.AutoSize = true;
            userGroupIDLabel.Location = new System.Drawing.Point(12, 362);
            userGroupIDLabel.Name = "userGroupIDLabel";
            userGroupIDLabel.Size = new System.Drawing.Size(39, 13);
            userGroupIDLabel.TabIndex = 79;
            userGroupIDLabel.Text = "Grupa:";
            // 
            // firstNameLabel1
            // 
            firstNameLabel1.AutoSize = true;
            firstNameLabel1.Location = new System.Drawing.Point(12, 9);
            firstNameLabel1.Name = "firstNameLabel1";
            firstNameLabel1.Size = new System.Drawing.Size(29, 13);
            firstNameLabel1.TabIndex = 69;
            firstNameLabel1.Text = "Imię:";
            // 
            // postalCodeLabel1
            // 
            postalCodeLabel1.AutoSize = true;
            postalCodeLabel1.Location = new System.Drawing.Point(12, 113);
            postalCodeLabel1.Name = "postalCodeLabel1";
            postalCodeLabel1.Size = new System.Drawing.Size(77, 13);
            postalCodeLabel1.TabIndex = 73;
            postalCodeLabel1.Text = "Kod pocztowy:";
            // 
            // employeeDescriptionLabel
            // 
            employeeDescriptionLabel.AutoSize = true;
            employeeDescriptionLabel.Location = new System.Drawing.Point(12, 218);
            employeeDescriptionLabel.Name = "employeeDescriptionLabel";
            employeeDescriptionLabel.Size = new System.Drawing.Size(31, 13);
            employeeDescriptionLabel.TabIndex = 76;
            employeeDescriptionLabel.Text = "Opis:";
            // 
            // lastNameLabel1
            // 
            lastNameLabel1.AutoSize = true;
            lastNameLabel1.Location = new System.Drawing.Point(12, 35);
            lastNameLabel1.Name = "lastNameLabel1";
            lastNameLabel1.Size = new System.Drawing.Size(56, 13);
            lastNameLabel1.TabIndex = 70;
            lastNameLabel1.Text = "Nazwisko:";
            // 
            // streetNumerLabel1
            // 
            streetNumerLabel1.AutoSize = true;
            streetNumerLabel1.Location = new System.Drawing.Point(12, 87);
            streetNumerLabel1.Name = "streetNumerLabel1";
            streetNumerLabel1.Size = new System.Drawing.Size(41, 13);
            streetNumerLabel1.TabIndex = 72;
            streetNumerLabel1.Text = "Numer:";
            // 
            // userPasswordLabel
            // 
            userPasswordLabel.AutoSize = true;
            userPasswordLabel.Location = new System.Drawing.Point(12, 310);
            userPasswordLabel.Name = "userPasswordLabel";
            userPasswordLabel.Size = new System.Drawing.Size(39, 13);
            userPasswordLabel.TabIndex = 78;
            userPasswordLabel.Text = "Hasło:";
            // 
            // userLoginLabel
            // 
            userLoginLabel.AutoSize = true;
            userLoginLabel.Location = new System.Drawing.Point(12, 284);
            userLoginLabel.Name = "userLoginLabel";
            userLoginLabel.Size = new System.Drawing.Size(36, 13);
            userLoginLabel.TabIndex = 77;
            userLoginLabel.Text = "Login:";
            // 
            // streetLabel1
            // 
            streetLabel1.AutoSize = true;
            streetLabel1.Location = new System.Drawing.Point(12, 61);
            streetLabel1.Name = "streetLabel1";
            streetLabel1.Size = new System.Drawing.Size(34, 13);
            streetLabel1.TabIndex = 71;
            streetLabel1.Text = "Ulica:";
            // 
            // medicalSpecializationNameLabel
            // 
            medicalSpecializationNameLabel.AutoSize = true;
            medicalSpecializationNameLabel.Location = new System.Drawing.Point(8, 22);
            medicalSpecializationNameLabel.Name = "medicalSpecializationNameLabel";
            medicalSpecializationNameLabel.Size = new System.Drawing.Size(68, 13);
            medicalSpecializationNameLabel.TabIndex = 100;
            medicalSpecializationNameLabel.Text = "Specjalność:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(8, 49);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(97, 13);
            label3.TabIndex = 101;
            label3.Text = "Nowa specjalność:";
            // 
            // comboBoxEmployeeGroup
            // 
            this.comboBoxEmployeeGroup.FormattingEnabled = true;
            this.comboBoxEmployeeGroup.Location = new System.Drawing.Point(115, 359);
            this.comboBoxEmployeeGroup.Name = "comboBoxEmployeeGroup";
            this.comboBoxEmployeeGroup.Size = new System.Drawing.Size(242, 21);
            this.comboBoxEmployeeGroup.TabIndex = 96;
            // 
            // comboBoxEmployeeCity
            // 
            this.comboBoxEmployeeCity.FormattingEnabled = true;
            this.comboBoxEmployeeCity.Location = new System.Drawing.Point(115, 163);
            this.comboBoxEmployeeCity.Name = "comboBoxEmployeeCity";
            this.comboBoxEmployeeCity.Size = new System.Drawing.Size(242, 21);
            this.comboBoxEmployeeCity.TabIndex = 95;
            // 
            // comboBoxEmployeeVoivodeship
            // 
            this.comboBoxEmployeeVoivodeship.FormattingEnabled = true;
            this.comboBoxEmployeeVoivodeship.Location = new System.Drawing.Point(115, 136);
            this.comboBoxEmployeeVoivodeship.Name = "comboBoxEmployeeVoivodeship";
            this.comboBoxEmployeeVoivodeship.Size = new System.Drawing.Size(242, 21);
            this.comboBoxEmployeeVoivodeship.TabIndex = 94;
            // 
            // textBoxEmployeePasswordConfirm
            // 
            this.textBoxEmployeePasswordConfirm.Location = new System.Drawing.Point(115, 333);
            this.textBoxEmployeePasswordConfirm.Name = "textBoxEmployeePasswordConfirm";
            this.textBoxEmployeePasswordConfirm.PasswordChar = '*';
            this.textBoxEmployeePasswordConfirm.Size = new System.Drawing.Size(242, 20);
            this.textBoxEmployeePasswordConfirm.TabIndex = 93;
            // 
            // textBoxEmployeeLogin
            // 
            this.textBoxEmployeeLogin.Location = new System.Drawing.Point(115, 281);
            this.textBoxEmployeeLogin.Name = "textBoxEmployeeLogin";
            this.textBoxEmployeeLogin.Size = new System.Drawing.Size(242, 20);
            this.textBoxEmployeeLogin.TabIndex = 92;
            // 
            // textBoxEmployeePassword
            // 
            this.textBoxEmployeePassword.Location = new System.Drawing.Point(115, 307);
            this.textBoxEmployeePassword.Name = "textBoxEmployeePassword";
            this.textBoxEmployeePassword.PasswordChar = '*';
            this.textBoxEmployeePassword.Size = new System.Drawing.Size(242, 20);
            this.textBoxEmployeePassword.TabIndex = 91;
            // 
            // textBoxEmployeePhoneNo
            // 
            this.textBoxEmployeePhoneNo.Location = new System.Drawing.Point(115, 189);
            this.textBoxEmployeePhoneNo.Name = "textBoxEmployeePhoneNo";
            this.textBoxEmployeePhoneNo.Size = new System.Drawing.Size(242, 20);
            this.textBoxEmployeePhoneNo.TabIndex = 90;
            // 
            // textBoxEmployeeDescription
            // 
            this.textBoxEmployeeDescription.Location = new System.Drawing.Point(115, 215);
            this.textBoxEmployeeDescription.Multiline = true;
            this.textBoxEmployeeDescription.Name = "textBoxEmployeeDescription";
            this.textBoxEmployeeDescription.Size = new System.Drawing.Size(242, 60);
            this.textBoxEmployeeDescription.TabIndex = 89;
            // 
            // textBoxEmployeePostalCode
            // 
            this.textBoxEmployeePostalCode.Location = new System.Drawing.Point(115, 110);
            this.textBoxEmployeePostalCode.Name = "textBoxEmployeePostalCode";
            this.textBoxEmployeePostalCode.Size = new System.Drawing.Size(242, 20);
            this.textBoxEmployeePostalCode.TabIndex = 88;
            // 
            // textBoxEmployeeStreet
            // 
            this.textBoxEmployeeStreet.Location = new System.Drawing.Point(115, 58);
            this.textBoxEmployeeStreet.Name = "textBoxEmployeeStreet";
            this.textBoxEmployeeStreet.Size = new System.Drawing.Size(242, 20);
            this.textBoxEmployeeStreet.TabIndex = 87;
            // 
            // textBoxEmployeeStreetNo
            // 
            this.textBoxEmployeeStreetNo.Location = new System.Drawing.Point(115, 84);
            this.textBoxEmployeeStreetNo.Name = "textBoxEmployeeStreetNo";
            this.textBoxEmployeeStreetNo.Size = new System.Drawing.Size(242, 20);
            this.textBoxEmployeeStreetNo.TabIndex = 86;
            // 
            // textBoxEmployeeFirstName
            // 
            this.textBoxEmployeeFirstName.Location = new System.Drawing.Point(115, 6);
            this.textBoxEmployeeFirstName.Name = "textBoxEmployeeFirstName";
            this.textBoxEmployeeFirstName.Size = new System.Drawing.Size(242, 20);
            this.textBoxEmployeeFirstName.TabIndex = 85;
            // 
            // textBoxEmployeeLastName
            // 
            this.textBoxEmployeeLastName.Location = new System.Drawing.Point(115, 32);
            this.textBoxEmployeeLastName.Name = "textBoxEmployeeLastName";
            this.textBoxEmployeeLastName.Size = new System.Drawing.Size(242, 20);
            this.textBoxEmployeeLastName.TabIndex = 84;
            // 
            // textBoxEmployeePicture
            // 
            this.textBoxEmployeePicture.Location = new System.Drawing.Point(484, 9);
            this.textBoxEmployeePicture.Name = "textBoxEmployeePicture";
            this.textBoxEmployeePicture.Size = new System.Drawing.Size(242, 20);
            this.textBoxEmployeePicture.TabIndex = 97;
            this.textBoxEmployeePicture.Text = "C:\\Users\\Asia\\Desktop\\Doctors\\Jan_Kowalski";
            // 
            // textBoxEmployeeSpecialization
            // 
            this.textBoxEmployeeSpecialization.Location = new System.Drawing.Point(115, 386);
            this.textBoxEmployeeSpecialization.Multiline = true;
            this.textBoxEmployeeSpecialization.Name = "textBoxEmployeeSpecialization";
            this.textBoxEmployeeSpecialization.Size = new System.Drawing.Size(242, 68);
            this.textBoxEmployeeSpecialization.TabIndex = 98;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(medicalSpecializationNameLabel);
            this.groupBox1.Controls.Add(label3);
            this.groupBox1.Controls.Add(this.textBoxEmployeeNewSpecialization);
            this.groupBox1.Controls.Add(this.comboBoxEmployeeAddSpecialization);
            this.groupBox1.Location = new System.Drawing.Point(371, 341);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 84);
            this.groupBox1.TabIndex = 99;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodaj specjalność";
            // 
            // textBoxEmployeeNewSpecialization
            // 
            this.textBoxEmployeeNewSpecialization.Location = new System.Drawing.Point(111, 46);
            this.textBoxEmployeeNewSpecialization.Name = "textBoxEmployeeNewSpecialization";
            this.textBoxEmployeeNewSpecialization.Size = new System.Drawing.Size(242, 20);
            this.textBoxEmployeeNewSpecialization.TabIndex = 99;
            // 
            // comboBoxEmployeeAddSpecialization
            // 
            this.comboBoxEmployeeAddSpecialization.FormattingEnabled = true;
            this.comboBoxEmployeeAddSpecialization.Location = new System.Drawing.Point(111, 19);
            this.comboBoxEmployeeAddSpecialization.Name = "comboBoxEmployeeAddSpecialization";
            this.comboBoxEmployeeAddSpecialization.Size = new System.Drawing.Size(242, 21);
            this.comboBoxEmployeeAddSpecialization.TabIndex = 98;
            // 
            // buttonAddEmployee
            // 
            this.buttonAddEmployee.Location = new System.Drawing.Point(598, 431);
            this.buttonAddEmployee.Name = "buttonAddEmployee";
            this.buttonAddEmployee.Size = new System.Drawing.Size(136, 23);
            this.buttonAddEmployee.TabIndex = 100;
            this.buttonAddEmployee.Text = "Zapisz";
            this.buttonAddEmployee.UseVisualStyleBackColor = true;
            this.buttonAddEmployee.Click += new System.EventHandler(this.buttonAddEmployee_Click);
            // 
            // buttonLoadPicture
            // 
            this.buttonLoadPicture.Location = new System.Drawing.Point(590, 35);
            this.buttonLoadPicture.Name = "buttonLoadPicture";
            this.buttonLoadPicture.Size = new System.Drawing.Size(136, 23);
            this.buttonLoadPicture.TabIndex = 102;
            this.buttonLoadPicture.Text = "Dodaj";
            this.buttonLoadPicture.UseVisualStyleBackColor = true;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employee_viewBindingSource
            // 
            this.employee_viewBindingSource.DataMember = "Employee_view";
            this.employee_viewBindingSource.DataSource = this.dataSet;
            // 
            // employee_viewTableAdapter
            // 
            this.employee_viewTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.MedicalServicesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Clinic.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(384, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 243);
            this.pictureBox1.TabIndex = 103;
            this.pictureBox1.TabStop = false;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 474);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonLoadPicture);
            this.Controls.Add(this.buttonAddEmployee);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxEmployeeSpecialization);
            this.Controls.Add(this.textBoxEmployeePicture);
            this.Controls.Add(this.comboBoxEmployeeGroup);
            this.Controls.Add(this.comboBoxEmployeeCity);
            this.Controls.Add(this.comboBoxEmployeeVoivodeship);
            this.Controls.Add(this.textBoxEmployeePasswordConfirm);
            this.Controls.Add(this.textBoxEmployeeLogin);
            this.Controls.Add(this.textBoxEmployeePassword);
            this.Controls.Add(this.textBoxEmployeePhoneNo);
            this.Controls.Add(this.textBoxEmployeeDescription);
            this.Controls.Add(this.textBoxEmployeePostalCode);
            this.Controls.Add(this.textBoxEmployeeStreet);
            this.Controls.Add(this.textBoxEmployeeStreetNo);
            this.Controls.Add(this.textBoxEmployeeFirstName);
            this.Controls.Add(this.textBoxEmployeeLastName);
            this.Controls.Add(label4);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(cityIDLabel1);
            this.Controls.Add(phoneNumberLabel1);
            this.Controls.Add(label13);
            this.Controls.Add(userGroupIDLabel);
            this.Controls.Add(firstNameLabel1);
            this.Controls.Add(postalCodeLabel1);
            this.Controls.Add(employeeDescriptionLabel);
            this.Controls.Add(lastNameLabel1);
            this.Controls.Add(streetNumerLabel1);
            this.Controls.Add(userPasswordLabel);
            this.Controls.Add(userLoginLabel);
            this.Controls.Add(streetLabel1);
            this.Name = "EmployeeForm";
            this.Text = "Pracownik";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_viewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox comboBoxEmployeeGroup;
        private System.Windows.Forms.ComboBox comboBoxEmployeeCity;
        private System.Windows.Forms.ComboBox comboBoxEmployeeVoivodeship;
        private System.Windows.Forms.TextBox textBoxEmployeePasswordConfirm;
        private System.Windows.Forms.TextBox textBoxEmployeeLogin;
        private System.Windows.Forms.TextBox textBoxEmployeePassword;
        private System.Windows.Forms.TextBox textBoxEmployeePhoneNo;
        private System.Windows.Forms.TextBox textBoxEmployeeDescription;
        private System.Windows.Forms.TextBox textBoxEmployeePostalCode;
        private System.Windows.Forms.TextBox textBoxEmployeeStreet;
        private System.Windows.Forms.TextBox textBoxEmployeeStreetNo;
        private System.Windows.Forms.TextBox textBoxEmployeeFirstName;
        private System.Windows.Forms.TextBox textBoxEmployeeLastName;
        private System.Windows.Forms.TextBox textBoxEmployeePicture;
        private System.Windows.Forms.TextBox textBoxEmployeeSpecialization;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxEmployeeNewSpecialization;
        private System.Windows.Forms.ComboBox comboBoxEmployeeAddSpecialization;
        private System.Windows.Forms.Button buttonAddEmployee;
        private System.Windows.Forms.Button buttonLoadPicture;
        private DataSet dataSet;
        private System.Windows.Forms.BindingSource employee_viewBindingSource;
        private DataSetTableAdapters.Employee_viewTableAdapter employee_viewTableAdapter;
        private DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}