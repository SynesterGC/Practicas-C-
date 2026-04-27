using System;

class Program
{

    private const double valor_IVA = 0.19; // Valor constante (const)!
    static void Main()
    {
        /*double precioPan = double.Parse(Console.ReadLine());
        double total = precioPan * 1.19;

        Console.WriteLine($"El precio a pagar por el pan es: {total}");
        */

        //Refactorizacion de este bloque de codigo:

        Console.WriteLine("Ingresa el valor del pan a comprar: ");
        double precioPan = double.Parse(Console.ReadLine());
        double impuesto = precioPan * valor_IVA;
        double precioTotal = precioPan + impuesto;

        Console.WriteLine($"El precio a pagar por el pan es: {precioTotal}, tomando en cuenta el valor del Iva que es de {valor_IVA}");

        /* Explicacion de la refactorizacion:

        -Aqui se evidencio un ejemplo de "magic numbers", un numero el cual no tiene contexto y tiende a
        estar en multiples bloques de codigo si se requiere este mismo valor en caso de que fuera fijo, en este
        caso siendo el valor del IVA

        -Lo que yo aplique aca fue el principio D.R.Y, evita que este mismo valor del IVA se tenga que repetir en 
        multiples bloques de codigo, separandolo en un atributo con valor 'Constante', significando en que el valor del
        iva podra ser llamado en el codigo con su nombre/etiqueta 'valor_IVA' y de esta manera, en caso de que se requiera
        actualizar el valor, simplemente se cambia y facilita asi el uso de este, dando miras tambien a la mantenibilidad y 
        soporte al codigo.
        */
    }
}