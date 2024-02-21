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
    public partial class formIngresarLibro : Form
    {
        public formIngresarLibro()
        {
            InitializeComponent();
        }
        String titulo;
        String autor;
        String categoria;
        Boolean dispo;

        public static class DatosLibro
        {
            public static ListaLibros listaLibros = new ListaLibros(); //Instancia de la lista de libros
        }
        
        private void escribirArchivo() 
        {
            string ruta = @"ListaLibros.txt";//ruta en donde se crea el archivo
            if (File.Exists(ruta)) //Si existe el archivo
            {
                StreamWriter archivo = File.AppendText(ruta); //Escribe en el archivo
                archivo.WriteLine(titulo + " - " + autor + " - " + categoria); //Escribe en el archivo
                archivo.Close();
            }
            else //Si no existe el archivo
            {
                TextWriter archivo = new StreamWriter(ruta); //Crea el archivo
                archivo.WriteLine(titulo + " - " + autor + " - " + categoria); //Escribe en el archivo
                archivo.Close();

            }
        }

        private void volvermenu_Click(object sender, EventArgs e)
        {
            this.Close(); //cerrar ventana
        }
        //Validacion de texto
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

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e) //Validacion de texto
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
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "") //Validacion de texto
            {
                MessageBox.Show("Campo vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "") //Validacion de texto
            {
                MessageBox.Show("Campo vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else //Si no hay campos vacios
            {
                titulo = textBox1.Text;
                autor = textBox2.Text;
                categoria = comboBox1.Text;
                dispo = true; //El libro se encuentra disponible
                Libro libro = new Libro(titulo, autor, categoria, dispo); //Instancia de la clase libro
                DatosLibro.listaLibros.AgregarLibro(libro); //Agrega el libro a la lista

                MessageBox.Show("Libro registrado con éxito", "Confirmado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                escribirArchivo();
            }
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "") //Validacion de texto
            {
                MessageBox.Show("Campo vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void formIngresarLibro_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
