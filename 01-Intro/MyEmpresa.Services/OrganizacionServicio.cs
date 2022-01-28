using MyEmpresa.AccesoDatos;
using MyEmpresa.Model;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;

namespace MyEmpresa.Servicios
{
    public class OrganizacionServicio : IOrganizacionServicio
    {
        private IOrganizacionRespositorio respositorio;
        private ISegundoNivelRepositorio segundoNivelRepositorio;
        private ITercerNivelRespositorio tercerNivelRespositorio;

        public OrganizacionServicio(IOrganizacionRespositorio respositorio, 
            ISegundoNivelRepositorio segundoNivelRepositorio,
            ITercerNivelRespositorio tercerNivelRespositorio)
        {
            this.respositorio = respositorio;
            this.segundoNivelRepositorio = segundoNivelRepositorio;
            this.tercerNivelRespositorio = tercerNivelRespositorio;
        }

        public void Guardar(IOrganizacion org)
        {
            try
            {
                respositorio.Crear(org);
                if (org.SegundoNiveles.Any())
                {
                    foreach (var segNivel in org.SegundoNiveles)
                    {
                        try
                        {
                            segundoNivelRepositorio.Crear(segNivel);

                            if (segNivel.TercerNiveles.Any())
                            {
                                foreach (var terNivel in segNivel.TercerNiveles)
                                {
                                    try
                                    {
                                        tercerNivelRespositorio.Crear(terNivel);
                                    }
                                    catch (DbException)
                                    {
                                        tercerNivelRespositorio.Actualizar(terNivel);
                                    }
                                }
                            }
                        }
                        catch (DbException)
                        {
                            segundoNivelRepositorio.Actualizar(segNivel);
                        }
                    }
                }
            }
            catch (DbException) //Error de clave duplicada
            {
                respositorio.Actualizar(org);
            }
            catch (Exception)
            { 
                //guardar en log
            }
        }
    }
}
