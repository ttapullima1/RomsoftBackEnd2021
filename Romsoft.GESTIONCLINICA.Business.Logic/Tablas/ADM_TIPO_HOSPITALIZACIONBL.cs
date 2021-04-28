using Romsoft.GESTIONCLINICA.Business.Logic.Interfaces.IADM_TIPO_HOSPITALIZACIONBL;
using Romsoft.GESTIONCLINICA.Common;
using Romsoft.GESTIONCLINICA.Common.Generics;
using Romsoft.GESTIONCLINICA.DataAccess.Tablas;
using Romsoft.GESTIONCLINICA.Entidades.ADM_TIPO_HOSPITALIZACION;
using System;
using System.Collections.Generic;

namespace Romsoft.GESTIONCLINICA.Business.Logic.Tablas
{
    public class ADM_TIPO_HOSPITALIZACIONBL : Singleton<ADM_TIPO_HOSPITALIZACIONBL>, IADM_TIPO_HOSPITALIZACIONBL<ADM_TIPO_HOSPITALIZACION>
    {
        public int Add(ADM_TIPO_HOSPITALIZACION entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(ADM_TIPO_HOSPITALIZACION entity)
        {
            throw new NotImplementedException();
        }

        public bool Exists(ADM_TIPO_HOSPITALIZACION entity)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_TIPO_HOSPITALIZACION> GetAll(string whereFilters)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_TIPO_HOSPITALIZACION> GetAllActives()
        {
            return ADM_TIPO_HOSPITALIZACIONRepository.Instancia.GetAllActives();
        }

        public IList<ADM_TIPO_HOSPITALIZACION> GetAllFilters(ADM_TIPO_HOSPITALIZACION entity)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_TIPO_HOSPITALIZACION> GetAllPaging(PaginationParameter paginationParameters)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_TIPO_HOSPITALIZACION> GetById(ADM_TIPO_HOSPITALIZACION entity)
        {
            throw new NotImplementedException();
        }

        public int Update(ADM_TIPO_HOSPITALIZACION entity)
        {
            throw new NotImplementedException();
        }
    }
}
