using Newtonsoft.Json;
using Romsoft.GESTIONCLINICA.Business.Logic.Tablas;
using Romsoft.GESTIONCLINICA.Entidades.ADM_TIPO_AFILIACION;
using Romsoft.GESTIONCLINICA.Entidades;
using Romsoft.GESTIONCLINICA.DTO.TABLAS.ADM_TIPO_AFILIACION;
using Romsoft.GESTIONCLINICA.WebApi.Core;
using Romsoft.GESTIONCLINICA.Common;
using System;
using System.Collections.Generic;
using System.Web.Http;
using Romsoft.GESTIONCLINICA.DTO.AutoMapper;

namespace Romsoft.GESTIONCLINICA.WebApi.Controllers
{
    public class ADM_TIPO_AFILIACIONController : BaseController
    {
        //Obtiene Lista de CIE10 Activos
        [HttpPost]
        public JsonResponse GetAllActives()
        {
            var jsonResponse = new JsonResponse { Success = true };

            try
            {
                var tipoafiliadoList = ADM_TIPO_AFILIACIONBL.Instancia.GetAllActives();
                var tipoafiDTOList = MapperHelper.Map<IEnumerable<ADM_TIPO_AFILIACION>, IEnumerable<ADM_TIPO_AFILIACIONDTO>>(tipoafiliadoList);
                jsonResponse.Data = tipoafiDTOList;
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
