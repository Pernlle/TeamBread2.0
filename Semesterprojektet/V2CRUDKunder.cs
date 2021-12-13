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

namespace Semesterprojektet
{
    public partial class V2CRUDKunder : Form
    {
        public V2CRUDKunder()
        {
            InitializeComponent();
        }

        private void V2CRUDKunder_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tHEDATASETOFALL.Kunder' table. You can move, or remove it, as needed.
            this.kunderTableAdapter.Fill(this.tHEDATASETOFALL.Kunder);

        }

        private void createbtn_Click(object sender, EventArgs e)
        {
            string kId = id.Text;
            string kFornavn = fornavn.Text;
            string kEfternavn = efternavn.Text;
            string kEmail = email.Text;
            string ePass = pass.Text;

            string sqlCom = "INSERT INTO Kunder(fNavn, eNavn, email) VALUES (@fNavn, @eNavn, @email, );";
            SqlConnection conn = new SqlConnection(strconn);
            SqlCommand cmd = new SqlCommand(sqlCom, conn);


            cmd.Parameters.Add("@fNavn", System.Data.SqlDbType.VarChar);
            cmd.Parameters["@fNavn"].Value = Convert.ToString(kFornavn);
            cmd.Parameters.Add("@eNavn", System.Data.SqlDbType.VarChar);
            cmd.Parameters["@eNavn"].Value = Convert.ToString(kEfternavn);
            cmd.Parameters.Add("@email", System.Data.SqlDbType.VarChar);
            cmd.Parameters["@email"].Value = Convert.ToString(kEmail);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Ejendomsmægleren er oprettet");
                this.kunderTableAdapter.Fill(this.tHEDATASETOFALL.Kunder);
            }
            catch (Exception exc)
            {
                MessageBox.Show("ERROR: \n\n" + exc.ToString());
            }
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {

        }

        private void deletebtn_Click(object sender, EventArgs e)
        {

        }
    }
}
