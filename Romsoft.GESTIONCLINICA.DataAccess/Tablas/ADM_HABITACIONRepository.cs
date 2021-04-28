using Microsoft.Practices.EnterpriseLibrary.Data;
using Romsoft.GESTIONCLINICA.Common;
using Romsoft.GESTIONCLINICA.Common.Generics;
using Romsoft.GESTIONCLINICA.DataAccess.Core;
using Romsoft.GESTIONCLINICA.DataAccess.Interfaces.IADM_HABITACIONRepository;
using Romsoft.GESTIONCLINICA.Entidades.ADM_HABITACION;
using System;
using System.Collections.Generic;
using System.Data;


namespace Romsoft.GESTIONCLINICA.DataAccess.Tablas
{
    public class ADM_HABITACIONRepository : Singleton<ADM_HABITACIONRepository>, IADM_HABITACIONRepository<ADM_HABITACION>
    {
        #region Attributos
        private readonly Database _database = new DatabaseProviderFactory().Create(ConectionStringRepository.ConnectionStringNameSQL);
        #endregion

        public int Add(ADM_HABITACION entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(ADM_HABITACION entity)
        {
            throw new NotImplementedException();
        }

        public bool Exists(ADM_HABITACION entity)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_HABITACION> GetAll(string whereFilters)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_HABITACION> GetAllActives()
        {
            List<ADM_HABITACION> tipocie10 = new List<ADM_HABITACION>();
            using (var comando = _database.GetStoredProcCommand(string.Format("{0}{1}", ConectionStringRepository.EsquemaName, "p_ADM_HABITACION_GetAllActives")))
            {
                //_database.AddInParameter(comando, "@tabla", DbType.String, entity.tabla);
                using (var lector = _database.ExecuteReader(comando))
                {
                    while (lector.Read())
                    {
                        tipocie10.Add(new ADM_HABITACION
                        {
                            id_habitacion = lector.IsDBNull(lector.GetOrdinal("id_habitacion")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_habitacion")),
                            t_descripcion = lector.IsDBNull(lector.GetOrdinal("t_descripcion")) ? default(string) : lector.GetString(lector.GetOrdinal("t_descripcion")),
                        });
                    }
                }
            }

            return tipocie10;
        }

        public IList<ADM_HABITACION> GetAllFilters(ADM_HABITACION entity)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_HABITACION> GetAllPaging(PaginationParameter paginationParameters)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_HABITACION> GetById(ADM_HABITACION entity)
        {
            throw new NotImplementedException();
        }

        public int Update(ADM_HABITACION entity)
        {
            throw new NotImplementedException();
        }
    }
}
