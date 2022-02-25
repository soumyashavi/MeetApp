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
    public partial class Settings : Form
    {
        public static string email;
        public static string x;
        public Settings()
        {
            InitializeComponent();


            string con1 = ConfigurationManager.ConnectionStrings["TestMeet"].ConnectionString;
            SqlConnection con = new SqlConnection(con1);

            email = Signin.l1;
            con.Open();
            SqlCommand cmd = new SqlCommand("select FirstName,LastName,Image,EmailId,MobileNumber,Userid from signup where EmailId=@email", con);
            cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = email;

            using (SqlDataReader sdr = cmd.ExecuteReader())
            {
                sdr.Read();

                label2.Text = sdr["FirstName"].ToString();
                label4.Text = sdr["LastName"].ToString();
                label5.Text = sdr["EmailId"].ToString();
                label7.Text = sdr["MobileNumber"].ToString();
                Byte[] MyData = new byte[0];
                MyData = (Byte[])sdr["image"];
                MemoryStream stream = new MemoryStream(MyData);
                stream.Position = 0;
                pictureBox1.Image = Image.FromStream(stream);
                label1.Text = sdr["Userid"].ToString();
            }


        }
    }
}
