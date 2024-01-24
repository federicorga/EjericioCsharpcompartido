using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductosConE
{
    public class Producto
    {
        private int codigo;
        private string descripcion;

        public Producto(int codigo, string descripcion) {
            this.codigo = codigo;
            this.descripcion = descripcion;
        
        
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}
