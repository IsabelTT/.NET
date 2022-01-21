using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace MyEmpresa
{
    public class CollectionsService
    {
        public static void ListExample01()
        {
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

            var nuevaLista = empleados.OrderBy(x => x.NIF, new DescendComparer());

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
        }

        public static void ListExample02()
        {
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

            var indice = empleados.FindIndex(e => e.NIF == "45234555P");
            if (indice != -1)
            {
                empleados.RemoveAt(indice);
            }

            var emp = empleados.FirstOrDefault(x => x.NIF == "45234555P");
            if (emp != null)
            {
                empleados.Remove(emp);
            }

            empleados.RemoveAll(x => x.NIF == "45234555P");

            foreach (var empl in empleados)
            {
                if (empl.NIF == "45234555P")
                {
                    empleados.Remove(empl);
                }
            }

            Console.WriteLine(empleados.Count);
            empleados.RemoveAt(4);
            Console.WriteLine(empleados.Count);
            empleados.Remove(emp7);
            Console.WriteLine(empleados.Count);
        }

        public static void HashTableExample01()
        {
            HashSet<int> numeros = new HashSet<int>();
            numeros.Add(1);
            numeros.Add(2);
            numeros.Add(3);
            numeros.Add(4);
            numeros.Add(5);
            numeros.Add(1);
            numeros.Add(1);
            numeros.Add(1);
            numeros.Add(1);
            numeros.Add(1);
            numeros.Add(1);
            numeros.Add(1);
            numeros.Add(1);
            numeros.Add(7);
            numeros.Add(5);
            numeros.Add(9);
            numeros.Add(3);

            numeros.ToList().ForEach(Console.WriteLine);
        }

        public static void HashTableExample02()
        {
            //Crear una lista con elementos unicos de empleado
            var emp1 = new Entidades.Empleado("12345678V", "Alfonso Perez Aguilar", DateTime.Now.AddDays(-46393));
            var emp2 = new Entidades.Empleado("52345234H", "c v f", DateTime.Now.AddDays(-64566));
            var emp3 = new Entidades.Empleado("64563456L", "w l e", DateTime.Now.AddDays(-73567));

            var emp4 = new Entidades.Empleado("12345678V", "Alfonso Perez Aguilar", DateTime.Now.AddDays(-46393));
            var emp5 = new Entidades.Empleado("64563456L", "w l e", DateTime.Now.AddDays(-73567));

            HashSet<Entidades.Empleado> empleados = new HashSet<Entidades.Empleado>();
            empleados.Add(emp1);
            empleados.Add(emp2);
            empleados.Add(emp3);
            empleados.Add(emp4);
            empleados.Add(emp5);

            empleados.ToList().ForEach(Console.WriteLine);
        }

        public static void DictionariesExample01()
        {
            var emp1 = new Entidades.Empleado("12345678V", "Alfonso Perez Aguilar", DateTime.Now.AddDays(-46393));
            var emp2 = new Entidades.Empleado("52345234H", "c v f", DateTime.Now.AddDays(-64566));
            var emp3 = new Entidades.Empleado("64563456L", "w l e", DateTime.Now.AddDays(-73567));
            var emp4 = new Entidades.Empleado("52345345Q", "m r p", DateTime.Now.AddDays(-34567));
            var emp5 = new Entidades.Empleado("43236565M", "e m t", DateTime.Now.AddDays(-56345));

            Dictionary<string, Entidades.Empleado> empleados = new Dictionary<string, Entidades.Empleado>();
            empleados.Add(emp1.NIF, emp1);
            empleados.Add(emp2.NIF, emp2);
            empleados.Add(emp3.NIF, emp3);
            empleados.Add(emp4.NIF, emp4);

            //lambda
            empleados.ToList().ForEach((k) => { Console.WriteLine(k.Value); });

            try
            {
                var cvf = empleados["45328799"];
                Console.WriteLine(cvf);
            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine("Empleado no encontrado");
            }

            var emp = empleados.GetValueOrDefault("874653", new Entidades.Empleado("55328476B", "g y t", DateTime.Now.AddDays(-45672)));
            Console.WriteLine(emp);
        }

        public static void SortedListExample01()
        {
            var emp1 = new Entidades.Empleado("12345678V", "Alfonso Perez Aguilar", DateTime.Now.AddDays(-46393));
            var emp2 = new Entidades.Empleado("52345234H", "c v f", DateTime.Now.AddDays(-64566));
            var emp3 = new Entidades.Empleado("64563456L", "w l e", DateTime.Now.AddDays(-73567));
            var emp4 = new Entidades.Empleado("52345345Q", "m r p", DateTime.Now.AddDays(-34567));
            var emp5 = new Entidades.Empleado("43236565M", "e m t", DateTime.Now.AddDays(-56345));

            SortedList<string, Entidades.Empleado> empleados = new SortedList<string, Entidades.Empleado>(new DescendComparer());
            empleados.Add(emp1.NIF, emp1);
            empleados.Add(emp2.NIF, emp2);
            empleados.Add(emp3.NIF, emp3);
            empleados.Add(emp4.NIF, emp4);

            empleados.ToList().ForEach((k) => Console.WriteLine(k.Value));
            empleados.Add(emp5.NIF, emp5);
            empleados.ToList().ForEach((k) => Console.WriteLine(k.Value));

        }

        private class DescendComparer : IComparer<string>
        {
            public int Compare([AllowNull] string x, [AllowNull] string y)
            {
                return y.CompareTo(x);
            }
        }
    }
}
