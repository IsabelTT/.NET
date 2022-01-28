using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;
using System.Data;
using Microsoft.Extensions.Logging;

namespace MyEmpresa
{
    class Program
    {
        private static int Suma(ref int aaa, int b)
        {
            int c = aaa + b;
            aaa = 9;
            b = 123123;
            return c;
        }

        private static void CambiarEmpleado(ref Entidades.Empleado emp)
        {
            emp.Name = "Lorem Ipsum";
        }

        static void Main(string[] args)
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

            Entidades.Empleado.PrintAll(empleados);

            //Quien cree q la lista estara vacia
            //Ganadores
            //Soraya, Cristina, Adrian, Guillermo, Jose Carlos

            //Quien cree q la lista no se ha modificado
            //Irene, Carolina, Isabel

            //Paso de parametros por valor o por referencia
            int a = 2, b = 5, c;
            c = Suma(ref a, b);

            Entidades.Empleado pepe = new Entidades.Empleado("12345678J", "Pepe Garcia Lopez", DateTime.Now.AddDays(-53454));
            CambiarEmpleado(ref pepe);

            //Inyeccion de dependecia -- utilizacion de interfaces
            //Creacion de instancias de clase utilizando reflexion mediante el nombre de la clase (cadena)

            string opt, sqlServer = null;

            if (string.IsNullOrEmpty(args[0]))
            {
                opt = "G";
            }
            else
            {
                opt = args[0];
            }

            //Registrando los servicios
            ServiceCollection service = new ServiceCollection();

            switch (opt)
            {
                case "G":
                    service.AddScoped(typeof(Model.IOrganizacion), typeof(Geo.Comunidad));
                    service.AddScoped(typeof(Model.ISegundoNivel), typeof(Geo.Provincia));
                    service.AddScoped(typeof(Model.ITercerNivel), typeof(Geo.Ciudad));
                    break;
                case "E":
                    service.AddScoped(typeof(Model.IOrganizacion), typeof(Estructura.Division));
                    service.AddScoped(typeof(Model.ISegundoNivel), typeof(Estructura.Area));
                    service.AddScoped(typeof(Model.ITercerNivel), typeof(Estructura.Zona));
                    break;
                default:
                    break;
            }

            //service.AddScoped(typeof(Servicios.IOrganizacionServicio), typeof(Servicios.OrganizacionServicio));
            service.AddScoped<Servicios.IOrganizacionServicio, Servicios.OrganizacionServicio>();
            service.AddScoped<AccesoDatos.IOrganizacionRespositorio, AccesoDatos.OrganizacionRespositorio>();

            if (string.IsNullOrEmpty(args[1]))
            {
                sqlServer = "MySql";
            }
            else
            {
                sqlServer = args[1];
            }

            switch (sqlServer)
            {
                case "MySql":
                    service.AddScoped<IDbConnection, MySql.Data.MySqlClient.MySqlConnection>();
                    break;
                case "SqlServer":
                    service.AddScoped<IDbConnection, System.Data.SqlClient.SqlConnection>();
                    break;
                case "Oracle":
                    break;
                default:
                    break;
            }

            MyEmpresa.Model.Empresa empresa = new Model.Empresa();
            //......
            //Recuperar las instancias
            using (ServiceProvider servProvider = service.BuildServiceProvider())
            {
                Servicios.IOrganizacionServicio servicio = servProvider.GetService<Servicios.IOrganizacionServicio>();
                servicio.Guardar(new Estructura.Division());
            }

            Console.ReadKey();
        }
    }
}


