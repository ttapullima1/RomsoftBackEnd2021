using Microsoft.Practices.EnterpriseLibrary.Data;
using Romsoft.GESTIONCLINICA.Common;
using Romsoft.GESTIONCLINICA.Common.Generics;
using Romsoft.GESTIONCLINICA.DataAccess.Core;
using Romsoft.GESTIONCLINICA.DataAccess.Interfaces.IADM_TIPO_FILIACIONRepository;
using Romsoft.GESTIONCLINICA.Entidades.ADM_TIPO_FILIACION;
using System;
using System.Collections.Generic;
using System.Data;

namespace Romsoft.GESTIONCLINICA.DataAccess.Tablas
{
    public class ADM_TIPO_FILIACIONRepository : Singleton<ADM_TIPO_FILIACIONRepository>, IADM_TIPO_FILIACIONRepository<ADM_TIPO_FILIACION>
    {
        #region Attributos
        private readonly Database _database = new DatabaseProviderFactory().Create(ConectionStringRepository.ConnectionStringNameSQL);
        #endregion

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
            List<ADM_TIPO_FILIACION> tipoaafiliacion = new List<ADM_TIPO_FILIACION>();
            using (var comando = _database.GetStoredProcCommand(string.Format("{0}{1}", ConectionStringRepository.EsquemaName, "p_ADM_TIPO_FILIACION_GetAllActives")))
            {
                //_database.AddInParameter(comando, "@tabla", DbType.String, entity.tabla);
                using (var lector = _database.ExecuteReader(comando))
                {
                    while (lector.Read())
                    {
                        tipoaafiliacion.Add(new ADM_TIPO_FILIACION
                        {
                            id_tipo_filiacion = lector.IsDBNull(lector.GetOrdinal("id_tipo_filiacion")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_tipo_filiacion")),
                            t_descripcion = lector.IsDBNull(lector.GetOrdinal("t_descripcion")) ? default(string) : lector.GetString(lector.GetOrdinal("t_descripcion")),
                        });
                    }
                }
            }

            return tipoaafiliacion;
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
