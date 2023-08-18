namespace NMIMS_Hospital_Management
{
    partial class Form2Testing
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
            this.PatientAssignedWardButton = new System.Windows.Forms.Button();
            this.NurseTakeCares_Button = new System.Windows.Forms.Button();
            this.ContentPannel_ward = new System.Windows.Forms.Panel();
            this.contentpannelWard2 = new System.Windows.Forms.Panel();
            this.PatientIniDet_TabButton = new System.Windows.Forms.Button();
            this.ContentPannel_ward.SuspendLayout();
            this.SuspendLayout();
            // 
            // PatientAssignedWardButton
            // 
            this.PatientAssignedWardButton.BackColor = System.Drawing.Color.Azure;
            this.PatientAssignedWardButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PatientAssignedWardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PatientAssignedWardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientAssignedWardButton.Location = new System.Drawing.Point(0, 245);
            this.PatientAssignedWardButton.Name = "PatientAssignedWardButton";
            this.PatientAssignedWardButton.Size = new System.Drawing.Size(272, 126);
            this.PatientAssignedWardButton.TabIndex = 1;
            this.PatientAssignedWardButton.Text = "Patient Ward Details";
            this.PatientAssignedWardButton.UseVisualStyleBackColor = false;
            this.PatientAssignedWardButton.Click += new System.EventHandler(this.PatientAssignedWardButton_Click);
            // 
            // NurseTakeCares_Button
            // 
            this.NurseTakeCares_Button.BackColor = System.Drawing.Color.Azure;
            this.NurseTakeCares_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NurseTakeCares_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NurseTakeCares_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NurseTakeCares_Button.Location = new System.Drawing.Point(0, 539);
            this.NurseTakeCares_Button.Name = "NurseTakeCares_Button";
            this.NurseTakeCares_Button.Size = new System.Drawing.Size(272, 128);
            this.NurseTakeCares_Button.TabIndex = 2;
            this.NurseTakeCares_Button.Text = "Patients\' Nurse and Doctors details";
            this.NurseTakeCares_Button.UseVisualStyleBackColor = false;
            this.NurseTakeCares_Button.Click += new System.EventHandler(this.NurseTakeCares_Button_Click);
            // 
            // ContentPannel_ward
            // 
            this.ContentPannel_ward.BackColor = System.Drawing.Color.LightCyan;
            this.ContentPannel_ward.Controls.Add(this.PatientIniDet_TabButton);
            this.ContentPannel_ward.Controls.Add(this.PatientAssignedWardButton);
            this.ContentPannel_ward.Controls.Add(this.NurseTakeCares_Button);
            this.ContentPannel_ward.Dock = System.Windows.Forms.DockStyle.Left;
            this.ContentPannel_ward.Location = new System.Drawing.Point(0, 0);
            this.ContentPannel_ward.Name = "ContentPannel_ward";
            this.ContentPannel_ward.Size = new System.Drawing.Size(284, 670);
            this.ContentPannel_ward.TabIndex = 3;
            // 
            // contentpannelWard2
            // 
            this.contentpannelWard2.BackgroundImage = global::NMIMS_Hospital_Management.Properties.Resources.admit_pic;
            this.contentpannelWard2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.contentpannelWard2.Dock = System.Windows.Forms.DockStyle.Right;
            this.contentpannelWard2.Location = new System.Drawing.Point(290, 0);
            this.contentpannelWard2.Name = "contentpannelWard2";
            this.contentpannelWard2.Size = new System.Drawing.Size(872, 670);
            this.contentpannelWard2.TabIndex = 4;
            // 
            // PatientIniDet_TabButton
            // 
            this.PatientIniDet_TabButton.BackColor = System.Drawing.Color.Azure;
            this.PatientIniDet_TabButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PatientIniDet_TabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PatientIniDet_TabButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientIniDet_TabButton.Location = new System.Drawing.Point(0, 12);
            this.PatientIniDet_TabButton.Name = "PatientIniDet_TabButton";
            this.PatientIniDet_TabButton.Size = new System.Drawing.Size(272, 126);
            this.PatientIniDet_TabButton.TabIndex = 3;
            this.PatientIniDet_TabButton.Text = "Patient Details";
            this.PatientIniDet_TabButton.UseVisualStyleBackColor = false;
            this.PatientIniDet_TabButton.Click += new System.EventHandler(this.PatientIniDet_TabButton_Click);
            // 
            // Form2Testing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1162, 670);
            this.Controls.Add(this.contentpannelWard2);
            this.Controls.Add(this.ContentPannel_ward);
            this.Name = "Form2Testing";
            this.Text = "Amitted Details";
            this.ContentPannel_ward.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PatientAssignedWardButton;
        private System.Windows.Forms.Button NurseTakeCares_Button;
        private System.Windows.Forms.Panel ContentPannel_ward;
        private System.Windows.Forms.Panel contentpannelWard2;
        private System.Windows.Forms.Button PatientIniDet_TabButton;
    }
}