using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semesterprojektet
{
    public partial class CRUDSaelger : Form
    {
        public string strconn = @"Server=den1.mssql7.gear.host; Database=teambreaddb; User ID=teambreaddb; Password=Tg53?N_p6fzh";

        public CRUDSaelger()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Create
            // masked message = SFornavn, SEfternavn, SEmail, STlf
            string fNavn = SFornavn.Text;
            string eNavn = SEfternavn.Text;
            string email = SEmail.Text;
            string tlf = STlf.Text;

            {
                SqlConnection conn = new SqlConnection(strconn);

                string sqlCom = "INSERT INTO Kunder VALUES (@fNavn, @eNavn, @email), INSERT INTO tlf VALUES (@tlf) ;";
                SqlCommand cmd = new SqlCommand(sqlCom, conn);
                cmd.Parameters.Add("@fNavn", System.Data.SqlDbType.VarChar);
                cmd.Parameters["@fNavn"].Value = Convert.ToString(fNavn);
                cmd.Parameters.Add("@eNavn", System.Data.SqlDbType.VarChar);
                cmd.Parameters["@eNavn"].Value = Convert.ToString(eNavn);
                cmd.Parameters.Add("@email", System.Data.SqlDbType.VarChar);
                cmd.Parameters["@email"].Value = Convert.ToString(email);
                cmd.Parameters.Add("@tlf", System.Data.SqlDbType.VarChar);
                cmd.Parameters["@tlf"].Value = Convert.ToString(tlf);


                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close(); // remember this
                    MessageBox.Show("GREAT SUCCESS");
                }
                catch (Exception exc)
                {
                    MessageBox.Show("ERROR: \n\n" + exc.ToString());
                }

            }
        }
    
        

        private void button4_Click(object sender, EventArgs e)
        {
            // Update
            // Masked meassage = 5-6
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Delete
            // masked message = 7
        }
    }
}
