using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_8___Clases_con_Net_Framework {
     class Articulo {

        /*
         
        - Codigo de Articulo (3 digitos no correlativos)
        - Precio 
        - Codigo de Mara (1 a 10) 
        - private int codArticulo 

         */

         public int CodigoArticulo { get ; set ; } 

         public float Precio { get ; set ; } 

         private int codigoMarca ;

         public int CodigoMarca {

            get { return codigoMarca ; }

            set { if (value >= 1 && value <= 10) {

                    codigoMarca = value ; } else {

                    codigoMarca = -1 ; 

                    throw new Exception("Codigo de marca debe esta r entre 1 y 10") ;
                }
            }

        }
}}
