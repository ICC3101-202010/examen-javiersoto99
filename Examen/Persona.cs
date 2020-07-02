using System;

namespace Examen
{
    public class Persona : IPersona
    {
        public string nombre;
        public int edad;
        public string nacion;
        public int sueldo;
        public Persona(string nombre, int edad , string nacion , int sueldo)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.nacion = nacion;
            this.sueldo = sueldo;
        }

        public string InfoPer()
        {
            return ("Nombre: "+ nombre+" Edad: "+edad+" Nacion: "+nacion+" Sueldo: "+sueldo);
        }
    }

}
