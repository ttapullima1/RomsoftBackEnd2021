using Microsoft.Practices.EnterpriseLibrary.Data;
using Romsoft.GESTIONCLINICA.Common;
using Romsoft.GESTIONCLINICA.Common.Generics;
using Romsoft.GESTIONCLINICA.DataAccess.Core;
using Romsoft.GESTIONCLINICA.DataAccess.Interfaces.IADM_ATENCIONRepository;
using Romsoft.GESTIONCLINICA.Entidades.ADM_ATENCION;
using System;
using System.Collections.Generic;
using System.Data;

namespace Romsoft.GESTIONCLINICA.DataAccess.Tablas
{
    public class ADM_ATENCIONRepository : Singleton<ADM_ATENCIONRepository>, IADM_ATENCIONRepository<ADM_ATENCION>
    {
        #region Attributos
        private readonly Database _database = new DatabaseProviderFactory().Create(ConectionStringRepository.ConnectionStringNameSQL);

        #endregion

        public int Add(ADM_ATENCION entity)
        {
            int id;

            using (var comando = _database.GetStoredProcCommand(string.Format("{0}{1}", ConectionStringRepository.EsquemaName, "p_ADM_ATENCION_Insert")))
            {
                _database.AddInParameter(comando, "@id_paciente", DbType.Int32, entity.id_paciente);
                _database.AddInParameter(comando, "@id_tipo_paciente", DbType.Int32, entity.id_tipo_paciente);
                _database.AddInParameter(comando, "@id_tipo_atencion", DbType.Int32, entity.id_tipo_atencion);
                _database.AddInParameter(comando, "@d_fecha_registro", DbType.DateTime, entity.d_fecha_registro);
                _database.AddInParameter(comando, "@c_hora_registro", DbType.String, entity.c_hora_registro);
                _database.AddInParameter(comando, "@n_paciente_derivado", DbType.Int32, entity.n_paciente_derivado);
                _database.AddInParameter(comando, "@id_plan_seguro", DbType.Int32, entity.id_plan_seguro);
                _database.AddInParameter(comando, "@id_categoria_pago", DbType.Int32, entity.id_categoria_pago);
                _database.AddInParameter(comando, "@c_codigo_asegurado", DbType.String, entity.c_codigo_asegurado);
                _database.AddInParameter(comando, "@c_contrato", DbType.String, entity.c_contrato);
                _database.AddInParameter(comando, "@id_beneficio", DbType.Int32, entity.id_beneficio);
                _database.AddInParameter(comando, "@id_documento_prestacion1", DbType.Int32, entity.id_documento_prestacion1);
                _database.AddInParameter(comando, "@c_documento_prestacion1", DbType.String, entity.c_documento_prestacion1);
                _database.AddInParameter(comando, "@d_fecha_autorizacion1", DbType.DateTime, entity.d_fecha_autorizacion1);
                _database.AddInParameter(comando, "@id_documento_prestacion2", DbType.Int32, entity.id_documento_prestacion2);
                _database.AddInParameter(comando, "@c_documento_prestacion2", DbType.String, entity.c_documento_prestacion2);
                _database.AddInParameter(comando, "@d_fecha_autorizacion2", DbType.DateTime, entity.d_fecha_autorizacion2);
                _database.AddInParameter(comando, "@id_tipo_filiacion", DbType.Int32, entity.id_tipo_filiacion);
                _database.AddInParameter(comando, "@t_nombre_titular", DbType.String, entity.t_nombre_titular);
                _database.AddInParameter(comando, "@id_tipo_afiliacion", DbType.Int32, entity.id_tipo_afiliacion);
                _database.AddInParameter(comando, "@id_moneda", DbType.Int32, entity.id_moneda);
                _database.AddInParameter(comando, "@n_copago_fijo", DbType.Decimal, entity.n_copago_fijo);
                _database.AddInParameter(comando, "@n_copago_variable", DbType.Decimal, entity.n_copago_variable);
                _database.AddInParameter(comando, "@n_copago_variable_far", DbType.Decimal, entity.n_copago_variable_far);
                _database.AddInParameter(comando, "@id_producto_plan", DbType.Int32, entity.id_producto_plan);
                _database.AddInParameter(comando, "@n_limite_cobertura", DbType.String, entity.n_limite_cobertura);
                _database.AddInParameter(comando, "@id_tipo_diagnostico", DbType.Int32, entity.id_tipo_diagnostico);
                _database.AddInParameter(comando, "@id_diagnostico", DbType.Int32, entity.id_diagnostico);
                _database.AddInParameter(comando, "@c_numero_placa", DbType.String, entity.c_numero_placa);
                _database.AddInParameter(comando, "@n_deja_denuncia", DbType.Int32, entity.n_deja_denuncia);
                _database.AddInParameter(comando, "@n_deja_carta", DbType.Int32, entity.n_deja_carta);
                _database.AddInParameter(comando, "@t_observacion_accidente", DbType.String, entity.t_observacion_accidente);
                _database.AddInParameter(comando, "@id_profesional", DbType.Int32, entity.id_profesional);
                _database.AddInParameter(comando, "@id_hospitalizacion", DbType.Int32, entity.id_hospitalizacion);
                _database.AddInParameter(comando, "@t_observacion_general", DbType.String, entity.t_observacion_general);
                _database.AddInParameter(comando, "@d_fecha_cierre", DbType.DateTime, entity.d_fecha_cierre);
                _database.AddInParameter(comando, "@c_hora_cierre", DbType.String, entity.c_hora_cierre);
                _database.AddInParameter(comando, "@id_tipo_facturacion", DbType.Int32, entity.id_tipo_facturacion);
                _database.AddInParameter(comando, "@n_a_no_gravado", DbType.Decimal, entity.n_a_no_gravado);
                _database.AddInParameter(comando, "@n_a_gravado", DbType.Decimal, entity.n_a_gravado);
                _database.AddInParameter(comando, "@n_a_impuesto", DbType.Decimal, entity.n_a_impuesto);
                _database.AddInParameter(comando, "@n_a_total", DbType.Decimal, entity.n_a_total);
                _database.AddInParameter(comando, "@n_p_no_gravado", DbType.Decimal, entity.n_p_no_gravado);
                _database.AddInParameter(comando, "@n_p_gravado", DbType.Decimal, entity.n_p_gravado);
                _database.AddInParameter(comando, "@n_p_impuesto", DbType.Decimal, entity.n_p_impuesto);
                _database.AddInParameter(comando, "@n_p_total", DbType.Decimal, entity.n_p_total);
                _database.AddInParameter(comando, "@n_g_no_gravado", DbType.Decimal, entity.n_g_no_gravado);
                _database.AddInParameter(comando, "@n_g_gravado", DbType.Decimal, entity.n_g_gravado);
                _database.AddInParameter(comando, "@n_g_impuesto", DbType.Decimal, entity.n_g_impuesto);
                _database.AddInParameter(comando, "@n_g_total", DbType.Decimal, entity.n_g_total);
                _database.AddInParameter(comando, "@f_estado", DbType.Int32, entity.f_estado);
                _database.AddInParameter(comando, "@id_user_registro", DbType.Int32, entity.id_usuarioCreacion);
                _database.AddInParameter(comando, "@id_user_modifica", DbType.Int32, entity.id_usuarioCreacion);
                _database.AddInParameter(comando, "@d_fecha_modifica", DbType.DateTime, entity.FechaCreacion);
                _database.AddOutParameter(comando, "@Response", DbType.Int32, 11);

                _database.ExecuteNonQuery(comando);
                id = Convert.ToInt32(_database.GetParameterValue(comando, "@Response"));
            }

            return id;
        }

