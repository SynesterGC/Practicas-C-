using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;
using System;
using Biblioteca2nd;

class Program  
{
    static void Main(string[] args) 
    {
        Biblioteca itemsLibrary = new Biblioteca();

        Book book1 = new Book { Title = "La metamorfosis", Description = "La cucaracha ya no puede caminar" };
        Book book2 = new Book { Title = "La divina comedia", Description = "Ya no da risa" };
        Book book3 = new Book { Title = "El principito", Description = "tiene un elefante en un sombrero" };

        itemsLibrary.Agregar(book1);
        itemsLibrary.Agregar(book2);
        itemsLibrary.Agregar(book3);

        Magazine magazine1 = new Magazine { Title = "Revista generica 1", Description = "Revista de ciencias" };
        Magazine magazine2 = new Magazine { Title = "Revista generica 2", Description = "Revista de noticias" };
        Magazine magazine3 = new Magazine { Title = "Revista generica 3", Description = "Revista de negocios" };
        

        itemsLibrary.Agregar(magazine1);
        itemsLibrary.Agregar(magazine2);
        itemsLibrary.Agregar(magazine3);

        itemsLibrary.MostrarInventario();

        User pepe = new User("Pepe");
        User juan = new User("Juan");
        User Akira = new User("Akira");

        bool exito = book1.Lend(pepe);
        bool exito2 = book2.Lend(juan);

        book1.Return(pepe);

        if (exito && exito2)
        {
            Console.WriteLine($"{pepe.Name} ahora tiene un libro, y {juan.Name} tambien");
        }
        else
        {
            Console.WriteLine($"Error");
        }
        
        itemsLibrary.MostrarInventario();    
        
    }  
}  




