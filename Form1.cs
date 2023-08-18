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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\Database.mdf\";Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;
        private String getUserName()
        {
            //fetch data from the database
            con.Open();
            String syntax = "SELECT Value FROM systemTable where Property='UserName'";
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            String temp = dr[0].ToString();
            con.Close();
            return temp;

        }

        private String getPassword()
        {
            //fetch data from the database
            con.Open();
            String syntax = "SELECT Value FROM systemTable where Property='Password'";
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            String temp = dr[0].ToString();
            con.Close();
            return temp;

        }
            private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Uname1 = getUserName(), Upass1 = getPassword(), name, pass;
            name = textBox1.Text;
            pass = textBox2.Text;

            if (name.Equals(Uname1) && pass.Equals(Upass1))
            {
                //login
                label3.Hide();
                MessageBox.Show("Successfully Logged in");
                AppBody obj = new AppBody();
                this.Hide();
                obj.Show();

            }
            else
            {
                //dont login
                label3.Show();
            }


        }
    }
}
