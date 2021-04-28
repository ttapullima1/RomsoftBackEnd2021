using Microsoft.Practices.EnterpriseLibrary.Data;
using Romsoft.GESTIONCLINICA.Common;
using Romsoft.GESTIONCLINICA.Common.Generics;
using Romsoft.GESTIONCLINICA.DataAccess.Core;
using Romsoft.GESTIONCLINICA.DataAccess.Interfaces.IADM_TIPO_HOSPITALIZACIONRepository;
using Romsoft.GESTIONCLINICA.Entidades.ADM_TIPO_HOSPITALIZACION;
using System;
using System.Collections.Generic;
using System.Data;

namespace Romsoft.GESTIONCLINICA.DataAccess.Tablas
{
    public class ADM_TIPO_HOSPITALIZACIONRepository : Singleton<ADM_TIPO_HOSPITALIZACIONRepository>, IADM_TIPO_HOSPITALIZACIONRepository<ADM_TIPO_HOSPITALIZACION>
    {
        #region Attributos
        private readonly Database _database = new DatabaseProviderFactory().Create(ConectionStringRepository.ConnectionStringNameSQL);
        #endregion

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
            List<ADM_TIPO_HOSPITALIZACION> tipoH = new List<ADM_TIPO_HOSPITALIZACION>();
            using (var comando = _database.GetStoredProcCommand(string.Format("{0}{1}", ConectionStringRepository.EsquemaName, "p_ADM_TIPO_HOSPITALIZACION_GetAllActives")))
            {
                //_database.AddInParameter(comando, "@tabla", DbType.String, entity.tabla);
                using (var lector = _database.ExecuteReader(comando))
                {
                    while (lector.Read())
                    {
                        tipoH.Add(new ADM_TIPO_HOSPITALIZACION
                        {
                            id_tipo_hospitalizacion = lector.IsDBNull(lector.GetOrdinal("id_tipo_hospitalizacion")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_tipo_hospitalizacion")),
                            t_descripcion = lector.IsDBNull(lector.GetOrdinal("t_descripcion")) ? default(string) : lector.GetString(lector.GetOrdinal("t_descripcion")),
                        });
                    }
                }
            }

            return tipoH;
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
