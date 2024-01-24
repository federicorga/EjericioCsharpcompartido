using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductosConE.EjemplosEnProgam
{
    public class EjemploProgramProductosConE
    {

        public void ProductoConEProgram()
        {


            Producto producto1 = new Producto(1, "Manzana");
            Producto producto2 = new Producto(2, "Pera");
            Producto producto3 = new Producto(3, "Sandia");
            Producto producto4 = new Producto(4, "Melon");
            Producto producto5 = new Producto(5, "Banana");
            Producto producto6 = new Producto(6, "Naranje");


            Producto[] productosArray = { producto1, producto2, producto3, producto4, producto5, producto6 };



            Console.WriteLine($"El tamaño del Producto Array es: {productosArray.Length}");

            //Ambas formas son iguales con For o Foreach

            Console.WriteLine("Esto es For");

            for (int i = 0; i < productosArray.Length; i++)
            {
                Console.WriteLine($"Esto es el Codigo:{productosArray[i].Descripcion} Esto es el nombre:{productosArray[i].Codigo}");

            }

            Console.WriteLine("Esto es Foreach");

            foreach (Producto producto in productosArray)
            {
                Console.WriteLine($"ESto es el codigo:{producto.Descripcion} Esto es el nombre:{producto.Codigo}");


            }



            List<Producto> listaProductosConE = new List<Producto>();

            for (int i = 0; i < productosArray.Length; i++)
            {
                if (productosArray[i].Descripcion.Contains("e") || productosArray[i].Descripcion.Contains("E"))
                {

                    listaProductosConE.Add(productosArray[i]);

                }

            }

            foreach (var item in listaProductosConE)
            {
                Console.WriteLine(item.Descripcion);
            }





        }
    }
}
