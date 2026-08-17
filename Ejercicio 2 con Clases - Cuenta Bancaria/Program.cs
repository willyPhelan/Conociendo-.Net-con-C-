using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2_con_Clases___Cuenta_Bancaria {
    internal class Program {
        static void Main(string[] args){

            CuentaBancaria cuenta = new CuentaBancaria("0001", "Willy Phelan", 10000) ; // Crear una cuenta con saldo inicial de 10.000

            Console.WriteLine("Saldo inicial: $" + cuenta.Saldo) ;

            cuenta.Depositar(5000) ; // Depositar 5.000

            Console.WriteLine("Saldo después del depósito: $" + cuenta.Saldo) ;

            cuenta.Extraer(2000); // Extraer 2.000 ; 

            Console.WriteLine("Saldo después de la extracción: $" + cuenta.Saldo) ;

            cuenta.Extraer(15000); // Intentar extraer 15.000 (más que el saldo disponible)

            Console.WriteLine("Saldo después de intentar extraer más de lo disponible: $" + cuenta.Saldo) ;

            cuenta.MostrarEstado(); // Mostrar el estado de la cuenta

        }
    }
}
