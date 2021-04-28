using Newtonsoft.Json;
using Romsoft.GESTIONCLINICA.Business.Logic.Tablas;
using Romsoft.GESTIONCLINICA.Entidades.ADM_ATENCION;
using Romsoft.GESTIONCLINICA.Entidades;
using Romsoft.GESTIONCLINICA.DTO.TABLAS.ADM_ATENCION;
using Romsoft.GESTIONCLINICA.WebApi.Core;
using Romsoft.GESTIONCLINICA.Common;
using System;
using System.Collections.Generic;
using System.Web.Http;
using Romsoft.GESTIONCLINICA.DTO.AutoMapper;

namespace Romsoft.GESTIONCLINICA.WebApi.Controllers
{
    public class ADM_ATENCIONController : BaseController
    {
        [HttpPost]
        public JsonResponse Add(ADM_ATENCIONDTO tarifarioDTO)
        {
            var jsonResponse = new JsonResponse { Success = true };
            try
            {
                int resultado = 0;
                var atencion = MapperHelper.Map<ADM_ATENCIONDTO, ADM_ATENCION>(tarifarioDTO);

                //if (!ADM_ATENCIONBL.Instancia.Exists(atencion))
                //{
                    resultado = ADM_ATENCIONBL.Instancia.Add(atencion);

                    if (resultado > 0)
                    {
                        jsonResponse.Message = Mensajes.RegistroSatisfactorio;
                    }
                    else
                    {
                        jsonResponse.Warning = true;
                        jsonResponse.Message = Mensajes.RegistroFallido;
                    }
                //}
                //else
                //{
                //    jsonResponse.Warning = true;
                //    jsonResponse.Message = Mensajes.YaExisteRegistro;
                //}

                LogBL.Instancia.Add(new Log
                {
                    Accion = Mensajes.Add,
                    Controlador = Mensajes.UsuarioController,
                    Identificador = resultado,
                    Mensaje = jsonResponse.Message,
                    Usuario = tarifarioDTO.UsuarioCreacion,
                    Objeto = JsonConvert.SerializeObject(tarifarioDTO)
                });
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
                    Usuario = tarifarioDTO.UsuarioCreacion,
                    Objeto = JsonConvert.SerializeObject(tarifarioDTO)
                });
            }

            return jsonResponse;
        }



        [HttpPost]
        public JsonResponse GetAllFilters(ADM_ATENCIONDTO atencionesDTO)
        {
            var jsonResponse = new JsonResponse { Success = true };

            try
            {
                var atenciones = MapperHelper.Map<ADM_ATENCIONDTO, ADM_ATENCION>(atencionesDTO);

                var pacienteList = ADM_ATENCIONBL.Instancia.GetAllFilters(atenciones);
                var pacienteDTOList = MapperHelper.Map<IEnumerable<ADM_ATENCION>, IEnumerable<ADM_ATENCIONDTO>>(pacienteList);
                jsonResponse.Data = pacienteDTOList;
            }
            catch (Exception ex)
            {
                LogError(ex);
                jsonResponse.Success = false;
                jsonResponse.Message = Mensajes.IntenteloMasTarde;
            }

            return jsonResponse;
        }

        [HttpPost]
        public JsonResponse GetAllPaciente(int idPaciente)
        {
            var jsonResponse = new JsonResponse { Success = true };

            try
            {
                
                var atencionesList = ADM_ATENCIONBL.Instancia.GetAllPaciente(idPaciente);
                var pacienteDTOList = MapperHelper.Map<IEnumerable<ADM_ATENCION>, IEnumerable<ADM_ATENCIONDTO>>(atencionesList);
                jsonResponse.Data = pacienteDTOList;
            }
            catch (Exception ex)
            {
                LogError(ex);
                jsonResponse.Success = false;
                jsonResponse.Message = Mensajes.IntenteloMasTarde;
            }

            return jsonResponse;
        }

        [HttpPost]
        public JsonResponse GetAtencionAllFilters(ADM_ATENCION_RequestGetAllActiveDTO requestAtencion)
        {
            var jsonResponse = new JsonResponse { Success = true };

            try
            {

                var atencionesList = ADM_ATENCIONBL.Instancia.GetAtencionAllFilters(requestAtencion.id_paciente);
                var atencionesDTOList = MapperHelper.Map<IEnumerable<ADM_ATENCION_ResponseGetAllActives>, IEnumerable<ADM_ATENCION_ResponseGetAllActivesDTO>>(atencionesList);
                jsonResponse.Data = atencionesDTOList;
            }
            catch (Exception ex)
            {
                LogError(ex);
                jsonResponse.Success = false;
                jsonResponse.Message = Mensajes.IntenteloMasTarde;
            }

            return jsonResponse;
        }




    }
}
