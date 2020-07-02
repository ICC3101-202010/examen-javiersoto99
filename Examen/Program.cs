using System;
using System.Collections.Generic;
using System.Linq;

namespace Examen
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido!");
            List<Equipo> equipos = new List<Equipo>();
            int eleccion = 0;
            while(eleccion != 3)
            {
                
                
                Console.WriteLine("[1] Crear un Equipo AUTOMATICAMENTE");
                Console.WriteLine("[2] Opciones de mi Equipo");
                Console.WriteLine("[3] SALIR");
                eleccion = Convert.ToInt32(Console.ReadLine());

                switch (eleccion)
                {
                    case 1:
                        List<Jugador> jugadores = new List<Jugador>();
                        Jugador j1 = new Jugador("Javier", 21, "Chile", 10000, 99, 20, 11);
                        Jugador j2 = new Jugador("Vicente", 21, "Chile", 5000, 78, 55, 13);
                        Jugador j3 = new Jugador("Nicolas", 26, "Chile", 1200, 55, 39, 4);
                        Jugador j4 = new Jugador("Andres", 19, "Chile", 65000, 84, 31, 17);
                        Jugador j5 = new Jugador("Alexis", 29, "Chile", 200000, 90, 25, 7);
                        Jugador j6 = new Jugador("Charles", 26, "Chile", 105000, 85, 78, 20);
                        Jugador j7 = new Jugador("Arturo", 28, "Chile", 30000, 80, 80, 8);
                        Jugador j8 = new Jugador("Eduardo", 27, "Chile", 18000, 86, 20, 9);
                        Jugador j9 = new Jugador("Claudio", 21, "Chile", 34000, 15, 95, 1);
                        Jugador j10 = new Jugador("Leonardo", 21, "Chile", 100, 20, 20, 98);
                        Jugador j11 = new Jugador("Gary", 28, "Chile", 300000, 78, 95, 3);
                        Jugador j12 = new Jugador("Martin", 17, "Chile", 1000, 84, 10, 24);
                        Jugador j13 = new Jugador("Jose", 20, "Chile", 9000, 68, 50, 6);
                        Jugador j14 = new Jugador("Carlos", 26, "Chile", 4300, 67, 78, 18);
                        Jugador j15 = new Jugador("Lian", 18, "Chile", 7900, 80, 15, 47);

                        jugadores.Add(j1);
                        jugadores.Add(j2);
                        jugadores.Add(j3);
                        jugadores.Add(j4);
                        jugadores.Add(j5);
                        jugadores.Add(j6);
                        jugadores.Add(j7);
                        jugadores.Add(j8);
                        jugadores.Add(j9);
                        jugadores.Add(j10);
                        jugadores.Add(j11);
                        jugadores.Add(j12);
                        jugadores.Add(j13);
                        jugadores.Add(j14);
                        jugadores.Add(j15);

                        Entrenador dt = new Entrenador("Reinaldo", 58, "Colombia", 200000, 1);
                        Medico med = new Medico("Sebastian", 42, "Argentina", 3000, 86);

                        Equipo equipoA = new Equipo("Examen FC", "Nacional", jugadores, dt, med);
                        equipos.Add(equipoA);
                        Console.WriteLine("Se ha creado su equipo con exito.");




                        break;


                    case 2:
                        Console.Clear();
                        if(equipos.Count() == 0)
                        {
                            Console.WriteLine("No hay equipos por el momento...");
                            break;
                        }
                        else
                        {
                            int elec = 0;
                            while(elec != 3)
                            {
                                Console.WriteLine("[1] Mostrar Equipo");
                                Console.WriteLine("[2] Verificar Equipo");
                                Console.WriteLine("[3] Volver");
                                elec = Convert.ToInt32(Console.ReadLine());
                                switch (elec)
                                {
                                    case 1:
                                        foreach (Equipo e in equipos)
                                        {
                                            Console.WriteLine("--------------------------------");
                                            e.mostrarEquipo();

                                            Console.WriteLine("--------------------------------");
                                        }
                                        break;

                                    case 2:
                                        foreach(Equipo e in equipos)
                                        {
                                            if (e.verificarEquipo())
                                            {
                                                Console.WriteLine(e.name + " tiene todos los jugadores de la misma nacionalidad");
                                            }
                                            else
                                            {
                                                Console.WriteLine(e.name+" no tiene todos los jugadores de la misma nacionalidad");
                                            }
                                        }
                                        break;
                                    case 3:
                                        break;
                                    default:
                                        Console.WriteLine("Opcion invalida...");
                                        break;

                                }
                            }
                            break;
                            

                           
                            
                        }
                    case 3:
                        break;

                    default:
                        Console.WriteLine("Opcion Invalida... Intentelo nuevamente");
                        break;
                }
            }

            Console.WriteLine("Hasta pronto!");
        }
    }
}
