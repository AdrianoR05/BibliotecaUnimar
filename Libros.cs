using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Unimar
{
    public class Libro
    {
        private string titulo;
        private string autor;
        private string categoria;

        //Metodo constructor
        public Libro(string titulo, string autor, string categoria)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.categoria = categoria;
        }


        //Metodos de acceso titulo
        public string Titulo { get { return titulo; } }
        //Metodos de acceso autor
        public string Autor { get { return autor; } }
        //Metodos de acceso categoria
        public string Categoria { get { return categoria; } }

    }
}
