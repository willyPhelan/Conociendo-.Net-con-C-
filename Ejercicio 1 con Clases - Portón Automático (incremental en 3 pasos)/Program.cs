using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1_con_Clases___Portón_Automático__incremental_en_3_pasos_ {
    internal class Program {
        static void Main(string[] args) {

        PortonAutomatico porton = new PortonAutomatico() ;

   /*     porton.Cerrar() ;

        Console.WriteLine("El porton esta: ") ;

        porton.MostrarEstado() ; 

        porton.Abrir() ;

        Console.WriteLine("El porton esta: ") ;

        porton.MostrarEstado() ;

        porton.Apertura=25 ;

        Console.WriteLine("El porton esta: ") ;

        porton.MostrarEstado() ;

        porton.AbrirPeatonal() ;

        porton.MostrarEstado() ;

        porton.Abrir(1000) ;

        porton.MostrarEstado() ;

        porton.Abrir(80) ; 

        porton.MostrarEstado() ;

        porton.Stop() ;

        porton.MostrarEstado() ;

        porton.Toggle() ;

        porton.MostrarEstado() ;

        porton.Toggle() ;

        porton.MostrarEstado() ; */

        //Simulaciones: Abrir(10) con un ciclo e ir consultando el estado. Cuando llegue a 50%
        // ejecutar Stop() y terminar. 

       /*  int porcentaje = 0 ; 

        while (porcentaje < 50) {

            porcentaje += 10 ;

            porton.Abrir(porcentaje) ;

            porton.MostrarEstado() ; 

           if(porcentaje == 50) { porton.Stop(); Console.WriteLine("El porton ha llegado al 50%") ; break ; }

        } */

        // ORientado a OBJS
        
        while (porton.Apertura < 50){
                
        porton.Abrir(porton.Apertura + 10) ;

        porton.MostrarEstado() ; }

        porton.Stop() ;

        Console.WriteLine("El portón ha llegado al 50%") ; } }
}
