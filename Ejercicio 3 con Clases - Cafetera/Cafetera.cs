using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3_con_Clases___Cafetera{
 
    public class Cafetera {
    private int capacidadMl ;

    // propiedades
    private int nivelMl ;
    public int CapacidadMl { get => capacidadMl ; set => capacidadMl = value < 0 ? 0 : value ; }
    public int NivelMl { get => nivelMl ; set {
            
        if (value < 0) nivelMl = 0 ;
            
        else if (value > CapacidadMl){ 
        
        nivelMl = CapacidadMl ; 
        
        Console.WriteLine("No se puede exceder la capacidad máxima.") ; } // No puede superar la capacidad máxima
       
        else nivelMl = value ;

        }
    }

    // constructores

      public Cafetera() { // constructor vacío

            CapacidadMl = 1000 ;
            
            NivelMl = 0 ;
      }

      public Cafetera(int capacidadInicial, int nivelInicial){ // constructor con parámetros // (validar 0 ≤ nivel ≤ capacidad) */
            
            if(capacidadInicial > 0) {CapacidadMl = capacidadInicial ; } else {
                
            CapacidadMl = 1000 ; } // valor por defecto si la capacidad inicial es negativa
            

            if(nivelInicial <= CapacidadMl && nivelInicial >= 0){NivelMl = nivelInicial ; } 


        }

    // METODOS

   // void CargarAgua(int ml): suma al nivel (sin exceder).

    public void CargarAgua(int ml) {

            if (ml < 0) return ; // no se puede cargar una cantidad negativa

             NivelMl += ml ; // la propiedad NivelMl se encarga de no exceder la capacidad máxima
        }


    // int ServirTaza(): sirve 200 ml por defecto (si alcanza); devuelve ml realmente servidos

    public int ServirTaza(){

            int cantidadServida = 0 ;
            
            if (NivelMl >= 200){

                cantidadServida = 200 ;

                Console.WriteLine("Cantidad servida: {0} ml", cantidadServida) ;
                
                NivelMl -= 200 ;
            
                } else {

                cantidadServida = NivelMl ;

                Console.WriteLine("Cantidad servida: {0} ml", cantidadServida) ;

                NivelMl = 0 ;
            }

            return cantidadServida ;

        }

   // Sobrecarga: int ServirTaza(int ml): sirve cantidad pedida si alcanza.

   public int ServirTaza(int ml) {
            
           int cantidadServida = 0 ;

            if (ml < 0) return 0 ; // no se puede servir una cantidad negativa
            
            if (NivelMl >= ml && capacidadMl >= ml){

                cantidadServida = ml ;

                Console.WriteLine("Cantidad servida: {0} ml", cantidadServida);

                NivelMl -= ml ;

            } else {

                Console.WriteLine("No hay suficiente agua para servir la cantidad pedida.") ;

                cantidadServida = NivelMl ;

                Console.WriteLine("Cantidad servida: {0} ml", cantidadServida) ;
                
                NivelMl = 0 ;
            }
            return cantidadServida ;
        }

   // void MostrarEstado(): “Nivel: X/Y ml”.

   public void MostrarEstado(){

            Console.WriteLine("Nivel: {0}/{1} ml", NivelMl, CapacidadMl) ; }
}}