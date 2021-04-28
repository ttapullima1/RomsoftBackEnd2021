using Newtonsoft.Json;
using Romsoft.GESTIONCLINICA.Business.Logic.Tablas;
using Romsoft.GESTIONCLINICA.Entidades.ADM_DOCUMENTO_AUTORIZACION;
using Romsoft.GESTIONCLINICA.DTO.TABLAS.ADM_DOCUMENTO_AUTORIZACION;
using Romsoft.GESTIONCLINICA.WebApi.Core;
using Romsoft.GESTIONCLINICA.Common;
using System;
using System.Collections.Generic;
using System.Web.Http;
using Romsoft.GESTIONCLINICA.DTO.AutoMapper;
using Romsoft.GESTIONCLINICA.Entidades;

namespace Romsoft.GESTIONCLINICA.WebApi.Controllers
{
    public class ADM_DOCUMENTO_AUTORIZACIONController : BaseController
    {

        [HttpPost]
        public JsonResponse Add(ADM_DOCUMENTO_AUTORIZACION_REQDTO autorizaDTO)
        {
            var jsonResponse = new JsonResponse { Success = true };
            try
            {
                int resultado = 0;
                var autoriza = MapperHelper.Map<ADM_DOCUMENTO_AUTORIZACION_REQDTO, ADM_DOCUMENTO_AUTORIZACION_REQ>(autorizaDTO);

                if (!ADM_DOCUMENTO_AUTORIZACION_REQBL.Instancia.Exists(autoriza))
                {
                    resultado = ADM_DOCUMENTO_AUTORIZACION_REQBL.Instancia.Add(autoriza);

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
                    Usuario = Convert.ToString(autorizaDTO.idUser),
                    Objeto = JsonConvert.SerializeObject(autorizaDTO)
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
                    Usuario = Convert.ToString(autorizaDTO.idUser),
                    Objeto = JsonConvert.SerializeObject(autorizaDTO)
                });
            }

            return jsonResponse;
        }


        [HttpPost]
        public JsonResponse GetAllFilters(ADM_DOCUMENTO_AUTORIZACIONDTO autorizacionlDTO)
        {
            var jsonResponse = new JsonResponse { Success = true };

            try
            {
                var autorizacion = MapperHelper.Map<ADM_DOCUMENTO_AUTORIZACIONDTO, ADM_DOCUMENTO_AUTORIZACION>(autorizacionlDTO);

                var autorizacionlList = ADM_DOCUMENTO_AUTORIZACIONBL.Instancia.GetAllFilters(autorizacion);
                var autorizacionDTOList = MapperHelper.Map<IEnumerable<ADM_DOCUMENTO_AUTORIZACION>, IEnumerable<ADM_DOCUMENTO_AUTORIZACIONDTO>>(autorizacionlList);
                jsonResponse.Data = autorizacionDTOList;

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
        public JsonResponse GetAddAtencionAll(ADM_DOCUMENTO_AUTORIZACION_REQ requestAutoriza)
        {
            var jsonResponse = new JsonResponse { Success = true };

            try
            {
            //    if(requestAutoriza.listaAutoriza.COD_AUTORIZACION =NULL)
            //    {

            //    }

                var autorizaList = ADM_DOCUMENTO_AUTORIZACION_REQBL.Instancia.GetAddAtencionAll(requestAutoriza);
                var autorizaDTOList = MapperHelper.Map<IEnumerable<ADM_DOCUMENTO_AUTORIZACION_RES>, IEnumerable<ADM_DOCUMENTO_AUTORIZACION_RESDTO>>(autorizaList);
                jsonResponse.Data = autorizaDTOList;
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
