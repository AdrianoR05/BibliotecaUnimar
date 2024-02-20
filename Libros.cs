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
        private Boolean prestado;
        private string v1;
        private string v2;
        private string v3;
        private string v4;
        private bool v5;

        //Metodo constructor
        public Libro(string titulo, string autor, string categoria, bool prestado)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.categoria = categoria;
            this.prestado = prestado;
        }

        public Libro(string v1, string v2, string v3, string v4, bool v5)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
            this.v5 = v5;
        }


        //Metodos de acceso titulo
        public string Titulo { get { return titulo; } }
        //Metodos de acceso autor
        public string Autor { get { return autor; } }
        //Metodos de acceso categoria
        public string Categoria { get { return categoria; } }

        public Boolean Prestado { get { return prestado; } set { prestado = value; } }

    }
}
