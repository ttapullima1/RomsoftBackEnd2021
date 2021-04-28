using Microsoft.Practices.EnterpriseLibrary.Data;
using Romsoft.GESTIONCLINICA.Common;
using Romsoft.GESTIONCLINICA.Common.Generics;
using Romsoft.GESTIONCLINICA.DataAccess.Core;
using Romsoft.GESTIONCLINICA.DataAccess.Interfaces.IADM_TIPO_EGRESORepository;
using Romsoft.GESTIONCLINICA.Entidades.ADM_TIPO_EGRESO;
using System;
using System.Collections.Generic;
using System.Data;

namespace Romsoft.GESTIONCLINICA.DataAccess.Tablas
{
    public class ADM_TIPO_EGRESORepository : Singleton<ADM_TIPO_EGRESORepository>, IADM_TIPO_EGRESORepository<ADM_TIPO_EGRESO>
    {
        #region Attributos
        private readonly Database _database = new DatabaseProviderFactory().Create(ConectionStringRepository.ConnectionStringNameSQL);
        #endregion
        public int Add(ADM_TIPO_EGRESO entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(ADM_TIPO_EGRESO entity)
        {
            throw new NotImplementedException();
        }

        public bool Exists(ADM_TIPO_EGRESO entity)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_TIPO_EGRESO> GetAll(string whereFilters)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_TIPO_EGRESO> GetAllActives()
        {
            List<ADM_TIPO_EGRESO> tipoegreso = new List<ADM_TIPO_EGRESO>();
            using (var comando = _database.GetStoredProcCommand(string.Format("{0}{1}", ConectionStringRepository.EsquemaName, "p_ADM_TIPO_EGRESO_GetAllActives")))
            {
                //_database.AddInParameter(comando, "@tabla", DbType.String, entity.tabla);
                using (var lector = _database.ExecuteReader(comando))
                {
                    while (lector.Read())
                    {
                        tipoegreso.Add(new ADM_TIPO_EGRESO
                        {
                            id_tipo_egreso = lector.IsDBNull(lector.GetOrdinal("id_tipo_egreso")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_tipo_egreso")),
                            t_descripcion = lector.IsDBNull(lector.GetOrdinal("t_descripcion")) ? default(string) : lector.GetString(lector.GetOrdinal("t_descripcion")),
                        });
                    }
                }
            }

            return tipoegreso;
        }

        public IList<ADM_TIPO_EGRESO> GetAllFilters(ADM_TIPO_EGRESO entity)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_TIPO_EGRESO> GetAllPaging(PaginationParameter paginationParameters)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_TIPO_EGRESO> GetById(ADM_TIPO_EGRESO entity)
        {
            throw new NotImplementedException();
        }

        public int Update(ADM_TIPO_EGRESO entity)
        {
            throw new NotImplementedException();
        }
    }
}
