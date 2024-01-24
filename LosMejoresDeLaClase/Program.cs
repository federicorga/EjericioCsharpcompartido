
using LosMejoresDeLaClase.Clases;


Jugador messi = new Messi("Messi", 21, 22, 23, 25, 26, 27);
Ronaldo ronaldo = new Ronaldo("Ronaldo", 39, 38, 37, 36, 35, 34);


PrintConsola.PrintDatosDeObjetos(messi);
Console.WriteLine("\n");
PrintConsola.PrintDatosDeObjetos(ronaldo);
Console.WriteLine("\n");



PrintConsola.Imprimir(messi.Nombre, messi.ColocarPase(),"Coloco un pase");
PrintConsola.Imprimir(messi.Nombre, messi.Rematar(), "Remato");
PrintConsola.Imprimir(messi.Nombre, messi.Correr(), "Corrio");
PrintConsola.Imprimir(messi.Nombre, messi.SoportarEmbate(), "Soporto Embate");
PrintConsola.Imprimir(messi.Nombre, messi.Regatear(), "Regateo");
PrintConsola.Imprimir(messi.Nombre, messi.Defender(), "Defendio");

Console.WriteLine("\n");

PrintConsola.Imprimir(ronaldo.Nombre, ronaldo.ColocarPase(), "Coloco un pase");
PrintConsola.Imprimir(ronaldo.Nombre, ronaldo.Rematar(), "Remato");
PrintConsola.Imprimir(ronaldo.Nombre, ronaldo.Correr(), "Corrio");
PrintConsola.Imprimir(ronaldo.Nombre, ronaldo.SoportarEmbate(), "Soporto Embate");
PrintConsola.Imprimir(ronaldo.Nombre, ronaldo.Regatear(), "Regateo");
PrintConsola.Imprimir(ronaldo.Nombre, ronaldo.Defender(), "Defendio");




