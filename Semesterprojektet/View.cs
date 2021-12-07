using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semesterprojektet
{
    public partial class View : Form
    {
        public View()
        {
            InitializeComponent();
        }

        private void View_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tHEONETHEONLY.Bolig' table. You can move, or remove it, as needed.
            this.boligTableAdapter1.Fill(this.tHEONETHEONLY.Bolig);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter Stream = null;
            //Indsæt noget andet i string udfil
            String UdFil = @"C:\Users\pkoe9\Downloads\Mappe\Dat21a.txt";
            try
            {
                Stream = new StreamWriter(UdFil, true); // open file output append

                Stream.WriteLine("email Santa@Claus.snow");
            }
            catch (IOException s)
            {
                Console.WriteLine(s.Message);
                Console.ReadLine();
            }
            finally
            {
                if (Stream != null)
                    Stream.Close();// close file
            }
        }
    }
}
