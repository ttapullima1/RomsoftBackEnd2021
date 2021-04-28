using Romsoft.GESTIONCLINICA.Business.Logic.Interfaces.IADM_TIPO_CIE10BL;
using Romsoft.GESTIONCLINICA.Common;
using Romsoft.GESTIONCLINICA.Common.Generics;
using Romsoft.GESTIONCLINICA.DataAccess.Tablas;
using Romsoft.GESTIONCLINICA.Entidades.ADM_TIPO_CIE10;
using System;
using System.Collections.Generic;

namespace Romsoft.GESTIONCLINICA.Business.Logic.Tablas
{
    public class ADM_TIPO_CIE10BL : Singleton<ADM_TIPO_CIE10BL>, IADM_TIPO_CIE10BL<ADM_TIPO_CIE10>
    {
        public int Add(ADM_TIPO_CIE10 entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(ADM_TIPO_CIE10 entity)
        {
            throw new NotImplementedException();
        }

        public bool Exists(ADM_TIPO_CIE10 entity)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_TIPO_CIE10> GetAll(string whereFilters)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_TIPO_CIE10> GetAllActives()
        {
            return ADM_TIPO_CIE10Repository.Instancia.GetAllActives();
        }

        public IList<ADM_TIPO_CIE10> GetAllFilters(ADM_TIPO_CIE10 entity)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_TIPO_CIE10> GetAllPaging(PaginationParameter paginationParameters)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_TIPO_CIE10> GetById(ADM_TIPO_CIE10 entity)
        {
            throw new NotImplementedException();
        }

        public int Update(ADM_TIPO_CIE10 entity)
        {
            throw new NotImplementedException();
        }
    }
}
