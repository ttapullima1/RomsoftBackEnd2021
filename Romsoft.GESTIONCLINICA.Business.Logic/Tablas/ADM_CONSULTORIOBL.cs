using Romsoft.GESTIONCLINICA.Business.Logic.Interfaces.IADM_CONSULTORIOBL;
using Romsoft.GESTIONCLINICA.Common;
using Romsoft.GESTIONCLINICA.Common.Generics;
using Romsoft.GESTIONCLINICA.DataAccess.Tablas;
using Romsoft.GESTIONCLINICA.Entidades.ADM_CONSULTORIO;
using System;
using System.Collections.Generic;

namespace Romsoft.GESTIONCLINICA.Business.Logic.Tablas
{
    public class ADM_CONSULTORIOBL : Singleton<ADM_CONSULTORIOBL>, IADM_CONSULTORIOBL<ADM_CONSULTORIO>
    {
        public int Add(ADM_CONSULTORIO entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(ADM_CONSULTORIO entity)
        {
            throw new NotImplementedException();
        }

        public bool Exists(ADM_CONSULTORIO entity)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_CONSULTORIO> GetAll(string whereFilters)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_CONSULTORIO> GetAllActives()
        {
            return ADM_CONSULTORIORepository.Instancia.GetAllActives();
        }

        public IList<ADM_CONSULTORIO> GetAllFilters(ADM_CONSULTORIO entity)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_CONSULTORIO> GetAllPaging(PaginationParameter paginationParameters)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_CONSULTORIO> GetById(ADM_CONSULTORIO entity)
        {
            throw new NotImplementedException();
        }

        public int Update(ADM_CONSULTORIO entity)
        {
            throw new NotImplementedException();
        }
    }
}
