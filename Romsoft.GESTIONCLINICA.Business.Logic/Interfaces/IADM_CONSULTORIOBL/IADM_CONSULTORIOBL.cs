using Romsoft.GESTIONCLINICA.Business.Logic.Core;
using System.Collections.Generic;

namespace Romsoft.GESTIONCLINICA.Business.Logic.Interfaces.IADM_CONSULTORIOBL
{
 
    public interface IADM_CONSULTORIOBL<T> : ILogic<T> where T : class
    {
        bool Exists(T entity);

    }
}
