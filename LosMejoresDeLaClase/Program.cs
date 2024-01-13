
using LosMejoresDeLaClase.Clases;


Jugador Messi = new Messi("Messi", 21, 22, 23, 25, 26, 27);
Jugador Ronaldo = new Ronaldo("Ronaldo", 39, 38, 37, 36, 35, 34);
PrintConsola printConsola = new PrintConsola();


PrintConsola.PrintDatosDeObjetos(Messi);
Console.WriteLine("\n");
PrintConsola.PrintDatosDeObjetos(Ronaldo);
Console.WriteLine("\n");

printConsola.ColocarPase(Messi);
printConsola.ColocarPase(Ronaldo);
Console.WriteLine("\n");
printConsola.Correr(Messi);
printConsola.Correr(Ronaldo);
Console.WriteLine("\n");
printConsola.Defender(Messi);
printConsola.Defender(Ronaldo);
Console.WriteLine("\n");
printConsola.Rematar(Messi);
printConsola.Rematar(Ronaldo);
Console.WriteLine("\n");
printConsola.Regatear(Messi);
printConsola.Regatear(Ronaldo);
Console.WriteLine("\n");
printConsola.SoportarEmbate(Messi);
printConsola.SoportarEmbate(Ronaldo);
