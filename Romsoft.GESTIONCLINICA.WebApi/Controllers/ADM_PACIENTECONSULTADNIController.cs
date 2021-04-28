using Newtonsoft.Json;
using Romsoft.GESTIONCLINICA.Business.Logic.Tablas;
using Romsoft.GESTIONCLINICA.Entidades.ADM_PACIENTE;
using Romsoft.GESTIONCLINICA.Entidades;
using Romsoft.GESTIONCLINICA.DTO.TABLAS.ADM_PACIENTE;
using Romsoft.GESTIONCLINICA.WebApi.Core;
using Romsoft.GESTIONCLINICA.Common;
using System;
using System.Collections.Generic;
using System.Web.Http;
using Romsoft.GESTIONCLINICA.DTO.AutoMapper;
using System.Net;
using System.IO;
using System.Configuration;

namespace Romsoft.GESTIONCLINICA.WebApi.Controllers
{
    public class ADM_PACIENTECONSULTADNIController : BaseController
    {
        [HttpPost]
        public JsonResponse GetPacienteConsultaDNI(ADM_PACIENTE_CONSULTADTO consultaDNIDTO)
        {
            var jsonResponse = new JsonResponse { Success = true };

            try
            {
                var paciente = MapperHelper.Map<ADM_PACIENTE_CONSULTADTO, ADM_PACIENTE_CONSULTA>(consultaDNIDTO);
                //
                string dni = consultaDNIDTO.dni;

                string url= ConfigurationManager.AppSettings["UrlServicioConsultaDNI"];
                string token = ConfigurationManager.AppSettings["TokenConsultaDNI"];
                string urlFinal = url + "?" + "dni=" + dni + "&" + "token=" + token;

                string respuesta = httpGet(urlFinal);

                var respuestaDni = JsonConvert.DeserializeObject<ADM_PACIENTE_CONSULTADTO>(respuesta);

                //var pacienteDTOList = MapperHelper.Map<IEnumerable<ADM_PACIENTE_CONSULTADTO>, IEnumerable<ADM_PACIENTE_CONSULTA>>(respuesta);
                jsonResponse.Data = respuestaDni;
            }
            catch (Exception ex)
            {
                LogError(ex);
                jsonResponse.Success = false;
                jsonResponse.Message = Mensajes.IntenteloMasTarde;
            }

            return jsonResponse;
        }

        public static string httpGet(string url)
        {
            WebRequest oRequest = WebRequest.Create(url);
            WebResponse oResponse = oRequest.GetResponse();
            StreamReader sr = new StreamReader(oResponse.GetResponseStream());

            return sr.ReadToEnd().Trim();
        }
    }
}
