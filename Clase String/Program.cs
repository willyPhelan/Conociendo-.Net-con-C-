using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_String {
    internal class Program {
        static void Main(string[] args) {

        string nombre = "Maxi" ; 

        nombre = "Hola" + nombre ;

        int cantidad = nombre.Length ; 

        nombre = nombre.ToUpper() ;
        nombre = nombre.ToLower() ;

        nombre = nombre.Replace('a', 'e') ; // cambia la letra "a" que aparesca en el string por "e" 
        
        nombre = nombre.Replace("Hola", "Chau") ; // puedo cambiar palabras enteras
        
        }
    }
}
