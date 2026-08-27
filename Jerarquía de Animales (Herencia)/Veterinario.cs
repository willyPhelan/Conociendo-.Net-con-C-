using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jerarquía_de_Animales__Herencia_ {
    internal class Veterinario {
        // Propiedades
        public string Nombre { get ; set ; }
        public string Matricula { get ; set ; }

        // Constructor con ambas propiedades
        public Veterinario(string nombre, string matricula) {
            
            Nombre = nombre ;
            
            Matricula = matricula ;
        }

        // Método de Asociación: Recibe un objeto que cumpla el contrato IAnimal
        public void AtenderPaciente(IAnimal paciente) {

            Console.WriteLine($"El Dr./Dra. {Nombre} (Mat. {Matricula}) inicia la consulta:") ;

            paciente.Atender() ; // Llamada polimórfica al método del paciente

            Console.WriteLine() ;

        } }
        
        } 