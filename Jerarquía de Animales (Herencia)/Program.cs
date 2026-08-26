using Jerarquía_de_Animales__Herencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jerarquía_de_Animales__Herencia_ {
     internal class Program {
        static void Main(string[] args) {

         /*   Animal a1 = new Animal() ;

            a1.Nombre = "Saul" ;
            a1.Edad = 1 ; 
            a1.Especie = "Pastor" ; 
           

            Animal a2 = new Animal("Rosi", 3, "Dover") ;

            Perro p1 = new Perro() ;

            p1.Nombre = "Satan" ;

            p1.Edad = 1 ;

            p1.Especie = "Pastor" ;

            p1.Raza = "Collie" ;

            Perro p2 = new Perro("Juan", 2, "Boyero", "Ingles") ; 
 

            
            Console.WriteLine(a1.Nombre) ;
            
            Gato g1 = new Gato() ;

            Gato g2 = new Gato("Gordo", 12, true) ;

            g1.Especie = "Gordo Siberiano" ; 

            Console.WriteLine(g1.Especie) ; 

            a1.Describir() ; // perro

            a2.Describir() ; // perro2

            g1.Describir() ; 

            g2.Describir();

            p1.Describir() ;

            p2.Describir() ; 

            Console.ReadKey() ;

            // Lista de tipo Animal con 3 Perros y 2 Gatos

            List<Animal> animales = new List<Animal> {
                
                new Perro("Firulais", 3, "Boyero", "Berna"),
                new Perro("Rex", 7, "Pastor", "Belga"),
                new Perro("Milo", 1, "Callejero", "Vago"),
                new Gato("Felix", 4, false),
                new Gato("Michi", 2, true)
            } ;

              // Agregar un Animal más a la lista después de crearla.

             animales.Add(new Perro("Francis", 9, "Asesino", "Dogo Apache")) ; 

            // Recorrido e impresión de cada elemento

            foreach (Animal animal in animales){
                
            animal.Describir() ; 
            
            
            
            }

          
            Console.WriteLine("--- Lista Original ---") ;

            animales.ForEach(a => a.Describir()) ;

            // Filtrado: elimina si la edad es menor a 2

            animales.RemoveAll(a => a.Edad < 2);

            Console.WriteLine("\n--- Después de eliminar menores a 2 años ---") ;

            animales.ForEach(a => a.Describir()) ;

            // Consulta LINQ: Filtra mayores a 3 años sin modificar la lista 'animales'

            Console.WriteLine("\n--- Solo animales mayores a 3 años ---");

            var mayores = animales.Where(a => a.Edad > 3).ToList();

            // lista sin filtro 

            Console.Clear() ;

            Console.WriteLine("Despues de borrado invoco lista:") ;

            animales.ForEach(a => a.Describir()) ;

            Console.ReadKey() ; 

            Console.WriteLine("Despues del filtro:") ;



            // Mostramos la lista filtrada
            
            mayores.ForEach(a => a.Describir());
          
          */

          Perro perro = new Perro() ;

          Gato gato = new Gato() ; 

       

       //   perro.Describir() ;

       /*   Console.WriteLine("Ahora el gato") ;

          gato.Describir() ;

          Console.ReadKey() ; */

          Console.WriteLine("Nueva lista") ; 

          List<Animal> animales = new List<Animal> {

                new Perro("Firulais", 3, "Pastor", "Aleman"),

                new Gato("Felix", 4, true),

                new Perro("Rex", 5, "Labrador", "Chocolate"),

                new Gato("Michi", 2, false),

                new Perro("Milo", 1, "Caniche", "Toy")

            } ;

            foreach (Animal animal in animales){

                animal.Describir() ; // Llamará al Describir() específico de Perro o Gato automáticamente
            }

            animales[0].HacerSonido() ; 

            animales[3].HacerSonido() ; 

            animales[2].Atender() ;
            
            animales[3].Atender() ;

            Animal conejo = new Animal() ;

            conejo.Describir() ;

            conejo.Atender() ;

            Conejo conejo2 = new Conejo("Pepe", 2, 2.00m) ;

            conejo2.Describir() ;

            conejo2.Atender() ;



         

            Console.ReadKey() ;

            
         

        }
    }
}






