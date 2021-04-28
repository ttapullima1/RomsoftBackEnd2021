using Romsoft.GESTIONCLINICA.Business.Logic.Interfaces.IADM_TIPO_AFILIACIONBL;
using Romsoft.GESTIONCLINICA.Common;
using Romsoft.GESTIONCLINICA.Common.Generics;
using Romsoft.GESTIONCLINICA.DataAccess.Tablas;
using Romsoft.GESTIONCLINICA.Entidades.ADM_TIPO_AFILIACION;
using System;
using System.Collections.Generic;

namespace Romsoft.GESTIONCLINICA.Business.Logic.Tablas
{
    public class ADM_TIPO_AFILIACIONBL : Singleton<ADM_TIPO_AFILIACIONBL>, IADM_TIPO_AFILIACIONBL<ADM_TIPO_AFILIACION>
    {
        public int Add(ADM_TIPO_AFILIACION entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(ADM_TIPO_AFILIACION entity)
        {
            throw new NotImplementedException();
        }

        public bool Exists(ADM_TIPO_AFILIACION entity)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_TIPO_AFILIACION> GetAll(string whereFilters)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_TIPO_AFILIACION> GetAllActives()
        {
            return ADM_TIPO_AFILIACIONRepository.Instancia.GetAllActives();
        }

        public IList<ADM_TIPO_AFILIACION> GetAllFilters(ADM_TIPO_AFILIACION entity)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_TIPO_AFILIACION> GetAllPaging(PaginationParameter paginationParameters)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_TIPO_AFILIACION> GetById(ADM_TIPO_AFILIACION entity)
        {
            throw new NotImplementedException();
        }

        public int Update(ADM_TIPO_AFILIACION entity)
        {
            throw new NotImplementedException();
        }
    }
}
