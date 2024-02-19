using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Unimar
{
    public class Alumno
    {
        private string nombre;
        private string apellido;
        private string cedula;
        private string carrera;

        //Metodo constructor
        public Alumno(string nombre, string apellido, string cedula, string carrera)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.cedula = cedula;
            this.carrera = carrera;
        }
        //Metodos de acceso nombre
        public string Nombre { get {  return nombre; } }
        //Metodos de acceso apellido
        public string Apellido { get { return apellido; } }
        //Metodos de acceso cedula
        public string Cedula { get { return cedula; } }
        //Metodos de acceso carrera
        public string Carrera { get { return carrera; } }

        public string MostrarAlumno()
        {
            return "Nombre: " + nombre + " Apellido: " + apellido + " Cedula: " + cedula + " Carrera: " + carrera;
        }
        
    }
}
