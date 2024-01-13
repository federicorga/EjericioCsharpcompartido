using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LosMejoresDeLaClase.Interfaces;

namespace LosMejoresDeLaClase.Clases
{

    public abstract class Jugador : IJugador
    {
        private string nombre;
        private int defensa;
        private int fisico;
        private int velocidad;
        private int tiro;
        private int regate;
        private int pase;

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

        

        public virtual int MostrarDefensa()
        {
            return Defensa;
        }

        public virtual int MostrarFisico()
        {
            return Fisico;
        }

        public virtual string MostrarNombreJugador()
        {
            return Nombre;
        }

        public virtual int MostrarPase()
        {
            return Pase;
        }

        public virtual int MostrarRegate()
        {
            return Regate;
        }

        public virtual int MostrarTiro()
        {
            return Tiro;
        }

        public virtual int MostrarVelocidad()
        {
            return Velocidad;
        }


    }
}
