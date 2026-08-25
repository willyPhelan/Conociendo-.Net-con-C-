using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Jerarquía_de_Animales__Herencia_ {
    internal class Animal {

         public int Edad { get ; set ; }

         public string Nombre { get; set ; }


         public string Especie { get; set ; }

         // Constructores 

         // Vacio
         public Animal() {

            Nombre = "Sin nombre" ;

            Especie = "Desconocida" ;
            
            Edad = 0 ;
        }

        // con valores

        public Animal(string nombre, int edad, string especie) {
        
        
            Nombre = nombre ; 
            
            Especie = especie ; 
            
            Edad = edad < 0 ? 0 : edad ;

        }


        // metodos 

        // void Describir(): imprime Nombre, Edad y Especie.


      public virtual void Describir(){
            
      Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad} años, Especie: {Especie}"); }

    
    
    }
}
