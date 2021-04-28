using Newtonsoft.Json;
using Romsoft.GESTIONCLINICA.Business.Logic.Tablas;
using Romsoft.GESTIONCLINICA.Entidades.ADM_TIPO_EGRESO;
using Romsoft.GESTIONCLINICA.Entidades;
using Romsoft.GESTIONCLINICA.DTO.TABLAS.ADM_TIPO_EGRESO;
using Romsoft.GESTIONCLINICA.WebApi.Core;
using Romsoft.GESTIONCLINICA.Common;
using System;
using System.Collections.Generic;
using System.Web.Http;
using Romsoft.GESTIONCLINICA.DTO.AutoMapper;

namespace Romsoft.GESTIONCLINICA.WebApi.Controllers
{
    public class ADM_TIPO_EGRESOController : BaseController
    {
        //Obtiene Lista de CIE10 Activos
        [HttpPost]
        public JsonResponse GetAllActives()
        {
            var jsonResponse = new JsonResponse { Success = true };

            try
            {
                var tipoegresoList = ADM_TIPO_EGRESOBL.Instancia.GetAllActives();
                var tipoegresoDTOList = MapperHelper.Map<IEnumerable<ADM_TIPO_EGRESO>, IEnumerable<ADM_TIPO_EGRESODTO>>(tipoegresoList);
                jsonResponse.Data = tipoegresoDTOList;
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
