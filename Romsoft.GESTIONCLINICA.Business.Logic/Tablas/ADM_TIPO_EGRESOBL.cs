using Romsoft.GESTIONCLINICA.Business.Logic.Interfaces.IADM_TIPO_EGRESOBL;
using Romsoft.GESTIONCLINICA.Common;
using Romsoft.GESTIONCLINICA.Common.Generics;
using Romsoft.GESTIONCLINICA.DataAccess.Tablas;
using Romsoft.GESTIONCLINICA.Entidades.ADM_TIPO_EGRESO;
using System;
using System.Collections.Generic;

namespace Romsoft.GESTIONCLINICA.Business.Logic.Tablas
{
    public class ADM_TIPO_EGRESOBL : Singleton<ADM_TIPO_EGRESOBL>, IADM_TIPO_EGRESOBL<ADM_TIPO_EGRESO>
    {
        public int Add(ADM_TIPO_EGRESO entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(ADM_TIPO_EGRESO entity)
        {
            throw new NotImplementedException();
        }

        public bool Exists(ADM_TIPO_EGRESO entity)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_TIPO_EGRESO> GetAll(string whereFilters)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_TIPO_EGRESO> GetAllActives()
        {
            return ADM_TIPO_EGRESORepository.Instancia.GetAllActives();
        }

        public IList<ADM_TIPO_EGRESO> GetAllFilters(ADM_TIPO_EGRESO entity)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_TIPO_EGRESO> GetAllPaging(PaginationParameter paginationParameters)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_TIPO_EGRESO> GetById(ADM_TIPO_EGRESO entity)
        {
            throw new NotImplementedException();
        }

        public int Update(ADM_TIPO_EGRESO entity)
        {
            throw new NotImplementedException();
        }
    }
}
