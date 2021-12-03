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
            string bAdresse = BAdresse.Text;
            string bPostnr = BPostnr.Text;
            string bKvm = BKvm.Text;
            string bSalgspris = BSalgspris.Text;
            string bHandelspris = BHandelspris.Text;
            string bSælger = BSælger.Text;
            string bEjdm = BEjendomsmægler.Text;
            /*
    bID INT IDENTITY (1,1) PRIMARY KEY NOT NULL,
	eID INT FOREIGN KEY REFERENCES Ejendomsmaegler(eID),
	kID INT FOREIGN KEY REFERENCES Kunder(kID),

	adresse VARCHAR (50),
	postNr INT FOREIGN KEY REFERENCES Postnummer(postNr),
	kvm DECIMAL,

	salgsPris DECIMAL,

	handelsPris DECIMAL,
	handelsDato DATE,
	solgt INT,
             */
            //C(RUD)
            SqlConnection conn = new SqlConnection(strconn);
            //Skal handelsdato og solgt sættes ind under mulige indtastninger??
            string sqlCom = "INSERT INTO Bolig VALUES (@adresse, @postNr, @kvm, @salgsPris, @handelsPris, @kID, @eID);"; 
            SqlCommand cmd = new SqlCommand(sqlCom, conn);
            cmd.Parameters.Add("@adresse", System.Data.SqlDbType.VarChar);
            cmd.Parameters["@adresse"].Value = Convert.ToString(bAdresse);
            cmd.Parameters.Add("@postNr", System.Data.SqlDbType.Int);
            cmd.Parameters["@postNr"].Value = Convert.ToString(bPostnr);
            cmd.Parameters.Add("@kvm", System.Data.SqlDbType.Int);
            cmd.Parameters["@kvm"].Value = Convert.ToString(bKvm);
            cmd.Parameters.Add("@salgsPris", System.Data.SqlDbType.Decimal);
            cmd.Parameters["@salgsPris"].Value = Convert.ToString(bSalgspris);
            cmd.Parameters.Add("@handelsPris", System.Data.SqlDbType.Decimal);
            cmd.Parameters["@handelsPris"].Value = Convert.ToString(bHandelspris);
            cmd.Parameters.Add("@kID", System.Data.SqlDbType.Int);
            cmd.Parameters["@kID"].Value = Convert.ToString(bSælger);
            cmd.Parameters.Add("@eID", System.Data.SqlDbType.Int);
            cmd.Parameters["@eID"].Value = Convert.ToString(bEjdm);
            
            /*
            //C(RUD): EKSEMPEL FRA JENS FRA DA VI STARTEDE MED CRUD
            string sqlCom = "INSERT INTO kunde VALUES (@Id, @Knavn, @Kadresse);";
            SqlCommand cmd = new SqlCommand(sqlCom, conn);

            //Tom version
            cmd.Parameters.Add("@", System.Data.SqlDbType.);
            cmd.Parameters["@"].Value = Convert.ToString();

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
    }
}
