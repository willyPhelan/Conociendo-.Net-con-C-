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
    
        Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad} años, Especie: {Especie}, Raza: {Raza}");}

    }


    }

