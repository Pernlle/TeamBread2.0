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
            dgv1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                bool valueResult = false;
                foreach (DataGridViewRow row in dgv1.Rows)
                {
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        if (row.Cells[i].Value != null && row.Cells[i].Value.ToString().Equals(searchValue))
                        {                            
                            int rowIndex = row.Index;
                            dgv1.Rows[rowIndex].Selected = true;
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
            foreach (DataGridViewRow row in dgv1.Rows)
            {
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    int rowIndex = row.Index;
                    dgv1.Rows[rowIndex].Selected = false;
                    break;
                }
            }            
        }
    }
}
