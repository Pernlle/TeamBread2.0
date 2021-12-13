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

namespace Semesterprojektet
{
    public partial class V2View : Form
    {
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
            string searchValue = cbSearchPostNr.Text;
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
                    MessageBox.Show("Unable to find " + cbSearchPostNr.Text, "Not Found");
                    return;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void print_Click(object sender, EventArgs e)
        {
            // Antager at sælger i dette tilfælde er SÆLGER! Da der ikke står sælger(Mægler) i opgaveteksten.
            // Det som sker her er, at, der først printes Boligen, og til sidst ALLE Sælgere - og dette går i loop til der ikke er flere boligere.
            dgvK.Columns.Count.ToString();
            string search = cbSearchPostNr.Text;
            string areaToPrint = search;
            if (areaToPrint == search)
            {
                TextWriter writer = new StreamWriter($@"..\..\..\txt\Bolig_Søg_{search}.txt");
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
                    // Sælger - Virker ikke som det skal :(
                    for (int k = 0; k < dgvK.Rows.Count - 1; k++) // Sælger rows
                    {
                        string areaK = dgvK.Rows[k].Cells[0].Value.ToString(); // 0 er index på kID (kundeID)
                        string areaB = dgvB.Rows[i].Cells[9].Value.ToString(); // 9 er index på sælgerID
                        if (areaB == areaK)
                        {
                            for (int j = 0; j < dgvK.Columns.Count; j++) // Sælger columns
                            {
                                if (j == dgvK.Columns.Count - 1) // Sælger if last column
                                {
                                    writer.WriteLine("\t" + dgvK.Rows[1].Cells[j].Value.ToString());
                                }
                                else
                                    writer.Write("\t" + dgvK.Rows[1].Cells[j].Value.ToString() + "\t" + "|");
                            }
                        }
                    }
                }
                writer.Close();
                MessageBox.Show("Selected data Exported");
            }
            else
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
        }

        private void clear_Click(object sender, EventArgs e)
        {
            // Fjerne de valgte felter 
            foreach (DataGridViewRow row in dgvB.Rows)
            {
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    int rowIndex = row.Index;
                    dgvB.Rows[rowIndex].Selected = false;
                    break;
                }
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
    }
}
