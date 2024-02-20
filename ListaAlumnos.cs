using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Unimar
{
    public class ListaAlumnos
    {
        private Nodo cabeza;
        private int cantidad;
        internal static char text;

        public ListaAlumnos()
        {
            cabeza = null;
            cantidad = 0;
        }

        public void AgregarAlumno(Alumno valor)
        {
            Nodo nuevo = new Nodo(valor);
            if (cabeza == null)
            {
                cabeza = nuevo;
            }
            else
            {
                Nodo temp = cabeza;
                while (temp.Siguiente != null)
                {
                    temp = temp.Siguiente;
                }
                temp.Siguiente = nuevo;
            }
            cantidad++;
        }

        public void EliminarAlumno(string cedula)
        {
            if (cabeza != null)
            {
                if (cabeza.ValorAl.Cedula == cedula)
                {
                    cabeza = cabeza.Siguiente;
                    cantidad--;
                }
                else
                {
                    Nodo temp = cabeza;
                    while (temp.Siguiente != null)
                    {
                        if (temp.Siguiente.ValorAl.Cedula == cedula)
                        {
                            temp.Siguiente = temp.Siguiente.Siguiente;
                            cantidad--;
                            break;
                        }
                        temp = temp.Siguiente;
                    }
                }
            }
        }

        public Alumno BuscarAlumno(string cedula)
        {
            Nodo temp = cabeza;
            while (temp != null)
            {
                if (temp.ValorAl.Cedula == cedula)
                {
                    return temp.ValorAl;
                }
                temp = temp.Siguiente;
            }
            return null;
        }
        
        public Boolean ExisteAlumno(string cedula)
        {
            Nodo temp = cabeza;
            while (temp != null)
            {
                if (temp.ValorAl.Cedula == cedula)
                {
                    return true;
                }
                temp = temp.Siguiente;
            }
            return false;
        }

        public string MostrarAlumnos()
        {
            string lista = "";
            Nodo temp = cabeza;
            while (temp != null)
            {
                lista += temp.ValorAl.Nombre + "\r\n" + temp.ValorAl.Apellido + "\r\n" + temp.ValorAl.Cedula + "\r\n " + temp.ValorAl.Carrera + "\r\n";
                temp = temp.Siguiente;
            }
            return lista;
        }

        public int Cantidad { get { return cantidad; } }

        public string leerArchivo()
        {
            string ruta = @"ListaAlumnos.txt";
            string texto = "";
            if (System.IO.File.Exists(ruta))
            {
                System.IO.StreamReader archivo = new System.IO.StreamReader(ruta);
                texto = archivo.ReadToEnd();
                archivo.Close();
            }
            return texto;
        }
    }

}
