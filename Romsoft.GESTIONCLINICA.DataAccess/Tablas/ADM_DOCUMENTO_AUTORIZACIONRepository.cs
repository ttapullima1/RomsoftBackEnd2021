using Microsoft.Practices.EnterpriseLibrary.Data;
using Romsoft.GESTIONCLINICA.Common;
using Romsoft.GESTIONCLINICA.Common.Generics;
using Romsoft.GESTIONCLINICA.DataAccess.Core;
using Romsoft.GESTIONCLINICA.DataAccess.Interfaces.IADM_DOCUMENTO_AUTORIZACIONRepository;
using Romsoft.GESTIONCLINICA.Entidades.ADM_DOCUMENTO_AUTORIZACION;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;


namespace Romsoft.GESTIONCLINICA.DataAccess.Tablas
{
    public class ADM_DOCUMENTO_AUTORIZACIONRepository : Singleton<ADM_DOCUMENTO_AUTORIZACIONRepository>, IADM_DOCUMENTO_AUTORIZACIONRepository<ADM_DOCUMENTO_AUTORIZACION>
    {
        private readonly Database _database = new DatabaseProviderFactory().Create(ConectionStringRepository.ConnectionStringNameSQL);
        public int Add(ADM_DOCUMENTO_AUTORIZACION entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(ADM_DOCUMENTO_AUTORIZACION entity)
        {
            throw new NotImplementedException();
        }

        public bool Exists(ADM_DOCUMENTO_AUTORIZACION entity)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_DOCUMENTO_AUTORIZACION> GetAll(string whereFilters)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_DOCUMENTO_AUTORIZACION> GetAllActives()
        {
            throw new NotImplementedException();
        }

        public IList<ADM_DOCUMENTO_AUTORIZACION> GetAllFilters(ADM_DOCUMENTO_AUTORIZACION entity)
        {
            string SQL = "SELECT Dg.CO_IAFASCODE AS COD_IAFA, Dg.CO_ASEGCODE AS COD_ASEGURADO, Dg.CO_AUTOCODE AS COD_AUTORIZACION, Dg.FE_AUTODATE AS FEC_AUTORIZACION, Dg.CO_IPRESSCODE AS COD_IPRESS, Dg.DE_IPRESSRUC AS RUC_IPRESS,";
            SQL = SQL + "Dg.AP_ASEGAPAT + ' ' + Dg.AP_ASEGAMAT + ' ' + Dg.NO_ASEGNAME as PACIENTE,Dg.CO_GECODE AS SEXO,Dg.FE_NACMDATE AS FEC_NACIMIENTO, Dg.CO_DNICODE AS COD_DOCUMENTO,Dg.NO_DNINAME AS NUM_DOCUMENTO,";
            SQL = SQL + "Dg.NU_EDADNUM AS NUM_EDAD, Dg.AP_ASEGAPAT AS AP_PATERNO, Dg.AP_ASEGAMAT AS AP_MATERNO, Dg.NO_ASEGNAME AS NOMBRES, Dg.CO_TITUCODE AS COD_ASEGURADO_TITULAR,Dg.AP_TITUAPAT+ ' ' + Dg.AP_TITUAMAT + ' '+ Dg.NO_TITUNAME AS TITULAR,  ";
            SQL = SQL + "Dg.CO_DNITITULAR AS COD_DOCUMENTO_TITULAR,Dg.NU_DNITITULAR AS NUM_DOCUMENTO_TITULAR,Dg.CO_FILIACODE AS COD_TIPO_FILIACION,SSTM_TIPO_FILIACION.NO_NAMEFILIACION AS DES_TIPO_FILIACION, Co.CO_COBERCODE AS COD_COBERTURA, ";
            SQL = SQL + "Co.CO_SUBTIPOCOBER AS COD_SUBCOBERTURA,Co.NO_SUBTIPOCOBER AS DES_BENEFICIO,Co.CO_PRODCODE AS COD_PRODUCTO,PR.NO_PRODNAME AS DES_PRODUCTO,Dg.CO_TIPOPLAN AS COD_TIPOPLAN,SSTM_TIPO_PLAN.NO_TIPOPLAN AS DES_TIPOPLAN, ";
            SQL = SQL + "Dg.CO_AFICODE AS COD_TIPO_AFILIACION,SSTM_TIPO_AFILIACION.NO_AFINAME AS DES_TIPO_AFILIACION, Dg.NU_POLIZA AS NUM_POLIZA,Dg.NU_ASEGPLAN AS NUM_PLAN, Dg.CO_CNTRTIPODOC AS COD_CONTRATANTE, SSTM_TIPO_DOCUMENTO.DE_NOMCORTO AS COD_CONTRATANTE_ABR, ";
            SQL = SQL + "Dg.DE_CNTRRUC AS NUM_CONTRATANTE, Dg.DE_CNTRNAME AS DES_CONTRATANTE, Dg.FE_INIVIGDATE AS FEC_INICIO_VIGENCIA,Dg.FE_FINVIGDATE AS FEC_FIN_VIGENCIA,Dg.FE_INCLDATE, Co.CO_MONECODE AS COD_MONEDA,Co.NU_COPGFIJO AS NUM_COPAGO_FIJO, ";
            SQL = SQL + "Co.NU_COPGVARI AS NUM_COPAGO_VARIABLE, Co.CO_CALIFSERVCODE AS COD_SERVICIO, Co.DE_IPSSHOST AS NUM_IP ";
            SQL = SQL + "FROM ((((((SSTC_DATOSGENERALES Dg INNER JOIN SSTD_COBERTURA_ACRED Co ON Dg.CO_AUTOCODE = Co.CO_AUTOCODE AND Dg.CO_ASEGCODE = Co.CO_ASEGCODE AND Dg.CO_IAFASCODE = Co.CO_IAFASCODE) ";
            SQL = SQL + "LEFT OUTER JOIN SSTM_TIPO_FILIACION ON Dg.CO_FILIACODE = SSTM_TIPO_FILIACION.CO_FILIACIONCODE) ";
            SQL = SQL + "LEFT OUTER JOIN SSTM_TIPO_AFILIACION ON Dg.CO_AFICODE = SSTM_TIPO_AFILIACION.CO_AFICODE) ";
            SQL = SQL + "LEFT OUTER JOIN SSTM_TIPO_PLAN ON Dg.CO_TIPOPLAN = SSTM_TIPO_PLAN.CO_TIPOPLAN) ";
            SQL = SQL + "LEFT OUTER JOIN SSTM_TIPO_DOCUMENTO ON Dg.CO_CNTRTIPODOC = SSTM_TIPO_DOCUMENTO.CO_DNICODE)  ";
            SQL = SQL + "LEFT OUTER JOIN SSTM_PRODUCTO PR ON Co.CO_PRODCODE = PR.CO_PRODCODE AND Co.CO_IAFASCODE = PR.CO_IAFACODE) ";
            SQL = SQL + "WHERE (LEFT(Dg.DE_FOTORUTA, 3) <> 'REV') AND(Dg.CO_IAFASCODE IS NOT NULL) AND(Dg.CO_ASEGCODE IS NOT NULL) AND (Dg.CO_AUTOCODE IS NOT NULL) AND (PR.DE_ESTADO = '1')   AND Dg.CO_AUTOCODE='";
            SQL = SQL + entity.COD_AUTORIZACION + "'";
            List<ADM_DOCUMENTO_AUTORIZACION> siteds = new List<ADM_DOCUMENTO_AUTORIZACION>();
            OleDbConnection conexion;
            //conexion = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\\SUSALUD\\IPRESSLOG.mdb");
            conexion = new OleDbConnection(ConectionStringRepository.ConnectionStringACCESS);

            conexion.Open();
            OleDbCommand comando = new OleDbCommand(SQL, conexion);
            OleDbDataReader lectorDatos;
            lectorDatos = comando.ExecuteReader();
            Boolean existeRegistre = lectorDatos.HasRows;
            while (lectorDatos.Read())
            {
                siteds.Add(new ADM_DOCUMENTO_AUTORIZACION
                {
                    COD_IAFA = lectorDatos.IsDBNull(lectorDatos.GetOrdinal("COD_IAFA")) ? default(string) : lectorDatos.GetString(lectorDatos.GetOrdinal("COD_IAFA")),
                    COD_ASEGURADO = lectorDatos.IsDBNull(lectorDatos.GetOrdinal("COD_ASEGURADO")) ? default(string) : lectorDatos.GetString(lectorDatos.GetOrdinal("COD_ASEGURADO")),
                    COD_AUTORIZACION = lectorDatos.IsDBNull(lectorDatos.GetOrdinal("COD_AUTORIZACION")) ? default(string) : lectorDatos.GetString(lectorDatos.GetOrdinal("COD_AUTORIZACION")),
                    FEC_AUTORIZACION = lectorDatos.IsDBNull(lectorDatos.GetOrdinal("FEC_AUTORIZACION")) ? default(DateTime) : lectorDatos.GetDateTime(lectorDatos.GetOrdinal("FEC_AUTORIZACION")),
                    COD_IPRESS = lectorDatos.IsDBNull(lectorDatos.GetOrdinal("COD_IPRESS")) ? default(string) : lectorDatos.GetString(lectorDatos.GetOrdinal("COD_IPRESS")).ToString(),
                    RUC_IPRESS = lectorDatos.IsDBNull(lectorDatos.GetOrdinal("RUC_IPRESS")) ? default(string) : lectorDatos.GetString(lectorDatos.GetOrdinal("RUC_IPRESS")),
                    PACIENTE = lectorDatos.IsDBNull(lectorDatos.GetOrdinal("PACIENTE")) ? default(string) : lectorDatos.GetString(lectorDatos.GetOrdinal("PACIENTE")),
                    SEXO = "1", //lectorDatos.IsDBNull(lectorDatos.GetOrdinal("SEXO")) ? default(string) : lectorDatos.GetString(lectorDatos.GetOrdinal("SEXO")),
                    FEC_NACIMIENTO = lectorDatos.IsDBNull(lectorDatos.GetOrdinal("FEC_NACIMIENTO")) ? default(DateTime) : lectorDatos.GetDateTime(lectorDatos.GetOrdinal("FEC_NACIMIENTO")),
                    COD_DOCUMENTO = lectorDatos.IsDBNull(lectorDatos.GetOrdinal("COD_DOCUMENTO")) ? default(string) : lectorDatos.GetString(lectorDatos.GetOrdinal("COD_DOCUMENTO")),
                    NUM_DOCUMENTO = lectorDatos.IsDBNull(lectorDatos.GetOrdinal("NUM_DOCUMENTO")) ? default(string) : lectorDatos.GetString(lectorDatos.GetOrdinal("NUM_DOCUMENTO")),
                    NUM_EDAD = "0",//lectorDatos.IsDBNull(lectorDatos.GetOrdinal("NUM_EDAD")) ? default(string) : lectorDatos.GetString(lectorDatos.GetOrdinal("NUM_EDAD")).ToString(),
                    AP_PATERNO = lectorDatos.IsDBNull(lectorDatos.GetOrdinal("AP_PATERNO")) ? default(string) : lectorDatos.GetString(lectorDatos.GetOrdinal("AP_PATERNO")),
                    AP_MATERNO = lectorDatos.IsDBNull(lectorDatos.GetOrdinal("AP_MATERNO")) ? default(string) : lectorDatos.GetString(lectorDatos.GetOrdinal("AP_MATERNO")),
                    NOMBRES = lectorDatos.IsDBNull(lectorDatos.GetOrdinal("NOMBRES")) ? default(string) : lectorDatos.GetString(lectorDatos.GetOrdinal("NOMBRES")),
                    COD_ASEGURADO_TITULAR = lectorDatos.IsDBNull(lectorDatos.GetOrdinal("COD_ASEGURADO_TITULAR")) ? default(string) : lectorDatos.GetString(lectorDatos.GetOrdinal("COD_ASEGURADO_TITULAR")),
                    TITULAR = lectorDatos.IsDBNull(lectorDatos.GetOrdinal("TITULAR")) ? default(string) : lectorDatos.GetString(lectorDatos.GetOrdinal("TITULAR")),
                    COD_DOCUMENTO_TITULAR = lectorDatos.IsDBNull(lectorDatos.GetOrdinal("COD_DOCUMENTO_TITULAR")) ? default(string) : lectorDatos.GetString(lectorDatos.GetOrdinal("COD_DOCUMENTO_TITULAR")),
                    NUM_DOCUMENTO_TITULAR = lectorDatos.IsDBNull(lectorDatos.GetOrdinal("NUM_DOCUMENTO_TITULAR")) ? default(string) : lectorDatos.GetString(lectorDatos.GetOrdinal("NUM_DOCUMENTO_TITULAR")),
                    COD_TIPO_FILIACION = lectorDatos.IsDBNull(lectorDatos.GetOrdinal("COD_TIPO_FILIACION")) ? default(string) : lectorDatos.GetString(lectorDatos.GetOrdinal("COD_TIPO_FILIACION")),
                    DES_TIPO_FILIACION = lectorDatos.IsDBNull(lectorDatos.GetOrdinal("DES_TIPO_FILIACION")) ? default(string) : lectorDatos.GetString(lectorDatos.GetOrdinal("DES_TIPO_FILIACION")),
                    COD_COBERTURA = lectorDatos.IsDBNull(lectorDatos.GetOrdinal("COD_COBERTURA")) ? default(string) : lectorDatos.GetString(lectorDatos.GetOrdinal("COD_COBERTURA")),
                    COD_SUBCOBERTURA = lectorDatos.IsDBNull(lectorDatos.GetOrdinal("COD_SUBCOBERTURA")) ? default(string) : lectorDatos.GetString(lectorDatos.GetOrdinal("COD_SUBCOBERTURA")),
                    DES_BENEFICIO = lectorDatos.IsDBNull(lectorDatos.GetOrdinal("DES_BENEFICIO")) ? default(string) : lectorDatos.GetString(lectorDatos.GetOrdinal("DES_BENEFICIO")),
                    COD_PRODUCTO = lectorDatos.IsDBNull(lectorDatos.GetOrdinal("COD_PRODUCTO")) ? default(string) : lectorDatos.GetString(lectorDatos.GetOrdinal("COD_PRODUCTO")),
                    DES_PRODUCTO = lectorDatos.IsDBNull(lectorDatos.GetOrdinal("DES_PRODUCTO")) ? default(string) : lectorDatos.GetString(lectorDatos.GetOrdinal("DES_PRODUCTO")),
                    COD_TIPOPLAN = lectorDatos.IsDBNull(lectorDatos.GetOrdinal("COD_TIPOPLAN")) ? default(string) : lectorDatos.GetString(lectorDatos.GetOrdinal("COD_TIPOPLAN")),
                    DES_TIPOPLAN = lectorDatos.IsDBNull(lectorDatos.GetOrdinal("DES_TIPOPLAN")) ? default(string) : lectorDatos.GetString(lectorDatos.GetOrdinal("DES_TIPOPLAN")),
                    COD_TIPO_AFILIACION = lectorDatos.IsDBNull(lectorDatos.GetOrdinal("COD_TIPO_AFILIACION")) ? default(string) : lectorDatos.GetString(lectorDatos.GetOrdinal("COD_TIPO_AFILIACION")),
                    DES_TIPO_AFILIACION = lectorDatos.IsDBNull(lectorDatos.GetOrdinal("DES_TIPO_AFILIACION")) ? default(string) : lectorDatos.GetString(lectorDatos.GetOrdinal("DES_TIPO_AFILIACION")),
                    NUM_POLIZA = lectorDatos.IsDBNull(lectorDatos.GetOrdinal("NUM_POLIZA")) ? default(string) : lectorDatos.GetString(lectorDatos.GetOrdinal("NUM_POLIZA")),
                    NUM_PLAN = lectorDatos.IsDBNull(lectorDatos.GetOrdinal("NUM_PLAN")) ? default(string) : lectorDatos.GetString(lectorDatos.GetOrdinal("NUM_PLAN")),
                    COD_CONTRATANTE = lectorDatos.IsDBNull(lectorDatos.GetOrdinal("COD_CONTRATANTE")) ? default(string) : lectorDatos.GetString(lectorDatos.GetOrdinal("COD_CONTRATANTE")),
                    COD_CONTRATANTE_ABR = lectorDatos.IsDBNull(lectorDatos.GetOrdinal("COD_CONTRATANTE_ABR")) ? default(string) : lectorDatos.GetString(lectorDatos.GetOrdinal("COD_CONTRATANTE_ABR")),
                    NUM_CONTRATANTE = lectorDatos.IsDBNull(lectorDatos.GetOrdinal("NUM_CONTRATANTE")) ? default(string) : lectorDatos.GetString(lectorDatos.GetOrdinal("NUM_CONTRATANTE")),
                    DES_CONTRATANTE = lectorDatos.IsDBNull(lectorDatos.GetOrdinal("DES_CONTRATANTE")) ? default(string) : lectorDatos.GetString(lectorDatos.GetOrdinal("DES_CONTRATANTE")),
                    FEC_INICIO_VIGENCIA = lectorDatos.IsDBNull(lectorDatos.GetOrdinal("FEC_INICIO_VIGENCIA")) ? default(DateTime) : lectorDatos.GetDateTime(lectorDatos.GetOrdinal("FEC_INICIO_VIGENCIA")),
                    FEC_FIN_VIGENCIA = lectorDatos.IsDBNull(lectorDatos.GetOrdinal("FEC_FIN_VIGENCIA")) ? default(DateTime) : lectorDatos.GetDateTime(lectorDatos.GetOrdinal("FEC_FIN_VIGENCIA")),
                    FE_INCLDATE = lectorDatos.IsDBNull(lectorDatos.GetOrdinal("FE_INCLDATE")) ? default(DateTime) : lectorDatos.GetDateTime(lectorDatos.GetOrdinal("FE_INCLDATE")),
                    COD_MONEDA = lectorDatos.IsDBNull(lectorDatos.GetOrdinal("COD_MONEDA")) ? default(string) : lectorDatos.GetString(lectorDatos.GetOrdinal("COD_MONEDA")),
                    NUM_COPAGO_FIJO = lectorDatos.IsDBNull(lectorDatos.GetOrdinal("NUM_COPAGO_FIJO")) ? default(decimal) : lectorDatos.GetDecimal(lectorDatos.GetOrdinal("NUM_COPAGO_FIJO")),
                    NUM_COPAGO_VARIABLE = lectorDatos.IsDBNull(lectorDatos.GetOrdinal("NUM_COPAGO_VARIABLE")) ? default(decimal) : Convert.ToDecimal(lectorDatos.GetDouble(lectorDatos.GetOrdinal("NUM_COPAGO_VARIABLE"))),
                    COD_SERVICIO = lectorDatos.IsDBNull(lectorDatos.GetOrdinal("COD_SERVICIO")) ? default(string) : lectorDatos.GetString(lectorDatos.GetOrdinal("COD_SERVICIO")),
                    NUM_IP = lectorDatos.IsDBNull(lectorDatos.GetOrdinal("NUM_IP")) ? default(string) : lectorDatos.GetString(lectorDatos.GetOrdinal("NUM_IP")),
                    //f_estado = 1, //lectorDatos.IsDBNull(lectorDatos.GetOrdinal("DE_CNTRNAME")) ? default(string) : lectorDatos.GetString(lectorDatos.GetOrdinal("DE_CNTRNAME")),
                    //d_fecha_registro = lectorDatos.IsDBNull(lectorDatos.GetOrdinal("DE_CNTRNAME")) ? default(string) : lectorDatos.GetString(lectorDatos.GetOrdinal("DE_CNTRNAME")),
                    //d_fecha_modifica = lectorDatos.IsDBNull(lectorDatos.GetOrdinal("DE_CNTRNAME")) ? default(string) : lectorDatos.GetString(lectorDatos.GetOrdinal("DE_CNTRNAME")),
                    //id_user_registro = lectorDatos.IsDBNull(lectorDatos.GetOrdinal("DE_CNTRNAME")) ? default(string) : lectorDatos.GetString(lectorDatos.GetOrdinal("DE_CNTRNAME")),
                    //id_user_modifica = lectorDatos.IsDBNull(lectorDatos.GetOrdinal("DE_CNTRNAME")) ? default(string) : lectorDatos.GetString(lectorDatos.GetOrdinal("DE_CNTRNAME")),
                });
            }
            conexion.Close();
            return siteds;
        }

        public IList<ADM_DOCUMENTO_AUTORIZACION> GetAllPaging(PaginationParameter paginationParameters)
        {
            throw new NotImplementedException();
        }

        public ADM_DOCUMENTO_AUTORIZACION GetByEstado(string estadoNombre)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_DOCUMENTO_AUTORIZACION> GetById(ADM_DOCUMENTO_AUTORIZACION entity)
        {
            throw new NotImplementedException();
        }

        public int Update(ADM_DOCUMENTO_AUTORIZACION entity)
        {
            throw new NotImplementedException();
        }
    }
}
