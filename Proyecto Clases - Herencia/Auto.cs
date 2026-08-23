using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Clases___Herencia {
    internal class Auto : Vehiculo {

        public Auto(){ Chasis = new Chasis() ; } // por composicion - el obj ya nace con chasis

        public int Anio { get; set; }

        public string Modelo { get ; set ; }
        
        public string duenio { get ; set ; }      

        // Composicion 

        public Chasis Chasis { get ;  }
        

        // Agregacion 

         public Motor Motor { get ; set ; } // agrego Motor a un obj ya creado

    
    }
}
