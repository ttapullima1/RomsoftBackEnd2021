using Romsoft.GESTIONCLINICA.Business.Logic.Interfaces.IADM_TIPO_FILIACIONBL;
using Romsoft.GESTIONCLINICA.Common;
using Romsoft.GESTIONCLINICA.Common.Generics;
using Romsoft.GESTIONCLINICA.DataAccess.Tablas;
using Romsoft.GESTIONCLINICA.Entidades.ADM_TIPO_FILIACION;
using System;
using System.Collections.Generic;

namespace Romsoft.GESTIONCLINICA.Business.Logic.Tablas
{
    public class ADM_TIPO_FILIACIONBL : Singleton<ADM_TIPO_FILIACIONBL>, IADM_TIPO_FILIACIONBL<ADM_TIPO_FILIACION>
    {
        public int Add(ADM_TIPO_FILIACION entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(ADM_TIPO_FILIACION entity)
        {
            throw new NotImplementedException();
        }

        public bool Exists(ADM_TIPO_FILIACION entity)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_TIPO_FILIACION> GetAll(string whereFilters)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_TIPO_FILIACION> GetAllActives()
        {
            return ADM_TIPO_FILIACIONRepository.Instancia.GetAllActives();
        }

        public IList<ADM_TIPO_FILIACION> GetAllFilters(ADM_TIPO_FILIACION entity)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_TIPO_FILIACION> GetAllPaging(PaginationParameter paginationParameters)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_TIPO_FILIACION> GetById(ADM_TIPO_FILIACION entity)
        {
            throw new NotImplementedException();
        }

        public int Update(ADM_TIPO_FILIACION entity)
        {
            throw new NotImplementedException();
        }
    }
}
