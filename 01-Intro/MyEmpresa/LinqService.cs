using System;
using System.Collections.Generic;
using System.Linq;

namespace MyEmpresa
{
    public class LinqService
    {
        public static void Example01()
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
            };

            var mayores = GetMayoresDe(empleados.ToHashSet(), 40);

            HashSet<Entidades.Empleado> empleados1 = new HashSet<Entidades.Empleado> {
                emp1,
                emp2,
                emp3,
                emp4,
                emp5,
                emp6,
                emp7,
            };
            var mayores1 = GetMayoresDe(empleados1, 40);

            List<Entidades.Empleado> empleados2 = new List<Entidades.Empleado> {
                emp1,
                emp6,
                emp7,
                emp8,
                emp9
            };

            var subconjunto = empleados2.Where(e => empleados.Contains(e));

            //lambda
            //query syntax

            var emps = from e in empleados
                       where e.Age > 40 && e.Phone != null && e.Name.StartsWith("Alf") && e.FirstLastName.Contains("ez")
                       orderby e.Name, e.FirstLastName, e.SecondLastName
                       //select $"{e.Name} {e.FirstLastName} {e.SecondLastName}";
                       //select e;
                       //select new { e.Name, e.Age, e.Phone };
                       //select new { Nombre = $"{e.Name} {e.FirstLastName} {e.SecondLastName}", e.Age, e.Phone };
                       //select new EmpleadoLite($"{e.Name} {e.FirstLastName} {e.SecondLastName}", e.Age, e.Phone);
                       select EmpleadoMapper.ToEmpleadoLite(e);

            foreach (var item in emps)
            {
                item.Edad = 32;
            }

            //method syntax

            int page = 2;
            IEnumerable<EmpleadoLite> emps2 = empleados.Select(e => EmpleadoMapper.ToEmpleadoLite(e))
                .Where(e => e.Edad > 40) 
                .OrderBy(e => e.Nombre);

            var cvf = empleados.OrderBy(e => e.Birth).First(e => e.Age > 40);
            if (cvf == null)
            {

            }

            bool existe = empleados.Any(e => e.NIF == "23423446G");
            if (existe)
            {
                var empSingle = empleados.Single(e => e.NIF == "23423446G");
            }

            bool todos = empleados.All(e => e.Phone != null);

            var dentro = empleados.Contains(new Entidades.Empleado("23423446G", "", DateTime.Now));

            var conteo = empleados.Count();
            var sum = empleados.Sum(e => e.Salario);
            var mediaSalario = empleados.Average(e => e.Salario);
            var mediaEdad = empleados.Average(e => e.Age);

            var salarioMax = empleados.Max(e => e.Salario);
            var salarioMin = empleados.Min(e => e.Salario);
        }

        private class EmpleadoLite
        {
            public string Nombre { get; set; }
            public uint Edad { get; set; }
            public int? Telefono { get; set; }

            public EmpleadoLite(string nombre, uint edad, int? telefono)
            {
                Nombre = nombre;
                Edad = edad;
                Telefono = telefono;
            }
        }

        private class EmpleadoMapper
        {
            public static EmpleadoLite ToEmpleadoLite(Entidades.Empleado emp)
            {
                return new EmpleadoLite($"{emp.Name} {emp.FirstLastName} {emp.SecondLastName}", emp.Age, emp.Phone);
            }
        }

        private static IEnumerable<Entidades.Empleado> GetMayoresDe(HashSet<Entidades.Empleado> empleados, int edad)
        {
            return empleados.Where(e => e.Age > edad);
        }
    }
}
