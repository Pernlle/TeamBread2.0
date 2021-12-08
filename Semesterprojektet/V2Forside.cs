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
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string kid = "1234";
            string kpass = "5555";
            

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
            if ((this.textBox1.Text == kid && this.textBox2.Text == kpass))
            {
                string idId = id.Substring(0, 1);
                if (idId.Contains("1")) { /* admin */}
                if (idId.Contains("2")) { /* Egendomsmægler */}

                panel2.Controls.Clear();
                EMPanel frm = new EMPanel() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                frm.FormBorderStyle = FormBorderStyle.None;
                this.panel2.Controls.Add(frm);
                frm.Show();
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
            View frm = new View() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frm.FormBorderStyle = FormBorderStyle.None;
            this.panel2.Controls.Add(frm);
            frm.Show();
            //SE JEG HAR FIXET DET GUYS
        }
    }
}
