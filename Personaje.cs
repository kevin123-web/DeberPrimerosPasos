using System;

namespace MisPrimerosPasos1
{
    public class Personajes

    {
        public string nombrePersonaje;
        public int progresoPersonaje; // cuando se juega  se completa misiones para el personaje
        public int victoriasPersonaje;
        public int derrotasPersonaje;
        public string generoPersonaje;
        public string habilidadesPersonaje; // cada personaje tiene diferente hablidad
        public string especialidadPersonaje; // se distinguen por agildiad fuerza y inteligencia
        public string equipacionPerosnaje; // aspectos que el persoanje se vea diferente
        public int partidasPersonaje;
        public int dañoPersonaje; // daño base por personaje

        public void Racha()
        {
            Console.WriteLine("Verificación de partidas jugadas.......");
            Console.Write("¿Cuantas partidas jugaste con el personaje ?: ");
            partidasPersonaje = int.Parse(Console.ReadLine());
            partidasPersonaje = partidasPersonaje + 0;
            Console.WriteLine("Las partidas jugadas con el personaje son  " + partidasPersonaje + " partidas . ");
            Console.ReadLine();
            Console.WriteLine("Gracias por elegir a su personaje disfrute de la partida......");
            Console.ReadLine();

        }

        public void Definicion()
        {
            Console.Write("¿Que especialidad es tu personaje?: ");
            especialidadPersonaje = Console.ReadLine();
            var especialidad = "Tu personaje es de: " + especialidadPersonaje;
            Console.WriteLine(especialidad);
            Console.ReadLine();
            this.Generalidad();
        }

        public void Datos()
        {
            Console.WriteLine("Bienvenido a la elección de personajes ");
            Console.ReadLine();
            Console.WriteLine("Su personaje es: " + this.nombrePersonaje + "\nTiene las siguientes hablidades: " + this.habilidadesPersonaje + "\nCon un daño incial de : " + this.dañoPersonaje);
            Console.ReadLine();
            Console.WriteLine("Mas información del personaje: ");
            Console.ReadLine();
            this.Definicion();
        }
        public void Sets()
        {
            Console.WriteLine("Posee el siguiente set: ");
            equipacionPerosnaje = "El zorro plateado";
            Console.WriteLine(equipacionPerosnaje);
            Console.ReadLine();
            this.Racha();
 
        }

        public void Generalidad()
        {
            especialidadPersonaje = "El personaje elegido es un personaje de: " + especialidadPersonaje;
            Console.WriteLine(especialidadPersonaje);
            this.Sets();

        }
    }
}


