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
    public partial class FormDeliver : Form
    {
        public FormDeliver()
        {
            InitializeComponent();
        }
        SqlConnection Conn = new SqlConnection("server=.;Database=Library;UID=Section1;PWD=123456");
        public static int loanID;
        public static int memberID;
        public static int debtMemberID;


        private void FormDeliver_Load(object sender, EventArgs e)
        {
            Conn.Open();
            string SqlStmt = "SELECT L.[LoanID],M.[FirstNameOfMember],M.[LastNameOfMember],B.[BoookName] " +
                "FROM Loan L,Member M,Book B WHERE L.MemberID=M.MemberID and L.BookID=B.BookID ";
            SqlDataAdapter da = new SqlDataAdapter(SqlStmt, Conn);
            DataTable ds = new DataTable();
            da.Fill(ds);
            dataGridLoan.DataSource = ds;
            Conn.Close();

        }

        private void dataGridLoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int cellNo = dataGridLoan.SelectedCells[0].RowIndex;
            loanID = Convert.ToInt32(dataGridLoan.Rows[cellNo].Cells[0].Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conn.Open();

            string SqlStmt_Loan = "SELECT MemberID FROM " +
                "[Loan] WHERE LoanID= "+loanID;
            SqlCommand cmd = new SqlCommand(SqlStmt_Loan, Conn);
            memberID = Convert.ToInt32(cmd.ExecuteScalar());
                        
            //if (debt>0)
            //{
                string SqlStmt = "SELECT [MemberID],[FirstNameOfMember],[LastNameOfMember],[Debt] " +
                "FROM Member WHERE MemberID = " + memberID;
                SqlDataAdapter da_Loan = new SqlDataAdapter(SqlStmt, Conn);
                // DataSet ds = new DataSet();
                DataTable ds_Loan = new DataTable();
                da_Loan.Fill(ds_Loan);
                dgMemberDelete.DataSource = ds_Loan;
            //}
                        
            Conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
             try
             {
                Conn.Open();
                string SqlStmt_Debt = "SELECT Debt FROM " +
               "[Member] WHERE MemberID= " + debtMemberID;
                SqlCommand cmd_M = new SqlCommand(SqlStmt_Debt, Conn);
                decimal debt = Convert.ToDecimal(cmd_M.ExecuteScalar());

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[sp_deleteDebt]";
                cmd.Parameters.AddWithValue("@memberID", SqlDbType.Int).Value = debtMemberID;
                cmd.Parameters.AddWithValue("@loanID", SqlDbType.Int).Value = loanID;
                cmd.Connection = Conn;
                cmd.ExecuteScalar();
                Conn.Close();

                if (debt>0)
                    MessageBox.Show("Üyeye ait borç silindi.\n Kitap iade edildi.");      
                else
                    MessageBox.Show("Kitap iade edildi.");
            }
            catch (Exception)
            {
                MessageBox.Show("İşlem sırasında bir hata meydana geldi.\nBorç silinmedi.");
            }
            
     
        }

        private void dgMemberDelete_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int cellNo = dgMemberDelete.SelectedCells[0].RowIndex;
            debtMemberID = Convert.ToInt32(dgMemberDelete.Rows[cellNo].Cells[0].Value);
        }
    }
}