        public int Delete(ADM_ATENCION entity)
        {
            throw new NotImplementedException();
        }

        public bool Exists(ADM_ATENCION entity)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_ATENCION> GetAll(string whereFilters)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_ATENCION> GetAllActives()
        {
            throw new NotImplementedException();
        }

        public IList<ADM_ATENCION> GetAllFilters(ADM_ATENCION entity)
        {
            List<ADM_ATENCION> atenciones = new List<ADM_ATENCION>();
            using (var comando = _database.GetStoredProcCommand(string.Format("{0}{1}", ConectionStringRepository.EsquemaName, "p_ADM_PACIENTE_GetAllFilter")))
            {
                _database.AddInParameter(comando, "@id_paciente", DbType.Int32, entity.id_paciente);
                _database.AddInParameter(comando, "@d_fecha_registro_1", DbType.DateTime, entity.d_fecha_registro_1);
                _database.AddInParameter(comando, "@d_fecha_registro_2", DbType.DateTime, entity.d_fecha_registro_2);



                using (var lector = _database.ExecuteReader(comando))
                {
                    while (lector.Read())
                    {
                        atenciones.Add(new ADM_ATENCION
                        {
                            id_nro_interno = lector.IsDBNull(lector.GetOrdinal("id_nro_interno")) ? default(int) : lector.GetInt64(lector.GetOrdinal("id_nro_interno")),
                            d_fecha_ingreso = lector.IsDBNull(lector.GetOrdinal("d_fecha_ingreso")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("d_fecha_ingreso")),
                            tipo_paciente = lector.IsDBNull(lector.GetOrdinal("tipo_paciente")) ? default(string) : lector.GetString(lector.GetOrdinal("tipo_paciente")),
                            tipo_atencion = lector.IsDBNull(lector.GetOrdinal("tipo_atencion")) ? default(string) : lector.GetString(lector.GetOrdinal("tipo_atencion")),
                            garante = lector.IsDBNull(lector.GetOrdinal("garante")) ? default(string) : lector.GetString(lector.GetOrdinal("garante")),
                            contratante = lector.IsDBNull(lector.GetOrdinal("t_direccion")) ? default(string) : lector.GetString(lector.GetOrdinal("t_direccion")),
                            estado = lector.IsDBNull(lector.GetOrdinal("estado")) ? default(string) : lector.GetString(lector.GetOrdinal("estado")),

                        });
                    }
                }
            }

            return atenciones;
        }

