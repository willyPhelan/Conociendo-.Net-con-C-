using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_3_con_Net_Framework {
    internal class Program {
        static void Main(string[] args) {

            // Condicionales // IF ELSE SWITCH CASE

            int a = 10 ;

            int b = 12 ;

            if (a == b && b != 10 || !(a == 20)){

                Console.WriteLine("Los numeros son iguales") ;

            } else { Console.WriteLine("Los numeros no son iguales") ; }

            switch (a) {

                case 1:

                break ;

                case 2:

                break ;

                default:

                break;

            }
        }
    }
}
