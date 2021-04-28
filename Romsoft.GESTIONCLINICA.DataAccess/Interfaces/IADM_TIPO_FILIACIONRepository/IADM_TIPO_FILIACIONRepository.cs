using Romsoft.GESTIONCLINICA.DataAccess.Core;


namespace Romsoft.GESTIONCLINICA.DataAccess.Interfaces.IADM_TIPO_FILIACIONRepository
{
    public interface IADM_TIPO_FILIACIONRepository<T> : IRepository<T> where T : class
    {
        bool Exists(T entity);
    }
}
