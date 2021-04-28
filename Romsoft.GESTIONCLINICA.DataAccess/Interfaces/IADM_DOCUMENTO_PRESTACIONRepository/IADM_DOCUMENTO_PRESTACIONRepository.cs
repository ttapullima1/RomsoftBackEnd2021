using Romsoft.GESTIONCLINICA.DataAccess.Core;

namespace Romsoft.GESTIONCLINICA.DataAccess.Interfaces.IADM_DOCUMENTO_PRESTACIONRepository
{
 
    public interface IADM_DOCUMENTO_PRESTACIONRepository<T> : IRepository<T> where T : class
    {
        bool Exists(T entity);
    }
}
