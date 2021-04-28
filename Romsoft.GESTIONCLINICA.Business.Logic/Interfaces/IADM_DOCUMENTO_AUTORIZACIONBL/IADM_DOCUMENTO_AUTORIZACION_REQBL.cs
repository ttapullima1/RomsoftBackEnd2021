using Romsoft.GESTIONCLINICA.Business.Logic.Core;
using System.Collections.Generic;
using Romsoft.GESTIONCLINICA.Entidades.ADM_DOCUMENTO_AUTORIZACION;

namespace Romsoft.GESTIONCLINICA.Business.Logic.Interfaces.IADM_DOCUMENTO_AUTORIZACIONBL
{


    public interface IADM_DOCUMENTO_AUTORIZACION_REQBL<T> : ILogic<T> where T : class
    {
        bool Exists(T entity);
        IList<ADM_DOCUMENTO_AUTORIZACION_RES> GetAddAtencionAll(T entity);
    }
}
