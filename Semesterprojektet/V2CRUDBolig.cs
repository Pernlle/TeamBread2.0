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

        // OBSOLETE
        private void soldCheck_CheckedChanged(object sender, EventArgs e)
        {

        }

        // OBSOLETE
        private void kvm_TextChanged(object sender, EventArgs e)
        {

        }

        // OBSOLETE
        private void salgspris_TextChanged(object sender, EventArgs e)
        {

        }

        // OBSOLETE
        private void sID_TextChanged(object sender, EventArgs e)
        {

        }

        // OBSOLETE
        private void eID_TextChanged(object sender, EventArgs e)
        {

        }

        // OBSOLETE
        private void handelspris_TextChanged(object sender, EventArgs e)
        {

        }

        // OBSOLETE
        private void handelsdato_ValueChanged(object sender, EventArgs e)
        {
            
        }   

        private void createBtn_Click(object sender, EventArgs e)
        {
            //(C)RUD
            SqlConnection conn = new SqlConnection(strconn);
            // Definerer strings, for at kunne converte værdien til den korrekte værdi i databasen når man inserter (create)
            string badresse = adresse.Text;
            string bpostnr = postnr.Text;
            string bkvm = kvm.Text;
            string spris = salgspris.Text;
            string koeber = koeberID.Text;
            string saelger = sID.Text;
            string ejendomsmaegler = eID.Text;
            string hpris = handelspris.Text;
            // Handelsdatoen er en value, fordi vi bruger DateTimePicker, for at gemme informationen i databasen converter vi den til en string
            string hdato = Convert.ToString(handelsdato.Value);

            // Hvis den er solgt, og checkboxen dermed er checked
            if (soldCheck.Checked)
            {
                // Tester om der er den nødvendige input i alle boxe
                if (postnr.Text != "" && adresse.Text != "" && kvm.Text != "" && salgspris.Text != "" && handelspris.Text != "" && handelsdato.Text != "" && koeberID.Text != "" && sID.Text != "" && eID.Text != "")
                
                {                    
                    string sqlCom = "INSERT INTO Bolig(adresse, postNr, kvm, salgsPris, handelsPris, handelsDato, saeglerID, koeberID, eID, solgt) VALUES (@adresse, @postNr, @kvm, @salgsPris, @handelsPris, @handelsDato, @saeglerID, @koeberID, @eID,'1');";
                    SqlCommand cmd = new SqlCommand(sqlCom, conn);

                    //Sætter værdierne korrekt ind i databasen

                    cmd.Parameters.Add("@adresse", System.Data.SqlDbType.VarChar);
                    cmd.Parameters["@adresse"].Value = Convert.ToString(badresse);
                    cmd.Parameters.Add("@postNr", System.Data.SqlDbType.Int);
                    cmd.Parameters["@postNr"].Value = Convert.ToInt32(bpostnr);
                    cmd.Parameters.Add("@kvm", System.Data.SqlDbType.Decimal);
                    cmd.Parameters["@kvm"].Value = Convert.ToDecimal(bkvm);
                    cmd.Parameters.Add("@salgsPris", System.Data.SqlDbType.Decimal);
                    cmd.Parameters["@salgsPris"].Value = Convert.ToDecimal(spris);
                    cmd.Parameters.Add("@saeglerID", System.Data.SqlDbType.Int);
                    cmd.Parameters["@saeglerID"].Value = Convert.ToInt32(saelger);
                    cmd.Parameters.Add("@koeberID", System.Data.SqlDbType.Int);
                    cmd.Parameters["@koeberID"].Value = Convert.ToInt32(koeber);
                    cmd.Parameters.Add("@eID", System.Data.SqlDbType.Int);
                    cmd.Parameters["@eID"].Value = Convert.ToInt32(ejendomsmaegler);
                    cmd.Parameters.Add("@handelsPris", System.Data.SqlDbType.Decimal);
                    cmd.Parameters["@handelsPris"].Value = Convert.ToDecimal(hpris);
                    cmd.Parameters.Add("@handelsDato", System.Data.SqlDbType.VarChar);
                    cmd.Parameters["@handelsDato"].Value = Convert.ToString(hdato);

                    //ved succes
                    try
                    {
                        //Åbner connection til databasen
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        //Lukker connection
                        conn.Close();
                        this.boligTableAdapter2.Fill(this.tHEDATASETOFALL.Bolig);
                        MessageBox.Show("Solgt bolig oprettet");
                    }
                    //ved fejl
                    catch (Exception exc)
                    {
                        //Printer SQL fejl besked ud
                        MessageBox.Show("ERROR: \n\n" + exc.ToString());
                    }
                }
                else
                {
                    //Sker hvis alle felter ikke er tastet ind
                    MessageBox.Show("Tast alle celler ind");
                }
            }

            // HVIS DEN IKKE ER SOLGT
            else
            {
                //Hvis ikke checkboxen er checked, bliver handelsdato, handelspris og køberid ikke inført
                if (postnr.Text != "" && adresse.Text != "" && kvm.Text != "" && salgspris.Text != "" && sID.Text != "" && eID.Text != "")
                {

                    string sqlCom = "INSERT INTO Bolig(adresse, postNr, kvm, salgsPris, saelger, eID, solgt) VALUES (@adresse, @postNr, @kvm, @salgsPris, @saeglerID, @eID,'0');";
                    SqlCommand cmd = new SqlCommand(sqlCom, conn);

                    cmd.Parameters.Add("@adresse", System.Data.SqlDbType.VarChar);
                    cmd.Parameters["@adresse"].Value = Convert.ToString(badresse);
                    cmd.Parameters.Add("@postNr", System.Data.SqlDbType.Int);
                    cmd.Parameters["@postNr"].Value = Convert.ToInt32(bpostnr);
                    cmd.Parameters.Add("@kvm", System.Data.SqlDbType.Decimal);
                    cmd.Parameters["@kvm"].Value = Convert.ToDecimal(bkvm);
                    cmd.Parameters.Add("@salgsPris", System.Data.SqlDbType.Decimal);
                    cmd.Parameters["@salgsPris"].Value = Convert.ToDecimal(spris);
                    cmd.Parameters.Add("@saeglerID", System.Data.SqlDbType.Int);
                    cmd.Parameters["@saeglerID"].Value = Convert.ToInt32(saelger);
                    cmd.Parameters.Add("@eID", System.Data.SqlDbType.Int);
                    cmd.Parameters["@eID"].Value = Convert.ToInt32(ejendomsmaegler);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close(); // remember this HUSK ALTID AT LUKKE!
                        this.boligTableAdapter2.Fill(this.tHEDATASETOFALL.Bolig);
                        MessageBox.Show("Ny bolig oprettet");

                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show("ERROR: \n\n" + exc.ToString());
                    }
                }

                else
                {
                    //Sker hvis alle felter ikke er tastet ind
                    MessageBox.Show("Tast alle celler ind");
                }

            }
         
        }


        private void updateBtn_Click(object sender, EventArgs e)
        {
            //CR(U)D: Update

            //For at kunne ændre på solgt bool, bruges samme metode som over med en IF sætning
            if (soldCheck.Checked)
            {
                int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];
                string cellValue = Convert.ToString(selectedRow.Cells[0].Value);
                if (cellValue != "" || cellValue == "0")
                {
                    string badresse = adresse.Text;
                    string bpostnr = postnr.Text;
                    string bkvm = kvm.Text;
                    string spris = salgspris.Text;
                    string koeber = koeberID.Text;
                    string saelger = sID.Text;
                    string ejendomsmaegler = eID.Text;
                    string hpris = handelspris.Text;
                    string hdato = Convert.ToString(handelsdato.Value);

                    string sqlCom = $"UPDATE Bolig SET handelsPris=@handelsPris, solgt = '1', koeberid=@koeberID WHERE {cellValue}";
                    SqlConnection conn = new SqlConnection(strconn);
                    SqlCommand cmd = new SqlCommand(sqlCom, conn);

                    cmd.Parameters.Add("@handelsPris", System.Data.SqlDbType.Decimal);
                    cmd.Parameters["@handelsPris"].Value = Convert.ToDecimal(hpris);
                    cmd.Parameters.Add("@handelsDato", System.Data.SqlDbType.VarChar);
                    cmd.Parameters["@handelsDato"].Value = Convert.ToString(hdato);
                    cmd.Parameters.Add("@koeberID", System.Data.SqlDbType.VarChar);
                    cmd.Parameters["@koeberID"].Value = Convert.ToString(koeber);
                    cmd.Parameters.Add("@salgsPris", System.Data.SqlDbType.Decimal);
                    cmd.Parameters["@salgsPris"].Value = Convert.ToDecimal(spris);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        this.boligTableAdapter2.Fill(this.tHEDATASETOFALL.Bolig);
                        MessageBox.Show("Opdatere bolig i database");

                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show("ERROR: \n\n" + exc.ToString());
                    }
                }
            }

            else
            {
                //Hvis den ikke er solgt
                string badresse = adresse.Text;
                string bpostnr = postnr.Text;
                string bkvm = kvm.Text;
                string spris = salgspris.Text;
                string koeber = koeberID.Text;
                string saelger = sID.Text;
                string ejendomsmaegler = eID.Text;
                string hpris = handelspris.Text;
                string hdato = Convert.ToString(handelsdato.Value);

                int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];
                string cellValue = Convert.ToString(selectedRow.Cells[0].Value);
                if (cellValue != "" || cellValue == "0")
                {
                    string sqlCom = $"UPDATE Bolig SET solgt = '0' WHERE {cellValue}";
                    SqlConnection conn = new SqlConnection(strconn);
                    SqlCommand cmd = new SqlCommand(sqlCom, conn);

                    cmd.Parameters.Add("@handelsPris", System.Data.SqlDbType.Decimal);
                    cmd.Parameters["@handelsPris"].Value = Convert.ToDecimal(hpris);
                    cmd.Parameters.Add("@handelsDato", System.Data.SqlDbType.VarChar);
                    cmd.Parameters["@handelsDato"].Value = Convert.ToString(hdato);
                    cmd.Parameters.Add("@koeberID", System.Data.SqlDbType.VarChar);
                    cmd.Parameters["@koeberID"].Value = Convert.ToString(koeber);
                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        this.boligTableAdapter2.Fill(this.tHEDATASETOFALL.Bolig);
                        MessageBox.Show("Opdatere bolig i database");

                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show("ERROR: \n\n" + exc.ToString());
                    }
                }
            }
        }


        // CRU(D)
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
                        conn.Close(); // remember this HUSK ALTID AT LUKKE!
                        this.boligTableAdapter2.Fill(this.tHEDATASETOFALL.Bolig);
                        MessageBox.Show("Bolig slettet");
                       
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

        // OBSOLETE
        private void refreshBtn_Click(object sender, EventArgs e)
        {
            
        }

        // OBSOLETE
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
          
        }

        // Fylder data i boxe når man trykker på en celle i DataGridView
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvRow = dataGridView1.Rows[e.RowIndex];
                adresse.Text = dgvRow.Cells[1].Value.ToString();
                postnr.Text = dgvRow.Cells[2].Value.ToString();
                kvm.Text = dgvRow.Cells[3].Value.ToString();
                salgspris.Text = dgvRow.Cells[7].Value.ToString();
                sID.Text = dgvRow.Cells[4].Value.ToString();
                eID.Text = dgvRow.Cells[5].Value.ToString();
                boligID.Text = dgvRow.Cells[0].Value.ToString();
                handelspris.Text = dgvRow.Cells[8].Value.ToString();
                koeberID.Text = dgvRow.Cells[10].Value.ToString();
            }
        }
    }
}
