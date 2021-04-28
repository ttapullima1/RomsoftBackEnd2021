using Romsoft.GESTIONCLINICA.Business.Logic.Core;
using System.Collections.Generic;


namespace Romsoft.GESTIONCLINICA.Business.Logic.Interfaces.IADM_TIPO_EGRESOBL
{

    public interface IADM_TIPO_EGRESOBL<T> : ILogic<T> where T : class
    {
        bool Exists(T entity);

    }
}
