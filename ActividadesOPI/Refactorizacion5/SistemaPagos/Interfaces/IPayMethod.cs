using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace SistemaPagos.Interfaces
{
    public interface IPayMethod
    {
        bool ProcessPayment(decimal amount);
        string GetMethodName();
    }

    public class TarjetaCredito : IPayMethod
    {
        public string NombreTitular { get; set; }
        public TarjetaCredito(string nombre)
        {
            NombreTitular = nombre;
        }

        public bool ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Cobrando ${amount} a la tarjeta de {NombreTitular} ^^");
            return true;
        }

        public string GetMethodName() => "Tarjeta de Credito";
    }

    public class PagoEfectivo : IPayMethod
    {
        public string NombreTitular { get; set; }
        public PagoEfectivo(string nombre)
        {
            NombreTitular = nombre;
        }

        public bool ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Cobrando ${amount} en efectivo a {NombreTitular} ^^");
            return true;
        }

        public string GetMethodName() => "Pago en efectivo";
    }
}
