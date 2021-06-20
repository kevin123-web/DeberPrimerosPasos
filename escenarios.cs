using System;
namespace MisPrimerosPasos1
{
    public class Escenarios
    {
        public string nombreEscenario;
        public int arboles;
        public int distancia;// distancia entre arboles
        public string camino;// celda donde el personaje camina 
        public int duraccionCreeps;// salen creeps apartir de un minuto
        public int stacksCreeps;// 30 segundos stackear creeps neutrales
        public int autoregeneracionArboles; // si un arbol es cortado o destuido se regenera 
        public string torres; // torres aliadas y enemigas en la cual deben ser destruidas
        public string fuente; // destruir la fuente otorga la victoria
        public string radar; //  para informar a los aliados el  putno de reunion

        public void Tiempo()
        {
            Console.WriteLine("Verificación de tiempos para los creeps.......");
            Console.Write(" El stack neutral se realiza cada: " + stacksCreeps + " segundos ");
            Console.WriteLine(" El tiempo de la salida de los creeps es de  " + duraccionCreeps + " minuto ");
            Console.ReadLine();
            Console.WriteLine("Gracias por verificar los tiempos......");
            Console.ReadLine();
        }

        public void Radiant()
        {
            Console.Write("¿Que lado has elegido en el escenario ?: ");
            torres = Console.ReadLine();
            var edificio = "Tu torre es : " + torres;
            Console.WriteLine(edificio);
            Console.WriteLine("Jugador usted eligio: " + torres);
            Console.ReadLine();
            this.Celda();
        }

        public void Datos()
        {
            Console.WriteLine("Bienvenido al escenario del juego ");
            this.GanarPartida();
            Console.ReadLine();
            Console.WriteLine("El nombre del escenario: " + this.nombreEscenario + "\nTiene: " + this.arboles + " arboles " + "\nLa distancia entre ellos es de: " + this.distancia + " metros ");
            Console.ReadLine();
            Console.WriteLine("Información del escenario: ");
            Console.ReadLine();
            this.Radiant();
        }
        public void Celda()
        {
            camino = "Dirigete a la celda superior medio o inferior";
            Console.WriteLine(camino);
            Console.ReadLine();
            this.Tiempo();
        }

        public void GanarPartida()
        {
            fuente = "Jugador recuerde que para ganar la partida debe destruir la fuente enemiga.";
            Console.WriteLine(fuente);

        }
    }
}