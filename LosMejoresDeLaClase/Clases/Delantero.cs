using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LosMejoresDeLaClase.Clases
{
    public class Delantero : Jugador
    {
        private string posicionDelantero;
        public Delantero(string posicionDelantero, string nombre, int defensa, int fisico, int velocidad, int tiro, int regate, int pase) : base(nombre, defensa, fisico, velocidad, tiro, regate, pase)
        {
            this.posicionDelantero = posicionDelantero;
        }

        public override string MostrarNombreJugador()
        {            
            return Nombre;            
        }

        public override int MostrarDefensa()
        {          
            return Defensa;
        }

        public override int MostrarFisico()
        {            
            return Fisico;
        }

        public override int MostrarRegate()
        {            
            return Regate;
        }

        public override int MostrarTiro()
        {            
            return Tiro;
        }

        public override int MostrarVelocidad()
        {            
            return Velocidad;
        }

        public override int MostrarPase()
        {            
            return Pase;
        }
    }
}
