using System;

namespace MisPrimerosPasos1
{
    class Program
    {
        static void Main(string[] args)
        {
            VerificacionDatos(args);
            PersonajeElegido(args);
            ItemsJuego(args);
            EscenariosJuego(args);
            Misiones desafio = new Misiones();
            desafio.nombreMision = "Batle pass 2021";
            desafio.destuirWards = 5;
            desafio.matarEnemigos = 10;
            desafio.dañosEstructuras = 55000;
            desafio.realizarDaño = 25000;
            desafio.Datos();

        }
        static void EscenariosJuego(string[] args)
        {
            Escenarios mapa = new Escenarios();
            mapa.nombreEscenario = "Mundo abismal";
            mapa.stacksCreeps = 5;
            mapa.duraccionCreeps = 1;
            mapa.arboles = 550;
            mapa.distancia =25;
            mapa.Datos();

        }

        static void ItemsJuego(string[] args)
        {
           
            Items articulo = new Items();
            articulo.nombreItems = "Coraza de Asalto";
            articulo.costeItems = 7550;
            articulo.mejoraDañoItems = 47;
            articulo.equipacionItems =1;
            articulo.caracteristicaItems="Mejora de defensa";
            articulo.Datos();

        }
        static void PersonajeElegido(string[] args)
        {
            Personajes heroe = new Personajes();
            heroe.nombrePersonaje = "Sniper";
            heroe.habilidadesPersonaje = "Metralla , Disparo a la cabeza";
            heroe.partidasPersonaje = 250;
            heroe.dañoPersonaje = 47;
            heroe.especialidadPersonaje = "Agilidad";
            heroe.Datos();

        }
        static void VerificacionDatos(string[] args)
        {
            Dota2 dato = new Dota2();
            dato.nombreJugador = "Kevin";
            dato.apellidoJugador = "Motoche";
            dato.edadJugador = 20;
            dato.saldo = 60;
            dato.Datos();

        }
    }
}   