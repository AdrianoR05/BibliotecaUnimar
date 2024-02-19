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
    public partial class formRegistro : Form
    {
        static ListaAlumnos listaAlumnos = new ListaAlumnos();
        private void escribirArchivo()
        {
            string ruta = @"ListaAlumnos.txt";
            if (File.Exists(ruta))
            {
                StreamWriter archivo = File.AppendText(ruta);
                archivo.WriteLine(nombre + " " + apellido + " " + cedula + " " + carrera);
                archivo.Close();
            }
            else
            {
                TextWriter archivo = new StreamWriter(ruta);
                archivo.WriteLine(nombre + " " + apellido + " " + cedula + " " + carrera);
                archivo.Close();

            }
        }
        public formRegistro()
        {
            InitializeComponent();
        }
        String nombre;
        String apellido;
        String cedula;
        String carrera;

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            nombre = textBox1.Text;
            apellido = textBox2.Text;
            cedula = textBox3.Text;
            carrera = comboBox1.Text;
            Alumno alumno = new Alumno(nombre, apellido, cedula, carrera);
            textBox4.Text += alumno.MostrarAlumno() + Environment.NewLine;
            listaAlumnos.AgregarAlumno(alumno);
            MessageBox.Show("Alumno registrado con éxito", "Confirmado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            escribirArchivo();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //Validacion de texto nombre
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
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
        //Validacion de texto apellido
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
        //Validacion de numeros cedula
        private void textBox3_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }
        //cerrar ventana
        private void volvermenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {
            
        }
    }
}
