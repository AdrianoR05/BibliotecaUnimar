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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Biblioteca_Unimar
{
    public partial class formRegistro : Form
    {
        public static class DatosAlumno
        {
            public static ListaAlumnos listaAlumnos = new ListaAlumnos(); //Instancia de la lista de alumnos
        }
        private void escribirArchivo()
        {
            string ruta = @"ListaAlumnos.txt";//ruta en donde se crea el archivo
            if (File.Exists(ruta)) //Si existe el archivo
            {
                StreamWriter archivo = File.AppendText(ruta); //Escribe en el archivo
                archivo.WriteLine(nombre + " - " + apellido + " - " + cedula + " - " + carrera); //Escribe en el archivo
                archivo.Close();
            }
            else //Si no existe el archivo
            {
                TextWriter archivo = new StreamWriter(ruta); //Crea el archivo
                archivo.WriteLine(nombre + " - " + apellido + " - " + cedula + " - " + carrera); //Escribe en el archivo
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
            if (textBox1.Text == "") 
            {
                MessageBox.Show("Campo vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || comboBox1.Text == "") //Comprobacion campos vacios
            {
                MessageBox.Show("Campo vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else //Si no hay campos vacios
            {
                nombre = textBox1.Text; 
                apellido = textBox2.Text;
                cedula = textBox3.Text;
                carrera = comboBox1.Text;
                Alumno alumno = new Alumno(nombre, apellido, cedula, carrera); //Instancia de la clase Alumno
                
                DatosAlumno.listaAlumnos.AgregarAlumno(alumno); //Agrega el alumno a la lista
                MessageBox.Show("Alumno registrado con éxito", "Confirmado", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                escribirArchivo();
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "") 
            {
                MessageBox.Show("Campo vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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


        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                MessageBox.Show("Campo vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("Campo vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
