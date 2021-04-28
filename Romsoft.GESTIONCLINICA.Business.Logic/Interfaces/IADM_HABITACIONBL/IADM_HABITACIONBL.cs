using Romsoft.GESTIONCLINICA.Business.Logic.Core;
using System.Collections.Generic;


namespace Romsoft.GESTIONCLINICA.Business.Logic.Interfaces.IADM_HABITACIONBL
{

    public interface IADM_HABITACIONBL<T> : ILogic<T> where T : class
    {
        bool Exists(T entity);

    }
}
