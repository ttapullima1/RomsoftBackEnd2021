using Microsoft.Practices.EnterpriseLibrary.Data;
using Romsoft.GESTIONCLINICA.Common;
using Romsoft.GESTIONCLINICA.Common.Generics;
using Romsoft.GESTIONCLINICA.DataAccess.Core;
using Romsoft.GESTIONCLINICA.DataAccess.Interfaces.IADM_TIPO_AFILIACIONRepository;
using Romsoft.GESTIONCLINICA.Entidades.ADM_TIPO_AFILIACION;
using System;
using System.Collections.Generic;
using System.Data;

namespace Romsoft.GESTIONCLINICA.DataAccess.Tablas
{
    public class ADM_TIPO_AFILIACIONRepository : Singleton<ADM_TIPO_AFILIACIONRepository>, IADM_TIPO_AFILIACIONRepository<ADM_TIPO_AFILIACION>
    {
        #region Attributos
        private readonly Database _database = new DatabaseProviderFactory().Create(ConectionStringRepository.ConnectionStringNameSQL);
        #endregion

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
            List<ADM_TIPO_AFILIACION> tipoafiliacion = new List<ADM_TIPO_AFILIACION>();
            using (var comando = _database.GetStoredProcCommand(string.Format("{0}{1}", ConectionStringRepository.EsquemaName, "p_ADM_TIPO_AFILIACION_GetAllActives")))
            {
                //_database.AddInParameter(comando, "@tabla", DbType.String, entity.tabla);
                using (var lector = _database.ExecuteReader(comando))
                {
                    while (lector.Read())
                    {
                        tipoafiliacion.Add(new ADM_TIPO_AFILIACION
                        {
                            id_tipo_afiliacion = lector.IsDBNull(lector.GetOrdinal("id_tipo_afiliacion")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_tipo_afiliacion")),
                            t_descripcion = lector.IsDBNull(lector.GetOrdinal("t_descripcion")) ? default(string) : lector.GetString(lector.GetOrdinal("t_descripcion")),
                        });
                    }
                }
            }

            return tipoafiliacion;
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
