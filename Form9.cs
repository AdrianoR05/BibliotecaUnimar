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

        static ListaLibros listaLibros = new ListaLibros();
        private void escribirArchivo()
        {
            string ruta = @"ListaLibros.txt";//ruta en donde se crea el archivo
            if (File.Exists(ruta))//si no esta creado, lo crea
            {
                StreamWriter archivo = File.AppendText(ruta);
                archivo.WriteLine("Titulo: "+ titulo + ". Autor: " + autor + ". Categoria: " + categoria + ".");
                archivo.Close();
            }
            else//si esta creado escribe
            {
                TextWriter archivo = new StreamWriter(ruta);
                archivo.WriteLine("Titulo: "+ titulo + ". Autor: " + autor + ". Categoria: " + categoria + ".");
                archivo.Close();

            }
        }

        private void volvermenu_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            titulo = textBox1.Text;
            autor = textBox2.Text;
            categoria = comboBox1.Text;
            Libro libro = new Libro(titulo, autor, categoria);
            listaLibros.AgregarLibro(libro);
            
            MessageBox.Show("Libro registrado con éxito", "Confirmado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            escribirArchivo();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
