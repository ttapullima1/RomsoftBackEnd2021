using Newtonsoft.Json;
using Romsoft.GESTIONCLINICA.Business.Logic.Tablas;
using Romsoft.GESTIONCLINICA.Entidades.ADM_DOCUMENTO_PRESTACION;
using Romsoft.GESTIONCLINICA.Entidades;
using Romsoft.GESTIONCLINICA.DTO.TABLAS.ADM_DOCUMENTO_PRESTACION;
using Romsoft.GESTIONCLINICA.WebApi.Core;
using Romsoft.GESTIONCLINICA.Common;
using System;
using System.Collections.Generic;
using System.Web.Http;
using Romsoft.GESTIONCLINICA.DTO.AutoMapper;

namespace Romsoft.GESTIONCLINICA.WebApi.Controllers
{
    public class ADM_DOCUMENTO_PRESTACIONController : BaseController
    {
        //Obtiene Lista de Doc Prestacion Activos
        [HttpPost]
        public JsonResponse GetAllActives()
        {
            var jsonResponse = new JsonResponse { Success = true };

            try
            {
                var docprestacionList = ADM_DOCUMENTO_PRESTACIONBL.Instancia.GetAllActives();
                var docprestacionDTOList = MapperHelper.Map<IEnumerable<ADM_DOCUMENTO_PRESTACION>, IEnumerable<ADM_DOCUMENTO_PRESTACIONDTO>>(docprestacionList);
                jsonResponse.Data = docprestacionDTOList;
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
