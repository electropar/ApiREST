using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using AccesoDatos;

namespace Webapi.Controllers
{
    public class LicitacionController : ApiController
    {
        private ELECTROPAREntities dbcontext = new ELECTROPAREntities();
       
        [HttpGet]
        public IEnumerable<C_LICITACION_ZOHO> Get()
        {
            using (ELECTROPAREntities licitacion  = new ELECTROPAREntities())
            {
              
                 return licitacion.C_LICITACION_ZOHO.ToList();
            }
         }

        [HttpPost]
        public Models.licitacionprueba Post ([FromBody] Models.licitacionprueba model) {
            Models.licitacionABM liciabm = new Models.licitacionABM();
            liciabm.insertar("  declare @codigo integer " +
                             "  set @codigo = isnull((select MAX(docentry) from ELECTROPARAD.dbo.LOG_MAILING),0) + 1 " +
                             "  insert into ELECTROPARAD.dbo.LOG_MAILING (docentry,fecha,proceso,nota) values (@codigo, getdate(),'ZOHO REST LIC','" +  model.idLicitacion + "') ");

            liciabm.insertar("  if (select count(code) from[@LICITACION_ZOHO] where U_idLicitacion = '" + model.idLicitacion +"') > 0 " +
                             "  begin " +
                             "      update[@LICITACION_ZOHO] set U_tipoLicitacion = '" + model.tipoLicitacion + "', " +
                             "      U_nombreLicitacion = upper(cast('" + model.nombreLicitacion + "'as varchar(max))), " +
                             "      U_codigoEntidadSAP = '" + model.entidadCodigoSAP + "', " +
                             "      U_nombreEntidad = '"  + model.nombreEntidad + "', " +
                             "      U_montoReferencial = '"+ model.montoReferencial +"', " +
                             "      U_moneda = '" + model.monedaLicitacion +"', " +
                             "      U_actualizado = getdate() " +
                             "      where U_idLicitacion = '"+ model.idLicitacion + "' " +
                             "  end " +
                             "  else " +
                             "  begin " +
                             "      declare @codigo integer " +
                             "      set @codigo = isnull((select max(cast(code as int)) from [@LICITACION_ZOHO]),0) + 1 " +
                             "      insert into[@LICITACION_ZOHO] (code, name, U_idLicitacion, U_tipoLicitacion, U_nombreLicitacion, U_codigoEntidadSAP, U_nombreEntidad, U_montoReferencial, U_moneda, U_registro) " +
                             "      values(@codigo, @codigo, '"+ model.idLicitacion + "', '" + model.tipoLicitacion + "', upper(cast('" + model.nombreLicitacion + "' as varchar(max))) , '" + model.entidadCodigoSAP +"', '"+model.nombreEntidad +"', '"+ model.montoReferencial +"', '"+ model.monedaLicitacion +"', getdate()) " +
                             "  end");
            return model;
            
        }
        /*public IHttpActionResult AgregarLicitacion (string idLicitacion,
                                                    string nombreLicitacion,
                                                    string divisionLicitacion,
                                                    string entidadLicitacion,
                                                    string entidadCodigoSAP)
        {
            return Ok(idLicitacion);

            //Models.licitacionABM liciabm =  new Models.licitacionABM();

            //if (ModelState.IsValid)
            //{
            //    /* dbcontext.C_LICITACION_ZOHO.Add(lici);
            //     dbcontext.SaveChanges();*/
            //    Models.licitacion licita = JsonConvert.DeserializeObject<Models.licitacion>(idLicitacion);
               

            //    liciabm.insertar("declare @codigo integer set @codigo = isnull((select MAX(docentry) from ELECTROPARAD.dbo.LOG_MAILING),0) + 1 insert into ELECTROPARAD.dbo.LOG_MAILING (docentry,fecha,proceso,nota) values (@codigo, getdate(),'ZOHO REST','" + idLicitacion + "') ");

            //    return Ok(idLicitacion);
            //}
            //else
            //{
            //    liciabm.insertar("declare @codigo integer set @codigo = isnull((select MAX(docentry) from ELECTROPARAD.dbo.LOG_MAILING),0) + 1 insert into ELECTROPARAD.dbo.LOG_MAILING (docentry,fecha,proceso,nota) values (@codigo, getdate(),'ZOHO REST','" + idLicitacion + "') ");
            //    return BadRequest();
            //}
        //}
    }

}

