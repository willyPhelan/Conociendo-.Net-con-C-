using Jerarquía_de_Animales__Herencia_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jerarquía_de_Animales__Herencia{
    internal class Conejo:Animal {

      

        public decimal Peso { get ; set ; }

      

        public Conejo(string nombre,int edad, decimal peso){

            Nombre = nombre ;

            Edad = edad ; 

            Peso = peso ;
        }

        // Implementación directa del contrato IAtendible (sin override)
        public override void  Atender() {

            Console.WriteLine($"Atendiendo al conejo {Nombre}: Peso:{Peso}.  control de peso.") ; }

        public override void Describir(){
 
            Console.WriteLine($"Nombre: {Nombre}, Edad {Edad},  Peso: {Peso} kg") ; }

        public override  void HacerSonido() {

            Console.WriteLine($"{Nombre} hace un resoplido suave.");
        }

    }
}
