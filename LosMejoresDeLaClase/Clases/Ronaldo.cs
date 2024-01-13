using LosMejoresDeLaClase.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LosMejoresDeLaClase.Clases
{
    public class Ronaldo : Jugador
    {
        public Ronaldo(string nombre, int defensa, int fisico, int velocidad, int tiro, int regate, int pase) : base(nombre, defensa, fisico, velocidad, tiro, regate, pase)
        {
        }

    }
}

