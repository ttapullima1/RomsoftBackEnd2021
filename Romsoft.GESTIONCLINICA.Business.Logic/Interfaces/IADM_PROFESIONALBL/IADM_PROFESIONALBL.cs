using Romsoft.GESTIONCLINICA.Business.Logic.Core;
using System.Collections.Generic;

namespace Romsoft.GESTIONCLINICA.Business.Logic.Interfaces.IADM_PROFESIONALBL
{

    public interface IADM_PROFESIONALBL<T> : ILogic<T> where T : class
    {
        bool Exists(T entity);

    }
}
