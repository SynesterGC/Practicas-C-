using System;

class Program
{
    /*static void Main()
    {
        Console.WriteLine("**LOGIN**");
        Console.Write("Usuario: ");
        string usuarioIngresado = Console.ReadLine();

        Console.Write("Contraseña: ");
        string passIngresada = Console.ReadLine();

        if (usuarioIngresado == "admin" & passIngresada == "1234")
        {
            Console.WriteLine("Bienveni@ a la pagina");
        }
        else
        {
            Console.WriteLine("Credenciales incorrectas, intentalo de nuevo.");
        }
    }*/

    /* Refactorizacion de este bloque de codigo:

     Aqui se aplico el metodo "Extract Method" y para no hacer largo la explicacion lo divide por puntos
    
    1. Gracias a esta forma de refactorizar, se separa el login de la validacion de credenciales
    */

    /*
    2. Cumple con el principio de Single Responsability, ya que gracias al metodo, se separa ambas funciones
    tanto el login como la validacion de credenciales, aparte que permite un acceso y modificacion mas sencillas a 
    esta ultima, en cambio con el anterior bloque de codigo para eliminar o crear mas credenciales tocaba apilar mas "credenciales" 
    o muchisimos OR. */
    

    static void Main()
    {
        Console.WriteLine("**LOGIN**");
        Console.Write("Ususario: ");
        string usuarioIngresado = Console.ReadLine();

        Console.Write("Contraseña: ");
        string passIngresada = Console.ReadLine();

        if (ValidarCredenciales(usuarioIngresado, passIngresada))
        {
            Console.WriteLine("Bienvenid@ a la pagina");
        }
        else
        {
            Console.WriteLine("Usuario y contraseña incorrectas, intentalo de nuevo");
        }

        static bool ValidarCredenciales(string user, string pass)
        {
            string usuarioCorrecto= "admin";
            string passCorrecta = "1234";

            return (user == usuarioCorrecto && pass == passCorrecta);
        }
    }
}