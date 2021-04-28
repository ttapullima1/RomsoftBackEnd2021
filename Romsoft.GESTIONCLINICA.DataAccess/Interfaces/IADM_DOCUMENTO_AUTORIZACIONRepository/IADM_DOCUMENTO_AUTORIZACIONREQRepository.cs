using Romsoft.GESTIONCLINICA.DataAccess.Core;
using System.Collections.Generic;
using Romsoft.GESTIONCLINICA.Entidades.ADM_DOCUMENTO_AUTORIZACION;

namespace Romsoft.GESTIONCLINICA.DataAccess.Interfaces.IADM_DOCUMENTO_AUTORIZACIONRepository
{
    public interface IADM_DOCUMENTO_AUTORIZACIONREQRepository<T> : IRepository<T>
    where T : class
    {
        bool Exists(T entity);

        //IList<ADM_ATENCION_ResponseGetAllActives> GetAtencionAllFilters(int idPaciente);
        IList<ADM_DOCUMENTO_AUTORIZACION_RES> GetAddAtencionAll(T entity);

    }
}
