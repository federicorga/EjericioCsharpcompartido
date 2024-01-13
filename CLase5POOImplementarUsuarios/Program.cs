

using CLase5ObjetosPOO.Clases;



Usuario usuario1 = new Usuario("Juan", "Perez", 321512312, "Juanperez@gmail.com", 21, "calle falsa 123");

Usuario usuario2 = new Usuario("Pepe", "Baez", 32544455, "pepebaez@gmail.com", 15, "la prida 222");

EsMayordEdad(usuario1);
EsMayordEdad(usuario2);




void EsMayordEdad(Usuario pepito){

    if (pepito.EsMayorEdad())
    {
        Console.WriteLine($"el usuario: {pepito.Name} es mayor de edad");

    }
    else
    {

        Console.WriteLine($"El usuario: {pepito.Name} es menor de edad");
    }

};






