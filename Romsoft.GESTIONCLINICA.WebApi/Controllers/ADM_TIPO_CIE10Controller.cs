using Newtonsoft.Json;
using Romsoft.GESTIONCLINICA.Business.Logic.Tablas;
using Romsoft.GESTIONCLINICA.Entidades.ADM_TIPO_CIE10;
using Romsoft.GESTIONCLINICA.Entidades;
using Romsoft.GESTIONCLINICA.DTO.TABLAS.ADM_TIPO_CIE10;
using Romsoft.GESTIONCLINICA.WebApi.Core;
using Romsoft.GESTIONCLINICA.Common;
using System;
using System.Collections.Generic;
using System.Web.Http;
using Romsoft.GESTIONCLINICA.DTO.AutoMapper;

namespace Romsoft.GESTIONCLINICA.WebApi.Controllers
{
    public class ADM_TIPO_CIE10Controller : BaseController
    {

        //Obtiene Lista Tipo CIE10 Activos
        [HttpPost]
        public JsonResponse GetAllActives()
        {
            var jsonResponse = new JsonResponse { Success = true };

            try
            {
                var tipocie10List = ADM_TIPO_CIE10BL.Instancia.GetAllActives();
                var tipocie10DTOList = MapperHelper.Map<IEnumerable<ADM_TIPO_CIE10>, IEnumerable<ADM_TIPO_CIE10DTO>>(tipocie10List);
                jsonResponse.Data = tipocie10DTOList;
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
