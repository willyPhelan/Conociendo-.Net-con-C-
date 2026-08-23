using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_2 {
    internal class Program {
        static void Main(string[] args){

        Animal a1 = new Animal() ;

        AnimalDomestico ad1 = new AnimalDomestico() ;

        ad1.Nombre = "Tadeo" ; 
        
        a1.GetHashCode() ;

        Console.WriteLine(a1.ToString()) ;

        // nuestro el obj

        Console.WriteLine(ad1.ToString()) ;

        // muestro nombre que guarde en el obj

        Console.WriteLine(ad1.Nombre) ;

        Console.WriteLine(ad1.Comunicarse()) ;

        Gato g1 = new Gato() ;

        g1.Nombre = "Gordo" ; 

        Console.WriteLine(g1.Comunicarse()) ;

        Perro p1 = new Perro() ;

        Console.WriteLine(p1.Comunicarse()) ; 

        // creo lista

        List<Animal> animales = new List<Animal> () ;

        // agrego a la lista 

        animales.Add(p1) ; 
        animales.Add(g1) ;
        animales.Add(new Pez()) ; 
        animales.Add(new Canario()) ;

        // utilizo una interfaz para segmentar animales que solo puedan volar

        List<Flyers> listaVoladores = new List<Flyers> () ;

        listaVoladores.Add(new Canario()) ; 
        listaVoladores.Add(new Aguila()) ; 
        
        // listaVoladores.Add(new Perro()) ; -- no puedo agregar perro porque no lo permite la interfaz

        // casteo automatico - fuerzo gato 

        Animal a2 = g1 ;

        Gato g5 = (Gato)a2 ; 

        Console.WriteLine(a2.Comunicarse()) ;

        // recorro la lista 

        foreach(Animal animal in animales){

        Console.WriteLine(animal.Comunicarse())  ; } 

        Console.ReadKey() ;




        }
    }
}
