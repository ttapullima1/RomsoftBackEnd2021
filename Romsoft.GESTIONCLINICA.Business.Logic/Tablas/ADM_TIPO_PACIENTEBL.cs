using Romsoft.GESTIONCLINICA.Business.Logic.Interfaces.IADM_TIPO_PACIENTEBL;
using Romsoft.GESTIONCLINICA.Common;
using Romsoft.GESTIONCLINICA.Common.Generics;
using Romsoft.GESTIONCLINICA.DataAccess.Tablas;
using Romsoft.GESTIONCLINICA.Entidades.ADM_TIPO_PACIENTE;
using System;
using System.Collections.Generic;

namespace Romsoft.GESTIONCLINICA.Business.Logic.Tablas
{
    public class ADM_TIPO_PACIENTEBL : Singleton<ADM_TIPO_PACIENTEBL>, IADM_TIPO_PACIENTEBL<ADM_TIPO_PACIENTE>
    {
        public int Add(ADM_TIPO_PACIENTE entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(ADM_TIPO_PACIENTE entity)
        {
            throw new NotImplementedException();
        }

        public bool Exists(ADM_TIPO_PACIENTE entity)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_TIPO_PACIENTE> GetAll(string whereFilters)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_TIPO_PACIENTE> GetAllActives()
        {
            return ADM_TIPO_PACIENTERepository.Instancia.GetAllActives();
        }

        public IList<ADM_TIPO_PACIENTE> GetAllFilters(ADM_TIPO_PACIENTE entity)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_TIPO_PACIENTE> GetAllPaging(PaginationParameter paginationParameters)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_TIPO_PACIENTE> GetById(ADM_TIPO_PACIENTE entity)
        {
            throw new NotImplementedException();
        }

        public int Update(ADM_TIPO_PACIENTE entity)
        {
            throw new NotImplementedException();
        }
    }
}
