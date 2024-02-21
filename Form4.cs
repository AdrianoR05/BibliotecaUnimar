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
    public partial class formPrestamos : Form
    {
        public formPrestamos()
        {
            InitializeComponent();
        }

        private void volvermenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formPrestamos_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader leer = new StreamReader(@"SolicitudesPrestamos.txt");
            string linea;

            try
            {
                linea = leer.ReadLine();
                while (linea != null)
                {
                    textBox1.AppendText(linea + "");
                    textBox1.AppendText("\r\n");
                    linea = leer.ReadLine();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
    }
}
