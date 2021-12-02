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
    public partial class CRUDBolig : Form
    {
        public CRUDBolig()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // log in knap - GEMT BAG PANEL!
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // glemt password - GEMT BAG PANEL!
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

            /*
            //C(RUD):
            string sqlCom = "INSERT INTO kunde VALUES (@Id, @Knavn, @Kadresse);";
            SqlCommand cmd = new SqlCommand(sqlCom, conn);
            cmd.Parameters.Add("@Id", System.Data.SqlDbType.Int);
            cmd.Parameters["@Id"].Value = Convert.ToInt32(Id);
            cmd.Parameters.Add("@Knavn", System.Data.SqlDbType.VarChar);
            cmd.Parameters["@Knavn"].Value = Convert.ToString(Knavn);
            cmd.Parameters.Add("@Kadresse", System.Data.SqlDbType.VarChar);
            cmd.Parameters["@Kadresse"].Value = Convert.ToString(Kadresse);
            *//*
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close(); // remember this
                MessageBox.Show("SUCCESS :\n" + sqlCom + "\nmed værdierne: (" +
                                cmd.Parameters["@Id"].Value + ", " +
                                cmd.Parameters["@Knavn"].Value + ", " +
                                cmd.Parameters["@Kadresse"].Value +
                                ")");
            }
            catch (Exception exc)
            {
                MessageBox.Show("ERROR: \n\n" + exc.ToString());
            }
            */
        }
    }
}
