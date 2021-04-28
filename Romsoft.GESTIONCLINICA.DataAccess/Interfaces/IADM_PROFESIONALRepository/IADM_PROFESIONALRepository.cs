using Romsoft.GESTIONCLINICA.DataAccess.Core;


namespace Romsoft.GESTIONCLINICA.DataAccess.Interfaces.IADM_PROFESIONALRepository
{

    public interface IADM_PROFESIONALRepository<T> : IRepository<T> where T : class
    {
        bool Exists(T entity);
    }
}
