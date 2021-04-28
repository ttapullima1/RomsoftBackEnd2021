using Romsoft.GESTIONCLINICA.Business.Logic.Interfaces.IADM_HABITACIONBL;
using Romsoft.GESTIONCLINICA.Common;
using Romsoft.GESTIONCLINICA.Common.Generics;
using Romsoft.GESTIONCLINICA.DataAccess.Tablas;
using Romsoft.GESTIONCLINICA.Entidades.ADM_HABITACION;
using System;
using System.Collections.Generic;

namespace Romsoft.GESTIONCLINICA.Business.Logic.Tablas
{
    public class ADM_HABITACIONBL : Singleton<ADM_HABITACIONBL>, IADM_HABITACIONBL<ADM_HABITACION>
    {
        public int Add(ADM_HABITACION entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(ADM_HABITACION entity)
        {
            throw new NotImplementedException();
        }

        public bool Exists(ADM_HABITACION entity)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_HABITACION> GetAll(string whereFilters)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_HABITACION> GetAllActives()
        {
            return ADM_HABITACIONRepository.Instancia.GetAllActives();
        }

        public IList<ADM_HABITACION> GetAllFilters(ADM_HABITACION entity)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_HABITACION> GetAllPaging(PaginationParameter paginationParameters)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_HABITACION> GetById(ADM_HABITACION entity)
        {
            throw new NotImplementedException();
        }

        public int Update(ADM_HABITACION entity)
        {
            throw new NotImplementedException();
        }
    }
}
