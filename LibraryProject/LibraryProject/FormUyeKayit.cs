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

namespace LibraryProject
{
    public partial class FormUyeKayit : Form
    {
        public FormUyeKayit()
        {
            InitializeComponent();
        }
        SqlConnection Conn = new SqlConnection("server=.;Database=Library;UID=Section1;PWD=123456");

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Conn.State == ConnectionState.Closed)
                    Conn.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO Member Values(@ad,@soyad,@mail,@borc,@telNo)", Conn);

                cmd.Parameters.AddWithValue("@ad", txtName.Text);
                cmd.Parameters.AddWithValue("@soyad", txtSurname.Text);
                cmd.Parameters.AddWithValue("@mail", txtEmail.Text);
                cmd.Parameters.AddWithValue("@borc", 0);
                cmd.Parameters.AddWithValue("@telNo", txtPhoneNumber.Text);

                cmd.ExecuteNonQuery();
                Conn.Close();
                MessageBox.Show("Uye kaydı başarılı.");

            }
            catch (Exception error)
            {
                MessageBox.Show("Islem sırasında hsata olustu." + error.Message);
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }
    }
}
