using Romsoft.GESTIONCLINICA.Business.Logic.Interfaces.IADM_ESPECIALIDADBL;
using Romsoft.GESTIONCLINICA.Common;
using Romsoft.GESTIONCLINICA.Common.Generics;
using Romsoft.GESTIONCLINICA.DataAccess.Tablas;
using Romsoft.GESTIONCLINICA.Entidades.ADM_ESPECIALIDAD;
using System;
using System.Collections.Generic;

namespace Romsoft.GESTIONCLINICA.Business.Logic.Tablas
{
    public class ADM_ESPECIALIDADBL : Singleton<ADM_ESPECIALIDADBL>, IADM_ESPECIALIDADBL<ADM_ESPECIALIDAD>
    {
        public int Add(ADM_ESPECIALIDAD entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(ADM_ESPECIALIDAD entity)
        {
            throw new NotImplementedException();
        }

        public bool Exists(ADM_ESPECIALIDAD entity)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_ESPECIALIDAD> GetAll(string whereFilters)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_ESPECIALIDAD> GetAllActives()
        {
            return ADM_ESPECIALIDADRepository.Instancia.GetAllActives();
        }

        public IList<ADM_ESPECIALIDAD> GetAllFilters(ADM_ESPECIALIDAD entity)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_ESPECIALIDAD> GetAllPaging(PaginationParameter paginationParameters)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_ESPECIALIDAD> GetById(ADM_ESPECIALIDAD entity)
        {
            throw new NotImplementedException();
        }

        public int Update(ADM_ESPECIALIDAD entity)
        {
            throw new NotImplementedException();
        }
    }
}
