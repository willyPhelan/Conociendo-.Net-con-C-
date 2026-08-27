using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Jerarquía_de_Animales__Herencia_ {
    internal class Gato:Animal {
    
    // propiedad adicional bool EsDeInterior. Constructor con Nombre, Edad y EsDeInterior.

    public bool EsDeInterior { get ; set ; }

    public Gato(){

    Nombre = "N/A" ; 

    Edad = 0 ; 

    EsDeInterior = true ;
    }

    public Gato(string nombre, int edad, bool esdeinterior){
    
        Nombre = nombre ; 
        
        Edad = edad ; 

        EsDeInterior = esdeinterior ; 

   
        
        
        }

    public override void Describir(){ 

      /*  Console.WriteLine("llamando a base") ;

        base.Describir() ; 

        Console.WriteLine("imprimiendo") ; */
    
        Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad} años, Especie: {Especie}, Es de interior: {EsDeInterior}");}

    


    public override string HacerSonido(){ // en el contrato de la interfaz 
            
      return $"{Nombre} Miaaaaau." ; }

    public override void Atender() {

            Console.WriteLine($"Atendiendo al gato {Nombre}: desparasitación.") ;
        }


    }
}
