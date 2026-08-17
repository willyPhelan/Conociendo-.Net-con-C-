/* 
 2) Cuenta Bancaria
Clase: CuentaBancaria

Propiedades: string NumeroCuenta, string Titular, decimal Saldo
Constructores: vacío y con valores iniciales (Saldo ≥ 0).
Métodos:
• void Depositar(decimal monto): valida monto > 0.
• bool Extraer(decimal monto): si monto <= Saldo, descuenta y devuelve true; si no, no
descuenta y devuelve false.
• void MostrarEstado(): número, titular y saldo.
Validaciones/mensajes:
• Depósito con monto <= 0: “Monto inválido.”
• Extracción sin fondos: imprimir “Saldo insuficiente.” y no modificar el saldo.
Pruebas mínimas:
• Depositar 10.000, extraer 12.000: “Saldo insuficiente.”, saldo intacto.
• Extraer 5.000: ok.
• MostrarEstado para ver resultado.

 */

using System;

namespace Ejercicio_2_con_Clases___Cuenta_Bancaria {
   
    internal class CuentaBancaria {
    public string NumeroCuenta { get ; set ; }
    public string Titular { get ; set ; }
    public decimal Saldo { get ; private set ; } // Modificable solo dentro de la clase

        // constructores
         public CuentaBancaria() { } // constructor vacío 
         public CuentaBancaria(decimal saldoInicial){ // constructor con validación de saldo inicial
             
         Saldo = saldoInicial ; }

        public CuentaBancaria(string numeroCuenta, string titular, decimal saldoInicial) {
            
            NumeroCuenta = numeroCuenta ;
            Titular = titular ;
            Saldo = saldoInicial >= 0 ? saldoInicial : 0 ; // Validación de saldo inicial
        }   

        // métodos

        public void Depositar(decimal monto){ if (monto > 0){ Saldo += monto ; }
            
        else { Console.WriteLine("Monto inválido.") ; }

        }

        public bool Extraer(decimal monto){

            if (monto <= Saldo) { Saldo -= monto; return true ; }

            else { Console.WriteLine("Saldo insuficiente.") ; return false ;  }
        }

        public void MostrarEstado() { Console.WriteLine($"Número de cuenta: {NumeroCuenta}, Titular: {Titular}, Saldo: {Saldo}"); }
    }
}