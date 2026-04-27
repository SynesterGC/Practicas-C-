using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;
using SistemaPagos.Models;
using SistemaPagos.Interfaces;

namespace SistemaPagos.Services
{
    public class Store
    {
        private List<Orders> _orders = new List<Orders>();
        private decimal _totalRevenue= 0;

        public void AddOrder (Orders newOrder)
        {
            _orders.Add(newOrder);
        }

        public PayConfirm? ProcessOrderPayment (Orders order, IPayMethod method)
        {
            if (order.State)
            {
                Console.WriteLine($"Error: La orden {order.ID} ya fue pagada anteriormente");
                return null;
            }

            if (method.ProcessPayment(order.TotalAmount))
            {
                order.MarkAsPaid();
                _totalRevenue += order.TotalAmount;
                Console.WriteLine($"Pago exitoso con {method.GetMethodName()} para la orden {order.ID}");
                return new PayConfirm(order.ID, order.TotalAmount, $"Pago exitoso con {method.GetMethodName()}");
            }
            else
            {
                Console.WriteLine($"Error: La orden {order.ID} fue rechazada al pagarse");
                return null;
            }
            }
        

        public void ShowSumarry()
        {
            Console.WriteLine("^^^Resumen de la Tienda^^^");
            Console.WriteLine($"Total recaudado: ${_totalRevenue}");

            foreach (var item in _orders)
            {
                Console.WriteLine($"-{item.ClientName} (Pagada: {item.State})");
            }
        }
    }
    
    
    
}

