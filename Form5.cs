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

namespace Biblioteca_Unimar
{
    public partial class formLibrosDispo : Form
    {
        public formLibrosDispo()
        {
            InitializeComponent();
        }

        private void volvermenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLibrosDisp_Click(object sender, EventArgs e)
        {
            StreamReader leer = new StreamReader(@"ListaLibros.txt");
            string linea;

            try
            {
                linea = leer.ReadLine();
                while (linea != null)
                {
                    richTextBox1.AppendText(linea+"");
                    richTextBox1.AppendText("\n");
                    linea = leer.ReadLine();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }  

            {

               
            }
        }

        private void formLibrosDispo_Load(object sender, EventArgs e)
        {

        }
    }
}
