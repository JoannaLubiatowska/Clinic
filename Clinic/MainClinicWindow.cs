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

        }

        private void buttonDeleteService_Click(object sender, EventArgs e)
        {

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
    }
}
