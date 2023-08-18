using NMIMS_Hospital_Management.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NMIMS_Hospital_Management
{
    public partial class AppBody : Form
    {
        public AppBody()
        {
            InitializeComponent();
            //initializing for sliding pannel
            isSlidingPannelExpanded = true;
            expandSlindingPannelGUI();
        }

        private void AppBody_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.1;
            Log_In_Timer.Start();

        }

        private void Log_In_Timer_Tick(object sender, EventArgs e)
        {
            if (this.Opacity <= 1.0)
            {
                this.Opacity += 0.025;
            }
            else
            {
                Log_In_Timer.Stop();
            }

        }
        public void expandSlindingPannelGUI()
        {
            //gui adjustments for expanding
            Admitted_TabButton.Text = "Admitted";
            Medical_Record_TabButton.Text = "Medical Records";
            NurseDoctor_TabButton.Text = "Doctors and Nurses";
            MedicineTransaction_TabButton.Text = "Medicine Transactions";
            BillingTransactione_TabButton.Text = "Billing Transactions";
            Setting_TabButton.Text = "Settings";
            About_TabButton.Text = "About";
            SliddingPannel_ToggleButton.Image = Properties.Resources.left;
           

            Admitted_TabButton.Image = null;
            Medical_Record_TabButton.Image = null;
            NurseDoctor_TabButton.Image = null;
            MedicineTransaction_TabButton.Image = null;
            BillingTransactione_TabButton.Image = null;
            Setting_TabButton.Image = null;
            About_TabButton.Image = null;


        }
        public void retractSlindingPannelGUI()
        {
            //gui adjustments for expanding
            Admitted_TabButton.Text = "";
            Medical_Record_TabButton.Text = "";
            NurseDoctor_TabButton.Text = "";
            MedicineTransaction_TabButton.Text = "";
            BillingTransactione_TabButton.Text = "";
            Setting_TabButton.Text = "";
            About_TabButton.Text = "";
            SliddingPannel_ToggleButton.Image = Properties.Resources.right;

            Admitted_TabButton.Image = Properties.Resources.admitted_new_final;
            Medical_Record_TabButton.Image = Resources.medical_record_final;
            NurseDoctor_TabButton.Image = Properties.Resources.nurse_final;
            MedicineTransaction_TabButton.Image = Properties.Resources.prescription_new__final;
            BillingTransactione_TabButton.Image = Properties.Resources.bill_image_final;
            Setting_TabButton.Image = Properties.Resources.Setting_final;
            About_TabButton.Image = Properties.Resources.new_about_final;
        }


        //Sliding pannel code starts from here

        bool isSlidingPannelExpanded;
        const int MaxSlidderWidth = 200;
        const int MinSlidderWidth = 100;
        private void SliddingPannel_ToggleButton_Click(object sender, EventArgs e)
        {
            if (isSlidingPannelExpanded)
            {
                //retract
               /* retractSlindingPannelGUI();*/

            }
            SlidingPannel_TImer.Start();
        }
        private void SlidingPannel_TImer_Tick_1(object sender, EventArgs e)
        {
            if (isSlidingPannelExpanded)
            {
                //retract pannel
                SlidingPannel.Width -= 30;
                if (SlidingPannel.Width <= MinSlidderWidth)
                {
                    //stop retract
                    isSlidingPannelExpanded = false;
                    SlidingPannel_TImer.Stop();
                    retractSlindingPannelGUI();
                    this.Refresh();
                }
            }
            else
            {
                //expand the pannel
                SlidingPannel.Width += 30;
                if (SlidingPannel.Width >= MaxSlidderWidth)
                {
                    //stop retract
                    isSlidingPannelExpanded = true;
                    SlidingPannel_TImer.Stop();
                    expandSlindingPannelGUI();
                    this.Refresh();
                }
            }
        }






        private void button3_Click(object sender, EventArgs e)
        {
            if (!ContentPannel.Controls.Contains(Doctors_UserControl.Instance))
            {
                ContentPannel.Controls.Add(Doctors_UserControl.Instance);
                Doctors_UserControl.Instance.Dock = DockStyle.Fill;
                Doctors_UserControl.Instance.BringToFront();
            }
            else
            {
                Doctors_UserControl.Instance.BringToFront();

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (!ContentPannel.Controls.Contains(BillingTransactions_UserControl.Instance))
            {
                ContentPannel.Controls.Add(BillingTransactions_UserControl.Instance);
                BillingTransactions_UserControl.Instance.Dock = DockStyle.Fill;
                BillingTransactions_UserControl.Instance.BringToFront();
            }
            else
            {
                BillingTransactions_UserControl.Instance.BringToFront();

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Admitted_TabButton_Click(object sender, EventArgs e)
        {
            /* if (! ContentPannel.Controls.Contains(Admitted_UserControl.Instance))
             {
                 ContentPannel.Controls.Add(Admitted_UserControl.Instance);
                 Admitted_UserControl.Instance.Dock = DockStyle.Fill;
                 Admitted_UserControl.Instance.BringToFront();
             }
             else
             {
                 Admitted_UserControl.Instance.BringToFront();

             }*/
            Form2Testing obj = new Form2Testing();
            obj.Show();
        }

        private void Setting_TabButton_Click(object sender, EventArgs e)
        {
            if (!ContentPannel.Controls.Contains(Setting_UserControl.Instance))
            {
                ContentPannel.Controls.Add(Setting_UserControl.Instance);
                Setting_UserControl.Instance.Dock = DockStyle.Fill;
                Setting_UserControl.Instance.BringToFront();
            }
            else
            {
                Setting_UserControl.Instance.BringToFront();

            }

        }

        private void Medical_Record_TabButton_Click(object sender, EventArgs e)
        {
            if (!ContentPannel.Controls.Contains(MedicalRecord_UserControl.Instance))
            {
                ContentPannel.Controls.Add(MedicalRecord_UserControl.Instance);
                MedicalRecord_UserControl.Instance.Dock = DockStyle.Fill;
                MedicalRecord_UserControl.Instance.BringToFront();
            }
            else
            {
                MedicalRecord_UserControl.Instance.BringToFront();

            }
        }

        private void About_TabButton_Click(object sender, EventArgs e)
        {
            if (!ContentPannel.Controls.Contains(About_UserControl.Instance))
            {
                ContentPannel.Controls.Add(About_UserControl.Instance);
                About_UserControl.Instance.Dock = DockStyle.Fill;
                About_UserControl.Instance.BringToFront();
            }
            else
            {
                About_UserControl.Instance.BringToFront();

            }
        }

        private void MedicineTransaction_TabButton_Click(object sender, EventArgs e)
        {

            if (!ContentPannel.Controls.Contains(MedicineTransaction_UserControl.Instance))
            {
                ContentPannel.Controls.Add(MedicineTransaction_UserControl.Instance);
                MedicineTransaction_UserControl.Instance.Dock = DockStyle.Fill;
                MedicineTransaction_UserControl.Instance.BringToFront();
            }
            else
            {
                MedicineTransaction_UserControl.Instance.BringToFront();

            }
        }

        private void ContentPannel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
