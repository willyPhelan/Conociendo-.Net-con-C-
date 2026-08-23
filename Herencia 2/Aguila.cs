using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_2 {
    internal class Aguila:AnimalSalvaje, Flyers { // Flyers es una interfaz

        public string volar() {

            return "Vuela" ; 
        }
    
    }
}
