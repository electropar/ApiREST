using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Webapi.Models
{
    public class oportunidadModel
    {
       
        public string idOportunidad { get; set; }
        public string nombreOportunidad { get; set; }
        public string nombreCliente { get; set; }
        public string codigoSAPCliente { get; set; }
        public string idPropietario { get; set; }
        public string Propietario { get; set; }
        public string Fase { get; set; }
        public string ImporteOPN { get; set; }
        public string MonedaOPN { get; set; }
        public DateTime FechaCierre { get; set; }
        public string descripcion { get; set; }
        public string motivoPerdio { get; set; }
        

}
}