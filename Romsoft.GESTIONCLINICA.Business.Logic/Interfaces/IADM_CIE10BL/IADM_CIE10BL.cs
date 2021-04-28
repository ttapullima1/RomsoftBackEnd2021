﻿using Romsoft.GESTIONCLINICA.Business.Logic.Core;
using System.Collections.Generic;

namespace Romsoft.GESTIONCLINICA.Business.Logic.Interfaces.IADM_CIE10BL
{

    public interface IADM_CIE10BL<T> : ILogic<T> where T : class
    {
        bool Exists(T entity);

    }
}
