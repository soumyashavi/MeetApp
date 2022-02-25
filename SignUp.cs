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
using System.IO;


namespace MeetApp
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && dateTimePicker1.Text != "")
            {


                string con1 = ConfigurationManager.ConnectionStrings["TestMeet"].ConnectionString;
                SqlConnection con = new SqlConnection(con1);


                SqlCommand cmd = new SqlCommand("insert into signup(FirstName,LastName, DateOfBirth, Emailid,MobileNumber,Password,Image) values(@first_name, @last_name,@date_of_birth,@email_id,@mobile_number,@password,@image)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@first_name", textBox1.Text);
                cmd.Parameters.AddWithValue("@last_name", textBox2.Text);
                cmd.Parameters.AddWithValue("@date_of_birth", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@email_id", textBox3.Text);
                cmd.Parameters.AddWithValue("@mobile_number", textBox4.Text);
                cmd.Parameters.AddWithValue("@password", textBox5.Text);
                OpenFileDialog openfd = new OpenFileDialog();
                openfd.Filter = "Image File(*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
                if (openfd.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = new Bitmap(openfd.FileName);
                }
                byte[] bytes = File.ReadAllBytes(openfd.FileName);
                cmd.Parameters.AddWithValue("@image", bytes);

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Sign up Successfully");




            }

            else if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "" && textBox4.Text == "" && textBox5.Text == "" && textBox6.Text == "")
            {
                MessageBox.Show("Please fill all the details!");
            }










        }
    }
}
