using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Stack<string> canciones = new Stack<string>();
        canciones.Push("Seré");
        canciones.Push("Buenos dias amor");
        canciones.Push("Rap de vegetta777");
        //Peek = VER el tope sin quitarlo
        string actual = canciones.Peek();
        Console.WriteLine($"Tope actual: {actual}"); 
        Console.WriteLine(canciones.Count); 
        // Pop = QUITAR y devolver el tope 

        Console.WriteLine(canciones.Peek()); 
    }
}
