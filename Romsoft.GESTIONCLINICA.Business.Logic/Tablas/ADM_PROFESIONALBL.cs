using Romsoft.GESTIONCLINICA.Business.Logic.Interfaces.IADM_PROFESIONALBL;
using Romsoft.GESTIONCLINICA.Common;
using Romsoft.GESTIONCLINICA.Common.Generics;
using Romsoft.GESTIONCLINICA.DataAccess.Tablas;
using Romsoft.GESTIONCLINICA.Entidades.ADM_PROFESIONAL;
using System;
using System.Collections.Generic;

namespace Romsoft.GESTIONCLINICA.Business.Logic.Tablas
{
    public class ADM_PROFESIONALBL : Singleton<ADM_PROFESIONALBL>, IADM_PROFESIONALBL<ADM_PROFESIONAL>
    {
        public int Add(ADM_PROFESIONAL entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(ADM_PROFESIONAL entity)
        {
            throw new NotImplementedException();
        }

        public bool Exists(ADM_PROFESIONAL entity)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_PROFESIONAL> GetAll(string whereFilters)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_PROFESIONAL> GetAllActives()
        {
            return ADM_PROFESIONALRepository.Instancia.GetAllActives();
        }

        public IList<ADM_PROFESIONAL> GetAllFilters(ADM_PROFESIONAL entity)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_PROFESIONAL> GetAllPaging(PaginationParameter paginationParameters)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_PROFESIONAL> GetById(ADM_PROFESIONAL entity)
        {
            throw new NotImplementedException();
        }

        public int Update(ADM_PROFESIONAL entity)
        {
            throw new NotImplementedException();
        }
    }
}
