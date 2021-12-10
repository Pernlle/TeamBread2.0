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

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            V2CRUDBolig frm = new V2CRUDBolig() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frm.FormBorderStyle = FormBorderStyle.None;
            this.panel1.Controls.Add(frm);
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            CRUDSaelger frm = new CRUDSaelger() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frm.FormBorderStyle = FormBorderStyle.None;
            this.panel1.Controls.Add(frm);
            frm.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            // Noget alla dette - så knappen kun er synlig hvis man er logget ind som admin.
            if (true)
            {
                button2.Visible = true;

                panel1.Controls.Clear();
                CRUDEjendomsmaegler frm = new CRUDEjendomsmaegler() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                frm.FormBorderStyle = FormBorderStyle.None;
                this.panel1.Controls.Add(frm);
                frm.Show();
            }
        }
    }
}
