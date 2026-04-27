using System;
using SistemaPagos;

namespace SistemaPagos
{
    class Program
    {
        static void Main(string[] args)
        {
            Store miTienda = new Store();

            Orders orden1 = new Orders(1, "Pepe", 150000);
            Orders orden2 = new Orders(2, "Cesar", 85000);
            Orders orden3 = new Orders(3, "Bernardo", 210000);

            miTienda.AddOrder(orden1);
            miTienda.AddOrder(orden2);
            miTienda.AddOrder(orden3);

            IPayMethod tarjeta = new TarjetaCredito("Pepe");
            IPayMethod efectivo = new PagoEfectivo("Cesar");

            Console.WriteLine("--- Iniciando Proceso de Pagos y recibos --- \n");

            miTienda.ProcessOrderPayment(orden1, tarjeta)?.MostrarRecibo();
            miTienda.ProcessOrderPayment(orden2, efectivo)?.MostrarRecibo();
            miTienda.ProcessOrderPayment(orden3, tarjeta)?.MostrarRecibo();


            Console.WriteLine("\n--- Prueba de Validación ---");

   
            miTienda.ProcessOrderPayment(orden1, tarjeta);
            miTienda.ProcessOrderPayment(orden2, efectivo);
            miTienda.ProcessOrderPayment(orden3, tarjeta);


            miTienda.ShowSumarry();

            Console.WriteLine("Fin (Presiona cualquier tecla para detener la ejecución)");
            Console.ReadKey();
        }
    }
}