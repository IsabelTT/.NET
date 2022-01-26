using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;

namespace MyEmpresa
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inyeccion de dependecia -- utilizacion de interfaces
            //Creacion de instancias de clase utilizando reflexion mediante el nombre de la clase (cadena)

            string opt = null;

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

            MyEmpresa.Model.Empresa empresa = new Model.Empresa();
            //......
            //Recuperar las instancias
            using (ServiceProvider servProvider = service.BuildServiceProvider())
            {
                Model.IOrganizacion org = servProvider.GetService<Model.IOrganizacion>();
                org.Crear();
            }

            Console.ReadKey();
        }
    }
}


