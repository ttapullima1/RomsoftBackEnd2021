using Newtonsoft.Json;
using Romsoft.GESTIONCLINICA.Business.Logic.Tablas;
using Romsoft.GESTIONCLINICA.Entidades.ADM_TIPO_HOSPITALIZACION;
using Romsoft.GESTIONCLINICA.Entidades;
using Romsoft.GESTIONCLINICA.DTO.TABLAS.ADM_TIPO_HOSPITALIZACION;
using Romsoft.GESTIONCLINICA.WebApi.Core;
using Romsoft.GESTIONCLINICA.Common;
using System;
using System.Collections.Generic;
using System.Web.Http;
using Romsoft.GESTIONCLINICA.DTO.AutoMapper;

namespace Romsoft.GESTIONCLINICA.WebApi.Controllers
{
    public class ADM_TIPO_HOSPITALIZACIONController : BaseController
    {
        //Obtiene Lista de Tipo Hospitalización Activos
        [HttpPost]
        public JsonResponse GetAllActives()
        {
            var jsonResponse = new JsonResponse { Success = true };

            try
            {
                var tipoahospList = ADM_TIPO_HOSPITALIZACIONBL.Instancia.GetAllActives();
                var tipohosDTOList = MapperHelper.Map<IEnumerable<ADM_TIPO_HOSPITALIZACION>, IEnumerable<ADM_TIPO_HOSPITALIZACIONDTO>>(tipoahospList);
                jsonResponse.Data = tipohosDTOList;
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
