using System;

class Program
{
    /*static void Main()
    {
        double n1 = 160;
        double n2 = 19000;

        double total = n1 * n2;
        Console.WriteLine($"El total es {total}");
    }*/




    // Refactorizacion de este bloque de codigo:

     static void Main()
    {
        double horasTrabajadas = 160;
        double valorHora = 19000;

        double salarioMensual = horasTrabajadas * valorHora;
        Console.WriteLine($"El salario del mes es: {salarioMensual}");
    }

    /* Explicacion de la refactorizacion:
    
    - Se aplico el metodo "Rename variable" para especificar la funcion que
    realiza el codigo; gracias a estos nombres como 'horasTrabajadas, valorHora,
    'salarioMensual' se le da un buen contexto al codigo con intenciones claras, de lo
    contrario si tuviera nombres vagos en las variables como 'n1', 'n2' y 'total' se podria
    entender cualquier cosa y segun el Clean Code, se violaria el principio de "Nombres con sentido".
    */
}



