using Romsoft.GESTIONCLINICA.Business.Logic.Interfaces.IPruebaBL;
using Romsoft.GESTIONCLINICA.Common;
using Romsoft.GESTIONCLINICA.Common.Generics;
using Romsoft.GESTIONCLINICA.DataAccess.Tablas;
using Romsoft.GESTIONCLINICA.Entidades.Prueba;
using System;
using System.Collections.Generic;

namespace Romsoft.GESTIONCLINICA.Business.Logic.Tablas
{
    public class PruebaBL : Singleton<PruebaBL>, ICabecera_PruebaBL<Cabecera_Prueba>
    {
        public int Add(Cabecera_Prueba entity)
        {
            throw new NotImplementedException();
        }

        public int addDetalle(Cabecera_Prueba entity)
        {
            return Cabecera_PruebaRepository.Instancia.addDetalle(entity);
        }

        public int Delete(Cabecera_Prueba entity)
        {
            throw new NotImplementedException();
        }

        public bool Exists(string id)
        {
            //throw new NotImplementedException();
            return false;
        }

        public IList<Cabecera_Prueba> GetAll(string whereFilters)
        {
            throw new NotImplementedException();
        }

        public IList<Cabecera_Prueba> GetAllActives()
        {
            throw new NotImplementedException();
        }

        public IList<Cabecera_Prueba> GetAllFilters(Cabecera_Prueba entity)
        {
            throw new NotImplementedException();
        }

        public IList<Cabecera_Prueba> GetAllPaging(PaginationParameter paginationParameters)
        {
            throw new NotImplementedException();
        }

        public IList<Cabecera_Prueba> GetById(Cabecera_Prueba entity)
        {
            throw new NotImplementedException();
        }

        public int Update(Cabecera_Prueba entity)
        {
            throw new NotImplementedException();
        }
    }
}
