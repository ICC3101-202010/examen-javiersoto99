using System;
using System.Collections.Generic;

namespace Examen
{
    public class Equipo
    {
        public List<Jugador> jugadores;
        public Entrenador dt;
        public Medico med;
        public string name;
        public string categoria;

        public Equipo(string name, string categoria, List<Jugador>jugadores, Entrenador dt, Medico med)
        {
            this.name = name;
            this.categoria = categoria;
            this.jugadores = jugadores;
            this.dt = dt;
            this.med = med;

        }

        public void mostrarJugadores()
        {
            foreach(Jugador j in jugadores)
            {
                j.InfoJ();
            }
        }

        public void mostrarEquipo()
        {
            Console.WriteLine("Nombre Equipo : "+name);
            Console.WriteLine("Categoria : "+categoria);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("PERSONAL");
            Console.WriteLine("Entrenador : ");
            dt.InfoE();
            Console.WriteLine("");
            Console.WriteLine("Medico: ");
            med.InfoM();
            Console.WriteLine("");
            Console.WriteLine("Jugadores: ");
            mostrarJugadores();

        }

        public bool verificarEquipo()
        {
            int contador = 0;
            string nbase = jugadores[0].nacion;
            foreach(Jugador j in jugadores)
            {
                if(j.nacion == nbase)
                {
                    contador++;
                }
                
            }
            if(contador < 15)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
