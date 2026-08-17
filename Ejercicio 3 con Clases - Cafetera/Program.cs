using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3_con_Clases___Cafetera {
    internal class Program {
        static void Main(string[] args){

        Cafetera cafetera1 = new Cafetera(1000, 900) ;

        cafetera1.CargarAgua(50) ;

        cafetera1.MostrarEstado() ;
        
        cafetera1.ServirTaza() ;

        cafetera1.MostrarEstado() ;

        cafetera1.ServirTaza(130);

        cafetera1.CargarAgua(100) ;

        cafetera1.MostrarEstado() ;

        cafetera1.CargarAgua(10000) ;

        cafetera1.ServirTaza(10000) ;

        cafetera1.MostrarEstado() ;

        cafetera1.ServirTaza(10) ;

        }
    }
}
