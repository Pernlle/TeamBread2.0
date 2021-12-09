using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semesterprojektet
{
    public partial class View : Form
    {
        public View()
        {
            InitializeComponent();
        }

        private void View_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tHEONETHEONLY.Bolig' table. You can move, or remove it, as needed.
            this.boligTableAdapter1.Fill(this.tHEONETHEONLY.Bolig);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string searchValue = search.Text;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                bool valueResult = false;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        if (row.Cells[i].Value != null && row.Cells[i].Value.ToString().Equals(searchValue))
                        {
                            int rowIndex = row.Index;
                            dataGridView1.Rows[rowIndex].Selected = true;
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string search = this.search.Text;

            switch (search)
            {
                case "2650":
                case "Hvidovre":
                    {
                        String areaToPrint = "2650";
                        TextWriter writer = new StreamWriter(@"..\..\..\Bolig_Søg_Hvidovre.txt");
                        for (int i = 0; i < dataGridView1.Rows.Count - 1; i++) // rows
                        {
                            String area = dataGridView1.Rows[i].Cells[2].Value.ToString();
                            MessageBox.Show(area);
                            if (area == areaToPrint)
                            {
                                for (int j = 0; j < dataGridView1.Columns.Count; j++) // columns
                                {
                                    if (j == dataGridView1.Columns.Count - 1) // if last column
                                    {
                                        writer.WriteLine("\t" + dataGridView1.Rows[i].Cells[j].Value.ToString());
                                    }
                                    else
                                        writer.Write("\t" + dataGridView1.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                                }
                            }
                        }
                        writer.Close();
                        MessageBox.Show("Data Exported");
                    }
                    break;
                case "6980":
                case "Tim":
                    {
                        String areaToPrint = "6980";
                        TextWriter writer = new StreamWriter(@"..\..\..\Bolig_Søg_Tim.txt");                        
                        for (int i = 0; i < dataGridView1.Rows.Count - 1; i++) // rows
                        {
                            String area = dataGridView1.Rows[i].Cells[2].Value.ToString();
                            MessageBox.Show(area);
                            if (area == areaToPrint)
                            {
                                for (int j = 0; j < dataGridView1.Columns.Count; j++) // columns
                                {
                                    if (j == dataGridView1.Columns.Count - 1) // if last column
                                    {
                                        writer.WriteLine("\t" + dataGridView1.Rows[i].Cells[j].Value.ToString());
                                    }
                                    else
                                        writer.Write("\t" + dataGridView1.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                                }
                            }
                        }
                        writer.Close();
                        MessageBox.Show("Data Exported");
                    }
                    break;
                case "7100":
                case "Vejle":
                    {
                        String areaToPrint = "7100"; // Læs det her ind fra dit textfield 
                        TextWriter writer = new StreamWriter(@"..\..\..\Bolig_Søg_Vejle.txt");
                        for (int i = 0; i < dataGridView1.Rows.Count - 1; i++) // rows
                        {
                            String area = dataGridView1.Rows[i].Cells[2].Value.ToString();
                            MessageBox.Show(area);
                           if (area == areaToPrint)
                            {
                                for (int j = 0; j < dataGridView1.Columns.Count; j++) // columns
                                {
                                    if (j == dataGridView1.Columns.Count - 1) // if last column
                                    {
                                        writer.WriteLine("\t" + dataGridView1.Rows[i].Cells[j].Value.ToString());
                                    }
                                    else
                                        writer.Write("\t" + dataGridView1.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                                }
                            }
                        }
                        writer.Close();
                        MessageBox.Show("Data Exported");
                    }
                    break;
                case "7323":
                case "Give":
                    {
                        String areaToPrint = "7323";
                        TextWriter writer = new StreamWriter(@"..\..\..\Bolig_Søg_Give.txt");
                        for (int i = 0; i < dataGridView1.Rows.Count - 1; i++) // rows
                        {
                            String area = dataGridView1.Rows[i].Cells[2].Value.ToString();
                            MessageBox.Show(area);
                            if (area == areaToPrint)
                            {
                                for (int j = 0; j < dataGridView1.Columns.Count; j++) // columns
                                {
                                    if (j == dataGridView1.Columns.Count - 1) // if last column
                                    {
                                        writer.WriteLine("\t" + dataGridView1.Rows[i].Cells[j].Value.ToString());
                                    }
                                    else
                                        writer.Write("\t" + dataGridView1.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                                }
                            }
                        }
                        writer.Close();
                        MessageBox.Show("Data Exported");
                    }
                    break;
                case "8700":
                case "Horsens":
                    {
                        String areaToPrint = "8700"; // Læs det her ind fra dit textfield 
                        TextWriter writer = new StreamWriter(@"..\..\..\Bolig_Søg_Horsens.txt");
                        for (int i = 0; i < dataGridView1.Rows.Count - 1; i++) // rows
                        {
                            String area = dataGridView1.Rows[i].Cells[3].Value.ToString();
                            if (area == areaToPrint)
                            {
                                for (int j = 0; j < dataGridView1.Columns.Count; j++) // columns
                                {
                                    if (j == dataGridView1.Columns.Count - 1) // if last column
                                    {
                                        writer.WriteLine("\t" + dataGridView1.Rows[i].Cells[j].Value.ToString());
                                    }
                                    else
                                        writer.Write("\t" + dataGridView1.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                                }
                            }
                        }
                        writer.Close();
                        MessageBox.Show("Data Exported");
                    }
                    break;
                default:
                    {
                        TextWriter writer = new StreamWriter(@"..\..\..\Bolig_Søg.txt");
                        for (int i = 0; i < dataGridView1.Rows.Count - 1; i++) // rows
                        {
                            for (int j = 0; j < dataGridView1.Columns.Count; j++) // columns
                            {
                                if (j == dataGridView1.Columns.Count - 1) // if last column
                                {
                                    writer.WriteLine("\t" + dataGridView1.Rows[i].Cells[j].Value.ToString());
                                }
                                else
                                    writer.Write("\t" + dataGridView1.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                            }
                        }
                        writer.Close();
                        MessageBox.Show("Data Exported");

                        break;
                    }
                    // nedenfor er til at lave søg - har også prøvet med switch
                    /*
                    TextWriter sw = new StreamWriter(@"..\Semester1.txt");
                    int rowcount = dataGridView1.Rows.Count;
                    for (int i = 0; i < rowcount - 1; i++)
                    {
                        sw.WriteLine(dataGridView1.Rows[i].Cells[0].Value.ToString() + "\t" + dataGridView1.Rows[i].Cells[1].Value.ToString() + "\t" + dataGridView1.Rows[i].Cells[2].Value.ToString());
                    }
                    sw.Close();
                    MessageBox.Show("Data Successfully Exported");
                    */
            }
        }
    }
}

