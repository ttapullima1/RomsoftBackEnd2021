using Newtonsoft.Json;
using Romsoft.GESTIONCLINICA.Business.Logic.Tablas;
using Romsoft.GESTIONCLINICA.Entidades.ADM_HABITACION;
using Romsoft.GESTIONCLINICA.Entidades;
using Romsoft.GESTIONCLINICA.DTO.TABLAS.ADM_HABITACION;
using Romsoft.GESTIONCLINICA.WebApi.Core;
using Romsoft.GESTIONCLINICA.Common;
using System;
using System.Collections.Generic;
using System.Web.Http;
using Romsoft.GESTIONCLINICA.DTO.AutoMapper;


namespace Romsoft.GESTIONCLINICA.WebApi.Controllers
{
    public class ADM_HABITACIONController : BaseController
    {
        //Obtiene Lista Habitación Activos
        [HttpPost]
        public JsonResponse GetAllActives()
        {
            var jsonResponse = new JsonResponse { Success = true };

            try
            {
                var cie10List = ADM_HABITACIONBL.Instancia.GetAllActives();
                var cie10DTOList = MapperHelper.Map<IEnumerable<ADM_HABITACION>, IEnumerable<ADM_HABITACIONDTO>>(cie10List);
                jsonResponse.Data = cie10DTOList;
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
