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
    public partial class Doctors_UserControl : UserControl
    {
        private static Doctors_UserControl _instance;
        public static Doctors_UserControl Instance
        {

            get

            {
                if (_instance == null)
                {
                    _instance = new Doctors_UserControl();
                }
                return _instance;
            }
        }
        public Doctors_UserControl()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""|DataDirectory|\Database.mdf"";Integrated Security=True");

        private void Doctors_UserControl_Load(object sender, EventArgs e)
        {
            refresh_DataGridView();
            refresh_DataGridView2();
        }
        public void refresh_DataGridView()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("ShowAllDataDoctorDet_PS", con);
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
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
        public void refresh_DataGridView2()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("ShowAllDataNurseDet_PS", con);
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
                dataGridView2.DataSource = DS.Tables[0];
                this.dataGridView2.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.dataGridView2.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.dataGridView2.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("DoctorDet_PS", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Doctor_Id", textBox1.Text);
            cmd.Parameters.AddWithValue("@Doctor_Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@Speciality", textBox3.Text);
            
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void NurseAddNew_TabButton_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("NurseDet_PS", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Nurse_Id", textBox4.Text);
            cmd.Parameters.AddWithValue("@Nurse_Name", textBox5.Text);
            cmd.Parameters.AddWithValue("@Patient_Id", textBox6.Text);

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
            refresh_DataGridView2();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("DocDetDelte_PS", con);
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("NurseDetDelete_PS", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Nurse_Id", textBox4.Text);

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
                refresh_DataGridView2();
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
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }
    }
}
