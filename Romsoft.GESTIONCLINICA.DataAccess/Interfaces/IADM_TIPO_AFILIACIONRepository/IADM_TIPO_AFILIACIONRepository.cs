using Romsoft.GESTIONCLINICA.DataAccess.Core;


namespace Romsoft.GESTIONCLINICA.DataAccess.Interfaces.IADM_TIPO_AFILIACIONRepository
{

    public interface IADM_TIPO_AFILIACIONRepository<T> : IRepository<T> where T : class
    {
        bool Exists(T entity);
    }
}
