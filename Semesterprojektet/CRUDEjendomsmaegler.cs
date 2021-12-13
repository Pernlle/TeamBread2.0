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
    public partial class CRUDEjendomsmaegler : Form
    {
        public string strconn = @"Server=den1.mssql7.gear.host; Database=teambreaddb; User ID=teambreaddb; Password=Tg53?N_p6fzh";

        public CRUDEjendomsmaegler()
        {
            InitializeComponent();
        }

        private void CRUDEjendomsmaegler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tHEDATASETOFALL.Ejendomsmaegler' table. You can move, or remove it, as needed.
            this.ejendomsmaeglerTableAdapter.Fill(this.tHEDATASETOFALL.Ejendomsmaegler);

        }

        private void createbtn_Click(object sender, EventArgs e)
        {
            string eId = id.Text;
            string eFornavn = fornavn.Text;
            string eEfternavn = efternavn.Text;
            string eEmail = email.Text;
            string ePass = pass.Text;

            string sqlCom = "INSERT INTO Ejendomsmaegler(fNavn, eNavn, email, pass) VALUES (@fNavn, @eNavn, @email, @pass);";
            SqlConnection conn = new SqlConnection(strconn);
            SqlCommand cmd = new SqlCommand(sqlCom, conn);

            
            cmd.Parameters.Add("@fNavn", System.Data.SqlDbType.VarChar);
            cmd.Parameters["@fNavn"].Value = Convert.ToString(eFornavn);
            cmd.Parameters.Add("@eNavn", System.Data.SqlDbType.VarChar);
            cmd.Parameters["@eNavn"].Value = Convert.ToString(eEfternavn);
            cmd.Parameters.Add("@email", System.Data.SqlDbType.VarChar);
            cmd.Parameters["@email"].Value = Convert.ToString(eEmail);
            cmd.Parameters.Add("@pass", System.Data.SqlDbType.VarChar);
            cmd.Parameters["@pass"].Value = Convert.ToString(ePass);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close(); 
                MessageBox.Show("Ejendomsmægleren er oprettet");
                this.ejendomsmaeglerTableAdapter.Fill(this.tHEDATASETOFALL.Ejendomsmaegler);
            }
            catch (Exception exc)
            {
                MessageBox.Show("ERROR: \n\n" + exc.ToString());
            }
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            string eID = id.Text;
            string eEmail = email.Text;

            string sqlCom = "UPDATE Ejendomsmaegler set email=@email WHERE eID=@eID; ";
            SqlConnection conn = new SqlConnection(strconn);
            SqlCommand cmd = new SqlCommand(sqlCom, conn);

            cmd.Parameters.Add("@eID", System.Data.SqlDbType.Int);
            cmd.Parameters["@eID"].Value = Convert.ToInt32(eID);
            cmd.Parameters.Add("@email", System.Data.SqlDbType.VarChar);
            cmd.Parameters["@email"].Value = Convert.ToString(eEmail);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Ejendomsmægleren er opdateret");
                this.ejendomsmaeglerTableAdapter.Fill(this.tHEDATASETOFALL.Ejendomsmaegler);
            }
            catch (Exception exc)
            {
                MessageBox.Show("ERROR: \n\n" + exc.ToString());
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {            
            SqlConnection conn = new SqlConnection(strconn);

            int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];
            string cellValue = Convert.ToString(selectedRow.Cells[0].Value);

            Yes_no(conn, cellValue);
        }
        // Metode som spørger om du er sikker på om du vil slette ejendomsmægler eller ej.
        public void Yes_no(SqlConnection conn, string cellValue)
        {
            string box_msg = $"Er du sikker på at du vil slette denne ejendomsmægler ID = {cellValue} ";
            string box_title = "Vælg ja eller nej";

            var selectedOption = MessageBox.Show(box_msg, box_title, MessageBoxButtons.YesNo);
            if (selectedOption == DialogResult.Yes)
            {
                if (cellValue != "" || cellValue == "0") 
                {
                    string sqlCom = $"DELETE Ejendomsmaegler WHERE eID = {cellValue};";
                    SqlCommand cmd = new SqlCommand(sqlCom, conn);
                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Ejendomsmægler slettet");
                        this.ejendomsmaeglerTableAdapter.Fill(this.tHEDATASETOFALL.Ejendomsmaegler);
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
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvRow = dataGridView1.Rows[e.RowIndex];
                id.Text = dgvRow.Cells[0].Value.ToString();
                fornavn.Text = dgvRow.Cells[2].Value.ToString();
                efternavn.Text = dgvRow.Cells[3].Value.ToString();
                email.Text = dgvRow.Cells[4].Value.ToString();
            }
        }

        private void updatebtn_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Du kan kun opdatere email | Vælg en ejendomsmægler i data sættet", updatebtn);
        }

        private void id_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Tryk på data sættet for at indsætte ID", id);
        }
    }
}
