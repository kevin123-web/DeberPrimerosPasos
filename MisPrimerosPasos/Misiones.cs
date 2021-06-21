using System;
namespace MisPrimerosPasos1
{
    public class Misiones
    {
        public string nombreMision;
        public int destuirWards; //  los wards son objetos que dan vision al mapa
        public int matarEnemigos;
        public string recolectarRunas;//las runas dan oro extra a aliados
        public int consumirMana;// mana es el espameo de habilidades si se agota no podra usar las habilidades
        public int realizarDaño;
        public int dañosEstructuras; 
        public string espameoHabilidades; // habilidades que puede ser dadas por un personaje
        public string revelarEnemigosInvisibles; // son objetos que ayudan a ver enemigos invisibles
        public string curaAliados;  

        public void MisionFinal()
        {
            Console.WriteLine("Verificación de las misiones.......");
            Console.Write(" Debes hacer : " + dañosEstructuras + " a estructuras ");
            Console.WriteLine(" El daño realizado debe ser mayor a  " + realizarDaño + " de daño ");
            Console.ReadLine();
            Console.WriteLine("Gracias por ver las misiones......");
            Console.ReadLine();
        }

        public void MisionIncial()
        {
            Console.Write("¿Que mision has elegido ?: ");
            curaAliados = Console.ReadLine();
            var cura = "La mision eleguida fue : " + curaAliados;
            Console.WriteLine(cura);
            Console.WriteLine("Jugador usted eligio: " + curaAliados + "aliados");
            Console.ReadLine();
            this.Runas();
        }

        public void Datos()
        {
            Console.WriteLine("Bienvenido a las misiones ");
            this.Habilidad();
            Console.ReadLine();
            Console.WriteLine("El nombre de la mision es: " + this.nombreMision + "\nTienes que destuir: " + this.destuirWards + " wards " + "\nDebes matar a: " + this.matarEnemigos + " enemigos ");
            Console.ReadLine();
            Console.WriteLine("Información de las misiones son: ");
            Console.ReadLine();
            this.MisionIncial();
        }
        public void Runas()
        {
            recolectarRunas = "Dirigete a la celda  medio para recolectar las runas";
            Console.WriteLine(recolectarRunas);
            Console.ReadLine();
            this.MisionFinal();
        }

        public void Habilidad()
        {
            espameoHabilidades = "Jugador recuerde que tiene ganar la partida para que las misiones sean cumplidas.";
            Console.WriteLine(espameoHabilidades);

        }
    }
}