using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NMIMS_Hospital_Management
{
    public partial class PatientNurseDoctorDet_UserConrtol : UserControl
    {
        private static PatientNurseDoctorDet_UserConrtol _instance;
        public static PatientNurseDoctorDet_UserConrtol Instance
        {

            get

            {
                if (_instance == null)
                {
                    _instance = new PatientNurseDoctorDet_UserConrtol();
                }
                return _instance;
            }
        }
        public PatientNurseDoctorDet_UserConrtol()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""|DataDirectory|\Database.mdf"";Integrated Security=True");

        private void PatientNurseDoctorDet_UserConrtol_Load(object sender, EventArgs e)
        {
            refresh_DataGridView();
        }
        public void refresh_DataGridView()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("ShowAllDataPatDocNur_PS", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("              <<<INVALID SQL OPERATION>>>: \n" + ex);
                }
                con.Close();
                dataGridView1.DataSource = DS.Tables[0];
                this.dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("PatientTreatsDet_PS", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Doctor_Id", textBox1.Text);
            cmd.Parameters.AddWithValue("@Patient_Id", textBox2.Text);
            cmd.Parameters.AddWithValue("@Nurse_Id", textBox3.Text);
            cmd.Parameters.AddWithValue("@Nurse_Name", textBox4.Text);
            cmd.Parameters.AddWithValue("@Patient_Name", textBox5.Text);
            cmd.Parameters.AddWithValue("@Phone_No", textBox6.Text);
            con.Open();

            try
            {
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("              <<<INVALID SQL OPERATION>>>: \n" + ex);

            }
            con.Close();
            refresh_DataGridView();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("PatientTreatDelete_Ps", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Doctor_Id", textBox1.Text);

                con.Open();

                try
                {
                    cmd.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("              <<<INVALID SQL OPERATION>>>: \n" + ex);

                }
                con.Close();
                refresh_DataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }
    }
}
