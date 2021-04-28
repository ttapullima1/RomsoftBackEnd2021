using Romsoft.GESTIONCLINICA.DataAccess.Core;


namespace Romsoft.GESTIONCLINICA.DataAccess.Interfaces.IADM_ESPECIALIDADRepository
{

    public interface IADM_ESPECIALIDADRepository<T> : IRepository<T> where T : class
    {
        bool Exists(T entity);
    }
}
