using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Unimar
{
    public class Nodo
    {
        //Atributos de la clase Nodo
        private Alumno valorAl;
        private Libro valorLib;
        private Nodo siguiente;

        //Constructor de la clase Nodo
        public Nodo(Alumno valor)
        {
            this.valorAl = valor;
            this.siguiente = null;
        }

        public Nodo(Libro valor)
        {
            this.valorLib = valor;
            this.siguiente = null;
        }

        //Metodos getters y setters
        public Alumno ValorAl { get { return valorAl; } }

        public Libro ValorLib { get { return ValorLib; } }

        public Nodo Siguiente { get { return siguiente; } set { siguiente = value; } }

        

    }
}
