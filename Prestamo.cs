using System;

namespace Biblioteca_Unimar
{
    public class Prestamo
    {
        private string cedula;
        private string titulo;
        private DateTime fechaPrestamo;

        

        //Metodo constructor
        public Prestamo(string cedula, string titulo, DateTime fechaPrestamo)
        {
            this.cedula = cedula;
            this.titulo = titulo;
            this.fechaPrestamo = fechaPrestamo;
            
        }
        //Metodos de acceso cedula
        public string Cedula { get {  return cedula; } }

        //Metodos de acceso titulo
        public string Titulo { get { return titulo; } }
        //Metodos de acceso fechaPrestamo
        public DateTime FechaPrestamo { get { return fechaPrestamo; } }
        //Set de fechaPrestamo
        public void SetFechaPrestamo(DateTime fechaPrestamo)
        {
            this.fechaPrestamo = fechaPrestamo;
        }

        public string MostrarPrestamo()
        {
            return "Cedula: " + cedula + " Titulo: " + titulo;
        }



    }
}