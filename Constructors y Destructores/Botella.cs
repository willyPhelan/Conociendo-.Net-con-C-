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
            this.capacidad = capacidad ; 
        }

        // constructor por defecto

        public Botella() {} 

        private int capacidad ; 
        private string color ;
        private string material ;

        // Propidades 

        public int Capacidad { get => capacidad ; set => capacidad = value ; } // modificable
        public string Color { get => color ; } // read only
        public string Material { get => material ; } // read only

    }
}