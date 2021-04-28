using Romsoft.GESTIONCLINICA.Business.Logic.Interfaces.IADM_TIPO_ATENCIONBL;
using Romsoft.GESTIONCLINICA.Common;
using Romsoft.GESTIONCLINICA.Common.Generics;
using Romsoft.GESTIONCLINICA.DataAccess.Tablas;
using Romsoft.GESTIONCLINICA.Entidades.ADM_TIPO_ATENCION;
using System;
using System.Collections.Generic;

namespace Romsoft.GESTIONCLINICA.Business.Logic.Tablas
{
    public class ADM_TIPO_ATENCIONBL : Singleton<ADM_TIPO_ATENCIONBL>, IADM_TIPO_ATENCIONBL<ADM_TIPO_ATENCION>
    {
        public int Add(ADM_TIPO_ATENCION entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(ADM_TIPO_ATENCION entity)
        {
            throw new NotImplementedException();
        }

        public bool Exists(ADM_TIPO_ATENCION entity)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_TIPO_ATENCION> GetAll(string whereFilters)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_TIPO_ATENCION> GetAllActives()
        {
            return ADM_TIPO_ATENCIONRepository.Instancia.GetAllActives();
        }

        public IList<ADM_TIPO_ATENCION> GetAllFilters(ADM_TIPO_ATENCION entity)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_TIPO_ATENCION> GetAllPaging(PaginationParameter paginationParameters)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_TIPO_ATENCION> GetById(ADM_TIPO_ATENCION entity)
        {
            throw new NotImplementedException();
        }

        public int Update(ADM_TIPO_ATENCION entity)
        {
            throw new NotImplementedException();
        }
    }
}
