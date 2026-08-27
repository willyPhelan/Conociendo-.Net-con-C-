using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jerarquía_de_Animales__Herencia_ {
    public interface IAnimal {

        // Propiedades requeridas por la interfaz
        string Nombre { get ; set ; }
        int Edad { get ; set ; }

        // Métodos que deben implementar las clases
        void Describir() ;
        string HacerSonido() ;
        void Atender() ; 
    }
}
