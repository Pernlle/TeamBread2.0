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
    public partial class Log_in : Form
    {
        public Log_in()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // log in knap
            panel1.Controls.Clear();
            CRUDSaelger frm = new CRUDSaelger() { TopLevel = false, TopMost = true };
            frm.FormBorderStyle = FormBorderStyle.None;
            this.panel1.Controls.Add(frm);
            this.panel1.SuspendLayout();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // glemt password
            MessageBox.Show("Idiot!");
        }

        private void textBox10_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Prisen boligen er sat til",textBox10);
        }

        private void textBox11_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Prisen boligen er solgt til", textBox11);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Delete
            // Maskedmessagebox 7
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Update
            // maskedmessagebox = 3-6
        }

        private void maskedTextBox7_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            //Fejltryk
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Create
            // masked messagebox = BAdresse, BPostnr, BKvm, BSalgspris, BHandelspris, BSælger, BEjendomsmægler
        }
    }
}
