using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semesterprojektet
{
    public partial class V2Forside : Form
    {
        public V2Forside()
        {
            InitializeComponent();
            int height = Screen.PrimaryScreen.Bounds.Height;
            int width = Screen.PrimaryScreen.Bounds.Width;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
 
            string id = textBox1.Text;
            string pass = textBox2.Text;

            // assumption: //double assumption dont assume anything
            bool id_ok = true, pass_ok = true;

            // length check:
            if (id.Length > 5) id_ok = false;
            if (pass.Length < 2) pass_ok = false;

            //"<" check for JS tags ... NO cross site scripting here:
            if (id.Contains("<")) id_ok = false;
            if (pass.Contains("<")) pass_ok = false;
            if (id_ok && pass_ok) 
            
                {
                string idId = id.Substring(0, 1);
                if (idId.Contains("1")) 
                { // Admin 
                    panel2.Controls.Clear();
                    ADPanel frm = new ADPanel() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                    frm.FormBorderStyle = FormBorderStyle.None;
                    this.panel2.Controls.Add(frm);
                    frm.Show();
                }
                else
                { // Egendomsmægler 
                    panel2.Controls.Clear();
                    EMPanel frm = new EMPanel() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                    frm.FormBorderStyle = FormBorderStyle.None;
                    this.panel2.Controls.Add(frm);
                    frm.Show();
                }

                
            }
            else { MessageBox.Show("Prøv igen du"); }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void search_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            V2View frm = new V2View() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frm.FormBorderStyle = FormBorderStyle.None;
            this.panel2.Controls.Add(frm);
            frm.Show();
            //SE JEG HAR FIXET DET GUYS
        }

        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Skriv dit ID | Max 5 tegn", textBox1);
        }

        private void textBox2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Mindst 8 tegn", textBox2);
        }
    }
}
