using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LosMejoresDeLaClase.Interfaces;

namespace LosMejoresDeLaClase.Clases
{

    public abstract class Jugador
    {
        protected string nombre;
        protected int defensa;
        protected int fisico;
        protected int velocidad;
        protected int tiro;
        protected int regate;
        protected int pase;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Defensa { get => defensa; set => defensa = value; }
        public int Fisico { get => fisico; set => fisico = value; }
        public int Velocidad { get => velocidad; set => velocidad = value; }
        public int Tiro { get => tiro; set => tiro = value; }
        public int Regate { get => regate; set => regate = value; }
        public int Pase { get => pase; set => pase = value; }

        public Jugador(string nombre, int defensa, int fisico, int velocidad, int tiro, int regate, int pase)
        {
            this.Nombre = nombre;
            this.Defensa = defensa;
            this.Fisico = fisico;
            this.Tiro = tiro;
            this.Regate = regate;
            this.Pase = pase;
            this.Velocidad = velocidad;
        }


    }
}
