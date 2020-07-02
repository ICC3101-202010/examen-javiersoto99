using System;

namespace Examen
{
    public class Entrenador : Persona
    {
        public int tactica;

        public Entrenador(string nombre, int edad, string nacion, int sueldo, int tactica): base(nombre,edad,nacion,sueldo)
        {
            this.tactica = tactica;
        }
        public void InfoE()
        {
            Console.WriteLine(InfoPer() + " Puntos de Tactica: " + tactica);
        }
    }

   
    
}
