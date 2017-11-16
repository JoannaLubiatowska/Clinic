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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedicinesForm));
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.textBox25 = new System.Windows.Forms.TextBox();
            this.textBox26 = new System.Windows.Forms.TextBox();
            this.textBox27 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.buttonSaveMedicines = new System.Windows.Forms.Button();
            this.buttonGenetatePrescription = new System.Windows.Forms.Button();
            this.dataSet = new Clinic.DataSet();
            this.medicines_viewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicines_viewTableAdapter = new Clinic.DataSetTableAdapters.Medicines_viewTableAdapter();
            this.tableAdapterManager = new Clinic.DataSetTableAdapters.TableAdapterManager();
            this.medicines_viewBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.medicines_viewBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.medicines_viewDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicines_viewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicines_viewBindingNavigator)).BeginInit();
            this.medicines_viewBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicines_viewDataGridView)).BeginInit();
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
            label28.Size = new System.Drawing.Size(82, 13);
            label28.TabIndex = 21;
            label28.Text = "Numer telefonu:";
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
            this.groupBox6.Controls.Add(this.textBox21);
            this.groupBox6.Controls.Add(this.textBox22);
            this.groupBox6.Controls.Add(this.textBox23);
            this.groupBox6.Controls.Add(this.textBox24);
            this.groupBox6.Controls.Add(this.textBox25);
            this.groupBox6.Controls.Add(this.textBox26);
            this.groupBox6.Controls.Add(this.textBox27);
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
            // textBox21
            // 
            this.textBox21.Enabled = false;
            this.textBox21.Location = new System.Drawing.Point(174, 149);
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(242, 20);
            this.textBox21.TabIndex = 29;
            // 
            // textBox22
            // 
            this.textBox22.Enabled = false;
            this.textBox22.Location = new System.Drawing.Point(174, 175);
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(242, 20);
            this.textBox22.TabIndex = 28;
            // 
            // textBox23
            // 
            this.textBox23.Enabled = false;
            this.textBox23.Location = new System.Drawing.Point(174, 123);
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new System.Drawing.Size(242, 20);
            this.textBox23.TabIndex = 27;
            // 
            // textBox24
            // 
            this.textBox24.Enabled = false;
            this.textBox24.Location = new System.Drawing.Point(174, 71);
            this.textBox24.Name = "textBox24";
            this.textBox24.Size = new System.Drawing.Size(242, 20);
            this.textBox24.TabIndex = 26;
            // 
            // textBox25
            // 
            this.textBox25.Enabled = false;
            this.textBox25.Location = new System.Drawing.Point(174, 97);
            this.textBox25.Name = "textBox25";
            this.textBox25.Size = new System.Drawing.Size(242, 20);
            this.textBox25.TabIndex = 25;
            // 
            // textBox26
            // 
            this.textBox26.Enabled = false;
            this.textBox26.Location = new System.Drawing.Point(174, 19);
            this.textBox26.Name = "textBox26";
            this.textBox26.Size = new System.Drawing.Size(242, 20);
            this.textBox26.TabIndex = 24;
            // 
            // textBox27
            // 
            this.textBox27.Enabled = false;
            this.textBox27.Location = new System.Drawing.Point(174, 45);
            this.textBox27.Name = "textBox27";
            this.textBox27.Size = new System.Drawing.Size(242, 20);
            this.textBox27.TabIndex = 23;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.medicines_viewDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(12, 229);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(430, 261);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Leki przyjmowane przez pacjenta";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox3);
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(174, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(242, 20);
            this.textBox1.TabIndex = 32;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(174, 66);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(242, 20);
            this.textBox2.TabIndex = 31;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(174, 14);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(242, 20);
            this.textBox3.TabIndex = 30;
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
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medicines_viewBindingSource
            // 
            this.medicines_viewBindingSource.DataMember = "Medicines_view";
            this.medicines_viewBindingSource.DataSource = this.dataSet;
            // 
            // medicines_viewTableAdapter
            // 
            this.medicines_viewTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = Clinic.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // medicines_viewBindingNavigator
            // 
            this.medicines_viewBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.medicines_viewBindingNavigator.BindingSource = this.medicines_viewBindingSource;
            this.medicines_viewBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.medicines_viewBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.medicines_viewBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.medicines_viewBindingNavigatorSaveItem});
            this.medicines_viewBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.medicines_viewBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.medicines_viewBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.medicines_viewBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.medicines_viewBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.medicines_viewBindingNavigator.Name = "medicines_viewBindingNavigator";
            this.medicines_viewBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.medicines_viewBindingNavigator.Size = new System.Drawing.Size(452, 25);
            this.medicines_viewBindingNavigator.TabIndex = 54;
            this.medicines_viewBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // medicines_viewBindingNavigatorSaveItem
            // 
            this.medicines_viewBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.medicines_viewBindingNavigatorSaveItem.Enabled = false;
            this.medicines_viewBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("medicines_viewBindingNavigatorSaveItem.Image")));
            this.medicines_viewBindingNavigatorSaveItem.Name = "medicines_viewBindingNavigatorSaveItem";
            this.medicines_viewBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 20);
            this.medicines_viewBindingNavigatorSaveItem.Text = "Save Data";
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
            this.medicines_viewDataGridView.Size = new System.Drawing.Size(406, 227);
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
            // MedicinesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 631);
            this.Controls.Add(this.medicines_viewBindingNavigator);
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
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicines_viewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicines_viewBindingNavigator)).EndInit();
            this.medicines_viewBindingNavigator.ResumeLayout(false);
            this.medicines_viewBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicines_viewDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox textBox21;
        private System.Windows.Forms.TextBox textBox22;
        private System.Windows.Forms.TextBox textBox23;
        private System.Windows.Forms.TextBox textBox24;
        private System.Windows.Forms.TextBox textBox25;
        private System.Windows.Forms.TextBox textBox26;
        private System.Windows.Forms.TextBox textBox27;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button buttonSaveMedicines;
        private System.Windows.Forms.Button buttonGenetatePrescription;
        private DataSet dataSet;
        private System.Windows.Forms.BindingSource medicines_viewBindingSource;
        private DataSetTableAdapters.Medicines_viewTableAdapter medicines_viewTableAdapter;
        private DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator medicines_viewBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton medicines_viewBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView medicines_viewDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}