using System;
namespace MisPrimerosPasos1
{
    public class Items

    {
        public string nombreItems; 
        public int costeItems; // el coste de items depede el item que querramos eso se debe farmear
        public int numeroItems; // varidad de cantidad de items que puede mejorar al personaje
        public string fucionItem; // se puede combinar el item para mejorarlo
        public string atributosItems; // atributos de mejora puede ser daño movimiento etc 
        public string habilidadItems; // otorga una habilidad especifica al personaje
        public string caracteristicaItems; // información del item
        public int equipacionItems; //solo permite equipar uno
        public int minutoItems; // minuto que parece los items de jugla
        public int mejoraDañoItems; // daño base del personaje

        public void Informacion()
        {
            Console.WriteLine("Coste de la compra del item.........");
            Console.Write("¿Cuanto fue el coste del item?: ");
            costeItems = int.Parse(Console.ReadLine());
            costeItems = costeItems + 0;
            Console.WriteLine("El coste del item fue: " + costeItems + " de oro. ");
            Console.ReadLine();
            Console.WriteLine("Gracias por ver la información del item ......");
            Console.ReadLine();

        }

        public void AgregarHabilidad()
        {
            Console.Write("¿Que habilidad le dio el item a tu  personaje?: ");
            habilidadItems= Console.ReadLine();
            var especialidad = "La nueva habilidad agregada es: " + habilidadItems;
            Console.WriteLine(especialidad);
            Console.ReadLine();
            this.Informacion();
            
        }

        public void Datos()
        {
            Console.WriteLine("Bienvenido a la elección de items para su personaje ");
            Console.ReadLine();
            Console.WriteLine("El nombre del item es: " + this.nombreItems + "\nLa equipación permitida del item es de : " + this.equipacionItems + "\nCon mejora de daño de : " + this.mejoraDañoItems);
            Console.ReadLine();
            Console.WriteLine("Mas información del item adquerido: ");
            Console.ReadLine();
            this.Stacks();
        }
        public void Stacks()
        {
            Console.WriteLine("Posee los siguientes atributos: ");
            atributosItems = "Aumento de la defensa en 13% y 20 velocidad de ataque";
            Console.WriteLine(atributosItems);
            Console.ReadLine();
            this.General();

        }

        public void General()
        {
            caracteristicaItems = "La caracteristica principal del item: " + caracteristicaItems;
            Console.WriteLine(caracteristicaItems);
            this.AgregarHabilidad();
        }
    }
}


