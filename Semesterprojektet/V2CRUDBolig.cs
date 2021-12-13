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
    public partial class V2CRUDBolig : Form
    {
        public string strconn = @"Server=den1.mssql7.gear.host; Database=teambreaddb; User ID=teambreaddb; Password=Tg53?N_p6fzh";
        public V2CRUDBolig()
        {
            InitializeComponent();
        }

        private void V2CRUDBolig_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tHEDATASETOFALL.Bolig' table. You can move, or remove it, as needed.
            this.boligTableAdapter2.Fill(this.tHEDATASETOFALL.Bolig);
           

        }

        //POSTNUMMER
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        //ADRESSE
        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void soldCheck_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void kvm_TextChanged(object sender, EventArgs e)
        {

        }

        private void salgspris_TextChanged(object sender, EventArgs e)
        {

        }

        private void sID_TextChanged(object sender, EventArgs e)
        {

        }

        private void eID_TextChanged(object sender, EventArgs e)
        {

        }

        private void handelspris_TextChanged(object sender, EventArgs e)
        {

        }

        private void handelsdato_ValueChanged(object sender, EventArgs e)
        {
            
        }   

        private void createBtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(strconn);
            // Definerer strings, for at kunne converte værdien til den korrekte værdi i databasen når man inserter (create)
            string badresse = adresse.Text;
            string bpostnr = postnr.Text;
            string bkvm = kvm.Text;
            string spris = salgspris.Text;
            string koeber = koeberID.Text;
            string saelger = sID.Text;
            string ejendomsmaegler = eID.Text;

            // Hvis den er solgt
            if (soldCheck.Checked)
            {
                if (postnr.Text != "" && adresse.Text != "" && kvm.Text != "" && salgspris.Text != "" && handelspris.Text != "" && handelsdato.Text != "" && sID.Text != "" && eID.Text != "")
                {                    
                    string hpris = handelspris.Text;
                    // Handelsdatoen er en value, fordi vi bruger DateTimePicker, for at gemme informationen i databasen converter vi den til en string
                    string hdato = Convert.ToString(handelsdato.Value);

                    string sqlCom = "INSERT INTO Bolig(adresse,postNr,kvm,salgsPris,handelsPris,handelsDato,saelgerID,koeberID,eID,solgt) VALUES (@adresse, @postNr, @kvm, @salgsPris, @handelsPris, @handelsDato,@saelgerID, @koeberID, @eID,'1');";
                    SqlCommand cmd = new SqlCommand(sqlCom, conn);

                    cmd.Parameters.Add("@adresse", System.Data.SqlDbType.VarChar);
                    cmd.Parameters["@adresse"].Value = Convert.ToString(badresse);
                    cmd.Parameters.Add("@postNr", System.Data.SqlDbType.Int);
                    cmd.Parameters["@postNr"].Value = Convert.ToInt32(bpostnr);
                    cmd.Parameters.Add("@kvm", System.Data.SqlDbType.Decimal);
                    cmd.Parameters["@kvm"].Value = Convert.ToDecimal(bkvm);
                    cmd.Parameters.Add("@salgsPris", System.Data.SqlDbType.Decimal);
                    cmd.Parameters["@salgsPris"].Value = Convert.ToDecimal(spris);

                    cmd.Parameters.Add("@saelgerID", System.Data.SqlDbType.Int);
                    cmd.Parameters["@saelgerID"].Value = Convert.ToInt32(saelger);

                    cmd.Parameters.Add("@koeberID", System.Data.SqlDbType.Int);
                    cmd.Parameters["@koeberID"].Value = Convert.ToInt32(koeber);

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


        private void updateBtn_Click(object sender, EventArgs e)
        {
            /*
             * 
             * // 

                    string hpris = handelspris.Text;
                    // Handelsdatoen er en value, fordi vi bruger DateTimePicker, for at gemme informationen i databasen converter vi den til en string
                    string hdato = Convert.ToString(handelsdato.Value);

                    string sqlCom = "INSERT INTO Bolig(adresse,postNr,kvm,salgsPris,handelsPris,handelsDato,kID,eID,solgt) VALUES (@adresse, @postNr, @kvm, @salgsPris, @handelsPris, @handelsDato, @kID, @eID,'1');";
                    SqlCommand cmd = new SqlCommand(sqlCom, conn);
            // Update

            string badresse = textBox7.Text;
            string bpostnr = textBox2.Text;
            string bkvm = kvm.Text;
            string spris = salgspris.Text;
            string saegler = sID.Text;
            string ejendomsmaegler = eID.Text;
            string hpris = handelspris.Text;
            string hdato = Convert.ToString(handelsdato.Value);

            SqlConnection conn = new SqlConnection(strconn);

            // Update er ikke værdig
            string sqlCom = "UPDATE Bolig set salgsPris=@salgsPris WHERE bID=@bID; ";
            SqlCommand cmd = new SqlCommand(sqlCom, conn);
            cmd.Parameters.Add("@bID", System.Data.SqlDbType.Int);
            cmd.Parameters["@bID"].Value = Convert.ToInt32(id);
            cmd.Parameters.Add("@salgspris", System.Data.SqlDbType.Decimal);
            cmd.Parameters["@salgsPris"].Value = Convert.ToDecimal(salgsPris);
            //Dette er ikke blevet inplimenteret endnu (nedenfor)
            cmd.Parameters.Add("@handelsPris", System.Data.SqlDbType.Decimal);
            cmd.Parameters["@handelsPris"].Value = Convert.ToDecimal(handelPris);
            cmd.Parameters.Add("@handelsDato", System.Data.SqlDbType.Date);
            cmd.Parameters["@handelsDato"].Value = Convert.ToDateTime(handelDato);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Updatere bolig i database");
            }
            catch (Exception exc)
            {
                MessageBox.Show("ERROR: \n\n" + exc.ToString());
            }
            */

        }


        private void deleteBtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(strconn);

            int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];
            string cellValue = Convert.ToString(selectedRow.Cells[0].Value);

            Yes_no(conn, cellValue);
            
        }
        public void Yes_no(SqlConnection conn, string cellValue)
        {
            string box_msg = "Er du sikker på at du vil slette denne bolig";

            string box_title = "Vær sød at svare ja eller nej";

            MessageBox.Show(box_msg, box_title, MessageBoxButtons.YesNo);

            var selectedOption = MessageBox.Show(box_msg, box_title, MessageBoxButtons.YesNo);
            if (selectedOption == DialogResult.Yes)
            {
                if (cellValue != "" || cellValue == "0")
                {
                    string sqlCom = $"DELETE Bolig WHERE bID = {cellValue};";
                    SqlCommand cmd = new SqlCommand(sqlCom, conn);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        //conn.Close(); // remember this HUSK ALTID AT LUKKE!
                        MessageBox.Show("Bolig slettet");
                        this.boligTableAdapter.Fill(this.tHEONETHEONLY.Bolig);
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show("ERROR: \n\n" + exc.ToString());
                    }

                }
                else
                {
                    MessageBox.Show("Vælg noget at slette");
                }
            }
            else if (selectedOption == DialogResult.No) { MessageBox.Show("Gør noget andet så :) "); }
        }
        private void refreshBtn_Click(object sender, EventArgs e)
        {
            this.boligTableAdapter.Fill(this.tHEONETHEONLY.Bolig);
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
          
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvRow = dataGridView1.Rows[e.RowIndex];
                adresse.Text = dgvRow.Cells[1].Value.ToString();
                postnr.Text = dgvRow.Cells[2].Value.ToString();
                kvm.Text = dgvRow.Cells[4].Value.ToString();
                salgspris.Text = dgvRow.Cells[5].Value.ToString();
                sID.Text = dgvRow.Cells[8].Value.ToString();
                eID.Text = dgvRow.Cells[9].Value.ToString();
            }
        }
    }
}
