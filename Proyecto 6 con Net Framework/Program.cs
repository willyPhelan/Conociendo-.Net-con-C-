using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_6_con_Net_Framework {
    internal class Program {
        static void Main(string[] args) {

            // FUNCIONES

            Console.WriteLine(saludar("Willy")) ; 

            Console.ReadKey() ; 
            
            sumarPorValor(2,19) ;

            int b = 10 ; 

            sumarPorValor(1, b) ; //  por valor

           int result = sumar(2, ref b) ; // por referencia 

        }
        static int sumar(int a, ref int b) {

            return a + b ;
        }

        static int sumarPorValor(int a,  int b) {

            return a + b ;
        }
        static string saludar(string nombre) {

            return "Hola " + nombre ; }
    
} }