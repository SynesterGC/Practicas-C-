using System;

class Program
{
    static void Main()
    {    
    /*
        Console.WriteLine("Escribe tu edad");
        double edadUser = double.Parse(Console.ReadLine());

        Console.WriteLine("Ahora confirma con 'Si' o 'No' si tienes un ticket para entrar");
        string entradaTicket =  Console.ReadLine();

        if (entradaTicket == "Si" && edadUser >= 18)
        {
            Console.WriteLine("Bienvenido a la pari");
        }
        else if (entradaTicket == "No" && edadUser >= 18)
        {
            Console.WriteLine("No tenes ticket boludin");
        }
        else if (entradaTicket == "Si" && edadUser < 18)
        {
            Console.WriteLine("Dame un pedazo de ese ticket mas bien");
        }
        else if (entradaTicket == "No" && edadUser < 18)
        {
            Console.WriteLine("A tu casa chiquin");
        }*/

        //Refactorizacion del bloque de codigo anterior:

        Console.WriteLine("Escribe tu edad");
        double edadUser = double.Parse(Console.ReadLine());

        if (edadUser < 18)
        {
            Console.WriteLine("Regresa a casa we");
            return;
        }   

        Console.WriteLine("Tienes ticket? (Si/No)");
        string entradaTicket = Console.ReadLine();

        if (entradaTicket != "Si")
        {
            Console.WriteLine("Nah chau");
            return;
        }
            Console.WriteLine("Bienveni@");
        
    }
    /* Explicacion de la refactorizacion:

    En este tipo de casos donde hay multiples posibilidades donde se filtra ciertos tipos de datos, como
    la edad, ticket, etc, aqui se trata el problema directamente, filtrando unicamente lo necesario para
    forzar una salida lo mas antes posible, y si se cumplen todas las condiciones que exije el sistema, 
    pasa como deberia; se eliminan estas ramas de condiciones de "que pasaria si" a un flujo lineal
    donde se trata con las condiciones mas importantes (como en este caso la edad y el ticket) 
    */
}