using System.Web.Http;

namespace Webapi.Controllers
{
    public class OportunidadController : ApiController
    {

        [HttpPost]
        public Models.oportunidadModel Post([FromBody] Models.oportunidadModel model) {
           
            Models.ABM oporABM = new Models.ABM();

            /*crea un registro en el LOG*/
            oporABM.insertar("  declare @codigo integer " +
                             "  set @codigo = isnull((select MAX(docentry) from ELECTROPARAD.dbo.LOG_MAILING),0) + 1 " +
                             "  insert into ELECTROPARAD.dbo.LOG_MAILING (docentry,fecha,proceso,nota) values (@codigo, getdate(),'ZOHO REST OPN','" + model.idOportunidad + "') ");

            /*crea O modifica un registro*/
            oporABM.insertar("  if (select count(idoportunidad) from ELECTROPARAD.dbo.[OPN_ZOHO] where idoportunidad = '" + model.idOportunidad + "') > 0 " +
                             "  begin " +
                             "      update ELECTROPARAD.dbo.[OPN_ZOHO] " +
                             "      set nombreoportunidad = upper('" + model.nombreOportunidad + "'), " +
                             "      nombrecliente = upper('" + model.nombreCliente + "'), " +
                             "      codigosapcliente = '" + model.codigoSAPCliente + "', " +
                             "      idpropietario = '" + model.idPropietario + "', " +
                             "      propietario = '"+ model.Propietario +"', " +
                             "      fase = '" + model.Fase + "', " +
                             "      importeopn = '" + model.ImporteOPN + "', " +
                             "      monedaopn = '"+ model.MonedaOPN + "', " +
                             "      fechacierre = '"+ model.FechaCierre + "', " +
                             "      descripcion = upper('"+ model.descripcion + "'), " +
                             "      motivoperdio = '" + model.motivoPerdio + "', " +
                             "      actualizado = getdate(), " +
                             "      migrado = 0 " + 
                             "      where idoportunidad = '" + model.idOportunidad + "' " +
                             "  end " +
                             "  else " +
                             "  begin " +
                             "      declare @codigo integer set @codigo = isnull((select max(docentry) from ELECTROPARAD.dbo.[OPN_ZOHO] ),0) + 1 " +
                             "      insert into ELECTROPARAD.dbo.[OPN_ZOHO] (docentry, idoportunidad, nombreoportunidad, nombrecliente, codigosapcliente, idpropietario, propietario, fase, importeopn, monedaopn, fechacierre, descripcion, motivoperdio, fecharegistro, migrado) " +
                             "      values(@codigo, '" + model.idOportunidad + "', " +
                             "      upper('" + model.nombreOportunidad + "'), " +
                             "      upper('" + model.nombreCliente + "' ) , " +
                             "      '" + model.codigoSAPCliente + "', " +
                             "      '" + model.idPropietario + "', " +
                             "      '" + model.Propietario + "', " +
                             "      '" + model.Fase + "', " +
                             "      '"+ model.ImporteOPN +"', " +
                             "      '"+ model.MonedaOPN +"', " +
                             "      '"+ model.FechaCierre +"', " +
                             "      upper('"+ model.descripcion +"'), " +
                             "      '"+ model.motivoPerdio +"', " +
                             "      getdate(), 0) " +
                             "  end");

            return model;

        }

    }
}
