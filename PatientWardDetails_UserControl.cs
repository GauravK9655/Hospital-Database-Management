using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace NMIMS_Hospital_Management
{
    public partial class PatientWardDetails_UserControl : UserControl
    {
        private static PatientWardDetails_UserControl _instance;
        public static PatientWardDetails_UserControl Instance
        {

            get

            {
                if (_instance == null)
                {
                    _instance = new PatientWardDetails_UserControl();
                }
                return _instance;
            }
        }
        
        public PatientWardDetails_UserControl()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""|DataDirectory|\Database.mdf"";Integrated Security=True");
        private void PatientWardDetails_UserControl_Load(object sender, EventArgs e)
        {
            refresh_DataGridView();
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

       

        public void refresh_DataGridView()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("ShowAllDataPAtWard_SP", con);
                cmd.CommandType= CommandType.StoredProcedure;

                SqlDataAdapter DA= new SqlDataAdapter(cmd);
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

        private void Add_New_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("PatientWardDet_SP", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Ward_No", textBox5.Text);
            cmd.Parameters.AddWithValue("@Patient_Id", textBox6.Text);
            cmd.Parameters.AddWithValue("@Patient_Name", textBox1.Text);
            cmd.Parameters.AddWithValue("@Phone_No", textBox3.Text);
            cmd.Parameters.AddWithValue("@Floor", textBox2.Text);
            cmd.Parameters.AddWithValue("@Type", textBox4.Text);
            con.Open();

            try
            {
                cmd.ExecuteNonQuery();

            }
            catch(Exception ex)
            {
                MessageBox.Show("              <<<INVALID SQL OPERATION>>>: \n" +ex);

            }
            con.Close();
            refresh_DataGridView();

        }

        private void PatientWardDetDelete_TabButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("PatientWarDDetDelete_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Ward_No", textBox5.Text);

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

        private void PatWarDetSearch_TabButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("PatWardDetSearch_PS", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Ward_No", SearchTextBox.Text);

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

        private void PatWardDEtClear_Tabbutton_Click(object sender, EventArgs e)
        {
            SearchTextBox .Text= "";
            textBox5.Text="";
             textBox6.Text ="";
            textBox1.Text ="";
            textBox3.Text ="";
             textBox2.Text ="";
            textBox4.Text ="";
            

        }
    }
}
