using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LosMejoresDeLaClase.Interfaces
{
    public interface IJugador
    {


        void Correr(object objeto);
        void Defender(object objeto);
        void Regatear(object objeto);
        void Rematar(object objeto);
        void ColocarPase(object objeto);
        void SoportarEmbate(object objeto);

    }
}
