﻿using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_7_Clases {
    internal class Program {
    
    static void Main(string[] args) {
    
     /*   int edad ; 

        float sueldo ; 

        string nombre ; 

        int[] edades = new int[10] ; 

        float[] sueldos = new float[10] ;

        string[] nombres = new string[10] ; */

        Persona p1 = new Persona("Willy") ;  

        p1.setEdad(25)  ;

        Console.WriteLine(p1.saludar()) ; 

        Console.WriteLine("La edad de " + p1.getnombre + " es: " + p1.getEdad()) ;

        
         Botella b1 = new Botella("Rojo", "Plastico") ;

      //  b1.Capacidad = 1000 ;

       //  int capacidad = b1.Capacidad ;  // lo guardo en una variable

         Console.WriteLine("Capacidad de la botella" + b1.Capacidad) ; 

         Console.WriteLine("Cantidad actual: " + b1.CantidadActual) ;

         b1.recargar() ;

         Console.Write("Después de recargar, la cantidad actual es: " + b1.CantidadActual) ;

         Console.WriteLine("Presione una tecla para continuar...") ;

         Console.ReadKey() ; 

/*


        Perro pe1 = new Perro() ; 

        pe1.Nombre = "Firulais" ;

        Console.WriteLine("Y el nombre del perro es: " + pe1.Nombre) ;  */

        } 

       

       

}

}