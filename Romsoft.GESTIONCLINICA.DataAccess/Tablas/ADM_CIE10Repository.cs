using Microsoft.Practices.EnterpriseLibrary.Data;
using Romsoft.GESTIONCLINICA.Common;
using Romsoft.GESTIONCLINICA.Common.Generics;
using Romsoft.GESTIONCLINICA.DataAccess.Core;
using Romsoft.GESTIONCLINICA.DataAccess.Interfaces.IADM_CIE10Repository;
using Romsoft.GESTIONCLINICA.Entidades.ADM_CIE10;
using System;
using System.Collections.Generic;
using System.Data;

namespace Romsoft.GESTIONCLINICA.DataAccess.Tablas
{
    public class ADM_CIE10Repository : Singleton<ADM_CIE10Repository>, IADM_CIE10Repository<ADM_CIE10>
    {
        #region Attributos
        private readonly Database _database = new DatabaseProviderFactory().Create(ConectionStringRepository.ConnectionStringNameSQL);
        #endregion

        public int Add(ADM_CIE10 entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(ADM_CIE10 entity)
        {
            throw new NotImplementedException();
        }

        public bool Exists(ADM_CIE10 entity)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_CIE10> GetAll(string whereFilters)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_CIE10> GetAllActives()
        {
            List<ADM_CIE10> cie10 = new List<ADM_CIE10>();
            using (var comando = _database.GetStoredProcCommand(string.Format("{0}{1}", ConectionStringRepository.EsquemaName, "p_ADM_CIE10_GetAllActives")))
            {
                //_database.AddInParameter(comando, "@tabla", DbType.String, entity.tabla);
                using (var lector = _database.ExecuteReader(comando))
                {
                    while (lector.Read())
                    {
                        cie10.Add(new ADM_CIE10
                        {
                            id_cie10 = lector.IsDBNull(lector.GetOrdinal("id_cie10")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_cie10")),
                            t_descripcion = lector.IsDBNull(lector.GetOrdinal("t_descripcion")) ? default(string) : lector.GetString(lector.GetOrdinal("t_descripcion")),
                        });
                    }
                }
            }

            return cie10;
        }

        public IList<ADM_CIE10> GetAllFilters(ADM_CIE10 entity)
        {
            List<ADM_CIE10> cie10 = new List<ADM_CIE10>();
            using (var comando = _database.GetStoredProcCommand(string.Format("{0}{1}", ConectionStringRepository.EsquemaName, "p_ADM_CIE10_GetAllFilter")))
            {
                _database.AddInParameter(comando, "@valor", DbType.String, entity.valorReq);

                using (var lector = _database.ExecuteReader(comando))
                {
                    while (lector.Read())
                    {
                        cie10.Add(new ADM_CIE10
                        {

                            id_cie10 = lector.IsDBNull(lector.GetOrdinal("id_cie10")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_cie10")),
                            c_codigo = lector.IsDBNull(lector.GetOrdinal("c_codigo")) ? default(string) : lector.GetString(lector.GetOrdinal("c_codigo")),
                            t_descripcion = lector.IsDBNull(lector.GetOrdinal("t_descripcion")) ? default(string) : lector.GetString(lector.GetOrdinal("t_descripcion")),

                        });
                    }
                }
            }

            return cie10;
        }

        public IList<ADM_CIE10> GetAllPaging(PaginationParameter paginationParameters)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_CIE10> GetById(ADM_CIE10 entity)
        {
            throw new NotImplementedException();
        }

        public int Update(ADM_CIE10 entity)
        {
            throw new NotImplementedException();
        }
    }
}
