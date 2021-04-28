using Romsoft.GESTIONCLINICA.Business.Logic.Core;
using System.Collections.Generic;

namespace Romsoft.GESTIONCLINICA.Business.Logic.Interfaces.IADM_TIPO_PACIENTEBL
{
    public interface IADM_TIPO_PACIENTEBL<T> : ILogic<T> where T : class
    {
        bool Exists(T entity);

    }
}
