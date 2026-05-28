# Dinamica
# Actividad — OOP + Estructuras de Datos · C#

| Campo | Dato |
|---|---|
| Nombre | Karla Minely Gonzalez Fuentes |
| Grupo | 6°B |
| Materia | Ingenieria Concurrente  |
| Fecha | 2026-05-28 |

## Puntaje opción múltiple
**10 / 12** (83%)

## Etapa 01 — Calentamiento

**1. Después de ejecutar las líneas A, B, C y D ¿cuántos elementos tiene la pila?**
Respuesta: 4 — ✔ Correcto

**2. ¿Qué imprime la línea E? (historial.Peek())**
Respuesta: Jugo naranja — ✔ Correcto

**3. ¿Cuántos elementos quedan en la pila después de la línea F? (historial.Pop())**
Respuesta: 3 — ✔ Correcto

**4. ¿Qué imprime la línea G? (historial.Count)**
Respuesta: 4 — ✖ Incorrecto

**5. ¿Qué imprime la línea H? (historial.Peek() después del Pop)**
Respuesta: Torta de jamón — ✔ Correcto

**6. Si declaras Stack<string> y llamas Push(42), ¿qué ocurre?**
Respuesta: Error de compilación — Stack<string> solo acepta textos — ✔ Correcto

## Etapa 02 — Stack en vivo

**1. Tienes una pila con: Torta (tope) → Agua → Tacos (fondo). Llamas Pop() dos veces. ¿Qué queda en la pila?**
Respuesta: Solo Torta — ✖ Incorrecto

**2. ¿En qué orden imprime el foreach una pila con: A (tope) → B → C (fondo)?**
Respuesta: A, B, C — ✔ Correcto

**3. ¿Cuál es la DIFERENCIA real entre Peek() y Pop()?**
Respuesta: Peek() mira el tope sin quitarlo; Pop() lo quita y lo devuelve — ✔ Correcto

**4. ¿Qué error lanza C# si llamas Pop() en una pila vacía?**
Respuesta: InvalidOperationException — ✔ Correcto

**5. ¿Por qué Stack<T> es la estructura ideal para implementar Ctrl+Z?**
Respuesta: Porque siempre expone el último elemento agregado — LIFO coincide con 'deshacer lo más reciente' — ✔ Correcto

**6. ¿Cuál de estas declaraciones es correcta para una pila de números enteros?**
Respuesta: Stack<int> pila = new Stack<int>(); — ✔ Correcto

## Etapa 03 — Bugs

**Bug #1:**
El error es que Pop() quita el elemento de la pila y el programador solo quería ver el pedido sin eliminarlo.

Stack<string> pedidos = new Stack<string>();
pedidos.Push("Tacos");
pedidos.Push("Agua");

// Quiero VER el pedido más reciente sin quitarlo
string ultimo = pedidos.Peek(); 
Console.WriteLine(ultimo);
Console.WriteLine(pedidos.Count);    // espera 2, obtiene 1

**Bug #2:**
La pila fue declarada de una forma en la que solo puede guardar cadenas (string), pero el código intenta agregar enteros.
Stack<string> precios = new Stack<string>();

precios.Push("25");        // ← ¿qué pasa aquí?
precios.Push("40");
precios.Push("15");

Console.WriteLine(precios.Pop());

**Bug #3:**
La ṕila solo tiene 2 elementos, pero a Pop() se le llama tres veces. Al tercer intento trata de sacar un elemento de una pila vacía.

Stack<string> historial = new Stack<string>();
historial.Push("Acción 1");
historial.Push("Acción 2");

// El usuario presionó Ctrl+Z tres veces
historial.Pop();   // deshacer 1 — ok
historial.Pop();   // deshacer 2 — ok




## Etapa 04 — Diseño

**Reto elegido:** 🎵 App de música — Lista de reproducción LIFO

**Solución:**
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

**Reflexión:**
Es la estructura que más se me facilitó en clase, el stack es eficiente ya que te agrega una lista 
