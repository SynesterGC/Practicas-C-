using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;
using SistemaPagos;

namespace SistemaPagos
{
    public class BuyItem
    {
        public User Cliente {get; set;}
        public Items Producto {get; set;}
        public IPayMethod SeleccionarMetodo {get; set; }
        public decimal MontoTotal { get; set;}

        public BuyItem(User name, Items producto, IPayMethod metodo)
        {
            this.Cliente = name;
            this.Producto = producto;
            this.SeleccionarMetodo = metodo;
            this.MontoTotal = producto.Price;
        }

        public bool ValidarInformacion(IPayMethod method)
        {
            if (Cliente == null || Producto == null || SeleccionarMetodo == null)
            {
                Console.WriteLine("Error: Informacion de compra incompleta");
                return false;
            }

            Console.WriteLine($"Solicitud creada: {Cliente.Name} quiere comprar {Producto.Title}");
            return true;
        }
    }
    
    
    
}