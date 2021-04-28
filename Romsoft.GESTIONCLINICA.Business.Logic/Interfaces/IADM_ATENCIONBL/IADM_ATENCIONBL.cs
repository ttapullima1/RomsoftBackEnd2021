using Romsoft.GESTIONCLINICA.Business.Logic.Core;
using System.Collections.Generic;
using Romsoft.GESTIONCLINICA.Entidades.ADM_ATENCION;

namespace Romsoft.GESTIONCLINICA.Business.Logic.Interfaces.IADM_ATENCIONBL
{
    public interface IADM_ATENCIONBL<T> : ILogic<T> where T : class
    {
        bool Exists(T entity);
        IList<T> GetAllPaciente(int idPaciente);
        IList<ADM_ATENCION_ResponseGetAllActives> GetAtencionAllFilters(int idPaciente);
    }
}
