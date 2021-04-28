using Romsoft.GESTIONCLINICA.DataAccess.Core;


namespace Romsoft.GESTIONCLINICA.DataAccess.Interfaces.IADM_TIPO_HOSPITALIZACIONRepository
{
    public interface IADM_TIPO_HOSPITALIZACIONRepository<T> : IRepository<T> where T : class
    {
        bool Exists(T entity);
    }
}
