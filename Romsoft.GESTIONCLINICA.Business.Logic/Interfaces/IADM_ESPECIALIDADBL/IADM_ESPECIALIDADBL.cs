using Romsoft.GESTIONCLINICA.Business.Logic.Core;
using System.Collections.Generic;

namespace Romsoft.GESTIONCLINICA.Business.Logic.Interfaces.IADM_ESPECIALIDADBL
{
    public interface IADM_ESPECIALIDADBL<T> : ILogic<T> where T : class
    {
        bool Exists(T entity);

    }
}
