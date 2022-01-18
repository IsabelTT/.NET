using Basic.Intro.Enumerados;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Basic.Intro.Modelo
{
    public delegate void ModeloChanged(string modelo);

    public sealed class Coche :  Contratos.IVehiculo
    {
        #region Variables
        private string modelo;
        public ModeloChanged onModeloChanged;
        #endregion

        #region Propiedades

        public string Modelo
        {
            get
            {
                return modelo;
            }
            set
            {
                if (onModeloChanged != null && value != modelo)
                {
                    onModeloChanged(value);
                }

                modelo = value;
            }
        }
        public Color Color { get; set; }
        public Motor Motor { get; set; }
        public Cambio Cambio { get; set; }

        #endregion

        #region Constructor

        public Coche()
        {

        }

        public Coche(string marca)
        {
            Marca = marca;
        }

        public Coche(string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
        }

        #endregion

        #region Metodos
        
        public static void DelegateEsCoche(Contratos.IVehiculo vehiculo)
        {
            if (vehiculo is Coche)
                Console.WriteLine("El " + vehiculo.Marca + "|" + vehiculo.Modelo + " es un coche");
        }

        #endregion
    }
}
