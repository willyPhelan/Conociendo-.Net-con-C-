using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_2 {
    internal class Perro:AnimalDomestico{

        public override string Comunicarse() { // sobrescritura de metodo
            
            return "Guau Guau" ;
        }

    }
}
