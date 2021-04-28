using Microsoft.Practices.EnterpriseLibrary.Data;
using Romsoft.GESTIONCLINICA.Common;
using Romsoft.GESTIONCLINICA.Common.Generics;
using Romsoft.GESTIONCLINICA.DataAccess.Core;
using Romsoft.GESTIONCLINICA.DataAccess.Interfaces.IPrueba;
using Romsoft.GESTIONCLINICA.Entidades.Prueba;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Romsoft.GESTIONCLINICA.DataAccess.Tablas
{
    public class Cabecera_PruebaRepository : Singleton<Cabecera_PruebaRepository>, ICabecera_PruebaRepository<Cabecera_Prueba>
    {
        #region Attributos
        private readonly Database _database = new DatabaseProviderFactory().Create(ConectionStringRepository.ConnectionStringNameSQL);

        #endregion


        public int Add(Cabecera_Prueba entity)
        {
            throw new NotImplementedException();
        }

        public int addDetalle(Cabecera_Prueba entity)
        {
            int id;

            List<Cabecera_Prueba> listafinal = new List<Cabecera_Prueba>();

            //foreach (var detalle in entity.Detalle_Prueba)
            //{
            //    var _detalle = new Detalle_Prueba();
            //    _detalle.CodVale = detalle.CodVale;
            //    _detalle.Descripcion = detalle.Descripcion;
            //    _detalle.CostoTotal = detalle.CostoTotal;
            //    _detalle.Fecha = detalle.Fecha;
            //    _detalle.f_estado = detalle.f_estado;

            //    //listafinal.Detalle_Prueba.Add(detalle);

            //    //var consultaPuertosResult = await puertosGPRepository.ConsultaPuertos(dto.ObjId, dto.LstPuertosOne, dto.LstPuertosTwo, dto.Fecha);
            //    //listResult.AddRange(consultaPuertosResult);

            //    //listafinal.Add(_cabecera_Prueba);
            //}


            ////Se crea tabla con las misma estrcura del detalle SQL
            DataTable tvpDetalle = new DataTable();
            tvpDetalle.Columns.Add("CodVale");
            tvpDetalle.Columns.Add("id_cabecera");
            tvpDetalle.Columns.Add("Descripcion");
            tvpDetalle.Columns.Add("Fecha", typeof(DateTime));
            tvpDetalle.Columns.Add("CostoTotal");
            tvpDetalle.Columns.Add("f_estado");


            foreach (var _Detalle in entity.Detalle_Prueba)
            {
                DataRow row2 = tvpDetalle.NewRow();
                row2["CodVale"] =  _Detalle.CodVale.ToString();
                row2["id_cabecera"] = 0;
                row2["Descripcion"] = _Detalle.Descripcion.ToString();
                row2["Fecha"] = _Detalle.Fecha;
                row2["CostoTotal"] = Convert.ToDecimal(_Detalle.CostoTotal);
                row2["f_estado"] = Convert.ToInt32(_Detalle.f_estado);

                tvpDetalle.Rows.Add(row2);
            }
            tvpDetalle.AcceptChanges();

            using (var comando = _database.GetStoredProcCommand(string.Format("{0}{1}", ConectionStringRepository.EsquemaName, "p_Registro_Insert")))
            {
                _database.AddInParameter(comando, "@Descripcion", DbType.String, entity.Descripcion);
                _database.AddInParameter(comando, "@Estado", DbType.Int32, entity.Estado);

                var parametroLista = new SqlParameter("@lstDetalle", SqlDbType.Structured);
                parametroLista.TypeName = "Romsoft.EstructuraDetalle";
                parametroLista.Value = tvpDetalle;

                _database.AddOutParameter(comando, "@Response", DbType.Int32, 11);

                comando.Parameters.Add(parametroLista);
               
                _database.ExecuteNonQuery(comando);

                id = Convert.ToInt32(_database.GetParameterValue(comando, "@Response"));
            }

            return id;
        }

        public int Delete(Cabecera_Prueba entity)
        {
            throw new NotImplementedException();
        }

        public bool Exists(Cabecera_Prueba entity)
        {
            throw new NotImplementedException();
        }

        public IList<Cabecera_Prueba> GetAll(string whereFilters)
        {
            throw new NotImplementedException();
        }

        public IList<Cabecera_Prueba> GetAllActives()
        {
            throw new NotImplementedException();
        }

        public IList<Cabecera_Prueba> GetAllFilters(Cabecera_Prueba entity)
        {
            throw new NotImplementedException();
        }

        public IList<Cabecera_Prueba> GetAllPaging(PaginationParameter paginationParameters)
        {
            throw new NotImplementedException();
        }

        public IList<Cabecera_Prueba> GetById(Cabecera_Prueba entity)
        {
            throw new NotImplementedException();
        }

        public int Update(Cabecera_Prueba entity)
        {
            throw new NotImplementedException();
        }
    }
}
