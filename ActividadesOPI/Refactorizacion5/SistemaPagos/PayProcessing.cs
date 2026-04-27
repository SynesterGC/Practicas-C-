using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;
using SistemaPagos;

namespace SistemaPagos
{
    public class PayProcessing
    {
        private Dictionary<int, bool> _registroPagos = new Dictionary<int, bool>();

        public PayProcessing() {}

        public void EjecutarCobro(Orders orden, IPayMethod metodo)
        {
            if (_registroPagos.ContainsKey(orden.ID) && _registroPagos[orden.ID] == true)
            {
            Console.WriteLine($"Error: La orden No.{orden.ID} ya se ha pagado anteriormente.");
            return;
            }
        
         bool exito = metodo.ProcessPayment(orden.TotalAmount);

         if (exito)
         {
            orden.MarkAsPaid();
            _registroPagos[orden.ID] = true; // Guardamos en nuestro registro interno
            Console.WriteLine($"[EXITO] Orden #{orden.ID} pagada correctamente.");
         }
         else
         {
         Console.WriteLine($"[FALLO] El método de pago rechazó la transacción de la orden #{orden.ID}.");

         }
            
        }
    }
}

