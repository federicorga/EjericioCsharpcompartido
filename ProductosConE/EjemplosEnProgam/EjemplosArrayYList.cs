using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductosConE.EjemplosEnProgam
{
    internal class EjemplosArrayYList
    {

        public void Ejemplo()
        {
            List<string> lista1 = new List<string>();

            string[] listaArrayNew = new string[8];


            lista1.Add("marcos");
            lista1.Add("Juan");
            lista1.Add("Adrian");
            lista1.Add("Enrique");

            lista1.Insert(0, "Pepe");

            Console.WriteLine(lista1.Contains("Juan"));
            lista1.Sort(); //ordena por orden alfabetico

            List<string> lista2 = lista1; //Mismo espacio de Memoria por referencia


            List<string> lista3 = new List<string>(lista1); //Diferente espacio de memoria por valor 

            lista3.Add("Pinocho");
            lista3.Clear();


            lista2.Add("Ricardo");


            Array listaArray = lista1.ToArray(); //transforma a Array

            Console.WriteLine("ListaArrayNew");

            Console.WriteLine(listaArrayNew.Length);

            Console.WriteLine("ListaArray");

            Console.WriteLine(listaArray.Length);

            Console.WriteLine("Lista2");

            Console.WriteLine(lista2.Count());

            Console.WriteLine("Lista3");

            Console.WriteLine(lista3.Count());

            foreach (var item in lista1)
            {
                Console.WriteLine(item);
            }

        }




    }
}
