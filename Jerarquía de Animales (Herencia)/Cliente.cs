using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Clase Cliente:
• string Nombre
• string Telefono
• List<Animal> Mascotas (un cliente puede tener varios animales).
• void AgregarMascota(Animal a): agrega a la lista.
• void MostrarMascotas(): lista el nombre y especie de cada mascota. */


namespace Jerarquía_de_Animales__Herencia_ {
    internal class Cliente {

        public string Nombre { get ; set ; }

        public string Telefono { get ; set ; }

        // Asociación 1 a N: Un cliente posee una lista de mascotas
        public List<Animal> Mascotas { get ; set ; }

        // Constructor
        public Cliente(string nombre, string telefono) {
            
            Nombre = nombre ;
            
            Telefono = telefono ;

            // Es buena práctica inicializar la lista en el constructor para evitar el error NullReferenceException

            Mascotas = new List<Animal> () ;
        }

        // metodos para agregar y mostrar info de la lista

        public void AgregarAnimal(Animal animal) {

            Mascotas.Add(animal) ; }


        public void MostrarInformacion() {

            Console.WriteLine($"Cliente: {Nombre} | Tel: {Telefono}") ;

            Console.WriteLine($"Mascotas registradas ({Mascotas.Count}):") ;

            if (Mascotas.Count == 0) {

                Console.WriteLine("  (No tiene mascotas registradas)") ;
            
                } else {
                
                foreach (Animal m in Mascotas) {

                    Console.WriteLine($"  - Nombre: {m.Nombre}, Especie: ({m.Especie})") ;
                }
            }




    }
  }
}
