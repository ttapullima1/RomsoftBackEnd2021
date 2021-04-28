using Microsoft.Practices.EnterpriseLibrary.Data;
using Romsoft.GESTIONCLINICA.Common;
using Romsoft.GESTIONCLINICA.Common.Generics;
using Romsoft.GESTIONCLINICA.DataAccess.Core;
using Romsoft.GESTIONCLINICA.DataAccess.Interfaces.IADM_TIPO_ATENCIONRepository;
using Romsoft.GESTIONCLINICA.Entidades.ADM_TIPO_ATENCION;
using System;
using System.Collections.Generic;
using System.Data;

namespace Romsoft.GESTIONCLINICA.DataAccess.Tablas
{
    public class ADM_TIPO_ATENCIONRepository : Singleton<ADM_TIPO_ATENCIONRepository>, IADM_TIPO_ATENCIONRepository<ADM_TIPO_ATENCION>
    {
        #region Attributos
        private readonly Database _database = new DatabaseProviderFactory().Create(ConectionStringRepository.ConnectionStringNameSQL);
        #endregion

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
            List<ADM_TIPO_ATENCION> tipoatencion = new List<ADM_TIPO_ATENCION>();
            using (var comando = _database.GetStoredProcCommand(string.Format("{0}{1}", ConectionStringRepository.EsquemaName, "p_ADM_TIPO_ATENCION_GetAllActives")))
            {
                //_database.AddInParameter(comando, "@tabla", DbType.String, entity.tabla);
                using (var lector = _database.ExecuteReader(comando))
                {
                    while (lector.Read())
                    {
                        tipoatencion.Add(new ADM_TIPO_ATENCION
                        {
                            id_tipo_atencion = lector.IsDBNull(lector.GetOrdinal("id_tipo_atencion")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_tipo_atencion")),
                            t_descripcion = lector.IsDBNull(lector.GetOrdinal("t_descripcion")) ? default(string) : lector.GetString(lector.GetOrdinal("t_descripcion")),
                        });
                    }
                }
            }

            return tipoatencion;
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
