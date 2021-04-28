using Microsoft.Practices.EnterpriseLibrary.Data;
using Romsoft.GESTIONCLINICA.Common;
using Romsoft.GESTIONCLINICA.Common.Generics;
using Romsoft.GESTIONCLINICA.DataAccess.Core;
using Romsoft.GESTIONCLINICA.DataAccess.Interfaces.IADM_PROFESIONALRepository;
using Romsoft.GESTIONCLINICA.Entidades.ADM_PROFESIONAL;
using System;
using System.Collections.Generic;
using System.Data;

namespace Romsoft.GESTIONCLINICA.DataAccess.Tablas 
{
    public class ADM_PROFESIONALRepository : Singleton<ADM_PROFESIONALRepository>, IADM_PROFESIONALRepository<ADM_PROFESIONAL>
    {
        #region Attributos
        private readonly Database _database = new DatabaseProviderFactory().Create(ConectionStringRepository.ConnectionStringNameSQL);

        #endregion

        public int Add(ADM_PROFESIONAL entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(ADM_PROFESIONAL entity)
        {
            throw new NotImplementedException();
        }

        public bool Exists(ADM_PROFESIONAL entity)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_PROFESIONAL> GetAll(string whereFilters)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_PROFESIONAL> GetAllActives()
        {
            List<ADM_PROFESIONAL> tipoatencion = new List<ADM_PROFESIONAL>();
            using (var comando = _database.GetStoredProcCommand(string.Format("{0}{1}", ConectionStringRepository.EsquemaName, "p_ADM_PROFESIONAL_GetAllActives")))
            {
                //_database.AddInParameter(comando, "@tabla", DbType.String, entity.tabla);
                using (var lector = _database.ExecuteReader(comando))
                {
                    while (lector.Read())
                    {
                        tipoatencion.Add(new ADM_PROFESIONAL
                        {
                            id_profesional = lector.IsDBNull(lector.GetOrdinal("id_profesional")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_profesional")),
                            t_medico = lector.IsDBNull(lector.GetOrdinal("t_medico")) ? default(string) : lector.GetString(lector.GetOrdinal("t_medico")),
                        });
                    }
                }
            }

            return tipoatencion;
        }

        public IList<ADM_PROFESIONAL> GetAllFilters(ADM_PROFESIONAL entity)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_PROFESIONAL> GetAllPaging(PaginationParameter paginationParameters)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_PROFESIONAL> GetById(ADM_PROFESIONAL entity)
        {
            throw new NotImplementedException();
        }

        public int Update(ADM_PROFESIONAL entity)
        {
            throw new NotImplementedException();
        }
    }
}
