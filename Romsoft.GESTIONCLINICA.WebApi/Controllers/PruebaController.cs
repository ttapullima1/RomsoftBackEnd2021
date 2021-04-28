using Newtonsoft.Json;
using Romsoft.GESTIONCLINICA.Business.Logic.Tablas;
using Romsoft.GESTIONCLINICA.Entidades.Prueba;
using Romsoft.GESTIONCLINICA.DTO;
using Romsoft.GESTIONCLINICA.WebApi.Core;
using Romsoft.GESTIONCLINICA.Common;
using System;
using System.Collections.Generic;
using System.Web.Http;
using Romsoft.GESTIONCLINICA.DTO.AutoMapper;
using Romsoft.GESTIONCLINICA.Entidades;


namespace Romsoft.GESTIONCLINICA.WebApi.Controllers
{
    public class PruebaController : BaseController
    {
        [HttpPost]
        public JsonResponse addDetalle(DTO.TABLAS.Prueba.Cabecera_Prueba cabeceraDetalleDTO)
        {
            var jsonResponse = new JsonResponse { Success = true };
            try
            {
              
                int resultado = 0;
                 var cabDetalle = MapperHelper.Map<DTO.TABLAS.Prueba.Cabecera_Prueba, Cabecera_Prueba>(cabeceraDetalleDTO);
                string idprueba = "0";

                if (!PruebaBL.Instancia.Exists(idprueba))
                {
                    resultado = PruebaBL.Instancia.addDetalle(cabDetalle);

                    if (resultado > 0)
                    {
                        jsonResponse.Message = Mensajes.RegistroSatisfactorio;
                    }
                    else
                    {
                        jsonResponse.Warning = true;
                        jsonResponse.Message = Mensajes.RegistroFallido;
                    }
                }
                else
                {
                    jsonResponse.Warning = true;
                    jsonResponse.Message = Mensajes.YaExisteRegistro;
                }

                LogBL.Instancia.Add(new Log
                {
                    Accion = Mensajes.Add,
                    Controlador = Mensajes.UsuarioController,
                    Identificador = resultado,
                    Mensaje = jsonResponse.Message,
                    Usuario = "",//cabeceraDetalleDTO.UsuarioCreacion,
                    Objeto = "" //JsonConvert.SerializeObject(cabeceraDetalleDTO)
                }); ; ;
            }
            catch (Exception ex)
            {
                LogError(ex);
                jsonResponse.Success = false;
                jsonResponse.Message = Mensajes.IntenteloMasTarde;

                LogBL.Instancia.Add(new Log
                {
                    Accion = Mensajes.Add,
                    Controlador = Mensajes.UsuarioController,
                    Identificador = 0,
                    Mensaje = ex.Message,
                    Usuario = "",//cabeceraDetalleDTO.UsuarioCreacion,
                    Objeto = "" //JsonConvert.SerializeObject(cabeceraDetalleDTO)
                });
            }

            return jsonResponse;
        }

    }
}
