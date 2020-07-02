using System;

namespace Examen
{
    public class Jugador : Persona
    {
        public int ataque;
        public int defensa;
        public int numero;

        public Jugador(string nombre, int edad, string nacion, int sueldo, int ataque, int defensa, int numero) : base(nombre, edad, nacion,sueldo)
        {
            this.ataque = ataque;
            this.defensa = defensa;
            this.numero = numero;
        }

        public void InfoJ()
        {
            Console.WriteLine(InfoPer() + " Numero Camiseta: " + numero + " Puntos de Ataque: " + ataque + " Puntos de Defensa: " + defensa);
        }

        
    }
}
