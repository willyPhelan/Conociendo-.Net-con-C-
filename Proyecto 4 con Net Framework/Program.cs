using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_4_con_Net_Framework {
    internal class Program {
        static void Main(string[] args) {

            // CICLOS // FOR WHILE DO WHILE FOREACH

            int a = 10 ;

            for (int i = 0 ; i < 10 ; i++) {

                while (a != 0) {

                    Console.WriteLine("El valor de i es: " + i) ;

                    a-- ;
                } 

                a = 10 ;
            } 
             
            Console.ReadKey() ;
        }
    }
}