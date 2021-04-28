using Microsoft.Practices.EnterpriseLibrary.Data;
using Romsoft.GESTIONCLINICA.Common;
using Romsoft.GESTIONCLINICA.Common.Generics;
using Romsoft.GESTIONCLINICA.DataAccess.Core;
using Romsoft.GESTIONCLINICA.DataAccess.Interfaces.IADM_DOCUMENTO_PRESTACIONRepository;
using Romsoft.GESTIONCLINICA.Entidades.ADM_DOCUMENTO_PRESTACION;
using System;
using System.Collections.Generic;
using System.Data;

namespace Romsoft.GESTIONCLINICA.DataAccess.Tablas
{
    public class ADM_DOCUMENTO_PRESTACIONRepository : Singleton<ADM_DOCUMENTO_PRESTACIONRepository>, IADM_DOCUMENTO_PRESTACIONRepository<ADM_DOCUMENTO_PRESTACION>
    {
        #region Attributos
        private readonly Database _database = new DatabaseProviderFactory().Create(ConectionStringRepository.ConnectionStringNameSQL);
        #endregion
        public int Add(ADM_DOCUMENTO_PRESTACION entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(ADM_DOCUMENTO_PRESTACION entity)
        {
            throw new NotImplementedException();
        }

        public bool Exists(ADM_DOCUMENTO_PRESTACION entity)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_DOCUMENTO_PRESTACION> GetAll(string whereFilters)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_DOCUMENTO_PRESTACION> GetAllActives()
        {
            List<ADM_DOCUMENTO_PRESTACION> docprestacion = new List<ADM_DOCUMENTO_PRESTACION>();
            using (var comando = _database.GetStoredProcCommand(string.Format("{0}{1}", ConectionStringRepository.EsquemaName, "p_ADM_DOCUMENTO_PRESTACION_GetAllActives")))
            {
                //_database.AddInParameter(comando, "@tabla", DbType.String, entity.tabla);
                using (var lector = _database.ExecuteReader(comando))
                {
                    while (lector.Read())
                    {
                        docprestacion.Add(new ADM_DOCUMENTO_PRESTACION
                        {
                            id_documento_prestacion = lector.IsDBNull(lector.GetOrdinal("id_documento_prestacion")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_documento_prestacion")),
                            t_descripcion = lector.IsDBNull(lector.GetOrdinal("t_descripcion")) ? default(string) : lector.GetString(lector.GetOrdinal("t_descripcion")),
                        });
                    }
                }
            }

            return docprestacion;
        }

        public IList<ADM_DOCUMENTO_PRESTACION> GetAllFilters(ADM_DOCUMENTO_PRESTACION entity)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_DOCUMENTO_PRESTACION> GetAllPaging(PaginationParameter paginationParameters)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_DOCUMENTO_PRESTACION> GetById(ADM_DOCUMENTO_PRESTACION entity)
        {
            throw new NotImplementedException();
        }

        public int Update(ADM_DOCUMENTO_PRESTACION entity)
        {
            throw new NotImplementedException();
        }
    }
}
