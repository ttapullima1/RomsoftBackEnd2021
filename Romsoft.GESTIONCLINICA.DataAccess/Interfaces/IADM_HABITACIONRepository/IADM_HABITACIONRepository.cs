using Romsoft.GESTIONCLINICA.DataAccess.Core;


namespace Romsoft.GESTIONCLINICA.DataAccess.Interfaces.IADM_HABITACIONRepository
{
    public interface IADM_HABITACIONRepository<T> : IRepository<T> where T : class
    {
        bool Exists(T entity);
    }
}
