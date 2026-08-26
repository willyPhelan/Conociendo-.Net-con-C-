using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jerarquía_de_Animales__Herencia_ {
    internal class Perro:Animal {

    // Perro: propiedad adicional string Raza. Constructor con Nombre, Edad y Raza.

    public string Raza { get; set; }

    // Constructor

    public Perro(){

            Nombre = "Sin nombre" ;
            
            Edad = 0 ;

            Especie = "N/A" ;

            Raza = "N/A" ; 

    }

    public Perro(string nombre, int edad, string especie, string raza){

            Nombre = nombre ;
            
            Edad = edad ;

            Especie = especie ; 

            Raza = raza ; 

    }

    // Sobrecarga de metodo
    public override void Describir(){ 

      /* Console.WriteLine("llamando a base") ;   

        base.Describir() ;

        Console.ReadKey();
         
        Console.WriteLine("sin base") ; */
    
        Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad} años, Especie: {Especie}, Raza: {Raza}");}



    public override void HacerSonido(){ // en el contrato de la interfaz 
            
          Console.WriteLine($"{Nombre} Guauuu") ;
       
          }

    public override void Atender(){

           Console.WriteLine($"Atendiendo al perro {Nombre}: revisión general y vacunas.") ;
        }

    }

    


    }

