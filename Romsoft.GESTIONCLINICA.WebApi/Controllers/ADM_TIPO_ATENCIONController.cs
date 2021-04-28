using Newtonsoft.Json;
using Romsoft.GESTIONCLINICA.Business.Logic.Tablas;
using Romsoft.GESTIONCLINICA.Entidades.ADM_TIPO_ATENCION;
using Romsoft.GESTIONCLINICA.Entidades;
using Romsoft.GESTIONCLINICA.DTO.TABLAS.ADM_TIPO_ATENCION;
using Romsoft.GESTIONCLINICA.WebApi.Core;
using Romsoft.GESTIONCLINICA.Common;
using System;
using System.Collections.Generic;
using System.Web.Http;
using Romsoft.GESTIONCLINICA.DTO.AutoMapper;

namespace Romsoft.GESTIONCLINICA.WebApi.Controllers
{
    public class ADM_TIPO_ATENCIONController : BaseController
    {
        //Obtiene Lista de Tipo Atencion Activos
        [HttpPost]
        public JsonResponse GetAllActives()
        {
            var jsonResponse = new JsonResponse { Success = true };

            try
            {
                var tipoatencionList = ADM_TIPO_ATENCIONBL.Instancia.GetAllActives();
                var tipoatencionDTOList = MapperHelper.Map<IEnumerable<ADM_TIPO_ATENCION>, IEnumerable<ADM_TIPO_ATENCIONDTO>>(tipoatencionList);
                jsonResponse.Data = tipoatencionDTOList;
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
