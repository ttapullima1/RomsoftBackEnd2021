using Romsoft.GESTIONCLINICA.DataAccess.Core;

namespace Romsoft.GESTIONCLINICA.DataAccess.Interfaces.IADM_TIPO_PACIENTERepository
{

    public interface IADM_TIPO_PACIENTEDTORepository<T> : IRepository<T> where T : class
    {
        bool Exists(T entity);
    }
}
