using Newtonsoft.Json;
using Romsoft.GESTIONCLINICA.Business.Logic.Tablas;
using Romsoft.GESTIONCLINICA.Entidades.ADM_ESPECIALIDAD;
using Romsoft.GESTIONCLINICA.Entidades;
using Romsoft.GESTIONCLINICA.DTO.TABLAS.ADM_ESPECIALIDAD;
using Romsoft.GESTIONCLINICA.WebApi.Core;
using Romsoft.GESTIONCLINICA.Common;
using System;
using System.Collections.Generic;
using System.Web.Http;
using Romsoft.GESTIONCLINICA.DTO.AutoMapper;

namespace Romsoft.GESTIONCLINICA.WebApi.Controllers
{
    public class ADM_ESPECIALIDADController : BaseController
    {
        //Obtiene Lista de Especialdiad Activos
        [HttpPost]
        public JsonResponse GetAllActives()
        {
            var jsonResponse = new JsonResponse { Success = true };

            try
            {
                var especialidadList = ADM_ESPECIALIDADBL.Instancia.GetAllActives();
                var espeDTOList = MapperHelper.Map<IEnumerable<ADM_ESPECIALIDAD>, IEnumerable<ADM_ESPECIALIDADDTO>>(especialidadList);
                jsonResponse.Data = espeDTOList;
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
