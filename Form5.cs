using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    }
}
