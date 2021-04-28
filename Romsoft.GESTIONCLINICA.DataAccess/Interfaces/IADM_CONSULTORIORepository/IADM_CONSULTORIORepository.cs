using Romsoft.GESTIONCLINICA.DataAccess.Core;

namespace Romsoft.GESTIONCLINICA.DataAccess.Interfaces.IADM_CONSULTORIORepository
{

    public interface IADM_CONSULTORIORepository<T> : IRepository<T> where T : class
    {
        bool Exists(T entity);
    }
}
