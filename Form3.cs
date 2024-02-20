using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Biblioteca_Unimar.formIngresarLibro;
using static Biblioteca_Unimar.formRegistro;

namespace Biblioteca_Unimar
{
    public partial class formSolicitud : Form
    {
        public formSolicitud()
        {
            InitializeComponent();
        }

        String cedula;
        String titulo;

        private void escribirArchivo()
        {
            string ruta = @"SolicitudesPrestamos.txt";//ruta en donde se crea el archivo
            if (System.IO.File.Exists(ruta)) //Si existe el archivo
            {
                System.IO.StreamWriter archivo = System.IO.File.AppendText(ruta); //Escribe en el archivo
                archivo.WriteLine("Cedula: " + cedula + ". Titulo: " + titulo + "."); //Escribe en el archivo
                archivo.Close();
            }
            else //Si no existe el archivo
            {
                System.IO.TextWriter archivo = new System.IO.StreamWriter(ruta); //Crea el archivo
                archivo.WriteLine("Cedula: " + cedula + ". Titulo: " + titulo + "."); //Escribe en el archivo
                archivo.Close();

            }
        }
        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void volvermenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "") //Validacion de texto
            {
                MessageBox.Show("Campo vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Validacion de numeros cedula
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return; 
            }
        }

        //Validacion del titulo
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar)) 
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar)) 
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("Sólo se permiten letras", "Denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "") //Validacion de texto
            {
                MessageBox.Show("Campo vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LeerArchivoAlumnos()
        {
            try
            {
                string ruta = @"Alumnos.txt";
                string[] lineas = System.IO.File.ReadAllLines(ruta);
                foreach (string linea in lineas)
                {
                    string[] datos = linea.Split(',');
                    Alumno alumno = new Alumno(datos[0], datos[1], datos[2], datos[3]);
                    DatosAlumno.listaAlumnos.AgregarAlumno(alumno);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al leer el archivo de alumnos");
            }
        }
        private void LeerArchivoLibros()
        {
            try
            {
                string ruta = @"Libros.txt";
                string[] lineas = System.IO.File.ReadAllLines(ruta);
                foreach (string linea in lineas)
                {
                    string[] datos = linea.Split(',');
                    Libro libro = new Libro(datos[0], datos[1], datos[2], datos[3], true);
                    DatosLibro.listaLibros.AgregarLibro(libro);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al leer el archivo de libros");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Campo vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                cedula = textBox1.Text;
                titulo = textBox2.Text;
                if (DatosLibro.listaLibros.ExisteLibro(titulo) == false)
                {
                    MessageBox.Show("Libro no registrado.");
                    return;
                }
                else if (DatosAlumno.listaAlumnos.ExisteAlumno(cedula) == false)
                {
                    MessageBox.Show("Alumno no registrado.");
                    return;
                }
                MessageBox.Show("Prestamo registrado.");
                escribirArchivo();
            }
        }
    }
}
