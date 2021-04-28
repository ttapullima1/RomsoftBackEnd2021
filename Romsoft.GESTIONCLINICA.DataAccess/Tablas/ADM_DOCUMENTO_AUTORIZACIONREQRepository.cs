using Microsoft.Practices.EnterpriseLibrary.Data;
using Romsoft.GESTIONCLINICA.Common;
using Romsoft.GESTIONCLINICA.Common.Generics;
using Romsoft.GESTIONCLINICA.DataAccess.Core;
using Romsoft.GESTIONCLINICA.DataAccess.Interfaces.IADM_DOCUMENTO_AUTORIZACIONRepository;
using Romsoft.GESTIONCLINICA.Entidades.ADM_DOCUMENTO_AUTORIZACION;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Romsoft.GESTIONCLINICA.DataAccess.Tablas
{
    public class ADM_DOCUMENTO_AUTORIZACIONREQRepository : Singleton<ADM_DOCUMENTO_AUTORIZACIONREQRepository>, IADM_DOCUMENTO_AUTORIZACIONREQRepository<ADM_DOCUMENTO_AUTORIZACION_REQ>
    {
        private readonly Database _database = new DatabaseProviderFactory().Create(ConectionStringRepository.ConnectionStringNameSQL);

        public int Add(ADM_DOCUMENTO_AUTORIZACION_REQ entity)
        {

            throw new NotImplementedException();
        }

        public int Delete(ADM_DOCUMENTO_AUTORIZACION_REQ entity)
        {
            throw new NotImplementedException();
        }

        public bool Exists(ADM_DOCUMENTO_AUTORIZACION_REQ entity)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_DOCUMENTO_AUTORIZACION_RES> GetAddAtencionAll(ADM_DOCUMENTO_AUTORIZACION_REQ entity)
        {
            List<ADM_DOCUMENTO_AUTORIZACION_RES> autoriza = new List<ADM_DOCUMENTO_AUTORIZACION_RES>();
            //



            ////Se crea tabla con las misma estrcura del detalle SQL
            DataTable tvpDetalle = new DataTable();
            tvpDetalle.Columns.Add("c_cod_iafa");
            tvpDetalle.Columns.Add("c_cod_asegurado");
            tvpDetalle.Columns.Add("c_cod_autorizacion");
            tvpDetalle.Columns.Add("d_fecha_autorizacion", typeof(DateTime));
            tvpDetalle.Columns.Add("c_cod_ipress");
            tvpDetalle.Columns.Add("c_ruc_ipress");
            tvpDetalle.Columns.Add("t_nombre_paciente");
            tvpDetalle.Columns.Add("c_cod_sexo");
            tvpDetalle.Columns.Add("d_fecha_nacimiento", typeof(DateTime));
            tvpDetalle.Columns.Add("c_cod_paciente");
            tvpDetalle.Columns.Add("c_numero_paciente");
            tvpDetalle.Columns.Add("n_numero_edad");
            tvpDetalle.Columns.Add("t_apellido_paterno");
            tvpDetalle.Columns.Add("t_apellido_materno");
            tvpDetalle.Columns.Add("t_nombres_completo");
            tvpDetalle.Columns.Add("c_cod_asegurado_titular");
            tvpDetalle.Columns.Add("t_nombre_titular");
            tvpDetalle.Columns.Add("c_cod_doc_titular");
            tvpDetalle.Columns.Add("c_numero_doc_titular");
            tvpDetalle.Columns.Add("c_cod_tipo_filiacion");
            tvpDetalle.Columns.Add("c_des_tipo_afiliacion");
            tvpDetalle.Columns.Add("c_cod_cobertura");
            tvpDetalle.Columns.Add("c_cod_subcobertura");
            tvpDetalle.Columns.Add("t_des_beneficio");
            tvpDetalle.Columns.Add("c_cod_producto");
            tvpDetalle.Columns.Add("t_des_producto");
            tvpDetalle.Columns.Add("c_cod_tplan");
            tvpDetalle.Columns.Add("t_des_tplan");
            tvpDetalle.Columns.Add("c_cod_tafiliacion");
            tvpDetalle.Columns.Add("t_des_tafiliacion");
            tvpDetalle.Columns.Add("c_num_poliza");
            tvpDetalle.Columns.Add("c_num_plan");
            tvpDetalle.Columns.Add("c_cod_contratante");
            tvpDetalle.Columns.Add("c_cod_contratante_abr");
            tvpDetalle.Columns.Add("c_num_contratante");
            tvpDetalle.Columns.Add("t_des_contratante");
            tvpDetalle.Columns.Add("d_ini_vigencia", typeof(DateTime));
            tvpDetalle.Columns.Add("d_fin_vigencia", typeof(DateTime));
            tvpDetalle.Columns.Add("d_incldate", typeof(DateTime));
            tvpDetalle.Columns.Add("c_cod_moneda");
            tvpDetalle.Columns.Add("c_num_copago_fijo");
            tvpDetalle.Columns.Add("c_num_copago_variable");
            tvpDetalle.Columns.Add("c_cod_servicio");
            tvpDetalle.Columns.Add("c_num_ip");
            tvpDetalle.Columns.Add("f_estado");


            var _Detalle = entity.listaAutoriza;

            //foreach (var _Detalle in entity.listaAutoriza)
            //{
                DataRow row2 = tvpDetalle.NewRow();
                row2["c_cod_iafa"] = _Detalle.COD_IAFA.ToString();
                row2["c_cod_asegurado"] = _Detalle.COD_ASEGURADO;
                row2["c_cod_autorizacion"] = _Detalle.COD_AUTORIZACION;
                row2["d_fecha_autorizacion"] = _Detalle.FEC_AUTORIZACION;
                row2["c_cod_ipress"] = _Detalle.COD_IPRESS;
                row2["c_ruc_ipress"] = _Detalle.COD_IPRESS;
                row2["t_nombre_paciente"] = _Detalle.NOMBRES;
                row2["c_cod_sexo"] = _Detalle.SEXO;
                row2["d_fecha_nacimiento"] = _Detalle.FEC_NACIMIENTO;
                row2["c_cod_paciente"] = Convert.ToInt32(_Detalle.COD_DOCUMENTO.ToString().Trim());
                row2["c_numero_paciente"] = _Detalle.NUM_DOCUMENTO;
                row2["n_numero_edad"] = _Detalle.NUM_EDAD;
                row2["t_apellido_paterno"] = _Detalle.AP_PATERNO;
                row2["t_apellido_materno"] = _Detalle.AP_MATERNO;
                row2["t_nombres_completo"] = _Detalle.NOMBRES;
                row2["c_cod_asegurado_titular"] = _Detalle.COD_ASEGURADO_TITULAR;
                row2["t_nombre_titular"] = _Detalle.TITULAR;
                row2["c_cod_doc_titular"] = _Detalle.COD_DOCUMENTO_TITULAR;
                row2["c_numero_doc_titular"] = _Detalle.NUM_DOCUMENTO_TITULAR;
                row2["c_cod_tipo_filiacion"] = _Detalle.COD_TIPO_FILIACION;
                row2["c_des_tipo_afiliacion"] = _Detalle.DES_TIPO_AFILIACION;
                row2["c_cod_cobertura"] = _Detalle.COD_COBERTURA;
                row2["c_cod_subcobertura"] = _Detalle.COD_SUBCOBERTURA;
                row2["t_des_beneficio"] = _Detalle.DES_BENEFICIO;
                row2["c_cod_producto"] = _Detalle.COD_PRODUCTO;
                row2["t_des_producto"] = _Detalle.DES_PRODUCTO;
                row2["c_cod_tplan"] = Convert.ToInt32(_Detalle.COD_TIPOPLAN.ToString().Trim());
                row2["t_des_tplan"] = _Detalle.DES_TIPOPLAN;
                row2["c_cod_tafiliacion"] = _Detalle.COD_TIPO_AFILIACION;
                row2["t_des_tafiliacion"] = _Detalle.DES_TIPO_AFILIACION;
                row2["c_num_poliza"] = _Detalle.NUM_POLIZA;
                row2["c_num_plan"] = _Detalle.NUM_PLAN;
                row2["c_cod_contratante"] = _Detalle.COD_CONTRATANTE;
                row2["c_cod_contratante_abr"] = _Detalle.COD_CONTRATANTE_ABR;
                row2["c_num_contratante"] = _Detalle.NUM_CONTRATANTE;
                row2["t_des_contratante"] = _Detalle.DES_CONTRATANTE;
                row2["d_ini_vigencia"] = _Detalle.FEC_INICIO_VIGENCIA;
                row2["d_fin_vigencia"] = _Detalle.FEC_FIN_VIGENCIA;
                row2["d_incldate"] = _Detalle.FE_INCLDATE;
                row2["c_cod_moneda"] = _Detalle.COD_MONEDA;
                row2["c_num_copago_fijo"] = _Detalle.NUM_COPAGO_FIJO;
                row2["c_num_copago_variable"] = _Detalle.NUM_COPAGO_VARIABLE;
                row2["c_cod_servicio"] = _Detalle.COD_SERVICIO;
                row2["c_num_ip"] = _Detalle.NUM_IP;
                row2["f_estado"] = _Detalle.f_estado;

                tvpDetalle.Rows.Add(row2);
            //}
            tvpDetalle.AcceptChanges();

            using (var comando = _database.GetStoredProcCommand(string.Format("{0}{1}", ConectionStringRepository.EsquemaName, "p_ADM_DOCUMENTO_AUTORIZACION_Insert")))
            {
                _database.AddInParameter(comando, "@id_user_registro", DbType.String, entity.idUser);

                var parametroLista = new SqlParameter("@DOC_AUTORIZA", SqlDbType.Structured);
                parametroLista.TypeName = "Romsoft.ADM_DOCUMENTO_AUTORIZACION_TYPE";
                parametroLista.Value = tvpDetalle;
                comando.Parameters.Add(parametroLista);

                using (var lector = _database.ExecuteReader(comando))
                {
                    while (lector.Read())
                    {
                        autoriza.Add(new ADM_DOCUMENTO_AUTORIZACION_RES
                        {
                            id_documento_autorizacion = lector.IsDBNull(lector.GetOrdinal("id_documento_autorizacion")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_documento_autorizacion")),
                            id_plan_seguro = lector.IsDBNull(lector.GetOrdinal("id_plan_seguro")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_plan_seguro")),
                            id_categoria_pago = lector.IsDBNull(lector.GetOrdinal("id_categoria_pago")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_categoria_pago")),
                            codigo_asegurado = lector.IsDBNull(lector.GetOrdinal("codigo_asegurado")) ? default(string) : lector.GetString(lector.GetOrdinal("codigo_asegurado")),
                            numero_contrato = lector.IsDBNull(lector.GetOrdinal("numero_contrato")) ? default(string) : lector.GetString(lector.GetOrdinal("numero_contrato")),
                            id_beneficio = lector.IsDBNull(lector.GetOrdinal("id_beneficio")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_beneficio")),
                            id_atecion_autoriza =  lector.IsDBNull(lector.GetOrdinal("id_atencion_autoriza")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_atencion_autoriza")),
                            c_cod_autorizacion = lector.IsDBNull(lector.GetOrdinal("c_cod_autorizacion")) ? default(string) : lector.GetString(lector.GetOrdinal("c_cod_autorizacion")),
                            d_fecha_autorizacion = lector.IsDBNull(lector.GetOrdinal("d_fecha_autorizacion")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("d_fecha_autorizacion")),
                            id_tipo_filiacion =  lector.IsDBNull(lector.GetOrdinal("id_tipo_filiacion")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_tipo_filiacion")),
                            t_nombre_titular = lector.IsDBNull(lector.GetOrdinal("t_nombre_titular")) ? default(string) : lector.GetString(lector.GetOrdinal("t_nombre_titular")),
                            id_tipo_afiliacion =  lector.IsDBNull(lector.GetOrdinal("id_tipo_afiliacion")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_tipo_afiliacion")),
                            id_moneda =  lector.IsDBNull(lector.GetOrdinal("id_moneda")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_moneda")),
                            c_num_copago_fijo = lector.IsDBNull(lector.GetOrdinal("c_num_copago_fijo")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("c_num_copago_fijo")),
                            c_num_copago_variable = lector.IsDBNull(lector.GetOrdinal("c_num_copago_variable")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("c_num_copago_variable")),
                            id_producto_plan =  lector.IsDBNull(lector.GetOrdinal("id_producto_plan")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_producto_plan")),

                        });
                    }
                }
            }

            return autoriza;

        }

        public IList<ADM_DOCUMENTO_AUTORIZACION_REQ> GetAll(string whereFilters)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_DOCUMENTO_AUTORIZACION_REQ> GetAllActives()
        {
            throw new NotImplementedException();
        }

        public IList<ADM_DOCUMENTO_AUTORIZACION_REQ> GetAllFilters(ADM_DOCUMENTO_AUTORIZACION_REQ entity)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_DOCUMENTO_AUTORIZACION_REQ> GetAllPaging(PaginationParameter paginationParameters)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_DOCUMENTO_AUTORIZACION_REQ> GetById(ADM_DOCUMENTO_AUTORIZACION_REQ entity)
        {
            throw new NotImplementedException();
        }

        public int Update(ADM_DOCUMENTO_AUTORIZACION_REQ entity)
        {
            throw new NotImplementedException();
        }
    }
}
