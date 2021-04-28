using Romsoft.GESTIONCLINICA.DataAccess.Core;
using System.Collections.Generic;

namespace Romsoft.GESTIONCLINICA.DataAccess.Interfaces.IPrueba
{

    public interface ICabecera_PruebaRepository<T> : IRepository<T>
       where T : class
    {
        bool Exists(T entity);
        //pasa Cabecera y Detalle
        int addDetalle(T entity);

    }
}
