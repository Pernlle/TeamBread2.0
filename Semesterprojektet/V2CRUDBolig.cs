using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Semesterprojektet
{
    public partial class V2CRUDBolig : Form
    {
        public string strconn = @"Server=den1.mssql7.gear.host; Database=teambreaddb; User ID=teambreaddb; Password=Tg53?N_p6fzh";
        public V2CRUDBolig()
        {
            InitializeComponent();
        }

        private void V2CRUDBolig_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tHEONETHEONLY.Bolig' table. You can move, or remove it, as needed.
            this.boligTableAdapter.Fill(this.tHEONETHEONLY.Bolig);

        }

        //POSTNUMMER
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        //ADRESSE
        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void soldCheck_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void kvm_TextChanged(object sender, EventArgs e)
        {

        }

        private void salgspris_TextChanged(object sender, EventArgs e)
        {

        }

        private void sID_TextChanged(object sender, EventArgs e)
        {

        }

        private void eID_TextChanged(object sender, EventArgs e)
        {

        }

        private void handelspris_TextChanged(object sender, EventArgs e)
        {

        }

        private void handelsdato_ValueChanged(object sender, EventArgs e)
        {

        }

        private void createBtn_Click(object sender, EventArgs e)
        {
        
            SqlConnection conn = new SqlConnection(strconn);
        /*
        if (txtCarName.Text != "" && txtModel.Text != "" && txtYear.Text != "")
        {
            cmd = new SqlCommand("insert into tblCarDetails(Name,Model,Year) values(@name,@model,@year)", con);
            con.Open();
            cmd.Parameters.AddWithValue("@name", txtCarName.Text);
            cmd.Parameters.AddWithValue("@model", txtModel.Text);
            cmd.Parameters.AddWithValue("@year", txtYear.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Car Details Inserted Successfully");
            PopulateData();
            ClearControls();
        }
        else
        {
            MessageBox.Show("Tast alle celler ind");
        }
        */
    }

        private void updateBtn_Click(object sender, EventArgs e)
        {

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
