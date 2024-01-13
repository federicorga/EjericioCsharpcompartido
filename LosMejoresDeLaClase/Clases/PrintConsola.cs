using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LosMejoresDeLaClase.Clases
{
    public static class PrintConsola
    {
        public static void PrintDatos(Jugador objeto) 
        {
            Console.WriteLine($"El nombre es: {objeto.Nombre}");
            Console.WriteLine($"El Tiro es: {objeto.Tiro}");
            Console.WriteLine($"El Pase es: {objeto.Pase}");
            Console.WriteLine($"El Velocidad es: {objeto.Velocidad}");
            Console.WriteLine($"El Defensa es: {objeto.Defensa}");
            Console.WriteLine($"El Fisico es: {objeto.Fisico}");
            Console.WriteLine($"El Regate es: {objeto.Regate}");
        }

    }
}
