namespace Clinic
{
    partial class MainClinicWindow
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
            System.Windows.Forms.Label medicalSpecialistLabel;
            System.Windows.Forms.Label visitDateLabel;
            System.Windows.Forms.Label label22;
            System.Windows.Forms.Label label15;
            System.Windows.Forms.Label label16;
            System.Windows.Forms.Label label17;
            System.Windows.Forms.Label label18;
            System.Windows.Forms.Label label19;
            System.Windows.Forms.Label label20;
            System.Windows.Forms.Label label21;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label12;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label label13;
            System.Windows.Forms.Label label14;
            System.Windows.Forms.Label label23;
            System.Windows.Forms.Label label24;
            System.Windows.Forms.Label label25;
            System.Windows.Forms.Label label26;
            System.Windows.Forms.Label label27;
            System.Windows.Forms.Label label28;
            System.Windows.Forms.Label employeeIDLabel;
            System.Windows.Forms.Label paidAmountLabel;
            System.Windows.Forms.Label medicalServiceIDLabel;
            System.Windows.Forms.Label patientIDLabel;
            System.Windows.Forms.Label nFZLabel;
            System.Windows.Forms.Label examinationDateLabel;
            System.Windows.Forms.Label examinationDescriptionLabel;
            System.Windows.Forms.Label serviceNameLabel;
            System.Windows.Forms.Label serviceDescriptionLabel;
            System.Windows.Forms.Label priceLabel;
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabSchedule = new System.Windows.Forms.TabPage();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.label30 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBoxSchedulerHour = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.textBoxSchedulerLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxSchedulerService = new System.Windows.Forms.ComboBox();
            this.textBoxSchedulerAddress = new System.Windows.Forms.TextBox();
            this.comboBoxSchedulerDoctor = new System.Windows.Forms.ComboBox();
            this.radioButtonService = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButtonVisit = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSchedulerFirstName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSchedulerPesel = new System.Windows.Forms.TextBox();
            this.buttonSaveSchedule = new System.Windows.Forms.Button();
            this.tabPatients = new System.Windows.Forms.TabPage();
            this.patients_viewDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.patients_viewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new Clinic.DataSet();
            this.checkBoxShowArchives = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonDeletePatient = new System.Windows.Forms.Button();
            this.buttonEditPatient = new System.Windows.Forms.Button();
            this.buttonAddPatient = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPatientPesel = new System.Windows.Forms.TextBox();
            this.tabVistis = new System.Windows.Forms.TabPage();
            this.buttonSaveVisit = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBoxVisitCode = new System.Windows.Forms.TextBox();
            this.textBoxVisitDescription = new System.Windows.Forms.TextBox();
            this.buttonMedicines = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxArchivMedicines = new System.Windows.Forms.TextBox();
            this.textBoxVisitArchivCode = new System.Windows.Forms.TextBox();
            this.textBoxVisitArchiveDescription = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePickerVisitDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxVisitDoctor = new System.Windows.Forms.TextBox();
            this.textBoxVisitPesel = new System.Windows.Forms.TextBox();
            this.tabServices = new System.Windows.Forms.TabPage();
            this.buttonSaveExamination = new System.Windows.Forms.Button();
            this.textBoxServicesDescription = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.textBoxServicesCity = new System.Windows.Forms.TextBox();
            this.textBoxServicesPhoneNo = new System.Windows.Forms.TextBox();
            this.textBoxServicesPostalCode = new System.Windows.Forms.TextBox();
            this.textBoxServicesStreet = new System.Windows.Forms.TextBox();
            this.textBoxServicesStreetNo = new System.Windows.Forms.TextBox();
            this.textBoxServicesFirstName = new System.Windows.Forms.TextBox();
            this.textBoxServicesLastName = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.checkBoxServicesNFZ = new System.Windows.Forms.CheckBox();
            this.dateTimePickerServicesDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxServicesAmount = new System.Windows.Forms.TextBox();
            this.textBoxServicesPesel = new System.Windows.Forms.TextBox();
            this.comboBoxServicesServiceName = new System.Windows.Forms.ComboBox();
            this.textBoxServicesDoctor = new System.Windows.Forms.TextBox();
            this.tabAdministration = new System.Windows.Forms.TabPage();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.buttonAddService = new System.Windows.Forms.Button();
            this.textBoxAdministrationServicePrice = new System.Windows.Forms.TextBox();
            this.textBoxAdministrationServiceDescription = new System.Windows.Forms.TextBox();
            this.textBoxAdministrationServiceName = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.medicalServicesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicalServicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonEditService = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.employee_viewDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.employee_viewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonDeleteEmployee = new System.Windows.Forms.Button();
            this.buttonAddEmployee = new System.Windows.Forms.Button();
            this.buttonEditEployee = new System.Windows.Forms.Button();
            this.labelLoginName = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.messageQueue1 = new System.Messaging.MessageQueue();
            this.patients_viewTableAdapter = new Clinic.DataSetTableAdapters.Patients_viewTableAdapter();
            this.tableAdapterManager = new Clinic.DataSetTableAdapters.TableAdapterManager();
            this.employee_viewTableAdapter = new Clinic.DataSetTableAdapters.Employee_viewTableAdapter();
            this.medicalServicesTableAdapter = new Clinic.DataSetTableAdapters.MedicalServicesTableAdapter();
            this.visits_viewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.visits_viewTableAdapter = new Clinic.DataSetTableAdapters.Visits_viewTableAdapter();
            this.visits_viewDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exterminations_viewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.exterminations_viewTableAdapter = new Clinic.DataSetTableAdapters.Exterminations_viewTableAdapter();
            this.exterminations_viewDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            medicalSpecialistLabel = new System.Windows.Forms.Label();
            visitDateLabel = new System.Windows.Forms.Label();
            label22 = new System.Windows.Forms.Label();
            label15 = new System.Windows.Forms.Label();
            label16 = new System.Windows.Forms.Label();
            label17 = new System.Windows.Forms.Label();
            label18 = new System.Windows.Forms.Label();
            label19 = new System.Windows.Forms.Label();
            label20 = new System.Windows.Forms.Label();
            label21 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            label23 = new System.Windows.Forms.Label();
            label24 = new System.Windows.Forms.Label();
            label25 = new System.Windows.Forms.Label();
            label26 = new System.Windows.Forms.Label();
            label27 = new System.Windows.Forms.Label();
            label28 = new System.Windows.Forms.Label();
            employeeIDLabel = new System.Windows.Forms.Label();
            paidAmountLabel = new System.Windows.Forms.Label();
            medicalServiceIDLabel = new System.Windows.Forms.Label();
            patientIDLabel = new System.Windows.Forms.Label();
            nFZLabel = new System.Windows.Forms.Label();
            examinationDateLabel = new System.Windows.Forms.Label();
            examinationDescriptionLabel = new System.Windows.Forms.Label();
            serviceNameLabel = new System.Windows.Forms.Label();
            serviceDescriptionLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabSchedule.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.tabPatients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patients_viewDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patients_viewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            this.tabVistis.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabServices.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabAdministration.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicalServicesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalServicesBindingSource)).BeginInit();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employee_viewDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_viewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visits_viewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visits_viewDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exterminations_viewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exterminations_viewDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // medicalSpecialistLabel
            // 
            medicalSpecialistLabel.AutoSize = true;
            medicalSpecialistLabel.Location = new System.Drawing.Point(6, 69);
            medicalSpecialistLabel.Name = "medicalSpecialistLabel";
            medicalSpecialistLabel.Size = new System.Drawing.Size(102, 13);
            medicalSpecialistLabel.TabIndex = 20;
            medicalSpecialistLabel.Text = "Lekarz prowadzący:";
            // 
            // visitDateLabel
            // 
            visitDateLabel.AutoSize = true;
            visitDateLabel.Location = new System.Drawing.Point(6, 98);
            visitDateLabel.Name = "visitDateLabel";
            visitDateLabel.Size = new System.Drawing.Size(64, 13);
            visitDateLabel.TabIndex = 21;
            visitDateLabel.Text = "Data wizyty:";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new System.Drawing.Point(6, 43);
            label22.Name = "label22";
            label22.Size = new System.Drawing.Size(88, 13);
            label22.TabIndex = 22;
            label22.Text = "PESEL pacjenta:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new System.Drawing.Point(6, 70);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(29, 13);
            label15.TabIndex = 15;
            label15.Text = "Imię:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new System.Drawing.Point(6, 96);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(56, 13);
            label16.TabIndex = 16;
            label16.Text = "Nazwisko:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new System.Drawing.Point(6, 122);
            label17.Name = "label17";
            label17.Size = new System.Drawing.Size(34, 13);
            label17.TabIndex = 17;
            label17.Text = "Ulica:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new System.Drawing.Point(6, 148);
            label18.Name = "label18";
            label18.Size = new System.Drawing.Size(70, 13);
            label18.TabIndex = 18;
            label18.Text = "Numer domu:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new System.Drawing.Point(6, 174);
            label19.Name = "label19";
            label19.Size = new System.Drawing.Size(77, 13);
            label19.TabIndex = 19;
            label19.Text = "Kod pocztowy:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new System.Drawing.Point(6, 200);
            label20.Name = "label20";
            label20.Size = new System.Drawing.Size(41, 13);
            label20.TabIndex = 20;
            label20.Text = "Miasto:";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new System.Drawing.Point(6, 226);
            label21.Name = "label21";
            label21.Size = new System.Drawing.Size(82, 13);
            label21.TabIndex = 21;
            label21.Text = "Numer telefonu:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(6, 52);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(31, 13);
            label7.TabIndex = 10;
            label7.Text = "Opis:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(6, 27);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(70, 13);
            label8.TabIndex = 9;
            label8.Text = "Kod choroby:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(8, 260);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(30, 13);
            label12.TabIndex = 17;
            label12.Text = "Leki:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(8, 54);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(31, 13);
            label9.TabIndex = 16;
            label9.Text = "Opis:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new System.Drawing.Point(6, 25);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(70, 13);
            label13.TabIndex = 15;
            label13.Text = "Kod choroby:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new System.Drawing.Point(6, 48);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(29, 13);
            label14.TabIndex = 15;
            label14.Text = "Imię:";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new System.Drawing.Point(6, 74);
            label23.Name = "label23";
            label23.Size = new System.Drawing.Size(56, 13);
            label23.TabIndex = 16;
            label23.Text = "Nazwisko:";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new System.Drawing.Point(6, 100);
            label24.Name = "label24";
            label24.Size = new System.Drawing.Size(34, 13);
            label24.TabIndex = 17;
            label24.Text = "Ulica:";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new System.Drawing.Point(6, 126);
            label25.Name = "label25";
            label25.Size = new System.Drawing.Size(70, 13);
            label25.TabIndex = 18;
            label25.Text = "Numer domu:";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new System.Drawing.Point(6, 152);
            label26.Name = "label26";
            label26.Size = new System.Drawing.Size(77, 13);
            label26.TabIndex = 19;
            label26.Text = "Kod pocztowy:";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new System.Drawing.Point(6, 178);
            label27.Name = "label27";
            label27.Size = new System.Drawing.Size(41, 13);
            label27.TabIndex = 20;
            label27.Text = "Miasto:";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new System.Drawing.Point(6, 204);
            label28.Name = "label28";
            label28.Size = new System.Drawing.Size(82, 13);
            label28.TabIndex = 21;
            label28.Text = "Numer telefonu:";
            // 
            // employeeIDLabel
            // 
            employeeIDLabel.AutoSize = true;
            employeeIDLabel.Location = new System.Drawing.Point(6, 49);
            employeeIDLabel.Name = "employeeIDLabel";
            employeeIDLabel.Size = new System.Drawing.Size(142, 13);
            employeeIDLabel.TabIndex = 39;
            employeeIDLabel.Text = "Osoba wykonująca badanie:";
            // 
            // paidAmountLabel
            // 
            paidAmountLabel.AutoSize = true;
            paidAmountLabel.Location = new System.Drawing.Point(6, 183);
            paidAmountLabel.Name = "paidAmountLabel";
            paidAmountLabel.Size = new System.Drawing.Size(97, 13);
            paidAmountLabel.TabIndex = 44;
            paidAmountLabel.Text = "Kwota zapłacona: ";
            // 
            // medicalServiceIDLabel
            // 
            medicalServiceIDLabel.AutoSize = true;
            medicalServiceIDLabel.Location = new System.Drawing.Point(6, 75);
            medicalServiceIDLabel.Name = "medicalServiceIDLabel";
            medicalServiceIDLabel.Size = new System.Drawing.Size(75, 13);
            medicalServiceIDLabel.TabIndex = 40;
            medicalServiceIDLabel.Text = "Nazwa usługi:";
            // 
            // patientIDLabel
            // 
            patientIDLabel.AutoSize = true;
            patientIDLabel.Location = new System.Drawing.Point(6, 101);
            patientIDLabel.Name = "patientIDLabel";
            patientIDLabel.Size = new System.Drawing.Size(88, 13);
            patientIDLabel.TabIndex = 41;
            patientIDLabel.Text = "PESEL pacjenta:";
            // 
            // nFZLabel
            // 
            nFZLabel.AutoSize = true;
            nFZLabel.Location = new System.Drawing.Point(9, 157);
            nFZLabel.Name = "nFZLabel";
            nFZLabel.Size = new System.Drawing.Size(31, 13);
            nFZLabel.TabIndex = 42;
            nFZLabel.Text = "NFZ:";
            // 
            // examinationDateLabel
            // 
            examinationDateLabel.AutoSize = true;
            examinationDateLabel.Location = new System.Drawing.Point(6, 130);
            examinationDateLabel.Name = "examinationDateLabel";
            examinationDateLabel.Size = new System.Drawing.Size(128, 13);
            examinationDateLabel.TabIndex = 43;
            examinationDateLabel.Text = "Data wykonania badania:";
            // 
            // examinationDescriptionLabel
            // 
            examinationDescriptionLabel.AutoSize = true;
            examinationDescriptionLabel.Location = new System.Drawing.Point(462, 14);
            examinationDescriptionLabel.Name = "examinationDescriptionLabel";
            examinationDescriptionLabel.Size = new System.Drawing.Size(82, 13);
            examinationDescriptionLabel.TabIndex = 43;
            examinationDescriptionLabel.Text = "Wynik Badania:";
            // 
            // serviceNameLabel
            // 
            serviceNameLabel.AutoSize = true;
            serviceNameLabel.Location = new System.Drawing.Point(6, 28);
            serviceNameLabel.Name = "serviceNameLabel";
            serviceNameLabel.Size = new System.Drawing.Size(75, 13);
            serviceNameLabel.TabIndex = 22;
            serviceNameLabel.Text = "Nazwa usługi:";
            // 
            // serviceDescriptionLabel
            // 
            serviceDescriptionLabel.AutoSize = true;
            serviceDescriptionLabel.Location = new System.Drawing.Point(6, 54);
            serviceDescriptionLabel.Name = "serviceDescriptionLabel";
            serviceDescriptionLabel.Size = new System.Drawing.Size(31, 13);
            serviceDescriptionLabel.TabIndex = 23;
            serviceDescriptionLabel.Text = "Opis:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(6, 128);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(35, 13);
            priceLabel.TabIndex = 24;
            priceLabel.Text = "Cena:";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabSchedule);
            this.tabControl.Controls.Add(this.tabPatients);
            this.tabControl.Controls.Add(this.tabVistis);
            this.tabControl.Controls.Add(this.tabServices);
            this.tabControl.Controls.Add(this.tabAdministration);
            this.tabControl.Location = new System.Drawing.Point(-1, 31);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1206, 684);
            this.tabControl.TabIndex = 0;
            // 
            // tabSchedule
            // 
            this.tabSchedule.AutoScroll = true;
            this.tabSchedule.Controls.Add(this.label31);
            this.tabSchedule.Controls.Add(this.label32);
            this.tabSchedule.Controls.Add(this.exterminations_viewDataGridView);
            this.tabSchedule.Controls.Add(this.visits_viewDataGridView);
            this.tabSchedule.Controls.Add(this.groupBox10);
            this.tabSchedule.Controls.Add(this.buttonSaveSchedule);
            this.tabSchedule.Location = new System.Drawing.Point(4, 22);
            this.tabSchedule.Name = "tabSchedule";
            this.tabSchedule.Padding = new System.Windows.Forms.Padding(3);
            this.tabSchedule.Size = new System.Drawing.Size(1198, 658);
            this.tabSchedule.TabIndex = 0;
            this.tabSchedule.Text = "Zapisy";
            this.tabSchedule.UseVisualStyleBackColor = true;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.label30);
            this.groupBox10.Controls.Add(this.dateTimePicker1);
            this.groupBox10.Controls.Add(this.textBoxSchedulerHour);
            this.groupBox10.Controls.Add(this.label29);
            this.groupBox10.Controls.Add(this.textBoxSchedulerLastName);
            this.groupBox10.Controls.Add(this.label2);
            this.groupBox10.Controls.Add(this.comboBoxSchedulerService);
            this.groupBox10.Controls.Add(this.textBoxSchedulerAddress);
            this.groupBox10.Controls.Add(this.comboBoxSchedulerDoctor);
            this.groupBox10.Controls.Add(this.radioButtonService);
            this.groupBox10.Controls.Add(this.label3);
            this.groupBox10.Controls.Add(this.radioButtonVisit);
            this.groupBox10.Controls.Add(this.label4);
            this.groupBox10.Controls.Add(this.textBoxSchedulerFirstName);
            this.groupBox10.Controls.Add(this.label5);
            this.groupBox10.Controls.Add(this.textBoxSchedulerPesel);
            this.groupBox10.Location = new System.Drawing.Point(788, 14);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(401, 608);
            this.groupBox10.TabIndex = 22;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Zapisy";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(39, 333);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(33, 13);
            this.label30.TabIndex = 25;
            this.label30.Text = "Data:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(132, 327);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(242, 20);
            this.dateTimePicker1.TabIndex = 24;
            // 
            // textBoxSchedulerHour
            // 
            this.textBoxSchedulerHour.Location = new System.Drawing.Point(132, 353);
            this.textBoxSchedulerHour.Name = "textBoxSchedulerHour";
            this.textBoxSchedulerHour.Size = new System.Drawing.Size(242, 20);
            this.textBoxSchedulerHour.TabIndex = 23;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(39, 356);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(49, 13);
            this.label29.TabIndex = 22;
            this.label29.Text = "Godzina:";
            // 
            // textBoxSchedulerLastName
            // 
            this.textBoxSchedulerLastName.Location = new System.Drawing.Point(132, 275);
            this.textBoxSchedulerLastName.Name = "textBoxSchedulerLastName";
            this.textBoxSchedulerLastName.Size = new System.Drawing.Size(242, 20);
            this.textBoxSchedulerLastName.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "PESEL:";
            // 
            // comboBoxSchedulerService
            // 
            this.comboBoxSchedulerService.Enabled = false;
            this.comboBoxSchedulerService.FormattingEnabled = true;
            this.comboBoxSchedulerService.Location = new System.Drawing.Point(132, 154);
            this.comboBoxSchedulerService.Name = "comboBoxSchedulerService";
            this.comboBoxSchedulerService.Size = new System.Drawing.Size(242, 21);
            this.comboBoxSchedulerService.TabIndex = 15;
            // 
            // textBoxSchedulerAddress
            // 
            this.textBoxSchedulerAddress.Location = new System.Drawing.Point(132, 301);
            this.textBoxSchedulerAddress.Name = "textBoxSchedulerAddress";
            this.textBoxSchedulerAddress.Size = new System.Drawing.Size(242, 20);
            this.textBoxSchedulerAddress.TabIndex = 19;
            // 
            // comboBoxSchedulerDoctor
            // 
            this.comboBoxSchedulerDoctor.FormattingEnabled = true;
            this.comboBoxSchedulerDoctor.Location = new System.Drawing.Point(132, 127);
            this.comboBoxSchedulerDoctor.Name = "comboBoxSchedulerDoctor";
            this.comboBoxSchedulerDoctor.Size = new System.Drawing.Size(242, 21);
            this.comboBoxSchedulerDoctor.TabIndex = 14;
            this.comboBoxSchedulerDoctor.Text = "Jan Kowalski (kardiolog)";
            // 
            // radioButtonService
            // 
            this.radioButtonService.AutoSize = true;
            this.radioButtonService.Location = new System.Drawing.Point(42, 157);
            this.radioButtonService.Name = "radioButtonService";
            this.radioButtonService.Size = new System.Drawing.Size(81, 17);
            this.radioButtonService.TabIndex = 3;
            this.radioButtonService.Text = "inna usługa";
            this.radioButtonService.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Imię:";
            // 
            // radioButtonVisit
            // 
            this.radioButtonVisit.AutoSize = true;
            this.radioButtonVisit.Checked = true;
            this.radioButtonVisit.Location = new System.Drawing.Point(42, 127);
            this.radioButtonVisit.Name = "radioButtonVisit";
            this.radioButtonVisit.Size = new System.Drawing.Size(54, 17);
            this.radioButtonVisit.TabIndex = 2;
            this.radioButtonVisit.TabStop = true;
            this.radioButtonVisit.Text = "wizyta";
            this.radioButtonVisit.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Nazwisko:";
            // 
            // textBoxSchedulerFirstName
            // 
            this.textBoxSchedulerFirstName.Location = new System.Drawing.Point(132, 250);
            this.textBoxSchedulerFirstName.Name = "textBoxSchedulerFirstName";
            this.textBoxSchedulerFirstName.Size = new System.Drawing.Size(242, 20);
            this.textBoxSchedulerFirstName.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Adres:";
            // 
            // textBoxSchedulerPesel
            // 
            this.textBoxSchedulerPesel.Location = new System.Drawing.Point(132, 224);
            this.textBoxSchedulerPesel.Name = "textBoxSchedulerPesel";
            this.textBoxSchedulerPesel.Size = new System.Drawing.Size(242, 20);
            this.textBoxSchedulerPesel.TabIndex = 16;
            // 
            // buttonSaveSchedule
            // 
            this.buttonSaveSchedule.Location = new System.Drawing.Point(1105, 628);
            this.buttonSaveSchedule.Name = "buttonSaveSchedule";
            this.buttonSaveSchedule.Size = new System.Drawing.Size(84, 23);
            this.buttonSaveSchedule.TabIndex = 20;
            this.buttonSaveSchedule.Text = "Zapisz";
            this.buttonSaveSchedule.UseVisualStyleBackColor = true;
            this.buttonSaveSchedule.Click += new System.EventHandler(this.buttonSaveSchedule_Click);
            // 
            // tabPatients
            // 
            this.tabPatients.AutoScroll = true;
            this.tabPatients.Controls.Add(this.patients_viewDataGridView);
            this.tabPatients.Controls.Add(this.checkBoxShowArchives);
            this.tabPatients.Controls.Add(this.label6);
            this.tabPatients.Controls.Add(this.buttonDeletePatient);
            this.tabPatients.Controls.Add(this.buttonEditPatient);
            this.tabPatients.Controls.Add(this.buttonAddPatient);
            this.tabPatients.Controls.Add(this.buttonSearch);
            this.tabPatients.Controls.Add(this.label1);
            this.tabPatients.Controls.Add(this.textBoxPatientPesel);
            this.tabPatients.Location = new System.Drawing.Point(4, 22);
            this.tabPatients.Name = "tabPatients";
            this.tabPatients.Padding = new System.Windows.Forms.Padding(3);
            this.tabPatients.Size = new System.Drawing.Size(1198, 658);
            this.tabPatients.TabIndex = 1;
            this.tabPatients.Text = "Pacjenci";
            this.tabPatients.UseVisualStyleBackColor = true;
            // 
            // patients_viewDataGridView
            // 
            this.patients_viewDataGridView.AutoGenerateColumns = false;
            this.patients_viewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patients_viewDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewCheckBoxColumn1});
            this.patients_viewDataGridView.DataSource = this.patients_viewBindingSource;
            this.patients_viewDataGridView.Location = new System.Drawing.Point(9, 58);
            this.patients_viewDataGridView.Name = "patients_viewDataGridView";
            this.patients_viewDataGridView.Size = new System.Drawing.Size(1181, 553);
            this.patients_viewDataGridView.TabIndex = 25;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Imię";
            this.dataGridViewTextBoxColumn1.HeaderText = "Imię";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nazwisko";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nazwisko";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PESEL";
            this.dataGridViewTextBoxColumn3.HeaderText = "PESEL";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Numer telefonu";
            this.dataGridViewTextBoxColumn4.HeaderText = "Numer telefonu";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Ulica";
            this.dataGridViewTextBoxColumn5.HeaderText = "Ulica";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Numer";
            this.dataGridViewTextBoxColumn6.HeaderText = "Numer";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Kod pocztowy";
            this.dataGridViewTextBoxColumn7.HeaderText = "Kod pocztowy";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Miasto";
            this.dataGridViewTextBoxColumn8.HeaderText = "Miasto";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Województwo";
            this.dataGridViewTextBoxColumn9.HeaderText = "Województwo";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Zapisany";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Zapisany";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // patients_viewBindingSource
            // 
            this.patients_viewBindingSource.DataMember = "Patients_view";
            this.patients_viewBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // checkBoxShowArchives
            // 
            this.checkBoxShowArchives.AutoSize = true;
            this.checkBoxShowArchives.Location = new System.Drawing.Point(113, 621);
            this.checkBoxShowArchives.Name = "checkBoxShowArchives";
            this.checkBoxShowArchives.Size = new System.Drawing.Size(66, 17);
            this.checkBoxShowArchives.TabIndex = 25;
            this.checkBoxShowArchives.Text = "Tak/Nie";
            this.checkBoxShowArchives.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 622);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Pokaż archiwalne:";
            // 
            // buttonDeletePatient
            // 
            this.buttonDeletePatient.Location = new System.Drawing.Point(1054, 617);
            this.buttonDeletePatient.Name = "buttonDeletePatient";
            this.buttonDeletePatient.Size = new System.Drawing.Size(136, 23);
            this.buttonDeletePatient.TabIndex = 23;
            this.buttonDeletePatient.Text = "Wypisz pacjenta";
            this.buttonDeletePatient.UseVisualStyleBackColor = true;
            this.buttonDeletePatient.Click += new System.EventHandler(this.buttonDeletePatient_Click);
            // 
            // buttonEditPatient
            // 
            this.buttonEditPatient.Location = new System.Drawing.Point(912, 617);
            this.buttonEditPatient.Name = "buttonEditPatient";
            this.buttonEditPatient.Size = new System.Drawing.Size(136, 23);
            this.buttonEditPatient.TabIndex = 22;
            this.buttonEditPatient.Text = "Edytuj pacjenta";
            this.buttonEditPatient.UseVisualStyleBackColor = true;
            this.buttonEditPatient.Click += new System.EventHandler(this.buttonEditPatient_Click);
            // 
            // buttonAddPatient
            // 
            this.buttonAddPatient.Location = new System.Drawing.Point(1054, 16);
            this.buttonAddPatient.Name = "buttonAddPatient";
            this.buttonAddPatient.Size = new System.Drawing.Size(136, 23);
            this.buttonAddPatient.TabIndex = 21;
            this.buttonAddPatient.Text = "Nowy pacjent";
            this.buttonAddPatient.UseVisualStyleBackColor = true;
            this.buttonAddPatient.Click += new System.EventHandler(this.buttonAddPatient_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(339, 17);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(84, 23);
            this.buttonSearch.TabIndex = 19;
            this.buttonSearch.Text = "Szukaj";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "PESEL:";
            // 
            // textBoxPatientPesel
            // 
            this.textBoxPatientPesel.Location = new System.Drawing.Point(72, 19);
            this.textBoxPatientPesel.Name = "textBoxPatientPesel";
            this.textBoxPatientPesel.Size = new System.Drawing.Size(242, 20);
            this.textBoxPatientPesel.TabIndex = 18;
            // 
            // tabVistis
            // 
            this.tabVistis.Controls.Add(this.buttonSaveVisit);
            this.tabVistis.Controls.Add(this.groupBox4);
            this.tabVistis.Controls.Add(this.groupBox3);
            this.tabVistis.Controls.Add(this.groupBox2);
            this.tabVistis.Controls.Add(this.groupBox1);
            this.tabVistis.Location = new System.Drawing.Point(4, 22);
            this.tabVistis.Name = "tabVistis";
            this.tabVistis.Padding = new System.Windows.Forms.Padding(3);
            this.tabVistis.Size = new System.Drawing.Size(1198, 658);
            this.tabVistis.TabIndex = 2;
            this.tabVistis.Text = "Wizyty";
            this.tabVistis.UseVisualStyleBackColor = true;
            // 
            // buttonSaveVisit
            // 
            this.buttonSaveVisit.Location = new System.Drawing.Point(1105, 628);
            this.buttonSaveVisit.Name = "buttonSaveVisit";
            this.buttonSaveVisit.Size = new System.Drawing.Size(84, 23);
            this.buttonSaveVisit.TabIndex = 45;
            this.buttonSaveVisit.Text = "Zapisz";
            this.buttonSaveVisit.UseVisualStyleBackColor = true;
            this.buttonSaveVisit.Click += new System.EventHandler(this.buttonSaveVisit_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBoxVisitCode);
            this.groupBox4.Controls.Add(this.textBoxVisitDescription);
            this.groupBox4.Controls.Add(this.buttonMedicines);
            this.groupBox4.Controls.Add(label7);
            this.groupBox4.Controls.Add(label8);
            this.groupBox4.Location = new System.Drawing.Point(397, 371);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(792, 251);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Opis wizyty";
            // 
            // textBoxVisitCode
            // 
            this.textBoxVisitCode.Location = new System.Drawing.Point(82, 24);
            this.textBoxVisitCode.Name = "textBoxVisitCode";
            this.textBoxVisitCode.Size = new System.Drawing.Size(614, 20);
            this.textBoxVisitCode.TabIndex = 52;
            // 
            // textBoxVisitDescription
            // 
            this.textBoxVisitDescription.Location = new System.Drawing.Point(82, 50);
            this.textBoxVisitDescription.Multiline = true;
            this.textBoxVisitDescription.Name = "textBoxVisitDescription";
            this.textBoxVisitDescription.Size = new System.Drawing.Size(704, 195);
            this.textBoxVisitDescription.TabIndex = 51;
            // 
            // buttonMedicines
            // 
            this.buttonMedicines.Location = new System.Drawing.Point(702, 22);
            this.buttonMedicines.Name = "buttonMedicines";
            this.buttonMedicines.Size = new System.Drawing.Size(84, 23);
            this.buttonMedicines.TabIndex = 50;
            this.buttonMedicines.Text = "Leki";
            this.buttonMedicines.UseVisualStyleBackColor = true;
            this.buttonMedicines.Click += new System.EventHandler(this.buttonMedicines_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox12);
            this.groupBox3.Controls.Add(this.textBox13);
            this.groupBox3.Controls.Add(this.textBox14);
            this.groupBox3.Controls.Add(this.textBox10);
            this.groupBox3.Controls.Add(this.textBox11);
            this.groupBox3.Controls.Add(this.textBox9);
            this.groupBox3.Controls.Add(this.textBox7);
            this.groupBox3.Controls.Add(label15);
            this.groupBox3.Controls.Add(label16);
            this.groupBox3.Controls.Add(label17);
            this.groupBox3.Controls.Add(label18);
            this.groupBox3.Controls.Add(label19);
            this.groupBox3.Controls.Add(label20);
            this.groupBox3.Controls.Add(label21);
            this.groupBox3.Location = new System.Drawing.Point(9, 371);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(382, 251);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dane pacjenta";
            // 
            // textBox12
            // 
            this.textBox12.Enabled = false;
            this.textBox12.Location = new System.Drawing.Point(129, 197);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(242, 20);
            this.textBox12.TabIndex = 29;
            this.textBox12.Text = "Łódź";
            // 
            // textBox13
            // 
            this.textBox13.Enabled = false;
            this.textBox13.Location = new System.Drawing.Point(129, 223);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(242, 20);
            this.textBox13.TabIndex = 28;
            this.textBox13.Text = "666034543";
            // 
            // textBox14
            // 
            this.textBox14.Enabled = false;
            this.textBox14.Location = new System.Drawing.Point(129, 171);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(242, 20);
            this.textBox14.TabIndex = 27;
            this.textBox14.Text = "92-430";
            // 
            // textBox10
            // 
            this.textBox10.Enabled = false;
            this.textBox10.Location = new System.Drawing.Point(129, 119);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(242, 20);
            this.textBox10.TabIndex = 26;
            this.textBox10.Text = "Zielona";
            // 
            // textBox11
            // 
            this.textBox11.Enabled = false;
            this.textBox11.Location = new System.Drawing.Point(129, 145);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(242, 20);
            this.textBox11.TabIndex = 25;
            this.textBox11.Text = "2a";
            // 
            // textBox9
            // 
            this.textBox9.Enabled = false;
            this.textBox9.Location = new System.Drawing.Point(129, 67);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(242, 20);
            this.textBox9.TabIndex = 24;
            this.textBox9.Text = "Łukasz";
            // 
            // textBox7
            // 
            this.textBox7.Enabled = false;
            this.textBox7.Location = new System.Drawing.Point(129, 93);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(242, 20);
            this.textBox7.TabIndex = 23;
            this.textBox7.Text = "Adamowicz";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxArchivMedicines);
            this.groupBox2.Controls.Add(this.textBoxVisitArchivCode);
            this.groupBox2.Controls.Add(this.textBoxVisitArchiveDescription);
            this.groupBox2.Controls.Add(label12);
            this.groupBox2.Controls.Add(label9);
            this.groupBox2.Controls.Add(label13);
            this.groupBox2.Location = new System.Drawing.Point(397, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(792, 359);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Historia choroby";
            // 
            // textBoxArchivMedicines
            // 
            this.textBoxArchivMedicines.Enabled = false;
            this.textBoxArchivMedicines.Location = new System.Drawing.Point(82, 257);
            this.textBoxArchivMedicines.Multiline = true;
            this.textBoxArchivMedicines.Name = "textBoxArchivMedicines";
            this.textBoxArchivMedicines.Size = new System.Drawing.Size(704, 96);
            this.textBoxArchivMedicines.TabIndex = 55;
            this.textBoxArchivMedicines.Text = "Nedal 50mg, Acard 75 mg";
            // 
            // textBoxVisitArchivCode
            // 
            this.textBoxVisitArchivCode.Enabled = false;
            this.textBoxVisitArchivCode.Location = new System.Drawing.Point(82, 25);
            this.textBoxVisitArchivCode.Name = "textBoxVisitArchivCode";
            this.textBoxVisitArchivCode.Size = new System.Drawing.Size(704, 20);
            this.textBoxVisitArchivCode.TabIndex = 54;
            this.textBoxVisitArchivCode.Text = "I-18";
            // 
            // textBoxVisitArchiveDescription
            // 
            this.textBoxVisitArchiveDescription.Enabled = false;
            this.textBoxVisitArchiveDescription.Location = new System.Drawing.Point(82, 51);
            this.textBoxVisitArchiveDescription.Multiline = true;
            this.textBoxVisitArchiveDescription.Name = "textBoxVisitArchiveDescription";
            this.textBoxVisitArchiveDescription.Size = new System.Drawing.Size(704, 195);
            this.textBoxVisitArchiveDescription.TabIndex = 53;
            this.textBoxVisitArchiveDescription.Text = "Pacjent przebywał w szpitalu w maju 2014r.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePickerVisitDate);
            this.groupBox1.Controls.Add(this.textBoxVisitDoctor);
            this.groupBox1.Controls.Add(medicalSpecialistLabel);
            this.groupBox1.Controls.Add(visitDateLabel);
            this.groupBox1.Controls.Add(label22);
            this.groupBox1.Controls.Add(this.textBoxVisitPesel);
            this.groupBox1.Location = new System.Drawing.Point(9, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 359);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Szczegóły";
            // 
            // dateTimePickerVisitDate
            // 
            this.dateTimePickerVisitDate.Location = new System.Drawing.Point(129, 92);
            this.dateTimePickerVisitDate.Name = "dateTimePickerVisitDate";
            this.dateTimePickerVisitDate.Size = new System.Drawing.Size(242, 20);
            this.dateTimePickerVisitDate.TabIndex = 25;
            // 
            // textBoxVisitDoctor
            // 
            this.textBoxVisitDoctor.Location = new System.Drawing.Point(129, 66);
            this.textBoxVisitDoctor.Name = "textBoxVisitDoctor";
            this.textBoxVisitDoctor.Size = new System.Drawing.Size(242, 20);
            this.textBoxVisitDoctor.TabIndex = 24;
            this.textBoxVisitDoctor.Text = "Jan Kowalski";
            // 
            // textBoxVisitPesel
            // 
            this.textBoxVisitPesel.Location = new System.Drawing.Point(129, 40);
            this.textBoxVisitPesel.Name = "textBoxVisitPesel";
            this.textBoxVisitPesel.Size = new System.Drawing.Size(242, 20);
            this.textBoxVisitPesel.TabIndex = 19;
            this.textBoxVisitPesel.Text = "92032507988";
            // 
            // tabServices
            // 
            this.tabServices.Controls.Add(this.buttonSaveExamination);
            this.tabServices.Controls.Add(this.textBoxServicesDescription);
            this.tabServices.Controls.Add(examinationDescriptionLabel);
            this.tabServices.Controls.Add(this.groupBox6);
            this.tabServices.Controls.Add(this.groupBox5);
            this.tabServices.Location = new System.Drawing.Point(4, 22);
            this.tabServices.Name = "tabServices";
            this.tabServices.Padding = new System.Windows.Forms.Padding(3);
            this.tabServices.Size = new System.Drawing.Size(1198, 658);
            this.tabServices.TabIndex = 3;
            this.tabServices.Text = "Usługi";
            this.tabServices.UseVisualStyleBackColor = true;
            // 
            // buttonSaveExamination
            // 
            this.buttonSaveExamination.Location = new System.Drawing.Point(1105, 628);
            this.buttonSaveExamination.Name = "buttonSaveExamination";
            this.buttonSaveExamination.Size = new System.Drawing.Size(84, 23);
            this.buttonSaveExamination.TabIndex = 51;
            this.buttonSaveExamination.Text = "Zapisz";
            this.buttonSaveExamination.UseVisualStyleBackColor = true;
            this.buttonSaveExamination.Click += new System.EventHandler(this.buttonSaveExamination_Click);
            // 
            // textBoxServicesDescription
            // 
            this.textBoxServicesDescription.Location = new System.Drawing.Point(465, 30);
            this.textBoxServicesDescription.Multiline = true;
            this.textBoxServicesDescription.Name = "textBoxServicesDescription";
            this.textBoxServicesDescription.Size = new System.Drawing.Size(724, 592);
            this.textBoxServicesDescription.TabIndex = 50;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.textBoxServicesCity);
            this.groupBox6.Controls.Add(this.textBoxServicesPhoneNo);
            this.groupBox6.Controls.Add(this.textBoxServicesPostalCode);
            this.groupBox6.Controls.Add(this.textBoxServicesStreet);
            this.groupBox6.Controls.Add(this.textBoxServicesStreetNo);
            this.groupBox6.Controls.Add(this.textBoxServicesFirstName);
            this.groupBox6.Controls.Add(this.textBoxServicesLastName);
            this.groupBox6.Controls.Add(label14);
            this.groupBox6.Controls.Add(label23);
            this.groupBox6.Controls.Add(label24);
            this.groupBox6.Controls.Add(label25);
            this.groupBox6.Controls.Add(label26);
            this.groupBox6.Controls.Add(label27);
            this.groupBox6.Controls.Add(label28);
            this.groupBox6.Location = new System.Drawing.Point(9, 331);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(426, 291);
            this.groupBox6.TabIndex = 22;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Dane pacjenta";
            // 
            // textBoxServicesCity
            // 
            this.textBoxServicesCity.Enabled = false;
            this.textBoxServicesCity.Location = new System.Drawing.Point(173, 175);
            this.textBoxServicesCity.Name = "textBoxServicesCity";
            this.textBoxServicesCity.Size = new System.Drawing.Size(242, 20);
            this.textBoxServicesCity.TabIndex = 29;
            this.textBoxServicesCity.Text = "Łódź";
            // 
            // textBoxServicesPhoneNo
            // 
            this.textBoxServicesPhoneNo.Enabled = false;
            this.textBoxServicesPhoneNo.Location = new System.Drawing.Point(173, 201);
            this.textBoxServicesPhoneNo.Name = "textBoxServicesPhoneNo";
            this.textBoxServicesPhoneNo.Size = new System.Drawing.Size(242, 20);
            this.textBoxServicesPhoneNo.TabIndex = 28;
            this.textBoxServicesPhoneNo.Text = "666034543";
            // 
            // textBoxServicesPostalCode
            // 
            this.textBoxServicesPostalCode.Enabled = false;
            this.textBoxServicesPostalCode.Location = new System.Drawing.Point(173, 149);
            this.textBoxServicesPostalCode.Name = "textBoxServicesPostalCode";
            this.textBoxServicesPostalCode.Size = new System.Drawing.Size(242, 20);
            this.textBoxServicesPostalCode.TabIndex = 27;
            this.textBoxServicesPostalCode.Text = "92-430";
            // 
            // textBoxServicesStreet
            // 
            this.textBoxServicesStreet.Enabled = false;
            this.textBoxServicesStreet.Location = new System.Drawing.Point(173, 97);
            this.textBoxServicesStreet.Name = "textBoxServicesStreet";
            this.textBoxServicesStreet.Size = new System.Drawing.Size(242, 20);
            this.textBoxServicesStreet.TabIndex = 26;
            this.textBoxServicesStreet.Text = "Zielona";
            // 
            // textBoxServicesStreetNo
            // 
            this.textBoxServicesStreetNo.Enabled = false;
            this.textBoxServicesStreetNo.Location = new System.Drawing.Point(173, 123);
            this.textBoxServicesStreetNo.Name = "textBoxServicesStreetNo";
            this.textBoxServicesStreetNo.Size = new System.Drawing.Size(242, 20);
            this.textBoxServicesStreetNo.TabIndex = 25;
            this.textBoxServicesStreetNo.Text = "2a";
            // 
            // textBoxServicesFirstName
            // 
            this.textBoxServicesFirstName.Enabled = false;
            this.textBoxServicesFirstName.Location = new System.Drawing.Point(173, 45);
            this.textBoxServicesFirstName.Name = "textBoxServicesFirstName";
            this.textBoxServicesFirstName.Size = new System.Drawing.Size(242, 20);
            this.textBoxServicesFirstName.TabIndex = 24;
            this.textBoxServicesFirstName.Text = "Łukasz";
            // 
            // textBoxServicesLastName
            // 
            this.textBoxServicesLastName.Enabled = false;
            this.textBoxServicesLastName.Location = new System.Drawing.Point(173, 71);
            this.textBoxServicesLastName.Name = "textBoxServicesLastName";
            this.textBoxServicesLastName.Size = new System.Drawing.Size(242, 20);
            this.textBoxServicesLastName.TabIndex = 23;
            this.textBoxServicesLastName.Text = "Adamowicz";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.checkBoxServicesNFZ);
            this.groupBox5.Controls.Add(this.dateTimePickerServicesDate);
            this.groupBox5.Controls.Add(this.textBoxServicesAmount);
            this.groupBox5.Controls.Add(this.textBoxServicesPesel);
            this.groupBox5.Controls.Add(this.comboBoxServicesServiceName);
            this.groupBox5.Controls.Add(employeeIDLabel);
            this.groupBox5.Controls.Add(paidAmountLabel);
            this.groupBox5.Controls.Add(this.textBoxServicesDoctor);
            this.groupBox5.Controls.Add(medicalServiceIDLabel);
            this.groupBox5.Controls.Add(patientIDLabel);
            this.groupBox5.Controls.Add(nFZLabel);
            this.groupBox5.Controls.Add(examinationDateLabel);
            this.groupBox5.Location = new System.Drawing.Point(9, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(426, 319);
            this.groupBox5.TabIndex = 21;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Szczegóły";
            // 
            // checkBoxServicesNFZ
            // 
            this.checkBoxServicesNFZ.AutoSize = true;
            this.checkBoxServicesNFZ.Location = new System.Drawing.Point(173, 156);
            this.checkBoxServicesNFZ.Name = "checkBoxServicesNFZ";
            this.checkBoxServicesNFZ.Size = new System.Drawing.Size(66, 17);
            this.checkBoxServicesNFZ.TabIndex = 49;
            this.checkBoxServicesNFZ.Text = "Tak/Nie";
            this.checkBoxServicesNFZ.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerServicesDate
            // 
            this.dateTimePickerServicesDate.Location = new System.Drawing.Point(173, 124);
            this.dateTimePickerServicesDate.Name = "dateTimePickerServicesDate";
            this.dateTimePickerServicesDate.Size = new System.Drawing.Size(242, 20);
            this.dateTimePickerServicesDate.TabIndex = 48;
            // 
            // textBoxServicesAmount
            // 
            this.textBoxServicesAmount.Location = new System.Drawing.Point(173, 180);
            this.textBoxServicesAmount.Name = "textBoxServicesAmount";
            this.textBoxServicesAmount.Size = new System.Drawing.Size(242, 20);
            this.textBoxServicesAmount.TabIndex = 47;
            this.textBoxServicesAmount.Text = "0";
            // 
            // textBoxServicesPesel
            // 
            this.textBoxServicesPesel.Location = new System.Drawing.Point(173, 98);
            this.textBoxServicesPesel.Name = "textBoxServicesPesel";
            this.textBoxServicesPesel.Size = new System.Drawing.Size(242, 20);
            this.textBoxServicesPesel.TabIndex = 46;
            this.textBoxServicesPesel.Text = "92032507988";
            // 
            // comboBoxServicesServiceName
            // 
            this.comboBoxServicesServiceName.FormattingEnabled = true;
            this.comboBoxServicesServiceName.Location = new System.Drawing.Point(173, 72);
            this.comboBoxServicesServiceName.Name = "comboBoxServicesServiceName";
            this.comboBoxServicesServiceName.Size = new System.Drawing.Size(242, 21);
            this.comboBoxServicesServiceName.TabIndex = 45;
            this.comboBoxServicesServiceName.Text = "EKG";
            // 
            // textBoxServicesDoctor
            // 
            this.textBoxServicesDoctor.Location = new System.Drawing.Point(173, 46);
            this.textBoxServicesDoctor.Name = "textBoxServicesDoctor";
            this.textBoxServicesDoctor.Size = new System.Drawing.Size(242, 20);
            this.textBoxServicesDoctor.TabIndex = 20;
            this.textBoxServicesDoctor.Text = "Jan Kowalski";
            // 
            // tabAdministration
            // 
            this.tabAdministration.AutoScroll = true;
            this.tabAdministration.Controls.Add(this.groupBox9);
            this.tabAdministration.Controls.Add(this.groupBox8);
            this.tabAdministration.Controls.Add(this.groupBox7);
            this.tabAdministration.Location = new System.Drawing.Point(4, 22);
            this.tabAdministration.Name = "tabAdministration";
            this.tabAdministration.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdministration.Size = new System.Drawing.Size(1198, 658);
            this.tabAdministration.TabIndex = 4;
            this.tabAdministration.Text = "Administracja";
            this.tabAdministration.UseVisualStyleBackColor = true;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.buttonAddService);
            this.groupBox9.Controls.Add(this.textBoxAdministrationServicePrice);
            this.groupBox9.Controls.Add(this.textBoxAdministrationServiceDescription);
            this.groupBox9.Controls.Add(serviceNameLabel);
            this.groupBox9.Controls.Add(serviceDescriptionLabel);
            this.groupBox9.Controls.Add(priceLabel);
            this.groupBox9.Controls.Add(this.textBoxAdministrationServiceName);
            this.groupBox9.Location = new System.Drawing.Point(743, 468);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(446, 183);
            this.groupBox9.TabIndex = 2;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Nowa Usługa";
            // 
            // buttonAddService
            // 
            this.buttonAddService.Location = new System.Drawing.Point(304, 154);
            this.buttonAddService.Name = "buttonAddService";
            this.buttonAddService.Size = new System.Drawing.Size(136, 23);
            this.buttonAddService.TabIndex = 27;
            this.buttonAddService.Text = "Dodaj usługę";
            this.buttonAddService.UseVisualStyleBackColor = true;
            this.buttonAddService.Click += new System.EventHandler(this.buttonAddService_Click);
            // 
            // textBoxAdministrationServicePrice
            // 
            this.textBoxAdministrationServicePrice.Location = new System.Drawing.Point(98, 125);
            this.textBoxAdministrationServicePrice.Name = "textBoxAdministrationServicePrice";
            this.textBoxAdministrationServicePrice.Size = new System.Drawing.Size(342, 20);
            this.textBoxAdministrationServicePrice.TabIndex = 26;
            // 
            // textBoxAdministrationServiceDescription
            // 
            this.textBoxAdministrationServiceDescription.Location = new System.Drawing.Point(98, 51);
            this.textBoxAdministrationServiceDescription.Multiline = true;
            this.textBoxAdministrationServiceDescription.Name = "textBoxAdministrationServiceDescription";
            this.textBoxAdministrationServiceDescription.Size = new System.Drawing.Size(342, 68);
            this.textBoxAdministrationServiceDescription.TabIndex = 25;
            // 
            // textBoxAdministrationServiceName
            // 
            this.textBoxAdministrationServiceName.Location = new System.Drawing.Point(98, 25);
            this.textBoxAdministrationServiceName.Name = "textBoxAdministrationServiceName";
            this.textBoxAdministrationServiceName.Size = new System.Drawing.Size(342, 20);
            this.textBoxAdministrationServiceName.TabIndex = 21;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.medicalServicesDataGridView);
            this.groupBox8.Controls.Add(this.buttonEditService);
            this.groupBox8.Location = new System.Drawing.Point(743, 6);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(446, 456);
            this.groupBox8.TabIndex = 1;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Usługi";
            // 
            // medicalServicesDataGridView
            // 
            this.medicalServicesDataGridView.AutoGenerateColumns = false;
            this.medicalServicesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.medicalServicesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15});
            this.medicalServicesDataGridView.DataSource = this.medicalServicesBindingSource;
            this.medicalServicesDataGridView.Location = new System.Drawing.Point(9, 19);
            this.medicalServicesDataGridView.Name = "medicalServicesDataGridView";
            this.medicalServicesDataGridView.Size = new System.Drawing.Size(431, 402);
            this.medicalServicesDataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "ServiceName";
            this.dataGridViewTextBoxColumn13.HeaderText = "Nazwa usługi";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "ServiceDescription";
            this.dataGridViewTextBoxColumn14.HeaderText = "Opis";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn15.HeaderText = "Cena";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // medicalServicesBindingSource
            // 
            this.medicalServicesBindingSource.DataMember = "MedicalServices";
            this.medicalServicesBindingSource.DataSource = this.dataSet;
            // 
            // buttonEditService
            // 
            this.buttonEditService.Location = new System.Drawing.Point(304, 427);
            this.buttonEditService.Name = "buttonEditService";
            this.buttonEditService.Size = new System.Drawing.Size(136, 23);
            this.buttonEditService.TabIndex = 8;
            this.buttonEditService.Text = "Edytuj usługę";
            this.buttonEditService.UseVisualStyleBackColor = true;
            this.buttonEditService.Click += new System.EventHandler(this.buttonEditService_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.employee_viewDataGridView);
            this.groupBox7.Controls.Add(this.buttonDeleteEmployee);
            this.groupBox7.Controls.Add(this.buttonAddEmployee);
            this.groupBox7.Controls.Add(this.buttonEditEployee);
            this.groupBox7.Location = new System.Drawing.Point(9, 6);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(728, 645);
            this.groupBox7.TabIndex = 0;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Pracownicy";
            // 
            // employee_viewDataGridView
            // 
            this.employee_viewDataGridView.AutoGenerateColumns = false;
            this.employee_viewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employee_viewDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewCheckBoxColumn2});
            this.employee_viewDataGridView.DataSource = this.employee_viewBindingSource;
            this.employee_viewDataGridView.Location = new System.Drawing.Point(6, 19);
            this.employee_viewDataGridView.Name = "employee_viewDataGridView";
            this.employee_viewDataGridView.Size = new System.Drawing.Size(716, 591);
            this.employee_viewDataGridView.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Imię";
            this.dataGridViewTextBoxColumn10.HeaderText = "Imię";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Nazwisko";
            this.dataGridViewTextBoxColumn11.HeaderText = "Nazwisko";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Numer telefonu";
            this.dataGridViewTextBoxColumn17.HeaderText = "Numer telefonu";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "Opis";
            this.dataGridViewTextBoxColumn18.HeaderText = "Opis";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "Zatrudniony";
            this.dataGridViewCheckBoxColumn2.HeaderText = "Zatrudniony";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            // 
            // employee_viewBindingSource
            // 
            this.employee_viewBindingSource.DataMember = "Employee_view";
            this.employee_viewBindingSource.DataSource = this.dataSet;
            // 
            // buttonDeleteEmployee
            // 
            this.buttonDeleteEmployee.Location = new System.Drawing.Point(586, 616);
            this.buttonDeleteEmployee.Name = "buttonDeleteEmployee";
            this.buttonDeleteEmployee.Size = new System.Drawing.Size(136, 23);
            this.buttonDeleteEmployee.TabIndex = 6;
            this.buttonDeleteEmployee.Text = "Usuń pracownika";
            this.buttonDeleteEmployee.UseVisualStyleBackColor = true;
            this.buttonDeleteEmployee.Click += new System.EventHandler(this.buttonDeleteEmployee_Click);
            // 
            // buttonAddEmployee
            // 
            this.buttonAddEmployee.Location = new System.Drawing.Point(303, 616);
            this.buttonAddEmployee.Name = "buttonAddEmployee";
            this.buttonAddEmployee.Size = new System.Drawing.Size(136, 23);
            this.buttonAddEmployee.TabIndex = 4;
            this.buttonAddEmployee.Text = "Dodaj pracownika";
            this.buttonAddEmployee.UseVisualStyleBackColor = true;
            this.buttonAddEmployee.Click += new System.EventHandler(this.buttonAddEmployee_Click);
            // 
            // buttonEditEployee
            // 
            this.buttonEditEployee.Location = new System.Drawing.Point(445, 616);
            this.buttonEditEployee.Name = "buttonEditEployee";
            this.buttonEditEployee.Size = new System.Drawing.Size(136, 23);
            this.buttonEditEployee.TabIndex = 5;
            this.buttonEditEployee.Text = "Edytuj pracownika";
            this.buttonEditEployee.UseVisualStyleBackColor = true;
            this.buttonEditEployee.Click += new System.EventHandler(this.buttonEditEployee_Click);
            // 
            // labelLoginName
            // 
            this.labelLoginName.AutoSize = true;
            this.labelLoginName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLoginName.Location = new System.Drawing.Point(934, 29);
            this.labelLoginName.Name = "labelLoginName";
            this.labelLoginName.Size = new System.Drawing.Size(69, 13);
            this.labelLoginName.TabIndex = 6;
            this.labelLoginName.Text = "Jan Kowalski";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(934, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Zalogowany jako:";
            // 
            // LogoutButton
            // 
            this.LogoutButton.Location = new System.Drawing.Point(1114, 12);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(84, 23);
            this.LogoutButton.TabIndex = 4;
            this.LogoutButton.Text = "Wyloguj";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label11.Location = new System.Drawing.Point(-1, 5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(160, 20);
            this.label11.TabIndex = 7;
            this.label11.Text = "Przychodnia Medica";
            // 
            // messageQueue1
            // 
            this.messageQueue1.MessageReadPropertyFilter.LookupId = true;
            this.messageQueue1.SynchronizingObject = this;
            // 
            // patients_viewTableAdapter
            // 
            this.patients_viewTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.MedicalServicesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Clinic.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // employee_viewTableAdapter
            // 
            this.employee_viewTableAdapter.ClearBeforeFill = true;
            // 
            // medicalServicesTableAdapter
            // 
            this.medicalServicesTableAdapter.ClearBeforeFill = true;
            // 
            // visits_viewBindingSource
            // 
            this.visits_viewBindingSource.DataMember = "Visits_view";
            this.visits_viewBindingSource.DataSource = this.dataSet;
            // 
            // visits_viewTableAdapter
            // 
            this.visits_viewTableAdapter.ClearBeforeFill = true;
            // 
            // visits_viewDataGridView
            // 
            this.visits_viewDataGridView.AutoGenerateColumns = false;
            this.visits_viewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.visits_viewDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23});
            this.visits_viewDataGridView.DataSource = this.visits_viewBindingSource;
            this.visits_viewDataGridView.Location = new System.Drawing.Point(9, 338);
            this.visits_viewDataGridView.Name = "visits_viewDataGridView";
            this.visits_viewDataGridView.Size = new System.Drawing.Size(761, 284);
            this.visits_viewDataGridView.TabIndex = 22;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Imię lekarza";
            this.dataGridViewTextBoxColumn12.HeaderText = "Imię lekarza";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Nazwisko Lekarza";
            this.dataGridViewTextBoxColumn16.HeaderText = "Nazwisko Lekarza";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "Specjalista";
            this.dataGridViewTextBoxColumn19.HeaderText = "Specjalista";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "Data";
            this.dataGridViewTextBoxColumn20.HeaderText = "Data";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "Imię pacjenta";
            this.dataGridViewTextBoxColumn21.HeaderText = "Imię pacjenta";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "Nazwisko pacjenta";
            this.dataGridViewTextBoxColumn22.HeaderText = "Nazwisko pacjenta";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "PESEL";
            this.dataGridViewTextBoxColumn23.HeaderText = "PESEL";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            // 
            // exterminations_viewBindingSource
            // 
            this.exterminations_viewBindingSource.DataMember = "Exterminations_view";
            this.exterminations_viewBindingSource.DataSource = this.dataSet;
            // 
            // exterminations_viewTableAdapter
            // 
            this.exterminations_viewTableAdapter.ClearBeforeFill = true;
            // 
            // exterminations_viewDataGridView
            // 
            this.exterminations_viewDataGridView.AutoGenerateColumns = false;
            this.exterminations_viewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.exterminations_viewDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn24,
            this.dataGridViewTextBoxColumn25,
            this.dataGridViewTextBoxColumn26,
            this.dataGridViewTextBoxColumn27,
            this.dataGridViewTextBoxColumn28});
            this.exterminations_viewDataGridView.DataSource = this.exterminations_viewBindingSource;
            this.exterminations_viewDataGridView.Location = new System.Drawing.Point(9, 30);
            this.exterminations_viewDataGridView.Name = "exterminations_viewDataGridView";
            this.exterminations_viewDataGridView.Size = new System.Drawing.Size(761, 284);
            this.exterminations_viewDataGridView.TabIndex = 22;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "Imię";
            this.dataGridViewTextBoxColumn24.HeaderText = "Imię";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "Nazwisko";
            this.dataGridViewTextBoxColumn25.HeaderText = "Nazwisko";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.DataPropertyName = "PESEL";
            this.dataGridViewTextBoxColumn26.HeaderText = "PESEL";
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.DataPropertyName = "Usługa";
            this.dataGridViewTextBoxColumn27.HeaderText = "Usługa";
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            // 
            // dataGridViewTextBoxColumn28
            // 
            this.dataGridViewTextBoxColumn28.DataPropertyName = "Data";
            this.dataGridViewTextBoxColumn28.HeaderText = "Data";
            this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(9, 14);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(77, 13);
            this.label31.TabIndex = 23;
            this.label31.Text = "Terminy usług:";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(6, 322);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(73, 13);
            this.label32.TabIndex = 24;
            this.label32.Text = "Terminy wizyt:";
            // 
            // MainClinicWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1205, 716);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.labelLoginName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.tabControl);
            this.Name = "MainClinicWindow";
            this.Text = "Okno główne";
            this.Load += new System.EventHandler(this.MainClinicWindow_Load);
            this.tabControl.ResumeLayout(false);
            this.tabSchedule.ResumeLayout(false);
            this.tabSchedule.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.tabPatients.ResumeLayout(false);
            this.tabPatients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patients_viewDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patients_viewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            this.tabVistis.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabServices.ResumeLayout(false);
            this.tabServices.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabAdministration.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.medicalServicesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalServicesBindingSource)).EndInit();
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.employee_viewDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_viewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visits_viewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visits_viewDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exterminations_viewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exterminations_viewDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabSchedule;
        private System.Windows.Forms.TabPage tabPatients;
        private System.Windows.Forms.TabPage tabVistis;
        private System.Windows.Forms.TabPage tabServices;
        private System.Windows.Forms.TabPage tabAdministration;
        private System.Windows.Forms.Button buttonSaveSchedule;
        private System.Windows.Forms.Label labelLoginName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox checkBoxShowArchives;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonDeletePatient;
        private System.Windows.Forms.Button buttonEditPatient;
        private System.Windows.Forms.Button buttonAddPatient;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPatientPesel;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxVisitDoctor;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBoxVisitPesel;
        private System.Windows.Forms.Button buttonSaveVisit;
        private System.Windows.Forms.TextBox textBoxVisitCode;
        private System.Windows.Forms.TextBox textBoxVisitDescription;
        private System.Windows.Forms.Button buttonMedicines;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBoxArchivMedicines;
        private System.Windows.Forms.TextBox textBoxVisitArchivCode;
        private System.Windows.Forms.TextBox textBoxVisitArchiveDescription;
        private System.Windows.Forms.DateTimePicker dateTimePickerVisitDate;
        private System.Windows.Forms.Button buttonSaveExamination;
        private System.Windows.Forms.TextBox textBoxServicesDescription;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox textBoxServicesCity;
        private System.Windows.Forms.TextBox textBoxServicesPhoneNo;
        private System.Windows.Forms.TextBox textBoxServicesPostalCode;
        private System.Windows.Forms.TextBox textBoxServicesStreet;
        private System.Windows.Forms.TextBox textBoxServicesStreetNo;
        private System.Windows.Forms.TextBox textBoxServicesFirstName;
        private System.Windows.Forms.TextBox textBoxServicesLastName;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox checkBoxServicesNFZ;
        private System.Windows.Forms.DateTimePicker dateTimePickerServicesDate;
        private System.Windows.Forms.TextBox textBoxServicesAmount;
        private System.Windows.Forms.TextBox textBoxServicesPesel;
        private System.Windows.Forms.ComboBox comboBoxServicesServiceName;
        private System.Windows.Forms.TextBox textBoxServicesDoctor;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button buttonAddService;
        private System.Windows.Forms.TextBox textBoxAdministrationServicePrice;
        private System.Windows.Forms.TextBox textBoxAdministrationServiceDescription;
        private System.Windows.Forms.TextBox textBoxAdministrationServiceName;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button buttonEditService;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button buttonDeleteEmployee;
        private System.Windows.Forms.Button buttonAddEmployee;
        private System.Windows.Forms.Button buttonEditEployee;
        private DataSet dataSet;
        private System.Windows.Forms.BindingSource patients_viewBindingSource;
        private DataSetTableAdapters.Patients_viewTableAdapter patients_viewTableAdapter;
        private DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView patients_viewDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.BindingSource employee_viewBindingSource;
        private DataSetTableAdapters.Employee_viewTableAdapter employee_viewTableAdapter;
        private System.Windows.Forms.DataGridView employee_viewDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.BindingSource medicalServicesBindingSource;
        private DataSetTableAdapters.MedicalServicesTableAdapter medicalServicesTableAdapter;
        private System.Windows.Forms.DataGridView medicalServicesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Messaging.MessageQueue messageQueue1;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBoxSchedulerHour;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox textBoxSchedulerLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxSchedulerService;
        private System.Windows.Forms.TextBox textBoxSchedulerAddress;
        private System.Windows.Forms.ComboBox comboBoxSchedulerDoctor;
        private System.Windows.Forms.RadioButton radioButtonService;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButtonVisit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSchedulerFirstName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxSchedulerPesel;
        private System.Windows.Forms.BindingSource visits_viewBindingSource;
        private DataSetTableAdapters.Visits_viewTableAdapter visits_viewTableAdapter;
        private System.Windows.Forms.DataGridView visits_viewDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.BindingSource exterminations_viewBindingSource;
        private DataSetTableAdapters.Exterminations_viewTableAdapter exterminations_viewTableAdapter;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.DataGridView exterminations_viewDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
    }
}

