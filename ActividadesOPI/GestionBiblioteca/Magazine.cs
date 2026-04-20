using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;
using Biblioteca2nd;


namespace Biblioteca2nd
{
    public class Magazine: Material, IBorrowed
{
    public override void ObtainDescription()
    {
        Console.WriteLine($"Revista: {Title}, Sinopsis:{Description}");
    }

    public bool Lend(User borrower)
    {
        if (IsAvailable)
        {
            IsAvailable = false;
            borrower.HaveMaterial= true;
            Console.WriteLine($"La revista {Title} ha sido prestada a {borrower.Name}");
            return true;
        }
        Console.WriteLine($"La revista {Title} no esta disponible en estos momentos");
        return false;  
    }
    public void Return(User borrower) 
    {
        IsAvailable = true;
        if (borrower != null) borrower.HaveMaterial = false;
        Console.WriteLine($"La revista '{Title}' ha sido devuelta.");
    }
}
}
