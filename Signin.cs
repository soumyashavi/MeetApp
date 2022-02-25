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
using System.Configuration;

namespace MeetApp
{
    public partial class Signin : Form
    {
        public static string l1;
        public static string l2;
        public Signin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string con1 = ConfigurationManager.ConnectionStrings["TestMeet"].ConnectionString;
            SqlConnection con = new SqlConnection(con1);


            SqlCommand cmd = new SqlCommand("select * from signup where EmailId = '" + textBox1.Text + "' and Password = '" + textBox2.Text + "'", con);
            con.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                dr.Close();
                this.Hide();
                //MessageBox.Show("Login success");

                l1 = textBox1.Text;
                l2 = textBox2.Text;



                Profilepage prof = new Profilepage();
                prof.Show();



            }
            else if (textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("please enter the value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dr.Close();
                MessageBox.Show("No Account avilable with this username and password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
