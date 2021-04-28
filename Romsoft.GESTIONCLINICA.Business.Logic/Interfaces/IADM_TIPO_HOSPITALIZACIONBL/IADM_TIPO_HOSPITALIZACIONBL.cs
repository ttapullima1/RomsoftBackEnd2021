using Romsoft.GESTIONCLINICA.Business.Logic.Core;
using System.Collections.Generic;

namespace Romsoft.GESTIONCLINICA.Business.Logic.Interfaces.IADM_TIPO_HOSPITALIZACIONBL
{

    public interface IADM_TIPO_HOSPITALIZACIONBL<T> : ILogic<T> where T : class
    {
        bool Exists(T entity);

    }
}
