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
    public partial class EMPanel : Form
    {
        public EMPanel()
        {
            InitializeComponent();
        }

        private void boligbtn_Click(object sender, EventArgs e)
        {
            //Bolig Button
            panel1.Controls.Clear();
            V2CRUDBolig frm = new V2CRUDBolig() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frm.FormBorderStyle = FormBorderStyle.None;
            this.panel1.Controls.Add(frm);
            frm.Show();
        }

        private void saelgerbtn_Click(object sender, EventArgs e)
        {
            //Kunder button
            panel1.Controls.Clear();
            v3crudkunder frm = new v3crudkunder() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frm.FormBorderStyle = FormBorderStyle.None;
            this.panel1.Controls.Add(frm);
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
