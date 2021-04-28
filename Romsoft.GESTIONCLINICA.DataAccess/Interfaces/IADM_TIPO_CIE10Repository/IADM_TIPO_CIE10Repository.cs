using Romsoft.GESTIONCLINICA.DataAccess.Core;

namespace Romsoft.GESTIONCLINICA.DataAccess.Interfaces.IADM_TIPO_CIE10Repository
{
    public interface IADM_TIPO_CIE10Repository<T> : IRepository<T> where T : class
    {
        bool Exists(T entity);
    }
}
