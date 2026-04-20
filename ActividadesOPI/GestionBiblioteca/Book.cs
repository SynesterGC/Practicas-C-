using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;
using Biblioteca2nd;



public class Book : Material, IBorrowed
{
    public override void ObtainDescription()
    {
        Console.WriteLine($"Libro: {Title}, Sinopsis:{Description}");
    }

    public bool Lend(User borrower)
    {
        if (IsAvailable)
        {
            IsAvailable = false;
            borrower.HaveMaterial= true;
            Console.WriteLine($"El libro {Title} ha sido prestado a {borrower.Name}");
            return true;
        }
        Console.WriteLine($"El libro {Title} no esta disponible en estos momentos");
        return false;  
    }
    public void Return(User borrower) 
    {
        IsAvailable = true;
        if (borrower != null) borrower.HaveMaterial = false;
        Console.WriteLine($"El libro '{Title}' ha sido devuelto.");
    }
}