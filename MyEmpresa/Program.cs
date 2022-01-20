using System;
using System.Linq;
using System.Collections.Generic;

namespace MyEmpresa
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pila
            Stack<Entidades.Empleado> lifo;

            //Cola
            Queue<Entidades.Empleado> fifo;

            var emp1 = new Entidades.Empleado("12345678V", "Alfonso Perez Aguilar", DateTime.Now.AddDays(-46393));
            var emp2 = new Entidades.Empleado("52345234H", "c v f", DateTime.Now.AddDays(-64566));
            var emp3 = new Entidades.Empleado("64563456L", "w l e", DateTime.Now.AddDays(-73567));
            var emp4 = new Entidades.Empleado("52345345Q", "m r p", DateTime.Now.AddDays(-34567));
            var emp5 = new Entidades.Empleado("43236565M", "e m t", DateTime.Now.AddDays(-56345));
            var emp6 = new Entidades.Empleado("45234555P", "o d f", DateTime.Now.AddDays(-23645));
            var emp7 = new Entidades.Empleado("02132184V", "r c b", DateTime.Now.AddDays(-82346));
            var emp8 = new Entidades.Empleado("34523455X", "f u u", DateTime.Now.AddDays(-64356));
            var emp9 = new Entidades.Empleado("45234534V", "m b b", DateTime.Now.AddDays(-72456));
            
            List<Entidades.Empleado> empleados = new List<Entidades.Empleado> {
                emp1,
                emp2,
                emp3,
                emp4,
                emp5,
                emp6,
                emp7,
                emp8,
                emp9
            };

            Entidades.Empleado.PrintAll(empleados);

            Entidades.Empleado emp = new Entidades.Empleado("76547365G", "Antonio", "Fernandez", "Ochoa", DateTime.Now.AddDays(-9367))
            {
                Phone = 765834765,
                SocialNumber = 213453245
            };
            emp.Boss = true;
            Console.WriteLine(emp);
            Console.WriteLine("{3} NIF: {0} Nombre: {1} {2} {4}", emp.NIF, emp.Name, emp.FirstLastName, emp.SecondLastName, emp.Phone);

            //Entidades.Empleado emp2 = new Entidades.Empleado(birth: DateTime.Now, firstLastName: "Garcia", secondLastName: "Garcia", nif: "345345345H", name: "Jose");
            //Entidades.Empleado emp3 = new Entidades.Empleado("", "", "", "", DateTime.Now, 5234555);

            Console.WriteLine("El empleado tiene " + emp.Age + " tacos");
            //Console.WriteLine("El empleado tiene " + emp.GetAge() + " tacos");

            Console.ReadKey();
        }
    }
}


