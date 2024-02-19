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
    public partial class interfazMenu : Form
    {
        public interfazMenu()
        {
            InitializeComponent();
        }

        private void InterfazMenu_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //Enviando al usuario al form de registro
        private void registro_Click(object sender, EventArgs e)
        {
            formRegistro registro = new formRegistro();
            registro.Show();
        }
        //cerrar ventana
        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Enviando al usuario al form de solicitud
        private void solicitud_Click(object sender, EventArgs e)
        {
            formSolicitud solicitud = new formSolicitud();
            solicitud.Show();
        }
        //Enviando al usuario al form de ver prestamos
        private void verPrestamo_Click(object sender, EventArgs e)
        {
            formPrestamos verPrestamo = new formPrestamos();
            verPrestamo.Show();
        }
        //Enviando al usuario al form de libros disponibles
        private void librosDisp_Click(object sender, EventArgs e)
        {
            formLibrosDispo librosDispo = new formLibrosDispo();
            librosDispo.Show();
        }
        //Enviando al usuario al form de ingresar libro
        private void ingresarLibro_Click(object sender, EventArgs e)
        {
            formIngresarLibro ingresarLibro = new formIngresarLibro();
            ingresarLibro.Show();
        }
        //Enviando al usuario al form de sancionados
        private void sancionados_Click(object sender, EventArgs e)
        {
            formAlumnosSancionados sancionados = new formAlumnosSancionados();
            sancionados.Show();
        }
        //Enviando al usuario al form de renovacion
        private void renovacion_Click(object sender, EventArgs e)
        {
            formRenovarLibro renovarLibro = new formRenovarLibro();
            renovarLibro.Show();
        }
        //Enviando al usuario al form de devolucion
        private void devolucion_Click(object sender, EventArgs e)
        {
            formDevolucion devolucion = new formDevolucion();
            devolucion.Show();
        }
    }
}
