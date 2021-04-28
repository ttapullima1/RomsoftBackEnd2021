using Romsoft.GESTIONCLINICA.Business.Logic.Interfaces.IADM_DOCUMENTO_PRESTACIONBL;
using Romsoft.GESTIONCLINICA.Common;
using Romsoft.GESTIONCLINICA.Common.Generics;
using Romsoft.GESTIONCLINICA.DataAccess.Tablas;
using Romsoft.GESTIONCLINICA.Entidades.ADM_DOCUMENTO_PRESTACION;
using System;
using System.Collections.Generic;

namespace Romsoft.GESTIONCLINICA.Business.Logic.Tablas
{
    public class ADM_DOCUMENTO_PRESTACIONBL : Singleton<ADM_DOCUMENTO_PRESTACIONBL>, IADM_DOCUMENTO_PRESTACIONBL<ADM_DOCUMENTO_PRESTACION>
    {
        public int Add(ADM_DOCUMENTO_PRESTACION entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(ADM_DOCUMENTO_PRESTACION entity)
        {
            throw new NotImplementedException();
        }

        public bool Exists(ADM_DOCUMENTO_PRESTACION entity)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_DOCUMENTO_PRESTACION> GetAll(string whereFilters)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_DOCUMENTO_PRESTACION> GetAllActives()
        {
            return ADM_DOCUMENTO_PRESTACIONRepository.Instancia.GetAllActives();
        }

        public IList<ADM_DOCUMENTO_PRESTACION> GetAllFilters(ADM_DOCUMENTO_PRESTACION entity)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_DOCUMENTO_PRESTACION> GetAllPaging(PaginationParameter paginationParameters)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_DOCUMENTO_PRESTACION> GetById(ADM_DOCUMENTO_PRESTACION entity)
        {
            throw new NotImplementedException();
        }

        public int Update(ADM_DOCUMENTO_PRESTACION entity)
        {
            throw new NotImplementedException();
        }
    }
}
