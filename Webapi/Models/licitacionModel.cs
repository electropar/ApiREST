using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Webapi.Models
{
    public class licitacionModel
    {
        public string idLicitacion { get; set; }

        public string nombreLicitacion { get; set; }
        public string divisionLicitacion { get; set; }
        public string entidadLicitacion { get; set; }
        public string entidadCodigoSAP { get; set; }

        public string tipoLicitacion { get; set; }
        public string nombreEntidad { get; set; }
        public string montoReferencial { get; set; }
        public string monedaLicitacion { get; set; }

    }
}