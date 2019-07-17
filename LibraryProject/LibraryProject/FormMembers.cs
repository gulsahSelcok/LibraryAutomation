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
    public partial class FormMembers : Form
    {
        public static int chosen_memberID;
        public static int chosen_bookID;
        public static string bookName;
        public static string memberName;
        public static string memberSurname;



        public FormMembers()
        {
            InitializeComponent();
        }
        SqlConnection Conn = new SqlConnection("server=.;Database=Library;UID=Section1;PWD=123456");
 

        private void FormMembers_Load(object sender, EventArgs e)
        {
            Conn.Open();
            string SqlStmt = "SELECT [MemberID],[FirstNameOfMember],[LastNameOfMember] FROM Member ORDER BY [MemberID] ";
            SqlDataAdapter da = new SqlDataAdapter(SqlStmt, Conn);
            DataTable ds = new DataTable();
            da.Fill(ds);
            dataGridMember.DataSource = ds;
            Conn.Close();

            Conn.Open();

            string SqlStmt_Book = "SELECT B.[BookID], B.[BoookName],C.[CategoryName] FROM " +
                "[Book] B INNER JOIN [Category] C ON B.CategoryID=C.CategoryID Order By [BoookName]";
            SqlDataAdapter da_Book = new SqlDataAdapter(SqlStmt_Book, Conn);
            // DataSet ds = new DataSet();
            DataTable ds_Book = new DataTable();
            da_Book.Fill(ds_Book);
            dataGridBook.DataSource = ds_Book;

            Conn.Close();
        }


        private void dataGridMember_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int cellNo = dataGridMember.SelectedCells[0].RowIndex;
            chosen_memberID = Convert.ToInt32(dataGridMember.Rows[cellNo].Cells[0].Value);
            memberName = dataGridMember.Rows[cellNo].Cells[1].Value.ToString();
            memberSurname = dataGridMember.Rows[cellNo].Cells[2].Value.ToString();


        }
        private void dataGridBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int cellNo = dataGridBook.SelectedCells[0].RowIndex;
            chosen_bookID = Convert.ToInt32(dataGridBook.Rows[cellNo].Cells[0].Value);
             bookName = dataGridBook.Rows[cellNo].Cells[1].Value.ToString();

        }

        private void dataGridMember_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Conn.Open();
                SqlCommand cmd = new SqlCommand(); //ödünç veriyor. borcu yoksa ve stokta kitap varsa ödünç veriyor.
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[sp_lend_book]";
                cmd.Parameters.AddWithValue("@bookID", SqlDbType.Int).Value = chosen_bookID;
                cmd.Parameters.AddWithValue("@memberID", SqlDbType.Int).Value = chosen_memberID;
                cmd.Parameters.Add("@message", SqlDbType.NVarChar, 50);
                cmd.Parameters.Add("@debt", SqlDbType.Float);
                cmd.Parameters.Add("@result", SqlDbType.Bit);
                cmd.Parameters["@message"].Direction = ParameterDirection.Output;
                cmd.Parameters["@debt"].Direction = ParameterDirection.Output;
                cmd.Parameters["@result"].Direction = ParameterDirection.Output;
                cmd.Connection = Conn;
                cmd.ExecuteScalar();
                double debt = (double)cmd.Parameters["@debt"].Value;
                string result = cmd.Parameters["@message"].Value.ToString();
                //bool recordState =(bool) cmd.Parameters["@result"].Value;
                MessageBox.Show(result);                            

               //if (recordState == true)
               //{
                    if (debt == 0) //stoktan düşme
                    {
                        SqlCommand cmdStock = new SqlCommand();
                        cmdStock.CommandType = CommandType.StoredProcedure;
                        cmdStock.CommandText = "[dbo].[sp_decrease_stock]";
                        cmdStock.Parameters.AddWithValue("@bookID", SqlDbType.Int).Value = chosen_bookID;
                        cmdStock.Parameters.Add("@message_stock", SqlDbType.NVarChar, 100);
                        cmdStock.Parameters["@message_stock"].Direction = ParameterDirection.Output;
                        cmdStock.Connection = Conn;
                        cmdStock.ExecuteScalar();

                        string msg = cmdStock.Parameters["@message_stock"].Value.ToString();
                        MessageBox.Show(msg);
                    }
               // }

               
                Conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnChooseMember_Click(object sender, EventArgs e)
        {
            lblMember.Text = memberName + " " + memberSurname;

        }

        private void btnChooseBook_Click(object sender, EventArgs e)
        {
            lblBook.Text = bookName;

        }
    }
}
