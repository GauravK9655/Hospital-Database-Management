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
    public partial class Form2Testing : Form
    {
        public Form2Testing()
        {
            InitializeComponent();
        }

        private void PatientAssignedWardButton_Click(object sender, EventArgs e)
        {
            if (!contentpannelWard2.Controls.Contains(PatientWardDetails_UserControl.Instance))
            {
                contentpannelWard2.Controls.Add(PatientWardDetails_UserControl.Instance);
                PatientWardDetails_UserControl.Instance.Dock = DockStyle.Fill;
                PatientWardDetails_UserControl.Instance.BringToFront();
            }
            else
            {
                PatientWardDetails_UserControl.Instance.BringToFront();

            }
        }

        private void NurseTakeCares_Button_Click(object sender, EventArgs e)
        {
            if (!contentpannelWard2.Controls.Contains(PatientNurseDoctorDet_UserConrtol.Instance))
            {
                contentpannelWard2.Controls.Add(PatientNurseDoctorDet_UserConrtol.Instance);
                PatientNurseDoctorDet_UserConrtol.Instance.Dock = DockStyle.Fill;
                PatientNurseDoctorDet_UserConrtol.Instance.BringToFront();
            }
            else
            {
                PatientNurseDoctorDet_UserConrtol.Instance.BringToFront();

            }
        }

        private void PatientIniDet_TabButton_Click(object sender, EventArgs e)
        {
            if (!contentpannelWard2.Controls.Contains(PatientDet_UserControl.Instance))

            {
                contentpannelWard2.Controls.Add(PatientDet_UserControl.Instance);
                PatientDet_UserControl.Instance.Dock = DockStyle.Fill;
                PatientDet_UserControl.Instance.BringToFront();
            }
            else
            {
                PatientDet_UserControl.Instance.BringToFront();

            }
        }
    }
}
