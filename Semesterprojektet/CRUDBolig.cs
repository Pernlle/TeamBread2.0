using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semesterprojektet
{
    public partial class CRUDBolig : Form
    {
        public string strconn = @"Server=den1.mssql7.gear.host; Database=teambreaddb; User ID=teambreaddb; Password=Tg53?N_p6fzh";
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
            string id = maskedTextBox7.Text;

            SqlConnection conn = new SqlConnection(strconn);

            string sqlCom = "DELETE FROM Bolig WHERE (bID =@bID);";
            SqlCommand cmd = new SqlCommand(sqlCom, conn);
            cmd.Parameters.Add("@bID", System.Data.SqlDbType.Int);
            cmd.Parameters["@bID"].Value = Convert.ToInt32(id);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close(); 
                MessageBox.Show("Deleting bolig from database");
            }
            catch (Exception exc)
            {
                MessageBox.Show("ERROR: \n\n" + exc.ToString());
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Update
            // maskedmessagebox = 3-6
            string id = maskedTextBox3.Text;
            string salgsPris = maskedTextBox4.Text;
            string handelPris = maskedTextBox5.Text;
            string handelDato = maskedTextBox6.Text;

            SqlConnection conn = new SqlConnection(strconn);

            // Update er ikke værdig
            string sqlCom = "UPDATE Bolig set salgsPris=@salgsPris WHERE bID=@bID; ";
            SqlCommand cmd = new SqlCommand(sqlCom, conn);
            cmd.Parameters.Add("@bID", System.Data.SqlDbType.Int);
            cmd.Parameters["@bID"].Value = Convert.ToInt32(id);
            cmd.Parameters.Add("@salgspris", System.Data.SqlDbType.Decimal);
            cmd.Parameters["@salgsPris"].Value = Convert.ToDecimal(salgsPris);
            //Dette er ikke blevet inplimenteret endnu
            cmd.Parameters.Add("@handelsPris", System.Data.SqlDbType.Decimal);
            cmd.Parameters["@handelsPris"].Value = Convert.ToDecimal(handelPris);
            cmd.Parameters.Add("@handelsDato", System.Data.SqlDbType.Date);
            cmd.Parameters["@handelsDato"].Value = Convert.ToDate(handelDato);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close(); 
                MessageBox.Show("Updatere bolig i database");
            }
            catch (Exception exc)
            {
                MessageBox.Show("ERROR: \n\n" + exc.ToString());
            }
        }

        private void maskedTextBox7_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            //Fejltryk
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Create
            // masked messagebox = BAdresse, BPostnr, BKvm, BSalgspris, BHandelspris, BSælger, BEjendomsmægler
            string bAdresse = BAdresse.Text;
            string bPostnr = BPostnr.Text;
            string bKvm = BKvm.Text;
            string bSalgspris = BSalgspris.Text;
            string bHandelspris = BHandelspris.Text;
            string bSælger = BSælger.Text;
            string bEjdm = BEjendomsmægler.Text;

            SqlConnection conn = new SqlConnection(strconn);
            //Skal handelsdato og solgt sættes ind under mulige indtastninger??
            string sqlCom = "INSERT INTO Bolig(adresse, postNr,kvm,salgsPris,handelsPris,kID,eID) VALUES (@adresse, @postNr, @kvm, @salgsPris, @handelsPris, @kID, @eID);"; 
            SqlCommand cmd = new SqlCommand(sqlCom, conn);
            cmd.Parameters.Add("@adresse", System.Data.SqlDbType.VarChar);
            cmd.Parameters["@adresse"].Value = Convert.ToString(bAdresse);
            cmd.Parameters.Add("@postNr", System.Data.SqlDbType.Int);
            cmd.Parameters["@postNr"].Value = Convert.ToInt32(bPostnr);
            cmd.Parameters.Add("@kvm", System.Data.SqlDbType.Decimal);
            cmd.Parameters["@kvm"].Value = Convert.ToDecimal(bKvm);
            cmd.Parameters.Add("@salgsPris", System.Data.SqlDbType.Decimal);
            cmd.Parameters["@salgsPris"].Value = Convert.ToDecimal(bSalgspris);
            cmd.Parameters.Add("@handelsPris", System.Data.SqlDbType.Decimal);
            cmd.Parameters["@handelsPris"].Value = Convert.ToDecimal(bHandelspris);
            cmd.Parameters.Add("@kID", System.Data.SqlDbType.Int);
            cmd.Parameters["@kID"].Value = Convert.ToInt32(bSælger);
            cmd.Parameters.Add("@eID", System.Data.SqlDbType.Int);
            cmd.Parameters["@eID"].Value = Convert.ToInt32(bEjdm);
            
            /*
            //C(RUD): EKSEMPEL FRA JENS FRA DA VI STARTEDE MED CRUD
            string sqlCom = "INSERT INTO kunde VALUES (@, @, @);";
            SqlCommand cmd = new SqlCommand(sqlCom, conn);
                        
            cmd.Parameters.Add("@", System.Data.SqlDbType.);
            cmd.Parameters["@"].Value = Convert.To();
            */
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close(); // remember this HUSK ALTID AT LUKKE!
                MessageBox.Show("Puttting info into database :)");
            }
            catch (Exception exc)
            {
                MessageBox.Show("ERROR: \n\n" + exc.ToString());
            }
            
        }

        private void textBox12_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Sælger ID - nr på sælger", textBox12);
        }

        private void textBox13_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("ID nr for ejendomsmægler", textBox13);
        }

        private void BPostnr_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // Solgt knap
        }
    }
}
