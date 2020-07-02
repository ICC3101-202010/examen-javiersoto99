using System;

namespace Examen
{
    public class Medico : Persona
    {
        public int xp;
        public Medico(string nombre, int edad, string nacion, int sueldo, int xp): base(nombre,edad,nacion,sueldo)
        {
            this.xp = xp;
        }
        public void InfoM()
        {
            Console.WriteLine(InfoPer() + " Puntos de Experiencia: " + xp);
        }
    }
}
