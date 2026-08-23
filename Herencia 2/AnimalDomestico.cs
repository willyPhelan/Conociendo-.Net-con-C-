using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_2 {
    internal class AnimalDomestico:Animal {

    public string Nombre {get ; set ;}

        public override string ToString(){

            return "Animal: " + Nombre ;
        }
    
    
    }
}
