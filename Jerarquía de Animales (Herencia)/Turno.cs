using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jerarquía_de_Animales__Herencia_ {
    internal class Turno {

        // Propiedades por asociación // con esto obtengo metodos y props de Animal y Veterinario
        public Animal Paciente { get ; set ; }
        public Veterinario Profesional { get ; set ; }

        // Nueva propiedad para el ID único del turno
        public int Id { get ; private set ; }
        
        // Propiedad de fecha y hora
        public DateTime FechaHora { get ; set ; }

        // Constructor con las tres propiedades
        public Turno(Animal paciente, Veterinario profesional, DateTime fechaHora) {

            Id = RegistroVeterinaria.GenerarId() ; // Asignación automática del ID
            
            Paciente = paciente ;

            Profesional = profesional ;

            FechaHora = fechaHora ;
        }

        // Método para mostrar la información del turno
        public void MostrarResumen() {

            Console.WriteLine("========================================") ;
            Console.WriteLine("           RESUMEN DEL TURNO            ") ;
            Console.WriteLine("========================================") ;

            Console.WriteLine($"           TURNO #{Id}");

            Console.WriteLine($"Fecha y Hora : {FechaHora:dd/MM/yyyy HH:mm} hs") ;

            Console.WriteLine($"Veterinario  : {Profesional.Nombre} (Mat. {Profesional.Matricula})") ;

            Console.WriteLine($"Paciente     : {Paciente.Nombre} ({Paciente.Especie})") ;

            Console.WriteLine("========================================\n") ;
        }
    }
}
