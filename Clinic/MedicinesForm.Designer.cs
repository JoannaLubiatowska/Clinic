namespace Clinic
{
    partial class MedicinesForm
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
            System.Windows.Forms.Label label14;
            System.Windows.Forms.Label label23;
            System.Windows.Forms.Label label24;
            System.Windows.Forms.Label label25;
            System.Windows.Forms.Label label26;
            System.Windows.Forms.Label label27;
            System.Windows.Forms.Label label28;
            System.Windows.Forms.Label drugDosageLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.textBoxMedicinesCity = new System.Windows.Forms.TextBox();
            this.textBoxMedicinesPesel = new System.Windows.Forms.TextBox();
            this.textBoxMedicinesPostalCode = new System.Windows.Forms.TextBox();
            this.textBoxMedicinesStreet = new System.Windows.Forms.TextBox();
            this.textBoxMedicinesStreetNo = new System.Windows.Forms.TextBox();
            this.textBoxMedicinesFirstName = new System.Windows.Forms.TextBox();
            this.textBoxMedicinesLastName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.medicines_viewDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicines_viewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new Clinic.DataSet();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxMedicinesAmount = new System.Windows.Forms.TextBox();
            this.textBoxMedicinesDrugDosage = new System.Windows.Forms.TextBox();
            this.textBoxMedicinesName = new System.Windows.Forms.TextBox();
            this.buttonSaveMedicines = new System.Windows.Forms.Button();
            this.buttonGenetatePrescription = new System.Windows.Forms.Button();
            this.medicines_viewTableAdapter = new Clinic.DataSetTableAdapters.Medicines_viewTableAdapter();
            this.tableAdapterManager = new Clinic.DataSetTableAdapters.TableAdapterManager();
            this.buttonAddToPrescription = new System.Windows.Forms.Button();
            label14 = new System.Windows.Forms.Label();
            label23 = new System.Windows.Forms.Label();
            label24 = new System.Windows.Forms.Label();
            label25 = new System.Windows.Forms.Label();
            label26 = new System.Windows.Forms.Label();
            label27 = new System.Windows.Forms.Label();
            label28 = new System.Windows.Forms.Label();
            drugDosageLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            this.groupBox6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicines_viewDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicines_viewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new System.Drawing.Point(7, 22);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(29, 13);
            label14.TabIndex = 15;
            label14.Text = "Imię:";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new System.Drawing.Point(7, 48);
            label23.Name = "label23";
            label23.Size = new System.Drawing.Size(56, 13);
            label23.TabIndex = 16;
            label23.Text = "Nazwisko:";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new System.Drawing.Point(7, 74);
            label24.Name = "label24";
            label24.Size = new System.Drawing.Size(34, 13);
            label24.TabIndex = 17;
            label24.Text = "Ulica:";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new System.Drawing.Point(7, 100);
            label25.Name = "label25";
            label25.Size = new System.Drawing.Size(70, 13);
            label25.TabIndex = 18;
            label25.Text = "Numer domu:";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new System.Drawing.Point(7, 126);
            label26.Name = "label26";
            label26.Size = new System.Drawing.Size(77, 13);
            label26.TabIndex = 19;
            label26.Text = "Kod pocztowy:";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new System.Drawing.Point(7, 152);
            label27.Name = "label27";
            label27.Size = new System.Drawing.Size(41, 13);
            label27.TabIndex = 20;
            label27.Text = "Miasto:";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new System.Drawing.Point(7, 178);
            label28.Name = "label28";
            label28.Size = new System.Drawing.Size(44, 13);
            label28.TabIndex = 21;
            label28.Text = "PESEL:";
            // 
            // drugDosageLabel
            // 
            drugDosageLabel.AutoSize = true;
            drugDosageLabel.Location = new System.Drawing.Point(7, 73);
            drugDosageLabel.Name = "drugDosageLabel";
            drugDosageLabel.Size = new System.Drawing.Size(72, 13);
            drugDosageLabel.TabIndex = 8;
            drugDosageLabel.Text = "Dawkowanie:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(7, 21);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(43, 13);
            label2.TabIndex = 6;
            label2.Text = "Nazwa:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(7, 47);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(59, 13);
            label3.TabIndex = 7;
            label3.Text = "Gramatura:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.textBoxMedicinesCity);
            this.groupBox6.Controls.Add(this.textBoxMedicinesPesel);
            this.groupBox6.Controls.Add(this.textBoxMedicinesPostalCode);
            this.groupBox6.Controls.Add(this.textBoxMedicinesStreet);
            this.groupBox6.Controls.Add(this.textBoxMedicinesStreetNo);
            this.groupBox6.Controls.Add(this.textBoxMedicinesFirstName);
            this.groupBox6.Controls.Add(this.textBoxMedicinesLastName);
            this.groupBox6.Controls.Add(label14);
            this.groupBox6.Controls.Add(label23);
            this.groupBox6.Controls.Add(label24);
            this.groupBox6.Controls.Add(label25);
            this.groupBox6.Controls.Add(label26);
            this.groupBox6.Controls.Add(label27);
            this.groupBox6.Controls.Add(label28);
            this.groupBox6.Location = new System.Drawing.Point(12, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(430, 211);
            this.groupBox6.TabIndex = 23;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Dane pacjenta";
            // 
            // textBoxMedicinesCity
            // 
            this.textBoxMedicinesCity.Enabled = false;
            this.textBoxMedicinesCity.Location = new System.Drawing.Point(174, 149);
            this.textBoxMedicinesCity.Name = "textBoxMedicinesCity";
            this.textBoxMedicinesCity.Size = new System.Drawing.Size(242, 20);
            this.textBoxMedicinesCity.TabIndex = 29;
            this.textBoxMedicinesCity.Text = "Łódź";
            // 
            // textBoxMedicinesPesel
            // 
            this.textBoxMedicinesPesel.Enabled = false;
            this.textBoxMedicinesPesel.Location = new System.Drawing.Point(174, 175);
            this.textBoxMedicinesPesel.Name = "textBoxMedicinesPesel";
            this.textBoxMedicinesPesel.Size = new System.Drawing.Size(242, 20);
            this.textBoxMedicinesPesel.TabIndex = 28;
            this.textBoxMedicinesPesel.Text = "81012407518";
            // 
            // textBoxMedicinesPostalCode
            // 
            this.textBoxMedicinesPostalCode.Enabled = false;
            this.textBoxMedicinesPostalCode.Location = new System.Drawing.Point(174, 123);
            this.textBoxMedicinesPostalCode.Name = "textBoxMedicinesPostalCode";
            this.textBoxMedicinesPostalCode.Size = new System.Drawing.Size(242, 20);
            this.textBoxMedicinesPostalCode.TabIndex = 27;
            this.textBoxMedicinesPostalCode.Text = "90-200";
            // 
            // textBoxMedicinesStreet
            // 
            this.textBoxMedicinesStreet.Enabled = false;
            this.textBoxMedicinesStreet.Location = new System.Drawing.Point(174, 71);
            this.textBoxMedicinesStreet.Name = "textBoxMedicinesStreet";
            this.textBoxMedicinesStreet.Size = new System.Drawing.Size(242, 20);
            this.textBoxMedicinesStreet.TabIndex = 26;
            this.textBoxMedicinesStreet.Text = "Narutowicza";
            // 
            // textBoxMedicinesStreetNo
            // 
            this.textBoxMedicinesStreetNo.Enabled = false;
            this.textBoxMedicinesStreetNo.Location = new System.Drawing.Point(174, 97);
            this.textBoxMedicinesStreetNo.Name = "textBoxMedicinesStreetNo";
            this.textBoxMedicinesStreetNo.Size = new System.Drawing.Size(242, 20);
            this.textBoxMedicinesStreetNo.TabIndex = 25;
            this.textBoxMedicinesStreetNo.Text = "56/43";
            // 
            // textBoxMedicinesFirstName
            // 
            this.textBoxMedicinesFirstName.Enabled = false;
            this.textBoxMedicinesFirstName.Location = new System.Drawing.Point(174, 19);
            this.textBoxMedicinesFirstName.Name = "textBoxMedicinesFirstName";
            this.textBoxMedicinesFirstName.Size = new System.Drawing.Size(242, 20);
            this.textBoxMedicinesFirstName.TabIndex = 24;
            this.textBoxMedicinesFirstName.Text = "Tomasz";
            // 
            // textBoxMedicinesLastName
            // 
            this.textBoxMedicinesLastName.Enabled = false;
            this.textBoxMedicinesLastName.Location = new System.Drawing.Point(174, 45);
            this.textBoxMedicinesLastName.Name = "textBoxMedicinesLastName";
            this.textBoxMedicinesLastName.Size = new System.Drawing.Size(242, 20);
            this.textBoxMedicinesLastName.TabIndex = 23;
            this.textBoxMedicinesLastName.Text = "Szymański";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonAddToPrescription);
            this.groupBox1.Controls.Add(this.medicines_viewDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(12, 229);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(430, 261);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Leki przyjmowane przez pacjenta";
            // 
            // medicines_viewDataGridView
            // 
            this.medicines_viewDataGridView.AutoGenerateColumns = false;
            this.medicines_viewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.medicines_viewDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.medicines_viewDataGridView.DataSource = this.medicines_viewBindingSource;
            this.medicines_viewDataGridView.Location = new System.Drawing.Point(10, 19);
            this.medicines_viewDataGridView.Name = "medicines_viewDataGridView";
            this.medicines_viewDataGridView.Size = new System.Drawing.Size(406, 207);
            this.medicines_viewDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Nazwa";
            this.dataGridViewTextBoxColumn1.HeaderText = "Nazwa";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Dawkowanie";
            this.dataGridViewTextBoxColumn2.HeaderText = "Dawkowanie";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Gramatura";
            this.dataGridViewTextBoxColumn3.HeaderText = "Gramatura";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // medicines_viewBindingSource
            // 
            this.medicines_viewBindingSource.DataMember = "Medicines_view";
            this.medicines_viewBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxMedicinesAmount);
            this.groupBox2.Controls.Add(this.textBoxMedicinesDrugDosage);
            this.groupBox2.Controls.Add(this.textBoxMedicinesName);
            this.groupBox2.Controls.Add(drugDosageLabel);
            this.groupBox2.Controls.Add(label2);
            this.groupBox2.Controls.Add(label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 496);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(430, 98);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Przepisz nowy lek";
            // 
            // textBoxMedicinesAmount
            // 
            this.textBoxMedicinesAmount.Location = new System.Drawing.Point(174, 40);
            this.textBoxMedicinesAmount.Name = "textBoxMedicinesAmount";
            this.textBoxMedicinesAmount.Size = new System.Drawing.Size(242, 20);
            this.textBoxMedicinesAmount.TabIndex = 32;
            // 
            // textBoxMedicinesDrugDosage
            // 
            this.textBoxMedicinesDrugDosage.Location = new System.Drawing.Point(174, 66);
            this.textBoxMedicinesDrugDosage.Name = "textBoxMedicinesDrugDosage";
            this.textBoxMedicinesDrugDosage.Size = new System.Drawing.Size(242, 20);
            this.textBoxMedicinesDrugDosage.TabIndex = 31;
            // 
            // textBoxMedicinesName
            // 
            this.textBoxMedicinesName.Location = new System.Drawing.Point(174, 14);
            this.textBoxMedicinesName.Name = "textBoxMedicinesName";
            this.textBoxMedicinesName.Size = new System.Drawing.Size(242, 20);
            this.textBoxMedicinesName.TabIndex = 30;
            // 
            // buttonSaveMedicines
            // 
            this.buttonSaveMedicines.Location = new System.Drawing.Point(168, 599);
            this.buttonSaveMedicines.Name = "buttonSaveMedicines";
            this.buttonSaveMedicines.Size = new System.Drawing.Size(134, 23);
            this.buttonSaveMedicines.TabIndex = 53;
            this.buttonSaveMedicines.Text = "Zapisz";
            this.buttonSaveMedicines.UseVisualStyleBackColor = true;
            this.buttonSaveMedicines.Click += new System.EventHandler(this.buttonSaveMedicines_Click);
            // 
            // buttonGenetatePrescription
            // 
            this.buttonGenetatePrescription.Location = new System.Drawing.Point(308, 600);
            this.buttonGenetatePrescription.Name = "buttonGenetatePrescription";
            this.buttonGenetatePrescription.Size = new System.Drawing.Size(134, 23);
            this.buttonGenetatePrescription.TabIndex = 52;
            this.buttonGenetatePrescription.Text = "Generuj receptę";
            this.buttonGenetatePrescription.UseVisualStyleBackColor = true;
            this.buttonGenetatePrescription.Click += new System.EventHandler(this.buttonGenetatePrescription_Click);
            // 
            // medicines_viewTableAdapter
            // 
            this.medicines_viewTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.MedicalServicesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Clinic.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // buttonAddToPrescription
            // 
            this.buttonAddToPrescription.Location = new System.Drawing.Point(282, 232);
            this.buttonAddToPrescription.Name = "buttonAddToPrescription";
            this.buttonAddToPrescription.Size = new System.Drawing.Size(134, 23);
            this.buttonAddToPrescription.TabIndex = 54;
            this.buttonAddToPrescription.Text = "Dodaj do recepty";
            this.buttonAddToPrescription.UseVisualStyleBackColor = true;
            // 
            // MedicinesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 631);
            this.Controls.Add(this.buttonSaveMedicines);
            this.Controls.Add(this.buttonGenetatePrescription);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox6);
            this.Name = "MedicinesForm";
            this.Text = "Leki";
            this.Load += new System.EventHandler(this.MedicinesForm_Load);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.medicines_viewDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicines_viewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox textBoxMedicinesCity;
        private System.Windows.Forms.TextBox textBoxMedicinesPesel;
        private System.Windows.Forms.TextBox textBoxMedicinesPostalCode;
        private System.Windows.Forms.TextBox textBoxMedicinesStreet;
        private System.Windows.Forms.TextBox textBoxMedicinesStreetNo;
        private System.Windows.Forms.TextBox textBoxMedicinesFirstName;
        private System.Windows.Forms.TextBox textBoxMedicinesLastName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxMedicinesAmount;
        private System.Windows.Forms.TextBox textBoxMedicinesDrugDosage;
        private System.Windows.Forms.TextBox textBoxMedicinesName;
        private System.Windows.Forms.Button buttonSaveMedicines;
        private System.Windows.Forms.Button buttonGenetatePrescription;
        private DataSet dataSet;
        private System.Windows.Forms.BindingSource medicines_viewBindingSource;
        private DataSetTableAdapters.Medicines_viewTableAdapter medicines_viewTableAdapter;
        private DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView medicines_viewDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button buttonAddToPrescription;
    }
}