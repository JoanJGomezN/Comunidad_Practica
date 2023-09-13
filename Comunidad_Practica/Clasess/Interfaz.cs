using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comunidad_Practica.Clasess
{
    public interface Interfaz
    {
        void Guardar(MiembroComunidad miembro);

        void Modificar(MiembroComunidad miembro);

        void Borrar(MiembroComunidad miembro);

    }

}
