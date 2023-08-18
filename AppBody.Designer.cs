namespace NMIMS_Hospital_Management
{
    partial class AppBody
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
            this.Log_In_Timer = new System.Windows.Forms.Timer(this.components);
            this.SlidingPannel_TImer = new System.Windows.Forms.Timer(this.components);
            this.ContentPannel = new System.Windows.Forms.Panel();
            this.SlidingPannel = new System.Windows.Forms.Panel();
            this.About_TabButton = new System.Windows.Forms.Button();
            this.Setting_TabButton = new System.Windows.Forms.Button();
            this.BillingTransactione_TabButton = new System.Windows.Forms.Button();
            this.MedicineTransaction_TabButton = new System.Windows.Forms.Button();
            this.NurseDoctor_TabButton = new System.Windows.Forms.Button();
            this.Medical_Record_TabButton = new System.Windows.Forms.Button();
            this.Admitted_TabButton = new System.Windows.Forms.Button();
            this.SliddingPannel_ToggleButton = new System.Windows.Forms.Button();
            this.SlidingPannel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Log_In_Timer
            // 
            this.Log_In_Timer.Interval = 20;
            this.Log_In_Timer.Tick += new System.EventHandler(this.Log_In_Timer_Tick);
            // 
            // SlidingPannel_TImer
            // 
            this.SlidingPannel_TImer.Interval = 20;
            this.SlidingPannel_TImer.Tick += new System.EventHandler(this.SlidingPannel_TImer_Tick_1);
            // 
            // ContentPannel
            // 
            this.ContentPannel.BackColor = System.Drawing.Color.Transparent;
            this.ContentPannel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ContentPannel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ContentPannel.Location = new System.Drawing.Point(300, 0);
            this.ContentPannel.Name = "ContentPannel";
            this.ContentPannel.Size = new System.Drawing.Size(1106, 744);
            this.ContentPannel.TabIndex = 1;
            this.ContentPannel.Paint += new System.Windows.Forms.PaintEventHandler(this.ContentPannel_Paint);
            // 
            // SlidingPannel
            // 
            this.SlidingPannel.BackColor = System.Drawing.Color.LightCyan;
            this.SlidingPannel.BackgroundImage = global::NMIMS_Hospital_Management.Properties.Resources.images;
            this.SlidingPannel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SlidingPannel.Controls.Add(this.About_TabButton);
            this.SlidingPannel.Controls.Add(this.Setting_TabButton);
            this.SlidingPannel.Controls.Add(this.BillingTransactione_TabButton);
            this.SlidingPannel.Controls.Add(this.MedicineTransaction_TabButton);
            this.SlidingPannel.Controls.Add(this.NurseDoctor_TabButton);
            this.SlidingPannel.Controls.Add(this.Medical_Record_TabButton);
            this.SlidingPannel.Controls.Add(this.Admitted_TabButton);
            this.SlidingPannel.Controls.Add(this.SliddingPannel_ToggleButton);
            this.SlidingPannel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SlidingPannel.Location = new System.Drawing.Point(0, 0);
            this.SlidingPannel.Name = "SlidingPannel";
            this.SlidingPannel.Size = new System.Drawing.Size(300, 744);
            this.SlidingPannel.TabIndex = 0;
            this.SlidingPannel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // About_TabButton
            // 
            this.About_TabButton.BackColor = System.Drawing.Color.Transparent;
            this.About_TabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.About_TabButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.About_TabButton.Image = global::NMIMS_Hospital_Management.Properties.Resources.new_about_final;
            this.About_TabButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.About_TabButton.Location = new System.Drawing.Point(0, 461);
            this.About_TabButton.Name = "About_TabButton";
            this.About_TabButton.Padding = new System.Windows.Forms.Padding(13, 0, 0, 3);
            this.About_TabButton.Size = new System.Drawing.Size(300, 70);
            this.About_TabButton.TabIndex = 8;
            this.About_TabButton.Text = "About";
            this.About_TabButton.UseVisualStyleBackColor = false;
            this.About_TabButton.Click += new System.EventHandler(this.About_TabButton_Click);
            // 
            // Setting_TabButton
            // 
            this.Setting_TabButton.BackColor = System.Drawing.Color.Transparent;
            this.Setting_TabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Setting_TabButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Setting_TabButton.Image = global::NMIMS_Hospital_Management.Properties.Resources.Setting_final;
            this.Setting_TabButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Setting_TabButton.Location = new System.Drawing.Point(0, 395);
            this.Setting_TabButton.Name = "Setting_TabButton";
            this.Setting_TabButton.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.Setting_TabButton.Size = new System.Drawing.Size(300, 70);
            this.Setting_TabButton.TabIndex = 7;
            this.Setting_TabButton.Text = "Setting";
            this.Setting_TabButton.UseVisualStyleBackColor = false;
            this.Setting_TabButton.Click += new System.EventHandler(this.Setting_TabButton_Click);
            // 
            // BillingTransactione_TabButton
            // 
            this.BillingTransactione_TabButton.BackColor = System.Drawing.Color.Transparent;
            this.BillingTransactione_TabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BillingTransactione_TabButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillingTransactione_TabButton.Image = global::NMIMS_Hospital_Management.Properties.Resources.bill_image_final;
            this.BillingTransactione_TabButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BillingTransactione_TabButton.Location = new System.Drawing.Point(0, 327);
            this.BillingTransactione_TabButton.Name = "BillingTransactione_TabButton";
            this.BillingTransactione_TabButton.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.BillingTransactione_TabButton.Size = new System.Drawing.Size(300, 70);
            this.BillingTransactione_TabButton.TabIndex = 6;
            this.BillingTransactione_TabButton.Text = "Billing Transactions";
            this.BillingTransactione_TabButton.UseVisualStyleBackColor = false;
            this.BillingTransactione_TabButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // MedicineTransaction_TabButton
            // 
            this.MedicineTransaction_TabButton.BackColor = System.Drawing.Color.Transparent;
            this.MedicineTransaction_TabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MedicineTransaction_TabButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedicineTransaction_TabButton.Image = global::NMIMS_Hospital_Management.Properties.Resources.prescription_new__final;
            this.MedicineTransaction_TabButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MedicineTransaction_TabButton.Location = new System.Drawing.Point(0, 260);
            this.MedicineTransaction_TabButton.Name = "MedicineTransaction_TabButton";
            this.MedicineTransaction_TabButton.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.MedicineTransaction_TabButton.Size = new System.Drawing.Size(300, 70);
            this.MedicineTransaction_TabButton.TabIndex = 5;
            this.MedicineTransaction_TabButton.Text = "Medicine Transactions";
            this.MedicineTransaction_TabButton.UseVisualStyleBackColor = false;
            this.MedicineTransaction_TabButton.Click += new System.EventHandler(this.MedicineTransaction_TabButton_Click);
            // 
            // NurseDoctor_TabButton
            // 
            this.NurseDoctor_TabButton.BackColor = System.Drawing.Color.Transparent;
            this.NurseDoctor_TabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NurseDoctor_TabButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NurseDoctor_TabButton.Image = global::NMIMS_Hospital_Management.Properties.Resources.nurse_final;
            this.NurseDoctor_TabButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NurseDoctor_TabButton.Location = new System.Drawing.Point(0, 195);
            this.NurseDoctor_TabButton.Name = "NurseDoctor_TabButton";
            this.NurseDoctor_TabButton.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.NurseDoctor_TabButton.Size = new System.Drawing.Size(300, 70);
            this.NurseDoctor_TabButton.TabIndex = 4;
            this.NurseDoctor_TabButton.Text = "Doctors and Nurses";
            this.NurseDoctor_TabButton.UseVisualStyleBackColor = false;
            this.NurseDoctor_TabButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // Medical_Record_TabButton
            // 
            this.Medical_Record_TabButton.BackColor = System.Drawing.Color.Transparent;
            this.Medical_Record_TabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Medical_Record_TabButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Medical_Record_TabButton.Image = global::NMIMS_Hospital_Management.Properties.Resources.medical_record_final;
            this.Medical_Record_TabButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Medical_Record_TabButton.Location = new System.Drawing.Point(0, 128);
            this.Medical_Record_TabButton.Name = "Medical_Record_TabButton";
            this.Medical_Record_TabButton.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.Medical_Record_TabButton.Size = new System.Drawing.Size(300, 70);
            this.Medical_Record_TabButton.TabIndex = 3;
            this.Medical_Record_TabButton.Text = "Medical Record";
            this.Medical_Record_TabButton.UseVisualStyleBackColor = false;
            this.Medical_Record_TabButton.Click += new System.EventHandler(this.Medical_Record_TabButton_Click);
            // 
            // Admitted_TabButton
            // 
            this.Admitted_TabButton.BackColor = System.Drawing.Color.Transparent;
            this.Admitted_TabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Admitted_TabButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admitted_TabButton.Image = global::NMIMS_Hospital_Management.Properties.Resources.admitted_new_final;
            this.Admitted_TabButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Admitted_TabButton.Location = new System.Drawing.Point(0, 63);
            this.Admitted_TabButton.Name = "Admitted_TabButton";
            this.Admitted_TabButton.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.Admitted_TabButton.Size = new System.Drawing.Size(300, 70);
            this.Admitted_TabButton.TabIndex = 2;
            this.Admitted_TabButton.Text = "Admitted";
            this.Admitted_TabButton.UseVisualStyleBackColor = false;
            this.Admitted_TabButton.Click += new System.EventHandler(this.Admitted_TabButton_Click);
            // 
            // SliddingPannel_ToggleButton
            // 
            this.SliddingPannel_ToggleButton.BackColor = System.Drawing.Color.Transparent;
            this.SliddingPannel_ToggleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SliddingPannel_ToggleButton.Image = global::NMIMS_Hospital_Management.Properties.Resources.left;
            this.SliddingPannel_ToggleButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SliddingPannel_ToggleButton.Location = new System.Drawing.Point(0, 0);
            this.SliddingPannel_ToggleButton.Name = "SliddingPannel_ToggleButton";
            this.SliddingPannel_ToggleButton.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.SliddingPannel_ToggleButton.Size = new System.Drawing.Size(300, 70);
            this.SliddingPannel_ToggleButton.TabIndex = 1;
            this.SliddingPannel_ToggleButton.UseVisualStyleBackColor = false;
            this.SliddingPannel_ToggleButton.Click += new System.EventHandler(this.SliddingPannel_ToggleButton_Click);
            // 
            // AppBody
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1406, 744);
            this.Controls.Add(this.SlidingPannel);
            this.Controls.Add(this.ContentPannel);
            this.Name = "AppBody";
            this.Text = "AppBody";
            this.Load += new System.EventHandler(this.AppBody_Load);
            this.SlidingPannel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer Log_In_Timer;
        private System.Windows.Forms.Panel SlidingPannel;
        private System.Windows.Forms.Button SliddingPannel_ToggleButton;
        private System.Windows.Forms.Button About_TabButton;
        private System.Windows.Forms.Button Setting_TabButton;
        private System.Windows.Forms.Button BillingTransactione_TabButton;
        private System.Windows.Forms.Button MedicineTransaction_TabButton;
        private System.Windows.Forms.Button NurseDoctor_TabButton;
        private System.Windows.Forms.Button Medical_Record_TabButton;
        private System.Windows.Forms.Button Admitted_TabButton;
        private System.Windows.Forms.Timer SlidingPannel_TImer;
        private System.Windows.Forms.Panel ContentPannel;
    }
}