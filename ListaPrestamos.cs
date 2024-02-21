using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Unimar
{
    public class ListaPrestamos
    {
        private Nodo cabeza;
        private int cantidad;

        public ListaPrestamos()
        {
            cabeza = null;
            cantidad = 0;
        }

        public void AgregarPrestamo(Prestamo valor)
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

        public void EliminarPrestamo(string cedula)
        {
            if (cabeza != null)
            {
                if (cabeza.ValorPres.Cedula == cedula)
                {
                    cabeza = cabeza.Siguiente;
                    cantidad--;
                }
                else
                {
                    Nodo temp = cabeza;
                    while (temp.Siguiente != null)
                    {
                        if (temp.Siguiente.ValorPres.Cedula == cedula)
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

        public string MostrarPrestamos()
        {
            string lista = "";
            Nodo temp = cabeza;
            while (temp != null)
            {
                lista += temp.ValorPres.MostrarPrestamo() + "\n";
                temp = temp.Siguiente;
            }
            return lista;
        }   
    }
}
