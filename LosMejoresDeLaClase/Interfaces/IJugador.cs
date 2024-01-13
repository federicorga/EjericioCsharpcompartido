using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LosMejoresDeLaClase.Interfaces
{
    public interface IJugador
    {
        string MostrarNombreJugador();
        int MostrarVelocidad();
        int MostrarTiro();
        int MostrarRegate ();
        int MostrarDefensa();
        int MostrarPase();
        int MostrarFisico();

    }
}
