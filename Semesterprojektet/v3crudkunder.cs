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
    public partial class v3crudkunder : Form
    {
        public string strconn = @"Server=den1.mssql7.gear.host; Database=teambreaddb; User ID=teambreaddb; Password=Tg53?N_p6fzh";

        public v3crudkunder()
        {
            InitializeComponent();
        }

        private void v3crudkunder_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tHEDATASETOFALL.Kunder' table. You can move, or remove it, as needed.
            this.kunderTableAdapter.Fill(this.tHEDATASETOFALL.Kunder);

        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            string kId = id.Text;
            string kFornavn = fornavn.Text;
            string kEfternavn = efternavn.Text;
            string kEmail = email.Text;

            if (saeglerCheck.Checked)
            {
                string sqlCom = "INSERT INTO Kunder(fNavn, eNavn, email, koeber, saelger) VALUES (@fNavn, @eNavn, @email, '0', '1' );";
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
                    MessageBox.Show("Kunden er oprettet");
                    this.kunderTableAdapter.Fill(this.tHEDATASETOFALL.Kunder);
                }
                catch (Exception exc)
                {
                    MessageBox.Show("ERROR: \n\n" + exc.ToString());
                }
            }

            else if (koeberCheck.Checked)
            {
                string sqlCom = "INSERT INTO Kunder(fNavn, eNavn, email, koeber, saelger) VALUES (@fNavn, @eNavn, @email, '1', '0' );";
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
                    MessageBox.Show("Kunden er oprettet");
                    this.kunderTableAdapter.Fill(this.tHEDATASETOFALL.Kunder);
                }
                catch (Exception exc)
                {
                    MessageBox.Show("ERROR: \n\n" + exc.ToString());
                }

            }

            else if (koeberCheck.Checked && saeglerCheck.Checked)
            {
                string sqlCom = "INSERT INTO Kunder(fNavn, eNavn, email, koeber, saelger) VALUES (@fNavn, @eNavn, @email, '1', '1' );";
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
                    MessageBox.Show("Kunden er oprettet");
                    this.kunderTableAdapter.Fill(this.tHEDATASETOFALL.Kunder);
                }
                catch (Exception exc)
                {
                    MessageBox.Show("ERROR: \n\n" + exc.ToString());
                }

            }

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(strconn);

            int selectedRowIndex = dataGridView2.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView2.Rows[selectedRowIndex];
            string cellValue = Convert.ToString(selectedRow.Cells[0].Value);

            if (cellValue != "" || cellValue == "0")
            {
                string sqlCom = $"DELETE Kunder WHERE kID = {cellValue};";
                SqlCommand cmd = new SqlCommand(sqlCom, conn);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Ejendomsmægler slettet");
                    this.kunderTableAdapter.Fill(this.tHEDATASETOFALL.Kunder);
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

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvRow = dataGridView2.Rows[e.RowIndex];
                id.Text = dgvRow.Cells[0].Value.ToString();
                fornavn.Text = dgvRow.Cells[2].Value.ToString();
                efternavn.Text = dgvRow.Cells[3].Value.ToString();
                email.Text = dgvRow.Cells[4].Value.ToString();
            }
        }
    }
}
