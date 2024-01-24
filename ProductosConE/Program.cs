


using ProductosConE;



Producto producto1 = new Producto(1, "Manzana");
Producto producto2 = new Producto(2, "Pera");
Producto producto3 = new Producto(3, "Sandia");
Producto producto4 = new Producto(4, "Melon");
Producto producto5 = new Producto(5, "Banana");
Producto producto6 = new Producto(6, "Naranje");


Producto[] productosArray = { producto1, producto2, producto3, producto4, producto5, producto6 };


ProductosConEr nuevaLista=  new ProductosConEr();

nuevaLista.AgregarArrayALaLista(productosArray);

var listaMostrada= nuevaLista.MostrarLista();


foreach(var item in listaMostrada)
{
    Console.WriteLine(item.Descripcion);
}

