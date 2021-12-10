﻿using System;
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
            // her mangler stadig sælger info (ejendodmsmægler /eller kunde?)
            
            string search = cbSearchPostNr.Text;
            string areaToPrint = search;
            if (areaToPrint == search)
            {
                TextWriter writer = new StreamWriter($@"..\..\..\Bolig_Søg_{search}.txt");
                for (int i = 0; i < dgvB.Rows.Count - 1; i++) // rows
                {
                    string area = dgvB.Rows[i].Cells[2].Value.ToString();
                    if (area == areaToPrint)
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
                }
                writer.Close();
                MessageBox.Show("Selected data Exported");
            }
            else
            {
                TextWriter writer = new StreamWriter(@"..\..\..\Bolig_Søg.txt");
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
            foreach (DataGridViewRow row in dgvB.Rows)
            {
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    int rowIndex = row.Index;
                    dgvB.Rows[rowIndex].Selected = false;
                    break;
                }
            }
        }
    }
}
