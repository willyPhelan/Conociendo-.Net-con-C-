using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jerarquía_de_Animales__Herencia_ {
    internal static class RegistroVeterinaria {

       // Variable estática privada para mantener el contador en memoria
        private static int _contadorId = 0 ;

        // Método estático incremental
        public static int GenerarId() {

            _contadorId++ ;

            return _contadorId ;
        }


    }
}
