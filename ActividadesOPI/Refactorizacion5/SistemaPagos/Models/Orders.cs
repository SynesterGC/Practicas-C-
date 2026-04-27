using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace SistemaPagos.Models
{
    public class Orders
    {
        public int ID {get;}
        public string ClientName {get; set;}
        public decimal TotalAmount {get;}
        public bool State {get; private set;} = false;

        public Orders(int id, string clientName, decimal amount)
        {
            ID = id;
            TotalAmount = amount;
            ClientName = clientName;
        }


        public void MarkAsPaid()
        {
            State = true;
        }

        public override string ToString()
        {
            string textState = State? "Pagada" : "Pendiente";

                return $"ID: {ID}, ClientName: {ClientName}, TotalAmount: ${TotalAmount}, State: {textState}"; 
        }
    }
}

