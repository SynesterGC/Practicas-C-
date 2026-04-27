using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;
using SistemaPagos;

namespace SistemaPagos
{
    public class Items
    {
        public int ID {get;}
        public string? Title {get; set;}
        public decimal Price {get;}
        public bool IsAvailable {get; private set;} = true;

        public Items(int id, decimal price, string title)
        {
            ID = id;
            Price = price;
            Title = title;
        }

        public void MarkAsUnavailable()
        {
            IsAvailable = false;
        }
    }
    
    
    
}