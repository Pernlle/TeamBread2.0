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
    
    public partial class CRUDKunder : Form
    {
        public string strconn = @"Server=den1.mssql7.gear.host; Database=teambreaddb; User ID=teambreaddb; Password=Tg53?N_p6fzh";
        public CRUDKunder()
        {
            InitializeComponent();
        }

        private void CRUDKunder_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tHEDATASETOFALL.Kunder' table. You can move, or remove it, as needed.
            this.kunderTableAdapter.Fill(this.tHEDATASETOFALL.Kunder);

        }

        private void koeberCheck_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void saeglerCheck_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void emailBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void fNavnBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void eNavnBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void opretBtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(strconn);

            if (saeglerCheck.Checked && koeberCheck.Checked)
            {
                if (fNavnBox.Text != "" && eNavnBox.Text != "" && emailBox.Text != "")
                {
                    // Definerer strings, for at kunne converte værdien til den korrekte værdi i databasen når man inserter (create)
                    string badresse = adresse.Text;
                    string bpostnr = postnr.Text;
                    string bkvm = kvm.Text;
                    string spris = salgspris.Text;
                    string saegler = sID.Text;
                    string ejendomsmaegler = eID.Text;

                    string hpris = handelspris.Text;
                    // Handelsdatoen er en value, fordi vi bruger DateTimePicker, for at gemme informationen i databasen converter vi den til en string
                    string hdato = Convert.ToString(handelsdato.Value);

                    string sqlCom = "INSERT INTO Bolig(adresse,postNr,kvm,salgsPris,handelsPris,handelsDato,kID,eID,solgt) VALUES (@adresse, @postNr, @kvm, @salgsPris, @handelsPris, @handelsDato, @kID, @eID,'1');";
                    SqlCommand cmd = new SqlCommand(sqlCom, conn);

                    cmd.Parameters.Add("@adresse", System.Data.SqlDbType.VarChar);
                    cmd.Parameters["@adresse"].Value = Convert.ToString(badresse);
                    cmd.Parameters.Add("@postNr", System.Data.SqlDbType.Int);
                    cmd.Parameters["@postNr"].Value = Convert.ToInt32(bpostnr);
                    cmd.Parameters.Add("@kvm", System.Data.SqlDbType.Decimal);
                    cmd.Parameters["@kvm"].Value = Convert.ToDecimal(bkvm);
                    cmd.Parameters.Add("@salgsPris", System.Data.SqlDbType.Decimal);
                    cmd.Parameters["@salgsPris"].Value = Convert.ToDecimal(spris);
                    cmd.Parameters.Add("@kID", System.Data.SqlDbType.Int);
                    cmd.Parameters["@kID"].Value = Convert.ToInt32(saegler);
                    cmd.Parameters.Add("@eID", System.Data.SqlDbType.Int);
                    cmd.Parameters["@eID"].Value = Convert.ToInt32(ejendomsmaegler);

                    cmd.Parameters.Add("@handelsPris", System.Data.SqlDbType.Decimal);
                    cmd.Parameters["@handelsPris"].Value = Convert.ToDecimal(hpris);
                    cmd.Parameters.Add("@handelsDato", System.Data.SqlDbType.VarChar);
                    cmd.Parameters["@handelsDato"].Value = Convert.ToString(hdato);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        //conn.Close(); // remember this HUSK ALTID AT LUKKE!
                        MessageBox.Show("Solgt bolig oprettet");
                        this.boligTableAdapter.Fill(this.tHEONETHEONLY.Bolig);
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show("ERROR: \n\n" + exc.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Tast alle celler ind");
                }
            }

            // HVIS DEN IKKE ER SOLGT
            else
            {
                string badresse = adresse.Text;
                string bpostnr = postnr.Text;
                string bkvm = kvm.Text;
                string spris = salgspris.Text;
                string saegler = sID.Text;
                string ejendomsmaegler = eID.Text;

                string sqlCom = "INSERT INTO Bolig(adresse,postNr,kvm,salgsPris,kID,eID,solgt) VALUES (@adresse, @postNr, @kvm, @salgsPris, @kID, @eID,'0');";
                SqlCommand cmd = new SqlCommand(sqlCom, conn);

                cmd.Parameters.Add("@adresse", System.Data.SqlDbType.VarChar);
                cmd.Parameters["@adresse"].Value = Convert.ToString(badresse);
                cmd.Parameters.Add("@postNr", System.Data.SqlDbType.Int);
                cmd.Parameters["@postNr"].Value = Convert.ToInt32(bpostnr);
                cmd.Parameters.Add("@kvm", System.Data.SqlDbType.Decimal);
                cmd.Parameters["@kvm"].Value = Convert.ToDecimal(bkvm);
                cmd.Parameters.Add("@salgsPris", System.Data.SqlDbType.Decimal);
                cmd.Parameters["@salgsPris"].Value = Convert.ToDecimal(spris);
                cmd.Parameters.Add("@kID", System.Data.SqlDbType.Int);
                cmd.Parameters["@kID"].Value = Convert.ToInt32(saegler);
                cmd.Parameters.Add("@eID", System.Data.SqlDbType.Int);
                cmd.Parameters["@eID"].Value = Convert.ToInt32(ejendomsmaegler);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    //conn.Close(); // remember this HUSK ALTID AT LUKKE!
                    MessageBox.Show("Ny bolig oprettet");
                    this.boligTableAdapter.Fill(this.tHEONETHEONLY.Bolig);
                }
                catch (Exception exc)
                {
                    MessageBox.Show("ERROR: \n\n" + exc.ToString());
                }
            }
        }

        private void opdaterBtn_Click(object sender, EventArgs e)
        {

        }

        private void sletBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
