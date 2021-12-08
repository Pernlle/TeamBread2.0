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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string search = Search.Text;

            switch (search) 
            {
                case "2650":
                case "Hvidovre":
                    {
                        TextWriter sw = new StreamWriter(@"..\Semester1.txt");
                        int rowcount = dataGridView1.Rows.Count;
                        for (int i = 0; i < rowcount - 1; i++)
                        {
                            sw.WriteLine(dataGridView1.Rows[i].Cells[0].Value.ToString() + "\t" + dataGridView1.Rows[i].Cells[1].Value.ToString() + "\t" + dataGridView1.Rows[i].Cells[2].Value.ToString());
                        }
                        sw.Close();
                        MessageBox.Show("Data Successfully Exported");
                    }
                    break;
                case "6980":
                case "Tim":
                    {
                        TextWriter sw = new StreamWriter(@"..\Semester1.txt");
                        int rowcount = dataGridView1.Rows.Count;
                        for (int i = 0; i < rowcount - 1; i++)
                        {
                            sw.WriteLine(dataGridView1.Rows[i].Cells[0].Value.ToString() + "\t" + dataGridView1.Rows[i].Cells[1].Value.ToString() + "\t" + dataGridView1.Rows[i].Cells[2].Value.ToString());
                        }
                        sw.Close();
                        MessageBox.Show("Data Successfully Exported");
                    }
                    break;
                case "7100":
                case "Vejle":
                    {
                        TextWriter sw = new StreamWriter(@"..\Semester1.txt");
                        int rowcount = dataGridView1.Rows.Count;
                        for (int i = 0; i < rowcount - 1; i++)
                        {
                            sw.WriteLine(dataGridView1.Rows[i].Cells[0].Value.ToString() + "\t" + dataGridView1.Rows[i].Cells[1].Value.ToString() + "\t" + dataGridView1.Rows[i].Cells[2].Value.ToString());
                            }
                        sw.Close();
                        MessageBox.Show("Data Successfully Exported");
                    }
                    break;
                case "7323":
                case "Give":
                    {
                        TextWriter sw = new StreamWriter(@"..\Semester1.txt");
                        int rowcount = dataGridView1.Rows.Count;
                        for (int i = 0; i < rowcount - 1; i++)
                        {
                            sw.WriteLine(dataGridView1.Rows[i].Cells[0].Value.ToString() + "\t" + dataGridView1.Rows[i].Cells[1].Value.ToString() + "\t" + dataGridView1.Rows[i].Cells[2].Value.ToString());
                           }
                        sw.Close();
                        MessageBox.Show("Data Successfully Exported");
                    }
                    break;
                case "8700":
                case "Horsens":
                    {
                        TextWriter sw = new StreamWriter(@"..\Semester1.txt");
                        int rowcount = dataGridView1.Rows.Count;
                        for (int i = 0; i < rowcount - 1; i++)
                        {
                            sw.WriteLine(dataGridView1.Rows[i].Cells[0].Value.ToString() + "\t" + dataGridView1.Rows[i].Cells[1].Value.ToString() + "\t" + dataGridView1.Rows[i].Cells[2].Value.ToString());                            
                        }
                        sw.Close();
                        MessageBox.Show("Data Successfully Exported");
                    }
                    break;
                default:
                    {
                        TextWriter sw = new StreamWriter(@"..\Semester1.txt");
                        int rowcount = dataGridView1.Rows.Count;
                        for (int i = 0; i < rowcount - 1; i++)
                        {
                            for (int j = 0; j < dataGridView1.Columns.Count; j++)
                                sw.WriteLine(dataGridView1.Rows[i].Cells[j].Value.ToString());
                        }
                        sw.Close();
                        MessageBox.Show("Data Successfully Exported");
                    }
                    break;
            }            
        }
    }
}

