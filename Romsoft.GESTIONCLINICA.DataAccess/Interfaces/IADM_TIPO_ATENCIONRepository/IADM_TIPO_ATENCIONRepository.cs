using Romsoft.GESTIONCLINICA.DataAccess.Core;

namespace Romsoft.GESTIONCLINICA.DataAccess.Interfaces.IADM_TIPO_ATENCIONRepository
{

    public interface IADM_TIPO_ATENCIONRepository<T> : IRepository<T> where T : class
    {
        bool Exists(T entity);
    }
}
