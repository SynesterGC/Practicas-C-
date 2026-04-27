using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;
using SistemaPagos;

namespace SistemaPagos
{
    public class PayConfirm
    {
        public int OrderID { get; }
        public DateTime FechaPago { get; }
        public decimal MontoPagado { get; }
        public string MetodoUsado { get; }
        public string NumeroConfirmacion { get; }

        public PayConfirm(int orderId, decimal monto, string metodo)
        {
            OrderID = orderId;
            MontoPagado = monto;
            MetodoUsado = metodo;
            FechaPago = DateTime.Now; 
            
            NumeroConfirmacion = "NC-" + Guid.NewGuid().ToString().Substring(0, 8).ToUpper(); // En esta linea de codigo, Guid me da un valor aleatorio (de 36 caracteres) tipo ID, 'ToString' convierte este dato
            //en string/texto para que pueda ser leido sin problemas, Substring elige los primeros 8 caractes del texto en este caso (0, 8) y ToUpper convierte las letras minusculas en mayusculas
        }

        public void MostrarRecibo()
        {
            Console.WriteLine("\n----------- RECIBO DE PAGO -----------"); // el \n es un salto de linea
            Console.WriteLine($"Confirmación: {NumeroConfirmacion}");
            Console.WriteLine($"Fecha: {FechaPago}");
            Console.WriteLine($"Orden ID: {OrderID}");
            Console.WriteLine($"Método: {MetodoUsado}");
            Console.WriteLine($"Total: ${MontoPagado}");
            Console.WriteLine("----------------------\n");
        }
    }
}

