using Romsoft.GESTIONCLINICA.Business.Logic.Core;
using System.Collections.Generic;

namespace Romsoft.GESTIONCLINICA.Business.Logic.Interfaces.IADM_DOCUMENTO_PRESTACIONBL
{

    public interface IADM_DOCUMENTO_PRESTACIONBL<T> : ILogic<T> where T : class
    {
        bool Exists(T entity);

    }
}
