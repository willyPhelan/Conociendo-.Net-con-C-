﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_7_Clases{
    internal class Botella{

        public Botella(string color, string material){
           
            this.color = color ;

            this.material = material ;
        }

        // sobre carga de constructores

        public Botella(string color, string material, int capacidad){

            this.color = color ;

            this.material = material ;

            this.capacidad = 100 ; // capacidad fija no puede modificarse

            this.cantidadActual  = 0 ; // cantidad inicial de la botella
        }

        // constructor por defecto

        public Botella() {} 
        private int capacidad ; 
        private string color ;
        private string material ;
        private int cantidadActual ;

        public int Capacidad { get => capacidad; } // read only

        public int CantidadActual { get => cantidadActual ; } // read only

        // Propidades 

        //  public int Capacidad { get => capacidad ; set => capacidad = value ; } // modificable

        public string Color { get => color ; } // read only
        public string Material { get => material ; } // read only

        // metodos

        public float recargar() {

            if (cantidadActual > 0 ){

            int dif = capacidad - cantidadActual ;
            
            float monto = dif * 50 / 100 ; 
            
            cantidadActual+= dif ;
            
            return monto ; }

            cantidadActual = 100 ; 

            return 50 ; // monto a pagar 
        }

    }
}