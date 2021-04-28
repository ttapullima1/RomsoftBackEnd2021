using Romsoft.GESTIONCLINICA.Business.Logic.Interfaces.IADM_DOCUMENTO_AUTORIZACIONBL;
using Romsoft.GESTIONCLINICA.Common;
using Romsoft.GESTIONCLINICA.Common.Generics;
using Romsoft.GESTIONCLINICA.DataAccess.Tablas;
using Romsoft.GESTIONCLINICA.Entidades.ADM_DOCUMENTO_AUTORIZACION;
using System;
using System.Collections.Generic;

namespace Romsoft.GESTIONCLINICA.Business.Logic.Tablas
{
    public class ADM_DOCUMENTO_AUTORIZACION_REQBL : Singleton<ADM_DOCUMENTO_AUTORIZACION_REQBL>, IADM_DOCUMENTO_AUTORIZACION_REQBL<ADM_DOCUMENTO_AUTORIZACION_REQ>
    {
        public int Add(ADM_DOCUMENTO_AUTORIZACION_REQ entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(ADM_DOCUMENTO_AUTORIZACION_REQ entity)
        {
            throw new NotImplementedException();
        }

        public bool Exists(ADM_DOCUMENTO_AUTORIZACION_REQ entity)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_DOCUMENTO_AUTORIZACION_RES> GetAddAtencionAll(ADM_DOCUMENTO_AUTORIZACION_REQ entity)
        {
            return ADM_DOCUMENTO_AUTORIZACIONREQRepository.Instancia.GetAddAtencionAll(entity);
            
        }

        public IList<ADM_DOCUMENTO_AUTORIZACION_REQ> GetAll(string whereFilters)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_DOCUMENTO_AUTORIZACION_REQ> GetAllActives()
        {
            throw new NotImplementedException();
        }

        public IList<ADM_DOCUMENTO_AUTORIZACION_REQ> GetAllFilters(ADM_DOCUMENTO_AUTORIZACION_REQ entity)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_DOCUMENTO_AUTORIZACION_REQ> GetAllPaging(PaginationParameter paginationParameters)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_DOCUMENTO_AUTORIZACION_REQ> GetById(ADM_DOCUMENTO_AUTORIZACION_REQ entity)
        {
            throw new NotImplementedException();
        }

        public int Update(ADM_DOCUMENTO_AUTORIZACION_REQ entity)
        {
            throw new NotImplementedException();
        }
    }
}
