using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_911
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Central_911 Llamada1 = Central_911.Obtener_Instancia();
            Central_911 Llamada2 = Central_911.Obtener_Instancia();

            Operador op1 = new Operador(1, "Laura");
            Operador op2 = new Operador(2, "Carlos");
            Operador op3 = new Operador(3, "María");
            Operador op4 = new Operador(4, "José");
            Operador op5 = new Operador(5, "Ana");
            Operador op6 = new Operador(6, "Pedro");
            Operador op7 = new Operador(7, "Sofía");
            Operador op8 = new Operador(8, "Miguel");

            Console.WriteLine("=== LLAMADAS A LA CENTRAL 911 ===\n");

            Llamada1.ConectarLlamada(op1, "Incendio");
            Llamada2.ConectarLlamada(op2, "Violeta");
            Llamada1.ConectarLlamada(op3, "Accidente");
            Llamada2.ConectarLlamada(op4, "Intento de suicidio");
            Llamada1.ConectarLlamada(op5, "Incendio");
            Llamada2.ConectarLlamada(op1, "Accidente");
            Llamada1.ConectarLlamada(op2, "Violeta");
            Llamada2.ConectarLlamada(op3, "Incendio");
            Llamada1.ConectarLlamada(op4, "Violeta");
            Llamada2.ConectarLlamada(op5, "Accidente");
            Llamada1.ConectarLlamada(op6, "Intento de suicidio");
            Llamada2.ConectarLlamada(op7, "Incendio");
            Llamada1.ConectarLlamada(op8, "Violeta");
            Llamada2.ConectarLlamada(op6, "Accidente");
            Llamada1.ConectarLlamada(op7, "Intento de suicidio");

            // VERIFICACIÓN 
            Console.WriteLine("\n=================================");
            Console.WriteLine("VERIFICACIÓN DE SINGLETON:");
            Console.WriteLine("=================================");
            Console.WriteLine("ReferenceEquals: " + ReferenceEquals(Llamada1, Llamada2));
            Console.WriteLine($"HashCode Llamada1: {Llamada1.GetHashCode()}");
            Console.WriteLine($"HashCode Llamada2: {Llamada2.GetHashCode()}");
            Console.WriteLine($"Total operadores: 8");
            Console.WriteLine($"Total llamadas: 15");
            Console.WriteLine("=================================");

            Console.ReadKey();
        }
    }
}