namespace NMIMS_Hospital_Management
{
    partial class PatientDet_UserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Patient_Id = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Add_New_PatientDet = new System.Windows.Forms.Button();
            this.DeletePAtDet_TabButton = new System.Windows.Forms.Button();
            this.PatDetClear_TabButton = new System.Windows.Forms.Button();
            this.Searh_button = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(61, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(758, 198);
            this.dataGridView1.TabIndex = 1;
            // 
            // Patient_Id
            // 
            this.Patient_Id.AutoSize = true;
            this.Patient_Id.Location = new System.Drawing.Point(86, 352);
            this.Patient_Id.Name = "Patient_Id";
            this.Patient_Id.Size = new System.Drawing.Size(82, 20);
            this.Patient_Id.TabIndex = 2;
            this.Patient_Id.Text = "Patient_Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 461);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Patient_Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(511, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Phone No.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(511, 461);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Blood Group";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(90, 375);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(90, 484);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 26);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(515, 484);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 26);
            this.textBox3.TabIndex = 8;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(515, 375);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 26);
            this.textBox4.TabIndex = 9;
            // 
            // Add_New_PatientDet
            // 
            this.Add_New_PatientDet.BackColor = System.Drawing.Color.Transparent;
            this.Add_New_PatientDet.Location = new System.Drawing.Point(90, 269);
            this.Add_New_PatientDet.Name = "Add_New_PatientDet";
            this.Add_New_PatientDet.Size = new System.Drawing.Size(100, 34);
            this.Add_New_PatientDet.TabIndex = 10;
            this.Add_New_PatientDet.Text = "Add New";
            this.Add_New_PatientDet.UseVisualStyleBackColor = false;
            this.Add_New_PatientDet.Click += new System.EventHandler(this.Add_New_PatientDet_Click);
            // 
            // DeletePAtDet_TabButton
            // 
            this.DeletePAtDet_TabButton.Location = new System.Drawing.Point(247, 269);
            this.DeletePAtDet_TabButton.Name = "DeletePAtDet_TabButton";
            this.DeletePAtDet_TabButton.Size = new System.Drawing.Size(91, 34);
            this.DeletePAtDet_TabButton.TabIndex = 11;
            this.DeletePAtDet_TabButton.Text = "Delete";
            this.DeletePAtDet_TabButton.UseVisualStyleBackColor = true;
            this.DeletePAtDet_TabButton.Click += new System.EventHandler(this.DeletePAtDet_TabButton_Click);
            // 
            // PatDetClear_TabButton
            // 
            this.PatDetClear_TabButton.BackColor = System.Drawing.Color.Transparent;
            this.PatDetClear_TabButton.Location = new System.Drawing.Point(401, 269);
            this.PatDetClear_TabButton.Name = "PatDetClear_TabButton";
            this.PatDetClear_TabButton.Size = new System.Drawing.Size(100, 34);
            this.PatDetClear_TabButton.TabIndex = 12;
            this.PatDetClear_TabButton.Text = "Clear";
            this.PatDetClear_TabButton.UseVisualStyleBackColor = false;
            this.PatDetClear_TabButton.Click += new System.EventHandler(this.PatDetClear_TabButton_Click);
            // 
            // Searh_button
            // 
            this.Searh_button.BackColor = System.Drawing.Color.Transparent;
            this.Searh_button.Location = new System.Drawing.Point(543, 269);
            this.Searh_button.Name = "Searh_button";
            this.Searh_button.Size = new System.Drawing.Size(100, 34);
            this.Searh_button.TabIndex = 13;
            this.Searh_button.Text = "Search";
            this.Searh_button.UseVisualStyleBackColor = false;
            this.Searh_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(543, 310);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(147, 26);
            this.SearchTextBox.TabIndex = 14;
            // 
            // PatientDet_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.Searh_button);
            this.Controls.Add(this.PatDetClear_TabButton);
            this.Controls.Add(this.DeletePAtDet_TabButton);
            this.Controls.Add(this.Add_New_PatientDet);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Patient_Id);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PatientDet_UserControl";
            this.Size = new System.Drawing.Size(872, 670);
            this.Load += new System.EventHandler(this.PatientDet_UserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Patient_Id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button Add_New_PatientDet;
        private System.Windows.Forms.Button DeletePAtDet_TabButton;
        private System.Windows.Forms.Button PatDetClear_TabButton;
        private System.Windows.Forms.Button Searh_button;
        private System.Windows.Forms.TextBox SearchTextBox;
    }
}
