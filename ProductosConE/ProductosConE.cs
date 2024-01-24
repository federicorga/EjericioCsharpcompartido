using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductosConE
{
    public class ProductosConEr
    {
       private List<Producto> listaProductosConE;

        public ProductosConEr()
        {

            this.listaProductosConE = new List<Producto>();
        }

        public List<Producto> MostrarLista()
        {
            return this.listaProductosConE;

        }

        public void AgregarArrayALaLista(Producto[] productosArray)
        {

            for (int i = 0; i < productosArray.Length; i++)
            {
                if (productosArray[i].Descripcion.Contains("e") || productosArray[i].Descripcion.Contains("E"))
                {

                    this.listaProductosConE.Add(productosArray[i]);

                }

            }
        }
        public void LimpiarLista()
        {
            this.listaProductosConE.Clear();
        }
    }
}
