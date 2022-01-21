using System;
using System.Collections.Generic;
using System.Text;

namespace MyEmpresa
{
    public class QueueService
    {
        public static void Example()
        {
            //Cola --> First In - First Out
            Queue<Entidades.Empleado> fifo = new Queue<Entidades.Empleado>();
            fifo.Enqueue(new Entidades.Empleado("00000001A", "a", "b", "c", DateTime.Now.AddDays(-84520)));
            fifo.Enqueue(new Entidades.Empleado("00000002B", "a", "b", "c", DateTime.Now.AddDays(-84520)));
            fifo.Enqueue(new Entidades.Empleado("00000003C", "a", "b", "c", DateTime.Now.AddDays(-84520)));
            fifo.Enqueue(new Entidades.Empleado("00000004D", "a", "b", "c", DateTime.Now.AddDays(-84520)));
            fifo.Enqueue(new Entidades.Empleado("00000005E", "a", "b", "c", DateTime.Now.AddDays(-84520)));
            fifo.Enqueue(new Entidades.Empleado("00000006F", "a", "b", "c", DateTime.Now.AddDays(-84520)));
            fifo.Enqueue(new Entidades.Empleado("00000007G", "a", "b", "c", DateTime.Now.AddDays(-84520)));
            fifo.Enqueue(new Entidades.Empleado("00000008H", "a", "b", "c", DateTime.Now.AddDays(-84520)));
            //..

            Console.WriteLine($"La cola tiene {fifo.Count} elementos");
            Entidades.Empleado lastEmpleado = fifo.Dequeue();
            Console.WriteLine($"La cola tiene {fifo.Count} elementos");
            lastEmpleado = fifo.Dequeue();
            lastEmpleado = fifo.Dequeue();
            lastEmpleado = fifo.Dequeue();
            lastEmpleado = fifo.Dequeue();
            lastEmpleado = fifo.Dequeue();
            Console.WriteLine($"La cola tiene {fifo.Count} elementos");
            lastEmpleado = fifo.Dequeue();
            Console.WriteLine($"La cola tiene {fifo.Count} elementos");
            fifo.Enqueue(new Entidades.Empleado("00000009I", "a", "b", "c", DateTime.Now.AddDays(-84520)));
            lastEmpleado = fifo.Dequeue();
            Console.WriteLine($"La cola tiene {fifo.Count} elementos");
            lastEmpleado = fifo.Dequeue();
            Console.WriteLine($"La cola tiene {fifo.Count} elementos");
            bool success = fifo.TryDequeue(out lastEmpleado);

            string cadena = "d";
            int num = 0;
            success = int.TryParse(cadena, out num);
        }
    }
}
