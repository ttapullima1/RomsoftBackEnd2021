using Microsoft.Practices.EnterpriseLibrary.Data;
using Romsoft.GESTIONCLINICA.Common;
using Romsoft.GESTIONCLINICA.Common.Generics;
using Romsoft.GESTIONCLINICA.DataAccess.Core;
using Romsoft.GESTIONCLINICA.DataAccess.Interfaces.IADM_ESPECIALIDADRepository;
using Romsoft.GESTIONCLINICA.Entidades.ADM_ESPECIALIDAD;
using System;
using System.Collections.Generic;
using System.Data;

namespace Romsoft.GESTIONCLINICA.DataAccess.Tablas
{
    public class ADM_ESPECIALIDADRepository : Singleton<ADM_ESPECIALIDADRepository>, IADM_ESPECIALIDADRepository<ADM_ESPECIALIDAD>
    {
        #region Attributos
        private readonly Database _database = new DatabaseProviderFactory().Create(ConectionStringRepository.ConnectionStringNameSQL);
        #endregion

        public int Add(ADM_ESPECIALIDAD entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(ADM_ESPECIALIDAD entity)
        {
            throw new NotImplementedException();
        }

        public bool Exists(ADM_ESPECIALIDAD entity)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_ESPECIALIDAD> GetAll(string whereFilters)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_ESPECIALIDAD> GetAllActives()
        {
            List<ADM_ESPECIALIDAD> especialidad = new List<ADM_ESPECIALIDAD>();
            using (var comando = _database.GetStoredProcCommand(string.Format("{0}{1}", ConectionStringRepository.EsquemaName, "p_ADM_ESPECIALIDAD_GetAllActives")))
            {
                //_database.AddInParameter(comando, "@tabla", DbType.String, entity.tabla);
                using (var lector = _database.ExecuteReader(comando))
                {
                    while (lector.Read())
                    {
                        especialidad.Add(new ADM_ESPECIALIDAD
                        {
                            id_especialidad = lector.IsDBNull(lector.GetOrdinal("id_especialidad")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_especialidad")),
                            t_descripcion = lector.IsDBNull(lector.GetOrdinal("t_descripcion")) ? default(string) : lector.GetString(lector.GetOrdinal("t_descripcion")),
                        });
                    }
                }
            }

            return especialidad;
        }

        public IList<ADM_ESPECIALIDAD> GetAllFilters(ADM_ESPECIALIDAD entity)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_ESPECIALIDAD> GetAllPaging(PaginationParameter paginationParameters)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_ESPECIALIDAD> GetById(ADM_ESPECIALIDAD entity)
        {
            throw new NotImplementedException();
        }

        public int Update(ADM_ESPECIALIDAD entity)
        {
            throw new NotImplementedException();
        }
    }
}
