using LosMejoresDeLaClase.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LosMejoresDeLaClase.Clases
{
    public class PrintConsola : IJugador
    {

        string? propiedadA;
        int propiedadB;
        public static void PrintDatosDeObjetos(object objeto)
        {
            Type tipoObjeto = objeto.GetType();
            foreach (var propiedad in tipoObjeto.GetProperties())
            {
                Console.WriteLine($"{propiedad.Name}: {propiedad.GetValue(objeto)}");
            }

        }


        private void Estructura(object objeto, string propiedad1, string propiedad2)
        {
            this.propiedadA = Convert.ToString(objeto.GetType().GetProperty(propiedad1).GetValue(objeto, null));
            this.propiedadB = Convert.ToInt32(objeto.GetType().GetProperty(propiedad2).GetValue(objeto, null));
        }

        public void ColocarPase(object objeto)
        {
            Estructura(objeto, "Nombre", "Pase");

            Console.WriteLine($"{propiedadA} coloco un pase con valor {propiedadB} de propiedad");
        }


        public void Correr(object objeto)
        {
            Estructura(objeto, "Nombre", "Velocidad");

            Console.WriteLine($"{propiedadA} corrio con: {propiedadB} de propiedad");

        }

        public void Defender(object objeto)
        {
            Estructura(objeto, "Nombre", "Defensa");

            Console.WriteLine($"{propiedadA} defendio con: {propiedadB} de propiedad");
        }

        public void Regatear(object objeto)
        {
            Estructura(objeto, "Nombre", "Regate");

            Console.WriteLine($"{propiedadA} regateo con: {propiedadB} de propiedad");
        }

        public void Rematar(object objeto)
        {
            Estructura(objeto, "Nombre", "Tiro");

            Console.WriteLine($"{propiedadA} remato con: {propiedadB} de propiedad");
        }

        public void SoportarEmbate(object objeto)
        {
            Estructura(objeto, "Nombre", "Fisico");

            Console.WriteLine($"{propiedadA} soporto el embate con: {propiedadB} de propiedad");
        }
    }
}
