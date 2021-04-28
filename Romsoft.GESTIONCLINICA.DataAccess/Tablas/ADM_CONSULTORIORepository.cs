using Microsoft.Practices.EnterpriseLibrary.Data;
using Romsoft.GESTIONCLINICA.Common;
using Romsoft.GESTIONCLINICA.Common.Generics;
using Romsoft.GESTIONCLINICA.DataAccess.Core;
using Romsoft.GESTIONCLINICA.DataAccess.Interfaces.IADM_CONSULTORIORepository;
using Romsoft.GESTIONCLINICA.Entidades.ADM_CONSULTORIO;
using System;
using System.Collections.Generic;
using System.Data;

namespace Romsoft.GESTIONCLINICA.DataAccess.Tablas
{
    public class ADM_CONSULTORIORepository : Singleton<ADM_CONSULTORIORepository>, IADM_CONSULTORIORepository<ADM_CONSULTORIO>
    {
        #region Attributos
        private readonly Database _database = new DatabaseProviderFactory().Create(ConectionStringRepository.ConnectionStringNameSQL);
        #endregion

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
            List<ADM_CONSULTORIO> consultorio = new List<ADM_CONSULTORIO>();
            using (var comando = _database.GetStoredProcCommand(string.Format("{0}{1}", ConectionStringRepository.EsquemaName, "p_ADM_CONSULTORIO_GetAllActives")))
            {
                //_database.AddInParameter(comando, "@tabla", DbType.String, entity.tabla);
                using (var lector = _database.ExecuteReader(comando))
                {
                    while (lector.Read())
                    {
                        consultorio.Add(new ADM_CONSULTORIO
                        {
                            id_consultorio = lector.IsDBNull(lector.GetOrdinal("id_consultorio")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_consultorio")),
                            t_descripcion = lector.IsDBNull(lector.GetOrdinal("t_descripcion")) ? default(string) : lector.GetString(lector.GetOrdinal("t_descripcion")),
                        });
                    }
                }
            }

            return consultorio;
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
