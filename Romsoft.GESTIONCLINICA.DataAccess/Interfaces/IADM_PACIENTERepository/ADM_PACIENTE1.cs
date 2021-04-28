using Romsoft.GESTIONCLINICA.DataAccess.Core;


namespace Romsoft.GESTIONCLINICA.DataAccess.Interfaces.IADM_PACIENTERepository
{

    public interface ADM_PACIENTE1<T> : IRepository<T> where T : class
    {
        bool Exists(T entity);
    }
}
