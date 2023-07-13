using System.Collections;
using System.Web.Http;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using System;

namespace Webapi.Controllers
{
    public class DocumentosController : ApiController
    {
        [HttpPost]
        public String Post([FromBody] Models.documentoFilter model)
        {
            Models.ABM consulta = new Models.ABM();

            DataTable dt = new DataTable();

            //licitacion_ID = "5074461000022319047";

            /*crea un registro en el LOG*/
            consulta.insertar("  declare @codigo integer " +
                              "  set @codigo = isnull((select MAX(docentry) from ELECTROPARAD.dbo.LOG_MAILING),0) + 1 " +
                              "  insert into ELECTROPARAD.dbo.LOG_MAILING (docentry,fecha,proceso,nota) values (@codigo, getdate(),'ZOHO REST DOC','" + model.id + "') ");

            if(model.tipo.Equals("LC"))
            {
                dt = consulta.consultar2(
                                        "select 'Oferta' as Documento, " +
                                        "CASE when t0.CANCELED = 'Y' then 'Cancelado' when t0.DocStatus = 'O' then 'Abierto' when t0.DocStatus = 'C' then 'Cerrado' END as Estado, " +
                                        "CONVERT(VARCHAR(10), t0.DocDate, 103) as Fecha, " +
                                        "t0.DocNum as [Número], " +
                                        "t0.CardCode as Cliente, " +
                                        "t0.CardName as Nombre, " +
                                        "t0.DocCur as Moneda, " +
                                        "CASE when t0.DocCur = 'GS' then t0.DocTotal else t0.DocTotalFC end  as Monto " +
                                        "from OQUT t0 with(nolock) " +
                                        "where ISNULL(t0.U_licitacion_ZOHO, '') <> '' " +
                                        "and (select l.U_idLicitacion from [@LICITACION_ZOHO] l where l.Code = t0.U_licitacion_ZOHO) = '" + model.id + "' " +
                                        " " +
                                        "union all " +
                                        " " +
                                        "select 'Pedido' as Documento, " +
                                        "CASE when t0.CANCELED = 'Y' then 'Cancelado' when t0.DocStatus = 'O' then 'Abierto' when t0.DocStatus = 'C' then 'Cerrado' END as Estado, " +
                                        "CONVERT(VARCHAR(10), t0.DocDate, 103) as Fecha, " +
                                        "t0.DocNum as [Número], " +
                                        "t0.CardCode as Cliente, " +
                                        "t0.CardName as Nombre, " +
                                        "t0.DocCur as Moneda, " +
                                        "CASE when t0.DocCur = 'GS' then t0.DocTotal else t0.DocTotalFC end  as Monto " +
                                        "from ORDR t0 with(nolock) " +
                                        "where ISNULL(t0.U_licitacion_ZOHO, '') <> '' " +
                                        "and (select l.U_idLicitacion from [@LICITACION_ZOHO] l where l.Code = t0.U_licitacion_ZOHO) = '" + model.id + "' " +
                                        " " +
                                        "union all " +
                                        " " +
                                        "select 'Remisión' as Documento, " +
                                        "CASE when t0.CANCELED = 'Y' then 'Cancelado' when t0.DocStatus = 'O' then 'Abierto' when t0.DocStatus = 'C' then 'Cerrado' END as Estado, " +
                                        "CONVERT(VARCHAR(10), t0.DocDate, 103) as Fecha, " +
                                        "t0.DocNum as [Número], " +
                                        "t0.CardCode as Cliente, " +
                                        "t0.CardName as Nombre, " +
                                        "t0.DocCur as Moneda, " +
                                        "CASE when t0.DocCur = 'GS' then t0.DocTotal else t0.DocTotalFC end  as Monto " +
                                        "from ODLN t0 with(nolock) " +
                                        "where ISNULL(t0.U_licitacion_ZOHO, '') <> '' " +
                                        "and (select l.U_idLicitacion from [@LICITACION_ZOHO] l where l.Code = t0.U_licitacion_ZOHO) = '" + model.id + "' " +
                                        " " +
                                        "union all " +
                                        " " +
                                        "select 'Devolución' as Documento, " +
                                        "CASE when t0.CANCELED = 'Y' then 'Cancelado' when t0.DocStatus = 'O' then 'Abierto' when t0.DocStatus = 'C' then 'Cerrado' END as Estado, " +
                                        "CONVERT(VARCHAR(10), t0.DocDate, 103) as Fecha, " +
                                        "t0.DocNum as [Número], " +
                                        "t0.CardCode as Cliente, " +
                                        "t0.CardName as Nombre, " +
                                        "t0.DocCur as Moneda, " +
                                        "CASE when t0.DocCur = 'GS' then t0.DocTotal else t0.DocTotalFC end  as Monto " +
                                        "from ORDN t0 with(nolock) " +
                                        "where ISNULL(t0.U_licitacion_ZOHO, '') <> '' " +
                                        "and (select l.U_idLicitacion from [@LICITACION_ZOHO] l where l.Code = t0.U_licitacion_ZOHO) = '" + model.id + "' " +
                                        " " +
                                        "union all " +
                                        " " +
                                        "select 'Factura' as Documento, " +
                                        "CASE when t0.CANCELED = 'Y' then 'Cancelado' when t0.DocStatus = 'O' then 'Abierto' when t0.DocStatus = 'C' then 'Cerrado' END as Estado, " +
                                        "CONVERT(VARCHAR(10), t0.DocDate, 103) as Fecha, " +
                                        "t0.DocNum as [Número], " +
                                        "t0.CardCode as Cliente, " +
                                        "t0.CardName as Nombre, " +
                                        "t0.DocCur as Moneda, " +
                                        "CASE when t0.DocCur = 'GS' then t0.DocTotal else t0.DocTotalFC end  as Monto " +
                                        "from OINV t0 with(nolock) " +
                                        "where ISNULL(t0.U_licitacion_ZOHO, '') <> '' " +
                                        "and (select l.U_idLicitacion from [@LICITACION_ZOHO] l where l.Code = t0.U_licitacion_ZOHO) = '" + model.id + "' " +
                                        " " +
                                        "union all " +
                                        " " +
                                        "select 'Nota de Crédito' as Documento, " +
                                        "CASE when t0.CANCELED = 'Y' then 'Cancelado' when t0.DocStatus = 'O' then 'Abierto' when t0.DocStatus = 'C' then 'Cerrado' END as Estado, " +
                                        "CONVERT(VARCHAR(10), t0.DocDate, 103) as Fecha, " +
                                        "t0.DocNum as [Número], " +
                                        "t0.CardCode as Cliente, " +
                                        "t0.CardName as Nombre, " +
                                        "t0.DocCur as Moneda, " +
                                        "CASE when t0.DocCur = 'GS' then t0.DocTotal else t0.DocTotalFC end  as Monto " +
                                        "from ORIN t0 with(nolock) " +
                                        "where ISNULL(t0.U_licitacion_ZOHO, '') <> '' " +
                                        "and (select l.U_idLicitacion from [@LICITACION_ZOHO] l where l.Code = t0.U_licitacion_ZOHO) = '" + model.id + "' ");
            }
            else if (model.tipo.Equals("OP"))
            {
                dt = consulta.consultar2(
                                        "select 'Oferta' as Documento, " +
                                        "CASE when t0.CANCELED = 'Y' then 'Cancelado' when t0.DocStatus = 'O' then 'Abierto' when t0.DocStatus = 'C' then 'Cerrado' END as Estado, " +
                                        "CONVERT(VARCHAR(10), t0.DocDate, 103) as Fecha, " +
                                        "t0.DocNum as [Número], " +
                                        "t0.CardCode as Cliente, " +
                                        "t0.CardName as Nombre, " +
                                        "t0.DocCur as Moneda, " +
                                        "CASE when t0.DocCur = 'GS' then t0.DocTotal else t0.DocTotalFC end  as Monto " +
                                        "from OQUT t0 with(nolock) " +
                                        "inner join OOPR t1 on t1.OpprId = t0.U_opprId " +
                                        "where t1.U_zoho_ID = '" + model.id + "' " +
                                        " " +
                                        "union all " +
                                        " " +
                                        "select 'Pedido' as Documento, " +
                                        "CASE when t0.CANCELED = 'Y' then 'Cancelado' when t0.DocStatus = 'O' then 'Abierto' when t0.DocStatus = 'C' then 'Cerrado' END as Estado, " +
                                        "CONVERT(VARCHAR(10), t0.DocDate, 103) as Fecha, " +
                                        "t0.DocNum as [Número], " +
                                        "t0.CardCode as Cliente, " +
                                        "t0.CardName as Nombre, " +
                                        "t0.DocCur as Moneda, " +
                                        "CASE when t0.DocCur = 'GS' then t0.DocTotal else t0.DocTotalFC end  as Monto " +
                                        "from ORDR t0 with(nolock) " +
                                        "inner join OOPR t1 on t1.OpprId = t0.U_opprId " +
                                        "where t1.U_zoho_ID = '" + model.id + "' " +
                                        " " +
                                        "union all " +
                                        " " +
                                        "select 'Remisión' as Documento, " +
                                        "CASE when t0.CANCELED = 'Y' then 'Cancelado' when t0.DocStatus = 'O' then 'Abierto' when t0.DocStatus = 'C' then 'Cerrado' END as Estado, " +
                                        "CONVERT(VARCHAR(10), t0.DocDate, 103) as Fecha, " +
                                        "t0.DocNum as [Número], " +
                                        "t0.CardCode as Cliente, " +
                                        "t0.CardName as Nombre, " +
                                        "t0.DocCur as Moneda, " +
                                        "CASE when t0.DocCur = 'GS' then t0.DocTotal else t0.DocTotalFC end  as Monto " +
                                        "from ODLN t0 with(nolock) " +
                                        "inner join OOPR t1 on t1.OpprId = t0.U_opprId " +
                                        "where t1.U_zoho_ID = '" + model.id + "' " +
                                        " " +
                                        "union all " +
                                        " " +
                                        "select 'Devolución' as Documento, " +
                                        "CASE when t0.CANCELED = 'Y' then 'Cancelado' when t0.DocStatus = 'O' then 'Abierto' when t0.DocStatus = 'C' then 'Cerrado' END as Estado, " +
                                        "CONVERT(VARCHAR(10), t0.DocDate, 103) as Fecha, " +
                                        "t0.DocNum as [Número], " +
                                        "t0.CardCode as Cliente, " +
                                        "t0.CardName as Nombre, " +
                                        "t0.DocCur as Moneda, " +
                                        "CASE when t0.DocCur = 'GS' then t0.DocTotal else t0.DocTotalFC end  as Monto " +
                                        "from ORDN t0 with(nolock) " +
                                        "inner join OOPR t1 on t1.OpprId = t0.U_opprId " +
                                        "where t1.U_zoho_ID = '" + model.id + "' " +
                                        " " +
                                        "union all " +
                                        " " +
                                        "select 'Factura' as Documento, " +
                                        "CASE when t0.CANCELED = 'Y' then 'Cancelado' when t0.DocStatus = 'O' then 'Abierto' when t0.DocStatus = 'C' then 'Cerrado' END as Estado, " +
                                        "CONVERT(VARCHAR(10), t0.DocDate, 103) as Fecha, " +
                                        "t0.DocNum as [Número], " +
                                        "t0.CardCode as Cliente, " +
                                        "t0.CardName as Nombre, " +
                                        "t0.DocCur as Moneda, " +
                                        "CASE when t0.DocCur = 'GS' then t0.DocTotal else t0.DocTotalFC end  as Monto " +
                                        "from OINV t0 with(nolock) " +
                                        "inner join OOPR t1 on t1.OpprId = t0.U_opprId " +
                                        "where t1.U_zoho_ID = '" + model.id + "' " +
                                        " " +
                                        "union all " +
                                        " " +
                                        "select 'Nota de Crédito' as Documento, " +
                                        "CASE when t0.CANCELED = 'Y' then 'Cancelado' when t0.DocStatus = 'O' then 'Abierto' when t0.DocStatus = 'C' then 'Cerrado' END as Estado, " +
                                        "CONVERT(VARCHAR(10), t0.DocDate, 103) as Fecha, " +
                                        "t0.DocNum as [Número], " +
                                        "t0.CardCode as Cliente, " +
                                        "t0.CardName as Nombre, " +
                                        "t0.DocCur as Moneda, " +
                                        "CASE when t0.DocCur = 'GS' then t0.DocTotal else t0.DocTotalFC end  as Monto " +
                                        "from ORIN t0 with(nolock) " +
                                        "inner join OOPR t1 on t1.OpprId = t0.U_opprId " +
                                        "where t1.U_zoho_ID = '" + model.id + "' ");
            }

                return consulta.DataTableToJSONWithStringBuilder(dt);
        }
    }
}