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
    public partial class Forside : Form
    {
        public Forside()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            View frm = new View() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frm.FormBorderStyle = FormBorderStyle.None;
            this.panel1.Controls.Add(frm);
            frm.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            // den falske knap
            panel1.Controls.Clear();
            Log_in frm = new Log_in() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frm.FormBorderStyle = FormBorderStyle.None;
            this.panel1.Controls.Add(frm);
            frm.Show();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            CRUDSaelger frm = new CRUDSaelger() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frm.FormBorderStyle = FormBorderStyle.None;
            this.panel1.Controls.Add(frm);
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = maskedTextBox1.Text;
            string pass = maskedTextBox2.Text;

            // assumption: //double assumption dont assume anything
            bool id_ok = true, pass_ok = true;

            // length check:
            if (id.Length > 5) id_ok = false;
            if (pass.Length < 8) pass_ok = false;

            //"<" check for JS tags ... NO cross site scripting here:
            if (id.Contains("<")) id_ok = false;
            if (pass.Contains("<")) pass_ok = false;                       
            if (id_ok && pass_ok)
            {
                string idId = id.Substring(0, 1);
                if (idId.Contains("1")) { /* admin */}
                if (idId.Contains("2")) { /* Egendomsmægler */}

                panel1.Controls.Clear();
                EMPanel frm = new EMPanel() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                frm.FormBorderStyle = FormBorderStyle.None;
                this.panel1.Controls.Add(frm);
                frm.Show();
            }
            else { MessageBox.Show("Prøv igen du"); }
        }

        private void maskedTextBox1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Max 5 tegn", maskedTextBox1);
        }

        private void maskedTextBox2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Mindst 8 tegn", maskedTextBox2);
        }
    }
}
