using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_2 {
    internal class Program {
        static void Main(string[] args){

            // VARIABLES // INT FLOAT BOOL CHAR 
           // DOUBLE DECIMAL LONG SHORT STRING DATETIME

            int a, b , c ;

            float d, e ;

            Console.WriteLine("Buenos dias") ;

            Console.WriteLine("Ingrese un numero: ") ;

            a = int.Parse(Console.ReadLine()) ;

            b = 10 ;

            c = (a + b + 10) / 3 ;

            Console.WriteLine("El resultado es: " + c ) ; 

            Console.ReadKey() ;
        }
    }
}
