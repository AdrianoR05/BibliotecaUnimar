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
        DateTime fechaPrestamo;

        public static class DatosPrestamo
        {
            public static ListaPrestamos listaPrestamos = new ListaPrestamos(); //Instancia de la lista de prestamos
        }
        private void escribirArchivo()
        {
            string ruta = @"SolicitudesPrestamos.txt";//ruta en donde se crea el archivo
            if (System.IO.File.Exists(ruta)) //Si existe el archivo
            {
                System.IO.StreamWriter archivo = System.IO.File.AppendText(ruta); //Escribe en el archivo
                archivo.WriteLine(cedula + " - " + titulo + " - " + fechaPrestamo); //Escribe en el archivo
                archivo.Close(); //cambiar
            }
            else //Si no existe el archivo
            {
                System.IO.TextWriter archivo = new System.IO.StreamWriter(ruta); //Crea el archivo
                archivo.WriteLine(cedula + " - " + titulo + " - " + fechaPrestamo); //Escribe en el archivo
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
            string ruta = @"ListaAlumnos.txt";
            if (System.IO.File.Exists(ruta))
            {
                System.IO.StreamReader archivo = new System.IO.StreamReader(ruta);
                string linea;
                while ((linea = archivo.ReadLine()) != null)
                {
                    string[] datos = linea.Split('-');
                    Alumno alumno = new Alumno(datos[0], datos[1], datos[2], datos[3]);
                    DatosAlumno.listaAlumnos.AgregarAlumno(alumno);
                }
                archivo.Close();
            }
        }
        private void LeerArchivoLibros()
        {
            string ruta = @"ListaLibros.txt";
            if (System.IO.File.Exists(ruta))
            {
                System.IO.StreamReader archivo = new System.IO.StreamReader(ruta);
                string linea;
                while ((linea = archivo.ReadLine()) != null)
                {
                    string[] datos = linea.Split('-');
                    Libro libro = new Libro(datos[0], datos[1], datos[2], true);
                    DatosLibro.listaLibros.AgregarLibro(libro);
                }
                archivo.Close();
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
                fechaPrestamo = DateTime.Now;
                LeerArchivoAlumnos();
                LeerArchivoLibros();
                if (DatosAlumno.listaAlumnos.ExisteAlumno(cedula) == false)
                {
                    MessageBox.Show("El alumno no existe.");
                    return;
                } else if (DatosLibro.listaLibros.ExisteLibro(titulo) == false)
                {
                    MessageBox.Show("El libro no existe.");
                    return;
                }else if (DatosLibro.listaLibros.BuscarLibro(titulo).Prestado == false)
                {
                    MessageBox.Show("El libro no está disponible.");
                    return;
                }
                else
                {
                    Prestamo prestamo = new Prestamo(cedula, titulo, fechaPrestamo);
                    DatosPrestamo.listaPrestamos.AgregarPrestamo(prestamo);
                    DatosLibro.listaLibros.BuscarLibro(titulo).Prestado = false;
                }
                MessageBox.Show("Prestamo registrado.");
                escribirArchivo();
            }
        }
        //Validacion de numeros cedula
        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }
        //Validacion titulo del libro
        private void textBox2_KeyPress_1(object sender, KeyPressEventArgs e)
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
    }
}
