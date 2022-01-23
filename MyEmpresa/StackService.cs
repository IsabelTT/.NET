using System;
using System.Collections.Generic;
using System.Text;

namespace MyEmpresa
{
    public class StackService
    {
        public static void Example()        
        {
            //Pila --> Last In - First Out
            Stack<Entidades.Empleado> lifo = new Stack<Entidades.Empleado>();
            lifo.Push(new Entidades.Empleado("00000001A", "a", "b", "c", DateTime.Now.AddDays(-84520)));
            lifo.Push(new Entidades.Empleado("00000002B", "a", "b", "c", DateTime.Now.AddDays(-84520)));
            lifo.Push(new Entidades.Empleado("00000003C", "a", "b", "c", DateTime.Now.AddDays(-84520)));
            lifo.Push(new Entidades.Empleado("00000004D", "a", "b", "c", DateTime.Now.AddDays(-84520)));
            lifo.Push(new Entidades.Empleado("00000005E", "a", "b", "c", DateTime.Now.AddDays(-84520)));
            lifo.Push(new Entidades.Empleado("00000006F", "a", "b", "c", DateTime.Now.AddDays(-84520)));
            lifo.Push(new Entidades.Empleado("00000007G", "a", "b", "c", DateTime.Now.AddDays(-84520)));
            lifo.Push(new Entidades.Empleado("00000008H", "a", "b", "c", DateTime.Now.AddDays(-84520)));
            //..

            Console.WriteLine($"La pila tiene {lifo.Count} elementos");
            Entidades.Empleado firstEmp = lifo.Pop();
            Console.WriteLine($"La pila tiene {lifo.Count} elementos");
            firstEmp = lifo.Pop();
            Console.WriteLine($"La pila tiene {lifo.Count} elementos");
            firstEmp = lifo.Pop();
            lifo.Push(new Entidades.Empleado("00000009I", "a", "b", "c", DateTime.Now.AddDays(-84520)));
            Console.WriteLine($"La pila tiene {lifo.Count} elementos");
            firstEmp = lifo.Peek();
            Console.WriteLine($"La pila tiene {lifo.Count} elementos");
            firstEmp = lifo.Peek();
            Console.WriteLine($"La pila tiene {lifo.Count} elementos");
        }
    }
}
