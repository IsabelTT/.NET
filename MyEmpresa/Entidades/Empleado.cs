using System;
using System.Collections.Generic;
using System.Linq;

namespace MyEmpresa.Entidades
{
    public class Empleado
    {
        #region Variables

        private string nif, name, firstLastName, secondLastName;
        private DateTime birth;
        private bool boss;

        #endregion

        #region Propiedades

        public string NIF
        {
            get { return nif; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception($"Empleado no valido: {nameof(NIF)} vacio o nulo");
                }
                if (value.Length != 9)
                {
                    throw new Exception($"Empleado no valido: {nameof(NIF)} no tiene la longitud correcta");
                }

                nif = value;
            }
        }
        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception($"Empleado no valido: {nameof(Name)} vacio o nulo");
                }
                name = value;
            }
        }
        public string FirstLastName
        {
            get { return firstLastName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception($"Empleado no valido: {nameof(FirstLastName)} vacio o nulo");
                }

                firstLastName = value;
            }
        }
        public string SecondLastName
        {
            get { return secondLastName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception($"Empleado no valido: {nameof(SecondLastName)} vacio o nulo");
                }

                secondLastName = value;
            }
        }
        public int? Phone { get; set; }
        public string Email { get; set; }
        public DateTime Birth
        {
            get { return birth; }
            set
            {
                if (GetAge(value) < 18)
                {
                    throw new Exception("Empleado no valido: es menor de edad");
                }

                birth = value;
            }
        }
        public long SocialNumber { get; set; }
        public uint Age
        {
            get
            {
                return GetAge(Birth);
            }
        }
        public bool Boss
        {
            private get
            {
                return boss;
            }
            set
            {
                boss = value;
            }
        }

        #endregion

        #region Constructor

        public Empleado(string nif, string fullName, DateTime birth)
        {
            string[] split = fullName.Split(' ');

            if (split.Length != 3)
            {
                throw new Exception("El formato de nombre no es correcto");
            }

            NIF = nif;
            Name = split[0];
            FirstLastName = split[1];
            SecondLastName = split[2];
            Birth = birth;
        }

        public Empleado(string nif, string name, string firstLastName, string secondLastName, DateTime birth)
        {
            NIF = nif;
            Name = name;
            FirstLastName = firstLastName;
            SecondLastName = secondLastName;
            Birth = birth;
        }

        public Empleado(string nif, string name, string firstLastName, string secondLastName, DateTime birth, int? phone = null)
        {
            NIF = nif;
            Name = name;
            FirstLastName = firstLastName;
            SecondLastName = secondLastName;
            Birth = birth;
            Phone = phone;
        }

        #endregion

        #region Funciones

        private static uint GetAge(DateTime birth)
        {
            if (birth == null)
                return 0;

            var age = DateTime.Today.Year - birth.Year;
            if (birth.Date > DateTime.Today.AddYears(-age))
            {
                age = age - 1;
            }
            return (uint)age;
        }

        private static uint GetAge(string birth)
        {
            return 0;
        }

        private static uint GetAge(int year, int month, int day)
        {
            return 0;
        }

        public override string ToString()
        {
            return $"{nameof(NIF)}: {NIF}\n{nameof(Name)}: {Name}\n{nameof(FirstLastName)}: {FirstLastName}\n{nameof(SecondLastName)}: {SecondLastName}\n{nameof(Birth)}: {Birth:yy/MM/dd}\nTiene {GetAge(Birth)} años {(Phone == null ? "Sin telefono" : Phone.ToString())}\n{(Boss ? "Jefe" : "Empleado")}\n";
            //return $"{nameof(NIF)}: {NIF}\n";
        }

        //Para el correcto funcionamiento al agregar elementos unicos en un HashSet debemos sobreescribir los metodos GetHashCode y Equals
        //Sobreescribir metodo GetHashCode
        public override int GetHashCode()
        {
            return NIF.ToLower().GetHashCode();
        }

        //Sobreescribir metodo Equals
        public override bool Equals(object obj)
        {
           return GetHashCode() == obj.GetHashCode();
        }

        public static void PrintAll(List<Empleado> empleados)
        {
            if (empleados.Any())
            {
                var emp = empleados[0];
                Console.WriteLine(emp);

                empleados.Remove(emp);
                PrintAll(empleados);
            }
        }

        #endregion
    }
}
