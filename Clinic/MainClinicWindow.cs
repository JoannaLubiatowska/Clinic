using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic
{
    public partial class MainClinicWindow : Form
    {
        public MainClinicWindow()
        {
            InitializeComponent();
        }

        private void buttonAddService_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy na pewno chcesz dodać usługę?", "Dodawanie usług", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //do something
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void buttonEditService_Click(object sender, EventArgs e)
        {

        }

        private void buttonDeleteEmployee_Click(object sender, EventArgs e)
        {

        }

        private void buttonEditEployee_Click(object sender, EventArgs e)
        {
            if (openNextWindow("EmployeeForm"))
            {
                EmployeeForm employeeWindow = new EmployeeForm();
                employeeWindow.Show();
            }
        }

        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            if (openNextWindow("EmployeeForm"))
            {
                EmployeeForm employeeWindow = new EmployeeForm();
                employeeWindow.Show();
            }
        }

        private void buttonSaveExamination_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Zapisano pomyślnie.");
        }

        private void buttonMedicines_Click(object sender, EventArgs e)
        {
            if (openNextWindow("MedicinesForm"))
            {
                MedicinesForm medicinesWindow = new MedicinesForm();
                medicinesWindow.Show();
            }
        }

        private void buttonSaveVisit_Click(object sender, EventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddPatient_Click(object sender, EventArgs e)
        {
            if (openNextWindow("PatientForm"))
            {
                PatientForm patientWindow = new PatientForm();
                patientWindow.Show();
            }
        }

        private void buttonEditPatient_Click(object sender, EventArgs e)
        {
            if (openNextWindow("PatientForm"))
            {
                PatientForm patientWindow = new PatientForm();
                patientWindow.Show();
            }
        }

        private void buttonDeletePatient_Click(object sender, EventArgs e)
        {

        }

        private void buttonSaveSchedule_Click(object sender, EventArgs e)
        {

        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {

        }
        private Boolean openNextWindow(string windowName)
        {
            bool IsOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == windowName)
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void MainClinicWindow_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet.Exterminations_view' table. You can move, or remove it, as needed.
            this.exterminations_viewTableAdapter.Fill(this.dataSet.Exterminations_view);
            // TODO: This line of code loads data into the 'dataSet.Visits_view' table. You can move, or remove it, as needed.
            this.visits_viewTableAdapter.Fill(this.dataSet.Visits_view);
            // TODO: This line of code loads data into the 'dataSet.MedicalServices' table. You can move, or remove it, as needed.
            this.medicalServicesTableAdapter.Fill(this.dataSet.MedicalServices);
            // TODO: This line of code loads data into the 'dataSet.Employee_view' table. You can move, or remove it, as needed.
            this.employee_viewTableAdapter.Fill(this.dataSet.Employee_view);
            // TODO: This line of code loads data into the 'dataSet.Employee_view' table. You can move, or remove it, as needed.
            this.employee_viewTableAdapter.Fill(this.dataSet.Employee_view);
            // TODO: This line of code loads data into the 'dataSet.Patients_view' table. You can move, or remove it, as needed.
            this.patients_viewTableAdapter.Fill(this.dataSet.Patients_view);

        }
    }
}
