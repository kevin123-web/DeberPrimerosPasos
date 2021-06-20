using System;
namespace MisPrimerosPasos1
{
    public class Dota2
    {
        public string nombreJugador;
        public string apellidoJugador;
        public int edadJugador;
        public string direccion;
        public string correo;
        public string codigoPostal;
        public string generoJuego; // juego multijugador online 
        public string estado; //online o ofline
        public int saldo;
        public string medalla; //rango para edentificar el jugador

        public void Recarga()
        {
            Console.WriteLine("Verificación de saldo.......");
            Console.Write("¿Cuanto dinero recargaste ?: ");
            saldo = int.Parse(Console.ReadLine());
            saldo = saldo + 0;
            Console.WriteLine("Su saldo actual en la cuenta es de  " + saldo + " $ . ");
            Console.ReadLine();
            Console.WriteLine("Gracias por verificar los datos de su cuenta......");
            Console.ReadLine();

        }

        public void Rango()
        {
            Console.Write("¿Que medalla eres en el juego de Dota 2 ?: ");
            medalla = Console.ReadLine();
            var nivel = "Tu medalla es : " + medalla;
            Console.WriteLine(nivel);
            Console.WriteLine("Jugador con la medalla: " + medalla);
            Console.ReadLine();
            this.Recarga();
        }

        public void Datos()
        {
            Console.WriteLine("Bienvenido Jugador de Dota 2 ");
            this.Entretenimeinto();
            Console.ReadLine();
            Console.WriteLine("Su nombre es: " + this.nombreJugador + " " + this.apellidoJugador + "\nTiene: " + this.edadJugador + " años ");
            Console.ReadLine();
            Console.WriteLine("Aqui se le mostrara la información de su cuenta: ");
            Console.ReadLine();
            this.EstadoJugador();
        }
        public void EstadoJugador()
        {
            estado = "Jugador en linea";
            Console.WriteLine(estado);
            Console.ReadLine();
            this.Rango();
        }

        public void Entretenimeinto()
        {
            generoJuego = "Juego Online donde podra jugar multijugador .";
            Console.WriteLine(generoJuego);

        }
    }
}