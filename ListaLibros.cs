using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Unimar
{
    public class ListaLibros
    {
        private Nodo cabeza;
        private int cantidad;

        public ListaLibros()
        {
            cabeza = null;
            cantidad = 0;
        }

        public void AgregarLibro(Libro valor)
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

        public void EliminarLibro(string titulo)
        {
            if (cabeza != null)
            {
                if (cabeza.ValorLib.Titulo == titulo)
                {
                    cabeza = cabeza.Siguiente;
                    cantidad--;
                }
                else
                {
                    Nodo temp = cabeza;
                    while (temp.Siguiente != null)
                    {
                        if (temp.Siguiente.ValorLib.Titulo == titulo)
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

        public Libro BuscarLibro(string titulo)
        {
            Nodo temp = cabeza;
            while (temp != null)
            {
                if (temp.ValorLib.Titulo == titulo)
                {
                    return temp.ValorLib;
                }
                temp = temp.Siguiente;
            }
            return null;
        }

        public int Cantidad { get { return cantidad; } }    

        public string MostrarLibros()
        {
            string lista = "";
            Nodo temp = cabeza;
            while (temp != null)
            {
                lista += temp.ValorLib.Titulo + "\r\n" + temp.ValorLib.Autor + "\r\n" + temp.ValorLib.Categoria + "\r\n";
                temp = temp.Siguiente;
            }
            return lista;
        }
    }
}
