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
    public partial class AdmittedDocPat_UserControl : UserControl
    {
        private static AdmittedDocPat_UserControl _instance;
        public static AdmittedDocPat_UserControl Instance
        {

            get

            {
                if (_instance == null)
                {
                    _instance = new AdmittedDocPat_UserControl();
                }
                return _instance;
            }
        }
        public AdmittedDocPat_UserControl()
        {
            InitializeComponent();
        }

        private void AdmittedDocPat_UserControl_Load(object sender, EventArgs e)
        {

        }
    }
}
