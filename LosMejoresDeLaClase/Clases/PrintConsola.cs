using LosMejoresDeLaClase.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LosMejoresDeLaClase.Clases
{
    public static class PrintConsola
    {

       
    
        public static void PrintDatosDeObjetos(object objeto)
        {
            Type tipoObjeto = objeto.GetType();
            foreach (var propiedad in tipoObjeto.GetProperties())
            {
                Console.WriteLine($"{propiedad.Name}: {propiedad.GetValue(objeto)}");
            }

        }


        public static void Imprimir(object objeto, int metodo, string adicionalString)
        {
            Console.WriteLine($"{objeto} {adicionalString} con {metodo} de propiedad");
        }

    }
}
