using Newtonsoft.Json;
using Romsoft.GESTIONCLINICA.Business.Logic.Tablas;
using Romsoft.GESTIONCLINICA.Entidades.ADM_CIE10;
using Romsoft.GESTIONCLINICA.Entidades;
using Romsoft.GESTIONCLINICA.DTO.TABLAS.ADM_CIE10;
using Romsoft.GESTIONCLINICA.WebApi.Core;
using Romsoft.GESTIONCLINICA.Common;
using System;
using System.Collections.Generic;
using System.Web.Http;
using Romsoft.GESTIONCLINICA.DTO.AutoMapper;

namespace Romsoft.GESTIONCLINICA.WebApi.Controllers
{
    public class ADM_CIE10Controller : BaseController
    {
        //Obtiene Lista de CIE10 Activos
        [HttpPost]
        public JsonResponse GetAllActives()
        {
            var jsonResponse = new JsonResponse { Success = true };

            try
            {
                var cie10List = ADM_CIE10BL.Instancia.GetAllActives();
                var cie10DTOList = MapperHelper.Map<IEnumerable<ADM_CIE10>, IEnumerable<ADM_CIE10DTO>>(cie10List);
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

        //Obtiene Lista de CIE10 Activos por filtro
        [HttpPost]
        public JsonResponse GetAllFilters(ADM_CIE10DTO admcie10lDTO)
        {
            var jsonResponse = new JsonResponse { Success = true };

            try
            {
                var cie10 = MapperHelper.Map<ADM_CIE10DTO, ADM_CIE10>(admcie10lDTO);

                var cie10lList = ADM_CIE10BL.Instancia.GetAllFilters(cie10);
                var cie10DTOList = MapperHelper.Map<IEnumerable<ADM_CIE10>, IEnumerable<ADM_CIE10DTO>>(cie10lList);
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
