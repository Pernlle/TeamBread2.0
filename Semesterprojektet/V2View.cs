using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Semesterprojektet
{
    public partial class V2View : Form
    {
        public string strconn = @"Server=den1.mssql7.gear.host; Database=teambreaddb; User ID=teambreaddb; Password=Tg53?N_p6fzh";

        public V2View()
        {
            InitializeComponent();
        }

        private void V2View_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tHEDATASETOFALL.Kunder' table. You can move, or remove it, as needed.
            this.kunderTableAdapter.Fill(this.tHEDATASETOFALL.Kunder);
            // TODO: This line of code loads data into the 'tHEDATASETOFALL.Bolig' table. You can move, or remove it, as needed.
            this.boligTableAdapter.Fill(this.tHEDATASETOFALL.Bolig);

        }

        private void cbSearchPostNr_SelectedIndexChanged(object sender, EventArgs e)
        { 
            //Det fungerede ikke helt med printknappen
        }

        private void print_Click(object sender, EventArgs e)
        {
            // Antager at sælger i dette tilfælde er SÆLGER! Da der ikke står sælger(Mægler) i opgaveteksten.
            // Det som sker her er, at, der først printes Boligen, og til sidst ALLE Sælgere - og dette går i loop til der ikke er flere boligere.
            string search1 = search.Text;
            string areaToPrint = search1;
            
            if (search1=="")
            {
                TextWriter writer = new StreamWriter(@"..\..\..\txt\Bolig_Søg.txt");
                for (int i = 0; i < dgvB.Rows.Count - 1; i++) // rows
                {
                    for (int j = 0; j < dgvB.Columns.Count; j++) // columns
                    {
                        if (j == dgvB.Columns.Count - 1) // if last column
                        {
                            writer.WriteLine("\t" + dgvB.Rows[i].Cells[j].Value.ToString());
                        }
                        else
                            writer.Write("\t" + dgvB.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                    }
                }
                writer.Close();
                MessageBox.Show("Full data Exported");
            }
            else if (areaToPrint == search1)
            {
                TextWriter writer = new StreamWriter($@"..\..\..\txt\Bolig_Søg_{search1}.txt");
                for (int i = 0; i < dgvB.Rows.Count - 1; i++) // Bolig rows
                {
                    //Bolig
                    string area = dgvB.Rows[i].Cells[2].Value.ToString();
                    if (area == areaToPrint)
                    {
                        for (int j = 0; j < dgvB.Columns.Count; j++) // Bolig columns
                        {
                            if (j == dgvB.Columns.Count - 1) // Bolig if last column
                            {
                                writer.WriteLine("\t" + dgvB.Rows[i].Cells[j].Value.ToString());
                            }
                            else
                                writer.Write("\t" + dgvB.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                        }
                    }
                }
                writer.Close();
                MessageBox.Show("Selected data Exported");
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            //Search button = Find
            string searchValue = search.Text;
            dgvB.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                bool valueResult = false;
                foreach (DataGridViewRow row in dgvB.Rows)
                {
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        if (row.Cells[i].Value != null && row.Cells[i].Value.ToString().Equals(searchValue))
                        {
                            int rowIndex = row.Index;
                            dgvB.Rows[rowIndex].Selected = true;
                            valueResult = true;
                            break;
                        }
                    }
                }
                if (!valueResult)
                {
                    MessageBox.Show("Unable to find " + search.Text, "Not Found");
                    return;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

                // print af sælger informationer
                /*
                string search = "6";
                string areaToPrint = search;
                if (areaToPrint == search)
                {
                    TextWriter writer = new StreamWriter($@"..\..\..\Bolig_Søg_{search}.txt");                
                    for (int k = 0; k < dgvK.Rows.Count - 1; k++) // rows
                    {
                        string areaK = dgvK.Rows[k].Cells[0].Value.ToString();
                        if (areaToPrint == areaK)
                        {
                            for (int j = 0; j < dgvK.Columns.Count; j++) // columns
                            {
                                if (j == dgvK.Columns.Count - 1) // if last column
                                {
                                    writer.WriteLine("\t" + dgvK.Rows[k].Cells[j].Value.ToString());
                                }
                                else
                                    writer.Write("\t" + dgvK.Rows[k].Cells[j].Value.ToString() + "\t" + "|");
                            }
                        }
                    }
                    writer.Close();
                    MessageBox.Show("Selected data Exported");
                }
                ^*/

            }

        private void mlDatoer_Click(object sender, EventArgs e)
        {
            string dato1 = Convert.ToString(datobox1);
            string dato2 = Convert.ToString(datobox2);

            SqlConnection conn = new SqlConnection(strconn);
            SqlCommand cmd = new SqlCommand("SELECT * FROM Bolig WHERE handelsDato BETWEEN '" + dato1 + "' AND '" + dato2 + "'", conn);
            DataTable dt1 = new DataTable();
            SqlDataAdapter SDA1 = new SqlDataAdapter(cmd);
            SDA1.Fill(dt1);
            dgvB.DataSource = dt1;

        }

        private void prisSearch_Click(object sender, EventArgs e)
        {
            string pris = Convert.ToString(prisInput.Text);

            SqlConnection conn = new SqlConnection(strconn);
            SqlCommand cmd = new SqlCommand("SELECT * FROM Bolig WHERE handelsPris >= '" + pris + "'", conn);
            DataTable dt2 = new DataTable();
            SqlDataAdapter SDA2 = new SqlDataAdapter(cmd);
            SDA2.Fill(dt2);
            dgvB.DataSource = dt2;

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show("ERROR: \n\n" + exc.ToString());
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void search_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            //Find knap
            string searchValue = search.Text;
            dgvB.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                bool valueResult = false;
                foreach (DataGridViewRow row in dgvB.Rows)
                {
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        if (row.Cells[i].Value != null && row.Cells[i].Value.ToString().Equals(searchValue))
                        {
                            int rowIndex = row.Index;
                            dgvB.Rows[rowIndex].Selected = true;
                            valueResult = true;
                            break;
                        }
                    }
                }
                if (!valueResult)
                {
                    MessageBox.Show("Unable to find " + searchValue, "Not Found");
                    return;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void datobox1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Dato start", datobox1);
        }

        private void datobox2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Dato slut", datobox2);
        }

        private void prisInput_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Pris input", prisInput);
        }

        private void search_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Søg eftter et postnummer, du gerne vil printe ", search);
        }
    }
}
