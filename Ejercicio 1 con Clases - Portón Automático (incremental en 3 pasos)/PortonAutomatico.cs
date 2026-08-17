using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

/*1) Portón Automático (caso incremental en 3 pasos)
Clase: PortonAutomatico
Propiedades obligatorias:
• int Apertura (valores 0 a 100; 0=cerrado; 100=abierto completo) x
• bool EstaCerrado (derivado: Apertura == 0) 
• bool EstaAbiertoCompleto (derivado: Apertura == 100)
Cuando se abre completo, la propiead abierto completo será true, de lo contrario será false.
Cuando está cerrado, la propiedad EstadoCerrado será true, de lo contrario será false.
Constructores:
• Va
cío (inicia cerrado).
• Con int aperturaInicial (validar 0–100. Si es menos de cero, se setea cero. Si es más de
100, se setea 100).
Parte A: Métodos obligatorios:
• void Abrir(): deja en 100 si no está ya en 100.
• void Cerrar(): deja en 0 si no está ya en 0.
• void MostrarEstado(): imprime “Cerrado”, “Abierto total (100%)” o “Abierto parcial
(X%)”.
Validaciones/mensajes:
• Si ya está en 100 y se llama Abrir(): mostrar “Ya está abierto al 100%”.
• Si ya está en 0 y se llama Cerrar(): mostrar “Ya está completamente cerrado”.*/

namespace Ejercicio_1_con_Clases___Portón_Automático__incremental_en_3_pasos_{
    internal class PortonAutomatico{

        // CONSTRUCTORES

        public PortonAutomatico() { } // constructor vacío (inicia cerrado)

        public PortonAutomatico(int aperturaInicial) { // constructor con validación de apertura inicial

            Apertura = aperturaInicial ; } // se valida en la propiedad


        // PROPIEDADES

        private int apertura ;
    
        // Propiedad con validación entre 0 y 100
        public int Apertura{

            get { return apertura ; }

            set {

                if (value < 0) apertura = 0 ;

                else if (value > 100) apertura = 100 ;
            
                else apertura = value ;
            }
        }

        // Propiedades derivadas (solo lectura)
        public bool EstaCerrado => Apertura == 0;

        public bool EstaAbiertoCompleto => Apertura == 100 ;

        // METODOS

       public void Abrir() { if (EstaAbiertoCompleto) { Console.WriteLine("El porton ya esta abierto") ; }  else { Apertura = 100 ; } } 
       public void Cerrar() { if (EstaCerrado) { Console.WriteLine("El porton ya esta cerrado") ; } else { Apertura = 0; } }

       public void Stop(){ Console.WriteLine("El porton se ha detenido") ; }

       public bool Toggle() { if (EstaCerrado) { Abrir(); return true; } else { Cerrar(); return false; } }

        // sobrecarga // void Abrir(int porcentaje): abre al % indicado (validar 1–99).
        public void Abrir(int porcentaje) { if (porcentaje < 1 || porcentaje > 99) { Console.WriteLine("Porcentaje inválido. Debe estar entre 1 y 99."); } else { Apertura = porcentaje; } }

       public void AbrirPeatonal(){ Apertura = 20 ; } 

        public void MostrarEstado() {
        
       if(EstaCerrado){ Console.WriteLine("Cerrado") ; }
    
         else if(EstaAbiertoCompleto){

            Console.WriteLine("Abierto total (100%)") ; }
   
            else {
                    
            Console.WriteLine($"Abierto parcial ({Apertura}%)") ; }
                
            }

    }
    
    }

