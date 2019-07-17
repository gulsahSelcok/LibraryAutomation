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

namespace LibraryProject
{
    public partial class Form_Giris : Form
    {
        public Form_Giris()
        {
            InitializeComponent();
        }
        SqlConnection Conn = new SqlConnection("server=.;Database=Library;UID=Section1;PWD=123456");

        private void button1_Click(object sender, EventArgs e)
        {
            bool enterProcess = enter(textBox1.Text,textBox2.Text);
            if(enterProcess == true)
            {
                MessageBox.Show("Giriş Başarılı.");
            }
            else
            {
                MessageBox.Show("Giriş Hatalı.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public bool enter(string us,string pw)
        {
            Conn.Open();
            SqlCommand kmt = new SqlCommand("Select * From Staff Where StaffID=@id And Cipher=@pw",Conn);

            kmt.Parameters.AddWithValue("@id",us);
            kmt.Parameters.AddWithValue("@pw", pw);

            SqlDataReader read = kmt.ExecuteReader();

            if (read.Read())
            {
                Conn.Close();
                return true;
            }
            else
            {
                Conn.Close();
                return false;
            }
        }
    }
}
