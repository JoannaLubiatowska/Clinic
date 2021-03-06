﻿using System;
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
    public partial class MedicinesForm : Form
    {
        public MedicinesForm()
        {
            InitializeComponent();
        }

        private void buttonSaveMedicines_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Zapisano pomyślnie.");
        }

        private void buttonGenetatePrescription_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy wygenerować receptę?", "Generowanie recepty", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //do something
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void MedicinesForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet.Medicines_view' table. You can move, or remove it, as needed.
            this.medicines_viewTableAdapter.Fill(this.dataSet.Medicines_view);

        }
    }
}
