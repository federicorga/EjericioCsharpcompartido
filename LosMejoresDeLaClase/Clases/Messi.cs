using LosMejoresDeLaClase.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LosMejoresDeLaClase.Clases
{
    public class Messi :Jugador
    {
        public Messi(string nombre, int defensa, int fisico, int velocidad, int tiro, int regate, int pase) : base(nombre, defensa, fisico, velocidad, tiro, regate, pase)
        {
        }


    /*
        public override int Correr()
        {
            return base.Correr();
        }
        public override int Defender()
        {
            return base.Defender();
        }
        public override int Regatear()
        {
            return base.Regatear();
        }

        public override int Rematar()
        {
            return base.Rematar();
        }

        public override int SoportarEmbate()
        {
            return base.SoportarEmbate();
        }

        public override int ColocarPase()
        {
            return base.ColocarPase();
        }
    */
        
     }
}

