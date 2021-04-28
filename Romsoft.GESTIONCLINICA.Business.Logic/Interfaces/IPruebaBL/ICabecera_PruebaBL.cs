using System;
using Romsoft.GESTIONCLINICA.Business.Logic.Core;
using System.Collections.Generic;

namespace Romsoft.GESTIONCLINICA.Business.Logic.Interfaces.IPruebaBL
{

    public interface ICabecera_PruebaBL<T> : ILogic<T> where T : class
    {
        bool Exists(string id);
        //pasa Cabecera y Detalle
        int addDetalle(T entity);
    }
}
