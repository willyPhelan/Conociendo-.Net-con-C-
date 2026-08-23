using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Clases___Herencia {
    internal class Program {
        static void Main(string[] args) {

        Persona p1 = new Persona() ;

        Developer d1 = new Developer() ;

        d1.Legajo = 01 ; 

        p1.Apellido = "Lopez" ;

        Vehiculo v1= new Vehiculo() ;

        Vehiculo v2 = new Vehiculo() ;

        Camioneta c1 = new Camioneta() ;

        Camioneta c2 = new Camioneta() ;

        Camioneta c3 = new Camioneta() ;

        c1.CargaMaximna = 10000 ;

        c1.Color = "Amarillo" ;

        c2.Color = "Negra" ;

        c3.Color = "Verde" ;

        // coleccion de camionetas

        List <Camioneta> listadoCamionetas = new List<Camioneta> () ; // creo una coleccion

        // agrego objetos a la lista: 
        
        listadoCamionetas.Add (c1) ;

        listadoCamionetas.Add (c2) ;

        listadoCamionetas.Add(c3) ; 
        
        // accedo a los valores

        Console.WriteLine ("Cantidad de camionetas: " + listadoCamionetas.Count) ;

        listadoCamionetas[1].Color = "Blanco" ;

        Console.WriteLine( "El color de la camioneta 1 es " + listadoCamionetas[0].Color) ; 

        Console.WriteLine( "El color de la camioneta 2 es " + listadoCamionetas[1].Color) ; 

        // borro un objeto de la lista

        listadoCamionetas.Remove(c3) ;
       
        Console.WriteLine ("Cantidad de camionetas: " + listadoCamionetas.Count) ;
   
       // Console.ReadKey() ;
        
        // recorrer una coleccion con ciclo 

        Console.WriteLine ("FOR EACH") ; 

        foreach(Camioneta camioneta in listadoCamionetas){

        Console.WriteLine("Color: " + camioneta.Color) ; 

        }

        Auto a2 = new Auto() ;

        a2.Motor = new Motor() ; // por agregacion 

        Console.ReadKey() ;


        }
    }
}