        public IList<ADM_ATENCION> GetAllPaciente(int idPaciente)
        {
            List<ADM_ATENCION> atenciones = new List<ADM_ATENCION>();
            using (var comando = _database.GetStoredProcCommand(string.Format("{0}{1}", ConectionStringRepository.EsquemaName, "p_ADM_ATENCION_GetAll")))
            {
                _database.AddInParameter(comando, "@id_paciente", DbType.Int32, idPaciente);

                using (var lector = _database.ExecuteReader(comando))
                {
                    while (lector.Read())
                    {
                        atenciones.Add(new ADM_ATENCION
                        {
                            id_nro_interno = lector.IsDBNull(lector.GetOrdinal("id_nro_interno")) ? default(int) : lector.GetInt64(lector.GetOrdinal("id_nro_interno")),
                            d_fecha_ingreso = lector.IsDBNull(lector.GetOrdinal("d_fecha_ingreso")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("d_fecha_ingreso")),
                            tipo_paciente = lector.IsDBNull(lector.GetOrdinal("tipo_paciente")) ? default(string) : lector.GetString(lector.GetOrdinal("tipo_paciente")),
                            tipo_atencion = lector.IsDBNull(lector.GetOrdinal("tipo_atencion")) ? default(string) : lector.GetString(lector.GetOrdinal("tipo_atencion")),
                            garante = lector.IsDBNull(lector.GetOrdinal("garante")) ? default(string) : lector.GetString(lector.GetOrdinal("garante")),
                            contratante = lector.IsDBNull(lector.GetOrdinal("t_direccion")) ? default(string) : lector.GetString(lector.GetOrdinal("t_direccion")),
                            estado = lector.IsDBNull(lector.GetOrdinal("estado")) ? default(string) : lector.GetString(lector.GetOrdinal("estado")),
                        });
                    }
                }
            }

            return atenciones;
        }

        public IList<ADM_ATENCION> GetAllPaging(PaginationParameter paginationParameters)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_ATENCION_ResponseGetAllActives> GetAtencionAllFilters(int idPaciente)
        {
            List<ADM_ATENCION_ResponseGetAllActives> atenciones = new List<ADM_ATENCION_ResponseGetAllActives>();
            using (var comando = _database.GetStoredProcCommand(string.Format("{0}{1}", ConectionStringRepository.EsquemaName, "p_ADM_ATENCION_GetAllFilter")))
            {
                _database.AddInParameter(comando, "@id_paciente", DbType.Int32, idPaciente);

                using (var lector = _database.ExecuteReader(comando))
                {
                    while (lector.Read())
                    {
                        atenciones.Add(new ADM_ATENCION_ResponseGetAllActives
                        {
                            id_atencion = lector.IsDBNull(lector.GetOrdinal("id_atencion")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_atencion")),
                            d_fecha_registro = lector.IsDBNull(lector.GetOrdinal("d_fecha_registro")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("d_fecha_registro")),
                            c_hora_registro = lector.IsDBNull(lector.GetOrdinal("c_hora_registro")) ? default(string) : lector.GetString(lector.GetOrdinal("c_hora_registro")),
                            HClinica = lector.IsDBNull(lector.GetOrdinal("HClinica")) ? default(string) : lector.GetString(lector.GetOrdinal("HClinica")),
                            Paciente = lector.IsDBNull(lector.GetOrdinal("Paciente")) ? default(string) : lector.GetString(lector.GetOrdinal("Paciente")),
                            Garante = lector.IsDBNull(lector.GetOrdinal("Garante")) ? default(string) : lector.GetString(lector.GetOrdinal("Garante")),
                            Prestacion = lector.IsDBNull(lector.GetOrdinal("Prestacion")) ? default(string) : lector.GetString(lector.GetOrdinal("Prestacion")),
                            TAtencion = lector.IsDBNull(lector.GetOrdinal("TAtencion")) ? default(string) : lector.GetString(lector.GetOrdinal("TAtencion")),
                            TPaciente = lector.IsDBNull(lector.GetOrdinal("TPaciente")) ? default(string) : lector.GetString(lector.GetOrdinal("TPaciente")),
                            Estado = lector.IsDBNull(lector.GetOrdinal("Estado")) ? default(string) : lector.GetString(lector.GetOrdinal("Estado")),
                        });
                    }
                }
            }

            return atenciones;
        }

        public IList<ADM_ATENCION> GetById(ADM_ATENCION entity)
        {
            throw new NotImplementedException();
        }

        public int Update(ADM_ATENCION entity)
        {
            throw new NotImplementedException();
        }

    }
}
