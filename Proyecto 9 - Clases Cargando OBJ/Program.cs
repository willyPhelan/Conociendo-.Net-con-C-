using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_8___Clases_con_Net_Framework {
    internal class Program {
        static void Main(string[] args) {

            /* Primer lote con 10 registros de productos, cada producto tiene: 

                - Codigo de Articulo (3 digitos no correlativos) 
                - Precio 
                - Codigo de Marca  ----> seran 3 arrays para codigo, precio y marca

                Segundo lote con las ventas de la semana. Cada venta tiene: 

                - Codigo de Articulo 
                - Cantidad 
                - Codigo de Cliente (1 a 100) 

                Este lote corta con Codigo de cliente = 0 

             */

             Articulo[] articulos = new Articulo[10] ;

             for(int i = 0; i < articulos.Length; i++) {

             // carga de vector 

                 articulos[i] = new Articulo() ;

                 Console.WriteLine("Ingrese los datos del articulo: ") ;

                 Console.WriteLine("Codigo: ") ; 

                 articulos[i].CodigoMarca = int.Parse(Console.ReadLine()) ;

                 Console.WriteLine("Precio: ") ;

                 articulos[i].Precio = float.Parse(Console.ReadLine()) ;

                 Console.WriteLine("Codigo de Marca: (1 a 10)") ;

                 articulos[i].CodigoMarca = int.Parse(Console.ReadLine()) ;

            }

               Venta venta = new Venta() ; 

               Console.WriteLine("Ingrese los datos de la venta: ") ;

               Console.WriteLine("Ingrese el codigo del cliente: ") ;

               venta.CodigoCliente = int.Parse(Console.ReadLine()) ;
               
                   while(venta.CodigoCliente != 0) { 

                       Console.WriteLine("Codigo de Articulo: ") ;
               
                       venta.CodigoArticulo = int.Parse(Console.ReadLine()) ;

                       Console.WriteLine("Cantidad: ") ;

                       venta.Cantidad = int.Parse(Console.ReadLine()) ;

                       // a partir de aca trabajo 

                       // aca vuelvo a pedir un cliente 

                       Console.WriteLine("Ingrese los datos de la venta: ") ;

                       Console.WriteLine("Ingrese el codigo del cliente: ") ;

                       venta.CodigoCliente = int.Parse(Console.ReadLine()) ;


               
                   }


               } 
        
           } 
        
        }

        
    
            
